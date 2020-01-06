using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using Acumatica.DefaultEndpoint.Model;

namespace erp_gateway_poc.Model {

    [DataContract]
    public partial class PurchaseOrderNotification : Entity, IEquatable<PurchaseOrderNotification>, IValidatableObject {

        public PurchaseOrderNotification() {

        }

        public PurchaseOrderNotification(List<PurchaseOrder> inserted, List<PurchaseOrder> deleted, StringValue query = default(StringValue), StringValue companyId = default(StringValue), StringValue id = default(StringValue), DecimalValue timeStamp = default(DecimalValue)) {
            this.Inserted = inserted;
            this.Deleted = deleted;
            this.Query = query;
            this.CompanyId = companyId;
            this.Id = id;
            this.TimeStamp = timeStamp;
        }

        [DataMember]
        public List<PurchaseOrder> Inserted { get; set; }

        [DataMember]
        public List<PurchaseOrder> Deleted { get; set; }

        [DataMember]
        public StringValue Query { get; set; }

        [DataMember]
        public StringValue CompanyId { get; set; }

        [DataMember]
        public StringValue Id { get; set; }

        [DataMember]
        public DecimalValue TimeStamp { get; set; }

        public bool Equals(PurchaseOrderNotification input) {
            return this.Equals(input as PurchaseOrderNotification);
        }
    }
}
