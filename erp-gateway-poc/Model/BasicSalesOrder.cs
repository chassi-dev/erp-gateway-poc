using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace erp_gateway_poc.Model {

    [DataContract]
    class BasicSalesOrder {

        [DataMember]
        public string OrderNbr { get; set; }

        [DataMember]
        public string Status { get; set; }

        [DataMember]
        public string LastModifiedOn { get; set; }

        public override string ToString() {
            var sb = new StringBuilder();
            sb.Append("class SalesOrderNotification {\n");
            sb.Append("  OrderNbr: ").Append(OrderNbr).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  LastModifiedOn: ").Append(LastModifiedOn).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
