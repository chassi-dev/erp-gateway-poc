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
    /// InventorySummaryRow
    /// </summary>
    [DataContract]
    public partial class InventorySummaryRow : Entity,  IEquatable<InventorySummaryRow>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InventorySummaryRow" /> class.
        /// </summary>
        /// <param name="baseUOM">baseUOM.</param>
        /// <param name="estimatedTotalCost">estimatedTotalCost.</param>
        /// <param name="estimatedUnitCost">estimatedUnitCost.</param>
        /// <param name="expirationDate">expirationDate.</param>
        /// <param name="locationID">locationID.</param>
        /// <param name="lotSerialNbr">lotSerialNbr.</param>
        /// <param name="qtyAvailable">qtyAvailable.</param>
        /// <param name="qtyAvailableForShipment">qtyAvailableForShipment.</param>
        /// <param name="qtyNotAvailable">qtyNotAvailable.</param>
        /// <param name="qtyOnHand">qtyOnHand.</param>
        /// <param name="subitem">subitem.</param>
        /// <param name="warehouseID">warehouseID.</param>
        public InventorySummaryRow(StringValue baseUOM = default(StringValue), DecimalValue estimatedTotalCost = default(DecimalValue), DecimalValue estimatedUnitCost = default(DecimalValue), DateTimeValue expirationDate = default(DateTimeValue), StringValue locationID = default(StringValue), StringValue lotSerialNbr = default(StringValue), DecimalValue qtyAvailable = default(DecimalValue), DecimalValue qtyAvailableForShipment = default(DecimalValue), DecimalValue qtyNotAvailable = default(DecimalValue), DecimalValue qtyOnHand = default(DecimalValue), StringValue subitem = default(StringValue), StringValue warehouseID = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.BaseUOM = baseUOM;
            this.EstimatedTotalCost = estimatedTotalCost;
            this.EstimatedUnitCost = estimatedUnitCost;
            this.ExpirationDate = expirationDate;
            this.LocationID = locationID;
            this.LotSerialNbr = lotSerialNbr;
            this.QtyAvailable = qtyAvailable;
            this.QtyAvailableForShipment = qtyAvailableForShipment;
            this.QtyNotAvailable = qtyNotAvailable;
            this.QtyOnHand = qtyOnHand;
            this.Subitem = subitem;
            this.WarehouseID = warehouseID;
        }

        /// <summary>
        /// Gets or Sets BaseUOM
        /// </summary>
        [DataMember(Name="BaseUOM", EmitDefaultValue=false)]
        public StringValue BaseUOM { get; set; }

        /// <summary>
        /// Gets or Sets EstimatedTotalCost
        /// </summary>
        [DataMember(Name="EstimatedTotalCost", EmitDefaultValue=false)]
        public DecimalValue EstimatedTotalCost { get; set; }

        /// <summary>
        /// Gets or Sets EstimatedUnitCost
        /// </summary>
        [DataMember(Name="EstimatedUnitCost", EmitDefaultValue=false)]
        public DecimalValue EstimatedUnitCost { get; set; }

        /// <summary>
        /// Gets or Sets ExpirationDate
        /// </summary>
        [DataMember(Name="ExpirationDate", EmitDefaultValue=false)]
        public DateTimeValue ExpirationDate { get; set; }

        /// <summary>
        /// Gets or Sets LocationID
        /// </summary>
        [DataMember(Name="LocationID", EmitDefaultValue=false)]
        public StringValue LocationID { get; set; }

        /// <summary>
        /// Gets or Sets LotSerialNbr
        /// </summary>
        [DataMember(Name="LotSerialNbr", EmitDefaultValue=false)]
        public StringValue LotSerialNbr { get; set; }

        /// <summary>
        /// Gets or Sets QtyAvailable
        /// </summary>
        [DataMember(Name="QtyAvailable", EmitDefaultValue=false)]
        public DecimalValue QtyAvailable { get; set; }

        /// <summary>
        /// Gets or Sets QtyAvailableForShipment
        /// </summary>
        [DataMember(Name="QtyAvailableForShipment", EmitDefaultValue=false)]
        public DecimalValue QtyAvailableForShipment { get; set; }

        /// <summary>
        /// Gets or Sets QtyNotAvailable
        /// </summary>
        [DataMember(Name="QtyNotAvailable", EmitDefaultValue=false)]
        public DecimalValue QtyNotAvailable { get; set; }

        /// <summary>
        /// Gets or Sets QtyOnHand
        /// </summary>
        [DataMember(Name="QtyOnHand", EmitDefaultValue=false)]
        public DecimalValue QtyOnHand { get; set; }

        /// <summary>
        /// Gets or Sets Subitem
        /// </summary>
        [DataMember(Name="Subitem", EmitDefaultValue=false)]
        public StringValue Subitem { get; set; }

        /// <summary>
        /// Gets or Sets WarehouseID
        /// </summary>
        [DataMember(Name="WarehouseID", EmitDefaultValue=false)]
        public StringValue WarehouseID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InventorySummaryRow {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  BaseUOM: ").Append(BaseUOM).Append("\n");
            sb.Append("  EstimatedTotalCost: ").Append(EstimatedTotalCost).Append("\n");
            sb.Append("  EstimatedUnitCost: ").Append(EstimatedUnitCost).Append("\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
            sb.Append("  LocationID: ").Append(LocationID).Append("\n");
            sb.Append("  LotSerialNbr: ").Append(LotSerialNbr).Append("\n");
            sb.Append("  QtyAvailable: ").Append(QtyAvailable).Append("\n");
            sb.Append("  QtyAvailableForShipment: ").Append(QtyAvailableForShipment).Append("\n");
            sb.Append("  QtyNotAvailable: ").Append(QtyNotAvailable).Append("\n");
            sb.Append("  QtyOnHand: ").Append(QtyOnHand).Append("\n");
            sb.Append("  Subitem: ").Append(Subitem).Append("\n");
            sb.Append("  WarehouseID: ").Append(WarehouseID).Append("\n");
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
            return this.Equals(input as InventorySummaryRow);
        }

        /// <summary>
        /// Returns true if InventorySummaryRow instances are equal
        /// </summary>
        /// <param name="input">Instance of InventorySummaryRow to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InventorySummaryRow input)
        {
            if (input == null)
                return false;

            return base.Equals(input) &&
                (
                    this.BaseUOM == input.BaseUOM ||
                    (this.BaseUOM != null &&
                    this.BaseUOM.Equals(input.BaseUOM))
                ) && base.Equals(input) &&
                (
                    this.EstimatedTotalCost == input.EstimatedTotalCost ||
                    (this.EstimatedTotalCost != null &&
                    this.EstimatedTotalCost.Equals(input.EstimatedTotalCost))
                ) && base.Equals(input) &&
                (
                    this.EstimatedUnitCost == input.EstimatedUnitCost ||
                    (this.EstimatedUnitCost != null &&
                    this.EstimatedUnitCost.Equals(input.EstimatedUnitCost))
                ) && base.Equals(input) &&
                (
                    this.ExpirationDate == input.ExpirationDate ||
                    (this.ExpirationDate != null &&
                    this.ExpirationDate.Equals(input.ExpirationDate))
                ) && base.Equals(input) &&
                (
                    this.LocationID == input.LocationID ||
                    (this.LocationID != null &&
                    this.LocationID.Equals(input.LocationID))
                ) && base.Equals(input) &&
                (
                    this.LotSerialNbr == input.LotSerialNbr ||
                    (this.LotSerialNbr != null &&
                    this.LotSerialNbr.Equals(input.LotSerialNbr))
                ) && base.Equals(input) &&
                (
                    this.QtyAvailable == input.QtyAvailable ||
                    (this.QtyAvailable != null &&
                    this.QtyAvailable.Equals(input.QtyAvailable))
                ) && base.Equals(input) &&
                (
                    this.QtyAvailableForShipment == input.QtyAvailableForShipment ||
                    (this.QtyAvailableForShipment != null &&
                    this.QtyAvailableForShipment.Equals(input.QtyAvailableForShipment))
                ) && base.Equals(input) &&
                (
                    this.QtyNotAvailable == input.QtyNotAvailable ||
                    (this.QtyNotAvailable != null &&
                    this.QtyNotAvailable.Equals(input.QtyNotAvailable))
                ) && base.Equals(input) &&
                (
                    this.QtyOnHand == input.QtyOnHand ||
                    (this.QtyOnHand != null &&
                    this.QtyOnHand.Equals(input.QtyOnHand))
                ) && base.Equals(input) &&
                (
                    this.Subitem == input.Subitem ||
                    (this.Subitem != null &&
                    this.Subitem.Equals(input.Subitem))
                ) && base.Equals(input) &&
                (
                    this.WarehouseID == input.WarehouseID ||
                    (this.WarehouseID != null &&
                    this.WarehouseID.Equals(input.WarehouseID))
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
                if (this.BaseUOM != null)
                    hashCode = hashCode * 59 + this.BaseUOM.GetHashCode();
                if (this.EstimatedTotalCost != null)
                    hashCode = hashCode * 59 + this.EstimatedTotalCost.GetHashCode();
                if (this.EstimatedUnitCost != null)
                    hashCode = hashCode * 59 + this.EstimatedUnitCost.GetHashCode();
                if (this.ExpirationDate != null)
                    hashCode = hashCode * 59 + this.ExpirationDate.GetHashCode();
                if (this.LocationID != null)
                    hashCode = hashCode * 59 + this.LocationID.GetHashCode();
                if (this.LotSerialNbr != null)
                    hashCode = hashCode * 59 + this.LotSerialNbr.GetHashCode();
                if (this.QtyAvailable != null)
                    hashCode = hashCode * 59 + this.QtyAvailable.GetHashCode();
                if (this.QtyAvailableForShipment != null)
                    hashCode = hashCode * 59 + this.QtyAvailableForShipment.GetHashCode();
                if (this.QtyNotAvailable != null)
                    hashCode = hashCode * 59 + this.QtyNotAvailable.GetHashCode();
                if (this.QtyOnHand != null)
                    hashCode = hashCode * 59 + this.QtyOnHand.GetHashCode();
                if (this.Subitem != null)
                    hashCode = hashCode * 59 + this.Subitem.GetHashCode();
                if (this.WarehouseID != null)
                    hashCode = hashCode * 59 + this.WarehouseID.GetHashCode();
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
