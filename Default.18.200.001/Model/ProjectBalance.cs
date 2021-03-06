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
    /// ProjectBalance
    /// </summary>
    [DataContract]
    public partial class ProjectBalance : Entity,  IEquatable<ProjectBalance>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectBalance" /> class.
        /// </summary>
        /// <param name="accountGroup">accountGroup.</param>
        /// <param name="actualAmount">actualAmount.</param>
        /// <param name="actualOpenCommittedAmount">actualOpenCommittedAmount.</param>
        /// <param name="budgetedCOAmount">budgetedCOAmount.</param>
        /// <param name="committedCOAmount">committedCOAmount.</param>
        /// <param name="committedInvoicedAmount">committedInvoicedAmount.</param>
        /// <param name="committedOpenAmount">committedOpenAmount.</param>
        /// <param name="description">description.</param>
        /// <param name="originalBudgetedAmount">originalBudgetedAmount.</param>
        /// <param name="originalCommittedAmount">originalCommittedAmount.</param>
        /// <param name="performance">performance.</param>
        /// <param name="revisedBudgetedAmount">revisedBudgetedAmount.</param>
        /// <param name="revisedCommittedAmount">revisedCommittedAmount.</param>
        /// <param name="varianceAmount">varianceAmount.</param>
        public ProjectBalance(StringValue accountGroup = default(StringValue), DecimalValue actualAmount = default(DecimalValue), DecimalValue actualOpenCommittedAmount = default(DecimalValue), DecimalValue budgetedCOAmount = default(DecimalValue), DecimalValue committedCOAmount = default(DecimalValue), DecimalValue committedInvoicedAmount = default(DecimalValue), DecimalValue committedOpenAmount = default(DecimalValue), StringValue description = default(StringValue), DecimalValue originalBudgetedAmount = default(DecimalValue), DecimalValue originalCommittedAmount = default(DecimalValue), DecimalValue performance = default(DecimalValue), DecimalValue revisedBudgetedAmount = default(DecimalValue), DecimalValue revisedCommittedAmount = default(DecimalValue), DecimalValue varianceAmount = default(DecimalValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.AccountGroup = accountGroup;
            this.ActualAmount = actualAmount;
            this.ActualOpenCommittedAmount = actualOpenCommittedAmount;
            this.BudgetedCOAmount = budgetedCOAmount;
            this.CommittedCOAmount = committedCOAmount;
            this.CommittedInvoicedAmount = committedInvoicedAmount;
            this.CommittedOpenAmount = committedOpenAmount;
            this.Description = description;
            this.OriginalBudgetedAmount = originalBudgetedAmount;
            this.OriginalCommittedAmount = originalCommittedAmount;
            this.Performance = performance;
            this.RevisedBudgetedAmount = revisedBudgetedAmount;
            this.RevisedCommittedAmount = revisedCommittedAmount;
            this.VarianceAmount = varianceAmount;
        }

        /// <summary>
        /// Gets or Sets AccountGroup
        /// </summary>
        [DataMember(Name="AccountGroup", EmitDefaultValue=false)]
        public StringValue AccountGroup { get; set; }

        /// <summary>
        /// Gets or Sets ActualAmount
        /// </summary>
        [DataMember(Name="ActualAmount", EmitDefaultValue=false)]
        public DecimalValue ActualAmount { get; set; }

        /// <summary>
        /// Gets or Sets ActualOpenCommittedAmount
        /// </summary>
        [DataMember(Name="ActualOpenCommittedAmount", EmitDefaultValue=false)]
        public DecimalValue ActualOpenCommittedAmount { get; set; }

        /// <summary>
        /// Gets or Sets BudgetedCOAmount
        /// </summary>
        [DataMember(Name="BudgetedCOAmount", EmitDefaultValue=false)]
        public DecimalValue BudgetedCOAmount { get; set; }

        /// <summary>
        /// Gets or Sets CommittedCOAmount
        /// </summary>
        [DataMember(Name="CommittedCOAmount", EmitDefaultValue=false)]
        public DecimalValue CommittedCOAmount { get; set; }

        /// <summary>
        /// Gets or Sets CommittedInvoicedAmount
        /// </summary>
        [DataMember(Name="CommittedInvoicedAmount", EmitDefaultValue=false)]
        public DecimalValue CommittedInvoicedAmount { get; set; }

        /// <summary>
        /// Gets or Sets CommittedOpenAmount
        /// </summary>
        [DataMember(Name="CommittedOpenAmount", EmitDefaultValue=false)]
        public DecimalValue CommittedOpenAmount { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public StringValue Description { get; set; }

        /// <summary>
        /// Gets or Sets OriginalBudgetedAmount
        /// </summary>
        [DataMember(Name="OriginalBudgetedAmount", EmitDefaultValue=false)]
        public DecimalValue OriginalBudgetedAmount { get; set; }

        /// <summary>
        /// Gets or Sets OriginalCommittedAmount
        /// </summary>
        [DataMember(Name="OriginalCommittedAmount", EmitDefaultValue=false)]
        public DecimalValue OriginalCommittedAmount { get; set; }

        /// <summary>
        /// Gets or Sets Performance
        /// </summary>
        [DataMember(Name="Performance", EmitDefaultValue=false)]
        public DecimalValue Performance { get; set; }

        /// <summary>
        /// Gets or Sets RevisedBudgetedAmount
        /// </summary>
        [DataMember(Name="RevisedBudgetedAmount", EmitDefaultValue=false)]
        public DecimalValue RevisedBudgetedAmount { get; set; }

        /// <summary>
        /// Gets or Sets RevisedCommittedAmount
        /// </summary>
        [DataMember(Name="RevisedCommittedAmount", EmitDefaultValue=false)]
        public DecimalValue RevisedCommittedAmount { get; set; }

        /// <summary>
        /// Gets or Sets VarianceAmount
        /// </summary>
        [DataMember(Name="VarianceAmount", EmitDefaultValue=false)]
        public DecimalValue VarianceAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProjectBalance {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  AccountGroup: ").Append(AccountGroup).Append("\n");
            sb.Append("  ActualAmount: ").Append(ActualAmount).Append("\n");
            sb.Append("  ActualOpenCommittedAmount: ").Append(ActualOpenCommittedAmount).Append("\n");
            sb.Append("  BudgetedCOAmount: ").Append(BudgetedCOAmount).Append("\n");
            sb.Append("  CommittedCOAmount: ").Append(CommittedCOAmount).Append("\n");
            sb.Append("  CommittedInvoicedAmount: ").Append(CommittedInvoicedAmount).Append("\n");
            sb.Append("  CommittedOpenAmount: ").Append(CommittedOpenAmount).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  OriginalBudgetedAmount: ").Append(OriginalBudgetedAmount).Append("\n");
            sb.Append("  OriginalCommittedAmount: ").Append(OriginalCommittedAmount).Append("\n");
            sb.Append("  Performance: ").Append(Performance).Append("\n");
            sb.Append("  RevisedBudgetedAmount: ").Append(RevisedBudgetedAmount).Append("\n");
            sb.Append("  RevisedCommittedAmount: ").Append(RevisedCommittedAmount).Append("\n");
            sb.Append("  VarianceAmount: ").Append(VarianceAmount).Append("\n");
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
            return this.Equals(input as ProjectBalance);
        }

        /// <summary>
        /// Returns true if ProjectBalance instances are equal
        /// </summary>
        /// <param name="input">Instance of ProjectBalance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProjectBalance input)
        {
            if (input == null)
                return false;

            return base.Equals(input) &&
                (
                    this.AccountGroup == input.AccountGroup ||
                    (this.AccountGroup != null &&
                    this.AccountGroup.Equals(input.AccountGroup))
                ) && base.Equals(input) &&
                (
                    this.ActualAmount == input.ActualAmount ||
                    (this.ActualAmount != null &&
                    this.ActualAmount.Equals(input.ActualAmount))
                ) && base.Equals(input) &&
                (
                    this.ActualOpenCommittedAmount == input.ActualOpenCommittedAmount ||
                    (this.ActualOpenCommittedAmount != null &&
                    this.ActualOpenCommittedAmount.Equals(input.ActualOpenCommittedAmount))
                ) && base.Equals(input) &&
                (
                    this.BudgetedCOAmount == input.BudgetedCOAmount ||
                    (this.BudgetedCOAmount != null &&
                    this.BudgetedCOAmount.Equals(input.BudgetedCOAmount))
                ) && base.Equals(input) &&
                (
                    this.CommittedCOAmount == input.CommittedCOAmount ||
                    (this.CommittedCOAmount != null &&
                    this.CommittedCOAmount.Equals(input.CommittedCOAmount))
                ) && base.Equals(input) &&
                (
                    this.CommittedInvoicedAmount == input.CommittedInvoicedAmount ||
                    (this.CommittedInvoicedAmount != null &&
                    this.CommittedInvoicedAmount.Equals(input.CommittedInvoicedAmount))
                ) && base.Equals(input) &&
                (
                    this.CommittedOpenAmount == input.CommittedOpenAmount ||
                    (this.CommittedOpenAmount != null &&
                    this.CommittedOpenAmount.Equals(input.CommittedOpenAmount))
                ) && base.Equals(input) &&
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && base.Equals(input) &&
                (
                    this.OriginalBudgetedAmount == input.OriginalBudgetedAmount ||
                    (this.OriginalBudgetedAmount != null &&
                    this.OriginalBudgetedAmount.Equals(input.OriginalBudgetedAmount))
                ) && base.Equals(input) &&
                (
                    this.OriginalCommittedAmount == input.OriginalCommittedAmount ||
                    (this.OriginalCommittedAmount != null &&
                    this.OriginalCommittedAmount.Equals(input.OriginalCommittedAmount))
                ) && base.Equals(input) &&
                (
                    this.Performance == input.Performance ||
                    (this.Performance != null &&
                    this.Performance.Equals(input.Performance))
                ) && base.Equals(input) &&
                (
                    this.RevisedBudgetedAmount == input.RevisedBudgetedAmount ||
                    (this.RevisedBudgetedAmount != null &&
                    this.RevisedBudgetedAmount.Equals(input.RevisedBudgetedAmount))
                ) && base.Equals(input) &&
                (
                    this.RevisedCommittedAmount == input.RevisedCommittedAmount ||
                    (this.RevisedCommittedAmount != null &&
                    this.RevisedCommittedAmount.Equals(input.RevisedCommittedAmount))
                ) && base.Equals(input) &&
                (
                    this.VarianceAmount == input.VarianceAmount ||
                    (this.VarianceAmount != null &&
                    this.VarianceAmount.Equals(input.VarianceAmount))
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
                if (this.AccountGroup != null)
                    hashCode = hashCode * 59 + this.AccountGroup.GetHashCode();
                if (this.ActualAmount != null)
                    hashCode = hashCode * 59 + this.ActualAmount.GetHashCode();
                if (this.ActualOpenCommittedAmount != null)
                    hashCode = hashCode * 59 + this.ActualOpenCommittedAmount.GetHashCode();
                if (this.BudgetedCOAmount != null)
                    hashCode = hashCode * 59 + this.BudgetedCOAmount.GetHashCode();
                if (this.CommittedCOAmount != null)
                    hashCode = hashCode * 59 + this.CommittedCOAmount.GetHashCode();
                if (this.CommittedInvoicedAmount != null)
                    hashCode = hashCode * 59 + this.CommittedInvoicedAmount.GetHashCode();
                if (this.CommittedOpenAmount != null)
                    hashCode = hashCode * 59 + this.CommittedOpenAmount.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.OriginalBudgetedAmount != null)
                    hashCode = hashCode * 59 + this.OriginalBudgetedAmount.GetHashCode();
                if (this.OriginalCommittedAmount != null)
                    hashCode = hashCode * 59 + this.OriginalCommittedAmount.GetHashCode();
                if (this.Performance != null)
                    hashCode = hashCode * 59 + this.Performance.GetHashCode();
                if (this.RevisedBudgetedAmount != null)
                    hashCode = hashCode * 59 + this.RevisedBudgetedAmount.GetHashCode();
                if (this.RevisedCommittedAmount != null)
                    hashCode = hashCode * 59 + this.RevisedCommittedAmount.GetHashCode();
                if (this.VarianceAmount != null)
                    hashCode = hashCode * 59 + this.VarianceAmount.GetHashCode();
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
