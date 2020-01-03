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
    /// ReportingSettings
    /// </summary>
    [DataContract]
    public partial class ReportingSettings : Entity,  IEquatable<ReportingSettings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportingSettings" /> class.
        /// </summary>
        /// <param name="reportingGroups">reportingGroups.</param>
        /// <param name="taxAgency">taxAgency.</param>
        public ReportingSettings(List<ReportingGroup> reportingGroups = default(List<ReportingGroup>), StringValue taxAgency = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.ReportingGroups = reportingGroups;
            this.TaxAgency = taxAgency;
        }

        /// <summary>
        /// Gets or Sets ReportingGroups
        /// </summary>
        [DataMember(Name="ReportingGroups", EmitDefaultValue=false)]
        public List<ReportingGroup> ReportingGroups { get; set; }

        /// <summary>
        /// Gets or Sets TaxAgency
        /// </summary>
        [DataMember(Name="TaxAgency", EmitDefaultValue=false)]
        public StringValue TaxAgency { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportingSettings {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  ReportingGroups: ").Append(ReportingGroups).Append("\n");
            sb.Append("  TaxAgency: ").Append(TaxAgency).Append("\n");
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
            return this.Equals(input as ReportingSettings);
        }

        /// <summary>
        /// Returns true if ReportingSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of ReportingSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportingSettings input)
        {
            if (input == null)
                return false;

            return base.Equals(input) &&
                (
                    this.ReportingGroups == input.ReportingGroups ||
                    this.ReportingGroups != null &&
                    this.ReportingGroups.SequenceEqual(input.ReportingGroups)
                ) && base.Equals(input) &&
                (
                    this.TaxAgency == input.TaxAgency ||
                    (this.TaxAgency != null &&
                    this.TaxAgency.Equals(input.TaxAgency))
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
                if (this.ReportingGroups != null)
                    hashCode = hashCode * 59 + this.ReportingGroups.GetHashCode();
                if (this.TaxAgency != null)
                    hashCode = hashCode * 59 + this.TaxAgency.GetHashCode();
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
