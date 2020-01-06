using Acumatica.Auth.Api;
using Acumatica.Auth.Model;
using Acumatica.DefaultEndpoint.Api;
using Acumatica.RESTClient.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Messaging;
using System.Timers;
using Newtonsoft.Json;
using erp_gateway_poc.Model;
using erp_gateway_poc.Util.MessageQueuing;

namespace erp_gateway_poc {
    class Program {

		static int messageId = 0;

		const string SiteURL = "http://localhost/AcumaticaERP";
		const string Username = "admin";
		const string Password = "******";
		const string Tenant = "SalesOrder";

		static List<string> queueNames = new List<string> {
			@".\private$\feelgoodqueue",
			@".\private$\feelbadqueue"
		};

		static void Main(string[] args) {

			/*Timer writeTimer = new Timer();
			writeTimer.Interval = 10000; // 15 seconds
			writeTimer.Elapsed += new ElapsedEventHandler(QueueWrite);
			writeTimer.Start();*/

			List<MessageQueue> queueList = ListenToQueues();
			Console.WriteLine($"Number of Queues {queueList.Count}");
			Console.ReadLine();
			CloseQueues(queueList);
			Console.ReadLine();
		}

		private static MessageQueue GetQueueReference(string queueName) {
			MessageQueue queue;
			if (!MessageQueue.Exists(queueName))
				queue = MessageQueue.Create(queueName);
			else
				queue = new MessageQueue(queueName);
			return queue;
		}


		private static List<MessageQueue> ListenToQueues() {

			List<MessageQueue> queueList = new List<MessageQueue>();

			foreach (string queueName in queueNames) {

				MessageQueue mq = GetQueueReference(queueName);

				mq.ReceiveCompleted += new ReceiveCompletedEventHandler(MyReceiveCompleted);

				mq.BeginReceive();

				Console.WriteLine($"Listening on queue: {queueName}");
				queueList.Add(mq);
			}

			return queueList;
		}

		private static void CloseQueues(List<MessageQueue> queueList) {

			foreach (MessageQueue mq in queueList) {

				Console.WriteLine($"Closing listener for queue: {mq.QueueName}");

				// Remove the event handler before closing the queue
				mq.ReceiveCompleted -= MyReceiveCompleted;
				mq.Close();
				mq.Dispose();
			}
		}

		private static void MyReceiveCompleted(Object source, ReceiveCompletedEventArgs asyncResult) {

			try {

				MessageQueue mq = (MessageQueue)source;
				//mq.Formatter = new XmlMessageFormatter(new Type[] { typeof(String) });
				Message message = mq.EndReceive(asyncResult.AsyncResult);
				PurchaseOrderNotification body = (PurchaseOrderNotification) new JsonMessageFormatter<PurchaseOrderNotification>().Read(message);
				//string jsonString = (string) new JsonMessageFormatter<string>().Read(message);
				//PurchaseOrderNotification body = JsonConvert.DeserializeObject<PurchaseOrderNotification>(jsonString);

				if (message != null) {
					//Console.WriteLine($"{message.Label}: {message.Body} from queue: {mq.QueueName}");
					Console.WriteLine($"from queue: {mq.QueueName}\n");
					if(body.Inserted.Count > 0) {
						Console.WriteLine(body.Inserted[0].OrderNbr);
						Console.WriteLine(body.Inserted[0].Status);
						Console.WriteLine(body.Inserted[0].LastModifiedDateTime);
					}
					if (body.Deleted.Count > 0) {
						Console.WriteLine(body.Deleted[0].OrderNbr);
						Console.WriteLine(body.Deleted[0].Status);
						Console.WriteLine(body.Deleted[0].LastModifiedDateTime);
					}
					Console.WriteLine(body.Query);
					Console.WriteLine(body.CompanyId);
					Console.WriteLine(body.Id);
					Console.WriteLine(body.TimeStamp);
				}

				mq.BeginReceive();
			}
			catch (MessageQueueException ex) {

				Console.WriteLine(ex.Message);
			}

			return;
		}

		public static void QueueWrite(Object sender, ElapsedEventArgs args) {
			try {

				MessageQueue goodQueue = GetQueueReference(@".\private$\feelgoodqueue");
				Console.WriteLine($"Sending message for {messageId} to queue {goodQueue.QueueName}");
				goodQueue.Send($"Message for the queue for message #{messageId}", $"Message {messageId}");

				MessageQueue badQueue = GetQueueReference(@".\private$\feelbadqueue");
				Console.WriteLine($"Sending message for {messageId} to queue {badQueue.QueueName}");
				badQueue.Send($"Message for the queue for message #{messageId}", $"Message {messageId}");

				messageId++;
			}

			catch (MessageQueueException ex) {

				Console.WriteLine(ex.Message);

			}
		}

		// Code from RestAPI client, just keeping it here for reference for a bit

		private static void basicStuff() {
			var authApi = new AuthApi(SiteURL);
			var cookieContainer = new CookieContainer();
			authApi.Configuration.ApiClient.RestClient.CookieContainer = cookieContainer;
			try {
				LogIn(authApi);

				var soApi = new SalesOrderApi();
				Console.WriteLine("Reading Sales Orders...");

				var soOrders = soApi.SalesOrderGetList(top: 5);

				foreach (var order in soOrders) {
					Console.WriteLine("Order Type: " + order.OrderType.Value + "; Order Number: " + order.OrderNbr.Value);
				}
			}
			catch (Exception e) {
				Console.WriteLine(e.Message);
			}
			finally {
				//we use logout in finally block because we need to always logut, even if the request failed for some reason
				authApi.AuthLogout();
				Console.WriteLine("Logged Out...");
			}
			Console.ReadLine();
		}

		private static void LogIn(AuthApi authApi) {
			authApi.AuthLogin(new Credentials(Username, Password, Tenant));
			Console.WriteLine("Logged In...");
			Configuration.Default = new Configuration(Default._18._200._001.EndpointHelper.CombineEndpointURL(SiteURL));

			//share cookie container between API clients because we use different client for authentication and interaction with endpoint
			Configuration.Default.ApiClient.RestClient.CookieContainer = authApi.Configuration.ApiClient.RestClient.CookieContainer;
		}

	}
}
