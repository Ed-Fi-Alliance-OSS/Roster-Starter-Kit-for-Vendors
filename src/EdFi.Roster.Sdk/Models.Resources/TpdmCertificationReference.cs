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
    /// TpdmCertificationReference
    /// </summary>
    [DataContract(Name = "tpdm_certificationReference")]
    public partial class TpdmCertificationReference : IEquatable<TpdmCertificationReference>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmCertificationReference" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TpdmCertificationReference() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmCertificationReference" /> class.
        /// </summary>
        /// <param name="certificationIdentifier">Identifier or serial number assigned to the Certification. (required).</param>
        /// <param name="_namespace">Namespace for the Certification, typically associated with the issuing authority. (required).</param>
        /// <param name="link">link.</param>
        public TpdmCertificationReference(string certificationIdentifier = default(string), string _namespace = default(string), Link link = default(Link))
        {
            // to ensure "certificationIdentifier" is required (not null)
            this.CertificationIdentifier = certificationIdentifier ?? throw new ArgumentNullException("certificationIdentifier is a required property for TpdmCertificationReference and cannot be null");
            // to ensure "_namespace" is required (not null)
            this.Namespace = _namespace ?? throw new ArgumentNullException("_namespace is a required property for TpdmCertificationReference and cannot be null");
            this.Link = link;
        }

        /// <summary>
        /// Identifier or serial number assigned to the Certification.
        /// </summary>
        /// <value>Identifier or serial number assigned to the Certification.</value>
        [DataMember(Name = "certificationIdentifier", IsRequired = true, EmitDefaultValue = false)]
        public string CertificationIdentifier { get; set; }

        /// <summary>
        /// Namespace for the Certification, typically associated with the issuing authority.
        /// </summary>
        /// <value>Namespace for the Certification, typically associated with the issuing authority.</value>
        [DataMember(Name = "namespace", IsRequired = true, EmitDefaultValue = false)]
        public string Namespace { get; set; }

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
            sb.Append("class TpdmCertificationReference {\n");
            sb.Append("  CertificationIdentifier: ").Append(CertificationIdentifier).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
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
            return this.Equals(input as TpdmCertificationReference);
        }

        /// <summary>
        /// Returns true if TpdmCertificationReference instances are equal
        /// </summary>
        /// <param name="input">Instance of TpdmCertificationReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TpdmCertificationReference input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CertificationIdentifier == input.CertificationIdentifier ||
                    (this.CertificationIdentifier != null &&
                    this.CertificationIdentifier.Equals(input.CertificationIdentifier))
                ) && 
                (
                    this.Namespace == input.Namespace ||
                    (this.Namespace != null &&
                    this.Namespace.Equals(input.Namespace))
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
                if (this.CertificationIdentifier != null)
                    hashCode = hashCode * 59 + this.CertificationIdentifier.GetHashCode();
                if (this.Namespace != null)
                    hashCode = hashCode * 59 + this.Namespace.GetHashCode();
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
            // CertificationIdentifier (string) maxLength
            if(this.CertificationIdentifier != null && this.CertificationIdentifier.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CertificationIdentifier, length must be less than 60.", new [] { "CertificationIdentifier" });
            }

            // Namespace (string) maxLength
            if(this.Namespace != null && this.Namespace.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Namespace, length must be less than 255.", new [] { "Namespace" });
            }

            yield break;
        }
    }

}
