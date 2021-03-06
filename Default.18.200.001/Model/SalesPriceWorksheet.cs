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
    /// SalesPriceWorksheet
    /// </summary>
    [DataContract]
    public partial class SalesPriceWorksheet : Entity,  IEquatable<SalesPriceWorksheet>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesPriceWorksheet" /> class.
        /// </summary>
        /// <param name="createdDateTime">createdDateTime.</param>
        /// <param name="description">description.</param>
        /// <param name="effectiveDate">effectiveDate.</param>
        /// <param name="expirationDate">expirationDate.</param>
        /// <param name="hold">hold.</param>
        /// <param name="lastModifiedDateTime">lastModifiedDateTime.</param>
        /// <param name="overwriteOverlappingPrices">overwriteOverlappingPrices.</param>
        /// <param name="referenceNbr">referenceNbr.</param>
        /// <param name="salesPrices">salesPrices.</param>
        /// <param name="status">status.</param>
        public SalesPriceWorksheet(DateTimeValue createdDateTime = default(DateTimeValue), StringValue description = default(StringValue), DateTimeValue effectiveDate = default(DateTimeValue), DateTimeValue expirationDate = default(DateTimeValue), BooleanValue hold = default(BooleanValue), DateTimeValue lastModifiedDateTime = default(DateTimeValue), BooleanValue overwriteOverlappingPrices = default(BooleanValue), StringValue referenceNbr = default(StringValue), List<SalesPricesWorksheetDetail> salesPrices = default(List<SalesPricesWorksheetDetail>), StringValue status = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.CreatedDateTime = createdDateTime;
            this.Description = description;
            this.EffectiveDate = effectiveDate;
            this.ExpirationDate = expirationDate;
            this.Hold = hold;
            this.LastModifiedDateTime = lastModifiedDateTime;
            this.OverwriteOverlappingPrices = overwriteOverlappingPrices;
            this.ReferenceNbr = referenceNbr;
            this.SalesPrices = salesPrices;
            this.Status = status;
        }

        /// <summary>
        /// Gets or Sets CreatedDateTime
        /// </summary>
        [DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
        public DateTimeValue CreatedDateTime { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public StringValue Description { get; set; }

        /// <summary>
        /// Gets or Sets EffectiveDate
        /// </summary>
        [DataMember(Name="EffectiveDate", EmitDefaultValue=false)]
        public DateTimeValue EffectiveDate { get; set; }

        /// <summary>
        /// Gets or Sets ExpirationDate
        /// </summary>
        [DataMember(Name="ExpirationDate", EmitDefaultValue=false)]
        public DateTimeValue ExpirationDate { get; set; }

        /// <summary>
        /// Gets or Sets Hold
        /// </summary>
        [DataMember(Name="Hold", EmitDefaultValue=false)]
        public BooleanValue Hold { get; set; }

        /// <summary>
        /// Gets or Sets LastModifiedDateTime
        /// </summary>
        [DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
        public DateTimeValue LastModifiedDateTime { get; set; }

        /// <summary>
        /// Gets or Sets OverwriteOverlappingPrices
        /// </summary>
        [DataMember(Name="OverwriteOverlappingPrices", EmitDefaultValue=false)]
        public BooleanValue OverwriteOverlappingPrices { get; set; }

        /// <summary>
        /// Gets or Sets ReferenceNbr
        /// </summary>
        [DataMember(Name="ReferenceNbr", EmitDefaultValue=false)]
        public StringValue ReferenceNbr { get; set; }

        /// <summary>
        /// Gets or Sets SalesPrices
        /// </summary>
        [DataMember(Name="SalesPrices", EmitDefaultValue=false)]
        public List<SalesPricesWorksheetDetail> SalesPrices { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public StringValue Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SalesPriceWorksheet {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  CreatedDateTime: ").Append(CreatedDateTime).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  EffectiveDate: ").Append(EffectiveDate).Append("\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
            sb.Append("  Hold: ").Append(Hold).Append("\n");
            sb.Append("  LastModifiedDateTime: ").Append(LastModifiedDateTime).Append("\n");
            sb.Append("  OverwriteOverlappingPrices: ").Append(OverwriteOverlappingPrices).Append("\n");
            sb.Append("  ReferenceNbr: ").Append(ReferenceNbr).Append("\n");
            sb.Append("  SalesPrices: ").Append(SalesPrices).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as SalesPriceWorksheet);
        }

        /// <summary>
        /// Returns true if SalesPriceWorksheet instances are equal
        /// </summary>
        /// <param name="input">Instance of SalesPriceWorksheet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SalesPriceWorksheet input)
        {
            if (input == null)
                return false;

            return base.Equals(input) &&
                (
                    this.CreatedDateTime == input.CreatedDateTime ||
                    (this.CreatedDateTime != null &&
                    this.CreatedDateTime.Equals(input.CreatedDateTime))
                ) && base.Equals(input) &&
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && base.Equals(input) &&
                (
                    this.EffectiveDate == input.EffectiveDate ||
                    (this.EffectiveDate != null &&
                    this.EffectiveDate.Equals(input.EffectiveDate))
                ) && base.Equals(input) &&
                (
                    this.ExpirationDate == input.ExpirationDate ||
                    (this.ExpirationDate != null &&
                    this.ExpirationDate.Equals(input.ExpirationDate))
                ) && base.Equals(input) &&
                (
                    this.Hold == input.Hold ||
                    (this.Hold != null &&
                    this.Hold.Equals(input.Hold))
                ) && base.Equals(input) &&
                (
                    this.LastModifiedDateTime == input.LastModifiedDateTime ||
                    (this.LastModifiedDateTime != null &&
                    this.LastModifiedDateTime.Equals(input.LastModifiedDateTime))
                ) && base.Equals(input) &&
                (
                    this.OverwriteOverlappingPrices == input.OverwriteOverlappingPrices ||
                    (this.OverwriteOverlappingPrices != null &&
                    this.OverwriteOverlappingPrices.Equals(input.OverwriteOverlappingPrices))
                ) && base.Equals(input) &&
                (
                    this.ReferenceNbr == input.ReferenceNbr ||
                    (this.ReferenceNbr != null &&
                    this.ReferenceNbr.Equals(input.ReferenceNbr))
                ) && base.Equals(input) &&
                (
                    this.SalesPrices == input.SalesPrices ||
                    this.SalesPrices != null &&
                    this.SalesPrices.SequenceEqual(input.SalesPrices)
                ) && base.Equals(input) &&
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.CreatedDateTime != null)
                    hashCode = hashCode * 59 + this.CreatedDateTime.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.EffectiveDate != null)
                    hashCode = hashCode * 59 + this.EffectiveDate.GetHashCode();
                if (this.ExpirationDate != null)
                    hashCode = hashCode * 59 + this.ExpirationDate.GetHashCode();
                if (this.Hold != null)
                    hashCode = hashCode * 59 + this.Hold.GetHashCode();
                if (this.LastModifiedDateTime != null)
                    hashCode = hashCode * 59 + this.LastModifiedDateTime.GetHashCode();
                if (this.OverwriteOverlappingPrices != null)
                    hashCode = hashCode * 59 + this.OverwriteOverlappingPrices.GetHashCode();
                if (this.ReferenceNbr != null)
                    hashCode = hashCode * 59 + this.ReferenceNbr.GetHashCode();
                if (this.SalesPrices != null)
                    hashCode = hashCode * 59 + this.SalesPrices.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
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
