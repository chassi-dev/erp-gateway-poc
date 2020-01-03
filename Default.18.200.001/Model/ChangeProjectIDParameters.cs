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
    /// The parameters of the action.
    /// </summary>
    [DataContract]
    public partial class ChangeProjectIDParameters :  IEquatable<ChangeProjectIDParameters>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeProjectIDParameters" /> class.
        /// </summary>
        /// <param name="projectID">projectID.</param>
        public ChangeProjectIDParameters(StringValue projectID = default(StringValue))
        {
            this.ProjectID = projectID;
        }

        /// <summary>
        /// Gets or Sets ProjectID
        /// </summary>
        [DataMember(Name="ProjectID", EmitDefaultValue=false)]
        public StringValue ProjectID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChangeProjectIDParameters {\n");
            sb.Append("  ProjectID: ").Append(ProjectID).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as ChangeProjectIDParameters);
        }

        /// <summary>
        /// Returns true if ChangeProjectIDParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of ChangeProjectIDParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChangeProjectIDParameters input)
        {
            if (input == null)
                return false;

            return
                (
                    this.ProjectID == input.ProjectID ||
                    (this.ProjectID != null &&
                    this.ProjectID.Equals(input.ProjectID))
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
                int hashCode = 41;
                if (this.ProjectID != null)
                    hashCode = hashCode * 59 + this.ProjectID.GetHashCode();
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
            yield break;
        }
    }

}
