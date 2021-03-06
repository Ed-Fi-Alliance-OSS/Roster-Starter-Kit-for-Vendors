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
    /// TpdmRecruitmentEventAttendanceDisabilityDesignation
    /// </summary>
    [DataContract(Name = "tpdm_recruitmentEventAttendanceDisabilityDesignation")]
    public partial class TpdmRecruitmentEventAttendanceDisabilityDesignation : IEquatable<TpdmRecruitmentEventAttendanceDisabilityDesignation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmRecruitmentEventAttendanceDisabilityDesignation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TpdmRecruitmentEventAttendanceDisabilityDesignation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmRecruitmentEventAttendanceDisabilityDesignation" /> class.
        /// </summary>
        /// <param name="disabilityDesignationDescriptor">Whether the disability is IDEA, Section 504, or other disability designation. (required).</param>
        public TpdmRecruitmentEventAttendanceDisabilityDesignation(string disabilityDesignationDescriptor = default(string))
        {
            // to ensure "disabilityDesignationDescriptor" is required (not null)
            this.DisabilityDesignationDescriptor = disabilityDesignationDescriptor ?? throw new ArgumentNullException("disabilityDesignationDescriptor is a required property for TpdmRecruitmentEventAttendanceDisabilityDesignation and cannot be null");
        }

        /// <summary>
        /// Whether the disability is IDEA, Section 504, or other disability designation.
        /// </summary>
        /// <value>Whether the disability is IDEA, Section 504, or other disability designation.</value>
        [DataMember(Name = "disabilityDesignationDescriptor", IsRequired = true, EmitDefaultValue = false)]
        public string DisabilityDesignationDescriptor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TpdmRecruitmentEventAttendanceDisabilityDesignation {\n");
            sb.Append("  DisabilityDesignationDescriptor: ").Append(DisabilityDesignationDescriptor).Append("\n");
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
            return this.Equals(input as TpdmRecruitmentEventAttendanceDisabilityDesignation);
        }

        /// <summary>
        /// Returns true if TpdmRecruitmentEventAttendanceDisabilityDesignation instances are equal
        /// </summary>
        /// <param name="input">Instance of TpdmRecruitmentEventAttendanceDisabilityDesignation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TpdmRecruitmentEventAttendanceDisabilityDesignation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DisabilityDesignationDescriptor == input.DisabilityDesignationDescriptor ||
                    (this.DisabilityDesignationDescriptor != null &&
                    this.DisabilityDesignationDescriptor.Equals(input.DisabilityDesignationDescriptor))
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
                if (this.DisabilityDesignationDescriptor != null)
                    hashCode = hashCode * 59 + this.DisabilityDesignationDescriptor.GetHashCode();
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
            // DisabilityDesignationDescriptor (string) maxLength
            if(this.DisabilityDesignationDescriptor != null && this.DisabilityDesignationDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DisabilityDesignationDescriptor, length must be less than 306.", new [] { "DisabilityDesignationDescriptor" });
            }

            yield break;
        }
    }

}
