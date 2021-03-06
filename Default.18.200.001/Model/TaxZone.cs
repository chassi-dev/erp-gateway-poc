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
    /// TaxZone
    /// </summary>
    [DataContract]
    public partial class TaxZone : Entity,  IEquatable<TaxZone>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxZone" /> class.
        /// </summary>
        /// <param name="applicableTaxes">applicableTaxes.</param>
        /// <param name="createdDateTime">createdDateTime.</param>
        /// <param name="description">description.</param>
        /// <param name="lastModifiedDateTime">lastModifiedDateTime.</param>
        /// <param name="taxZoneID">taxZoneID.</param>
        public TaxZone(List<TaxZoneApplicableTaxDetail> applicableTaxes = default(List<TaxZoneApplicableTaxDetail>), DateTimeValue createdDateTime = default(DateTimeValue), StringValue description = default(StringValue), DateTimeValue lastModifiedDateTime = default(DateTimeValue), StringValue taxZoneID = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.ApplicableTaxes = applicableTaxes;
            this.CreatedDateTime = createdDateTime;
            this.Description = description;
            this.LastModifiedDateTime = lastModifiedDateTime;
            this.TaxZoneID = taxZoneID;
        }

        /// <summary>
        /// Gets or Sets ApplicableTaxes
        /// </summary>
        [DataMember(Name="ApplicableTaxes", EmitDefaultValue=false)]
        public List<TaxZoneApplicableTaxDetail> ApplicableTaxes { get; set; }

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
        /// Gets or Sets LastModifiedDateTime
        /// </summary>
        [DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
        public DateTimeValue LastModifiedDateTime { get; set; }

        /// <summary>
        /// Gets or Sets TaxZoneID
        /// </summary>
        [DataMember(Name="TaxZoneID", EmitDefaultValue=false)]
        public StringValue TaxZoneID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaxZone {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  ApplicableTaxes: ").Append(ApplicableTaxes).Append("\n");
            sb.Append("  CreatedDateTime: ").Append(CreatedDateTime).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  LastModifiedDateTime: ").Append(LastModifiedDateTime).Append("\n");
            sb.Append("  TaxZoneID: ").Append(TaxZoneID).Append("\n");
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
            return this.Equals(input as TaxZone);
        }

        /// <summary>
        /// Returns true if TaxZone instances are equal
        /// </summary>
        /// <param name="input">Instance of TaxZone to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaxZone input)
        {
            if (input == null)
                return false;

            return base.Equals(input) &&
                (
                    this.ApplicableTaxes == input.ApplicableTaxes ||
                    this.ApplicableTaxes != null &&
                    this.ApplicableTaxes.SequenceEqual(input.ApplicableTaxes)
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
                    this.LastModifiedDateTime == input.LastModifiedDateTime ||
                    (this.LastModifiedDateTime != null &&
                    this.LastModifiedDateTime.Equals(input.LastModifiedDateTime))
                ) && base.Equals(input) &&
                (
                    this.TaxZoneID == input.TaxZoneID ||
                    (this.TaxZoneID != null &&
                    this.TaxZoneID.Equals(input.TaxZoneID))
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
                if (this.ApplicableTaxes != null)
                    hashCode = hashCode * 59 + this.ApplicableTaxes.GetHashCode();
                if (this.CreatedDateTime != null)
                    hashCode = hashCode * 59 + this.CreatedDateTime.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.LastModifiedDateTime != null)
                    hashCode = hashCode * 59 + this.LastModifiedDateTime.GetHashCode();
                if (this.TaxZoneID != null)
                    hashCode = hashCode * 59 + this.TaxZoneID.GetHashCode();
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
