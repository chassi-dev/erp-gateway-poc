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
    /// BusinessAccountCaseDetail
    /// </summary>
    [DataContract]
    public partial class BusinessAccountCaseDetail : Entity,  IEquatable<BusinessAccountCaseDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessAccountCaseDetail" /> class.
        /// </summary>
        /// <param name="caseID">caseID.</param>
        /// <param name="classID">classID.</param>
        /// <param name="closingDate">closingDate.</param>
        /// <param name="contract">contract.</param>
        /// <param name="dateReported">dateReported.</param>
        /// <param name="estimation">estimation.</param>
        /// <param name="initialResponse">initialResponse.</param>
        /// <param name="owner">owner.</param>
        /// <param name="reason">reason.</param>
        /// <param name="severity">severity.</param>
        /// <param name="status">status.</param>
        /// <param name="subject">subject.</param>
        /// <param name="workgroup">workgroup.</param>
        public BusinessAccountCaseDetail(StringValue caseID = default(StringValue), StringValue classID = default(StringValue), DateTimeValue closingDate = default(DateTimeValue), StringValue contract = default(StringValue), DateTimeValue dateReported = default(DateTimeValue), StringValue estimation = default(StringValue), StringValue initialResponse = default(StringValue), StringValue owner = default(StringValue), StringValue reason = default(StringValue), StringValue severity = default(StringValue), StringValue status = default(StringValue), StringValue subject = default(StringValue), StringValue workgroup = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.CaseID = caseID;
            this.ClassID = classID;
            this.ClosingDate = closingDate;
            this.Contract = contract;
            this.DateReported = dateReported;
            this.Estimation = estimation;
            this.InitialResponse = initialResponse;
            this.Owner = owner;
            this.Reason = reason;
            this.Severity = severity;
            this.Status = status;
            this.Subject = subject;
            this.Workgroup = workgroup;
        }

        /// <summary>
        /// Gets or Sets CaseID
        /// </summary>
        [DataMember(Name="CaseID", EmitDefaultValue=false)]
        public StringValue CaseID { get; set; }

        /// <summary>
        /// Gets or Sets ClassID
        /// </summary>
        [DataMember(Name="ClassID", EmitDefaultValue=false)]
        public StringValue ClassID { get; set; }

        /// <summary>
        /// Gets or Sets ClosingDate
        /// </summary>
        [DataMember(Name="ClosingDate", EmitDefaultValue=false)]
        public DateTimeValue ClosingDate { get; set; }

        /// <summary>
        /// Gets or Sets Contract
        /// </summary>
        [DataMember(Name="Contract", EmitDefaultValue=false)]
        public StringValue Contract { get; set; }

        /// <summary>
        /// Gets or Sets DateReported
        /// </summary>
        [DataMember(Name="DateReported", EmitDefaultValue=false)]
        public DateTimeValue DateReported { get; set; }

        /// <summary>
        /// Gets or Sets Estimation
        /// </summary>
        [DataMember(Name="Estimation", EmitDefaultValue=false)]
        public StringValue Estimation { get; set; }

        /// <summary>
        /// Gets or Sets InitialResponse
        /// </summary>
        [DataMember(Name="InitialResponse", EmitDefaultValue=false)]
        public StringValue InitialResponse { get; set; }

        /// <summary>
        /// Gets or Sets Owner
        /// </summary>
        [DataMember(Name="Owner", EmitDefaultValue=false)]
        public StringValue Owner { get; set; }

        /// <summary>
        /// Gets or Sets Reason
        /// </summary>
        [DataMember(Name="Reason", EmitDefaultValue=false)]
        public StringValue Reason { get; set; }

        /// <summary>
        /// Gets or Sets Severity
        /// </summary>
        [DataMember(Name="Severity", EmitDefaultValue=false)]
        public StringValue Severity { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public StringValue Status { get; set; }

        /// <summary>
        /// Gets or Sets Subject
        /// </summary>
        [DataMember(Name="Subject", EmitDefaultValue=false)]
        public StringValue Subject { get; set; }

        /// <summary>
        /// Gets or Sets Workgroup
        /// </summary>
        [DataMember(Name="Workgroup", EmitDefaultValue=false)]
        public StringValue Workgroup { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BusinessAccountCaseDetail {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  CaseID: ").Append(CaseID).Append("\n");
            sb.Append("  ClassID: ").Append(ClassID).Append("\n");
            sb.Append("  ClosingDate: ").Append(ClosingDate).Append("\n");
            sb.Append("  Contract: ").Append(Contract).Append("\n");
            sb.Append("  DateReported: ").Append(DateReported).Append("\n");
            sb.Append("  Estimation: ").Append(Estimation).Append("\n");
            sb.Append("  InitialResponse: ").Append(InitialResponse).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  Severity: ").Append(Severity).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  Workgroup: ").Append(Workgroup).Append("\n");
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
            return this.Equals(input as BusinessAccountCaseDetail);
        }

        /// <summary>
        /// Returns true if BusinessAccountCaseDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of BusinessAccountCaseDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BusinessAccountCaseDetail input)
        {
            if (input == null)
                return false;

            return base.Equals(input) &&
                (
                    this.CaseID == input.CaseID ||
                    (this.CaseID != null &&
                    this.CaseID.Equals(input.CaseID))
                ) && base.Equals(input) &&
                (
                    this.ClassID == input.ClassID ||
                    (this.ClassID != null &&
                    this.ClassID.Equals(input.ClassID))
                ) && base.Equals(input) &&
                (
                    this.ClosingDate == input.ClosingDate ||
                    (this.ClosingDate != null &&
                    this.ClosingDate.Equals(input.ClosingDate))
                ) && base.Equals(input) &&
                (
                    this.Contract == input.Contract ||
                    (this.Contract != null &&
                    this.Contract.Equals(input.Contract))
                ) && base.Equals(input) &&
                (
                    this.DateReported == input.DateReported ||
                    (this.DateReported != null &&
                    this.DateReported.Equals(input.DateReported))
                ) && base.Equals(input) &&
                (
                    this.Estimation == input.Estimation ||
                    (this.Estimation != null &&
                    this.Estimation.Equals(input.Estimation))
                ) && base.Equals(input) &&
                (
                    this.InitialResponse == input.InitialResponse ||
                    (this.InitialResponse != null &&
                    this.InitialResponse.Equals(input.InitialResponse))
                ) && base.Equals(input) &&
                (
                    this.Owner == input.Owner ||
                    (this.Owner != null &&
                    this.Owner.Equals(input.Owner))
                ) && base.Equals(input) &&
                (
                    this.Reason == input.Reason ||
                    (this.Reason != null &&
                    this.Reason.Equals(input.Reason))
                ) && base.Equals(input) &&
                (
                    this.Severity == input.Severity ||
                    (this.Severity != null &&
                    this.Severity.Equals(input.Severity))
                ) && base.Equals(input) &&
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && base.Equals(input) &&
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && base.Equals(input) &&
                (
                    this.Workgroup == input.Workgroup ||
                    (this.Workgroup != null &&
                    this.Workgroup.Equals(input.Workgroup))
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
                if (this.CaseID != null)
                    hashCode = hashCode * 59 + this.CaseID.GetHashCode();
                if (this.ClassID != null)
                    hashCode = hashCode * 59 + this.ClassID.GetHashCode();
                if (this.ClosingDate != null)
                    hashCode = hashCode * 59 + this.ClosingDate.GetHashCode();
                if (this.Contract != null)
                    hashCode = hashCode * 59 + this.Contract.GetHashCode();
                if (this.DateReported != null)
                    hashCode = hashCode * 59 + this.DateReported.GetHashCode();
                if (this.Estimation != null)
                    hashCode = hashCode * 59 + this.Estimation.GetHashCode();
                if (this.InitialResponse != null)
                    hashCode = hashCode * 59 + this.InitialResponse.GetHashCode();
                if (this.Owner != null)
                    hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.Reason != null)
                    hashCode = hashCode * 59 + this.Reason.GetHashCode();
                if (this.Severity != null)
                    hashCode = hashCode * 59 + this.Severity.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.Workgroup != null)
                    hashCode = hashCode * 59 + this.Workgroup.GetHashCode();
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
