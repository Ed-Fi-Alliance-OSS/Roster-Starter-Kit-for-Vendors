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
    /// EdFiStateEducationAgencyAccountability
    /// </summary>
    [DataContract(Name = "edFi_stateEducationAgencyAccountability")]
    public partial class EdFiStateEducationAgencyAccountability : IEquatable<EdFiStateEducationAgencyAccountability>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStateEducationAgencyAccountability" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStateEducationAgencyAccountability() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStateEducationAgencyAccountability" /> class.
        /// </summary>
        /// <param name="cteGraduationRateInclusion">An indication of whether CTE concentrators are included in the state&#39;s computation of its graduation rate..</param>
        /// <param name="schoolYearTypeReference">schoolYearTypeReference (required).</param>
        public EdFiStateEducationAgencyAccountability(bool cteGraduationRateInclusion = default(bool), EdFiSchoolYearTypeReference schoolYearTypeReference = default(EdFiSchoolYearTypeReference))
        {
            // to ensure "schoolYearTypeReference" is required (not null)
            this.SchoolYearTypeReference = schoolYearTypeReference ?? throw new ArgumentNullException("schoolYearTypeReference is a required property for EdFiStateEducationAgencyAccountability and cannot be null");
            this.CteGraduationRateInclusion = cteGraduationRateInclusion;
        }

        /// <summary>
        /// An indication of whether CTE concentrators are included in the state&#39;s computation of its graduation rate.
        /// </summary>
        /// <value>An indication of whether CTE concentrators are included in the state&#39;s computation of its graduation rate.</value>
        [DataMember(Name = "cteGraduationRateInclusion", EmitDefaultValue = true)]
        public bool CteGraduationRateInclusion { get; set; }

        /// <summary>
        /// Gets or Sets SchoolYearTypeReference
        /// </summary>
        [DataMember(Name = "schoolYearTypeReference", IsRequired = true, EmitDefaultValue = false)]
        public EdFiSchoolYearTypeReference SchoolYearTypeReference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiStateEducationAgencyAccountability {\n");
            sb.Append("  CteGraduationRateInclusion: ").Append(CteGraduationRateInclusion).Append("\n");
            sb.Append("  SchoolYearTypeReference: ").Append(SchoolYearTypeReference).Append("\n");
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
            return this.Equals(input as EdFiStateEducationAgencyAccountability);
        }

        /// <summary>
        /// Returns true if EdFiStateEducationAgencyAccountability instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiStateEducationAgencyAccountability to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiStateEducationAgencyAccountability input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CteGraduationRateInclusion == input.CteGraduationRateInclusion ||
                    this.CteGraduationRateInclusion.Equals(input.CteGraduationRateInclusion)
                ) && 
                (
                    this.SchoolYearTypeReference == input.SchoolYearTypeReference ||
                    (this.SchoolYearTypeReference != null &&
                    this.SchoolYearTypeReference.Equals(input.SchoolYearTypeReference))
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
                hashCode = hashCode * 59 + this.CteGraduationRateInclusion.GetHashCode();
                if (this.SchoolYearTypeReference != null)
                    hashCode = hashCode * 59 + this.SchoolYearTypeReference.GetHashCode();
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
            yield break;
        }
    }

}
