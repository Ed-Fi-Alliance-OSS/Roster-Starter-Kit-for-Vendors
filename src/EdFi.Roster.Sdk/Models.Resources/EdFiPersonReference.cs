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
    /// EdFiPersonReference
    /// </summary>
    [DataContract(Name = "edFi_personReference")]
    public partial class EdFiPersonReference : IEquatable<EdFiPersonReference>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiPersonReference" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiPersonReference() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiPersonReference" /> class.
        /// </summary>
        /// <param name="personId">A unique alphanumeric code assigned to a person. (required).</param>
        /// <param name="sourceSystemDescriptor">This descriptor defines the originating record source system for the person. (required).</param>
        /// <param name="link">link.</param>
        public EdFiPersonReference(string personId = default(string), string sourceSystemDescriptor = default(string), Link link = default(Link))
        {
            // to ensure "personId" is required (not null)
            this.PersonId = personId ?? throw new ArgumentNullException("personId is a required property for EdFiPersonReference and cannot be null");
            // to ensure "sourceSystemDescriptor" is required (not null)
            this.SourceSystemDescriptor = sourceSystemDescriptor ?? throw new ArgumentNullException("sourceSystemDescriptor is a required property for EdFiPersonReference and cannot be null");
            this.Link = link;
        }

        /// <summary>
        /// A unique alphanumeric code assigned to a person.
        /// </summary>
        /// <value>A unique alphanumeric code assigned to a person.</value>
        [DataMember(Name = "personId", IsRequired = true, EmitDefaultValue = false)]
        public string PersonId { get; set; }

        /// <summary>
        /// This descriptor defines the originating record source system for the person.
        /// </summary>
        /// <value>This descriptor defines the originating record source system for the person.</value>
        [DataMember(Name = "sourceSystemDescriptor", IsRequired = true, EmitDefaultValue = false)]
        public string SourceSystemDescriptor { get; set; }

        /// <summary>
        /// Gets or Sets Link
        /// </summary>
        [DataMember(Name = "link", EmitDefaultValue = false)]
        public Link Link { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiPersonReference {\n");
            sb.Append("  PersonId: ").Append(PersonId).Append("\n");
            sb.Append("  SourceSystemDescriptor: ").Append(SourceSystemDescriptor).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
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
            return this.Equals(input as EdFiPersonReference);
        }

        /// <summary>
        /// Returns true if EdFiPersonReference instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiPersonReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiPersonReference input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PersonId == input.PersonId ||
                    (this.PersonId != null &&
                    this.PersonId.Equals(input.PersonId))
                ) && 
                (
                    this.SourceSystemDescriptor == input.SourceSystemDescriptor ||
                    (this.SourceSystemDescriptor != null &&
                    this.SourceSystemDescriptor.Equals(input.SourceSystemDescriptor))
                ) && 
                (
                    this.Link == input.Link ||
                    (this.Link != null &&
                    this.Link.Equals(input.Link))
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
                if (this.PersonId != null)
                    hashCode = hashCode * 59 + this.PersonId.GetHashCode();
                if (this.SourceSystemDescriptor != null)
                    hashCode = hashCode * 59 + this.SourceSystemDescriptor.GetHashCode();
                if (this.Link != null)
                    hashCode = hashCode * 59 + this.Link.GetHashCode();
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
            // PersonId (string) maxLength
            if(this.PersonId != null && this.PersonId.Length > 32)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PersonId, length must be less than 32.", new [] { "PersonId" });
            }

            // SourceSystemDescriptor (string) maxLength
            if(this.SourceSystemDescriptor != null && this.SourceSystemDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SourceSystemDescriptor, length must be less than 306.", new [] { "SourceSystemDescriptor" });
            }

            yield break;
        }
    }

}
