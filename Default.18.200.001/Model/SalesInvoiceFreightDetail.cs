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
    /// SalesInvoiceFreightDetail
    /// </summary>
    [DataContract]
    public partial class SalesInvoiceFreightDetail : Entity,  IEquatable<SalesInvoiceFreightDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesInvoiceFreightDetail" /> class.
        /// </summary>
        /// <param name="description">description.</param>
        /// <param name="freightAmount">freightAmount.</param>
        /// <param name="freightCost">freightCost.</param>
        /// <param name="lineTotal">lineTotal.</param>
        /// <param name="premiumFreightAmount">premiumFreightAmount.</param>
        /// <param name="shipmentNbr">shipmentNbr.</param>
        /// <param name="shipmentType">shipmentType.</param>
        /// <param name="totalFreightAmount">totalFreightAmount.</param>
        /// <param name="volume">volume.</param>
        /// <param name="weight">weight.</param>
        public SalesInvoiceFreightDetail(StringValue description = default(StringValue), DecimalValue freightAmount = default(DecimalValue), DecimalValue freightCost = default(DecimalValue), DecimalValue lineTotal = default(DecimalValue), DecimalValue premiumFreightAmount = default(DecimalValue), StringValue shipmentNbr = default(StringValue), StringValue shipmentType = default(StringValue), DecimalValue totalFreightAmount = default(DecimalValue), DecimalValue volume = default(DecimalValue), DecimalValue weight = default(DecimalValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.Description = description;
            this.FreightAmount = freightAmount;
            this.FreightCost = freightCost;
            this.LineTotal = lineTotal;
            this.PremiumFreightAmount = premiumFreightAmount;
            this.ShipmentNbr = shipmentNbr;
            this.ShipmentType = shipmentType;
            this.TotalFreightAmount = totalFreightAmount;
            this.Volume = volume;
            this.Weight = weight;
        }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public StringValue Description { get; set; }

        /// <summary>
        /// Gets or Sets FreightAmount
        /// </summary>
        [DataMember(Name="FreightAmount", EmitDefaultValue=false)]
        public DecimalValue FreightAmount { get; set; }

        /// <summary>
        /// Gets or Sets FreightCost
        /// </summary>
        [DataMember(Name="FreightCost", EmitDefaultValue=false)]
        public DecimalValue FreightCost { get; set; }

        /// <summary>
        /// Gets or Sets LineTotal
        /// </summary>
        [DataMember(Name="LineTotal", EmitDefaultValue=false)]
        public DecimalValue LineTotal { get; set; }

        /// <summary>
        /// Gets or Sets PremiumFreightAmount
        /// </summary>
        [DataMember(Name="PremiumFreightAmount", EmitDefaultValue=false)]
        public DecimalValue PremiumFreightAmount { get; set; }

        /// <summary>
        /// Gets or Sets ShipmentNbr
        /// </summary>
        [DataMember(Name="ShipmentNbr", EmitDefaultValue=false)]
        public StringValue ShipmentNbr { get; set; }

        /// <summary>
        /// Gets or Sets ShipmentType
        /// </summary>
        [DataMember(Name="ShipmentType", EmitDefaultValue=false)]
        public StringValue ShipmentType { get; set; }

        /// <summary>
        /// Gets or Sets TotalFreightAmount
        /// </summary>
        [DataMember(Name="TotalFreightAmount", EmitDefaultValue=false)]
        public DecimalValue TotalFreightAmount { get; set; }

        /// <summary>
        /// Gets or Sets Volume
        /// </summary>
        [DataMember(Name="Volume", EmitDefaultValue=false)]
        public DecimalValue Volume { get; set; }

        /// <summary>
        /// Gets or Sets Weight
        /// </summary>
        [DataMember(Name="Weight", EmitDefaultValue=false)]
        public DecimalValue Weight { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SalesInvoiceFreightDetail {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  FreightAmount: ").Append(FreightAmount).Append("\n");
            sb.Append("  FreightCost: ").Append(FreightCost).Append("\n");
            sb.Append("  LineTotal: ").Append(LineTotal).Append("\n");
            sb.Append("  PremiumFreightAmount: ").Append(PremiumFreightAmount).Append("\n");
            sb.Append("  ShipmentNbr: ").Append(ShipmentNbr).Append("\n");
            sb.Append("  ShipmentType: ").Append(ShipmentType).Append("\n");
            sb.Append("  TotalFreightAmount: ").Append(TotalFreightAmount).Append("\n");
            sb.Append("  Volume: ").Append(Volume).Append("\n");
            sb.Append("  Weight: ").Append(Weight).Append("\n");
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
            return this.Equals(input as SalesInvoiceFreightDetail);
        }

        /// <summary>
        /// Returns true if SalesInvoiceFreightDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of SalesInvoiceFreightDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SalesInvoiceFreightDetail input)
        {
            if (input == null)
                return false;

            return base.Equals(input) &&
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && base.Equals(input) &&
                (
                    this.FreightAmount == input.FreightAmount ||
                    (this.FreightAmount != null &&
                    this.FreightAmount.Equals(input.FreightAmount))
                ) && base.Equals(input) &&
                (
                    this.FreightCost == input.FreightCost ||
                    (this.FreightCost != null &&
                    this.FreightCost.Equals(input.FreightCost))
                ) && base.Equals(input) &&
                (
                    this.LineTotal == input.LineTotal ||
                    (this.LineTotal != null &&
                    this.LineTotal.Equals(input.LineTotal))
                ) && base.Equals(input) &&
                (
                    this.PremiumFreightAmount == input.PremiumFreightAmount ||
                    (this.PremiumFreightAmount != null &&
                    this.PremiumFreightAmount.Equals(input.PremiumFreightAmount))
                ) && base.Equals(input) &&
                (
                    this.ShipmentNbr == input.ShipmentNbr ||
                    (this.ShipmentNbr != null &&
                    this.ShipmentNbr.Equals(input.ShipmentNbr))
                ) && base.Equals(input) &&
                (
                    this.ShipmentType == input.ShipmentType ||
                    (this.ShipmentType != null &&
                    this.ShipmentType.Equals(input.ShipmentType))
                ) && base.Equals(input) &&
                (
                    this.TotalFreightAmount == input.TotalFreightAmount ||
                    (this.TotalFreightAmount != null &&
                    this.TotalFreightAmount.Equals(input.TotalFreightAmount))
                ) && base.Equals(input) &&
                (
                    this.Volume == input.Volume ||
                    (this.Volume != null &&
                    this.Volume.Equals(input.Volume))
                ) && base.Equals(input) &&
                (
                    this.Weight == input.Weight ||
                    (this.Weight != null &&
                    this.Weight.Equals(input.Weight))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.FreightAmount != null)
                    hashCode = hashCode * 59 + this.FreightAmount.GetHashCode();
                if (this.FreightCost != null)
                    hashCode = hashCode * 59 + this.FreightCost.GetHashCode();
                if (this.LineTotal != null)
                    hashCode = hashCode * 59 + this.LineTotal.GetHashCode();
                if (this.PremiumFreightAmount != null)
                    hashCode = hashCode * 59 + this.PremiumFreightAmount.GetHashCode();
                if (this.ShipmentNbr != null)
                    hashCode = hashCode * 59 + this.ShipmentNbr.GetHashCode();
                if (this.ShipmentType != null)
                    hashCode = hashCode * 59 + this.ShipmentType.GetHashCode();
                if (this.TotalFreightAmount != null)
                    hashCode = hashCode * 59 + this.TotalFreightAmount.GetHashCode();
                if (this.Volume != null)
                    hashCode = hashCode * 59 + this.Volume.GetHashCode();
                if (this.Weight != null)
                    hashCode = hashCode * 59 + this.Weight.GetHashCode();
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
