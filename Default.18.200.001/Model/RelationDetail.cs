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
    /// RelationDetail
    /// </summary>
    [DataContract]
    public partial class RelationDetail : Entity,  IEquatable<RelationDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RelationDetail" /> class.
        /// </summary>
        /// <param name="account">account.</param>
        /// <param name="addToCc">addToCc.</param>
        /// <param name="contactDisplayName">contactDisplayName.</param>
        /// <param name="contactID">contactID.</param>
        /// <param name="document">document.</param>
        /// <param name="documentTargetNoteIDDescription">documentTargetNoteIDDescription.</param>
        /// <param name="email">email.</param>
        /// <param name="name">name.</param>
        /// <param name="primary">primary.</param>
        /// <param name="relationID">relationID.</param>
        /// <param name="role">role.</param>
        /// <param name="type">type.</param>
        public RelationDetail(StringValue account = default(StringValue), BooleanValue addToCc = default(BooleanValue), StringValue contactDisplayName = default(StringValue), IntValue contactID = default(IntValue), GuidValue document = default(GuidValue), StringValue documentTargetNoteIDDescription = default(StringValue), StringValue email = default(StringValue), StringValue name = default(StringValue), BooleanValue primary = default(BooleanValue), IntValue relationID = default(IntValue), StringValue role = default(StringValue), StringValue type = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.Account = account;
            this.AddToCc = addToCc;
            this.ContactDisplayName = contactDisplayName;
            this.ContactID = contactID;
            this.Document = document;
            this.DocumentTargetNoteIDDescription = documentTargetNoteIDDescription;
            this.Email = email;
            this.Name = name;
            this.Primary = primary;
            this.RelationID = relationID;
            this.Role = role;
            this.Type = type;
        }

        /// <summary>
        /// Gets or Sets Account
        /// </summary>
        [DataMember(Name="Account", EmitDefaultValue=false)]
        public StringValue Account { get; set; }

        /// <summary>
        /// Gets or Sets AddToCc
        /// </summary>
        [DataMember(Name="AddToCc", EmitDefaultValue=false)]
        public BooleanValue AddToCc { get; set; }

        /// <summary>
        /// Gets or Sets ContactDisplayName
        /// </summary>
        [DataMember(Name="ContactDisplayName", EmitDefaultValue=false)]
        public StringValue ContactDisplayName { get; set; }

        /// <summary>
        /// Gets or Sets ContactID
        /// </summary>
        [DataMember(Name="ContactID", EmitDefaultValue=false)]
        public IntValue ContactID { get; set; }

        /// <summary>
        /// Gets or Sets Document
        /// </summary>
        [DataMember(Name="Document", EmitDefaultValue=false)]
        public GuidValue Document { get; set; }

        /// <summary>
        /// Gets or Sets DocumentTargetNoteIDDescription
        /// </summary>
        [DataMember(Name="DocumentTargetNoteIDDescription", EmitDefaultValue=false)]
        public StringValue DocumentTargetNoteIDDescription { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="Email", EmitDefaultValue=false)]
        public StringValue Email { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public StringValue Name { get; set; }

        /// <summary>
        /// Gets or Sets Primary
        /// </summary>
        [DataMember(Name="Primary", EmitDefaultValue=false)]
        public BooleanValue Primary { get; set; }

        /// <summary>
        /// Gets or Sets RelationID
        /// </summary>
        [DataMember(Name="RelationID", EmitDefaultValue=false)]
        public IntValue RelationID { get; set; }

        /// <summary>
        /// Gets or Sets Role
        /// </summary>
        [DataMember(Name="Role", EmitDefaultValue=false)]
        public StringValue Role { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="Type", EmitDefaultValue=false)]
        public StringValue Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RelationDetail {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  AddToCc: ").Append(AddToCc).Append("\n");
            sb.Append("  ContactDisplayName: ").Append(ContactDisplayName).Append("\n");
            sb.Append("  ContactID: ").Append(ContactID).Append("\n");
            sb.Append("  Document: ").Append(Document).Append("\n");
            sb.Append("  DocumentTargetNoteIDDescription: ").Append(DocumentTargetNoteIDDescription).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Primary: ").Append(Primary).Append("\n");
            sb.Append("  RelationID: ").Append(RelationID).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
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
            return this.Equals(input as RelationDetail);
        }

        /// <summary>
        /// Returns true if RelationDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of RelationDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RelationDetail input)
        {
            if (input == null)
                return false;

            return base.Equals(input) &&
                (
                    this.Account == input.Account ||
                    (this.Account != null &&
                    this.Account.Equals(input.Account))
                ) && base.Equals(input) &&
                (
                    this.AddToCc == input.AddToCc ||
                    (this.AddToCc != null &&
                    this.AddToCc.Equals(input.AddToCc))
                ) && base.Equals(input) &&
                (
                    this.ContactDisplayName == input.ContactDisplayName ||
                    (this.ContactDisplayName != null &&
                    this.ContactDisplayName.Equals(input.ContactDisplayName))
                ) && base.Equals(input) &&
                (
                    this.ContactID == input.ContactID ||
                    (this.ContactID != null &&
                    this.ContactID.Equals(input.ContactID))
                ) && base.Equals(input) &&
                (
                    this.Document == input.Document ||
                    (this.Document != null &&
                    this.Document.Equals(input.Document))
                ) && base.Equals(input) &&
                (
                    this.DocumentTargetNoteIDDescription == input.DocumentTargetNoteIDDescription ||
                    (this.DocumentTargetNoteIDDescription != null &&
                    this.DocumentTargetNoteIDDescription.Equals(input.DocumentTargetNoteIDDescription))
                ) && base.Equals(input) &&
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && base.Equals(input) &&
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && base.Equals(input) &&
                (
                    this.Primary == input.Primary ||
                    (this.Primary != null &&
                    this.Primary.Equals(input.Primary))
                ) && base.Equals(input) &&
                (
                    this.RelationID == input.RelationID ||
                    (this.RelationID != null &&
                    this.RelationID.Equals(input.RelationID))
                ) && base.Equals(input) &&
                (
                    this.Role == input.Role ||
                    (this.Role != null &&
                    this.Role.Equals(input.Role))
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
                if (this.Account != null)
                    hashCode = hashCode * 59 + this.Account.GetHashCode();
                if (this.AddToCc != null)
                    hashCode = hashCode * 59 + this.AddToCc.GetHashCode();
                if (this.ContactDisplayName != null)
                    hashCode = hashCode * 59 + this.ContactDisplayName.GetHashCode();
                if (this.ContactID != null)
                    hashCode = hashCode * 59 + this.ContactID.GetHashCode();
                if (this.Document != null)
                    hashCode = hashCode * 59 + this.Document.GetHashCode();
                if (this.DocumentTargetNoteIDDescription != null)
                    hashCode = hashCode * 59 + this.DocumentTargetNoteIDDescription.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Primary != null)
                    hashCode = hashCode * 59 + this.Primary.GetHashCode();
                if (this.RelationID != null)
                    hashCode = hashCode * 59 + this.RelationID.GetHashCode();
                if (this.Role != null)
                    hashCode = hashCode * 59 + this.Role.GetHashCode();
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
