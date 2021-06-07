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
    /// TpdmGraduationPlanRequiredCertification
    /// </summary>
    [DataContract(Name = "tpdm_graduationPlanRequiredCertification")]
    public partial class TpdmGraduationPlanRequiredCertification : IEquatable<TpdmGraduationPlanRequiredCertification>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmGraduationPlanRequiredCertification" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TpdmGraduationPlanRequiredCertification() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmGraduationPlanRequiredCertification" /> class.
        /// </summary>
        /// <param name="certificationTitle">The title of the Certification required for Graduation. (required).</param>
        /// <param name="certificationRouteDescriptor">The process, program ,or pathway used to obtain certification..</param>
        /// <param name="certificationReference">certificationReference.</param>
        public TpdmGraduationPlanRequiredCertification(string certificationTitle = default(string), string certificationRouteDescriptor = default(string), TpdmCertificationReference certificationReference = default(TpdmCertificationReference))
        {
            // to ensure "certificationTitle" is required (not null)
            this.CertificationTitle = certificationTitle ?? throw new ArgumentNullException("certificationTitle is a required property for TpdmGraduationPlanRequiredCertification and cannot be null");
            this.CertificationRouteDescriptor = certificationRouteDescriptor;
            this.CertificationReference = certificationReference;
        }

        /// <summary>
        /// The title of the Certification required for Graduation.
        /// </summary>
        /// <value>The title of the Certification required for Graduation.</value>
        [DataMember(Name = "certificationTitle", IsRequired = true, EmitDefaultValue = false)]
        public string CertificationTitle { get; set; }

        /// <summary>
        /// The process, program ,or pathway used to obtain certification.
        /// </summary>
        /// <value>The process, program ,or pathway used to obtain certification.</value>
        [DataMember(Name = "certificationRouteDescriptor", EmitDefaultValue = false)]
        public string CertificationRouteDescriptor { get; set; }

        /// <summary>
        /// Gets or Sets CertificationReference
        /// </summary>
        [DataMember(Name = "certificationReference", EmitDefaultValue = false)]
        public TpdmCertificationReference CertificationReference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TpdmGraduationPlanRequiredCertification {\n");
            sb.Append("  CertificationTitle: ").Append(CertificationTitle).Append("\n");
            sb.Append("  CertificationRouteDescriptor: ").Append(CertificationRouteDescriptor).Append("\n");
            sb.Append("  CertificationReference: ").Append(CertificationReference).Append("\n");
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
            return this.Equals(input as TpdmGraduationPlanRequiredCertification);
        }

        /// <summary>
        /// Returns true if TpdmGraduationPlanRequiredCertification instances are equal
        /// </summary>
        /// <param name="input">Instance of TpdmGraduationPlanRequiredCertification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TpdmGraduationPlanRequiredCertification input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CertificationTitle == input.CertificationTitle ||
                    (this.CertificationTitle != null &&
                    this.CertificationTitle.Equals(input.CertificationTitle))
                ) && 
                (
                    this.CertificationRouteDescriptor == input.CertificationRouteDescriptor ||
                    (this.CertificationRouteDescriptor != null &&
                    this.CertificationRouteDescriptor.Equals(input.CertificationRouteDescriptor))
                ) && 
                (
                    this.CertificationReference == input.CertificationReference ||
                    (this.CertificationReference != null &&
                    this.CertificationReference.Equals(input.CertificationReference))
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
                if (this.CertificationTitle != null)
                    hashCode = hashCode * 59 + this.CertificationTitle.GetHashCode();
                if (this.CertificationRouteDescriptor != null)
                    hashCode = hashCode * 59 + this.CertificationRouteDescriptor.GetHashCode();
                if (this.CertificationReference != null)
                    hashCode = hashCode * 59 + this.CertificationReference.GetHashCode();
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
            // CertificationTitle (string) maxLength
            if(this.CertificationTitle != null && this.CertificationTitle.Length > 64)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CertificationTitle, length must be less than 64.", new [] { "CertificationTitle" });
            }

            // CertificationRouteDescriptor (string) maxLength
            if(this.CertificationRouteDescriptor != null && this.CertificationRouteDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CertificationRouteDescriptor, length must be less than 306.", new [] { "CertificationRouteDescriptor" });
            }

            yield break;
        }
    }

}
