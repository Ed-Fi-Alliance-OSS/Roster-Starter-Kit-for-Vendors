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

namespace EdFi.Roster.Sdk.Models.EnrollmentComposites
{
    /// <summary>
    /// SectionStudentSectionAssociation
    /// </summary>
    [DataContract(Name = "section_studentSectionAssociation")]
    public partial class SectionStudentSectionAssociation : IEquatable<SectionStudentSectionAssociation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SectionStudentSectionAssociation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SectionStudentSectionAssociation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SectionStudentSectionAssociation" /> class.
        /// </summary>
        /// <param name="enrollmentBeginDate">Month, day, and year of the Student&#39;s entry or assignment to the Section. (required).</param>
        /// <param name="enrollmentEndDate">Month, day, and year of the withdrawal or exit of the Student from the Section..</param>
        /// <param name="id">id (required).</param>
        /// <param name="studentUniqueId">A unique alphanumeric code assigned to a student. (required).</param>
        public SectionStudentSectionAssociation(DateTime enrollmentBeginDate = default(DateTime), DateTime enrollmentEndDate = default(DateTime), string id = default(string), string studentUniqueId = default(string))
        {
            this.EnrollmentBeginDate = enrollmentBeginDate;
            // to ensure "id" is required (not null)
            this.Id = id ?? throw new ArgumentNullException("id is a required property for SectionStudentSectionAssociation and cannot be null");
            // to ensure "studentUniqueId" is required (not null)
            this.StudentUniqueId = studentUniqueId ?? throw new ArgumentNullException("studentUniqueId is a required property for SectionStudentSectionAssociation and cannot be null");
            this.EnrollmentEndDate = enrollmentEndDate;
        }

        /// <summary>
        /// Month, day, and year of the Student&#39;s entry or assignment to the Section.
        /// </summary>
        /// <value>Month, day, and year of the Student&#39;s entry or assignment to the Section.</value>
        [DataMember(Name = "enrollmentBeginDate", IsRequired = true, EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime EnrollmentBeginDate { get; set; }

        /// <summary>
        /// Month, day, and year of the withdrawal or exit of the Student from the Section.
        /// </summary>
        /// <value>Month, day, and year of the withdrawal or exit of the Student from the Section.</value>
        [DataMember(Name = "enrollmentEndDate", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime EnrollmentEndDate { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// A unique alphanumeric code assigned to a student.
        /// </summary>
        /// <value>A unique alphanumeric code assigned to a student.</value>
        [DataMember(Name = "studentUniqueId", IsRequired = true, EmitDefaultValue = false)]
        public string StudentUniqueId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SectionStudentSectionAssociation {\n");
            sb.Append("  EnrollmentBeginDate: ").Append(EnrollmentBeginDate).Append("\n");
            sb.Append("  EnrollmentEndDate: ").Append(EnrollmentEndDate).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  StudentUniqueId: ").Append(StudentUniqueId).Append("\n");
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
            return this.Equals(input as SectionStudentSectionAssociation);
        }

        /// <summary>
        /// Returns true if SectionStudentSectionAssociation instances are equal
        /// </summary>
        /// <param name="input">Instance of SectionStudentSectionAssociation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SectionStudentSectionAssociation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EnrollmentBeginDate == input.EnrollmentBeginDate ||
                    (this.EnrollmentBeginDate != null &&
                    this.EnrollmentBeginDate.Equals(input.EnrollmentBeginDate))
                ) && 
                (
                    this.EnrollmentEndDate == input.EnrollmentEndDate ||
                    (this.EnrollmentEndDate != null &&
                    this.EnrollmentEndDate.Equals(input.EnrollmentEndDate))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.StudentUniqueId == input.StudentUniqueId ||
                    (this.StudentUniqueId != null &&
                    this.StudentUniqueId.Equals(input.StudentUniqueId))
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
                if (this.EnrollmentBeginDate != null)
                    hashCode = hashCode * 59 + this.EnrollmentBeginDate.GetHashCode();
                if (this.EnrollmentEndDate != null)
                    hashCode = hashCode * 59 + this.EnrollmentEndDate.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.StudentUniqueId != null)
                    hashCode = hashCode * 59 + this.StudentUniqueId.GetHashCode();
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
            // StudentUniqueId (string) maxLength
            if(this.StudentUniqueId != null && this.StudentUniqueId.Length > 32)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StudentUniqueId, length must be less than 32.", new [] { "StudentUniqueId" });
            }

            yield break;
        }
    }

}
