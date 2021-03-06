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
    /// CashSale
    /// </summary>
    [DataContract]
    public partial class CashSale : Entity,  IEquatable<CashSale>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CashSale" /> class.
        /// </summary>
        /// <param name="amount">amount.</param>
        /// <param name="balance">balance.</param>
        /// <param name="cashAccount">cashAccount.</param>
        /// <param name="createdDateTime">createdDateTime.</param>
        /// <param name="customerID">customerID.</param>
        /// <param name="date">date.</param>
        /// <param name="description">description.</param>
        /// <param name="details">details.</param>
        /// <param name="hold">hold.</param>
        /// <param name="lastModifiedDateTime">lastModifiedDateTime.</param>
        /// <param name="paymentMethod">paymentMethod.</param>
        /// <param name="paymentRef">paymentRef.</param>
        /// <param name="project">project.</param>
        /// <param name="referenceNbr">referenceNbr.</param>
        /// <param name="status">status.</param>
        /// <param name="taxTotal">taxTotal.</param>
        /// <param name="type">type.</param>
        public CashSale(DecimalValue amount = default(DecimalValue), DecimalValue balance = default(DecimalValue), StringValue cashAccount = default(StringValue), DateTimeValue createdDateTime = default(DateTimeValue), StringValue customerID = default(StringValue), DateTimeValue date = default(DateTimeValue), StringValue description = default(StringValue), List<CashSaleDetail> details = default(List<CashSaleDetail>), BooleanValue hold = default(BooleanValue), DateTimeValue lastModifiedDateTime = default(DateTimeValue), StringValue paymentMethod = default(StringValue), StringValue paymentRef = default(StringValue), StringValue project = default(StringValue), StringValue referenceNbr = default(StringValue), StringValue status = default(StringValue), DecimalValue taxTotal = default(DecimalValue), StringValue type = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.Amount = amount;
            this.Balance = balance;
            this.CashAccount = cashAccount;
            this.CreatedDateTime = createdDateTime;
            this.CustomerID = customerID;
            this.Date = date;
            this.Description = description;
            this.Details = details;
            this.Hold = hold;
            this.LastModifiedDateTime = lastModifiedDateTime;
            this.PaymentMethod = paymentMethod;
            this.PaymentRef = paymentRef;
            this.Project = project;
            this.ReferenceNbr = referenceNbr;
            this.Status = status;
            this.TaxTotal = taxTotal;
            this.Type = type;
        }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name="Amount", EmitDefaultValue=false)]
        public DecimalValue Amount { get; set; }

        /// <summary>
        /// Gets or Sets Balance
        /// </summary>
        [DataMember(Name="Balance", EmitDefaultValue=false)]
        public DecimalValue Balance { get; set; }

        /// <summary>
        /// Gets or Sets CashAccount
        /// </summary>
        [DataMember(Name="CashAccount", EmitDefaultValue=false)]
        public StringValue CashAccount { get; set; }

        /// <summary>
        /// Gets or Sets CreatedDateTime
        /// </summary>
        [DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
        public DateTimeValue CreatedDateTime { get; set; }

        /// <summary>
        /// Gets or Sets CustomerID
        /// </summary>
        [DataMember(Name="CustomerID", EmitDefaultValue=false)]
        public StringValue CustomerID { get; set; }

        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name="Date", EmitDefaultValue=false)]
        public DateTimeValue Date { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public StringValue Description { get; set; }

        /// <summary>
        /// Gets or Sets Details
        /// </summary>
        [DataMember(Name="Details", EmitDefaultValue=false)]
        public List<CashSaleDetail> Details { get; set; }

        /// <summary>
        /// Gets or Sets Hold
        /// </summary>
        [DataMember(Name="Hold", EmitDefaultValue=false)]
        public BooleanValue Hold { get; set; }

        /// <summary>
        /// Gets or Sets LastModifiedDateTime
        /// </summary>
        [DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
        public DateTimeValue LastModifiedDateTime { get; set; }

        /// <summary>
        /// Gets or Sets PaymentMethod
        /// </summary>
        [DataMember(Name="PaymentMethod", EmitDefaultValue=false)]
        public StringValue PaymentMethod { get; set; }

        /// <summary>
        /// Gets or Sets PaymentRef
        /// </summary>
        [DataMember(Name="PaymentRef", EmitDefaultValue=false)]
        public StringValue PaymentRef { get; set; }

        /// <summary>
        /// Gets or Sets Project
        /// </summary>
        [DataMember(Name="Project", EmitDefaultValue=false)]
        public StringValue Project { get; set; }

        /// <summary>
        /// Gets or Sets ReferenceNbr
        /// </summary>
        [DataMember(Name="ReferenceNbr", EmitDefaultValue=false)]
        public StringValue ReferenceNbr { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public StringValue Status { get; set; }

        /// <summary>
        /// Gets or Sets TaxTotal
        /// </summary>
        [DataMember(Name="TaxTotal", EmitDefaultValue=false)]
        public DecimalValue TaxTotal { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="Type", EmitDefaultValue=false)]
        public StringValue Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CashSale {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Balance: ").Append(Balance).Append("\n");
            sb.Append("  CashAccount: ").Append(CashAccount).Append("\n");
            sb.Append("  CreatedDateTime: ").Append(CreatedDateTime).Append("\n");
            sb.Append("  CustomerID: ").Append(CustomerID).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  Hold: ").Append(Hold).Append("\n");
            sb.Append("  LastModifiedDateTime: ").Append(LastModifiedDateTime).Append("\n");
            sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
            sb.Append("  PaymentRef: ").Append(PaymentRef).Append("\n");
            sb.Append("  Project: ").Append(Project).Append("\n");
            sb.Append("  ReferenceNbr: ").Append(ReferenceNbr).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  TaxTotal: ").Append(TaxTotal).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as CashSale);
        }

        /// <summary>
        /// Returns true if CashSale instances are equal
        /// </summary>
        /// <param name="input">Instance of CashSale to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CashSale input)
        {
            if (input == null)
                return false;

            return base.Equals(input) &&
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && base.Equals(input) &&
                (
                    this.Balance == input.Balance ||
                    (this.Balance != null &&
                    this.Balance.Equals(input.Balance))
                ) && base.Equals(input) &&
                (
                    this.CashAccount == input.CashAccount ||
                    (this.CashAccount != null &&
                    this.CashAccount.Equals(input.CashAccount))
                ) && base.Equals(input) &&
                (
                    this.CreatedDateTime == input.CreatedDateTime ||
                    (this.CreatedDateTime != null &&
                    this.CreatedDateTime.Equals(input.CreatedDateTime))
                ) && base.Equals(input) &&
                (
                    this.CustomerID == input.CustomerID ||
                    (this.CustomerID != null &&
                    this.CustomerID.Equals(input.CustomerID))
                ) && base.Equals(input) &&
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && base.Equals(input) &&
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && base.Equals(input) &&
                (
                    this.Details == input.Details ||
                    this.Details != null &&
                    this.Details.SequenceEqual(input.Details)
                ) && base.Equals(input) &&
                (
                    this.Hold == input.Hold ||
                    (this.Hold != null &&
                    this.Hold.Equals(input.Hold))
                ) && base.Equals(input) &&
                (
                    this.LastModifiedDateTime == input.LastModifiedDateTime ||
                    (this.LastModifiedDateTime != null &&
                    this.LastModifiedDateTime.Equals(input.LastModifiedDateTime))
                ) && base.Equals(input) &&
                (
                    this.PaymentMethod == input.PaymentMethod ||
                    (this.PaymentMethod != null &&
                    this.PaymentMethod.Equals(input.PaymentMethod))
                ) && base.Equals(input) &&
                (
                    this.PaymentRef == input.PaymentRef ||
                    (this.PaymentRef != null &&
                    this.PaymentRef.Equals(input.PaymentRef))
                ) && base.Equals(input) &&
                (
                    this.Project == input.Project ||
                    (this.Project != null &&
                    this.Project.Equals(input.Project))
                ) && base.Equals(input) &&
                (
                    this.ReferenceNbr == input.ReferenceNbr ||
                    (this.ReferenceNbr != null &&
                    this.ReferenceNbr.Equals(input.ReferenceNbr))
                ) && base.Equals(input) &&
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && base.Equals(input) &&
                (
                    this.TaxTotal == input.TaxTotal ||
                    (this.TaxTotal != null &&
                    this.TaxTotal.Equals(input.TaxTotal))
                ) && base.Equals(input) &&
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.Balance != null)
                    hashCode = hashCode * 59 + this.Balance.GetHashCode();
                if (this.CashAccount != null)
                    hashCode = hashCode * 59 + this.CashAccount.GetHashCode();
                if (this.CreatedDateTime != null)
                    hashCode = hashCode * 59 + this.CreatedDateTime.GetHashCode();
                if (this.CustomerID != null)
                    hashCode = hashCode * 59 + this.CustomerID.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Details != null)
                    hashCode = hashCode * 59 + this.Details.GetHashCode();
                if (this.Hold != null)
                    hashCode = hashCode * 59 + this.Hold.GetHashCode();
                if (this.LastModifiedDateTime != null)
                    hashCode = hashCode * 59 + this.LastModifiedDateTime.GetHashCode();
                if (this.PaymentMethod != null)
                    hashCode = hashCode * 59 + this.PaymentMethod.GetHashCode();
                if (this.PaymentRef != null)
                    hashCode = hashCode * 59 + this.PaymentRef.GetHashCode();
                if (this.Project != null)
                    hashCode = hashCode * 59 + this.Project.GetHashCode();
                if (this.ReferenceNbr != null)
                    hashCode = hashCode * 59 + this.ReferenceNbr.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.TaxTotal != null)
                    hashCode = hashCode * 59 + this.TaxTotal.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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
