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
    /// DiscountCode
    /// </summary>
    [DataContract]
    public partial class DiscountCode : Entity,  IEquatable<DiscountCode>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DiscountCode" /> class.
        /// </summary>
        /// <param name="applicableTo">applicableTo.</param>
        /// <param name="createdDateTime">createdDateTime.</param>
        /// <param name="description">description.</param>
        /// <param name="discountCodeID">discountCodeID.</param>
        /// <param name="discountType">discountType.</param>
        /// <param name="lastModifiedDateTime">lastModifiedDateTime.</param>
        public DiscountCode(StringValue applicableTo = default(StringValue), DateTimeValue createdDateTime = default(DateTimeValue), StringValue description = default(StringValue), StringValue discountCodeID = default(StringValue), StringValue discountType = default(StringValue), DateTimeValue lastModifiedDateTime = default(DateTimeValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.ApplicableTo = applicableTo;
            this.CreatedDateTime = createdDateTime;
            this.Description = description;
            this.DiscountCodeID = discountCodeID;
            this.DiscountType = discountType;
            this.LastModifiedDateTime = lastModifiedDateTime;
        }

        /// <summary>
        /// Gets or Sets ApplicableTo
        /// </summary>
        [DataMember(Name="ApplicableTo", EmitDefaultValue=false)]
        public StringValue ApplicableTo { get; set; }

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
        /// Gets or Sets DiscountCodeID
        /// </summary>
        [DataMember(Name="DiscountCodeID", EmitDefaultValue=false)]
        public StringValue DiscountCodeID { get; set; }

        /// <summary>
        /// Gets or Sets DiscountType
        /// </summary>
        [DataMember(Name="DiscountType", EmitDefaultValue=false)]
        public StringValue DiscountType { get; set; }

        /// <summary>
        /// Gets or Sets LastModifiedDateTime
        /// </summary>
        [DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
        public DateTimeValue LastModifiedDateTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DiscountCode {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  ApplicableTo: ").Append(ApplicableTo).Append("\n");
            sb.Append("  CreatedDateTime: ").Append(CreatedDateTime).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DiscountCodeID: ").Append(DiscountCodeID).Append("\n");
            sb.Append("  DiscountType: ").Append(DiscountType).Append("\n");
            sb.Append("  LastModifiedDateTime: ").Append(LastModifiedDateTime).Append("\n");
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
            return this.Equals(input as DiscountCode);
        }

        /// <summary>
        /// Returns true if DiscountCode instances are equal
        /// </summary>
        /// <param name="input">Instance of DiscountCode to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DiscountCode input)
        {
            if (input == null)
                return false;

            return base.Equals(input) &&
                (
                    this.ApplicableTo == input.ApplicableTo ||
                    (this.ApplicableTo != null &&
                    this.ApplicableTo.Equals(input.ApplicableTo))
                ) && base.Equals(input) &&
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
                    this.DiscountCodeID == input.DiscountCodeID ||
                    (this.DiscountCodeID != null &&
                    this.DiscountCodeID.Equals(input.DiscountCodeID))
                ) && base.Equals(input) &&
                (
                    this.DiscountType == input.DiscountType ||
                    (this.DiscountType != null &&
                    this.DiscountType.Equals(input.DiscountType))
                ) && base.Equals(input) &&
                (
                    this.LastModifiedDateTime == input.LastModifiedDateTime ||
                    (this.LastModifiedDateTime != null &&
                    this.LastModifiedDateTime.Equals(input.LastModifiedDateTime))
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
                if (this.ApplicableTo != null)
                    hashCode = hashCode * 59 + this.ApplicableTo.GetHashCode();
                if (this.CreatedDateTime != null)
                    hashCode = hashCode * 59 + this.CreatedDateTime.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DiscountCodeID != null)
                    hashCode = hashCode * 59 + this.DiscountCodeID.GetHashCode();
                if (this.DiscountType != null)
                    hashCode = hashCode * 59 + this.DiscountType.GetHashCode();
                if (this.LastModifiedDateTime != null)
                    hashCode = hashCode * 59 + this.LastModifiedDateTime.GetHashCode();
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
