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
    /// EmployeeDelegate
    /// </summary>
    [DataContract]
    public partial class EmployeeDelegate : Entity,  IEquatable<EmployeeDelegate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeDelegate" /> class.
        /// </summary>
        /// <param name="_delegate">_delegate.</param>
        /// <param name="employeeName">employeeName.</param>
        public EmployeeDelegate(StringValue _delegate = default(StringValue), StringValue employeeName = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.Delegate = _delegate;
            this.EmployeeName = employeeName;
        }

        /// <summary>
        /// Gets or Sets Delegate
        /// </summary>
        [DataMember(Name="Delegate", EmitDefaultValue=false)]
        public StringValue Delegate { get; set; }

        /// <summary>
        /// Gets or Sets EmployeeName
        /// </summary>
        [DataMember(Name="EmployeeName", EmitDefaultValue=false)]
        public StringValue EmployeeName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmployeeDelegate {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Delegate: ").Append(Delegate).Append("\n");
            sb.Append("  EmployeeName: ").Append(EmployeeName).Append("\n");
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
            return this.Equals(input as EmployeeDelegate);
        }

        /// <summary>
        /// Returns true if EmployeeDelegate instances are equal
        /// </summary>
        /// <param name="input">Instance of EmployeeDelegate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmployeeDelegate input)
        {
            if (input == null)
                return false;

            return base.Equals(input) &&
                (
                    this.Delegate == input.Delegate ||
                    (this.Delegate != null &&
                    this.Delegate.Equals(input.Delegate))
                ) && base.Equals(input) &&
                (
                    this.EmployeeName == input.EmployeeName ||
                    (this.EmployeeName != null &&
                    this.EmployeeName.Equals(input.EmployeeName))
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
                if (this.Delegate != null)
                    hashCode = hashCode * 59 + this.Delegate.GetHashCode();
                if (this.EmployeeName != null)
                    hashCode = hashCode * 59 + this.EmployeeName.GetHashCode();
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
