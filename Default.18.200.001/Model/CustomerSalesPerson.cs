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
    /// CustomerSalesPerson
    /// </summary>
    [DataContract]
    public partial class CustomerSalesPerson : Entity,  IEquatable<CustomerSalesPerson>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerSalesPerson" /> class.
        /// </summary>
        /// <param name="commission">commission.</param>
        /// <param name="_default">_default.</param>
        /// <param name="locationID">locationID.</param>
        /// <param name="locationName">locationName.</param>
        /// <param name="name">name.</param>
        /// <param name="salespersonID">salespersonID.</param>
        public CustomerSalesPerson(DecimalValue commission = default(DecimalValue), BooleanValue _default = default(BooleanValue), StringValue locationID = default(StringValue), StringValue locationName = default(StringValue), StringValue name = default(StringValue), StringValue salespersonID = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.Commission = commission;
            this.Default = _default;
            this.LocationID = locationID;
            this.LocationName = locationName;
            this.Name = name;
            this.SalespersonID = salespersonID;
        }

        /// <summary>
        /// Gets or Sets Commission
        /// </summary>
        [DataMember(Name="Commission", EmitDefaultValue=false)]
        public DecimalValue Commission { get; set; }

        /// <summary>
        /// Gets or Sets Default
        /// </summary>
        [DataMember(Name="Default", EmitDefaultValue=false)]
        public BooleanValue Default { get; set; }

        /// <summary>
        /// Gets or Sets LocationID
        /// </summary>
        [DataMember(Name="LocationID", EmitDefaultValue=false)]
        public StringValue LocationID { get; set; }

        /// <summary>
        /// Gets or Sets LocationName
        /// </summary>
        [DataMember(Name="LocationName", EmitDefaultValue=false)]
        public StringValue LocationName { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public StringValue Name { get; set; }

        /// <summary>
        /// Gets or Sets SalespersonID
        /// </summary>
        [DataMember(Name="SalespersonID", EmitDefaultValue=false)]
        public StringValue SalespersonID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomerSalesPerson {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Commission: ").Append(Commission).Append("\n");
            sb.Append("  Default: ").Append(Default).Append("\n");
            sb.Append("  LocationID: ").Append(LocationID).Append("\n");
            sb.Append("  LocationName: ").Append(LocationName).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SalespersonID: ").Append(SalespersonID).Append("\n");
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
            return this.Equals(input as CustomerSalesPerson);
        }

        /// <summary>
        /// Returns true if CustomerSalesPerson instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomerSalesPerson to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomerSalesPerson input)
        {
            if (input == null)
                return false;

            return base.Equals(input) &&
                (
                    this.Commission == input.Commission ||
                    (this.Commission != null &&
                    this.Commission.Equals(input.Commission))
                ) && base.Equals(input) &&
                (
                    this.Default == input.Default ||
                    (this.Default != null &&
                    this.Default.Equals(input.Default))
                ) && base.Equals(input) &&
                (
                    this.LocationID == input.LocationID ||
                    (this.LocationID != null &&
                    this.LocationID.Equals(input.LocationID))
                ) && base.Equals(input) &&
                (
                    this.LocationName == input.LocationName ||
                    (this.LocationName != null &&
                    this.LocationName.Equals(input.LocationName))
                ) && base.Equals(input) &&
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && base.Equals(input) &&
                (
                    this.SalespersonID == input.SalespersonID ||
                    (this.SalespersonID != null &&
                    this.SalespersonID.Equals(input.SalespersonID))
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
                if (this.Commission != null)
                    hashCode = hashCode * 59 + this.Commission.GetHashCode();
                if (this.Default != null)
                    hashCode = hashCode * 59 + this.Default.GetHashCode();
                if (this.LocationID != null)
                    hashCode = hashCode * 59 + this.LocationID.GetHashCode();
                if (this.LocationName != null)
                    hashCode = hashCode * 59 + this.LocationName.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.SalespersonID != null)
                    hashCode = hashCode * 59 + this.SalespersonID.GetHashCode();
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
