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
    /// PurchaseOrder
    /// </summary>
    [DataContract]
    public partial class PurchaseOrder : Entity,  IEquatable<PurchaseOrder>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PurchaseOrder" /> class.
        /// </summary>
        /// <param name="branch">branch.</param>
        /// <param name="controlTotal">controlTotal.</param>
        /// <param name="currencyID">currencyID.</param>
        /// <param name="date">date.</param>
        /// <param name="description">description.</param>
        /// <param name="details">details.</param>
        /// <param name="hold">hold.</param>
        /// <param name="lastModifiedDateTime">lastModifiedDateTime.</param>
        /// <param name="lineTotal">lineTotal.</param>
        /// <param name="location">location.</param>
        /// <param name="orderNbr">orderNbr.</param>
        /// <param name="orderTotal">orderTotal.</param>
        /// <param name="owner">owner.</param>
        /// <param name="project">project.</param>
        /// <param name="promisedOn">promisedOn.</param>
        /// <param name="shippingInstructions">shippingInstructions.</param>
        /// <param name="status">status.</param>
        /// <param name="taxDetails">taxDetails.</param>
        /// <param name="taxTotal">taxTotal.</param>
        /// <param name="terms">terms.</param>
        /// <param name="type">type.</param>
        /// <param name="vendorID">vendorID.</param>
        /// <param name="vendorRef">vendorRef.</param>
        /// <param name="vendorTaxZone">vendorTaxZone.</param>
        public PurchaseOrder(StringValue branch = default(StringValue), DecimalValue controlTotal = default(DecimalValue), StringValue currencyID = default(StringValue), DateTimeValue date = default(DateTimeValue), StringValue description = default(StringValue), List<PurchaseOrderDetail> details = default(List<PurchaseOrderDetail>), BooleanValue hold = default(BooleanValue), DateTimeValue lastModifiedDateTime = default(DateTimeValue), DecimalValue lineTotal = default(DecimalValue), StringValue location = default(StringValue), StringValue orderNbr = default(StringValue), DecimalValue orderTotal = default(DecimalValue), StringValue owner = default(StringValue), StringValue project = default(StringValue), DateTimeValue promisedOn = default(DateTimeValue), ShippingInstructions shippingInstructions = default(ShippingInstructions), StringValue status = default(StringValue), List<PurchaseOrderTaxDetail> taxDetails = default(List<PurchaseOrderTaxDetail>), DecimalValue taxTotal = default(DecimalValue), StringValue terms = default(StringValue), StringValue type = default(StringValue), StringValue vendorID = default(StringValue), StringValue vendorRef = default(StringValue), StringValue vendorTaxZone = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.Branch = branch;
            this.ControlTotal = controlTotal;
            this.CurrencyID = currencyID;
            this.Date = date;
            this.Description = description;
            this.Details = details;
            this.Hold = hold;
            this.LastModifiedDateTime = lastModifiedDateTime;
            this.LineTotal = lineTotal;
            this.Location = location;
            this.OrderNbr = orderNbr;
            this.OrderTotal = orderTotal;
            this.Owner = owner;
            this.Project = project;
            this.PromisedOn = promisedOn;
            this.ShippingInstructions = shippingInstructions;
            this.Status = status;
            this.TaxDetails = taxDetails;
            this.TaxTotal = taxTotal;
            this.Terms = terms;
            this.Type = type;
            this.VendorID = vendorID;
            this.VendorRef = vendorRef;
            this.VendorTaxZone = vendorTaxZone;
        }

        /// <summary>
        /// Gets or Sets Branch
        /// </summary>
        [DataMember(Name="Branch", EmitDefaultValue=false)]
        public StringValue Branch { get; set; }

        /// <summary>
        /// Gets or Sets ControlTotal
        /// </summary>
        [DataMember(Name="ControlTotal", EmitDefaultValue=false)]
        public DecimalValue ControlTotal { get; set; }

        /// <summary>
        /// Gets or Sets CurrencyID
        /// </summary>
        [DataMember(Name="CurrencyID", EmitDefaultValue=false)]
        public StringValue CurrencyID { get; set; }

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
        public List<PurchaseOrderDetail> Details { get; set; }

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
        /// Gets or Sets LineTotal
        /// </summary>
        [DataMember(Name="LineTotal", EmitDefaultValue=false)]
        public DecimalValue LineTotal { get; set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name="Location", EmitDefaultValue=false)]
        public StringValue Location { get; set; }

        /// <summary>
        /// Gets or Sets OrderNbr
        /// </summary>
        [DataMember(Name="OrderNbr", EmitDefaultValue=false)]
        public StringValue OrderNbr { get; set; }

        /// <summary>
        /// Gets or Sets OrderTotal
        /// </summary>
        [DataMember(Name="OrderTotal", EmitDefaultValue=false)]
        public DecimalValue OrderTotal { get; set; }

        /// <summary>
        /// Gets or Sets Owner
        /// </summary>
        [DataMember(Name="Owner", EmitDefaultValue=false)]
        public StringValue Owner { get; set; }

        /// <summary>
        /// Gets or Sets Project
        /// </summary>
        [DataMember(Name="Project", EmitDefaultValue=false)]
        public StringValue Project { get; set; }

        /// <summary>
        /// Gets or Sets PromisedOn
        /// </summary>
        [DataMember(Name="PromisedOn", EmitDefaultValue=false)]
        public DateTimeValue PromisedOn { get; set; }

        /// <summary>
        /// Gets or Sets ShippingInstructions
        /// </summary>
        [DataMember(Name="ShippingInstructions", EmitDefaultValue=false)]
        public ShippingInstructions ShippingInstructions { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public StringValue Status { get; set; }

        /// <summary>
        /// Gets or Sets TaxDetails
        /// </summary>
        [DataMember(Name="TaxDetails", EmitDefaultValue=false)]
        public List<PurchaseOrderTaxDetail> TaxDetails { get; set; }

        /// <summary>
        /// Gets or Sets TaxTotal
        /// </summary>
        [DataMember(Name="TaxTotal", EmitDefaultValue=false)]
        public DecimalValue TaxTotal { get; set; }

        /// <summary>
        /// Gets or Sets Terms
        /// </summary>
        [DataMember(Name="Terms", EmitDefaultValue=false)]
        public StringValue Terms { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="Type", EmitDefaultValue=false)]
        public StringValue Type { get; set; }

        /// <summary>
        /// Gets or Sets VendorID
        /// </summary>
        [DataMember(Name="VendorID", EmitDefaultValue=false)]
        public StringValue VendorID { get; set; }

        /// <summary>
        /// Gets or Sets VendorRef
        /// </summary>
        [DataMember(Name="VendorRef", EmitDefaultValue=false)]
        public StringValue VendorRef { get; set; }

        /// <summary>
        /// Gets or Sets VendorTaxZone
        /// </summary>
        [DataMember(Name="VendorTaxZone", EmitDefaultValue=false)]
        public StringValue VendorTaxZone { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PurchaseOrder {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Branch: ").Append(Branch).Append("\n");
            sb.Append("  ControlTotal: ").Append(ControlTotal).Append("\n");
            sb.Append("  CurrencyID: ").Append(CurrencyID).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  Hold: ").Append(Hold).Append("\n");
            sb.Append("  LastModifiedDateTime: ").Append(LastModifiedDateTime).Append("\n");
            sb.Append("  LineTotal: ").Append(LineTotal).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  OrderNbr: ").Append(OrderNbr).Append("\n");
            sb.Append("  OrderTotal: ").Append(OrderTotal).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  Project: ").Append(Project).Append("\n");
            sb.Append("  PromisedOn: ").Append(PromisedOn).Append("\n");
            sb.Append("  ShippingInstructions: ").Append(ShippingInstructions).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  TaxDetails: ").Append(TaxDetails).Append("\n");
            sb.Append("  TaxTotal: ").Append(TaxTotal).Append("\n");
            sb.Append("  Terms: ").Append(Terms).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  VendorID: ").Append(VendorID).Append("\n");
            sb.Append("  VendorRef: ").Append(VendorRef).Append("\n");
            sb.Append("  VendorTaxZone: ").Append(VendorTaxZone).Append("\n");
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
            return this.Equals(input as PurchaseOrder);
        }

        /// <summary>
        /// Returns true if PurchaseOrder instances are equal
        /// </summary>
        /// <param name="input">Instance of PurchaseOrder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PurchaseOrder input)
        {
            if (input == null)
                return false;

            return base.Equals(input) &&
                (
                    this.Branch == input.Branch ||
                    (this.Branch != null &&
                    this.Branch.Equals(input.Branch))
                ) && base.Equals(input) &&
                (
                    this.ControlTotal == input.ControlTotal ||
                    (this.ControlTotal != null &&
                    this.ControlTotal.Equals(input.ControlTotal))
                ) && base.Equals(input) &&
                (
                    this.CurrencyID == input.CurrencyID ||
                    (this.CurrencyID != null &&
                    this.CurrencyID.Equals(input.CurrencyID))
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
                    this.LineTotal == input.LineTotal ||
                    (this.LineTotal != null &&
                    this.LineTotal.Equals(input.LineTotal))
                ) && base.Equals(input) &&
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && base.Equals(input) &&
                (
                    this.OrderNbr == input.OrderNbr ||
                    (this.OrderNbr != null &&
                    this.OrderNbr.Equals(input.OrderNbr))
                ) && base.Equals(input) &&
                (
                    this.OrderTotal == input.OrderTotal ||
                    (this.OrderTotal != null &&
                    this.OrderTotal.Equals(input.OrderTotal))
                ) && base.Equals(input) &&
                (
                    this.Owner == input.Owner ||
                    (this.Owner != null &&
                    this.Owner.Equals(input.Owner))
                ) && base.Equals(input) &&
                (
                    this.Project == input.Project ||
                    (this.Project != null &&
                    this.Project.Equals(input.Project))
                ) && base.Equals(input) &&
                (
                    this.PromisedOn == input.PromisedOn ||
                    (this.PromisedOn != null &&
                    this.PromisedOn.Equals(input.PromisedOn))
                ) && base.Equals(input) &&
                (
                    this.ShippingInstructions == input.ShippingInstructions ||
                    (this.ShippingInstructions != null &&
                    this.ShippingInstructions.Equals(input.ShippingInstructions))
                ) && base.Equals(input) &&
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && base.Equals(input) &&
                (
                    this.TaxDetails == input.TaxDetails ||
                    this.TaxDetails != null &&
                    this.TaxDetails.SequenceEqual(input.TaxDetails)
                ) && base.Equals(input) &&
                (
                    this.TaxTotal == input.TaxTotal ||
                    (this.TaxTotal != null &&
                    this.TaxTotal.Equals(input.TaxTotal))
                ) && base.Equals(input) &&
                (
                    this.Terms == input.Terms ||
                    (this.Terms != null &&
                    this.Terms.Equals(input.Terms))
                ) && base.Equals(input) &&
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && base.Equals(input) &&
                (
                    this.VendorID == input.VendorID ||
                    (this.VendorID != null &&
                    this.VendorID.Equals(input.VendorID))
                ) && base.Equals(input) &&
                (
                    this.VendorRef == input.VendorRef ||
                    (this.VendorRef != null &&
                    this.VendorRef.Equals(input.VendorRef))
                ) && base.Equals(input) &&
                (
                    this.VendorTaxZone == input.VendorTaxZone ||
                    (this.VendorTaxZone != null &&
                    this.VendorTaxZone.Equals(input.VendorTaxZone))
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
                if (this.Branch != null)
                    hashCode = hashCode * 59 + this.Branch.GetHashCode();
                if (this.ControlTotal != null)
                    hashCode = hashCode * 59 + this.ControlTotal.GetHashCode();
                if (this.CurrencyID != null)
                    hashCode = hashCode * 59 + this.CurrencyID.GetHashCode();
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
                if (this.LineTotal != null)
                    hashCode = hashCode * 59 + this.LineTotal.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.OrderNbr != null)
                    hashCode = hashCode * 59 + this.OrderNbr.GetHashCode();
                if (this.OrderTotal != null)
                    hashCode = hashCode * 59 + this.OrderTotal.GetHashCode();
                if (this.Owner != null)
                    hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.Project != null)
                    hashCode = hashCode * 59 + this.Project.GetHashCode();
                if (this.PromisedOn != null)
                    hashCode = hashCode * 59 + this.PromisedOn.GetHashCode();
                if (this.ShippingInstructions != null)
                    hashCode = hashCode * 59 + this.ShippingInstructions.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.TaxDetails != null)
                    hashCode = hashCode * 59 + this.TaxDetails.GetHashCode();
                if (this.TaxTotal != null)
                    hashCode = hashCode * 59 + this.TaxTotal.GetHashCode();
                if (this.Terms != null)
                    hashCode = hashCode * 59 + this.Terms.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.VendorID != null)
                    hashCode = hashCode * 59 + this.VendorID.GetHashCode();
                if (this.VendorRef != null)
                    hashCode = hashCode * 59 + this.VendorRef.GetHashCode();
                if (this.VendorTaxZone != null)
                    hashCode = hashCode * 59 + this.VendorTaxZone.GetHashCode();
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
