/*
 * Ed-Fi Operational Data Store API
 *
 * The Ed-Fi ODS / API enables applications to read and write education data stored in an Ed-Fi ODS through a secure REST interface.  ***  > *Note: Consumers of ODS / API information should sanitize all data for display and storage. The ODS / API provides reasonable safeguards against cross-site scripting attacks and other malicious content, but the platform does not and cannot guarantee that the data it contains is free of all potentially harmful content.*  *** 
 *
 * The version of the OpenAPI document: 3
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = EdFi.Roster.Sdk.Client.OpenAPIDateConverter;

namespace EdFi.Roster.Sdk.Models.Resources
{
    /// <summary>
    /// TpdmCredentialEvent
    /// </summary>
    [DataContract(Name = "tpdm_credentialEvent")]
    public partial class TpdmCredentialEvent : IEquatable<TpdmCredentialEvent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmCredentialEvent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TpdmCredentialEvent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmCredentialEvent" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="credentialEventDate">The year, month and day of the Credential Event. (required).</param>
        /// <param name="credentialEventTypeDescriptor">The type of event associated with a person&#39;s Credential (e.g, suspension, revocation, or renewal). (required).</param>
        /// <param name="credentialReference">credentialReference (required).</param>
        /// <param name="credentialEventReason">The reason for the credential event, or any other descriptive text..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        public TpdmCredentialEvent(string id = default(string), DateTime credentialEventDate = default(DateTime), string credentialEventTypeDescriptor = default(string), EdFiCredentialReference credentialReference = default(EdFiCredentialReference), string credentialEventReason = default(string), string etag = default(string))
        {
            this.CredentialEventDate = credentialEventDate;
            // to ensure "credentialEventTypeDescriptor" is required (not null)
            this.CredentialEventTypeDescriptor = credentialEventTypeDescriptor ?? throw new ArgumentNullException("credentialEventTypeDescriptor is a required property for TpdmCredentialEvent and cannot be null");
            // to ensure "credentialReference" is required (not null)
            this.CredentialReference = credentialReference ?? throw new ArgumentNullException("credentialReference is a required property for TpdmCredentialEvent and cannot be null");
            this.Id = id;
            this.CredentialEventReason = credentialEventReason;
            this.Etag = etag;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The year, month and day of the Credential Event.
        /// </summary>
        /// <value>The year, month and day of the Credential Event.</value>
        [DataMember(Name = "credentialEventDate", IsRequired = true, EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime CredentialEventDate { get; set; }

        /// <summary>
        /// The type of event associated with a person&#39;s Credential (e.g, suspension, revocation, or renewal).
        /// </summary>
        /// <value>The type of event associated with a person&#39;s Credential (e.g, suspension, revocation, or renewal).</value>
        [DataMember(Name = "credentialEventTypeDescriptor", IsRequired = true, EmitDefaultValue = false)]
        public string CredentialEventTypeDescriptor { get; set; }

        /// <summary>
        /// Gets or Sets CredentialReference
        /// </summary>
        [DataMember(Name = "credentialReference", IsRequired = true, EmitDefaultValue = false)]
        public EdFiCredentialReference CredentialReference { get; set; }

        /// <summary>
        /// The reason for the credential event, or any other descriptive text.
        /// </summary>
        /// <value>The reason for the credential event, or any other descriptive text.</value>
        [DataMember(Name = "credentialEventReason", EmitDefaultValue = false)]
        public string CredentialEventReason { get; set; }

        /// <summary>
        /// A unique system-generated value that identifies the version of the resource.
        /// </summary>
        /// <value>A unique system-generated value that identifies the version of the resource.</value>
        [DataMember(Name = "_etag", EmitDefaultValue = false)]
        public string Etag { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TpdmCredentialEvent {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CredentialEventDate: ").Append(CredentialEventDate).Append("\n");
            sb.Append("  CredentialEventTypeDescriptor: ").Append(CredentialEventTypeDescriptor).Append("\n");
            sb.Append("  CredentialReference: ").Append(CredentialReference).Append("\n");
            sb.Append("  CredentialEventReason: ").Append(CredentialEventReason).Append("\n");
            sb.Append("  Etag: ").Append(Etag).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as TpdmCredentialEvent);
        }

        /// <summary>
        /// Returns true if TpdmCredentialEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of TpdmCredentialEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TpdmCredentialEvent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.CredentialEventDate == input.CredentialEventDate ||
                    (this.CredentialEventDate != null &&
                    this.CredentialEventDate.Equals(input.CredentialEventDate))
                ) && 
                (
                    this.CredentialEventTypeDescriptor == input.CredentialEventTypeDescriptor ||
                    (this.CredentialEventTypeDescriptor != null &&
                    this.CredentialEventTypeDescriptor.Equals(input.CredentialEventTypeDescriptor))
                ) && 
                (
                    this.CredentialReference == input.CredentialReference ||
                    (this.CredentialReference != null &&
                    this.CredentialReference.Equals(input.CredentialReference))
                ) && 
                (
                    this.CredentialEventReason == input.CredentialEventReason ||
                    (this.CredentialEventReason != null &&
                    this.CredentialEventReason.Equals(input.CredentialEventReason))
                ) && 
                (
                    this.Etag == input.Etag ||
                    (this.Etag != null &&
                    this.Etag.Equals(input.Etag))
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
                int hashCode = 41;
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.CredentialEventDate != null)
                    hashCode = hashCode * 59 + this.CredentialEventDate.GetHashCode();
                if (this.CredentialEventTypeDescriptor != null)
                    hashCode = hashCode * 59 + this.CredentialEventTypeDescriptor.GetHashCode();
                if (this.CredentialReference != null)
                    hashCode = hashCode * 59 + this.CredentialReference.GetHashCode();
                if (this.CredentialEventReason != null)
                    hashCode = hashCode * 59 + this.CredentialEventReason.GetHashCode();
                if (this.Etag != null)
                    hashCode = hashCode * 59 + this.Etag.GetHashCode();
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
            // CredentialEventTypeDescriptor (string) maxLength
            if(this.CredentialEventTypeDescriptor != null && this.CredentialEventTypeDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CredentialEventTypeDescriptor, length must be less than 306.", new [] { "CredentialEventTypeDescriptor" });
            }

            // CredentialEventReason (string) maxLength
            if(this.CredentialEventReason != null && this.CredentialEventReason.Length > 1024)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CredentialEventReason, length must be less than 1024.", new [] { "CredentialEventReason" });
            }

            yield break;
        }
    }

}
