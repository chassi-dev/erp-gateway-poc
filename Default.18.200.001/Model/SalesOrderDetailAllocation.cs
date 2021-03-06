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
    /// SalesOrderDetailAllocation
    /// </summary>
    [DataContract]
    public partial class SalesOrderDetailAllocation : Entity,  IEquatable<SalesOrderDetailAllocation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesOrderDetailAllocation" /> class.
        /// </summary>
        /// <param name="allocated">allocated.</param>
        /// <param name="allocWarehouseID">allocWarehouseID.</param>
        /// <param name="completed">completed.</param>
        /// <param name="expirationDate">expirationDate.</param>
        /// <param name="inventoryID">inventoryID.</param>
        /// <param name="lineNbr">lineNbr.</param>
        /// <param name="locationID">locationID.</param>
        /// <param name="lotSerialNbr">lotSerialNbr.</param>
        /// <param name="orderNbr">orderNbr.</param>
        /// <param name="orderType">orderType.</param>
        /// <param name="qty">qty.</param>
        /// <param name="qtyOnShipments">qtyOnShipments.</param>
        /// <param name="qtyReceived">qtyReceived.</param>
        /// <param name="relatedDocument">relatedDocument.</param>
        /// <param name="shipOn">shipOn.</param>
        /// <param name="splitLineNbr">splitLineNbr.</param>
        /// <param name="subitem">subitem.</param>
        /// <param name="uOM">uOM.</param>
        public SalesOrderDetailAllocation(BooleanValue allocated = default(BooleanValue), StringValue allocWarehouseID = default(StringValue), BooleanValue completed = default(BooleanValue), DateTimeValue expirationDate = default(DateTimeValue), StringValue inventoryID = default(StringValue), IntValue lineNbr = default(IntValue), StringValue locationID = default(StringValue), StringValue lotSerialNbr = default(StringValue), StringValue orderNbr = default(StringValue), StringValue orderType = default(StringValue), DecimalValue qty = default(DecimalValue), DecimalValue qtyOnShipments = default(DecimalValue), DecimalValue qtyReceived = default(DecimalValue), StringValue relatedDocument = default(StringValue), DateTimeValue shipOn = default(DateTimeValue), IntValue splitLineNbr = default(IntValue), StringValue subitem = default(StringValue), StringValue uOM = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.Allocated = allocated;
            this.AllocWarehouseID = allocWarehouseID;
            this.Completed = completed;
            this.ExpirationDate = expirationDate;
            this.InventoryID = inventoryID;
            this.LineNbr = lineNbr;
            this.LocationID = locationID;
            this.LotSerialNbr = lotSerialNbr;
            this.OrderNbr = orderNbr;
            this.OrderType = orderType;
            this.Qty = qty;
            this.QtyOnShipments = qtyOnShipments;
            this.QtyReceived = qtyReceived;
            this.RelatedDocument = relatedDocument;
            this.ShipOn = shipOn;
            this.SplitLineNbr = splitLineNbr;
            this.Subitem = subitem;
            this.UOM = uOM;
        }

        /// <summary>
        /// Gets or Sets Allocated
        /// </summary>
        [DataMember(Name="Allocated", EmitDefaultValue=false)]
        public BooleanValue Allocated { get; set; }

        /// <summary>
        /// Gets or Sets AllocWarehouseID
        /// </summary>
        [DataMember(Name="AllocWarehouseID", EmitDefaultValue=false)]
        public StringValue AllocWarehouseID { get; set; }

        /// <summary>
        /// Gets or Sets Completed
        /// </summary>
        [DataMember(Name="Completed", EmitDefaultValue=false)]
        public BooleanValue Completed { get; set; }

        /// <summary>
        /// Gets or Sets ExpirationDate
        /// </summary>
        [DataMember(Name="ExpirationDate", EmitDefaultValue=false)]
        public DateTimeValue ExpirationDate { get; set; }

        /// <summary>
        /// Gets or Sets InventoryID
        /// </summary>
        [DataMember(Name="InventoryID", EmitDefaultValue=false)]
        public StringValue InventoryID { get; set; }

        /// <summary>
        /// Gets or Sets LineNbr
        /// </summary>
        [DataMember(Name="LineNbr", EmitDefaultValue=false)]
        public IntValue LineNbr { get; set; }

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
        /// Gets or Sets OrderNbr
        /// </summary>
        [DataMember(Name="OrderNbr", EmitDefaultValue=false)]
        public StringValue OrderNbr { get; set; }

        /// <summary>
        /// Gets or Sets OrderType
        /// </summary>
        [DataMember(Name="OrderType", EmitDefaultValue=false)]
        public StringValue OrderType { get; set; }

        /// <summary>
        /// Gets or Sets Qty
        /// </summary>
        [DataMember(Name="Qty", EmitDefaultValue=false)]
        public DecimalValue Qty { get; set; }

        /// <summary>
        /// Gets or Sets QtyOnShipments
        /// </summary>
        [DataMember(Name="QtyOnShipments", EmitDefaultValue=false)]
        public DecimalValue QtyOnShipments { get; set; }

        /// <summary>
        /// Gets or Sets QtyReceived
        /// </summary>
        [DataMember(Name="QtyReceived", EmitDefaultValue=false)]
        public DecimalValue QtyReceived { get; set; }

        /// <summary>
        /// Gets or Sets RelatedDocument
        /// </summary>
        [DataMember(Name="RelatedDocument", EmitDefaultValue=false)]
        public StringValue RelatedDocument { get; set; }

        /// <summary>
        /// Gets or Sets ShipOn
        /// </summary>
        [DataMember(Name="ShipOn", EmitDefaultValue=false)]
        public DateTimeValue ShipOn { get; set; }

        /// <summary>
        /// Gets or Sets SplitLineNbr
        /// </summary>
        [DataMember(Name="SplitLineNbr", EmitDefaultValue=false)]
        public IntValue SplitLineNbr { get; set; }

        /// <summary>
        /// Gets or Sets Subitem
        /// </summary>
        [DataMember(Name="Subitem", EmitDefaultValue=false)]
        public StringValue Subitem { get; set; }

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
            sb.Append("class SalesOrderDetailAllocation {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Allocated: ").Append(Allocated).Append("\n");
            sb.Append("  AllocWarehouseID: ").Append(AllocWarehouseID).Append("\n");
            sb.Append("  Completed: ").Append(Completed).Append("\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
            sb.Append("  InventoryID: ").Append(InventoryID).Append("\n");
            sb.Append("  LineNbr: ").Append(LineNbr).Append("\n");
            sb.Append("  LocationID: ").Append(LocationID).Append("\n");
            sb.Append("  LotSerialNbr: ").Append(LotSerialNbr).Append("\n");
            sb.Append("  OrderNbr: ").Append(OrderNbr).Append("\n");
            sb.Append("  OrderType: ").Append(OrderType).Append("\n");
            sb.Append("  Qty: ").Append(Qty).Append("\n");
            sb.Append("  QtyOnShipments: ").Append(QtyOnShipments).Append("\n");
            sb.Append("  QtyReceived: ").Append(QtyReceived).Append("\n");
            sb.Append("  RelatedDocument: ").Append(RelatedDocument).Append("\n");
            sb.Append("  ShipOn: ").Append(ShipOn).Append("\n");
            sb.Append("  SplitLineNbr: ").Append(SplitLineNbr).Append("\n");
            sb.Append("  Subitem: ").Append(Subitem).Append("\n");
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
            return this.Equals(input as SalesOrderDetailAllocation);
        }

        /// <summary>
        /// Returns true if SalesOrderDetailAllocation instances are equal
        /// </summary>
        /// <param name="input">Instance of SalesOrderDetailAllocation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SalesOrderDetailAllocation input)
        {
            if (input == null)
                return false;

            return base.Equals(input) &&
                (
                    this.Allocated == input.Allocated ||
                    (this.Allocated != null &&
                    this.Allocated.Equals(input.Allocated))
                ) && base.Equals(input) &&
                (
                    this.AllocWarehouseID == input.AllocWarehouseID ||
                    (this.AllocWarehouseID != null &&
                    this.AllocWarehouseID.Equals(input.AllocWarehouseID))
                ) && base.Equals(input) &&
                (
                    this.Completed == input.Completed ||
                    (this.Completed != null &&
                    this.Completed.Equals(input.Completed))
                ) && base.Equals(input) &&
                (
                    this.ExpirationDate == input.ExpirationDate ||
                    (this.ExpirationDate != null &&
                    this.ExpirationDate.Equals(input.ExpirationDate))
                ) && base.Equals(input) &&
                (
                    this.InventoryID == input.InventoryID ||
                    (this.InventoryID != null &&
                    this.InventoryID.Equals(input.InventoryID))
                ) && base.Equals(input) &&
                (
                    this.LineNbr == input.LineNbr ||
                    (this.LineNbr != null &&
                    this.LineNbr.Equals(input.LineNbr))
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
                    this.OrderNbr == input.OrderNbr ||
                    (this.OrderNbr != null &&
                    this.OrderNbr.Equals(input.OrderNbr))
                ) && base.Equals(input) &&
                (
                    this.OrderType == input.OrderType ||
                    (this.OrderType != null &&
                    this.OrderType.Equals(input.OrderType))
                ) && base.Equals(input) &&
                (
                    this.Qty == input.Qty ||
                    (this.Qty != null &&
                    this.Qty.Equals(input.Qty))
                ) && base.Equals(input) &&
                (
                    this.QtyOnShipments == input.QtyOnShipments ||
                    (this.QtyOnShipments != null &&
                    this.QtyOnShipments.Equals(input.QtyOnShipments))
                ) && base.Equals(input) &&
                (
                    this.QtyReceived == input.QtyReceived ||
                    (this.QtyReceived != null &&
                    this.QtyReceived.Equals(input.QtyReceived))
                ) && base.Equals(input) &&
                (
                    this.RelatedDocument == input.RelatedDocument ||
                    (this.RelatedDocument != null &&
                    this.RelatedDocument.Equals(input.RelatedDocument))
                ) && base.Equals(input) &&
                (
                    this.ShipOn == input.ShipOn ||
                    (this.ShipOn != null &&
                    this.ShipOn.Equals(input.ShipOn))
                ) && base.Equals(input) &&
                (
                    this.SplitLineNbr == input.SplitLineNbr ||
                    (this.SplitLineNbr != null &&
                    this.SplitLineNbr.Equals(input.SplitLineNbr))
                ) && base.Equals(input) &&
                (
                    this.Subitem == input.Subitem ||
                    (this.Subitem != null &&
                    this.Subitem.Equals(input.Subitem))
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
                if (this.Allocated != null)
                    hashCode = hashCode * 59 + this.Allocated.GetHashCode();
                if (this.AllocWarehouseID != null)
                    hashCode = hashCode * 59 + this.AllocWarehouseID.GetHashCode();
                if (this.Completed != null)
                    hashCode = hashCode * 59 + this.Completed.GetHashCode();
                if (this.ExpirationDate != null)
                    hashCode = hashCode * 59 + this.ExpirationDate.GetHashCode();
                if (this.InventoryID != null)
                    hashCode = hashCode * 59 + this.InventoryID.GetHashCode();
                if (this.LineNbr != null)
                    hashCode = hashCode * 59 + this.LineNbr.GetHashCode();
                if (this.LocationID != null)
                    hashCode = hashCode * 59 + this.LocationID.GetHashCode();
                if (this.LotSerialNbr != null)
                    hashCode = hashCode * 59 + this.LotSerialNbr.GetHashCode();
                if (this.OrderNbr != null)
                    hashCode = hashCode * 59 + this.OrderNbr.GetHashCode();
                if (this.OrderType != null)
                    hashCode = hashCode * 59 + this.OrderType.GetHashCode();
                if (this.Qty != null)
                    hashCode = hashCode * 59 + this.Qty.GetHashCode();
                if (this.QtyOnShipments != null)
                    hashCode = hashCode * 59 + this.QtyOnShipments.GetHashCode();
                if (this.QtyReceived != null)
                    hashCode = hashCode * 59 + this.QtyReceived.GetHashCode();
                if (this.RelatedDocument != null)
                    hashCode = hashCode * 59 + this.RelatedDocument.GetHashCode();
                if (this.ShipOn != null)
                    hashCode = hashCode * 59 + this.ShipOn.GetHashCode();
                if (this.SplitLineNbr != null)
                    hashCode = hashCode * 59 + this.SplitLineNbr.GetHashCode();
                if (this.Subitem != null)
                    hashCode = hashCode * 59 + this.Subitem.GetHashCode();
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
