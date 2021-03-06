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
    /// BusinessAccountLocation
    /// </summary>
    [DataContract]
    public partial class BusinessAccountLocation : Entity,  IEquatable<BusinessAccountLocation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessAccountLocation" /> class.
        /// </summary>
        /// <param name="active">active.</param>
        /// <param name="city">city.</param>
        /// <param name="country">country.</param>
        /// <param name="_default">_default.</param>
        /// <param name="locationID">locationID.</param>
        /// <param name="locationName">locationName.</param>
        /// <param name="priceClass">priceClass.</param>
        /// <param name="salesAccount">salesAccount.</param>
        /// <param name="salesSubaccount">salesSubaccount.</param>
        /// <param name="state">state.</param>
        /// <param name="taxZone">taxZone.</param>
        public BusinessAccountLocation(BooleanValue active = default(BooleanValue), StringValue city = default(StringValue), StringValue country = default(StringValue), BooleanValue _default = default(BooleanValue), StringValue locationID = default(StringValue), StringValue locationName = default(StringValue), StringValue priceClass = default(StringValue), StringValue salesAccount = default(StringValue), StringValue salesSubaccount = default(StringValue), StringValue state = default(StringValue), StringValue taxZone = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.Active = active;
            this.City = city;
            this.Country = country;
            this.Default = _default;
            this.LocationID = locationID;
            this.LocationName = locationName;
            this.PriceClass = priceClass;
            this.SalesAccount = salesAccount;
            this.SalesSubaccount = salesSubaccount;
            this.State = state;
            this.TaxZone = taxZone;
        }

        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name="Active", EmitDefaultValue=false)]
        public BooleanValue Active { get; set; }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name="City", EmitDefaultValue=false)]
        public StringValue City { get; set; }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name="Country", EmitDefaultValue=false)]
        public StringValue Country { get; set; }

        /// <summary>
        /// Gets or Sets Default
        /// </summary>
        [DataMember(Name="Default", EmitDefaultValue=false)]
        public BooleanValue Default { get; set; }

        /// <summary>
        /// Gets or Sets LocationID
        /// </summary>
        [DataMember(Name="LocationID", EmitDefaultValue=false)]
        public StringValue LocationID { get; set; }

        /// <summary>
        /// Gets or Sets LocationName
        /// </summary>
        [DataMember(Name="LocationName", EmitDefaultValue=false)]
        public StringValue LocationName { get; set; }

        /// <summary>
        /// Gets or Sets PriceClass
        /// </summary>
        [DataMember(Name="PriceClass", EmitDefaultValue=false)]
        public StringValue PriceClass { get; set; }

        /// <summary>
        /// Gets or Sets SalesAccount
        /// </summary>
        [DataMember(Name="SalesAccount", EmitDefaultValue=false)]
        public StringValue SalesAccount { get; set; }

        /// <summary>
        /// Gets or Sets SalesSubaccount
        /// </summary>
        [DataMember(Name="SalesSubaccount", EmitDefaultValue=false)]
        public StringValue SalesSubaccount { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="State", EmitDefaultValue=false)]
        public StringValue State { get; set; }

        /// <summary>
        /// Gets or Sets TaxZone
        /// </summary>
        [DataMember(Name="TaxZone", EmitDefaultValue=false)]
        public StringValue TaxZone { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BusinessAccountLocation {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Default: ").Append(Default).Append("\n");
            sb.Append("  LocationID: ").Append(LocationID).Append("\n");
            sb.Append("  LocationName: ").Append(LocationName).Append("\n");
            sb.Append("  PriceClass: ").Append(PriceClass).Append("\n");
            sb.Append("  SalesAccount: ").Append(SalesAccount).Append("\n");
            sb.Append("  SalesSubaccount: ").Append(SalesSubaccount).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  TaxZone: ").Append(TaxZone).Append("\n");
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
            return this.Equals(input as BusinessAccountLocation);
        }

        /// <summary>
        /// Returns true if BusinessAccountLocation instances are equal
        /// </summary>
        /// <param name="input">Instance of BusinessAccountLocation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BusinessAccountLocation input)
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
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && base.Equals(input) &&
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && base.Equals(input) &&
                (
                    this.Default == input.Default ||
                    (this.Default != null &&
                    this.Default.Equals(input.Default))
                ) && base.Equals(input) &&
                (
                    this.LocationID == input.LocationID ||
                    (this.LocationID != null &&
                    this.LocationID.Equals(input.LocationID))
                ) && base.Equals(input) &&
                (
                    this.LocationName == input.LocationName ||
                    (this.LocationName != null &&
                    this.LocationName.Equals(input.LocationName))
                ) && base.Equals(input) &&
                (
                    this.PriceClass == input.PriceClass ||
                    (this.PriceClass != null &&
                    this.PriceClass.Equals(input.PriceClass))
                ) && base.Equals(input) &&
                (
                    this.SalesAccount == input.SalesAccount ||
                    (this.SalesAccount != null &&
                    this.SalesAccount.Equals(input.SalesAccount))
                ) && base.Equals(input) &&
                (
                    this.SalesSubaccount == input.SalesSubaccount ||
                    (this.SalesSubaccount != null &&
                    this.SalesSubaccount.Equals(input.SalesSubaccount))
                ) && base.Equals(input) &&
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && base.Equals(input) &&
                (
                    this.TaxZone == input.TaxZone ||
                    (this.TaxZone != null &&
                    this.TaxZone.Equals(input.TaxZone))
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
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.Default != null)
                    hashCode = hashCode * 59 + this.Default.GetHashCode();
                if (this.LocationID != null)
                    hashCode = hashCode * 59 + this.LocationID.GetHashCode();
                if (this.LocationName != null)
                    hashCode = hashCode * 59 + this.LocationName.GetHashCode();
                if (this.PriceClass != null)
                    hashCode = hashCode * 59 + this.PriceClass.GetHashCode();
                if (this.SalesAccount != null)
                    hashCode = hashCode * 59 + this.SalesAccount.GetHashCode();
                if (this.SalesSubaccount != null)
                    hashCode = hashCode * 59 + this.SalesSubaccount.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.TaxZone != null)
                    hashCode = hashCode * 59 + this.TaxZone.GetHashCode();
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
