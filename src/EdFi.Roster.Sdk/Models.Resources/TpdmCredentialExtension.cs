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
    /// TpdmCredentialExtension
    /// </summary>
    [DataContract(Name = "tpdm_credentialExtension")]
    public partial class TpdmCredentialExtension : IEquatable<TpdmCredentialExtension>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmCredentialExtension" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TpdmCredentialExtension() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmCredentialExtension" /> class.
        /// </summary>
        /// <param name="certificationRouteDescriptor">The process, program, or pathway used to obtain certification..</param>
        /// <param name="credentialStatusDescriptor">The most recent status of the credential (e.g., active, suspended, etc.)..</param>
        /// <param name="boardCertificationIndicator">Indicator that the credential was granted under the authority of a national Board Certification..</param>
        /// <param name="certificationTitle">The title of the certification obtained by the educator. (required).</param>
        /// <param name="credentialStatusDate">The month, day, and year on which the credential status was effective..</param>
        /// <param name="certificationReference">certificationReference.</param>
        /// <param name="personReference">personReference (required).</param>
        /// <param name="studentAcademicRecords">An unordered collection of credentialStudentAcademicRecords. Reference to the person&#39;s Student Academic Records for the school(s) with which the Credential is associated..</param>
        public TpdmCredentialExtension(string certificationRouteDescriptor = default(string), string credentialStatusDescriptor = default(string), bool boardCertificationIndicator = default(bool), string certificationTitle = default(string), DateTime credentialStatusDate = default(DateTime), TpdmCertificationReference certificationReference = default(TpdmCertificationReference), EdFiPersonReference personReference = default(EdFiPersonReference), List<TpdmCredentialStudentAcademicRecord> studentAcademicRecords = default(List<TpdmCredentialStudentAcademicRecord>))
        {
            // to ensure "certificationTitle" is required (not null)
            this.CertificationTitle = certificationTitle ?? throw new ArgumentNullException("certificationTitle is a required property for TpdmCredentialExtension and cannot be null");
            // to ensure "personReference" is required (not null)
            this.PersonReference = personReference ?? throw new ArgumentNullException("personReference is a required property for TpdmCredentialExtension and cannot be null");
            this.CertificationRouteDescriptor = certificationRouteDescriptor;
            this.CredentialStatusDescriptor = credentialStatusDescriptor;
            this.BoardCertificationIndicator = boardCertificationIndicator;
            this.CredentialStatusDate = credentialStatusDate;
            this.CertificationReference = certificationReference;
            this.StudentAcademicRecords = studentAcademicRecords;
        }

        /// <summary>
        /// The process, program, or pathway used to obtain certification.
        /// </summary>
        /// <value>The process, program, or pathway used to obtain certification.</value>
        [DataMember(Name = "certificationRouteDescriptor", EmitDefaultValue = false)]
        public string CertificationRouteDescriptor { get; set; }

        /// <summary>
        /// The most recent status of the credential (e.g., active, suspended, etc.).
        /// </summary>
        /// <value>The most recent status of the credential (e.g., active, suspended, etc.).</value>
        [DataMember(Name = "credentialStatusDescriptor", EmitDefaultValue = false)]
        public string CredentialStatusDescriptor { get; set; }

        /// <summary>
        /// Indicator that the credential was granted under the authority of a national Board Certification.
        /// </summary>
        /// <value>Indicator that the credential was granted under the authority of a national Board Certification.</value>
        [DataMember(Name = "boardCertificationIndicator", EmitDefaultValue = true)]
        public bool BoardCertificationIndicator { get; set; }

        /// <summary>
        /// The title of the certification obtained by the educator.
        /// </summary>
        /// <value>The title of the certification obtained by the educator.</value>
        [DataMember(Name = "certificationTitle", IsRequired = true, EmitDefaultValue = false)]
        public string CertificationTitle { get; set; }

        /// <summary>
        /// The month, day, and year on which the credential status was effective.
        /// </summary>
        /// <value>The month, day, and year on which the credential status was effective.</value>
        [DataMember(Name = "credentialStatusDate", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime CredentialStatusDate { get; set; }

        /// <summary>
        /// Gets or Sets CertificationReference
        /// </summary>
        [DataMember(Name = "certificationReference", EmitDefaultValue = false)]
        public TpdmCertificationReference CertificationReference { get; set; }

        /// <summary>
        /// Gets or Sets PersonReference
        /// </summary>
        [DataMember(Name = "personReference", IsRequired = true, EmitDefaultValue = false)]
        public EdFiPersonReference PersonReference { get; set; }

        /// <summary>
        /// An unordered collection of credentialStudentAcademicRecords. Reference to the person&#39;s Student Academic Records for the school(s) with which the Credential is associated.
        /// </summary>
        /// <value>An unordered collection of credentialStudentAcademicRecords. Reference to the person&#39;s Student Academic Records for the school(s) with which the Credential is associated.</value>
        [DataMember(Name = "studentAcademicRecords", EmitDefaultValue = false)]
        public List<TpdmCredentialStudentAcademicRecord> StudentAcademicRecords { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TpdmCredentialExtension {\n");
            sb.Append("  CertificationRouteDescriptor: ").Append(CertificationRouteDescriptor).Append("\n");
            sb.Append("  CredentialStatusDescriptor: ").Append(CredentialStatusDescriptor).Append("\n");
            sb.Append("  BoardCertificationIndicator: ").Append(BoardCertificationIndicator).Append("\n");
            sb.Append("  CertificationTitle: ").Append(CertificationTitle).Append("\n");
            sb.Append("  CredentialStatusDate: ").Append(CredentialStatusDate).Append("\n");
            sb.Append("  CertificationReference: ").Append(CertificationReference).Append("\n");
            sb.Append("  PersonReference: ").Append(PersonReference).Append("\n");
            sb.Append("  StudentAcademicRecords: ").Append(StudentAcademicRecords).Append("\n");
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
            return this.Equals(input as TpdmCredentialExtension);
        }

        /// <summary>
        /// Returns true if TpdmCredentialExtension instances are equal
        /// </summary>
        /// <param name="input">Instance of TpdmCredentialExtension to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TpdmCredentialExtension input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CertificationRouteDescriptor == input.CertificationRouteDescriptor ||
                    (this.CertificationRouteDescriptor != null &&
                    this.CertificationRouteDescriptor.Equals(input.CertificationRouteDescriptor))
                ) && 
                (
                    this.CredentialStatusDescriptor == input.CredentialStatusDescriptor ||
                    (this.CredentialStatusDescriptor != null &&
                    this.CredentialStatusDescriptor.Equals(input.CredentialStatusDescriptor))
                ) && 
                (
                    this.BoardCertificationIndicator == input.BoardCertificationIndicator ||
                    this.BoardCertificationIndicator.Equals(input.BoardCertificationIndicator)
                ) && 
                (
                    this.CertificationTitle == input.CertificationTitle ||
                    (this.CertificationTitle != null &&
                    this.CertificationTitle.Equals(input.CertificationTitle))
                ) && 
                (
                    this.CredentialStatusDate == input.CredentialStatusDate ||
                    (this.CredentialStatusDate != null &&
                    this.CredentialStatusDate.Equals(input.CredentialStatusDate))
                ) && 
                (
                    this.CertificationReference == input.CertificationReference ||
                    (this.CertificationReference != null &&
                    this.CertificationReference.Equals(input.CertificationReference))
                ) && 
                (
                    this.PersonReference == input.PersonReference ||
                    (this.PersonReference != null &&
                    this.PersonReference.Equals(input.PersonReference))
                ) && 
                (
                    this.StudentAcademicRecords == input.StudentAcademicRecords ||
                    this.StudentAcademicRecords != null &&
                    input.StudentAcademicRecords != null &&
                    this.StudentAcademicRecords.SequenceEqual(input.StudentAcademicRecords)
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
                if (this.CertificationRouteDescriptor != null)
                    hashCode = hashCode * 59 + this.CertificationRouteDescriptor.GetHashCode();
                if (this.CredentialStatusDescriptor != null)
                    hashCode = hashCode * 59 + this.CredentialStatusDescriptor.GetHashCode();
                hashCode = hashCode * 59 + this.BoardCertificationIndicator.GetHashCode();
                if (this.CertificationTitle != null)
                    hashCode = hashCode * 59 + this.CertificationTitle.GetHashCode();
                if (this.CredentialStatusDate != null)
                    hashCode = hashCode * 59 + this.CredentialStatusDate.GetHashCode();
                if (this.CertificationReference != null)
                    hashCode = hashCode * 59 + this.CertificationReference.GetHashCode();
                if (this.PersonReference != null)
                    hashCode = hashCode * 59 + this.PersonReference.GetHashCode();
                if (this.StudentAcademicRecords != null)
                    hashCode = hashCode * 59 + this.StudentAcademicRecords.GetHashCode();
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
            // CertificationRouteDescriptor (string) maxLength
            if(this.CertificationRouteDescriptor != null && this.CertificationRouteDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CertificationRouteDescriptor, length must be less than 306.", new [] { "CertificationRouteDescriptor" });
            }

            // CredentialStatusDescriptor (string) maxLength
            if(this.CredentialStatusDescriptor != null && this.CredentialStatusDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CredentialStatusDescriptor, length must be less than 306.", new [] { "CredentialStatusDescriptor" });
            }

            // CertificationTitle (string) maxLength
            if(this.CertificationTitle != null && this.CertificationTitle.Length > 64)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CertificationTitle, length must be less than 64.", new [] { "CertificationTitle" });
            }

            yield break;
        }
    }

}
