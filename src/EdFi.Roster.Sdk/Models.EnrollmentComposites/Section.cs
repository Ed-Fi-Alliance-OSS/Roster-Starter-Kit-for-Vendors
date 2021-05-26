/*
 * Ed-Fi Operational Data Store API
 *
 * The Ed-Fi ODS / API enables applications to read and write education data stored in an Ed-Fi ODS through a secure REST interface.  ***  > *Note: Consumers of ODS / API information should sanitize all data for display and storage. The ODS / API provides reasonable safeguards against cross-site scripting attacks and other malicious content, but the platform does not and cannot guarantee that the data it contains is free of all potentially harmful content.*  *** 
 *
 * The version of the OpenAPI document: 3
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace EdFi.Roster.Sdk.Models.EnrollmentComposites
{
    /// <summary>
    /// Section
    /// </summary>
    [DataContract(Name = "section")]
    public partial class Section : IEquatable<Section>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Section" /> class.
        /// </summary>
        [JsonConstructor]
        protected Section() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Section" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="localCourseCode">The local code assigned by the School that identifies the course offering provided for the instruction of students. (required).</param>
        /// <param name="sectionIdentifier">The local identifier assigned to a section. (required).</param>
        /// <param name="academicSubjectDescriptor">The intended major subject area of the course..</param>
        /// <param name="availableCredits">The value of credits or units of value awarded for the completion of a course..</param>
        /// <param name="classPeriods">An unordered collection of sectionClassPeriods. .</param>
        /// <param name="educationalEnvironmentDescriptor">The setting in which a child receives education and related services; for example:         Center-based instruction         Home-based instruction         Hospital class         Mainstream         Residential care and treatment facility         ....</param>
        /// <param name="localCourseTitle">The descriptive name given to a course of study offered in the school, if different from the CourseTitle..</param>
        /// <param name="location">location.</param>
        /// <param name="sequenceOfCourse">When a section is part of a sequence of parts for a course, the number of the sequence. If the course has only one part, the value of this section attribute should be 1..</param>
        /// <param name="session">session.</param>
        /// <param name="staff">An unordered collection of staffSectionAssociations. .</param>
        /// <param name="students">An unordered collection of studentSectionAssociations. .</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        public Section(string id = default(string), string localCourseCode = default(string), string sectionIdentifier = default(string), string academicSubjectDescriptor = default(string), double availableCredits = default(double), List<SectionSectionClassPeriod> classPeriods = default(List<SectionSectionClassPeriod>), string educationalEnvironmentDescriptor = default(string), string localCourseTitle = default(string), SectionLocation location = default(SectionLocation), int sequenceOfCourse = default(int), SectionSession session = default(SectionSession), List<SectionStaffSectionAssociation> staff = default(List<SectionStaffSectionAssociation>), List<SectionStudentSectionAssociation> students = default(List<SectionStudentSectionAssociation>), string etag = default(string))
        {
            // to ensure "localCourseCode" is required (not null)
            this.LocalCourseCode = localCourseCode ?? throw new ArgumentNullException("localCourseCode is a required property for Section and cannot be null");
            // to ensure "sectionIdentifier" is required (not null)
            this.SectionIdentifier = sectionIdentifier ?? throw new ArgumentNullException("sectionIdentifier is a required property for Section and cannot be null");
            this.Id = id;
            this.AcademicSubjectDescriptor = academicSubjectDescriptor;
            this.AvailableCredits = availableCredits;
            this.ClassPeriods = classPeriods;
            this.EducationalEnvironmentDescriptor = educationalEnvironmentDescriptor;
            this.LocalCourseTitle = localCourseTitle;
            this.Location = location;
            this.SequenceOfCourse = sequenceOfCourse;
            this.Session = session;
            this.Staff = staff;
            this.Students = students;
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
        /// The local identifier assigned to a section.
        /// </summary>
        /// <value>The local identifier assigned to a section.</value>
        [DataMember(Name = "sectionIdentifier", IsRequired = true, EmitDefaultValue = false)]
        public string SectionIdentifier { get; set; }

        /// <summary>
        /// The intended major subject area of the course.
        /// </summary>
        /// <value>The intended major subject area of the course.</value>
        [DataMember(Name = "academicSubjectDescriptor", EmitDefaultValue = false)]
        public string AcademicSubjectDescriptor { get; set; }

        /// <summary>
        /// The value of credits or units of value awarded for the completion of a course.
        /// </summary>
        /// <value>The value of credits or units of value awarded for the completion of a course.</value>
        [DataMember(Name = "availableCredits", EmitDefaultValue = false)]
        public double AvailableCredits { get; set; }

        /// <summary>
        /// An unordered collection of sectionClassPeriods. 
        /// </summary>
        /// <value>An unordered collection of sectionClassPeriods. </value>
        [DataMember(Name = "classPeriods", EmitDefaultValue = false)]
        public List<SectionSectionClassPeriod> ClassPeriods { get; set; }

        /// <summary>
        /// The setting in which a child receives education and related services; for example:         Center-based instruction         Home-based instruction         Hospital class         Mainstream         Residential care and treatment facility         ...
        /// </summary>
        /// <value>The setting in which a child receives education and related services; for example:         Center-based instruction         Home-based instruction         Hospital class         Mainstream         Residential care and treatment facility         ...</value>
        [DataMember(Name = "educationalEnvironmentDescriptor", EmitDefaultValue = false)]
        public string EducationalEnvironmentDescriptor { get; set; }

        /// <summary>
        /// The descriptive name given to a course of study offered in the school, if different from the CourseTitle.
        /// </summary>
        /// <value>The descriptive name given to a course of study offered in the school, if different from the CourseTitle.</value>
        [DataMember(Name = "localCourseTitle", EmitDefaultValue = false)]
        public string LocalCourseTitle { get; set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name = "location", EmitDefaultValue = false)]
        public SectionLocation Location { get; set; }

        /// <summary>
        /// When a section is part of a sequence of parts for a course, the number of the sequence. If the course has only one part, the value of this section attribute should be 1.
        /// </summary>
        /// <value>When a section is part of a sequence of parts for a course, the number of the sequence. If the course has only one part, the value of this section attribute should be 1.</value>
        [DataMember(Name = "sequenceOfCourse", EmitDefaultValue = false)]
        public int SequenceOfCourse { get; set; }

        /// <summary>
        /// Gets or Sets Session
        /// </summary>
        [DataMember(Name = "session", EmitDefaultValue = false)]
        public SectionSession Session { get; set; }

        /// <summary>
        /// An unordered collection of staffSectionAssociations. 
        /// </summary>
        /// <value>An unordered collection of staffSectionAssociations. </value>
        [DataMember(Name = "staff", EmitDefaultValue = false)]
        public List<SectionStaffSectionAssociation> Staff { get; set; }

        /// <summary>
        /// An unordered collection of studentSectionAssociations. 
        /// </summary>
        /// <value>An unordered collection of studentSectionAssociations. </value>
        [DataMember(Name = "students", EmitDefaultValue = false)]
        public List<SectionStudentSectionAssociation> Students { get; set; }

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
            sb.Append("class Section {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LocalCourseCode: ").Append(LocalCourseCode).Append("\n");
            sb.Append("  SectionIdentifier: ").Append(SectionIdentifier).Append("\n");
            sb.Append("  AcademicSubjectDescriptor: ").Append(AcademicSubjectDescriptor).Append("\n");
            sb.Append("  AvailableCredits: ").Append(AvailableCredits).Append("\n");
            sb.Append("  ClassPeriods: ").Append(ClassPeriods).Append("\n");
            sb.Append("  EducationalEnvironmentDescriptor: ").Append(EducationalEnvironmentDescriptor).Append("\n");
            sb.Append("  LocalCourseTitle: ").Append(LocalCourseTitle).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  SequenceOfCourse: ").Append(SequenceOfCourse).Append("\n");
            sb.Append("  Session: ").Append(Session).Append("\n");
            sb.Append("  Staff: ").Append(Staff).Append("\n");
            sb.Append("  Students: ").Append(Students).Append("\n");
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
            return this.Equals(input as Section);
        }

        /// <summary>
        /// Returns true if Section instances are equal
        /// </summary>
        /// <param name="input">Instance of Section to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Section input)
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
                    this.SectionIdentifier == input.SectionIdentifier ||
                    (this.SectionIdentifier != null &&
                    this.SectionIdentifier.Equals(input.SectionIdentifier))
                ) && 
                (
                    this.AcademicSubjectDescriptor == input.AcademicSubjectDescriptor ||
                    (this.AcademicSubjectDescriptor != null &&
                    this.AcademicSubjectDescriptor.Equals(input.AcademicSubjectDescriptor))
                ) && 
                (
                    this.AvailableCredits == input.AvailableCredits ||
                    this.AvailableCredits.Equals(input.AvailableCredits)
                ) && 
                (
                    this.ClassPeriods == input.ClassPeriods ||
                    this.ClassPeriods != null &&
                    input.ClassPeriods != null &&
                    this.ClassPeriods.SequenceEqual(input.ClassPeriods)
                ) && 
                (
                    this.EducationalEnvironmentDescriptor == input.EducationalEnvironmentDescriptor ||
                    (this.EducationalEnvironmentDescriptor != null &&
                    this.EducationalEnvironmentDescriptor.Equals(input.EducationalEnvironmentDescriptor))
                ) && 
                (
                    this.LocalCourseTitle == input.LocalCourseTitle ||
                    (this.LocalCourseTitle != null &&
                    this.LocalCourseTitle.Equals(input.LocalCourseTitle))
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.SequenceOfCourse == input.SequenceOfCourse ||
                    this.SequenceOfCourse.Equals(input.SequenceOfCourse)
                ) && 
                (
                    this.Session == input.Session ||
                    (this.Session != null &&
                    this.Session.Equals(input.Session))
                ) && 
                (
                    this.Staff == input.Staff ||
                    this.Staff != null &&
                    input.Staff != null &&
                    this.Staff.SequenceEqual(input.Staff)
                ) && 
                (
                    this.Students == input.Students ||
                    this.Students != null &&
                    input.Students != null &&
                    this.Students.SequenceEqual(input.Students)
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
                if (this.SectionIdentifier != null)
                    hashCode = hashCode * 59 + this.SectionIdentifier.GetHashCode();
                if (this.AcademicSubjectDescriptor != null)
                    hashCode = hashCode * 59 + this.AcademicSubjectDescriptor.GetHashCode();
                hashCode = hashCode * 59 + this.AvailableCredits.GetHashCode();
                if (this.ClassPeriods != null)
                    hashCode = hashCode * 59 + this.ClassPeriods.GetHashCode();
                if (this.EducationalEnvironmentDescriptor != null)
                    hashCode = hashCode * 59 + this.EducationalEnvironmentDescriptor.GetHashCode();
                if (this.LocalCourseTitle != null)
                    hashCode = hashCode * 59 + this.LocalCourseTitle.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                hashCode = hashCode * 59 + this.SequenceOfCourse.GetHashCode();
                if (this.Session != null)
                    hashCode = hashCode * 59 + this.Session.GetHashCode();
                if (this.Staff != null)
                    hashCode = hashCode * 59 + this.Staff.GetHashCode();
                if (this.Students != null)
                    hashCode = hashCode * 59 + this.Students.GetHashCode();
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

            // SectionIdentifier (string) maxLength
            if(this.SectionIdentifier != null && this.SectionIdentifier.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SectionIdentifier, length must be less than 255.", new [] { "SectionIdentifier" });
            }

            // AcademicSubjectDescriptor (string) maxLength
            if(this.AcademicSubjectDescriptor != null && this.AcademicSubjectDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AcademicSubjectDescriptor, length must be less than 306.", new [] { "AcademicSubjectDescriptor" });
            }

            // EducationalEnvironmentDescriptor (string) maxLength
            if(this.EducationalEnvironmentDescriptor != null && this.EducationalEnvironmentDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EducationalEnvironmentDescriptor, length must be less than 306.", new [] { "EducationalEnvironmentDescriptor" });
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
