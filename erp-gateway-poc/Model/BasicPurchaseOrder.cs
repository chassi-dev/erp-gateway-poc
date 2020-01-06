using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace erp_gateway_poc.Model {

    [DataContract]
    class BasicPurchaseOrder {

        [DataMember]
        public string OrderNbr { get; set; }

        [DataMember]
        public string Status { get; set; }

        [DataMember]
        public String LastModifiedOn { get; set; }
    }
}
