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
    /// ShipVia
    /// </summary>
    [DataContract]
    public partial class ShipVia : Entity,  IEquatable<ShipVia>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipVia" /> class.
        /// </summary>
        /// <param name="calculationMethod">calculationMethod.</param>
        /// <param name="calendar">calendar.</param>
        /// <param name="carrierID">carrierID.</param>
        /// <param name="commonCarrier">commonCarrier.</param>
        /// <param name="description">description.</param>
        /// <param name="freightExpenseAccount">freightExpenseAccount.</param>
        /// <param name="freightExpenseSubaccount">freightExpenseSubaccount.</param>
        /// <param name="freightRates">freightRates.</param>
        /// <param name="freightSalesAccount">freightSalesAccount.</param>
        /// <param name="freightSalesSubaccount">freightSalesSubaccount.</param>
        /// <param name="packages">packages.</param>
        /// <param name="taxCategory">taxCategory.</param>
        public ShipVia(StringValue calculationMethod = default(StringValue), StringValue calendar = default(StringValue), StringValue carrierID = default(StringValue), BooleanValue commonCarrier = default(BooleanValue), StringValue description = default(StringValue), StringValue freightExpenseAccount = default(StringValue), StringValue freightExpenseSubaccount = default(StringValue), List<ShipViaFreightRate> freightRates = default(List<ShipViaFreightRate>), StringValue freightSalesAccount = default(StringValue), StringValue freightSalesSubaccount = default(StringValue), List<ShippingBox> packages = default(List<ShippingBox>), StringValue taxCategory = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.CalculationMethod = calculationMethod;
            this.Calendar = calendar;
            this.CarrierID = carrierID;
            this.CommonCarrier = commonCarrier;
            this.Description = description;
            this.FreightExpenseAccount = freightExpenseAccount;
            this.FreightExpenseSubaccount = freightExpenseSubaccount;
            this.FreightRates = freightRates;
            this.FreightSalesAccount = freightSalesAccount;
            this.FreightSalesSubaccount = freightSalesSubaccount;
            this.Packages = packages;
            this.TaxCategory = taxCategory;
        }

        /// <summary>
        /// Gets or Sets CalculationMethod
        /// </summary>
        [DataMember(Name="CalculationMethod", EmitDefaultValue=false)]
        public StringValue CalculationMethod { get; set; }

        /// <summary>
        /// Gets or Sets Calendar
        /// </summary>
        [DataMember(Name="Calendar", EmitDefaultValue=false)]
        public StringValue Calendar { get; set; }

        /// <summary>
        /// Gets or Sets CarrierID
        /// </summary>
        [DataMember(Name="CarrierID", EmitDefaultValue=false)]
        public StringValue CarrierID { get; set; }

        /// <summary>
        /// Gets or Sets CommonCarrier
        /// </summary>
        [DataMember(Name="CommonCarrier", EmitDefaultValue=false)]
        public BooleanValue CommonCarrier { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public StringValue Description { get; set; }

        /// <summary>
        /// Gets or Sets FreightExpenseAccount
        /// </summary>
        [DataMember(Name="FreightExpenseAccount", EmitDefaultValue=false)]
        public StringValue FreightExpenseAccount { get; set; }

        /// <summary>
        /// Gets or Sets FreightExpenseSubaccount
        /// </summary>
        [DataMember(Name="FreightExpenseSubaccount", EmitDefaultValue=false)]
        public StringValue FreightExpenseSubaccount { get; set; }

        /// <summary>
        /// Gets or Sets FreightRates
        /// </summary>
        [DataMember(Name="FreightRates", EmitDefaultValue=false)]
        public List<ShipViaFreightRate> FreightRates { get; set; }

        /// <summary>
        /// Gets or Sets FreightSalesAccount
        /// </summary>
        [DataMember(Name="FreightSalesAccount", EmitDefaultValue=false)]
        public StringValue FreightSalesAccount { get; set; }

        /// <summary>
        /// Gets or Sets FreightSalesSubaccount
        /// </summary>
        [DataMember(Name="FreightSalesSubaccount", EmitDefaultValue=false)]
        public StringValue FreightSalesSubaccount { get; set; }

        /// <summary>
        /// Gets or Sets Packages
        /// </summary>
        [DataMember(Name="Packages", EmitDefaultValue=false)]
        public List<ShippingBox> Packages { get; set; }

        /// <summary>
        /// Gets or Sets TaxCategory
        /// </summary>
        [DataMember(Name="TaxCategory", EmitDefaultValue=false)]
        public StringValue TaxCategory { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShipVia {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  CalculationMethod: ").Append(CalculationMethod).Append("\n");
            sb.Append("  Calendar: ").Append(Calendar).Append("\n");
            sb.Append("  CarrierID: ").Append(CarrierID).Append("\n");
            sb.Append("  CommonCarrier: ").Append(CommonCarrier).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  FreightExpenseAccount: ").Append(FreightExpenseAccount).Append("\n");
            sb.Append("  FreightExpenseSubaccount: ").Append(FreightExpenseSubaccount).Append("\n");
            sb.Append("  FreightRates: ").Append(FreightRates).Append("\n");
            sb.Append("  FreightSalesAccount: ").Append(FreightSalesAccount).Append("\n");
            sb.Append("  FreightSalesSubaccount: ").Append(FreightSalesSubaccount).Append("\n");
            sb.Append("  Packages: ").Append(Packages).Append("\n");
            sb.Append("  TaxCategory: ").Append(TaxCategory).Append("\n");
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
            return this.Equals(input as ShipVia);
        }

        /// <summary>
        /// Returns true if ShipVia instances are equal
        /// </summary>
        /// <param name="input">Instance of ShipVia to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShipVia input)
        {
            if (input == null)
                return false;

            return base.Equals(input) &&
                (
                    this.CalculationMethod == input.CalculationMethod ||
                    (this.CalculationMethod != null &&
                    this.CalculationMethod.Equals(input.CalculationMethod))
                ) && base.Equals(input) &&
                (
                    this.Calendar == input.Calendar ||
                    (this.Calendar != null &&
                    this.Calendar.Equals(input.Calendar))
                ) && base.Equals(input) &&
                (
                    this.CarrierID == input.CarrierID ||
                    (this.CarrierID != null &&
                    this.CarrierID.Equals(input.CarrierID))
                ) && base.Equals(input) &&
                (
                    this.CommonCarrier == input.CommonCarrier ||
                    (this.CommonCarrier != null &&
                    this.CommonCarrier.Equals(input.CommonCarrier))
                ) && base.Equals(input) &&
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && base.Equals(input) &&
                (
                    this.FreightExpenseAccount == input.FreightExpenseAccount ||
                    (this.FreightExpenseAccount != null &&
                    this.FreightExpenseAccount.Equals(input.FreightExpenseAccount))
                ) && base.Equals(input) &&
                (
                    this.FreightExpenseSubaccount == input.FreightExpenseSubaccount ||
                    (this.FreightExpenseSubaccount != null &&
                    this.FreightExpenseSubaccount.Equals(input.FreightExpenseSubaccount))
                ) && base.Equals(input) &&
                (
                    this.FreightRates == input.FreightRates ||
                    this.FreightRates != null &&
                    this.FreightRates.SequenceEqual(input.FreightRates)
                ) && base.Equals(input) &&
                (
                    this.FreightSalesAccount == input.FreightSalesAccount ||
                    (this.FreightSalesAccount != null &&
                    this.FreightSalesAccount.Equals(input.FreightSalesAccount))
                ) && base.Equals(input) &&
                (
                    this.FreightSalesSubaccount == input.FreightSalesSubaccount ||
                    (this.FreightSalesSubaccount != null &&
                    this.FreightSalesSubaccount.Equals(input.FreightSalesSubaccount))
                ) && base.Equals(input) &&
                (
                    this.Packages == input.Packages ||
                    this.Packages != null &&
                    this.Packages.SequenceEqual(input.Packages)
                ) && base.Equals(input) &&
                (
                    this.TaxCategory == input.TaxCategory ||
                    (this.TaxCategory != null &&
                    this.TaxCategory.Equals(input.TaxCategory))
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
                if (this.CalculationMethod != null)
                    hashCode = hashCode * 59 + this.CalculationMethod.GetHashCode();
                if (this.Calendar != null)
                    hashCode = hashCode * 59 + this.Calendar.GetHashCode();
                if (this.CarrierID != null)
                    hashCode = hashCode * 59 + this.CarrierID.GetHashCode();
                if (this.CommonCarrier != null)
                    hashCode = hashCode * 59 + this.CommonCarrier.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.FreightExpenseAccount != null)
                    hashCode = hashCode * 59 + this.FreightExpenseAccount.GetHashCode();
                if (this.FreightExpenseSubaccount != null)
                    hashCode = hashCode * 59 + this.FreightExpenseSubaccount.GetHashCode();
                if (this.FreightRates != null)
                    hashCode = hashCode * 59 + this.FreightRates.GetHashCode();
                if (this.FreightSalesAccount != null)
                    hashCode = hashCode * 59 + this.FreightSalesAccount.GetHashCode();
                if (this.FreightSalesSubaccount != null)
                    hashCode = hashCode * 59 + this.FreightSalesSubaccount.GetHashCode();
                if (this.Packages != null)
                    hashCode = hashCode * 59 + this.Packages.GetHashCode();
                if (this.TaxCategory != null)
                    hashCode = hashCode * 59 + this.TaxCategory.GetHashCode();
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
