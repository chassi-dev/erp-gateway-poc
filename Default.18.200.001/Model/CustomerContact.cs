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
    /// CustomerContact
    /// </summary>
    [DataContract]
    public partial class CustomerContact : Entity,  IEquatable<CustomerContact>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerContact" /> class.
        /// </summary>
        /// <param name="contact">contact.</param>
        /// <param name="contactID">contactID.</param>
        public CustomerContact(Contact contact = default(Contact), IntValue contactID = default(IntValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.Contact = contact;
            this.ContactID = contactID;
        }

        /// <summary>
        /// Gets or Sets Contact
        /// </summary>
        [DataMember(Name="Contact", EmitDefaultValue=false)]
        public Contact Contact { get; set; }

        /// <summary>
        /// Gets or Sets ContactID
        /// </summary>
        [DataMember(Name="ContactID", EmitDefaultValue=false)]
        public IntValue ContactID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomerContact {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Contact: ").Append(Contact).Append("\n");
            sb.Append("  ContactID: ").Append(ContactID).Append("\n");
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
            return this.Equals(input as CustomerContact);
        }

        /// <summary>
        /// Returns true if CustomerContact instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomerContact to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomerContact input)
        {
            if (input == null)
                return false;

            return base.Equals(input) &&
                (
                    this.Contact == input.Contact ||
                    (this.Contact != null &&
                    this.Contact.Equals(input.Contact))
                ) && base.Equals(input) &&
                (
                    this.ContactID == input.ContactID ||
                    (this.ContactID != null &&
                    this.ContactID.Equals(input.ContactID))
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
                if (this.Contact != null)
                    hashCode = hashCode * 59 + this.Contact.GetHashCode();
                if (this.ContactID != null)
                    hashCode = hashCode * 59 + this.ContactID.GetHashCode();
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
