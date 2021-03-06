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
    /// EventAttendee
    /// </summary>
    [DataContract]
    public partial class EventAttendee : Entity,  IEquatable<EventAttendee>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventAttendee" /> class.
        /// </summary>
        /// <param name="comment">comment.</param>
        /// <param name="email">email.</param>
        /// <param name="eventNoteID">eventNoteID.</param>
        /// <param name="invitationStatus">invitationStatus.</param>
        /// <param name="key">key.</param>
        /// <param name="name">name.</param>
        /// <param name="nameAttendeeName">nameAttendeeName.</param>
        /// <param name="type">type.</param>
        public EventAttendee(StringValue comment = default(StringValue), StringValue email = default(StringValue), GuidValue eventNoteID = default(GuidValue), StringValue invitationStatus = default(StringValue), StringValue key = default(StringValue), StringValue name = default(StringValue), StringValue nameAttendeeName = default(StringValue), IntValue type = default(IntValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.Comment = comment;
            this.Email = email;
            this.EventNoteID = eventNoteID;
            this.InvitationStatus = invitationStatus;
            this.Key = key;
            this.Name = name;
            this.NameAttendeeName = nameAttendeeName;
            this.Type = type;
        }

        /// <summary>
        /// Gets or Sets Comment
        /// </summary>
        [DataMember(Name="Comment", EmitDefaultValue=false)]
        public StringValue Comment { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="Email", EmitDefaultValue=false)]
        public StringValue Email { get; set; }

        /// <summary>
        /// Gets or Sets EventNoteID
        /// </summary>
        [DataMember(Name="EventNoteID", EmitDefaultValue=false)]
        public GuidValue EventNoteID { get; set; }

        /// <summary>
        /// Gets or Sets InvitationStatus
        /// </summary>
        [DataMember(Name="InvitationStatus", EmitDefaultValue=false)]
        public StringValue InvitationStatus { get; set; }

        /// <summary>
        /// Gets or Sets Key
        /// </summary>
        [DataMember(Name="Key", EmitDefaultValue=false)]
        public StringValue Key { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public StringValue Name { get; set; }

        /// <summary>
        /// Gets or Sets NameAttendeeName
        /// </summary>
        [DataMember(Name="NameAttendeeName", EmitDefaultValue=false)]
        public StringValue NameAttendeeName { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="Type", EmitDefaultValue=false)]
        public IntValue Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EventAttendee {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  EventNoteID: ").Append(EventNoteID).Append("\n");
            sb.Append("  InvitationStatus: ").Append(InvitationStatus).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NameAttendeeName: ").Append(NameAttendeeName).Append("\n");
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
            return this.Equals(input as EventAttendee);
        }

        /// <summary>
        /// Returns true if EventAttendee instances are equal
        /// </summary>
        /// <param name="input">Instance of EventAttendee to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EventAttendee input)
        {
            if (input == null)
                return false;

            return base.Equals(input) &&
                (
                    this.Comment == input.Comment ||
                    (this.Comment != null &&
                    this.Comment.Equals(input.Comment))
                ) && base.Equals(input) &&
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && base.Equals(input) &&
                (
                    this.EventNoteID == input.EventNoteID ||
                    (this.EventNoteID != null &&
                    this.EventNoteID.Equals(input.EventNoteID))
                ) && base.Equals(input) &&
                (
                    this.InvitationStatus == input.InvitationStatus ||
                    (this.InvitationStatus != null &&
                    this.InvitationStatus.Equals(input.InvitationStatus))
                ) && base.Equals(input) &&
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && base.Equals(input) &&
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && base.Equals(input) &&
                (
                    this.NameAttendeeName == input.NameAttendeeName ||
                    (this.NameAttendeeName != null &&
                    this.NameAttendeeName.Equals(input.NameAttendeeName))
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
                if (this.Comment != null)
                    hashCode = hashCode * 59 + this.Comment.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.EventNoteID != null)
                    hashCode = hashCode * 59 + this.EventNoteID.GetHashCode();
                if (this.InvitationStatus != null)
                    hashCode = hashCode * 59 + this.InvitationStatus.GetHashCode();
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NameAttendeeName != null)
                    hashCode = hashCode * 59 + this.NameAttendeeName.GetHashCode();
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
