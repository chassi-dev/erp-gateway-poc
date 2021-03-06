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
    /// SalesInvoiceCommissions
    /// </summary>
    [DataContract]
    public partial class SalesInvoiceCommissions : Entity,  IEquatable<SalesInvoiceCommissions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesInvoiceCommissions" /> class.
        /// </summary>
        /// <param name="commissionAmount">commissionAmount.</param>
        /// <param name="salesPersons">salesPersons.</param>
        /// <param name="totalCommissionableAmount">totalCommissionableAmount.</param>
        public SalesInvoiceCommissions(DecimalValue commissionAmount = default(DecimalValue), List<SalesInvoiceSalesPersonDetail> salesPersons = default(List<SalesInvoiceSalesPersonDetail>), DecimalValue totalCommissionableAmount = default(DecimalValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.CommissionAmount = commissionAmount;
            this.SalesPersons = salesPersons;
            this.TotalCommissionableAmount = totalCommissionableAmount;
        }

        /// <summary>
        /// Gets or Sets CommissionAmount
        /// </summary>
        [DataMember(Name="CommissionAmount", EmitDefaultValue=false)]
        public DecimalValue CommissionAmount { get; set; }

        /// <summary>
        /// Gets or Sets SalesPersons
        /// </summary>
        [DataMember(Name="SalesPersons", EmitDefaultValue=false)]
        public List<SalesInvoiceSalesPersonDetail> SalesPersons { get; set; }

        /// <summary>
        /// Gets or Sets TotalCommissionableAmount
        /// </summary>
        [DataMember(Name="TotalCommissionableAmount", EmitDefaultValue=false)]
        public DecimalValue TotalCommissionableAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SalesInvoiceCommissions {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  CommissionAmount: ").Append(CommissionAmount).Append("\n");
            sb.Append("  SalesPersons: ").Append(SalesPersons).Append("\n");
            sb.Append("  TotalCommissionableAmount: ").Append(TotalCommissionableAmount).Append("\n");
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
            return this.Equals(input as SalesInvoiceCommissions);
        }

        /// <summary>
        /// Returns true if SalesInvoiceCommissions instances are equal
        /// </summary>
        /// <param name="input">Instance of SalesInvoiceCommissions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SalesInvoiceCommissions input)
        {
            if (input == null)
                return false;

            return base.Equals(input) &&
                (
                    this.CommissionAmount == input.CommissionAmount ||
                    (this.CommissionAmount != null &&
                    this.CommissionAmount.Equals(input.CommissionAmount))
                ) && base.Equals(input) &&
                (
                    this.SalesPersons == input.SalesPersons ||
                    this.SalesPersons != null &&
                    this.SalesPersons.SequenceEqual(input.SalesPersons)
                ) && base.Equals(input) &&
                (
                    this.TotalCommissionableAmount == input.TotalCommissionableAmount ||
                    (this.TotalCommissionableAmount != null &&
                    this.TotalCommissionableAmount.Equals(input.TotalCommissionableAmount))
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
                if (this.CommissionAmount != null)
                    hashCode = hashCode * 59 + this.CommissionAmount.GetHashCode();
                if (this.SalesPersons != null)
                    hashCode = hashCode * 59 + this.SalesPersons.GetHashCode();
                if (this.TotalCommissionableAmount != null)
                    hashCode = hashCode * 59 + this.TotalCommissionableAmount.GetHashCode();
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
