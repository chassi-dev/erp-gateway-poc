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
    /// CustomerPaymentMethod
    /// </summary>
    [DataContract]
    public partial class CustomerPaymentMethod : Entity,  IEquatable<CustomerPaymentMethod>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerPaymentMethod" /> class.
        /// </summary>
        /// <param name="active">active.</param>
        /// <param name="cardAccountNbr">cardAccountNbr.</param>
        /// <param name="cashAccount">cashAccount.</param>
        /// <param name="createdDateTime">createdDateTime.</param>
        /// <param name="customerID">customerID.</param>
        /// <param name="customerProfileID">customerProfileID.</param>
        /// <param name="details">details.</param>
        /// <param name="instanceID">instanceID.</param>
        /// <param name="lastModifiedDateTime">lastModifiedDateTime.</param>
        /// <param name="paymentMethod">paymentMethod.</param>
        /// <param name="procCenterID">procCenterID.</param>
        public CustomerPaymentMethod(BooleanValue active = default(BooleanValue), StringValue cardAccountNbr = default(StringValue), StringValue cashAccount = default(StringValue), DateTimeValue createdDateTime = default(DateTimeValue), StringValue customerID = default(StringValue), StringValue customerProfileID = default(StringValue), List<CustomerPaymentMethodDetail> details = default(List<CustomerPaymentMethodDetail>), IntValue instanceID = default(IntValue), DateTimeValue lastModifiedDateTime = default(DateTimeValue), StringValue paymentMethod = default(StringValue), StringValue procCenterID = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.Active = active;
            this.CardAccountNbr = cardAccountNbr;
            this.CashAccount = cashAccount;
            this.CreatedDateTime = createdDateTime;
            this.CustomerID = customerID;
            this.CustomerProfileID = customerProfileID;
            this.Details = details;
            this.InstanceID = instanceID;
            this.LastModifiedDateTime = lastModifiedDateTime;
            this.PaymentMethod = paymentMethod;
            this.ProcCenterID = procCenterID;
        }

        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name="Active", EmitDefaultValue=false)]
        public BooleanValue Active { get; set; }

        /// <summary>
        /// Gets or Sets CardAccountNbr
        /// </summary>
        [DataMember(Name="CardAccountNbr", EmitDefaultValue=false)]
        public StringValue CardAccountNbr { get; set; }

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
        /// Gets or Sets CustomerProfileID
        /// </summary>
        [DataMember(Name="CustomerProfileID", EmitDefaultValue=false)]
        public StringValue CustomerProfileID { get; set; }

        /// <summary>
        /// Gets or Sets Details
        /// </summary>
        [DataMember(Name="Details", EmitDefaultValue=false)]
        public List<CustomerPaymentMethodDetail> Details { get; set; }

        /// <summary>
        /// Gets or Sets InstanceID
        /// </summary>
        [DataMember(Name="InstanceID", EmitDefaultValue=false)]
        public IntValue InstanceID { get; set; }

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
        /// Gets or Sets ProcCenterID
        /// </summary>
        [DataMember(Name="ProcCenterID", EmitDefaultValue=false)]
        public StringValue ProcCenterID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomerPaymentMethod {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  CardAccountNbr: ").Append(CardAccountNbr).Append("\n");
            sb.Append("  CashAccount: ").Append(CashAccount).Append("\n");
            sb.Append("  CreatedDateTime: ").Append(CreatedDateTime).Append("\n");
            sb.Append("  CustomerID: ").Append(CustomerID).Append("\n");
            sb.Append("  CustomerProfileID: ").Append(CustomerProfileID).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  InstanceID: ").Append(InstanceID).Append("\n");
            sb.Append("  LastModifiedDateTime: ").Append(LastModifiedDateTime).Append("\n");
            sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
            sb.Append("  ProcCenterID: ").Append(ProcCenterID).Append("\n");
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
            return this.Equals(input as CustomerPaymentMethod);
        }

        /// <summary>
        /// Returns true if CustomerPaymentMethod instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomerPaymentMethod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomerPaymentMethod input)
        {
            if (input == null)
                return false;

            return base.Equals(input) &&
                (
                    this.Active == input.Active ||
                    (this.Active != null &&
                    this.Active.Equals(input.Active))
                ) && base.Equals(input) &&
                (
                    this.CardAccountNbr == input.CardAccountNbr ||
                    (this.CardAccountNbr != null &&
                    this.CardAccountNbr.Equals(input.CardAccountNbr))
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
                    this.CustomerProfileID == input.CustomerProfileID ||
                    (this.CustomerProfileID != null &&
                    this.CustomerProfileID.Equals(input.CustomerProfileID))
                ) && base.Equals(input) &&
                (
                    this.Details == input.Details ||
                    this.Details != null &&
                    this.Details.SequenceEqual(input.Details)
                ) && base.Equals(input) &&
                (
                    this.InstanceID == input.InstanceID ||
                    (this.InstanceID != null &&
                    this.InstanceID.Equals(input.InstanceID))
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
                    this.ProcCenterID == input.ProcCenterID ||
                    (this.ProcCenterID != null &&
                    this.ProcCenterID.Equals(input.ProcCenterID))
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
                if (this.Active != null)
                    hashCode = hashCode * 59 + this.Active.GetHashCode();
                if (this.CardAccountNbr != null)
                    hashCode = hashCode * 59 + this.CardAccountNbr.GetHashCode();
                if (this.CashAccount != null)
                    hashCode = hashCode * 59 + this.CashAccount.GetHashCode();
                if (this.CreatedDateTime != null)
                    hashCode = hashCode * 59 + this.CreatedDateTime.GetHashCode();
                if (this.CustomerID != null)
                    hashCode = hashCode * 59 + this.CustomerID.GetHashCode();
                if (this.CustomerProfileID != null)
                    hashCode = hashCode * 59 + this.CustomerProfileID.GetHashCode();
                if (this.Details != null)
                    hashCode = hashCode * 59 + this.Details.GetHashCode();
                if (this.InstanceID != null)
                    hashCode = hashCode * 59 + this.InstanceID.GetHashCode();
                if (this.LastModifiedDateTime != null)
                    hashCode = hashCode * 59 + this.LastModifiedDateTime.GetHashCode();
                if (this.PaymentMethod != null)
                    hashCode = hashCode * 59 + this.PaymentMethod.GetHashCode();
                if (this.ProcCenterID != null)
                    hashCode = hashCode * 59 + this.ProcCenterID.GetHashCode();
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
