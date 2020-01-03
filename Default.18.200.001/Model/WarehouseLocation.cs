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
    /// WarehouseLocation
    /// </summary>
    [DataContract]
    public partial class WarehouseLocation : Entity,  IEquatable<WarehouseLocation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WarehouseLocation" /> class.
        /// </summary>
        /// <param name="active">active.</param>
        /// <param name="assemblyAllowed">assemblyAllowed.</param>
        /// <param name="description">description.</param>
        /// <param name="locationID">locationID.</param>
        /// <param name="pickPriority">pickPriority.</param>
        /// <param name="receiptsAllowed">receiptsAllowed.</param>
        /// <param name="salesAllowed">salesAllowed.</param>
        /// <param name="transfersAllowed">transfersAllowed.</param>
        public WarehouseLocation(BooleanValue active = default(BooleanValue), BooleanValue assemblyAllowed = default(BooleanValue), StringValue description = default(StringValue), StringValue locationID = default(StringValue), ShortValue pickPriority = default(ShortValue), BooleanValue receiptsAllowed = default(BooleanValue), BooleanValue salesAllowed = default(BooleanValue), BooleanValue transfersAllowed = default(BooleanValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.Active = active;
            this.AssemblyAllowed = assemblyAllowed;
            this.Description = description;
            this.LocationID = locationID;
            this.PickPriority = pickPriority;
            this.ReceiptsAllowed = receiptsAllowed;
            this.SalesAllowed = salesAllowed;
            this.TransfersAllowed = transfersAllowed;
        }

        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name="Active", EmitDefaultValue=false)]
        public BooleanValue Active { get; set; }

        /// <summary>
        /// Gets or Sets AssemblyAllowed
        /// </summary>
        [DataMember(Name="AssemblyAllowed", EmitDefaultValue=false)]
        public BooleanValue AssemblyAllowed { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public StringValue Description { get; set; }

        /// <summary>
        /// Gets or Sets LocationID
        /// </summary>
        [DataMember(Name="LocationID", EmitDefaultValue=false)]
        public StringValue LocationID { get; set; }

        /// <summary>
        /// Gets or Sets PickPriority
        /// </summary>
        [DataMember(Name="PickPriority", EmitDefaultValue=false)]
        public ShortValue PickPriority { get; set; }

        /// <summary>
        /// Gets or Sets ReceiptsAllowed
        /// </summary>
        [DataMember(Name="ReceiptsAllowed", EmitDefaultValue=false)]
        public BooleanValue ReceiptsAllowed { get; set; }

        /// <summary>
        /// Gets or Sets SalesAllowed
        /// </summary>
        [DataMember(Name="SalesAllowed", EmitDefaultValue=false)]
        public BooleanValue SalesAllowed { get; set; }

        /// <summary>
        /// Gets or Sets TransfersAllowed
        /// </summary>
        [DataMember(Name="TransfersAllowed", EmitDefaultValue=false)]
        public BooleanValue TransfersAllowed { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WarehouseLocation {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  AssemblyAllowed: ").Append(AssemblyAllowed).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  LocationID: ").Append(LocationID).Append("\n");
            sb.Append("  PickPriority: ").Append(PickPriority).Append("\n");
            sb.Append("  ReceiptsAllowed: ").Append(ReceiptsAllowed).Append("\n");
            sb.Append("  SalesAllowed: ").Append(SalesAllowed).Append("\n");
            sb.Append("  TransfersAllowed: ").Append(TransfersAllowed).Append("\n");
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
            return this.Equals(input as WarehouseLocation);
        }

        /// <summary>
        /// Returns true if WarehouseLocation instances are equal
        /// </summary>
        /// <param name="input">Instance of WarehouseLocation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WarehouseLocation input)
        {
            if (input == null)
                return false;

            return base.Equals(input) &&
                (
                    this.Active == input.Active ||
                    (this.Active != null &&
                    this.Active.Equals(input.Active))
                ) && base.Equals(input) &&
                (
                    this.AssemblyAllowed == input.AssemblyAllowed ||
                    (this.AssemblyAllowed != null &&
                    this.AssemblyAllowed.Equals(input.AssemblyAllowed))
                ) && base.Equals(input) &&
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && base.Equals(input) &&
                (
                    this.LocationID == input.LocationID ||
                    (this.LocationID != null &&
                    this.LocationID.Equals(input.LocationID))
                ) && base.Equals(input) &&
                (
                    this.PickPriority == input.PickPriority ||
                    (this.PickPriority != null &&
                    this.PickPriority.Equals(input.PickPriority))
                ) && base.Equals(input) &&
                (
                    this.ReceiptsAllowed == input.ReceiptsAllowed ||
                    (this.ReceiptsAllowed != null &&
                    this.ReceiptsAllowed.Equals(input.ReceiptsAllowed))
                ) && base.Equals(input) &&
                (
                    this.SalesAllowed == input.SalesAllowed ||
                    (this.SalesAllowed != null &&
                    this.SalesAllowed.Equals(input.SalesAllowed))
                ) && base.Equals(input) &&
                (
                    this.TransfersAllowed == input.TransfersAllowed ||
                    (this.TransfersAllowed != null &&
                    this.TransfersAllowed.Equals(input.TransfersAllowed))
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
                if (this.Active != null)
                    hashCode = hashCode * 59 + this.Active.GetHashCode();
                if (this.AssemblyAllowed != null)
                    hashCode = hashCode * 59 + this.AssemblyAllowed.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.LocationID != null)
                    hashCode = hashCode * 59 + this.LocationID.GetHashCode();
                if (this.PickPriority != null)
                    hashCode = hashCode * 59 + this.PickPriority.GetHashCode();
                if (this.ReceiptsAllowed != null)
                    hashCode = hashCode * 59 + this.ReceiptsAllowed.GetHashCode();
                if (this.SalesAllowed != null)
                    hashCode = hashCode * 59 + this.SalesAllowed.GetHashCode();
                if (this.TransfersAllowed != null)
                    hashCode = hashCode * 59 + this.TransfersAllowed.GetHashCode();
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
