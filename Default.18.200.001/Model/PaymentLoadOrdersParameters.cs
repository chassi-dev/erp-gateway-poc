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
    /// The parameters of the action.
    /// </summary>
    [DataContract]
    public partial class PaymentLoadOrdersParameters :  IEquatable<PaymentLoadOrdersParameters>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentLoadOrdersParameters" /> class.
        /// </summary>
        /// <param name="endOrderNbr">endOrderNbr.</param>
        /// <param name="startOrderNbr">startOrderNbr.</param>
        /// <param name="fromDate">fromDate.</param>
        /// <param name="sOOrderBy">sOOrderBy.</param>
        /// <param name="tillDate">tillDate.</param>
        /// <param name="maxDocs">maxDocs.</param>
        public PaymentLoadOrdersParameters(StringValue endOrderNbr = default(StringValue), StringValue startOrderNbr = default(StringValue), DateTimeValue fromDate = default(DateTimeValue), StringValue sOOrderBy = default(StringValue), DateTimeValue tillDate = default(DateTimeValue), IntValue maxDocs = default(IntValue))
        {
            this.EndOrderNbr = endOrderNbr;
            this.StartOrderNbr = startOrderNbr;
            this.FromDate = fromDate;
            this.SOOrderBy = sOOrderBy;
            this.TillDate = tillDate;
            this.MaxDocs = maxDocs;
        }

        /// <summary>
        /// Gets or Sets EndOrderNbr
        /// </summary>
        [DataMember(Name="EndOrderNbr", EmitDefaultValue=false)]
        public StringValue EndOrderNbr { get; set; }

        /// <summary>
        /// Gets or Sets StartOrderNbr
        /// </summary>
        [DataMember(Name="StartOrderNbr", EmitDefaultValue=false)]
        public StringValue StartOrderNbr { get; set; }

        /// <summary>
        /// Gets or Sets FromDate
        /// </summary>
        [DataMember(Name="FromDate", EmitDefaultValue=false)]
        public DateTimeValue FromDate { get; set; }

        /// <summary>
        /// Gets or Sets SOOrderBy
        /// </summary>
        [DataMember(Name="SOOrderBy", EmitDefaultValue=false)]
        public StringValue SOOrderBy { get; set; }

        /// <summary>
        /// Gets or Sets TillDate
        /// </summary>
        [DataMember(Name="TillDate", EmitDefaultValue=false)]
        public DateTimeValue TillDate { get; set; }

        /// <summary>
        /// Gets or Sets MaxDocs
        /// </summary>
        [DataMember(Name="MaxDocs", EmitDefaultValue=false)]
        public IntValue MaxDocs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentLoadOrdersParameters {\n");
            sb.Append("  EndOrderNbr: ").Append(EndOrderNbr).Append("\n");
            sb.Append("  StartOrderNbr: ").Append(StartOrderNbr).Append("\n");
            sb.Append("  FromDate: ").Append(FromDate).Append("\n");
            sb.Append("  SOOrderBy: ").Append(SOOrderBy).Append("\n");
            sb.Append("  TillDate: ").Append(TillDate).Append("\n");
            sb.Append("  MaxDocs: ").Append(MaxDocs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as PaymentLoadOrdersParameters);
        }

        /// <summary>
        /// Returns true if PaymentLoadOrdersParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentLoadOrdersParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentLoadOrdersParameters input)
        {
            if (input == null)
                return false;

            return
                (
                    this.EndOrderNbr == input.EndOrderNbr ||
                    (this.EndOrderNbr != null &&
                    this.EndOrderNbr.Equals(input.EndOrderNbr))
                ) &&
                (
                    this.StartOrderNbr == input.StartOrderNbr ||
                    (this.StartOrderNbr != null &&
                    this.StartOrderNbr.Equals(input.StartOrderNbr))
                ) &&
                (
                    this.FromDate == input.FromDate ||
                    (this.FromDate != null &&
                    this.FromDate.Equals(input.FromDate))
                ) &&
                (
                    this.SOOrderBy == input.SOOrderBy ||
                    (this.SOOrderBy != null &&
                    this.SOOrderBy.Equals(input.SOOrderBy))
                ) &&
                (
                    this.TillDate == input.TillDate ||
                    (this.TillDate != null &&
                    this.TillDate.Equals(input.TillDate))
                ) &&
                (
                    this.MaxDocs == input.MaxDocs ||
                    (this.MaxDocs != null &&
                    this.MaxDocs.Equals(input.MaxDocs))
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
                int hashCode = 41;
                if (this.EndOrderNbr != null)
                    hashCode = hashCode * 59 + this.EndOrderNbr.GetHashCode();
                if (this.StartOrderNbr != null)
                    hashCode = hashCode * 59 + this.StartOrderNbr.GetHashCode();
                if (this.FromDate != null)
                    hashCode = hashCode * 59 + this.FromDate.GetHashCode();
                if (this.SOOrderBy != null)
                    hashCode = hashCode * 59 + this.SOOrderBy.GetHashCode();
                if (this.TillDate != null)
                    hashCode = hashCode * 59 + this.TillDate.GetHashCode();
                if (this.MaxDocs != null)
                    hashCode = hashCode * 59 + this.MaxDocs.GetHashCode();
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
            yield break;
        }
    }

}
