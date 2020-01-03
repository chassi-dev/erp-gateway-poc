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
    /// ContractUsage
    /// </summary>
    [DataContract]
    public partial class ContractUsage : Entity,  IEquatable<ContractUsage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContractUsage" /> class.
        /// </summary>
        /// <param name="billedTransactions">billedTransactions.</param>
        /// <param name="contractID">contractID.</param>
        /// <param name="postPeriod">postPeriod.</param>
        /// <param name="unbilledTransactions">unbilledTransactions.</param>
        public ContractUsage(List<ContractUsageTransactionDetail> billedTransactions = default(List<ContractUsageTransactionDetail>), StringValue contractID = default(StringValue), StringValue postPeriod = default(StringValue), List<ContractUsageTransactionDetail> unbilledTransactions = default(List<ContractUsageTransactionDetail>), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.BilledTransactions = billedTransactions;
            this.ContractID = contractID;
            this.PostPeriod = postPeriod;
            this.UnbilledTransactions = unbilledTransactions;
        }

        /// <summary>
        /// Gets or Sets BilledTransactions
        /// </summary>
        [DataMember(Name="BilledTransactions", EmitDefaultValue=false)]
        public List<ContractUsageTransactionDetail> BilledTransactions { get; set; }

        /// <summary>
        /// Gets or Sets ContractID
        /// </summary>
        [DataMember(Name="ContractID", EmitDefaultValue=false)]
        public StringValue ContractID { get; set; }

        /// <summary>
        /// Gets or Sets PostPeriod
        /// </summary>
        [DataMember(Name="PostPeriod", EmitDefaultValue=false)]
        public StringValue PostPeriod { get; set; }

        /// <summary>
        /// Gets or Sets UnbilledTransactions
        /// </summary>
        [DataMember(Name="UnbilledTransactions", EmitDefaultValue=false)]
        public List<ContractUsageTransactionDetail> UnbilledTransactions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContractUsage {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  BilledTransactions: ").Append(BilledTransactions).Append("\n");
            sb.Append("  ContractID: ").Append(ContractID).Append("\n");
            sb.Append("  PostPeriod: ").Append(PostPeriod).Append("\n");
            sb.Append("  UnbilledTransactions: ").Append(UnbilledTransactions).Append("\n");
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
            return this.Equals(input as ContractUsage);
        }

        /// <summary>
        /// Returns true if ContractUsage instances are equal
        /// </summary>
        /// <param name="input">Instance of ContractUsage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContractUsage input)
        {
            if (input == null)
                return false;

            return base.Equals(input) &&
                (
                    this.BilledTransactions == input.BilledTransactions ||
                    this.BilledTransactions != null &&
                    this.BilledTransactions.SequenceEqual(input.BilledTransactions)
                ) && base.Equals(input) &&
                (
                    this.ContractID == input.ContractID ||
                    (this.ContractID != null &&
                    this.ContractID.Equals(input.ContractID))
                ) && base.Equals(input) &&
                (
                    this.PostPeriod == input.PostPeriod ||
                    (this.PostPeriod != null &&
                    this.PostPeriod.Equals(input.PostPeriod))
                ) && base.Equals(input) &&
                (
                    this.UnbilledTransactions == input.UnbilledTransactions ||
                    this.UnbilledTransactions != null &&
                    this.UnbilledTransactions.SequenceEqual(input.UnbilledTransactions)
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
                if (this.BilledTransactions != null)
                    hashCode = hashCode * 59 + this.BilledTransactions.GetHashCode();
                if (this.ContractID != null)
                    hashCode = hashCode * 59 + this.ContractID.GetHashCode();
                if (this.PostPeriod != null)
                    hashCode = hashCode * 59 + this.PostPeriod.GetHashCode();
                if (this.UnbilledTransactions != null)
                    hashCode = hashCode * 59 + this.UnbilledTransactions.GetHashCode();
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
