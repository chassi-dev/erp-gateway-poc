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
    /// OpportunityTaxDetail
    /// </summary>
    [DataContract]
    public partial class OpportunityTaxDetail : Entity,  IEquatable<OpportunityTaxDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OpportunityTaxDetail" /> class.
        /// </summary>
        /// <param name="includeInVATExemptTotal">includeInVATExemptTotal.</param>
        /// <param name="lineNbr">lineNbr.</param>
        /// <param name="pendingVAT">pendingVAT.</param>
        /// <param name="reverseVAT">reverseVAT.</param>
        /// <param name="statisticalVAT">statisticalVAT.</param>
        /// <param name="taxableAmount">taxableAmount.</param>
        /// <param name="taxAmount">taxAmount.</param>
        /// <param name="taxID">taxID.</param>
        /// <param name="taxRate">taxRate.</param>
        /// <param name="taxType">taxType.</param>
        public OpportunityTaxDetail(BooleanValue includeInVATExemptTotal = default(BooleanValue), IntValue lineNbr = default(IntValue), BooleanValue pendingVAT = default(BooleanValue), BooleanValue reverseVAT = default(BooleanValue), BooleanValue statisticalVAT = default(BooleanValue), DecimalValue taxableAmount = default(DecimalValue), DecimalValue taxAmount = default(DecimalValue), StringValue taxID = default(StringValue), DecimalValue taxRate = default(DecimalValue), StringValue taxType = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.IncludeInVATExemptTotal = includeInVATExemptTotal;
            this.LineNbr = lineNbr;
            this.PendingVAT = pendingVAT;
            this.ReverseVAT = reverseVAT;
            this.StatisticalVAT = statisticalVAT;
            this.TaxableAmount = taxableAmount;
            this.TaxAmount = taxAmount;
            this.TaxID = taxID;
            this.TaxRate = taxRate;
            this.TaxType = taxType;
        }

        /// <summary>
        /// Gets or Sets IncludeInVATExemptTotal
        /// </summary>
        [DataMember(Name="IncludeInVATExemptTotal", EmitDefaultValue=false)]
        public BooleanValue IncludeInVATExemptTotal { get; set; }

        /// <summary>
        /// Gets or Sets LineNbr
        /// </summary>
        [DataMember(Name="LineNbr", EmitDefaultValue=false)]
        public IntValue LineNbr { get; set; }

        /// <summary>
        /// Gets or Sets PendingVAT
        /// </summary>
        [DataMember(Name="PendingVAT", EmitDefaultValue=false)]
        public BooleanValue PendingVAT { get; set; }

        /// <summary>
        /// Gets or Sets ReverseVAT
        /// </summary>
        [DataMember(Name="ReverseVAT", EmitDefaultValue=false)]
        public BooleanValue ReverseVAT { get; set; }

        /// <summary>
        /// Gets or Sets StatisticalVAT
        /// </summary>
        [DataMember(Name="StatisticalVAT", EmitDefaultValue=false)]
        public BooleanValue StatisticalVAT { get; set; }

        /// <summary>
        /// Gets or Sets TaxableAmount
        /// </summary>
        [DataMember(Name="TaxableAmount", EmitDefaultValue=false)]
        public DecimalValue TaxableAmount { get; set; }

        /// <summary>
        /// Gets or Sets TaxAmount
        /// </summary>
        [DataMember(Name="TaxAmount", EmitDefaultValue=false)]
        public DecimalValue TaxAmount { get; set; }

        /// <summary>
        /// Gets or Sets TaxID
        /// </summary>
        [DataMember(Name="TaxID", EmitDefaultValue=false)]
        public StringValue TaxID { get; set; }

        /// <summary>
        /// Gets or Sets TaxRate
        /// </summary>
        [DataMember(Name="TaxRate", EmitDefaultValue=false)]
        public DecimalValue TaxRate { get; set; }

        /// <summary>
        /// Gets or Sets TaxType
        /// </summary>
        [DataMember(Name="TaxType", EmitDefaultValue=false)]
        public StringValue TaxType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OpportunityTaxDetail {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  IncludeInVATExemptTotal: ").Append(IncludeInVATExemptTotal).Append("\n");
            sb.Append("  LineNbr: ").Append(LineNbr).Append("\n");
            sb.Append("  PendingVAT: ").Append(PendingVAT).Append("\n");
            sb.Append("  ReverseVAT: ").Append(ReverseVAT).Append("\n");
            sb.Append("  StatisticalVAT: ").Append(StatisticalVAT).Append("\n");
            sb.Append("  TaxableAmount: ").Append(TaxableAmount).Append("\n");
            sb.Append("  TaxAmount: ").Append(TaxAmount).Append("\n");
            sb.Append("  TaxID: ").Append(TaxID).Append("\n");
            sb.Append("  TaxRate: ").Append(TaxRate).Append("\n");
            sb.Append("  TaxType: ").Append(TaxType).Append("\n");
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
            return this.Equals(input as OpportunityTaxDetail);
        }

        /// <summary>
        /// Returns true if OpportunityTaxDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of OpportunityTaxDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OpportunityTaxDetail input)
        {
            if (input == null)
                return false;

            return base.Equals(input) &&
                (
                    this.IncludeInVATExemptTotal == input.IncludeInVATExemptTotal ||
                    (this.IncludeInVATExemptTotal != null &&
                    this.IncludeInVATExemptTotal.Equals(input.IncludeInVATExemptTotal))
                ) && base.Equals(input) &&
                (
                    this.LineNbr == input.LineNbr ||
                    (this.LineNbr != null &&
                    this.LineNbr.Equals(input.LineNbr))
                ) && base.Equals(input) &&
                (
                    this.PendingVAT == input.PendingVAT ||
                    (this.PendingVAT != null &&
                    this.PendingVAT.Equals(input.PendingVAT))
                ) && base.Equals(input) &&
                (
                    this.ReverseVAT == input.ReverseVAT ||
                    (this.ReverseVAT != null &&
                    this.ReverseVAT.Equals(input.ReverseVAT))
                ) && base.Equals(input) &&
                (
                    this.StatisticalVAT == input.StatisticalVAT ||
                    (this.StatisticalVAT != null &&
                    this.StatisticalVAT.Equals(input.StatisticalVAT))
                ) && base.Equals(input) &&
                (
                    this.TaxableAmount == input.TaxableAmount ||
                    (this.TaxableAmount != null &&
                    this.TaxableAmount.Equals(input.TaxableAmount))
                ) && base.Equals(input) &&
                (
                    this.TaxAmount == input.TaxAmount ||
                    (this.TaxAmount != null &&
                    this.TaxAmount.Equals(input.TaxAmount))
                ) && base.Equals(input) &&
                (
                    this.TaxID == input.TaxID ||
                    (this.TaxID != null &&
                    this.TaxID.Equals(input.TaxID))
                ) && base.Equals(input) &&
                (
                    this.TaxRate == input.TaxRate ||
                    (this.TaxRate != null &&
                    this.TaxRate.Equals(input.TaxRate))
                ) && base.Equals(input) &&
                (
                    this.TaxType == input.TaxType ||
                    (this.TaxType != null &&
                    this.TaxType.Equals(input.TaxType))
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
                if (this.IncludeInVATExemptTotal != null)
                    hashCode = hashCode * 59 + this.IncludeInVATExemptTotal.GetHashCode();
                if (this.LineNbr != null)
                    hashCode = hashCode * 59 + this.LineNbr.GetHashCode();
                if (this.PendingVAT != null)
                    hashCode = hashCode * 59 + this.PendingVAT.GetHashCode();
                if (this.ReverseVAT != null)
                    hashCode = hashCode * 59 + this.ReverseVAT.GetHashCode();
                if (this.StatisticalVAT != null)
                    hashCode = hashCode * 59 + this.StatisticalVAT.GetHashCode();
                if (this.TaxableAmount != null)
                    hashCode = hashCode * 59 + this.TaxableAmount.GetHashCode();
                if (this.TaxAmount != null)
                    hashCode = hashCode * 59 + this.TaxAmount.GetHashCode();
                if (this.TaxID != null)
                    hashCode = hashCode * 59 + this.TaxID.GetHashCode();
                if (this.TaxRate != null)
                    hashCode = hashCode * 59 + this.TaxRate.GetHashCode();
                if (this.TaxType != null)
                    hashCode = hashCode * 59 + this.TaxType.GetHashCode();
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
