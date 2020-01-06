using System.Collections.Generic;
using System.Runtime.Serialization;

namespace erp_gateway_poc.Model {

    [DataContract]
    class PurchaseOrderNotification {

        [DataMember]
        public List<BasicPurchaseOrder> Inserted { get; set; }

        [DataMember]
        public List<BasicPurchaseOrder> Deleted { get; set; }

        [DataMember]
        public string Query { get; set; }

        [DataMember]
        public string CompanyId { get; set; }

        [DataMember]
        public string Id { get; set; }

        [DataMember]
        public long TimeStamp { get; set; }

    }
}
