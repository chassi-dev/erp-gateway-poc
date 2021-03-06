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
    /// InterBranchAccountMappingTransactionInSourceBranchDetail
    /// </summary>
    [DataContract]
    public partial class InterBranchAccountMappingTransactionInSourceBranchDetail : Entity,  IEquatable<InterBranchAccountMappingTransactionInSourceBranchDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InterBranchAccountMappingTransactionInSourceBranchDetail" /> class.
        /// </summary>
        /// <param name="accountFrom">accountFrom.</param>
        /// <param name="accountTo">accountTo.</param>
        /// <param name="branchID">branchID.</param>
        /// <param name="destinationBranch">destinationBranch.</param>
        /// <param name="lineNbr">lineNbr.</param>
        /// <param name="offsetAccount">offsetAccount.</param>
        /// <param name="offsetSubaccount">offsetSubaccount.</param>
        public InterBranchAccountMappingTransactionInSourceBranchDetail(StringValue accountFrom = default(StringValue), StringValue accountTo = default(StringValue), IntValue branchID = default(IntValue), StringValue destinationBranch = default(StringValue), IntValue lineNbr = default(IntValue), StringValue offsetAccount = default(StringValue), StringValue offsetSubaccount = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.AccountFrom = accountFrom;
            this.AccountTo = accountTo;
            this.BranchID = branchID;
            this.DestinationBranch = destinationBranch;
            this.LineNbr = lineNbr;
            this.OffsetAccount = offsetAccount;
            this.OffsetSubaccount = offsetSubaccount;
        }

        /// <summary>
        /// Gets or Sets AccountFrom
        /// </summary>
        [DataMember(Name="AccountFrom", EmitDefaultValue=false)]
        public StringValue AccountFrom { get; set; }

        /// <summary>
        /// Gets or Sets AccountTo
        /// </summary>
        [DataMember(Name="AccountTo", EmitDefaultValue=false)]
        public StringValue AccountTo { get; set; }

        /// <summary>
        /// Gets or Sets BranchID
        /// </summary>
        [DataMember(Name="BranchID", EmitDefaultValue=false)]
        public IntValue BranchID { get; set; }

        /// <summary>
        /// Gets or Sets DestinationBranch
        /// </summary>
        [DataMember(Name="DestinationBranch", EmitDefaultValue=false)]
        public StringValue DestinationBranch { get; set; }

        /// <summary>
        /// Gets or Sets LineNbr
        /// </summary>
        [DataMember(Name="LineNbr", EmitDefaultValue=false)]
        public IntValue LineNbr { get; set; }

        /// <summary>
        /// Gets or Sets OffsetAccount
        /// </summary>
        [DataMember(Name="OffsetAccount", EmitDefaultValue=false)]
        public StringValue OffsetAccount { get; set; }

        /// <summary>
        /// Gets or Sets OffsetSubaccount
        /// </summary>
        [DataMember(Name="OffsetSubaccount", EmitDefaultValue=false)]
        public StringValue OffsetSubaccount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InterBranchAccountMappingTransactionInSourceBranchDetail {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  AccountFrom: ").Append(AccountFrom).Append("\n");
            sb.Append("  AccountTo: ").Append(AccountTo).Append("\n");
            sb.Append("  BranchID: ").Append(BranchID).Append("\n");
            sb.Append("  DestinationBranch: ").Append(DestinationBranch).Append("\n");
            sb.Append("  LineNbr: ").Append(LineNbr).Append("\n");
            sb.Append("  OffsetAccount: ").Append(OffsetAccount).Append("\n");
            sb.Append("  OffsetSubaccount: ").Append(OffsetSubaccount).Append("\n");
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
            return this.Equals(input as InterBranchAccountMappingTransactionInSourceBranchDetail);
        }

        /// <summary>
        /// Returns true if InterBranchAccountMappingTransactionInSourceBranchDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of InterBranchAccountMappingTransactionInSourceBranchDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InterBranchAccountMappingTransactionInSourceBranchDetail input)
        {
            if (input == null)
                return false;

            return base.Equals(input) &&
                (
                    this.AccountFrom == input.AccountFrom ||
                    (this.AccountFrom != null &&
                    this.AccountFrom.Equals(input.AccountFrom))
                ) && base.Equals(input) &&
                (
                    this.AccountTo == input.AccountTo ||
                    (this.AccountTo != null &&
                    this.AccountTo.Equals(input.AccountTo))
                ) && base.Equals(input) &&
                (
                    this.BranchID == input.BranchID ||
                    (this.BranchID != null &&
                    this.BranchID.Equals(input.BranchID))
                ) && base.Equals(input) &&
                (
                    this.DestinationBranch == input.DestinationBranch ||
                    (this.DestinationBranch != null &&
                    this.DestinationBranch.Equals(input.DestinationBranch))
                ) && base.Equals(input) &&
                (
                    this.LineNbr == input.LineNbr ||
                    (this.LineNbr != null &&
                    this.LineNbr.Equals(input.LineNbr))
                ) && base.Equals(input) &&
                (
                    this.OffsetAccount == input.OffsetAccount ||
                    (this.OffsetAccount != null &&
                    this.OffsetAccount.Equals(input.OffsetAccount))
                ) && base.Equals(input) &&
                (
                    this.OffsetSubaccount == input.OffsetSubaccount ||
                    (this.OffsetSubaccount != null &&
                    this.OffsetSubaccount.Equals(input.OffsetSubaccount))
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
                if (this.AccountFrom != null)
                    hashCode = hashCode * 59 + this.AccountFrom.GetHashCode();
                if (this.AccountTo != null)
                    hashCode = hashCode * 59 + this.AccountTo.GetHashCode();
                if (this.BranchID != null)
                    hashCode = hashCode * 59 + this.BranchID.GetHashCode();
                if (this.DestinationBranch != null)
                    hashCode = hashCode * 59 + this.DestinationBranch.GetHashCode();
                if (this.LineNbr != null)
                    hashCode = hashCode * 59 + this.LineNbr.GetHashCode();
                if (this.OffsetAccount != null)
                    hashCode = hashCode * 59 + this.OffsetAccount.GetHashCode();
                if (this.OffsetSubaccount != null)
                    hashCode = hashCode * 59 + this.OffsetSubaccount.GetHashCode();
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
