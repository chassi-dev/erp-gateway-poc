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
    /// SalesPricesWorksheetDetail
    /// </summary>
    [DataContract]
    public partial class SalesPricesWorksheetDetail : Entity,  IEquatable<SalesPricesWorksheetDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesPricesWorksheetDetail" /> class.
        /// </summary>
        /// <param name="breakQty">breakQty.</param>
        /// <param name="currencyID">currencyID.</param>
        /// <param name="description">description.</param>
        /// <param name="inventoryID">inventoryID.</param>
        /// <param name="lineID">lineID.</param>
        /// <param name="pendingPrice">pendingPrice.</param>
        /// <param name="priceCode">priceCode.</param>
        /// <param name="priceType">priceType.</param>
        /// <param name="referenceNbr">referenceNbr.</param>
        /// <param name="sourcePrice">sourcePrice.</param>
        /// <param name="tax">tax.</param>
        /// <param name="uOM">uOM.</param>
        public SalesPricesWorksheetDetail(DecimalValue breakQty = default(DecimalValue), StringValue currencyID = default(StringValue), StringValue description = default(StringValue), StringValue inventoryID = default(StringValue), IntValue lineID = default(IntValue), DecimalValue pendingPrice = default(DecimalValue), StringValue priceCode = default(StringValue), StringValue priceType = default(StringValue), StringValue referenceNbr = default(StringValue), DecimalValue sourcePrice = default(DecimalValue), StringValue tax = default(StringValue), StringValue uOM = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.BreakQty = breakQty;
            this.CurrencyID = currencyID;
            this.Description = description;
            this.InventoryID = inventoryID;
            this.LineID = lineID;
            this.PendingPrice = pendingPrice;
            this.PriceCode = priceCode;
            this.PriceType = priceType;
            this.ReferenceNbr = referenceNbr;
            this.SourcePrice = sourcePrice;
            this.Tax = tax;
            this.UOM = uOM;
        }

        /// <summary>
        /// Gets or Sets BreakQty
        /// </summary>
        [DataMember(Name="BreakQty", EmitDefaultValue=false)]
        public DecimalValue BreakQty { get; set; }

        /// <summary>
        /// Gets or Sets CurrencyID
        /// </summary>
        [DataMember(Name="CurrencyID", EmitDefaultValue=false)]
        public StringValue CurrencyID { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public StringValue Description { get; set; }

        /// <summary>
        /// Gets or Sets InventoryID
        /// </summary>
        [DataMember(Name="InventoryID", EmitDefaultValue=false)]
        public StringValue InventoryID { get; set; }

        /// <summary>
        /// Gets or Sets LineID
        /// </summary>
        [DataMember(Name="LineID", EmitDefaultValue=false)]
        public IntValue LineID { get; set; }

        /// <summary>
        /// Gets or Sets PendingPrice
        /// </summary>
        [DataMember(Name="PendingPrice", EmitDefaultValue=false)]
        public DecimalValue PendingPrice { get; set; }

        /// <summary>
        /// Gets or Sets PriceCode
        /// </summary>
        [DataMember(Name="PriceCode", EmitDefaultValue=false)]
        public StringValue PriceCode { get; set; }

        /// <summary>
        /// Gets or Sets PriceType
        /// </summary>
        [DataMember(Name="PriceType", EmitDefaultValue=false)]
        public StringValue PriceType { get; set; }

        /// <summary>
        /// Gets or Sets ReferenceNbr
        /// </summary>
        [DataMember(Name="ReferenceNbr", EmitDefaultValue=false)]
        public StringValue ReferenceNbr { get; set; }

        /// <summary>
        /// Gets or Sets SourcePrice
        /// </summary>
        [DataMember(Name="SourcePrice", EmitDefaultValue=false)]
        public DecimalValue SourcePrice { get; set; }

        /// <summary>
        /// Gets or Sets Tax
        /// </summary>
        [DataMember(Name="Tax", EmitDefaultValue=false)]
        public StringValue Tax { get; set; }

        /// <summary>
        /// Gets or Sets UOM
        /// </summary>
        [DataMember(Name="UOM", EmitDefaultValue=false)]
        public StringValue UOM { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SalesPricesWorksheetDetail {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  BreakQty: ").Append(BreakQty).Append("\n");
            sb.Append("  CurrencyID: ").Append(CurrencyID).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  InventoryID: ").Append(InventoryID).Append("\n");
            sb.Append("  LineID: ").Append(LineID).Append("\n");
            sb.Append("  PendingPrice: ").Append(PendingPrice).Append("\n");
            sb.Append("  PriceCode: ").Append(PriceCode).Append("\n");
            sb.Append("  PriceType: ").Append(PriceType).Append("\n");
            sb.Append("  ReferenceNbr: ").Append(ReferenceNbr).Append("\n");
            sb.Append("  SourcePrice: ").Append(SourcePrice).Append("\n");
            sb.Append("  Tax: ").Append(Tax).Append("\n");
            sb.Append("  UOM: ").Append(UOM).Append("\n");
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
            return this.Equals(input as SalesPricesWorksheetDetail);
        }

        /// <summary>
        /// Returns true if SalesPricesWorksheetDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of SalesPricesWorksheetDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SalesPricesWorksheetDetail input)
        {
            if (input == null)
                return false;

            return base.Equals(input) &&
                (
                    this.BreakQty == input.BreakQty ||
                    (this.BreakQty != null &&
                    this.BreakQty.Equals(input.BreakQty))
                ) && base.Equals(input) &&
                (
                    this.CurrencyID == input.CurrencyID ||
                    (this.CurrencyID != null &&
                    this.CurrencyID.Equals(input.CurrencyID))
                ) && base.Equals(input) &&
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && base.Equals(input) &&
                (
                    this.InventoryID == input.InventoryID ||
                    (this.InventoryID != null &&
                    this.InventoryID.Equals(input.InventoryID))
                ) && base.Equals(input) &&
                (
                    this.LineID == input.LineID ||
                    (this.LineID != null &&
                    this.LineID.Equals(input.LineID))
                ) && base.Equals(input) &&
                (
                    this.PendingPrice == input.PendingPrice ||
                    (this.PendingPrice != null &&
                    this.PendingPrice.Equals(input.PendingPrice))
                ) && base.Equals(input) &&
                (
                    this.PriceCode == input.PriceCode ||
                    (this.PriceCode != null &&
                    this.PriceCode.Equals(input.PriceCode))
                ) && base.Equals(input) &&
                (
                    this.PriceType == input.PriceType ||
                    (this.PriceType != null &&
                    this.PriceType.Equals(input.PriceType))
                ) && base.Equals(input) &&
                (
                    this.ReferenceNbr == input.ReferenceNbr ||
                    (this.ReferenceNbr != null &&
                    this.ReferenceNbr.Equals(input.ReferenceNbr))
                ) && base.Equals(input) &&
                (
                    this.SourcePrice == input.SourcePrice ||
                    (this.SourcePrice != null &&
                    this.SourcePrice.Equals(input.SourcePrice))
                ) && base.Equals(input) &&
                (
                    this.Tax == input.Tax ||
                    (this.Tax != null &&
                    this.Tax.Equals(input.Tax))
                ) && base.Equals(input) &&
                (
                    this.UOM == input.UOM ||
                    (this.UOM != null &&
                    this.UOM.Equals(input.UOM))
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
                if (this.BreakQty != null)
                    hashCode = hashCode * 59 + this.BreakQty.GetHashCode();
                if (this.CurrencyID != null)
                    hashCode = hashCode * 59 + this.CurrencyID.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.InventoryID != null)
                    hashCode = hashCode * 59 + this.InventoryID.GetHashCode();
                if (this.LineID != null)
                    hashCode = hashCode * 59 + this.LineID.GetHashCode();
                if (this.PendingPrice != null)
                    hashCode = hashCode * 59 + this.PendingPrice.GetHashCode();
                if (this.PriceCode != null)
                    hashCode = hashCode * 59 + this.PriceCode.GetHashCode();
                if (this.PriceType != null)
                    hashCode = hashCode * 59 + this.PriceType.GetHashCode();
                if (this.ReferenceNbr != null)
                    hashCode = hashCode * 59 + this.ReferenceNbr.GetHashCode();
                if (this.SourcePrice != null)
                    hashCode = hashCode * 59 + this.SourcePrice.GetHashCode();
                if (this.Tax != null)
                    hashCode = hashCode * 59 + this.Tax.GetHashCode();
                if (this.UOM != null)
                    hashCode = hashCode * 59 + this.UOM.GetHashCode();
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
