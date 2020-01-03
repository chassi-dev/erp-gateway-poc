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
    /// ProjectEmployee
    /// </summary>
    [DataContract]
    public partial class ProjectEmployee : Entity,  IEquatable<ProjectEmployee>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectEmployee" /> class.
        /// </summary>
        /// <param name="department">department.</param>
        /// <param name="employeeID">employeeID.</param>
        /// <param name="employeeName">employeeName.</param>
        public ProjectEmployee(StringValue department = default(StringValue), StringValue employeeID = default(StringValue), StringValue employeeName = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.Department = department;
            this.EmployeeID = employeeID;
            this.EmployeeName = employeeName;
        }

        /// <summary>
        /// Gets or Sets Department
        /// </summary>
        [DataMember(Name="Department", EmitDefaultValue=false)]
        public StringValue Department { get; set; }

        /// <summary>
        /// Gets or Sets EmployeeID
        /// </summary>
        [DataMember(Name="EmployeeID", EmitDefaultValue=false)]
        public StringValue EmployeeID { get; set; }

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
            sb.Append("class ProjectEmployee {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Department: ").Append(Department).Append("\n");
            sb.Append("  EmployeeID: ").Append(EmployeeID).Append("\n");
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
            return this.Equals(input as ProjectEmployee);
        }

        /// <summary>
        /// Returns true if ProjectEmployee instances are equal
        /// </summary>
        /// <param name="input">Instance of ProjectEmployee to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProjectEmployee input)
        {
            if (input == null)
                return false;

            return base.Equals(input) &&
                (
                    this.Department == input.Department ||
                    (this.Department != null &&
                    this.Department.Equals(input.Department))
                ) && base.Equals(input) &&
                (
                    this.EmployeeID == input.EmployeeID ||
                    (this.EmployeeID != null &&
                    this.EmployeeID.Equals(input.EmployeeID))
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
                if (this.Department != null)
                    hashCode = hashCode * 59 + this.Department.GetHashCode();
                if (this.EmployeeID != null)
                    hashCode = hashCode * 59 + this.EmployeeID.GetHashCode();
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
