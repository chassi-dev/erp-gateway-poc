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
    /// SalesOrderShipment
    /// </summary>
    [DataContract]
    public partial class SalesOrderShipment : Entity,  IEquatable<SalesOrderShipment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesOrderShipment" /> class.
        /// </summary>
        /// <param name="inventoryDocType">inventoryDocType.</param>
        /// <param name="inventoryRefNbr">inventoryRefNbr.</param>
        /// <param name="invoiceNbr">invoiceNbr.</param>
        /// <param name="invoiceType">invoiceType.</param>
        /// <param name="shipmentDate">shipmentDate.</param>
        /// <param name="shipmentNbr">shipmentNbr.</param>
        /// <param name="shipmentType">shipmentType.</param>
        /// <param name="shippedQty">shippedQty.</param>
        /// <param name="shippedVolume">shippedVolume.</param>
        /// <param name="shippedWeight">shippedWeight.</param>
        /// <param name="status">status.</param>
        public SalesOrderShipment(StringValue inventoryDocType = default(StringValue), StringValue inventoryRefNbr = default(StringValue), StringValue invoiceNbr = default(StringValue), StringValue invoiceType = default(StringValue), DateTimeValue shipmentDate = default(DateTimeValue), StringValue shipmentNbr = default(StringValue), StringValue shipmentType = default(StringValue), DecimalValue shippedQty = default(DecimalValue), DecimalValue shippedVolume = default(DecimalValue), DecimalValue shippedWeight = default(DecimalValue), StringValue status = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.InventoryDocType = inventoryDocType;
            this.InventoryRefNbr = inventoryRefNbr;
            this.InvoiceNbr = invoiceNbr;
            this.InvoiceType = invoiceType;
            this.ShipmentDate = shipmentDate;
            this.ShipmentNbr = shipmentNbr;
            this.ShipmentType = shipmentType;
            this.ShippedQty = shippedQty;
            this.ShippedVolume = shippedVolume;
            this.ShippedWeight = shippedWeight;
            this.Status = status;
        }

        /// <summary>
        /// Gets or Sets InventoryDocType
        /// </summary>
        [DataMember(Name="InventoryDocType", EmitDefaultValue=false)]
        public StringValue InventoryDocType { get; set; }

        /// <summary>
        /// Gets or Sets InventoryRefNbr
        /// </summary>
        [DataMember(Name="InventoryRefNbr", EmitDefaultValue=false)]
        public StringValue InventoryRefNbr { get; set; }

        /// <summary>
        /// Gets or Sets InvoiceNbr
        /// </summary>
        [DataMember(Name="InvoiceNbr", EmitDefaultValue=false)]
        public StringValue InvoiceNbr { get; set; }

        /// <summary>
        /// Gets or Sets InvoiceType
        /// </summary>
        [DataMember(Name="InvoiceType", EmitDefaultValue=false)]
        public StringValue InvoiceType { get; set; }

        /// <summary>
        /// Gets or Sets ShipmentDate
        /// </summary>
        [DataMember(Name="ShipmentDate", EmitDefaultValue=false)]
        public DateTimeValue ShipmentDate { get; set; }

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
        /// Gets or Sets ShippedQty
        /// </summary>
        [DataMember(Name="ShippedQty", EmitDefaultValue=false)]
        public DecimalValue ShippedQty { get; set; }

        /// <summary>
        /// Gets or Sets ShippedVolume
        /// </summary>
        [DataMember(Name="ShippedVolume", EmitDefaultValue=false)]
        public DecimalValue ShippedVolume { get; set; }

        /// <summary>
        /// Gets or Sets ShippedWeight
        /// </summary>
        [DataMember(Name="ShippedWeight", EmitDefaultValue=false)]
        public DecimalValue ShippedWeight { get; set; }

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
            sb.Append("class SalesOrderShipment {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  InventoryDocType: ").Append(InventoryDocType).Append("\n");
            sb.Append("  InventoryRefNbr: ").Append(InventoryRefNbr).Append("\n");
            sb.Append("  InvoiceNbr: ").Append(InvoiceNbr).Append("\n");
            sb.Append("  InvoiceType: ").Append(InvoiceType).Append("\n");
            sb.Append("  ShipmentDate: ").Append(ShipmentDate).Append("\n");
            sb.Append("  ShipmentNbr: ").Append(ShipmentNbr).Append("\n");
            sb.Append("  ShipmentType: ").Append(ShipmentType).Append("\n");
            sb.Append("  ShippedQty: ").Append(ShippedQty).Append("\n");
            sb.Append("  ShippedVolume: ").Append(ShippedVolume).Append("\n");
            sb.Append("  ShippedWeight: ").Append(ShippedWeight).Append("\n");
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
            return this.Equals(input as SalesOrderShipment);
        }

        /// <summary>
        /// Returns true if SalesOrderShipment instances are equal
        /// </summary>
        /// <param name="input">Instance of SalesOrderShipment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SalesOrderShipment input)
        {
            if (input == null)
                return false;

            return base.Equals(input) &&
                (
                    this.InventoryDocType == input.InventoryDocType ||
                    (this.InventoryDocType != null &&
                    this.InventoryDocType.Equals(input.InventoryDocType))
                ) && base.Equals(input) &&
                (
                    this.InventoryRefNbr == input.InventoryRefNbr ||
                    (this.InventoryRefNbr != null &&
                    this.InventoryRefNbr.Equals(input.InventoryRefNbr))
                ) && base.Equals(input) &&
                (
                    this.InvoiceNbr == input.InvoiceNbr ||
                    (this.InvoiceNbr != null &&
                    this.InvoiceNbr.Equals(input.InvoiceNbr))
                ) && base.Equals(input) &&
                (
                    this.InvoiceType == input.InvoiceType ||
                    (this.InvoiceType != null &&
                    this.InvoiceType.Equals(input.InvoiceType))
                ) && base.Equals(input) &&
                (
                    this.ShipmentDate == input.ShipmentDate ||
                    (this.ShipmentDate != null &&
                    this.ShipmentDate.Equals(input.ShipmentDate))
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
                    this.ShippedQty == input.ShippedQty ||
                    (this.ShippedQty != null &&
                    this.ShippedQty.Equals(input.ShippedQty))
                ) && base.Equals(input) &&
                (
                    this.ShippedVolume == input.ShippedVolume ||
                    (this.ShippedVolume != null &&
                    this.ShippedVolume.Equals(input.ShippedVolume))
                ) && base.Equals(input) &&
                (
                    this.ShippedWeight == input.ShippedWeight ||
                    (this.ShippedWeight != null &&
                    this.ShippedWeight.Equals(input.ShippedWeight))
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
                if (this.InventoryDocType != null)
                    hashCode = hashCode * 59 + this.InventoryDocType.GetHashCode();
                if (this.InventoryRefNbr != null)
                    hashCode = hashCode * 59 + this.InventoryRefNbr.GetHashCode();
                if (this.InvoiceNbr != null)
                    hashCode = hashCode * 59 + this.InvoiceNbr.GetHashCode();
                if (this.InvoiceType != null)
                    hashCode = hashCode * 59 + this.InvoiceType.GetHashCode();
                if (this.ShipmentDate != null)
                    hashCode = hashCode * 59 + this.ShipmentDate.GetHashCode();
                if (this.ShipmentNbr != null)
                    hashCode = hashCode * 59 + this.ShipmentNbr.GetHashCode();
                if (this.ShipmentType != null)
                    hashCode = hashCode * 59 + this.ShipmentType.GetHashCode();
                if (this.ShippedQty != null)
                    hashCode = hashCode * 59 + this.ShippedQty.GetHashCode();
                if (this.ShippedVolume != null)
                    hashCode = hashCode * 59 + this.ShippedVolume.GetHashCode();
                if (this.ShippedWeight != null)
                    hashCode = hashCode * 59 + this.ShippedWeight.GetHashCode();
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
