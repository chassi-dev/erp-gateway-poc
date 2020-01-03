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
    /// AccountLocation
    /// </summary>
    [DataContract]
    public partial class AccountLocation : Entity,  IEquatable<AccountLocation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountLocation" /> class.
        /// </summary>
        /// <param name="active">active.</param>
        /// <param name="address">address.</param>
        /// <param name="addressSameAsMain">addressSameAsMain.</param>
        /// <param name="addressValidated">addressValidated.</param>
        /// <param name="aRAccount">aRAccount.</param>
        /// <param name="aRSubaccount">aRSubaccount.</param>
        /// <param name="businessAccountID">businessAccountID.</param>
        /// <param name="calendar">calendar.</param>
        /// <param name="cases">cases.</param>
        /// <param name="contact">contact.</param>
        /// <param name="defaultProject">defaultProject.</param>
        /// <param name="discountAccount">discountAccount.</param>
        /// <param name="discountSubaccount">discountSubaccount.</param>
        /// <param name="entityUsageType">entityUsageType.</param>
        /// <param name="fedExGroundCollect">fedExGroundCollect.</param>
        /// <param name="fOBPoint">fOBPoint.</param>
        /// <param name="freightAccount">freightAccount.</param>
        /// <param name="freightSubaccount">freightSubaccount.</param>
        /// <param name="insurance">insurance.</param>
        /// <param name="leadTimeInDays">leadTimeInDays.</param>
        /// <param name="locationID">locationID.</param>
        /// <param name="locationName">locationName.</param>
        /// <param name="opportunities">opportunities.</param>
        /// <param name="orderPriority">orderPriority.</param>
        /// <param name="priceClass">priceClass.</param>
        /// <param name="residentialDelivery">residentialDelivery.</param>
        /// <param name="salesAccount">salesAccount.</param>
        /// <param name="salesSubaccount">salesSubaccount.</param>
        /// <param name="sameAsDefaultLocation">sameAsDefaultLocation.</param>
        /// <param name="saturdayDelivery">saturdayDelivery.</param>
        /// <param name="shippingBranch">shippingBranch.</param>
        /// <param name="shippingRule">shippingRule.</param>
        /// <param name="shippingTerms">shippingTerms.</param>
        /// <param name="shippingZone">shippingZone.</param>
        /// <param name="shipVia">shipVia.</param>
        /// <param name="taxExemptionNumber">taxExemptionNumber.</param>
        /// <param name="taxRegistrationID">taxRegistrationID.</param>
        /// <param name="taxZone">taxZone.</param>
        /// <param name="warehouse">warehouse.</param>
        public AccountLocation(BooleanValue active = default(BooleanValue), Address address = default(Address), BooleanValue addressSameAsMain = default(BooleanValue), BooleanValue addressValidated = default(BooleanValue), StringValue aRAccount = default(StringValue), StringValue aRSubaccount = default(StringValue), StringValue businessAccountID = default(StringValue), StringValue calendar = default(StringValue), List<CaseDetail> cases = default(List<CaseDetail>), AccountLocationContact contact = default(AccountLocationContact), StringValue defaultProject = default(StringValue), StringValue discountAccount = default(StringValue), StringValue discountSubaccount = default(StringValue), StringValue entityUsageType = default(StringValue), BooleanValue fedExGroundCollect = default(BooleanValue), StringValue fOBPoint = default(StringValue), StringValue freightAccount = default(StringValue), StringValue freightSubaccount = default(StringValue), BooleanValue insurance = default(BooleanValue), ShortValue leadTimeInDays = default(ShortValue), StringValue locationID = default(StringValue), StringValue locationName = default(StringValue), List<OpportunityDetail> opportunities = default(List<OpportunityDetail>), ShortValue orderPriority = default(ShortValue), StringValue priceClass = default(StringValue), BooleanValue residentialDelivery = default(BooleanValue), StringValue salesAccount = default(StringValue), StringValue salesSubaccount = default(StringValue), BooleanValue sameAsDefaultLocation = default(BooleanValue), BooleanValue saturdayDelivery = default(BooleanValue), StringValue shippingBranch = default(StringValue), StringValue shippingRule = default(StringValue), StringValue shippingTerms = default(StringValue), StringValue shippingZone = default(StringValue), StringValue shipVia = default(StringValue), StringValue taxExemptionNumber = default(StringValue), StringValue taxRegistrationID = default(StringValue), StringValue taxZone = default(StringValue), StringValue warehouse = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.Active = active;
            this.Address = address;
            this.AddressSameAsMain = addressSameAsMain;
            this.AddressValidated = addressValidated;
            this.ARAccount = aRAccount;
            this.ARSubaccount = aRSubaccount;
            this.BusinessAccountID = businessAccountID;
            this.Calendar = calendar;
            this.Cases = cases;
            this.Contact = contact;
            this.DefaultProject = defaultProject;
            this.DiscountAccount = discountAccount;
            this.DiscountSubaccount = discountSubaccount;
            this.EntityUsageType = entityUsageType;
            this.FedExGroundCollect = fedExGroundCollect;
            this.FOBPoint = fOBPoint;
            this.FreightAccount = freightAccount;
            this.FreightSubaccount = freightSubaccount;
            this.Insurance = insurance;
            this.LeadTimeInDays = leadTimeInDays;
            this.LocationID = locationID;
            this.LocationName = locationName;
            this.Opportunities = opportunities;
            this.OrderPriority = orderPriority;
            this.PriceClass = priceClass;
            this.ResidentialDelivery = residentialDelivery;
            this.SalesAccount = salesAccount;
            this.SalesSubaccount = salesSubaccount;
            this.SameAsDefaultLocation = sameAsDefaultLocation;
            this.SaturdayDelivery = saturdayDelivery;
            this.ShippingBranch = shippingBranch;
            this.ShippingRule = shippingRule;
            this.ShippingTerms = shippingTerms;
            this.ShippingZone = shippingZone;
            this.ShipVia = shipVia;
            this.TaxExemptionNumber = taxExemptionNumber;
            this.TaxRegistrationID = taxRegistrationID;
            this.TaxZone = taxZone;
            this.Warehouse = warehouse;
        }

        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name="Active", EmitDefaultValue=false)]
        public BooleanValue Active { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="Address", EmitDefaultValue=false)]
        public Address Address { get; set; }

        /// <summary>
        /// Gets or Sets AddressSameAsMain
        /// </summary>
        [DataMember(Name="AddressSameAsMain", EmitDefaultValue=false)]
        public BooleanValue AddressSameAsMain { get; set; }

        /// <summary>
        /// Gets or Sets AddressValidated
        /// </summary>
        [DataMember(Name="AddressValidated", EmitDefaultValue=false)]
        public BooleanValue AddressValidated { get; set; }

        /// <summary>
        /// Gets or Sets ARAccount
        /// </summary>
        [DataMember(Name="ARAccount", EmitDefaultValue=false)]
        public StringValue ARAccount { get; set; }

        /// <summary>
        /// Gets or Sets ARSubaccount
        /// </summary>
        [DataMember(Name="ARSubaccount", EmitDefaultValue=false)]
        public StringValue ARSubaccount { get; set; }

        /// <summary>
        /// Gets or Sets BusinessAccountID
        /// </summary>
        [DataMember(Name="BusinessAccountID", EmitDefaultValue=false)]
        public StringValue BusinessAccountID { get; set; }

        /// <summary>
        /// Gets or Sets Calendar
        /// </summary>
        [DataMember(Name="Calendar", EmitDefaultValue=false)]
        public StringValue Calendar { get; set; }

        /// <summary>
        /// Gets or Sets Cases
        /// </summary>
        [DataMember(Name="Cases", EmitDefaultValue=false)]
        public List<CaseDetail> Cases { get; set; }

        /// <summary>
        /// Gets or Sets Contact
        /// </summary>
        [DataMember(Name="Contact", EmitDefaultValue=false)]
        public AccountLocationContact Contact { get; set; }

        /// <summary>
        /// Gets or Sets DefaultProject
        /// </summary>
        [DataMember(Name="DefaultProject", EmitDefaultValue=false)]
        public StringValue DefaultProject { get; set; }

        /// <summary>
        /// Gets or Sets DiscountAccount
        /// </summary>
        [DataMember(Name="DiscountAccount", EmitDefaultValue=false)]
        public StringValue DiscountAccount { get; set; }

        /// <summary>
        /// Gets or Sets DiscountSubaccount
        /// </summary>
        [DataMember(Name="DiscountSubaccount", EmitDefaultValue=false)]
        public StringValue DiscountSubaccount { get; set; }

        /// <summary>
        /// Gets or Sets EntityUsageType
        /// </summary>
        [DataMember(Name="EntityUsageType", EmitDefaultValue=false)]
        public StringValue EntityUsageType { get; set; }

        /// <summary>
        /// Gets or Sets FedExGroundCollect
        /// </summary>
        [DataMember(Name="FedExGroundCollect", EmitDefaultValue=false)]
        public BooleanValue FedExGroundCollect { get; set; }

        /// <summary>
        /// Gets or Sets FOBPoint
        /// </summary>
        [DataMember(Name="FOBPoint", EmitDefaultValue=false)]
        public StringValue FOBPoint { get; set; }

        /// <summary>
        /// Gets or Sets FreightAccount
        /// </summary>
        [DataMember(Name="FreightAccount", EmitDefaultValue=false)]
        public StringValue FreightAccount { get; set; }

        /// <summary>
        /// Gets or Sets FreightSubaccount
        /// </summary>
        [DataMember(Name="FreightSubaccount", EmitDefaultValue=false)]
        public StringValue FreightSubaccount { get; set; }

        /// <summary>
        /// Gets or Sets Insurance
        /// </summary>
        [DataMember(Name="Insurance", EmitDefaultValue=false)]
        public BooleanValue Insurance { get; set; }

        /// <summary>
        /// Gets or Sets LeadTimeInDays
        /// </summary>
        [DataMember(Name="LeadTimeInDays", EmitDefaultValue=false)]
        public ShortValue LeadTimeInDays { get; set; }

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
        /// Gets or Sets Opportunities
        /// </summary>
        [DataMember(Name="Opportunities", EmitDefaultValue=false)]
        public List<OpportunityDetail> Opportunities { get; set; }

        /// <summary>
        /// Gets or Sets OrderPriority
        /// </summary>
        [DataMember(Name="OrderPriority", EmitDefaultValue=false)]
        public ShortValue OrderPriority { get; set; }

        /// <summary>
        /// Gets or Sets PriceClass
        /// </summary>
        [DataMember(Name="PriceClass", EmitDefaultValue=false)]
        public StringValue PriceClass { get; set; }

        /// <summary>
        /// Gets or Sets ResidentialDelivery
        /// </summary>
        [DataMember(Name="ResidentialDelivery", EmitDefaultValue=false)]
        public BooleanValue ResidentialDelivery { get; set; }

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
        /// Gets or Sets SameAsDefaultLocation
        /// </summary>
        [DataMember(Name="SameAsDefaultLocation", EmitDefaultValue=false)]
        public BooleanValue SameAsDefaultLocation { get; set; }

        /// <summary>
        /// Gets or Sets SaturdayDelivery
        /// </summary>
        [DataMember(Name="SaturdayDelivery", EmitDefaultValue=false)]
        public BooleanValue SaturdayDelivery { get; set; }

        /// <summary>
        /// Gets or Sets ShippingBranch
        /// </summary>
        [DataMember(Name="ShippingBranch", EmitDefaultValue=false)]
        public StringValue ShippingBranch { get; set; }

        /// <summary>
        /// Gets or Sets ShippingRule
        /// </summary>
        [DataMember(Name="ShippingRule", EmitDefaultValue=false)]
        public StringValue ShippingRule { get; set; }

        /// <summary>
        /// Gets or Sets ShippingTerms
        /// </summary>
        [DataMember(Name="ShippingTerms", EmitDefaultValue=false)]
        public StringValue ShippingTerms { get; set; }

        /// <summary>
        /// Gets or Sets ShippingZone
        /// </summary>
        [DataMember(Name="ShippingZone", EmitDefaultValue=false)]
        public StringValue ShippingZone { get; set; }

        /// <summary>
        /// Gets or Sets ShipVia
        /// </summary>
        [DataMember(Name="ShipVia", EmitDefaultValue=false)]
        public StringValue ShipVia { get; set; }

        /// <summary>
        /// Gets or Sets TaxExemptionNumber
        /// </summary>
        [DataMember(Name="TaxExemptionNumber", EmitDefaultValue=false)]
        public StringValue TaxExemptionNumber { get; set; }

        /// <summary>
        /// Gets or Sets TaxRegistrationID
        /// </summary>
        [DataMember(Name="TaxRegistrationID", EmitDefaultValue=false)]
        public StringValue TaxRegistrationID { get; set; }

        /// <summary>
        /// Gets or Sets TaxZone
        /// </summary>
        [DataMember(Name="TaxZone", EmitDefaultValue=false)]
        public StringValue TaxZone { get; set; }

        /// <summary>
        /// Gets or Sets Warehouse
        /// </summary>
        [DataMember(Name="Warehouse", EmitDefaultValue=false)]
        public StringValue Warehouse { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountLocation {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  AddressSameAsMain: ").Append(AddressSameAsMain).Append("\n");
            sb.Append("  AddressValidated: ").Append(AddressValidated).Append("\n");
            sb.Append("  ARAccount: ").Append(ARAccount).Append("\n");
            sb.Append("  ARSubaccount: ").Append(ARSubaccount).Append("\n");
            sb.Append("  BusinessAccountID: ").Append(BusinessAccountID).Append("\n");
            sb.Append("  Calendar: ").Append(Calendar).Append("\n");
            sb.Append("  Cases: ").Append(Cases).Append("\n");
            sb.Append("  Contact: ").Append(Contact).Append("\n");
            sb.Append("  DefaultProject: ").Append(DefaultProject).Append("\n");
            sb.Append("  DiscountAccount: ").Append(DiscountAccount).Append("\n");
            sb.Append("  DiscountSubaccount: ").Append(DiscountSubaccount).Append("\n");
            sb.Append("  EntityUsageType: ").Append(EntityUsageType).Append("\n");
            sb.Append("  FedExGroundCollect: ").Append(FedExGroundCollect).Append("\n");
            sb.Append("  FOBPoint: ").Append(FOBPoint).Append("\n");
            sb.Append("  FreightAccount: ").Append(FreightAccount).Append("\n");
            sb.Append("  FreightSubaccount: ").Append(FreightSubaccount).Append("\n");
            sb.Append("  Insurance: ").Append(Insurance).Append("\n");
            sb.Append("  LeadTimeInDays: ").Append(LeadTimeInDays).Append("\n");
            sb.Append("  LocationID: ").Append(LocationID).Append("\n");
            sb.Append("  LocationName: ").Append(LocationName).Append("\n");
            sb.Append("  Opportunities: ").Append(Opportunities).Append("\n");
            sb.Append("  OrderPriority: ").Append(OrderPriority).Append("\n");
            sb.Append("  PriceClass: ").Append(PriceClass).Append("\n");
            sb.Append("  ResidentialDelivery: ").Append(ResidentialDelivery).Append("\n");
            sb.Append("  SalesAccount: ").Append(SalesAccount).Append("\n");
            sb.Append("  SalesSubaccount: ").Append(SalesSubaccount).Append("\n");
            sb.Append("  SameAsDefaultLocation: ").Append(SameAsDefaultLocation).Append("\n");
            sb.Append("  SaturdayDelivery: ").Append(SaturdayDelivery).Append("\n");
            sb.Append("  ShippingBranch: ").Append(ShippingBranch).Append("\n");
            sb.Append("  ShippingRule: ").Append(ShippingRule).Append("\n");
            sb.Append("  ShippingTerms: ").Append(ShippingTerms).Append("\n");
            sb.Append("  ShippingZone: ").Append(ShippingZone).Append("\n");
            sb.Append("  ShipVia: ").Append(ShipVia).Append("\n");
            sb.Append("  TaxExemptionNumber: ").Append(TaxExemptionNumber).Append("\n");
            sb.Append("  TaxRegistrationID: ").Append(TaxRegistrationID).Append("\n");
            sb.Append("  TaxZone: ").Append(TaxZone).Append("\n");
            sb.Append("  Warehouse: ").Append(Warehouse).Append("\n");
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
            return this.Equals(input as AccountLocation);
        }

        /// <summary>
        /// Returns true if AccountLocation instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountLocation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountLocation input)
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
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && base.Equals(input) &&
                (
                    this.AddressSameAsMain == input.AddressSameAsMain ||
                    (this.AddressSameAsMain != null &&
                    this.AddressSameAsMain.Equals(input.AddressSameAsMain))
                ) && base.Equals(input) &&
                (
                    this.AddressValidated == input.AddressValidated ||
                    (this.AddressValidated != null &&
                    this.AddressValidated.Equals(input.AddressValidated))
                ) && base.Equals(input) &&
                (
                    this.ARAccount == input.ARAccount ||
                    (this.ARAccount != null &&
                    this.ARAccount.Equals(input.ARAccount))
                ) && base.Equals(input) &&
                (
                    this.ARSubaccount == input.ARSubaccount ||
                    (this.ARSubaccount != null &&
                    this.ARSubaccount.Equals(input.ARSubaccount))
                ) && base.Equals(input) &&
                (
                    this.BusinessAccountID == input.BusinessAccountID ||
                    (this.BusinessAccountID != null &&
                    this.BusinessAccountID.Equals(input.BusinessAccountID))
                ) && base.Equals(input) &&
                (
                    this.Calendar == input.Calendar ||
                    (this.Calendar != null &&
                    this.Calendar.Equals(input.Calendar))
                ) && base.Equals(input) &&
                (
                    this.Cases == input.Cases ||
                    this.Cases != null &&
                    this.Cases.SequenceEqual(input.Cases)
                ) && base.Equals(input) &&
                (
                    this.Contact == input.Contact ||
                    (this.Contact != null &&
                    this.Contact.Equals(input.Contact))
                ) && base.Equals(input) &&
                (
                    this.DefaultProject == input.DefaultProject ||
                    (this.DefaultProject != null &&
                    this.DefaultProject.Equals(input.DefaultProject))
                ) && base.Equals(input) &&
                (
                    this.DiscountAccount == input.DiscountAccount ||
                    (this.DiscountAccount != null &&
                    this.DiscountAccount.Equals(input.DiscountAccount))
                ) && base.Equals(input) &&
                (
                    this.DiscountSubaccount == input.DiscountSubaccount ||
                    (this.DiscountSubaccount != null &&
                    this.DiscountSubaccount.Equals(input.DiscountSubaccount))
                ) && base.Equals(input) &&
                (
                    this.EntityUsageType == input.EntityUsageType ||
                    (this.EntityUsageType != null &&
                    this.EntityUsageType.Equals(input.EntityUsageType))
                ) && base.Equals(input) &&
                (
                    this.FedExGroundCollect == input.FedExGroundCollect ||
                    (this.FedExGroundCollect != null &&
                    this.FedExGroundCollect.Equals(input.FedExGroundCollect))
                ) && base.Equals(input) &&
                (
                    this.FOBPoint == input.FOBPoint ||
                    (this.FOBPoint != null &&
                    this.FOBPoint.Equals(input.FOBPoint))
                ) && base.Equals(input) &&
                (
                    this.FreightAccount == input.FreightAccount ||
                    (this.FreightAccount != null &&
                    this.FreightAccount.Equals(input.FreightAccount))
                ) && base.Equals(input) &&
                (
                    this.FreightSubaccount == input.FreightSubaccount ||
                    (this.FreightSubaccount != null &&
                    this.FreightSubaccount.Equals(input.FreightSubaccount))
                ) && base.Equals(input) &&
                (
                    this.Insurance == input.Insurance ||
                    (this.Insurance != null &&
                    this.Insurance.Equals(input.Insurance))
                ) && base.Equals(input) &&
                (
                    this.LeadTimeInDays == input.LeadTimeInDays ||
                    (this.LeadTimeInDays != null &&
                    this.LeadTimeInDays.Equals(input.LeadTimeInDays))
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
                    this.Opportunities == input.Opportunities ||
                    this.Opportunities != null &&
                    this.Opportunities.SequenceEqual(input.Opportunities)
                ) && base.Equals(input) &&
                (
                    this.OrderPriority == input.OrderPriority ||
                    (this.OrderPriority != null &&
                    this.OrderPriority.Equals(input.OrderPriority))
                ) && base.Equals(input) &&
                (
                    this.PriceClass == input.PriceClass ||
                    (this.PriceClass != null &&
                    this.PriceClass.Equals(input.PriceClass))
                ) && base.Equals(input) &&
                (
                    this.ResidentialDelivery == input.ResidentialDelivery ||
                    (this.ResidentialDelivery != null &&
                    this.ResidentialDelivery.Equals(input.ResidentialDelivery))
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
                    this.SameAsDefaultLocation == input.SameAsDefaultLocation ||
                    (this.SameAsDefaultLocation != null &&
                    this.SameAsDefaultLocation.Equals(input.SameAsDefaultLocation))
                ) && base.Equals(input) &&
                (
                    this.SaturdayDelivery == input.SaturdayDelivery ||
                    (this.SaturdayDelivery != null &&
                    this.SaturdayDelivery.Equals(input.SaturdayDelivery))
                ) && base.Equals(input) &&
                (
                    this.ShippingBranch == input.ShippingBranch ||
                    (this.ShippingBranch != null &&
                    this.ShippingBranch.Equals(input.ShippingBranch))
                ) && base.Equals(input) &&
                (
                    this.ShippingRule == input.ShippingRule ||
                    (this.ShippingRule != null &&
                    this.ShippingRule.Equals(input.ShippingRule))
                ) && base.Equals(input) &&
                (
                    this.ShippingTerms == input.ShippingTerms ||
                    (this.ShippingTerms != null &&
                    this.ShippingTerms.Equals(input.ShippingTerms))
                ) && base.Equals(input) &&
                (
                    this.ShippingZone == input.ShippingZone ||
                    (this.ShippingZone != null &&
                    this.ShippingZone.Equals(input.ShippingZone))
                ) && base.Equals(input) &&
                (
                    this.ShipVia == input.ShipVia ||
                    (this.ShipVia != null &&
                    this.ShipVia.Equals(input.ShipVia))
                ) && base.Equals(input) &&
                (
                    this.TaxExemptionNumber == input.TaxExemptionNumber ||
                    (this.TaxExemptionNumber != null &&
                    this.TaxExemptionNumber.Equals(input.TaxExemptionNumber))
                ) && base.Equals(input) &&
                (
                    this.TaxRegistrationID == input.TaxRegistrationID ||
                    (this.TaxRegistrationID != null &&
                    this.TaxRegistrationID.Equals(input.TaxRegistrationID))
                ) && base.Equals(input) &&
                (
                    this.TaxZone == input.TaxZone ||
                    (this.TaxZone != null &&
                    this.TaxZone.Equals(input.TaxZone))
                ) && base.Equals(input) &&
                (
                    this.Warehouse == input.Warehouse ||
                    (this.Warehouse != null &&
                    this.Warehouse.Equals(input.Warehouse))
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
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.AddressSameAsMain != null)
                    hashCode = hashCode * 59 + this.AddressSameAsMain.GetHashCode();
                if (this.AddressValidated != null)
                    hashCode = hashCode * 59 + this.AddressValidated.GetHashCode();
                if (this.ARAccount != null)
                    hashCode = hashCode * 59 + this.ARAccount.GetHashCode();
                if (this.ARSubaccount != null)
                    hashCode = hashCode * 59 + this.ARSubaccount.GetHashCode();
                if (this.BusinessAccountID != null)
                    hashCode = hashCode * 59 + this.BusinessAccountID.GetHashCode();
                if (this.Calendar != null)
                    hashCode = hashCode * 59 + this.Calendar.GetHashCode();
                if (this.Cases != null)
                    hashCode = hashCode * 59 + this.Cases.GetHashCode();
                if (this.Contact != null)
                    hashCode = hashCode * 59 + this.Contact.GetHashCode();
                if (this.DefaultProject != null)
                    hashCode = hashCode * 59 + this.DefaultProject.GetHashCode();
                if (this.DiscountAccount != null)
                    hashCode = hashCode * 59 + this.DiscountAccount.GetHashCode();
                if (this.DiscountSubaccount != null)
                    hashCode = hashCode * 59 + this.DiscountSubaccount.GetHashCode();
                if (this.EntityUsageType != null)
                    hashCode = hashCode * 59 + this.EntityUsageType.GetHashCode();
                if (this.FedExGroundCollect != null)
                    hashCode = hashCode * 59 + this.FedExGroundCollect.GetHashCode();
                if (this.FOBPoint != null)
                    hashCode = hashCode * 59 + this.FOBPoint.GetHashCode();
                if (this.FreightAccount != null)
                    hashCode = hashCode * 59 + this.FreightAccount.GetHashCode();
                if (this.FreightSubaccount != null)
                    hashCode = hashCode * 59 + this.FreightSubaccount.GetHashCode();
                if (this.Insurance != null)
                    hashCode = hashCode * 59 + this.Insurance.GetHashCode();
                if (this.LeadTimeInDays != null)
                    hashCode = hashCode * 59 + this.LeadTimeInDays.GetHashCode();
                if (this.LocationID != null)
                    hashCode = hashCode * 59 + this.LocationID.GetHashCode();
                if (this.LocationName != null)
                    hashCode = hashCode * 59 + this.LocationName.GetHashCode();
                if (this.Opportunities != null)
                    hashCode = hashCode * 59 + this.Opportunities.GetHashCode();
                if (this.OrderPriority != null)
                    hashCode = hashCode * 59 + this.OrderPriority.GetHashCode();
                if (this.PriceClass != null)
                    hashCode = hashCode * 59 + this.PriceClass.GetHashCode();
                if (this.ResidentialDelivery != null)
                    hashCode = hashCode * 59 + this.ResidentialDelivery.GetHashCode();
                if (this.SalesAccount != null)
                    hashCode = hashCode * 59 + this.SalesAccount.GetHashCode();
                if (this.SalesSubaccount != null)
                    hashCode = hashCode * 59 + this.SalesSubaccount.GetHashCode();
                if (this.SameAsDefaultLocation != null)
                    hashCode = hashCode * 59 + this.SameAsDefaultLocation.GetHashCode();
                if (this.SaturdayDelivery != null)
                    hashCode = hashCode * 59 + this.SaturdayDelivery.GetHashCode();
                if (this.ShippingBranch != null)
                    hashCode = hashCode * 59 + this.ShippingBranch.GetHashCode();
                if (this.ShippingRule != null)
                    hashCode = hashCode * 59 + this.ShippingRule.GetHashCode();
                if (this.ShippingTerms != null)
                    hashCode = hashCode * 59 + this.ShippingTerms.GetHashCode();
                if (this.ShippingZone != null)
                    hashCode = hashCode * 59 + this.ShippingZone.GetHashCode();
                if (this.ShipVia != null)
                    hashCode = hashCode * 59 + this.ShipVia.GetHashCode();
                if (this.TaxExemptionNumber != null)
                    hashCode = hashCode * 59 + this.TaxExemptionNumber.GetHashCode();
                if (this.TaxRegistrationID != null)
                    hashCode = hashCode * 59 + this.TaxRegistrationID.GetHashCode();
                if (this.TaxZone != null)
                    hashCode = hashCode * 59 + this.TaxZone.GetHashCode();
                if (this.Warehouse != null)
                    hashCode = hashCode * 59 + this.Warehouse.GetHashCode();
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
