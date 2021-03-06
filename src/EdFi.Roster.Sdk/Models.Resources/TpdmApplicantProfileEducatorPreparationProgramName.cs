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
    /// TpdmApplicantProfileEducatorPreparationProgramName
    /// </summary>
    [DataContract(Name = "tpdm_applicantProfileEducatorPreparationProgramName")]
    public partial class TpdmApplicantProfileEducatorPreparationProgramName : IEquatable<TpdmApplicantProfileEducatorPreparationProgramName>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmApplicantProfileEducatorPreparationProgramName" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TpdmApplicantProfileEducatorPreparationProgramName() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmApplicantProfileEducatorPreparationProgramName" /> class.
        /// </summary>
        /// <param name="educatorPreparationProgramName">The Teacher Preparation Program(s) completed by the teacher. (required).</param>
        public TpdmApplicantProfileEducatorPreparationProgramName(string educatorPreparationProgramName = default(string))
        {
            // to ensure "educatorPreparationProgramName" is required (not null)
            this.EducatorPreparationProgramName = educatorPreparationProgramName ?? throw new ArgumentNullException("educatorPreparationProgramName is a required property for TpdmApplicantProfileEducatorPreparationProgramName and cannot be null");
        }

        /// <summary>
        /// The Teacher Preparation Program(s) completed by the teacher.
        /// </summary>
        /// <value>The Teacher Preparation Program(s) completed by the teacher.</value>
        [DataMember(Name = "educatorPreparationProgramName", IsRequired = true, EmitDefaultValue = false)]
        public string EducatorPreparationProgramName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TpdmApplicantProfileEducatorPreparationProgramName {\n");
            sb.Append("  EducatorPreparationProgramName: ").Append(EducatorPreparationProgramName).Append("\n");
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
            return this.Equals(input as TpdmApplicantProfileEducatorPreparationProgramName);
        }

        /// <summary>
        /// Returns true if TpdmApplicantProfileEducatorPreparationProgramName instances are equal
        /// </summary>
        /// <param name="input">Instance of TpdmApplicantProfileEducatorPreparationProgramName to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TpdmApplicantProfileEducatorPreparationProgramName input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EducatorPreparationProgramName == input.EducatorPreparationProgramName ||
                    (this.EducatorPreparationProgramName != null &&
                    this.EducatorPreparationProgramName.Equals(input.EducatorPreparationProgramName))
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
                if (this.EducatorPreparationProgramName != null)
                    hashCode = hashCode * 59 + this.EducatorPreparationProgramName.GetHashCode();
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
            // EducatorPreparationProgramName (string) maxLength
            if(this.EducatorPreparationProgramName != null && this.EducatorPreparationProgramName.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EducatorPreparationProgramName, length must be less than 255.", new [] { "EducatorPreparationProgramName" });
            }

            yield break;
        }
    }

}
