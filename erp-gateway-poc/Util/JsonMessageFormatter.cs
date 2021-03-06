﻿using NetJSON;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Messaging;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace erp_gateway_poc.Util {

    namespace MessageQueuing {
        public class JsonMessageFormatter<T> : IMessageFormatter {
            private Encoding encoding;
            public JsonMessageFormatter() {
                this.encoding = Encoding.UTF8;
            }
            public JsonMessageFormatter(Encoding encoding) {
                this.encoding = encoding;
            }
            public bool CanRead(Message message) {
                if (message == null) {
                    throw new ArgumentNullException("message");
                }
                var stream = message.BodyStream;
                return stream != null
                && stream.CanRead
                && stream.Length > 0;
            }
            public object Clone() {
                return new JsonMessageFormatter<T>(encoding);
            }
            public object Read(Message message) {
                if (message == null) {
                    throw new ArgumentNullException("message");
                }
                var ser = new DataContractJsonSerializer(typeof(T));
                T obj = (T)ser.ReadObject(message.BodyStream);
                return obj;
            }
            public void Write(Message message, object obj) {
                if (message == null) {
                    throw new ArgumentNullException("message");
                }
                string json = NetJSON.NetJSON.Serialize(obj);
                message.BodyStream = new MemoryStream(encoding.GetBytes(json));
            }
        }
    }
}
