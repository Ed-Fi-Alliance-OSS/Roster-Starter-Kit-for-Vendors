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
    /// EdFiCourseOffering
    /// </summary>
    [DataContract(Name = "edFi_courseOffering")]
    public partial class EdFiCourseOffering : IEquatable<EdFiCourseOffering>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiCourseOffering" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiCourseOffering() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiCourseOffering" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="localCourseCode">The local code assigned by the School that identifies the course offering provided for the instruction of students. (required).</param>
        /// <param name="courseReference">courseReference (required).</param>
        /// <param name="schoolReference">schoolReference (required).</param>
        /// <param name="sessionReference">sessionReference (required).</param>
        /// <param name="courseLevelCharacteristics">An unordered collection of courseOfferingCourseLevelCharacteristics. The type of specific program or designation with which the course offering is associated (e.g., AP, IB, Dual Credit, CTE). This collection should only be populated if it differs from the Course Level Characteristics identified at the Course level..</param>
        /// <param name="curriculumUseds">An unordered collection of courseOfferingCurriculumUseds. The type of curriculum used in an early learning classroom or group..</param>
        /// <param name="instructionalTimePlanned">The planned total number of clock minutes of instruction for this course offering. Generally, this should be at least as many minutes as is required for completion by the related state- or district-defined course..</param>
        /// <param name="localCourseTitle">The descriptive name given to a course of study offered in the school, if different from the CourseTitle..</param>
        /// <param name="offeredGradeLevels">An unordered collection of courseOfferingOfferedGradeLevels. The grade levels in which the course is offered. This collection should only be populated if it differs from the Offered Grade Levels identified at the Course level..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        public EdFiCourseOffering(string id = default(string), string localCourseCode = default(string), EdFiCourseReference courseReference = default(EdFiCourseReference), EdFiSchoolReference schoolReference = default(EdFiSchoolReference), EdFiSessionReference sessionReference = default(EdFiSessionReference), List<EdFiCourseOfferingCourseLevelCharacteristic> courseLevelCharacteristics = default(List<EdFiCourseOfferingCourseLevelCharacteristic>), List<EdFiCourseOfferingCurriculumUsed> curriculumUseds = default(List<EdFiCourseOfferingCurriculumUsed>), int instructionalTimePlanned = default(int), string localCourseTitle = default(string), List<EdFiCourseOfferingOfferedGradeLevel> offeredGradeLevels = default(List<EdFiCourseOfferingOfferedGradeLevel>), string etag = default(string))
        {
            // to ensure "localCourseCode" is required (not null)
            this.LocalCourseCode = localCourseCode ?? throw new ArgumentNullException("localCourseCode is a required property for EdFiCourseOffering and cannot be null");
            // to ensure "courseReference" is required (not null)
            this.CourseReference = courseReference ?? throw new ArgumentNullException("courseReference is a required property for EdFiCourseOffering and cannot be null");
            // to ensure "schoolReference" is required (not null)
            this.SchoolReference = schoolReference ?? throw new ArgumentNullException("schoolReference is a required property for EdFiCourseOffering and cannot be null");
            // to ensure "sessionReference" is required (not null)
            this.SessionReference = sessionReference ?? throw new ArgumentNullException("sessionReference is a required property for EdFiCourseOffering and cannot be null");
            this.Id = id;
            this.CourseLevelCharacteristics = courseLevelCharacteristics;
            this.CurriculumUseds = curriculumUseds;
            this.InstructionalTimePlanned = instructionalTimePlanned;
            this.LocalCourseTitle = localCourseTitle;
            this.OfferedGradeLevels = offeredGradeLevels;
            this.Etag = etag;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The local code assigned by the School that identifies the course offering provided for the instruction of students.
        /// </summary>
        /// <value>The local code assigned by the School that identifies the course offering provided for the instruction of students.</value>
        [DataMember(Name = "localCourseCode", IsRequired = true, EmitDefaultValue = false)]
        public string LocalCourseCode { get; set; }

        /// <summary>
        /// Gets or Sets CourseReference
        /// </summary>
        [DataMember(Name = "courseReference", IsRequired = true, EmitDefaultValue = false)]
        public EdFiCourseReference CourseReference { get; set; }

        /// <summary>
        /// Gets or Sets SchoolReference
        /// </summary>
        [DataMember(Name = "schoolReference", IsRequired = true, EmitDefaultValue = false)]
        public EdFiSchoolReference SchoolReference { get; set; }

        /// <summary>
        /// Gets or Sets SessionReference
        /// </summary>
        [DataMember(Name = "sessionReference", IsRequired = true, EmitDefaultValue = false)]
        public EdFiSessionReference SessionReference { get; set; }

        /// <summary>
        /// An unordered collection of courseOfferingCourseLevelCharacteristics. The type of specific program or designation with which the course offering is associated (e.g., AP, IB, Dual Credit, CTE). This collection should only be populated if it differs from the Course Level Characteristics identified at the Course level.
        /// </summary>
        /// <value>An unordered collection of courseOfferingCourseLevelCharacteristics. The type of specific program or designation with which the course offering is associated (e.g., AP, IB, Dual Credit, CTE). This collection should only be populated if it differs from the Course Level Characteristics identified at the Course level.</value>
        [DataMember(Name = "courseLevelCharacteristics", EmitDefaultValue = false)]
        public List<EdFiCourseOfferingCourseLevelCharacteristic> CourseLevelCharacteristics { get; set; }

        /// <summary>
        /// An unordered collection of courseOfferingCurriculumUseds. The type of curriculum used in an early learning classroom or group.
        /// </summary>
        /// <value>An unordered collection of courseOfferingCurriculumUseds. The type of curriculum used in an early learning classroom or group.</value>
        [DataMember(Name = "curriculumUseds", EmitDefaultValue = false)]
        public List<EdFiCourseOfferingCurriculumUsed> CurriculumUseds { get; set; }

        /// <summary>
        /// The planned total number of clock minutes of instruction for this course offering. Generally, this should be at least as many minutes as is required for completion by the related state- or district-defined course.
        /// </summary>
        /// <value>The planned total number of clock minutes of instruction for this course offering. Generally, this should be at least as many minutes as is required for completion by the related state- or district-defined course.</value>
        [DataMember(Name = "instructionalTimePlanned", EmitDefaultValue = false)]
        public int InstructionalTimePlanned { get; set; }

        /// <summary>
        /// The descriptive name given to a course of study offered in the school, if different from the CourseTitle.
        /// </summary>
        /// <value>The descriptive name given to a course of study offered in the school, if different from the CourseTitle.</value>
        [DataMember(Name = "localCourseTitle", EmitDefaultValue = false)]
        public string LocalCourseTitle { get; set; }

        /// <summary>
        /// An unordered collection of courseOfferingOfferedGradeLevels. The grade levels in which the course is offered. This collection should only be populated if it differs from the Offered Grade Levels identified at the Course level.
        /// </summary>
        /// <value>An unordered collection of courseOfferingOfferedGradeLevels. The grade levels in which the course is offered. This collection should only be populated if it differs from the Offered Grade Levels identified at the Course level.</value>
        [DataMember(Name = "offeredGradeLevels", EmitDefaultValue = false)]
        public List<EdFiCourseOfferingOfferedGradeLevel> OfferedGradeLevels { get; set; }

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
            sb.Append("class EdFiCourseOffering {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LocalCourseCode: ").Append(LocalCourseCode).Append("\n");
            sb.Append("  CourseReference: ").Append(CourseReference).Append("\n");
            sb.Append("  SchoolReference: ").Append(SchoolReference).Append("\n");
            sb.Append("  SessionReference: ").Append(SessionReference).Append("\n");
            sb.Append("  CourseLevelCharacteristics: ").Append(CourseLevelCharacteristics).Append("\n");
            sb.Append("  CurriculumUseds: ").Append(CurriculumUseds).Append("\n");
            sb.Append("  InstructionalTimePlanned: ").Append(InstructionalTimePlanned).Append("\n");
            sb.Append("  LocalCourseTitle: ").Append(LocalCourseTitle).Append("\n");
            sb.Append("  OfferedGradeLevels: ").Append(OfferedGradeLevels).Append("\n");
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
            return this.Equals(input as EdFiCourseOffering);
        }

        /// <summary>
        /// Returns true if EdFiCourseOffering instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiCourseOffering to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiCourseOffering input)
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
                    this.LocalCourseCode == input.LocalCourseCode ||
                    (this.LocalCourseCode != null &&
                    this.LocalCourseCode.Equals(input.LocalCourseCode))
                ) && 
                (
                    this.CourseReference == input.CourseReference ||
                    (this.CourseReference != null &&
                    this.CourseReference.Equals(input.CourseReference))
                ) && 
                (
                    this.SchoolReference == input.SchoolReference ||
                    (this.SchoolReference != null &&
                    this.SchoolReference.Equals(input.SchoolReference))
                ) && 
                (
                    this.SessionReference == input.SessionReference ||
                    (this.SessionReference != null &&
                    this.SessionReference.Equals(input.SessionReference))
                ) && 
                (
                    this.CourseLevelCharacteristics == input.CourseLevelCharacteristics ||
                    this.CourseLevelCharacteristics != null &&
                    input.CourseLevelCharacteristics != null &&
                    this.CourseLevelCharacteristics.SequenceEqual(input.CourseLevelCharacteristics)
                ) && 
                (
                    this.CurriculumUseds == input.CurriculumUseds ||
                    this.CurriculumUseds != null &&
                    input.CurriculumUseds != null &&
                    this.CurriculumUseds.SequenceEqual(input.CurriculumUseds)
                ) && 
                (
                    this.InstructionalTimePlanned == input.InstructionalTimePlanned ||
                    this.InstructionalTimePlanned.Equals(input.InstructionalTimePlanned)
                ) && 
                (
                    this.LocalCourseTitle == input.LocalCourseTitle ||
                    (this.LocalCourseTitle != null &&
                    this.LocalCourseTitle.Equals(input.LocalCourseTitle))
                ) && 
                (
                    this.OfferedGradeLevels == input.OfferedGradeLevels ||
                    this.OfferedGradeLevels != null &&
                    input.OfferedGradeLevels != null &&
                    this.OfferedGradeLevels.SequenceEqual(input.OfferedGradeLevels)
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
                if (this.LocalCourseCode != null)
                    hashCode = hashCode * 59 + this.LocalCourseCode.GetHashCode();
                if (this.CourseReference != null)
                    hashCode = hashCode * 59 + this.CourseReference.GetHashCode();
                if (this.SchoolReference != null)
                    hashCode = hashCode * 59 + this.SchoolReference.GetHashCode();
                if (this.SessionReference != null)
                    hashCode = hashCode * 59 + this.SessionReference.GetHashCode();
                if (this.CourseLevelCharacteristics != null)
                    hashCode = hashCode * 59 + this.CourseLevelCharacteristics.GetHashCode();
                if (this.CurriculumUseds != null)
                    hashCode = hashCode * 59 + this.CurriculumUseds.GetHashCode();
                hashCode = hashCode * 59 + this.InstructionalTimePlanned.GetHashCode();
                if (this.LocalCourseTitle != null)
                    hashCode = hashCode * 59 + this.LocalCourseTitle.GetHashCode();
                if (this.OfferedGradeLevels != null)
                    hashCode = hashCode * 59 + this.OfferedGradeLevels.GetHashCode();
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
            // LocalCourseCode (string) maxLength
            if(this.LocalCourseCode != null && this.LocalCourseCode.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LocalCourseCode, length must be less than 60.", new [] { "LocalCourseCode" });
            }

            // LocalCourseTitle (string) maxLength
            if(this.LocalCourseTitle != null && this.LocalCourseTitle.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LocalCourseTitle, length must be less than 60.", new [] { "LocalCourseTitle" });
            }

            yield break;
        }
    }

}
