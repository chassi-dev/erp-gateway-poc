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
    /// ShippingBox
    /// </summary>
    [DataContract]
    public partial class ShippingBox : Entity,  IEquatable<ShippingBox>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShippingBox" /> class.
        /// </summary>
        /// <param name="activeByDefault">activeByDefault.</param>
        /// <param name="boxID">boxID.</param>
        /// <param name="boxWeight">boxWeight.</param>
        /// <param name="carriersPackage">carriersPackage.</param>
        /// <param name="description">description.</param>
        /// <param name="height">height.</param>
        /// <param name="length">length.</param>
        /// <param name="maxVolume">maxVolume.</param>
        /// <param name="maxWeight">maxWeight.</param>
        /// <param name="volumeUOM">volumeUOM.</param>
        /// <param name="weightUOM">weightUOM.</param>
        /// <param name="width">width.</param>
        public ShippingBox(BooleanValue activeByDefault = default(BooleanValue), StringValue boxID = default(StringValue), DecimalValue boxWeight = default(DecimalValue), StringValue carriersPackage = default(StringValue), StringValue description = default(StringValue), IntValue height = default(IntValue), IntValue length = default(IntValue), DecimalValue maxVolume = default(DecimalValue), DecimalValue maxWeight = default(DecimalValue), StringValue volumeUOM = default(StringValue), StringValue weightUOM = default(StringValue), IntValue width = default(IntValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.ActiveByDefault = activeByDefault;
            this.BoxID = boxID;
            this.BoxWeight = boxWeight;
            this.CarriersPackage = carriersPackage;
            this.Description = description;
            this.Height = height;
            this.Length = length;
            this.MaxVolume = maxVolume;
            this.MaxWeight = maxWeight;
            this.VolumeUOM = volumeUOM;
            this.WeightUOM = weightUOM;
            this.Width = width;
        }

        /// <summary>
        /// Gets or Sets ActiveByDefault
        /// </summary>
        [DataMember(Name="ActiveByDefault", EmitDefaultValue=false)]
        public BooleanValue ActiveByDefault { get; set; }

        /// <summary>
        /// Gets or Sets BoxID
        /// </summary>
        [DataMember(Name="BoxID", EmitDefaultValue=false)]
        public StringValue BoxID { get; set; }

        /// <summary>
        /// Gets or Sets BoxWeight
        /// </summary>
        [DataMember(Name="BoxWeight", EmitDefaultValue=false)]
        public DecimalValue BoxWeight { get; set; }

        /// <summary>
        /// Gets or Sets CarriersPackage
        /// </summary>
        [DataMember(Name="CarriersPackage", EmitDefaultValue=false)]
        public StringValue CarriersPackage { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public StringValue Description { get; set; }

        /// <summary>
        /// Gets or Sets Height
        /// </summary>
        [DataMember(Name="Height", EmitDefaultValue=false)]
        public IntValue Height { get; set; }

        /// <summary>
        /// Gets or Sets Length
        /// </summary>
        [DataMember(Name="Length", EmitDefaultValue=false)]
        public IntValue Length { get; set; }

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
        /// Gets or Sets VolumeUOM
        /// </summary>
        [DataMember(Name="VolumeUOM", EmitDefaultValue=false)]
        public StringValue VolumeUOM { get; set; }

        /// <summary>
        /// Gets or Sets WeightUOM
        /// </summary>
        [DataMember(Name="WeightUOM", EmitDefaultValue=false)]
        public StringValue WeightUOM { get; set; }

        /// <summary>
        /// Gets or Sets Width
        /// </summary>
        [DataMember(Name="Width", EmitDefaultValue=false)]
        public IntValue Width { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShippingBox {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  ActiveByDefault: ").Append(ActiveByDefault).Append("\n");
            sb.Append("  BoxID: ").Append(BoxID).Append("\n");
            sb.Append("  BoxWeight: ").Append(BoxWeight).Append("\n");
            sb.Append("  CarriersPackage: ").Append(CarriersPackage).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  Length: ").Append(Length).Append("\n");
            sb.Append("  MaxVolume: ").Append(MaxVolume).Append("\n");
            sb.Append("  MaxWeight: ").Append(MaxWeight).Append("\n");
            sb.Append("  VolumeUOM: ").Append(VolumeUOM).Append("\n");
            sb.Append("  WeightUOM: ").Append(WeightUOM).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
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
            return this.Equals(input as ShippingBox);
        }

        /// <summary>
        /// Returns true if ShippingBox instances are equal
        /// </summary>
        /// <param name="input">Instance of ShippingBox to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShippingBox input)
        {
            if (input == null)
                return false;

            return base.Equals(input) &&
                (
                    this.ActiveByDefault == input.ActiveByDefault ||
                    (this.ActiveByDefault != null &&
                    this.ActiveByDefault.Equals(input.ActiveByDefault))
                ) && base.Equals(input) &&
                (
                    this.BoxID == input.BoxID ||
                    (this.BoxID != null &&
                    this.BoxID.Equals(input.BoxID))
                ) && base.Equals(input) &&
                (
                    this.BoxWeight == input.BoxWeight ||
                    (this.BoxWeight != null &&
                    this.BoxWeight.Equals(input.BoxWeight))
                ) && base.Equals(input) &&
                (
                    this.CarriersPackage == input.CarriersPackage ||
                    (this.CarriersPackage != null &&
                    this.CarriersPackage.Equals(input.CarriersPackage))
                ) && base.Equals(input) &&
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && base.Equals(input) &&
                (
                    this.Height == input.Height ||
                    (this.Height != null &&
                    this.Height.Equals(input.Height))
                ) && base.Equals(input) &&
                (
                    this.Length == input.Length ||
                    (this.Length != null &&
                    this.Length.Equals(input.Length))
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
                    this.VolumeUOM == input.VolumeUOM ||
                    (this.VolumeUOM != null &&
                    this.VolumeUOM.Equals(input.VolumeUOM))
                ) && base.Equals(input) &&
                (
                    this.WeightUOM == input.WeightUOM ||
                    (this.WeightUOM != null &&
                    this.WeightUOM.Equals(input.WeightUOM))
                ) && base.Equals(input) &&
                (
                    this.Width == input.Width ||
                    (this.Width != null &&
                    this.Width.Equals(input.Width))
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
                if (this.ActiveByDefault != null)
                    hashCode = hashCode * 59 + this.ActiveByDefault.GetHashCode();
                if (this.BoxID != null)
                    hashCode = hashCode * 59 + this.BoxID.GetHashCode();
                if (this.BoxWeight != null)
                    hashCode = hashCode * 59 + this.BoxWeight.GetHashCode();
                if (this.CarriersPackage != null)
                    hashCode = hashCode * 59 + this.CarriersPackage.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Height != null)
                    hashCode = hashCode * 59 + this.Height.GetHashCode();
                if (this.Length != null)
                    hashCode = hashCode * 59 + this.Length.GetHashCode();
                if (this.MaxVolume != null)
                    hashCode = hashCode * 59 + this.MaxVolume.GetHashCode();
                if (this.MaxWeight != null)
                    hashCode = hashCode * 59 + this.MaxWeight.GetHashCode();
                if (this.VolumeUOM != null)
                    hashCode = hashCode * 59 + this.VolumeUOM.GetHashCode();
                if (this.WeightUOM != null)
                    hashCode = hashCode * 59 + this.WeightUOM.GetHashCode();
                if (this.Width != null)
                    hashCode = hashCode * 59 + this.Width.GetHashCode();
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
