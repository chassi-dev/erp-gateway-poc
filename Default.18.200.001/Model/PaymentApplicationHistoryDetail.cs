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
    /// PaymentApplicationHistoryDetail
    /// </summary>
    [DataContract]
    public partial class PaymentApplicationHistoryDetail : Entity,  IEquatable<PaymentApplicationHistoryDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentApplicationHistoryDetail" /> class.
        /// </summary>
        /// <param name="adjustedDocType">adjustedDocType.</param>
        /// <param name="adjustedRefNbr">adjustedRefNbr.</param>
        /// <param name="adjustingDocType">adjustingDocType.</param>
        /// <param name="adjustingRefNbr">adjustingRefNbr.</param>
        /// <param name="adjustmentNbr">adjustmentNbr.</param>
        /// <param name="adjustsVAT">adjustsVAT.</param>
        /// <param name="amountPaid">amountPaid.</param>
        /// <param name="applicationPeriod">applicationPeriod.</param>
        /// <param name="balance">balance.</param>
        /// <param name="balanceWriteOff">balanceWriteOff.</param>
        /// <param name="batchNbr">batchNbr.</param>
        /// <param name="cashDiscountBalance">cashDiscountBalance.</param>
        /// <param name="cashDiscountDate">cashDiscountDate.</param>
        /// <param name="cashDiscountTaken">cashDiscountTaken.</param>
        /// <param name="currencyID">currencyID.</param>
        /// <param name="customer">customer.</param>
        /// <param name="customerOrder">customerOrder.</param>
        /// <param name="date">date.</param>
        /// <param name="description">description.</param>
        /// <param name="displayDocType">displayDocType.</param>
        /// <param name="displayRefNbr">displayRefNbr.</param>
        /// <param name="dueDate">dueDate.</param>
        /// <param name="postPeriod">postPeriod.</param>
        /// <param name="vATCreditMemo">vATCreditMemo.</param>
        public PaymentApplicationHistoryDetail(StringValue adjustedDocType = default(StringValue), StringValue adjustedRefNbr = default(StringValue), StringValue adjustingDocType = default(StringValue), StringValue adjustingRefNbr = default(StringValue), IntValue adjustmentNbr = default(IntValue), BooleanValue adjustsVAT = default(BooleanValue), DecimalValue amountPaid = default(DecimalValue), StringValue applicationPeriod = default(StringValue), DecimalValue balance = default(DecimalValue), DecimalValue balanceWriteOff = default(DecimalValue), StringValue batchNbr = default(StringValue), DecimalValue cashDiscountBalance = default(DecimalValue), DateTimeValue cashDiscountDate = default(DateTimeValue), DecimalValue cashDiscountTaken = default(DecimalValue), StringValue currencyID = default(StringValue), StringValue customer = default(StringValue), StringValue customerOrder = default(StringValue), DateTimeValue date = default(DateTimeValue), StringValue description = default(StringValue), StringValue displayDocType = default(StringValue), StringValue displayRefNbr = default(StringValue), DateTimeValue dueDate = default(DateTimeValue), StringValue postPeriod = default(StringValue), StringValue vATCreditMemo = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.AdjustedDocType = adjustedDocType;
            this.AdjustedRefNbr = adjustedRefNbr;
            this.AdjustingDocType = adjustingDocType;
            this.AdjustingRefNbr = adjustingRefNbr;
            this.AdjustmentNbr = adjustmentNbr;
            this.AdjustsVAT = adjustsVAT;
            this.AmountPaid = amountPaid;
            this.ApplicationPeriod = applicationPeriod;
            this.Balance = balance;
            this.BalanceWriteOff = balanceWriteOff;
            this.BatchNbr = batchNbr;
            this.CashDiscountBalance = cashDiscountBalance;
            this.CashDiscountDate = cashDiscountDate;
            this.CashDiscountTaken = cashDiscountTaken;
            this.CurrencyID = currencyID;
            this.Customer = customer;
            this.CustomerOrder = customerOrder;
            this.Date = date;
            this.Description = description;
            this.DisplayDocType = displayDocType;
            this.DisplayRefNbr = displayRefNbr;
            this.DueDate = dueDate;
            this.PostPeriod = postPeriod;
            this.VATCreditMemo = vATCreditMemo;
        }

        /// <summary>
        /// Gets or Sets AdjustedDocType
        /// </summary>
        [DataMember(Name="AdjustedDocType", EmitDefaultValue=false)]
        public StringValue AdjustedDocType { get; set; }

        /// <summary>
        /// Gets or Sets AdjustedRefNbr
        /// </summary>
        [DataMember(Name="AdjustedRefNbr", EmitDefaultValue=false)]
        public StringValue AdjustedRefNbr { get; set; }

        /// <summary>
        /// Gets or Sets AdjustingDocType
        /// </summary>
        [DataMember(Name="AdjustingDocType", EmitDefaultValue=false)]
        public StringValue AdjustingDocType { get; set; }

        /// <summary>
        /// Gets or Sets AdjustingRefNbr
        /// </summary>
        [DataMember(Name="AdjustingRefNbr", EmitDefaultValue=false)]
        public StringValue AdjustingRefNbr { get; set; }

        /// <summary>
        /// Gets or Sets AdjustmentNbr
        /// </summary>
        [DataMember(Name="AdjustmentNbr", EmitDefaultValue=false)]
        public IntValue AdjustmentNbr { get; set; }

        /// <summary>
        /// Gets or Sets AdjustsVAT
        /// </summary>
        [DataMember(Name="AdjustsVAT", EmitDefaultValue=false)]
        public BooleanValue AdjustsVAT { get; set; }

        /// <summary>
        /// Gets or Sets AmountPaid
        /// </summary>
        [DataMember(Name="AmountPaid", EmitDefaultValue=false)]
        public DecimalValue AmountPaid { get; set; }

        /// <summary>
        /// Gets or Sets ApplicationPeriod
        /// </summary>
        [DataMember(Name="ApplicationPeriod", EmitDefaultValue=false)]
        public StringValue ApplicationPeriod { get; set; }

        /// <summary>
        /// Gets or Sets Balance
        /// </summary>
        [DataMember(Name="Balance", EmitDefaultValue=false)]
        public DecimalValue Balance { get; set; }

        /// <summary>
        /// Gets or Sets BalanceWriteOff
        /// </summary>
        [DataMember(Name="BalanceWriteOff", EmitDefaultValue=false)]
        public DecimalValue BalanceWriteOff { get; set; }

        /// <summary>
        /// Gets or Sets BatchNbr
        /// </summary>
        [DataMember(Name="BatchNbr", EmitDefaultValue=false)]
        public StringValue BatchNbr { get; set; }

        /// <summary>
        /// Gets or Sets CashDiscountBalance
        /// </summary>
        [DataMember(Name="CashDiscountBalance", EmitDefaultValue=false)]
        public DecimalValue CashDiscountBalance { get; set; }

        /// <summary>
        /// Gets or Sets CashDiscountDate
        /// </summary>
        [DataMember(Name="CashDiscountDate", EmitDefaultValue=false)]
        public DateTimeValue CashDiscountDate { get; set; }

        /// <summary>
        /// Gets or Sets CashDiscountTaken
        /// </summary>
        [DataMember(Name="CashDiscountTaken", EmitDefaultValue=false)]
        public DecimalValue CashDiscountTaken { get; set; }

        /// <summary>
        /// Gets or Sets CurrencyID
        /// </summary>
        [DataMember(Name="CurrencyID", EmitDefaultValue=false)]
        public StringValue CurrencyID { get; set; }

        /// <summary>
        /// Gets or Sets Customer
        /// </summary>
        [DataMember(Name="Customer", EmitDefaultValue=false)]
        public StringValue Customer { get; set; }

        /// <summary>
        /// Gets or Sets CustomerOrder
        /// </summary>
        [DataMember(Name="CustomerOrder", EmitDefaultValue=false)]
        public StringValue CustomerOrder { get; set; }

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
        /// Gets or Sets DisplayDocType
        /// </summary>
        [DataMember(Name="DisplayDocType", EmitDefaultValue=false)]
        public StringValue DisplayDocType { get; set; }

        /// <summary>
        /// Gets or Sets DisplayRefNbr
        /// </summary>
        [DataMember(Name="DisplayRefNbr", EmitDefaultValue=false)]
        public StringValue DisplayRefNbr { get; set; }

        /// <summary>
        /// Gets or Sets DueDate
        /// </summary>
        [DataMember(Name="DueDate", EmitDefaultValue=false)]
        public DateTimeValue DueDate { get; set; }

        /// <summary>
        /// Gets or Sets PostPeriod
        /// </summary>
        [DataMember(Name="PostPeriod", EmitDefaultValue=false)]
        public StringValue PostPeriod { get; set; }

        /// <summary>
        /// Gets or Sets VATCreditMemo
        /// </summary>
        [DataMember(Name="VATCreditMemo", EmitDefaultValue=false)]
        public StringValue VATCreditMemo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentApplicationHistoryDetail {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  AdjustedDocType: ").Append(AdjustedDocType).Append("\n");
            sb.Append("  AdjustedRefNbr: ").Append(AdjustedRefNbr).Append("\n");
            sb.Append("  AdjustingDocType: ").Append(AdjustingDocType).Append("\n");
            sb.Append("  AdjustingRefNbr: ").Append(AdjustingRefNbr).Append("\n");
            sb.Append("  AdjustmentNbr: ").Append(AdjustmentNbr).Append("\n");
            sb.Append("  AdjustsVAT: ").Append(AdjustsVAT).Append("\n");
            sb.Append("  AmountPaid: ").Append(AmountPaid).Append("\n");
            sb.Append("  ApplicationPeriod: ").Append(ApplicationPeriod).Append("\n");
            sb.Append("  Balance: ").Append(Balance).Append("\n");
            sb.Append("  BalanceWriteOff: ").Append(BalanceWriteOff).Append("\n");
            sb.Append("  BatchNbr: ").Append(BatchNbr).Append("\n");
            sb.Append("  CashDiscountBalance: ").Append(CashDiscountBalance).Append("\n");
            sb.Append("  CashDiscountDate: ").Append(CashDiscountDate).Append("\n");
            sb.Append("  CashDiscountTaken: ").Append(CashDiscountTaken).Append("\n");
            sb.Append("  CurrencyID: ").Append(CurrencyID).Append("\n");
            sb.Append("  Customer: ").Append(Customer).Append("\n");
            sb.Append("  CustomerOrder: ").Append(CustomerOrder).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DisplayDocType: ").Append(DisplayDocType).Append("\n");
            sb.Append("  DisplayRefNbr: ").Append(DisplayRefNbr).Append("\n");
            sb.Append("  DueDate: ").Append(DueDate).Append("\n");
            sb.Append("  PostPeriod: ").Append(PostPeriod).Append("\n");
            sb.Append("  VATCreditMemo: ").Append(VATCreditMemo).Append("\n");
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
            return this.Equals(input as PaymentApplicationHistoryDetail);
        }

        /// <summary>
        /// Returns true if PaymentApplicationHistoryDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentApplicationHistoryDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentApplicationHistoryDetail input)
        {
            if (input == null)
                return false;

            return base.Equals(input) &&
                (
                    this.AdjustedDocType == input.AdjustedDocType ||
                    (this.AdjustedDocType != null &&
                    this.AdjustedDocType.Equals(input.AdjustedDocType))
                ) && base.Equals(input) &&
                (
                    this.AdjustedRefNbr == input.AdjustedRefNbr ||
                    (this.AdjustedRefNbr != null &&
                    this.AdjustedRefNbr.Equals(input.AdjustedRefNbr))
                ) && base.Equals(input) &&
                (
                    this.AdjustingDocType == input.AdjustingDocType ||
                    (this.AdjustingDocType != null &&
                    this.AdjustingDocType.Equals(input.AdjustingDocType))
                ) && base.Equals(input) &&
                (
                    this.AdjustingRefNbr == input.AdjustingRefNbr ||
                    (this.AdjustingRefNbr != null &&
                    this.AdjustingRefNbr.Equals(input.AdjustingRefNbr))
                ) && base.Equals(input) &&
                (
                    this.AdjustmentNbr == input.AdjustmentNbr ||
                    (this.AdjustmentNbr != null &&
                    this.AdjustmentNbr.Equals(input.AdjustmentNbr))
                ) && base.Equals(input) &&
                (
                    this.AdjustsVAT == input.AdjustsVAT ||
                    (this.AdjustsVAT != null &&
                    this.AdjustsVAT.Equals(input.AdjustsVAT))
                ) && base.Equals(input) &&
                (
                    this.AmountPaid == input.AmountPaid ||
                    (this.AmountPaid != null &&
                    this.AmountPaid.Equals(input.AmountPaid))
                ) && base.Equals(input) &&
                (
                    this.ApplicationPeriod == input.ApplicationPeriod ||
                    (this.ApplicationPeriod != null &&
                    this.ApplicationPeriod.Equals(input.ApplicationPeriod))
                ) && base.Equals(input) &&
                (
                    this.Balance == input.Balance ||
                    (this.Balance != null &&
                    this.Balance.Equals(input.Balance))
                ) && base.Equals(input) &&
                (
                    this.BalanceWriteOff == input.BalanceWriteOff ||
                    (this.BalanceWriteOff != null &&
                    this.BalanceWriteOff.Equals(input.BalanceWriteOff))
                ) && base.Equals(input) &&
                (
                    this.BatchNbr == input.BatchNbr ||
                    (this.BatchNbr != null &&
                    this.BatchNbr.Equals(input.BatchNbr))
                ) && base.Equals(input) &&
                (
                    this.CashDiscountBalance == input.CashDiscountBalance ||
                    (this.CashDiscountBalance != null &&
                    this.CashDiscountBalance.Equals(input.CashDiscountBalance))
                ) && base.Equals(input) &&
                (
                    this.CashDiscountDate == input.CashDiscountDate ||
                    (this.CashDiscountDate != null &&
                    this.CashDiscountDate.Equals(input.CashDiscountDate))
                ) && base.Equals(input) &&
                (
                    this.CashDiscountTaken == input.CashDiscountTaken ||
                    (this.CashDiscountTaken != null &&
                    this.CashDiscountTaken.Equals(input.CashDiscountTaken))
                ) && base.Equals(input) &&
                (
                    this.CurrencyID == input.CurrencyID ||
                    (this.CurrencyID != null &&
                    this.CurrencyID.Equals(input.CurrencyID))
                ) && base.Equals(input) &&
                (
                    this.Customer == input.Customer ||
                    (this.Customer != null &&
                    this.Customer.Equals(input.Customer))
                ) && base.Equals(input) &&
                (
                    this.CustomerOrder == input.CustomerOrder ||
                    (this.CustomerOrder != null &&
                    this.CustomerOrder.Equals(input.CustomerOrder))
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
                    this.DisplayDocType == input.DisplayDocType ||
                    (this.DisplayDocType != null &&
                    this.DisplayDocType.Equals(input.DisplayDocType))
                ) && base.Equals(input) &&
                (
                    this.DisplayRefNbr == input.DisplayRefNbr ||
                    (this.DisplayRefNbr != null &&
                    this.DisplayRefNbr.Equals(input.DisplayRefNbr))
                ) && base.Equals(input) &&
                (
                    this.DueDate == input.DueDate ||
                    (this.DueDate != null &&
                    this.DueDate.Equals(input.DueDate))
                ) && base.Equals(input) &&
                (
                    this.PostPeriod == input.PostPeriod ||
                    (this.PostPeriod != null &&
                    this.PostPeriod.Equals(input.PostPeriod))
                ) && base.Equals(input) &&
                (
                    this.VATCreditMemo == input.VATCreditMemo ||
                    (this.VATCreditMemo != null &&
                    this.VATCreditMemo.Equals(input.VATCreditMemo))
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
                if (this.AdjustedDocType != null)
                    hashCode = hashCode * 59 + this.AdjustedDocType.GetHashCode();
                if (this.AdjustedRefNbr != null)
                    hashCode = hashCode * 59 + this.AdjustedRefNbr.GetHashCode();
                if (this.AdjustingDocType != null)
                    hashCode = hashCode * 59 + this.AdjustingDocType.GetHashCode();
                if (this.AdjustingRefNbr != null)
                    hashCode = hashCode * 59 + this.AdjustingRefNbr.GetHashCode();
                if (this.AdjustmentNbr != null)
                    hashCode = hashCode * 59 + this.AdjustmentNbr.GetHashCode();
                if (this.AdjustsVAT != null)
                    hashCode = hashCode * 59 + this.AdjustsVAT.GetHashCode();
                if (this.AmountPaid != null)
                    hashCode = hashCode * 59 + this.AmountPaid.GetHashCode();
                if (this.ApplicationPeriod != null)
                    hashCode = hashCode * 59 + this.ApplicationPeriod.GetHashCode();
                if (this.Balance != null)
                    hashCode = hashCode * 59 + this.Balance.GetHashCode();
                if (this.BalanceWriteOff != null)
                    hashCode = hashCode * 59 + this.BalanceWriteOff.GetHashCode();
                if (this.BatchNbr != null)
                    hashCode = hashCode * 59 + this.BatchNbr.GetHashCode();
                if (this.CashDiscountBalance != null)
                    hashCode = hashCode * 59 + this.CashDiscountBalance.GetHashCode();
                if (this.CashDiscountDate != null)
                    hashCode = hashCode * 59 + this.CashDiscountDate.GetHashCode();
                if (this.CashDiscountTaken != null)
                    hashCode = hashCode * 59 + this.CashDiscountTaken.GetHashCode();
                if (this.CurrencyID != null)
                    hashCode = hashCode * 59 + this.CurrencyID.GetHashCode();
                if (this.Customer != null)
                    hashCode = hashCode * 59 + this.Customer.GetHashCode();
                if (this.CustomerOrder != null)
                    hashCode = hashCode * 59 + this.CustomerOrder.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DisplayDocType != null)
                    hashCode = hashCode * 59 + this.DisplayDocType.GetHashCode();
                if (this.DisplayRefNbr != null)
                    hashCode = hashCode * 59 + this.DisplayRefNbr.GetHashCode();
                if (this.DueDate != null)
                    hashCode = hashCode * 59 + this.DueDate.GetHashCode();
                if (this.PostPeriod != null)
                    hashCode = hashCode * 59 + this.PostPeriod.GetHashCode();
                if (this.VATCreditMemo != null)
                    hashCode = hashCode * 59 + this.VATCreditMemo.GetHashCode();
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
