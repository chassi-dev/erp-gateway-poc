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
    /// ExternalCommitment
    /// </summary>
    [DataContract]
    public partial class ExternalCommitment : Entity,  IEquatable<ExternalCommitment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalCommitment" /> class.
        /// </summary>
        /// <param name="accountGroup">accountGroup.</param>
        /// <param name="committedCOAmount">committedCOAmount.</param>
        /// <param name="committedCOQty">committedCOQty.</param>
        /// <param name="committedInvoicedAmount">committedInvoicedAmount.</param>
        /// <param name="committedInvoicedQty">committedInvoicedQty.</param>
        /// <param name="committedOpenAmount">committedOpenAmount.</param>
        /// <param name="committedOpenQty">committedOpenQty.</param>
        /// <param name="committedReceivedQty">committedReceivedQty.</param>
        /// <param name="costCode">costCode.</param>
        /// <param name="externalRefNbr">externalRefNbr.</param>
        /// <param name="inventoryID">inventoryID.</param>
        /// <param name="lastModifiedDateTime">lastModifiedDateTime.</param>
        /// <param name="originalCommittedAmount">originalCommittedAmount.</param>
        /// <param name="originalCommittedQty">originalCommittedQty.</param>
        /// <param name="projectID">projectID.</param>
        /// <param name="projectTaskID">projectTaskID.</param>
        /// <param name="relatedDocument">relatedDocument.</param>
        /// <param name="revisedCommittedAmount">revisedCommittedAmount.</param>
        /// <param name="revisedCommittedQty">revisedCommittedQty.</param>
        /// <param name="type">type.</param>
        /// <param name="uOM">uOM.</param>
        public ExternalCommitment(StringValue accountGroup = default(StringValue), DecimalValue committedCOAmount = default(DecimalValue), DecimalValue committedCOQty = default(DecimalValue), DecimalValue committedInvoicedAmount = default(DecimalValue), DecimalValue committedInvoicedQty = default(DecimalValue), DecimalValue committedOpenAmount = default(DecimalValue), DecimalValue committedOpenQty = default(DecimalValue), DecimalValue committedReceivedQty = default(DecimalValue), StringValue costCode = default(StringValue), StringValue externalRefNbr = default(StringValue), StringValue inventoryID = default(StringValue), DateTimeValue lastModifiedDateTime = default(DateTimeValue), DecimalValue originalCommittedAmount = default(DecimalValue), DecimalValue originalCommittedQty = default(DecimalValue), StringValue projectID = default(StringValue), StringValue projectTaskID = default(StringValue), StringValue relatedDocument = default(StringValue), DecimalValue revisedCommittedAmount = default(DecimalValue), DecimalValue revisedCommittedQty = default(DecimalValue), StringValue type = default(StringValue), StringValue uOM = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.AccountGroup = accountGroup;
            this.CommittedCOAmount = committedCOAmount;
            this.CommittedCOQty = committedCOQty;
            this.CommittedInvoicedAmount = committedInvoicedAmount;
            this.CommittedInvoicedQty = committedInvoicedQty;
            this.CommittedOpenAmount = committedOpenAmount;
            this.CommittedOpenQty = committedOpenQty;
            this.CommittedReceivedQty = committedReceivedQty;
            this.CostCode = costCode;
            this.ExternalRefNbr = externalRefNbr;
            this.InventoryID = inventoryID;
            this.LastModifiedDateTime = lastModifiedDateTime;
            this.OriginalCommittedAmount = originalCommittedAmount;
            this.OriginalCommittedQty = originalCommittedQty;
            this.ProjectID = projectID;
            this.ProjectTaskID = projectTaskID;
            this.RelatedDocument = relatedDocument;
            this.RevisedCommittedAmount = revisedCommittedAmount;
            this.RevisedCommittedQty = revisedCommittedQty;
            this.Type = type;
            this.UOM = uOM;
        }

        /// <summary>
        /// Gets or Sets AccountGroup
        /// </summary>
        [DataMember(Name="AccountGroup", EmitDefaultValue=false)]
        public StringValue AccountGroup { get; set; }

        /// <summary>
        /// Gets or Sets CommittedCOAmount
        /// </summary>
        [DataMember(Name="CommittedCOAmount", EmitDefaultValue=false)]
        public DecimalValue CommittedCOAmount { get; set; }

        /// <summary>
        /// Gets or Sets CommittedCOQty
        /// </summary>
        [DataMember(Name="CommittedCOQty", EmitDefaultValue=false)]
        public DecimalValue CommittedCOQty { get; set; }

        /// <summary>
        /// Gets or Sets CommittedInvoicedAmount
        /// </summary>
        [DataMember(Name="CommittedInvoicedAmount", EmitDefaultValue=false)]
        public DecimalValue CommittedInvoicedAmount { get; set; }

        /// <summary>
        /// Gets or Sets CommittedInvoicedQty
        /// </summary>
        [DataMember(Name="CommittedInvoicedQty", EmitDefaultValue=false)]
        public DecimalValue CommittedInvoicedQty { get; set; }

        /// <summary>
        /// Gets or Sets CommittedOpenAmount
        /// </summary>
        [DataMember(Name="CommittedOpenAmount", EmitDefaultValue=false)]
        public DecimalValue CommittedOpenAmount { get; set; }

        /// <summary>
        /// Gets or Sets CommittedOpenQty
        /// </summary>
        [DataMember(Name="CommittedOpenQty", EmitDefaultValue=false)]
        public DecimalValue CommittedOpenQty { get; set; }

        /// <summary>
        /// Gets or Sets CommittedReceivedQty
        /// </summary>
        [DataMember(Name="CommittedReceivedQty", EmitDefaultValue=false)]
        public DecimalValue CommittedReceivedQty { get; set; }

        /// <summary>
        /// Gets or Sets CostCode
        /// </summary>
        [DataMember(Name="CostCode", EmitDefaultValue=false)]
        public StringValue CostCode { get; set; }

        /// <summary>
        /// Gets or Sets ExternalRefNbr
        /// </summary>
        [DataMember(Name="ExternalRefNbr", EmitDefaultValue=false)]
        public StringValue ExternalRefNbr { get; set; }

        /// <summary>
        /// Gets or Sets InventoryID
        /// </summary>
        [DataMember(Name="InventoryID", EmitDefaultValue=false)]
        public StringValue InventoryID { get; set; }

        /// <summary>
        /// Gets or Sets LastModifiedDateTime
        /// </summary>
        [DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
        public DateTimeValue LastModifiedDateTime { get; set; }

        /// <summary>
        /// Gets or Sets OriginalCommittedAmount
        /// </summary>
        [DataMember(Name="OriginalCommittedAmount", EmitDefaultValue=false)]
        public DecimalValue OriginalCommittedAmount { get; set; }

        /// <summary>
        /// Gets or Sets OriginalCommittedQty
        /// </summary>
        [DataMember(Name="OriginalCommittedQty", EmitDefaultValue=false)]
        public DecimalValue OriginalCommittedQty { get; set; }

        /// <summary>
        /// Gets or Sets ProjectID
        /// </summary>
        [DataMember(Name="ProjectID", EmitDefaultValue=false)]
        public StringValue ProjectID { get; set; }

        /// <summary>
        /// Gets or Sets ProjectTaskID
        /// </summary>
        [DataMember(Name="ProjectTaskID", EmitDefaultValue=false)]
        public StringValue ProjectTaskID { get; set; }

        /// <summary>
        /// Gets or Sets RelatedDocument
        /// </summary>
        [DataMember(Name="RelatedDocument", EmitDefaultValue=false)]
        public StringValue RelatedDocument { get; set; }

        /// <summary>
        /// Gets or Sets RevisedCommittedAmount
        /// </summary>
        [DataMember(Name="RevisedCommittedAmount", EmitDefaultValue=false)]
        public DecimalValue RevisedCommittedAmount { get; set; }

        /// <summary>
        /// Gets or Sets RevisedCommittedQty
        /// </summary>
        [DataMember(Name="RevisedCommittedQty", EmitDefaultValue=false)]
        public DecimalValue RevisedCommittedQty { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="Type", EmitDefaultValue=false)]
        public StringValue Type { get; set; }

        /// <summary>
        /// Gets or Sets UOM
        /// </summary>
        [DataMember(Name="UOM", EmitDefaultValue=false)]
        public StringValue UOM { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExternalCommitment {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  AccountGroup: ").Append(AccountGroup).Append("\n");
            sb.Append("  CommittedCOAmount: ").Append(CommittedCOAmount).Append("\n");
            sb.Append("  CommittedCOQty: ").Append(CommittedCOQty).Append("\n");
            sb.Append("  CommittedInvoicedAmount: ").Append(CommittedInvoicedAmount).Append("\n");
            sb.Append("  CommittedInvoicedQty: ").Append(CommittedInvoicedQty).Append("\n");
            sb.Append("  CommittedOpenAmount: ").Append(CommittedOpenAmount).Append("\n");
            sb.Append("  CommittedOpenQty: ").Append(CommittedOpenQty).Append("\n");
            sb.Append("  CommittedReceivedQty: ").Append(CommittedReceivedQty).Append("\n");
            sb.Append("  CostCode: ").Append(CostCode).Append("\n");
            sb.Append("  ExternalRefNbr: ").Append(ExternalRefNbr).Append("\n");
            sb.Append("  InventoryID: ").Append(InventoryID).Append("\n");
            sb.Append("  LastModifiedDateTime: ").Append(LastModifiedDateTime).Append("\n");
            sb.Append("  OriginalCommittedAmount: ").Append(OriginalCommittedAmount).Append("\n");
            sb.Append("  OriginalCommittedQty: ").Append(OriginalCommittedQty).Append("\n");
            sb.Append("  ProjectID: ").Append(ProjectID).Append("\n");
            sb.Append("  ProjectTaskID: ").Append(ProjectTaskID).Append("\n");
            sb.Append("  RelatedDocument: ").Append(RelatedDocument).Append("\n");
            sb.Append("  RevisedCommittedAmount: ").Append(RevisedCommittedAmount).Append("\n");
            sb.Append("  RevisedCommittedQty: ").Append(RevisedCommittedQty).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  UOM: ").Append(UOM).Append("\n");
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
            return this.Equals(input as ExternalCommitment);
        }

        /// <summary>
        /// Returns true if ExternalCommitment instances are equal
        /// </summary>
        /// <param name="input">Instance of ExternalCommitment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExternalCommitment input)
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
                    this.CommittedCOAmount == input.CommittedCOAmount ||
                    (this.CommittedCOAmount != null &&
                    this.CommittedCOAmount.Equals(input.CommittedCOAmount))
                ) && base.Equals(input) &&
                (
                    this.CommittedCOQty == input.CommittedCOQty ||
                    (this.CommittedCOQty != null &&
                    this.CommittedCOQty.Equals(input.CommittedCOQty))
                ) && base.Equals(input) &&
                (
                    this.CommittedInvoicedAmount == input.CommittedInvoicedAmount ||
                    (this.CommittedInvoicedAmount != null &&
                    this.CommittedInvoicedAmount.Equals(input.CommittedInvoicedAmount))
                ) && base.Equals(input) &&
                (
                    this.CommittedInvoicedQty == input.CommittedInvoicedQty ||
                    (this.CommittedInvoicedQty != null &&
                    this.CommittedInvoicedQty.Equals(input.CommittedInvoicedQty))
                ) && base.Equals(input) &&
                (
                    this.CommittedOpenAmount == input.CommittedOpenAmount ||
                    (this.CommittedOpenAmount != null &&
                    this.CommittedOpenAmount.Equals(input.CommittedOpenAmount))
                ) && base.Equals(input) &&
                (
                    this.CommittedOpenQty == input.CommittedOpenQty ||
                    (this.CommittedOpenQty != null &&
                    this.CommittedOpenQty.Equals(input.CommittedOpenQty))
                ) && base.Equals(input) &&
                (
                    this.CommittedReceivedQty == input.CommittedReceivedQty ||
                    (this.CommittedReceivedQty != null &&
                    this.CommittedReceivedQty.Equals(input.CommittedReceivedQty))
                ) && base.Equals(input) &&
                (
                    this.CostCode == input.CostCode ||
                    (this.CostCode != null &&
                    this.CostCode.Equals(input.CostCode))
                ) && base.Equals(input) &&
                (
                    this.ExternalRefNbr == input.ExternalRefNbr ||
                    (this.ExternalRefNbr != null &&
                    this.ExternalRefNbr.Equals(input.ExternalRefNbr))
                ) && base.Equals(input) &&
                (
                    this.InventoryID == input.InventoryID ||
                    (this.InventoryID != null &&
                    this.InventoryID.Equals(input.InventoryID))
                ) && base.Equals(input) &&
                (
                    this.LastModifiedDateTime == input.LastModifiedDateTime ||
                    (this.LastModifiedDateTime != null &&
                    this.LastModifiedDateTime.Equals(input.LastModifiedDateTime))
                ) && base.Equals(input) &&
                (
                    this.OriginalCommittedAmount == input.OriginalCommittedAmount ||
                    (this.OriginalCommittedAmount != null &&
                    this.OriginalCommittedAmount.Equals(input.OriginalCommittedAmount))
                ) && base.Equals(input) &&
                (
                    this.OriginalCommittedQty == input.OriginalCommittedQty ||
                    (this.OriginalCommittedQty != null &&
                    this.OriginalCommittedQty.Equals(input.OriginalCommittedQty))
                ) && base.Equals(input) &&
                (
                    this.ProjectID == input.ProjectID ||
                    (this.ProjectID != null &&
                    this.ProjectID.Equals(input.ProjectID))
                ) && base.Equals(input) &&
                (
                    this.ProjectTaskID == input.ProjectTaskID ||
                    (this.ProjectTaskID != null &&
                    this.ProjectTaskID.Equals(input.ProjectTaskID))
                ) && base.Equals(input) &&
                (
                    this.RelatedDocument == input.RelatedDocument ||
                    (this.RelatedDocument != null &&
                    this.RelatedDocument.Equals(input.RelatedDocument))
                ) && base.Equals(input) &&
                (
                    this.RevisedCommittedAmount == input.RevisedCommittedAmount ||
                    (this.RevisedCommittedAmount != null &&
                    this.RevisedCommittedAmount.Equals(input.RevisedCommittedAmount))
                ) && base.Equals(input) &&
                (
                    this.RevisedCommittedQty == input.RevisedCommittedQty ||
                    (this.RevisedCommittedQty != null &&
                    this.RevisedCommittedQty.Equals(input.RevisedCommittedQty))
                ) && base.Equals(input) &&
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && base.Equals(input) &&
                (
                    this.UOM == input.UOM ||
                    (this.UOM != null &&
                    this.UOM.Equals(input.UOM))
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
                if (this.CommittedCOAmount != null)
                    hashCode = hashCode * 59 + this.CommittedCOAmount.GetHashCode();
                if (this.CommittedCOQty != null)
                    hashCode = hashCode * 59 + this.CommittedCOQty.GetHashCode();
                if (this.CommittedInvoicedAmount != null)
                    hashCode = hashCode * 59 + this.CommittedInvoicedAmount.GetHashCode();
                if (this.CommittedInvoicedQty != null)
                    hashCode = hashCode * 59 + this.CommittedInvoicedQty.GetHashCode();
                if (this.CommittedOpenAmount != null)
                    hashCode = hashCode * 59 + this.CommittedOpenAmount.GetHashCode();
                if (this.CommittedOpenQty != null)
                    hashCode = hashCode * 59 + this.CommittedOpenQty.GetHashCode();
                if (this.CommittedReceivedQty != null)
                    hashCode = hashCode * 59 + this.CommittedReceivedQty.GetHashCode();
                if (this.CostCode != null)
                    hashCode = hashCode * 59 + this.CostCode.GetHashCode();
                if (this.ExternalRefNbr != null)
                    hashCode = hashCode * 59 + this.ExternalRefNbr.GetHashCode();
                if (this.InventoryID != null)
                    hashCode = hashCode * 59 + this.InventoryID.GetHashCode();
                if (this.LastModifiedDateTime != null)
                    hashCode = hashCode * 59 + this.LastModifiedDateTime.GetHashCode();
                if (this.OriginalCommittedAmount != null)
                    hashCode = hashCode * 59 + this.OriginalCommittedAmount.GetHashCode();
                if (this.OriginalCommittedQty != null)
                    hashCode = hashCode * 59 + this.OriginalCommittedQty.GetHashCode();
                if (this.ProjectID != null)
                    hashCode = hashCode * 59 + this.ProjectID.GetHashCode();
                if (this.ProjectTaskID != null)
                    hashCode = hashCode * 59 + this.ProjectTaskID.GetHashCode();
                if (this.RelatedDocument != null)
                    hashCode = hashCode * 59 + this.RelatedDocument.GetHashCode();
                if (this.RevisedCommittedAmount != null)
                    hashCode = hashCode * 59 + this.RevisedCommittedAmount.GetHashCode();
                if (this.RevisedCommittedQty != null)
                    hashCode = hashCode * 59 + this.RevisedCommittedQty.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.UOM != null)
                    hashCode = hashCode * 59 + this.UOM.GetHashCode();
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
