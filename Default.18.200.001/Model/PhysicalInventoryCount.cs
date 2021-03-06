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
    /// PhysicalInventoryCount
    /// </summary>
    [DataContract]
    public partial class PhysicalInventoryCount : Entity,  IEquatable<PhysicalInventoryCount>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PhysicalInventoryCount" /> class.
        /// </summary>
        /// <param name="details">details.</param>
        /// <param name="inventoryID">inventoryID.</param>
        /// <param name="location">location.</param>
        /// <param name="lotSerialNbr">lotSerialNbr.</param>
        /// <param name="referenceNbr">referenceNbr.</param>
        /// <param name="subitem">subitem.</param>
        public PhysicalInventoryCount(List<PhysicalInventoryCountDetail> details = default(List<PhysicalInventoryCountDetail>), StringValue inventoryID = default(StringValue), StringValue location = default(StringValue), StringValue lotSerialNbr = default(StringValue), StringValue referenceNbr = default(StringValue), StringValue subitem = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.Details = details;
            this.InventoryID = inventoryID;
            this.Location = location;
            this.LotSerialNbr = lotSerialNbr;
            this.ReferenceNbr = referenceNbr;
            this.Subitem = subitem;
        }

        /// <summary>
        /// Gets or Sets Details
        /// </summary>
        [DataMember(Name="Details", EmitDefaultValue=false)]
        public List<PhysicalInventoryCountDetail> Details { get; set; }

        /// <summary>
        /// Gets or Sets InventoryID
        /// </summary>
        [DataMember(Name="InventoryID", EmitDefaultValue=false)]
        public StringValue InventoryID { get; set; }

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
        /// Gets or Sets ReferenceNbr
        /// </summary>
        [DataMember(Name="ReferenceNbr", EmitDefaultValue=false)]
        public StringValue ReferenceNbr { get; set; }

        /// <summary>
        /// Gets or Sets Subitem
        /// </summary>
        [DataMember(Name="Subitem", EmitDefaultValue=false)]
        public StringValue Subitem { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PhysicalInventoryCount {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  InventoryID: ").Append(InventoryID).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  LotSerialNbr: ").Append(LotSerialNbr).Append("\n");
            sb.Append("  ReferenceNbr: ").Append(ReferenceNbr).Append("\n");
            sb.Append("  Subitem: ").Append(Subitem).Append("\n");
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
            return this.Equals(input as PhysicalInventoryCount);
        }

        /// <summary>
        /// Returns true if PhysicalInventoryCount instances are equal
        /// </summary>
        /// <param name="input">Instance of PhysicalInventoryCount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PhysicalInventoryCount input)
        {
            if (input == null)
                return false;

            return base.Equals(input) &&
                (
                    this.Details == input.Details ||
                    this.Details != null &&
                    this.Details.SequenceEqual(input.Details)
                ) && base.Equals(input) &&
                (
                    this.InventoryID == input.InventoryID ||
                    (this.InventoryID != null &&
                    this.InventoryID.Equals(input.InventoryID))
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
                    this.ReferenceNbr == input.ReferenceNbr ||
                    (this.ReferenceNbr != null &&
                    this.ReferenceNbr.Equals(input.ReferenceNbr))
                ) && base.Equals(input) &&
                (
                    this.Subitem == input.Subitem ||
                    (this.Subitem != null &&
                    this.Subitem.Equals(input.Subitem))
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
                if (this.Details != null)
                    hashCode = hashCode * 59 + this.Details.GetHashCode();
                if (this.InventoryID != null)
                    hashCode = hashCode * 59 + this.InventoryID.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.LotSerialNbr != null)
                    hashCode = hashCode * 59 + this.LotSerialNbr.GetHashCode();
                if (this.ReferenceNbr != null)
                    hashCode = hashCode * 59 + this.ReferenceNbr.GetHashCode();
                if (this.Subitem != null)
                    hashCode = hashCode * 59 + this.Subitem.GetHashCode();
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
