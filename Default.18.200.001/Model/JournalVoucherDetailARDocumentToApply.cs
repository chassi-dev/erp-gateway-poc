/*
 * Default/18.200.001
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * OpenAPI spec version: 3
 *
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

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
using OpenAPIDateConverter = Acumatica.RESTClient.Client.OpenAPIDateConverter;

namespace Acumatica.DefaultEndpoint.Model
{
    /// <summary>
    /// JournalVoucherDetailARDocumentToApply
    /// </summary>
    [DataContract]
    public partial class JournalVoucherDetailARDocumentToApply : Entity,  IEquatable<JournalVoucherDetailARDocumentToApply>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JournalVoucherDetailARDocumentToApply" /> class.
        /// </summary>
        /// <param name="balanceWriteOff">balanceWriteOff.</param>
        /// <param name="customerOrder">customerOrder.</param>
        /// <param name="docType">docType.</param>
        /// <param name="referenceNbr">referenceNbr.</param>
        /// <param name="writeOffLimit">writeOffLimit.</param>
        /// <param name="writeOffReasonCode">writeOffReasonCode.</param>
        public JournalVoucherDetailARDocumentToApply(DecimalValue balanceWriteOff = default(DecimalValue), StringValue customerOrder = default(StringValue), StringValue docType = default(StringValue), StringValue referenceNbr = default(StringValue), DecimalValue writeOffLimit = default(DecimalValue), StringValue writeOffReasonCode = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.BalanceWriteOff = balanceWriteOff;
            this.CustomerOrder = customerOrder;
            this.DocType = docType;
            this.ReferenceNbr = referenceNbr;
            this.WriteOffLimit = writeOffLimit;
            this.WriteOffReasonCode = writeOffReasonCode;
        }

        /// <summary>
        /// Gets or Sets BalanceWriteOff
        /// </summary>
        [DataMember(Name="BalanceWriteOff", EmitDefaultValue=false)]
        public DecimalValue BalanceWriteOff { get; set; }

        /// <summary>
        /// Gets or Sets CustomerOrder
        /// </summary>
        [DataMember(Name="CustomerOrder", EmitDefaultValue=false)]
        public StringValue CustomerOrder { get; set; }

        /// <summary>
        /// Gets or Sets DocType
        /// </summary>
        [DataMember(Name="DocType", EmitDefaultValue=false)]
        public StringValue DocType { get; set; }

        /// <summary>
        /// Gets or Sets ReferenceNbr
        /// </summary>
        [DataMember(Name="ReferenceNbr", EmitDefaultValue=false)]
        public StringValue ReferenceNbr { get; set; }

        /// <summary>
        /// Gets or Sets WriteOffLimit
        /// </summary>
        [DataMember(Name="WriteOffLimit", EmitDefaultValue=false)]
        public DecimalValue WriteOffLimit { get; set; }

        /// <summary>
        /// Gets or Sets WriteOffReasonCode
        /// </summary>
        [DataMember(Name="WriteOffReasonCode", EmitDefaultValue=false)]
        public StringValue WriteOffReasonCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JournalVoucherDetailARDocumentToApply {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  BalanceWriteOff: ").Append(BalanceWriteOff).Append("\n");
            sb.Append("  CustomerOrder: ").Append(CustomerOrder).Append("\n");
            sb.Append("  DocType: ").Append(DocType).Append("\n");
            sb.Append("  ReferenceNbr: ").Append(ReferenceNbr).Append("\n");
            sb.Append("  WriteOffLimit: ").Append(WriteOffLimit).Append("\n");
            sb.Append("  WriteOffReasonCode: ").Append(WriteOffReasonCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as JournalVoucherDetailARDocumentToApply);
        }

        /// <summary>
        /// Returns true if JournalVoucherDetailARDocumentToApply instances are equal
        /// </summary>
        /// <param name="input">Instance of JournalVoucherDetailARDocumentToApply to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JournalVoucherDetailARDocumentToApply input)
        {
            if (input == null)
                return false;

            return base.Equals(input) &&
                (
                    this.BalanceWriteOff == input.BalanceWriteOff ||
                    (this.BalanceWriteOff != null &&
                    this.BalanceWriteOff.Equals(input.BalanceWriteOff))
                ) && base.Equals(input) &&
                (
                    this.CustomerOrder == input.CustomerOrder ||
                    (this.CustomerOrder != null &&
                    this.CustomerOrder.Equals(input.CustomerOrder))
                ) && base.Equals(input) &&
                (
                    this.DocType == input.DocType ||
                    (this.DocType != null &&
                    this.DocType.Equals(input.DocType))
                ) && base.Equals(input) &&
                (
                    this.ReferenceNbr == input.ReferenceNbr ||
                    (this.ReferenceNbr != null &&
                    this.ReferenceNbr.Equals(input.ReferenceNbr))
                ) && base.Equals(input) &&
                (
                    this.WriteOffLimit == input.WriteOffLimit ||
                    (this.WriteOffLimit != null &&
                    this.WriteOffLimit.Equals(input.WriteOffLimit))
                ) && base.Equals(input) &&
                (
                    this.WriteOffReasonCode == input.WriteOffReasonCode ||
                    (this.WriteOffReasonCode != null &&
                    this.WriteOffReasonCode.Equals(input.WriteOffReasonCode))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = base.GetHashCode();
                if (this.BalanceWriteOff != null)
                    hashCode = hashCode * 59 + this.BalanceWriteOff.GetHashCode();
                if (this.CustomerOrder != null)
                    hashCode = hashCode * 59 + this.CustomerOrder.GetHashCode();
                if (this.DocType != null)
                    hashCode = hashCode * 59 + this.DocType.GetHashCode();
                if (this.ReferenceNbr != null)
                    hashCode = hashCode * 59 + this.ReferenceNbr.GetHashCode();
                if (this.WriteOffLimit != null)
                    hashCode = hashCode * 59 + this.WriteOffLimit.GetHashCode();
                if (this.WriteOffReasonCode != null)
                    hashCode = hashCode * 59 + this.WriteOffReasonCode.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            foreach(var x in base.BaseValidate(validationContext)) yield return x;
            yield break;
        }
    }

}
