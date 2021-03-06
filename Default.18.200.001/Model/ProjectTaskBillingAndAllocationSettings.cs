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
    /// ProjectTaskBillingAndAllocationSettings
    /// </summary>
    [DataContract]
    public partial class ProjectTaskBillingAndAllocationSettings : Entity,  IEquatable<ProjectTaskBillingAndAllocationSettings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectTaskBillingAndAllocationSettings" /> class.
        /// </summary>
        /// <param name="allocationRule">allocationRule.</param>
        /// <param name="billingOption">billingOption.</param>
        /// <param name="billingRule">billingRule.</param>
        /// <param name="billSeparately">billSeparately.</param>
        /// <param name="branch">branch.</param>
        /// <param name="customer">customer.</param>
        /// <param name="location">location.</param>
        /// <param name="rateTable">rateTable.</param>
        /// <param name="wIPAccountGroup">wIPAccountGroup.</param>
        public ProjectTaskBillingAndAllocationSettings(StringValue allocationRule = default(StringValue), StringValue billingOption = default(StringValue), StringValue billingRule = default(StringValue), BooleanValue billSeparately = default(BooleanValue), StringValue branch = default(StringValue), StringValue customer = default(StringValue), StringValue location = default(StringValue), StringValue rateTable = default(StringValue), StringValue wIPAccountGroup = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.AllocationRule = allocationRule;
            this.BillingOption = billingOption;
            this.BillingRule = billingRule;
            this.BillSeparately = billSeparately;
            this.Branch = branch;
            this.Customer = customer;
            this.Location = location;
            this.RateTable = rateTable;
            this.WIPAccountGroup = wIPAccountGroup;
        }

        /// <summary>
        /// Gets or Sets AllocationRule
        /// </summary>
        [DataMember(Name="AllocationRule", EmitDefaultValue=false)]
        public StringValue AllocationRule { get; set; }

        /// <summary>
        /// Gets or Sets BillingOption
        /// </summary>
        [DataMember(Name="BillingOption", EmitDefaultValue=false)]
        public StringValue BillingOption { get; set; }

        /// <summary>
        /// Gets or Sets BillingRule
        /// </summary>
        [DataMember(Name="BillingRule", EmitDefaultValue=false)]
        public StringValue BillingRule { get; set; }

        /// <summary>
        /// Gets or Sets BillSeparately
        /// </summary>
        [DataMember(Name="BillSeparately", EmitDefaultValue=false)]
        public BooleanValue BillSeparately { get; set; }

        /// <summary>
        /// Gets or Sets Branch
        /// </summary>
        [DataMember(Name="Branch", EmitDefaultValue=false)]
        public StringValue Branch { get; set; }

        /// <summary>
        /// Gets or Sets Customer
        /// </summary>
        [DataMember(Name="Customer", EmitDefaultValue=false)]
        public StringValue Customer { get; set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name="Location", EmitDefaultValue=false)]
        public StringValue Location { get; set; }

        /// <summary>
        /// Gets or Sets RateTable
        /// </summary>
        [DataMember(Name="RateTable", EmitDefaultValue=false)]
        public StringValue RateTable { get; set; }

        /// <summary>
        /// Gets or Sets WIPAccountGroup
        /// </summary>
        [DataMember(Name="WIPAccountGroup", EmitDefaultValue=false)]
        public StringValue WIPAccountGroup { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProjectTaskBillingAndAllocationSettings {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  AllocationRule: ").Append(AllocationRule).Append("\n");
            sb.Append("  BillingOption: ").Append(BillingOption).Append("\n");
            sb.Append("  BillingRule: ").Append(BillingRule).Append("\n");
            sb.Append("  BillSeparately: ").Append(BillSeparately).Append("\n");
            sb.Append("  Branch: ").Append(Branch).Append("\n");
            sb.Append("  Customer: ").Append(Customer).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  RateTable: ").Append(RateTable).Append("\n");
            sb.Append("  WIPAccountGroup: ").Append(WIPAccountGroup).Append("\n");
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
            return this.Equals(input as ProjectTaskBillingAndAllocationSettings);
        }

        /// <summary>
        /// Returns true if ProjectTaskBillingAndAllocationSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of ProjectTaskBillingAndAllocationSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProjectTaskBillingAndAllocationSettings input)
        {
            if (input == null)
                return false;

            return base.Equals(input) &&
                (
                    this.AllocationRule == input.AllocationRule ||
                    (this.AllocationRule != null &&
                    this.AllocationRule.Equals(input.AllocationRule))
                ) && base.Equals(input) &&
                (
                    this.BillingOption == input.BillingOption ||
                    (this.BillingOption != null &&
                    this.BillingOption.Equals(input.BillingOption))
                ) && base.Equals(input) &&
                (
                    this.BillingRule == input.BillingRule ||
                    (this.BillingRule != null &&
                    this.BillingRule.Equals(input.BillingRule))
                ) && base.Equals(input) &&
                (
                    this.BillSeparately == input.BillSeparately ||
                    (this.BillSeparately != null &&
                    this.BillSeparately.Equals(input.BillSeparately))
                ) && base.Equals(input) &&
                (
                    this.Branch == input.Branch ||
                    (this.Branch != null &&
                    this.Branch.Equals(input.Branch))
                ) && base.Equals(input) &&
                (
                    this.Customer == input.Customer ||
                    (this.Customer != null &&
                    this.Customer.Equals(input.Customer))
                ) && base.Equals(input) &&
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && base.Equals(input) &&
                (
                    this.RateTable == input.RateTable ||
                    (this.RateTable != null &&
                    this.RateTable.Equals(input.RateTable))
                ) && base.Equals(input) &&
                (
                    this.WIPAccountGroup == input.WIPAccountGroup ||
                    (this.WIPAccountGroup != null &&
                    this.WIPAccountGroup.Equals(input.WIPAccountGroup))
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
                if (this.AllocationRule != null)
                    hashCode = hashCode * 59 + this.AllocationRule.GetHashCode();
                if (this.BillingOption != null)
                    hashCode = hashCode * 59 + this.BillingOption.GetHashCode();
                if (this.BillingRule != null)
                    hashCode = hashCode * 59 + this.BillingRule.GetHashCode();
                if (this.BillSeparately != null)
                    hashCode = hashCode * 59 + this.BillSeparately.GetHashCode();
                if (this.Branch != null)
                    hashCode = hashCode * 59 + this.Branch.GetHashCode();
                if (this.Customer != null)
                    hashCode = hashCode * 59 + this.Customer.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.RateTable != null)
                    hashCode = hashCode * 59 + this.RateTable.GetHashCode();
                if (this.WIPAccountGroup != null)
                    hashCode = hashCode * 59 + this.WIPAccountGroup.GetHashCode();
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
