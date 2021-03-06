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
    /// InventoryReceiptDetail
    /// </summary>
    [DataContract]
    public partial class InventoryReceiptDetail : Entity,  IEquatable<InventoryReceiptDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InventoryReceiptDetail" /> class.
        /// </summary>
        /// <param name="allocations">allocations.</param>
        /// <param name="costCode">costCode.</param>
        /// <param name="description">description.</param>
        /// <param name="expirationDate">expirationDate.</param>
        /// <param name="extCost">extCost.</param>
        /// <param name="inventoryID">inventoryID.</param>
        /// <param name="lineNumber">lineNumber.</param>
        /// <param name="location">location.</param>
        /// <param name="lotSerialNbr">lotSerialNbr.</param>
        /// <param name="project">project.</param>
        /// <param name="projectTask">projectTask.</param>
        /// <param name="qty">qty.</param>
        /// <param name="subitem">subitem.</param>
        /// <param name="unitCost">unitCost.</param>
        /// <param name="uOM">uOM.</param>
        /// <param name="warehouseID">warehouseID.</param>
        public InventoryReceiptDetail(List<InventoryReceiptDetailAllocation> allocations = default(List<InventoryReceiptDetailAllocation>), StringValue costCode = default(StringValue), StringValue description = default(StringValue), DateTimeValue expirationDate = default(DateTimeValue), DecimalValue extCost = default(DecimalValue), StringValue inventoryID = default(StringValue), IntValue lineNumber = default(IntValue), StringValue location = default(StringValue), StringValue lotSerialNbr = default(StringValue), StringValue project = default(StringValue), StringValue projectTask = default(StringValue), DecimalValue qty = default(DecimalValue), StringValue subitem = default(StringValue), DecimalValue unitCost = default(DecimalValue), StringValue uOM = default(StringValue), StringValue warehouseID = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.Allocations = allocations;
            this.CostCode = costCode;
            this.Description = description;
            this.ExpirationDate = expirationDate;
            this.ExtCost = extCost;
            this.InventoryID = inventoryID;
            this.LineNumber = lineNumber;
            this.Location = location;
            this.LotSerialNbr = lotSerialNbr;
            this.Project = project;
            this.ProjectTask = projectTask;
            this.Qty = qty;
            this.Subitem = subitem;
            this.UnitCost = unitCost;
            this.UOM = uOM;
            this.WarehouseID = warehouseID;
        }

        /// <summary>
        /// Gets or Sets Allocations
        /// </summary>
        [DataMember(Name="Allocations", EmitDefaultValue=false)]
        public List<InventoryReceiptDetailAllocation> Allocations { get; set; }

        /// <summary>
        /// Gets or Sets CostCode
        /// </summary>
        [DataMember(Name="CostCode", EmitDefaultValue=false)]
        public StringValue CostCode { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public StringValue Description { get; set; }

        /// <summary>
        /// Gets or Sets ExpirationDate
        /// </summary>
        [DataMember(Name="ExpirationDate", EmitDefaultValue=false)]
        public DateTimeValue ExpirationDate { get; set; }

        /// <summary>
        /// Gets or Sets ExtCost
        /// </summary>
        [DataMember(Name="ExtCost", EmitDefaultValue=false)]
        public DecimalValue ExtCost { get; set; }

        /// <summary>
        /// Gets or Sets InventoryID
        /// </summary>
        [DataMember(Name="InventoryID", EmitDefaultValue=false)]
        public StringValue InventoryID { get; set; }

        /// <summary>
        /// Gets or Sets LineNumber
        /// </summary>
        [DataMember(Name="LineNumber", EmitDefaultValue=false)]
        public IntValue LineNumber { get; set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name="Location", EmitDefaultValue=false)]
        public StringValue Location { get; set; }

        /// <summary>
        /// Gets or Sets LotSerialNbr
        /// </summary>
        [DataMember(Name="LotSerialNbr", EmitDefaultValue=false)]
        public StringValue LotSerialNbr { get; set; }

        /// <summary>
        /// Gets or Sets Project
        /// </summary>
        [DataMember(Name="Project", EmitDefaultValue=false)]
        public StringValue Project { get; set; }

        /// <summary>
        /// Gets or Sets ProjectTask
        /// </summary>
        [DataMember(Name="ProjectTask", EmitDefaultValue=false)]
        public StringValue ProjectTask { get; set; }

        /// <summary>
        /// Gets or Sets Qty
        /// </summary>
        [DataMember(Name="Qty", EmitDefaultValue=false)]
        public DecimalValue Qty { get; set; }

        /// <summary>
        /// Gets or Sets Subitem
        /// </summary>
        [DataMember(Name="Subitem", EmitDefaultValue=false)]
        public StringValue Subitem { get; set; }

        /// <summary>
        /// Gets or Sets UnitCost
        /// </summary>
        [DataMember(Name="UnitCost", EmitDefaultValue=false)]
        public DecimalValue UnitCost { get; set; }

        /// <summary>
        /// Gets or Sets UOM
        /// </summary>
        [DataMember(Name="UOM", EmitDefaultValue=false)]
        public StringValue UOM { get; set; }

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
            sb.Append("class InventoryReceiptDetail {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Allocations: ").Append(Allocations).Append("\n");
            sb.Append("  CostCode: ").Append(CostCode).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
            sb.Append("  ExtCost: ").Append(ExtCost).Append("\n");
            sb.Append("  InventoryID: ").Append(InventoryID).Append("\n");
            sb.Append("  LineNumber: ").Append(LineNumber).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  LotSerialNbr: ").Append(LotSerialNbr).Append("\n");
            sb.Append("  Project: ").Append(Project).Append("\n");
            sb.Append("  ProjectTask: ").Append(ProjectTask).Append("\n");
            sb.Append("  Qty: ").Append(Qty).Append("\n");
            sb.Append("  Subitem: ").Append(Subitem).Append("\n");
            sb.Append("  UnitCost: ").Append(UnitCost).Append("\n");
            sb.Append("  UOM: ").Append(UOM).Append("\n");
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
            return this.Equals(input as InventoryReceiptDetail);
        }

        /// <summary>
        /// Returns true if InventoryReceiptDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of InventoryReceiptDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InventoryReceiptDetail input)
        {
            if (input == null)
                return false;

            return base.Equals(input) &&
                (
                    this.Allocations == input.Allocations ||
                    this.Allocations != null &&
                    this.Allocations.SequenceEqual(input.Allocations)
                ) && base.Equals(input) &&
                (
                    this.CostCode == input.CostCode ||
                    (this.CostCode != null &&
                    this.CostCode.Equals(input.CostCode))
                ) && base.Equals(input) &&
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && base.Equals(input) &&
                (
                    this.ExpirationDate == input.ExpirationDate ||
                    (this.ExpirationDate != null &&
                    this.ExpirationDate.Equals(input.ExpirationDate))
                ) && base.Equals(input) &&
                (
                    this.ExtCost == input.ExtCost ||
                    (this.ExtCost != null &&
                    this.ExtCost.Equals(input.ExtCost))
                ) && base.Equals(input) &&
                (
                    this.InventoryID == input.InventoryID ||
                    (this.InventoryID != null &&
                    this.InventoryID.Equals(input.InventoryID))
                ) && base.Equals(input) &&
                (
                    this.LineNumber == input.LineNumber ||
                    (this.LineNumber != null &&
                    this.LineNumber.Equals(input.LineNumber))
                ) && base.Equals(input) &&
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && base.Equals(input) &&
                (
                    this.LotSerialNbr == input.LotSerialNbr ||
                    (this.LotSerialNbr != null &&
                    this.LotSerialNbr.Equals(input.LotSerialNbr))
                ) && base.Equals(input) &&
                (
                    this.Project == input.Project ||
                    (this.Project != null &&
                    this.Project.Equals(input.Project))
                ) && base.Equals(input) &&
                (
                    this.ProjectTask == input.ProjectTask ||
                    (this.ProjectTask != null &&
                    this.ProjectTask.Equals(input.ProjectTask))
                ) && base.Equals(input) &&
                (
                    this.Qty == input.Qty ||
                    (this.Qty != null &&
                    this.Qty.Equals(input.Qty))
                ) && base.Equals(input) &&
                (
                    this.Subitem == input.Subitem ||
                    (this.Subitem != null &&
                    this.Subitem.Equals(input.Subitem))
                ) && base.Equals(input) &&
                (
                    this.UnitCost == input.UnitCost ||
                    (this.UnitCost != null &&
                    this.UnitCost.Equals(input.UnitCost))
                ) && base.Equals(input) &&
                (
                    this.UOM == input.UOM ||
                    (this.UOM != null &&
                    this.UOM.Equals(input.UOM))
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
                if (this.Allocations != null)
                    hashCode = hashCode * 59 + this.Allocations.GetHashCode();
                if (this.CostCode != null)
                    hashCode = hashCode * 59 + this.CostCode.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ExpirationDate != null)
                    hashCode = hashCode * 59 + this.ExpirationDate.GetHashCode();
                if (this.ExtCost != null)
                    hashCode = hashCode * 59 + this.ExtCost.GetHashCode();
                if (this.InventoryID != null)
                    hashCode = hashCode * 59 + this.InventoryID.GetHashCode();
                if (this.LineNumber != null)
                    hashCode = hashCode * 59 + this.LineNumber.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.LotSerialNbr != null)
                    hashCode = hashCode * 59 + this.LotSerialNbr.GetHashCode();
                if (this.Project != null)
                    hashCode = hashCode * 59 + this.Project.GetHashCode();
                if (this.ProjectTask != null)
                    hashCode = hashCode * 59 + this.ProjectTask.GetHashCode();
                if (this.Qty != null)
                    hashCode = hashCode * 59 + this.Qty.GetHashCode();
                if (this.Subitem != null)
                    hashCode = hashCode * 59 + this.Subitem.GetHashCode();
                if (this.UnitCost != null)
                    hashCode = hashCode * 59 + this.UnitCost.GetHashCode();
                if (this.UOM != null)
                    hashCode = hashCode * 59 + this.UOM.GetHashCode();
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
