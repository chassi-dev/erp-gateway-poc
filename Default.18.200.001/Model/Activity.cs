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
    /// Activity
    /// </summary>
    [DataContract]
    public partial class Activity : Entity,  IEquatable<Activity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Activity" /> class.
        /// </summary>
        /// <param name="body">body.</param>
        /// <param name="date">date.</param>
        /// <param name="_internal">_internal.</param>
        /// <param name="noteID">noteID.</param>
        /// <param name="owner">owner.</param>
        /// <param name="relatedEntityDescription">relatedEntityDescription.</param>
        /// <param name="status">status.</param>
        /// <param name="summary">summary.</param>
        /// <param name="task">task.</param>
        /// <param name="timeActivity">timeActivity.</param>
        /// <param name="type">type.</param>
        /// <param name="workgroup">workgroup.</param>
        public Activity(StringValue body = default(StringValue), DateTimeValue date = default(DateTimeValue), BooleanValue _internal = default(BooleanValue), GuidValue noteID = default(GuidValue), StringValue owner = default(StringValue), StringValue relatedEntityDescription = default(StringValue), StringValue status = default(StringValue), StringValue summary = default(StringValue), StringValue task = default(StringValue), TimeActivity timeActivity = default(TimeActivity), StringValue type = default(StringValue), StringValue workgroup = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.Body = body;
            this.Date = date;
            this.Internal = _internal;
            this.NoteID = noteID;
            this.Owner = owner;
            this.RelatedEntityDescription = relatedEntityDescription;
            this.Status = status;
            this.Summary = summary;
            this.Task = task;
            this.TimeActivity = timeActivity;
            this.Type = type;
            this.Workgroup = workgroup;
        }

        /// <summary>
        /// Gets or Sets Body
        /// </summary>
        [DataMember(Name="Body", EmitDefaultValue=false)]
        public StringValue Body { get; set; }

        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name="Date", EmitDefaultValue=false)]
        public DateTimeValue Date { get; set; }

        /// <summary>
        /// Gets or Sets Internal
        /// </summary>
        [DataMember(Name="Internal", EmitDefaultValue=false)]
        public BooleanValue Internal { get; set; }

        /// <summary>
        /// Gets or Sets NoteID
        /// </summary>
        [DataMember(Name="NoteID", EmitDefaultValue=false)]
        public GuidValue NoteID { get; set; }

        /// <summary>
        /// Gets or Sets Owner
        /// </summary>
        [DataMember(Name="Owner", EmitDefaultValue=false)]
        public StringValue Owner { get; set; }

        /// <summary>
        /// Gets or Sets RelatedEntityDescription
        /// </summary>
        [DataMember(Name="RelatedEntityDescription", EmitDefaultValue=false)]
        public StringValue RelatedEntityDescription { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public StringValue Status { get; set; }

        /// <summary>
        /// Gets or Sets Summary
        /// </summary>
        [DataMember(Name="Summary", EmitDefaultValue=false)]
        public StringValue Summary { get; set; }

        /// <summary>
        /// Gets or Sets Task
        /// </summary>
        [DataMember(Name="Task", EmitDefaultValue=false)]
        public StringValue Task { get; set; }

        /// <summary>
        /// Gets or Sets TimeActivity
        /// </summary>
        [DataMember(Name="TimeActivity", EmitDefaultValue=false)]
        public TimeActivity TimeActivity { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="Type", EmitDefaultValue=false)]
        public StringValue Type { get; set; }

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
            sb.Append("class Activity {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Internal: ").Append(Internal).Append("\n");
            sb.Append("  NoteID: ").Append(NoteID).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  RelatedEntityDescription: ").Append(RelatedEntityDescription).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Summary: ").Append(Summary).Append("\n");
            sb.Append("  Task: ").Append(Task).Append("\n");
            sb.Append("  TimeActivity: ").Append(TimeActivity).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as Activity);
        }

        /// <summary>
        /// Returns true if Activity instances are equal
        /// </summary>
        /// <param name="input">Instance of Activity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Activity input)
        {
            if (input == null)
                return false;

            return base.Equals(input) &&
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
                ) && base.Equals(input) &&
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && base.Equals(input) &&
                (
                    this.Internal == input.Internal ||
                    (this.Internal != null &&
                    this.Internal.Equals(input.Internal))
                ) && base.Equals(input) &&
                (
                    this.NoteID == input.NoteID ||
                    (this.NoteID != null &&
                    this.NoteID.Equals(input.NoteID))
                ) && base.Equals(input) &&
                (
                    this.Owner == input.Owner ||
                    (this.Owner != null &&
                    this.Owner.Equals(input.Owner))
                ) && base.Equals(input) &&
                (
                    this.RelatedEntityDescription == input.RelatedEntityDescription ||
                    (this.RelatedEntityDescription != null &&
                    this.RelatedEntityDescription.Equals(input.RelatedEntityDescription))
                ) && base.Equals(input) &&
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && base.Equals(input) &&
                (
                    this.Summary == input.Summary ||
                    (this.Summary != null &&
                    this.Summary.Equals(input.Summary))
                ) && base.Equals(input) &&
                (
                    this.Task == input.Task ||
                    (this.Task != null &&
                    this.Task.Equals(input.Task))
                ) && base.Equals(input) &&
                (
                    this.TimeActivity == input.TimeActivity ||
                    (this.TimeActivity != null &&
                    this.TimeActivity.Equals(input.TimeActivity))
                ) && base.Equals(input) &&
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.Internal != null)
                    hashCode = hashCode * 59 + this.Internal.GetHashCode();
                if (this.NoteID != null)
                    hashCode = hashCode * 59 + this.NoteID.GetHashCode();
                if (this.Owner != null)
                    hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.RelatedEntityDescription != null)
                    hashCode = hashCode * 59 + this.RelatedEntityDescription.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Summary != null)
                    hashCode = hashCode * 59 + this.Summary.GetHashCode();
                if (this.Task != null)
                    hashCode = hashCode * 59 + this.Task.GetHashCode();
                if (this.TimeActivity != null)
                    hashCode = hashCode * 59 + this.TimeActivity.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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
