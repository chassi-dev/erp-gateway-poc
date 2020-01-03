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
    /// PaymentMethodAllowedCashAccountDetail
    /// </summary>
    [DataContract]
    public partial class PaymentMethodAllowedCashAccountDetail : Entity,  IEquatable<PaymentMethodAllowedCashAccountDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodAllowedCashAccountDetail" /> class.
        /// </summary>
        /// <param name="aPDefault">aPDefault.</param>
        /// <param name="aPLastRefNbr">aPLastRefNbr.</param>
        /// <param name="aPSuggestNextNbr">aPSuggestNextNbr.</param>
        /// <param name="aRDefault">aRDefault.</param>
        /// <param name="aRDefaultForRefund">aRDefaultForRefund.</param>
        /// <param name="aRLastRefNbr">aRLastRefNbr.</param>
        /// <param name="aRSuggestNextNbr">aRSuggestNextNbr.</param>
        /// <param name="batchLastRefNbr">batchLastRefNbr.</param>
        /// <param name="branch">branch.</param>
        /// <param name="cashAccount">cashAccount.</param>
        /// <param name="description">description.</param>
        /// <param name="paymentMethod">paymentMethod.</param>
        /// <param name="useInAP">useInAP.</param>
        /// <param name="useInAR">useInAR.</param>
        public PaymentMethodAllowedCashAccountDetail(BooleanValue aPDefault = default(BooleanValue), StringValue aPLastRefNbr = default(StringValue), BooleanValue aPSuggestNextNbr = default(BooleanValue), BooleanValue aRDefault = default(BooleanValue), BooleanValue aRDefaultForRefund = default(BooleanValue), StringValue aRLastRefNbr = default(StringValue), BooleanValue aRSuggestNextNbr = default(BooleanValue), StringValue batchLastRefNbr = default(StringValue), StringValue branch = default(StringValue), StringValue cashAccount = default(StringValue), StringValue description = default(StringValue), StringValue paymentMethod = default(StringValue), BooleanValue useInAP = default(BooleanValue), BooleanValue useInAR = default(BooleanValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.APDefault = aPDefault;
            this.APLastRefNbr = aPLastRefNbr;
            this.APSuggestNextNbr = aPSuggestNextNbr;
            this.ARDefault = aRDefault;
            this.ARDefaultForRefund = aRDefaultForRefund;
            this.ARLastRefNbr = aRLastRefNbr;
            this.ARSuggestNextNbr = aRSuggestNextNbr;
            this.BatchLastRefNbr = batchLastRefNbr;
            this.Branch = branch;
            this.CashAccount = cashAccount;
            this.Description = description;
            this.PaymentMethod = paymentMethod;
            this.UseInAP = useInAP;
            this.UseInAR = useInAR;
        }

        /// <summary>
        /// Gets or Sets APDefault
        /// </summary>
        [DataMember(Name="APDefault", EmitDefaultValue=false)]
        public BooleanValue APDefault { get; set; }

        /// <summary>
        /// Gets or Sets APLastRefNbr
        /// </summary>
        [DataMember(Name="APLastRefNbr", EmitDefaultValue=false)]
        public StringValue APLastRefNbr { get; set; }

        /// <summary>
        /// Gets or Sets APSuggestNextNbr
        /// </summary>
        [DataMember(Name="APSuggestNextNbr", EmitDefaultValue=false)]
        public BooleanValue APSuggestNextNbr { get; set; }

        /// <summary>
        /// Gets or Sets ARDefault
        /// </summary>
        [DataMember(Name="ARDefault", EmitDefaultValue=false)]
        public BooleanValue ARDefault { get; set; }

        /// <summary>
        /// Gets or Sets ARDefaultForRefund
        /// </summary>
        [DataMember(Name="ARDefaultForRefund", EmitDefaultValue=false)]
        public BooleanValue ARDefaultForRefund { get; set; }

        /// <summary>
        /// Gets or Sets ARLastRefNbr
        /// </summary>
        [DataMember(Name="ARLastRefNbr", EmitDefaultValue=false)]
        public StringValue ARLastRefNbr { get; set; }

        /// <summary>
        /// Gets or Sets ARSuggestNextNbr
        /// </summary>
        [DataMember(Name="ARSuggestNextNbr", EmitDefaultValue=false)]
        public BooleanValue ARSuggestNextNbr { get; set; }

        /// <summary>
        /// Gets or Sets BatchLastRefNbr
        /// </summary>
        [DataMember(Name="BatchLastRefNbr", EmitDefaultValue=false)]
        public StringValue BatchLastRefNbr { get; set; }

        /// <summary>
        /// Gets or Sets Branch
        /// </summary>
        [DataMember(Name="Branch", EmitDefaultValue=false)]
        public StringValue Branch { get; set; }

        /// <summary>
        /// Gets or Sets CashAccount
        /// </summary>
        [DataMember(Name="CashAccount", EmitDefaultValue=false)]
        public StringValue CashAccount { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public StringValue Description { get; set; }

        /// <summary>
        /// Gets or Sets PaymentMethod
        /// </summary>
        [DataMember(Name="PaymentMethod", EmitDefaultValue=false)]
        public StringValue PaymentMethod { get; set; }

        /// <summary>
        /// Gets or Sets UseInAP
        /// </summary>
        [DataMember(Name="UseInAP", EmitDefaultValue=false)]
        public BooleanValue UseInAP { get; set; }

        /// <summary>
        /// Gets or Sets UseInAR
        /// </summary>
        [DataMember(Name="UseInAR", EmitDefaultValue=false)]
        public BooleanValue UseInAR { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentMethodAllowedCashAccountDetail {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  APDefault: ").Append(APDefault).Append("\n");
            sb.Append("  APLastRefNbr: ").Append(APLastRefNbr).Append("\n");
            sb.Append("  APSuggestNextNbr: ").Append(APSuggestNextNbr).Append("\n");
            sb.Append("  ARDefault: ").Append(ARDefault).Append("\n");
            sb.Append("  ARDefaultForRefund: ").Append(ARDefaultForRefund).Append("\n");
            sb.Append("  ARLastRefNbr: ").Append(ARLastRefNbr).Append("\n");
            sb.Append("  ARSuggestNextNbr: ").Append(ARSuggestNextNbr).Append("\n");
            sb.Append("  BatchLastRefNbr: ").Append(BatchLastRefNbr).Append("\n");
            sb.Append("  Branch: ").Append(Branch).Append("\n");
            sb.Append("  CashAccount: ").Append(CashAccount).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
            sb.Append("  UseInAP: ").Append(UseInAP).Append("\n");
            sb.Append("  UseInAR: ").Append(UseInAR).Append("\n");
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
            return this.Equals(input as PaymentMethodAllowedCashAccountDetail);
        }

        /// <summary>
        /// Returns true if PaymentMethodAllowedCashAccountDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentMethodAllowedCashAccountDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentMethodAllowedCashAccountDetail input)
        {
            if (input == null)
                return false;

            return base.Equals(input) &&
                (
                    this.APDefault == input.APDefault ||
                    (this.APDefault != null &&
                    this.APDefault.Equals(input.APDefault))
                ) && base.Equals(input) &&
                (
                    this.APLastRefNbr == input.APLastRefNbr ||
                    (this.APLastRefNbr != null &&
                    this.APLastRefNbr.Equals(input.APLastRefNbr))
                ) && base.Equals(input) &&
                (
                    this.APSuggestNextNbr == input.APSuggestNextNbr ||
                    (this.APSuggestNextNbr != null &&
                    this.APSuggestNextNbr.Equals(input.APSuggestNextNbr))
                ) && base.Equals(input) &&
                (
                    this.ARDefault == input.ARDefault ||
                    (this.ARDefault != null &&
                    this.ARDefault.Equals(input.ARDefault))
                ) && base.Equals(input) &&
                (
                    this.ARDefaultForRefund == input.ARDefaultForRefund ||
                    (this.ARDefaultForRefund != null &&
                    this.ARDefaultForRefund.Equals(input.ARDefaultForRefund))
                ) && base.Equals(input) &&
                (
                    this.ARLastRefNbr == input.ARLastRefNbr ||
                    (this.ARLastRefNbr != null &&
                    this.ARLastRefNbr.Equals(input.ARLastRefNbr))
                ) && base.Equals(input) &&
                (
                    this.ARSuggestNextNbr == input.ARSuggestNextNbr ||
                    (this.ARSuggestNextNbr != null &&
                    this.ARSuggestNextNbr.Equals(input.ARSuggestNextNbr))
                ) && base.Equals(input) &&
                (
                    this.BatchLastRefNbr == input.BatchLastRefNbr ||
                    (this.BatchLastRefNbr != null &&
                    this.BatchLastRefNbr.Equals(input.BatchLastRefNbr))
                ) && base.Equals(input) &&
                (
                    this.Branch == input.Branch ||
                    (this.Branch != null &&
                    this.Branch.Equals(input.Branch))
                ) && base.Equals(input) &&
                (
                    this.CashAccount == input.CashAccount ||
                    (this.CashAccount != null &&
                    this.CashAccount.Equals(input.CashAccount))
                ) && base.Equals(input) &&
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && base.Equals(input) &&
                (
                    this.PaymentMethod == input.PaymentMethod ||
                    (this.PaymentMethod != null &&
                    this.PaymentMethod.Equals(input.PaymentMethod))
                ) && base.Equals(input) &&
                (
                    this.UseInAP == input.UseInAP ||
                    (this.UseInAP != null &&
                    this.UseInAP.Equals(input.UseInAP))
                ) && base.Equals(input) &&
                (
                    this.UseInAR == input.UseInAR ||
                    (this.UseInAR != null &&
                    this.UseInAR.Equals(input.UseInAR))
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
                if (this.APDefault != null)
                    hashCode = hashCode * 59 + this.APDefault.GetHashCode();
                if (this.APLastRefNbr != null)
                    hashCode = hashCode * 59 + this.APLastRefNbr.GetHashCode();
                if (this.APSuggestNextNbr != null)
                    hashCode = hashCode * 59 + this.APSuggestNextNbr.GetHashCode();
                if (this.ARDefault != null)
                    hashCode = hashCode * 59 + this.ARDefault.GetHashCode();
                if (this.ARDefaultForRefund != null)
                    hashCode = hashCode * 59 + this.ARDefaultForRefund.GetHashCode();
                if (this.ARLastRefNbr != null)
                    hashCode = hashCode * 59 + this.ARLastRefNbr.GetHashCode();
                if (this.ARSuggestNextNbr != null)
                    hashCode = hashCode * 59 + this.ARSuggestNextNbr.GetHashCode();
                if (this.BatchLastRefNbr != null)
                    hashCode = hashCode * 59 + this.BatchLastRefNbr.GetHashCode();
                if (this.Branch != null)
                    hashCode = hashCode * 59 + this.Branch.GetHashCode();
                if (this.CashAccount != null)
                    hashCode = hashCode * 59 + this.CashAccount.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.PaymentMethod != null)
                    hashCode = hashCode * 59 + this.PaymentMethod.GetHashCode();
                if (this.UseInAP != null)
                    hashCode = hashCode * 59 + this.UseInAP.GetHashCode();
                if (this.UseInAR != null)
                    hashCode = hashCode * 59 + this.UseInAR.GetHashCode();
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
