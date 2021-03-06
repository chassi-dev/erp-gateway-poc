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
    /// BoxStockItem
    /// </summary>
    [DataContract]
    public partial class BoxStockItem : Entity,  IEquatable<BoxStockItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BoxStockItem" /> class.
        /// </summary>
        /// <param name="boxID">boxID.</param>
        /// <param name="description">description.</param>
        /// <param name="maxQty">maxQty.</param>
        /// <param name="maxVolume">maxVolume.</param>
        /// <param name="maxWeight">maxWeight.</param>
        /// <param name="qty">qty.</param>
        /// <param name="uOM">uOM.</param>
        public BoxStockItem(StringValue boxID = default(StringValue), StringValue description = default(StringValue), DecimalValue maxQty = default(DecimalValue), DecimalValue maxVolume = default(DecimalValue), DecimalValue maxWeight = default(DecimalValue), DecimalValue qty = default(DecimalValue), StringValue uOM = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.BoxID = boxID;
            this.Description = description;
            this.MaxQty = maxQty;
            this.MaxVolume = maxVolume;
            this.MaxWeight = maxWeight;
            this.Qty = qty;
            this.UOM = uOM;
        }

        /// <summary>
        /// Gets or Sets BoxID
        /// </summary>
        [DataMember(Name="BoxID", EmitDefaultValue=false)]
        public StringValue BoxID { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public StringValue Description { get; set; }

        /// <summary>
        /// Gets or Sets MaxQty
        /// </summary>
        [DataMember(Name="MaxQty", EmitDefaultValue=false)]
        public DecimalValue MaxQty { get; set; }

        /// <summary>
        /// Gets or Sets MaxVolume
        /// </summary>
        [DataMember(Name="MaxVolume", EmitDefaultValue=false)]
        public DecimalValue MaxVolume { get; set; }

        /// <summary>
        /// Gets or Sets MaxWeight
        /// </summary>
        [DataMember(Name="MaxWeight", EmitDefaultValue=false)]
        public DecimalValue MaxWeight { get; set; }

        /// <summary>
        /// Gets or Sets Qty
        /// </summary>
        [DataMember(Name="Qty", EmitDefaultValue=false)]
        public DecimalValue Qty { get; set; }

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
            sb.Append("class BoxStockItem {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  BoxID: ").Append(BoxID).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  MaxQty: ").Append(MaxQty).Append("\n");
            sb.Append("  MaxVolume: ").Append(MaxVolume).Append("\n");
            sb.Append("  MaxWeight: ").Append(MaxWeight).Append("\n");
            sb.Append("  Qty: ").Append(Qty).Append("\n");
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
            return this.Equals(input as BoxStockItem);
        }

        /// <summary>
        /// Returns true if BoxStockItem instances are equal
        /// </summary>
        /// <param name="input">Instance of BoxStockItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BoxStockItem input)
        {
            if (input == null)
                return false;

            return base.Equals(input) &&
                (
                    this.BoxID == input.BoxID ||
                    (this.BoxID != null &&
                    this.BoxID.Equals(input.BoxID))
                ) && base.Equals(input) &&
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && base.Equals(input) &&
                (
                    this.MaxQty == input.MaxQty ||
                    (this.MaxQty != null &&
                    this.MaxQty.Equals(input.MaxQty))
                ) && base.Equals(input) &&
                (
                    this.MaxVolume == input.MaxVolume ||
                    (this.MaxVolume != null &&
                    this.MaxVolume.Equals(input.MaxVolume))
                ) && base.Equals(input) &&
                (
                    this.MaxWeight == input.MaxWeight ||
                    (this.MaxWeight != null &&
                    this.MaxWeight.Equals(input.MaxWeight))
                ) && base.Equals(input) &&
                (
                    this.Qty == input.Qty ||
                    (this.Qty != null &&
                    this.Qty.Equals(input.Qty))
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
                if (this.BoxID != null)
                    hashCode = hashCode * 59 + this.BoxID.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.MaxQty != null)
                    hashCode = hashCode * 59 + this.MaxQty.GetHashCode();
                if (this.MaxVolume != null)
                    hashCode = hashCode * 59 + this.MaxVolume.GetHashCode();
                if (this.MaxWeight != null)
                    hashCode = hashCode * 59 + this.MaxWeight.GetHashCode();
                if (this.Qty != null)
                    hashCode = hashCode * 59 + this.Qty.GetHashCode();
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
