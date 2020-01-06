using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace erp_gateway_poc.Model {

    [DataContract]
    class SalesOrderNotification {

        [DataMember]
        public List<BasicSalesOrder> Inserted { get; set; }

        [DataMember]
        public List<BasicSalesOrder> Deleted { get; set; }

        [DataMember]
        public string Query { get; set; }

        [DataMember]
        public string CompanyId { get; set; }

        [DataMember]
        public string Id { get; set; }

        [DataMember]
        public long TimeStamp { get; set; }

        [DataMember]
        public AdditionalInfo AdditionalInfo { get; set; }

        public override string ToString() {
            var sb = new StringBuilder();
            sb.Append("class SalesOrderNotification {\n");
            foreach(BasicSalesOrder so in Inserted) {
                sb.Append("  Inserted: ").Append(so).Append("\n");
            }
            foreach(BasicSalesOrder so in Deleted) {
                sb.Append("  Deleted: ").Append(so).Append("\n");
            }
            sb.Append("  Query: ").Append(Query).Append("\n");
            sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TimeStamp: ").Append(TimeStamp).Append("\n");
            sb.Append("  AdditionalInfo: ").Append(AdditionalInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
