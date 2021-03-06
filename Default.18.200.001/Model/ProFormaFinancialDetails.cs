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
    /// ProFormaFinancialDetails
    /// </summary>
    [DataContract]
    public partial class ProFormaFinancialDetails : Entity,  IEquatable<ProFormaFinancialDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProFormaFinancialDetails" /> class.
        /// </summary>
        /// <param name="aRDocType">aRDocType.</param>
        /// <param name="aRRefNbr">aRRefNbr.</param>
        /// <param name="branch">branch.</param>
        /// <param name="cashDiscountDate">cashDiscountDate.</param>
        /// <param name="customerTaxZone">customerTaxZone.</param>
        /// <param name="customerUsageType">customerUsageType.</param>
        /// <param name="dueDate">dueDate.</param>
        /// <param name="terms">terms.</param>
        public ProFormaFinancialDetails(StringValue aRDocType = default(StringValue), StringValue aRRefNbr = default(StringValue), StringValue branch = default(StringValue), DateTimeValue cashDiscountDate = default(DateTimeValue), StringValue customerTaxZone = default(StringValue), StringValue customerUsageType = default(StringValue), DateTimeValue dueDate = default(DateTimeValue), StringValue terms = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.ARDocType = aRDocType;
            this.ARRefNbr = aRRefNbr;
            this.Branch = branch;
            this.CashDiscountDate = cashDiscountDate;
            this.CustomerTaxZone = customerTaxZone;
            this.CustomerUsageType = customerUsageType;
            this.DueDate = dueDate;
            this.Terms = terms;
        }

        /// <summary>
        /// Gets or Sets ARDocType
        /// </summary>
        [DataMember(Name="ARDocType", EmitDefaultValue=false)]
        public StringValue ARDocType { get; set; }

        /// <summary>
        /// Gets or Sets ARRefNbr
        /// </summary>
        [DataMember(Name="ARRefNbr", EmitDefaultValue=false)]
        public StringValue ARRefNbr { get; set; }

        /// <summary>
        /// Gets or Sets Branch
        /// </summary>
        [DataMember(Name="Branch", EmitDefaultValue=false)]
        public StringValue Branch { get; set; }

        /// <summary>
        /// Gets or Sets CashDiscountDate
        /// </summary>
        [DataMember(Name="CashDiscountDate", EmitDefaultValue=false)]
        public DateTimeValue CashDiscountDate { get; set; }

        /// <summary>
        /// Gets or Sets CustomerTaxZone
        /// </summary>
        [DataMember(Name="CustomerTaxZone", EmitDefaultValue=false)]
        public StringValue CustomerTaxZone { get; set; }

        /// <summary>
        /// Gets or Sets CustomerUsageType
        /// </summary>
        [DataMember(Name="CustomerUsageType", EmitDefaultValue=false)]
        public StringValue CustomerUsageType { get; set; }

        /// <summary>
        /// Gets or Sets DueDate
        /// </summary>
        [DataMember(Name="DueDate", EmitDefaultValue=false)]
        public DateTimeValue DueDate { get; set; }

        /// <summary>
        /// Gets or Sets Terms
        /// </summary>
        [DataMember(Name="Terms", EmitDefaultValue=false)]
        public StringValue Terms { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProFormaFinancialDetails {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  ARDocType: ").Append(ARDocType).Append("\n");
            sb.Append("  ARRefNbr: ").Append(ARRefNbr).Append("\n");
            sb.Append("  Branch: ").Append(Branch).Append("\n");
            sb.Append("  CashDiscountDate: ").Append(CashDiscountDate).Append("\n");
            sb.Append("  CustomerTaxZone: ").Append(CustomerTaxZone).Append("\n");
            sb.Append("  CustomerUsageType: ").Append(CustomerUsageType).Append("\n");
            sb.Append("  DueDate: ").Append(DueDate).Append("\n");
            sb.Append("  Terms: ").Append(Terms).Append("\n");
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
            return this.Equals(input as ProFormaFinancialDetails);
        }

        /// <summary>
        /// Returns true if ProFormaFinancialDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of ProFormaFinancialDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProFormaFinancialDetails input)
        {
            if (input == null)
                return false;

            return base.Equals(input) &&
                (
                    this.ARDocType == input.ARDocType ||
                    (this.ARDocType != null &&
                    this.ARDocType.Equals(input.ARDocType))
                ) && base.Equals(input) &&
                (
                    this.ARRefNbr == input.ARRefNbr ||
                    (this.ARRefNbr != null &&
                    this.ARRefNbr.Equals(input.ARRefNbr))
                ) && base.Equals(input) &&
                (
                    this.Branch == input.Branch ||
                    (this.Branch != null &&
                    this.Branch.Equals(input.Branch))
                ) && base.Equals(input) &&
                (
                    this.CashDiscountDate == input.CashDiscountDate ||
                    (this.CashDiscountDate != null &&
                    this.CashDiscountDate.Equals(input.CashDiscountDate))
                ) && base.Equals(input) &&
                (
                    this.CustomerTaxZone == input.CustomerTaxZone ||
                    (this.CustomerTaxZone != null &&
                    this.CustomerTaxZone.Equals(input.CustomerTaxZone))
                ) && base.Equals(input) &&
                (
                    this.CustomerUsageType == input.CustomerUsageType ||
                    (this.CustomerUsageType != null &&
                    this.CustomerUsageType.Equals(input.CustomerUsageType))
                ) && base.Equals(input) &&
                (
                    this.DueDate == input.DueDate ||
                    (this.DueDate != null &&
                    this.DueDate.Equals(input.DueDate))
                ) && base.Equals(input) &&
                (
                    this.Terms == input.Terms ||
                    (this.Terms != null &&
                    this.Terms.Equals(input.Terms))
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
                if (this.ARDocType != null)
                    hashCode = hashCode * 59 + this.ARDocType.GetHashCode();
                if (this.ARRefNbr != null)
                    hashCode = hashCode * 59 + this.ARRefNbr.GetHashCode();
                if (this.Branch != null)
                    hashCode = hashCode * 59 + this.Branch.GetHashCode();
                if (this.CashDiscountDate != null)
                    hashCode = hashCode * 59 + this.CashDiscountDate.GetHashCode();
                if (this.CustomerTaxZone != null)
                    hashCode = hashCode * 59 + this.CustomerTaxZone.GetHashCode();
                if (this.CustomerUsageType != null)
                    hashCode = hashCode * 59 + this.CustomerUsageType.GetHashCode();
                if (this.DueDate != null)
                    hashCode = hashCode * 59 + this.DueDate.GetHashCode();
                if (this.Terms != null)
                    hashCode = hashCode * 59 + this.Terms.GetHashCode();
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
