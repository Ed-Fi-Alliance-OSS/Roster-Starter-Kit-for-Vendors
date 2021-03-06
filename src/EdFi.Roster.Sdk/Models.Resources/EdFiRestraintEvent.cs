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
    /// EdFiRestraintEvent
    /// </summary>
    [DataContract(Name = "edFi_restraintEvent")]
    public partial class EdFiRestraintEvent : IEquatable<EdFiRestraintEvent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiRestraintEvent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiRestraintEvent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiRestraintEvent" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="restraintEventIdentifier">A unique number or alphanumeric code assigned to a restraint event by a school, school system, state, or other agency or entity. (required).</param>
        /// <param name="schoolReference">schoolReference (required).</param>
        /// <param name="studentReference">studentReference (required).</param>
        /// <param name="educationalEnvironmentDescriptor">The setting where the RestraintEvent was exercised..</param>
        /// <param name="eventDate">Month, day, and year of the RestraintEvent. (required).</param>
        /// <param name="programs">An unordered collection of restraintEventPrograms. The special education program associated with the RestraintEvent..</param>
        /// <param name="reasons">An unordered collection of restraintEventReasons. A categorization of the circumstances or reason for the RestraintEvent..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        public EdFiRestraintEvent(string id = default(string), string restraintEventIdentifier = default(string), EdFiSchoolReference schoolReference = default(EdFiSchoolReference), EdFiStudentReference studentReference = default(EdFiStudentReference), string educationalEnvironmentDescriptor = default(string), DateTime eventDate = default(DateTime), List<EdFiRestraintEventProgram> programs = default(List<EdFiRestraintEventProgram>), List<EdFiRestraintEventReason> reasons = default(List<EdFiRestraintEventReason>), string etag = default(string))
        {
            // to ensure "restraintEventIdentifier" is required (not null)
            this.RestraintEventIdentifier = restraintEventIdentifier ?? throw new ArgumentNullException("restraintEventIdentifier is a required property for EdFiRestraintEvent and cannot be null");
            // to ensure "schoolReference" is required (not null)
            this.SchoolReference = schoolReference ?? throw new ArgumentNullException("schoolReference is a required property for EdFiRestraintEvent and cannot be null");
            // to ensure "studentReference" is required (not null)
            this.StudentReference = studentReference ?? throw new ArgumentNullException("studentReference is a required property for EdFiRestraintEvent and cannot be null");
            this.EventDate = eventDate;
            this.Id = id;
            this.EducationalEnvironmentDescriptor = educationalEnvironmentDescriptor;
            this.Programs = programs;
            this.Reasons = reasons;
            this.Etag = etag;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// A unique number or alphanumeric code assigned to a restraint event by a school, school system, state, or other agency or entity.
        /// </summary>
        /// <value>A unique number or alphanumeric code assigned to a restraint event by a school, school system, state, or other agency or entity.</value>
        [DataMember(Name = "restraintEventIdentifier", IsRequired = true, EmitDefaultValue = false)]
        public string RestraintEventIdentifier { get; set; }

        /// <summary>
        /// Gets or Sets SchoolReference
        /// </summary>
        [DataMember(Name = "schoolReference", IsRequired = true, EmitDefaultValue = false)]
        public EdFiSchoolReference SchoolReference { get; set; }

        /// <summary>
        /// Gets or Sets StudentReference
        /// </summary>
        [DataMember(Name = "studentReference", IsRequired = true, EmitDefaultValue = false)]
        public EdFiStudentReference StudentReference { get; set; }

        /// <summary>
        /// The setting where the RestraintEvent was exercised.
        /// </summary>
        /// <value>The setting where the RestraintEvent was exercised.</value>
        [DataMember(Name = "educationalEnvironmentDescriptor", EmitDefaultValue = false)]
        public string EducationalEnvironmentDescriptor { get; set; }

        /// <summary>
        /// Month, day, and year of the RestraintEvent.
        /// </summary>
        /// <value>Month, day, and year of the RestraintEvent.</value>
        [DataMember(Name = "eventDate", IsRequired = true, EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime EventDate { get; set; }

        /// <summary>
        /// An unordered collection of restraintEventPrograms. The special education program associated with the RestraintEvent.
        /// </summary>
        /// <value>An unordered collection of restraintEventPrograms. The special education program associated with the RestraintEvent.</value>
        [DataMember(Name = "programs", EmitDefaultValue = false)]
        public List<EdFiRestraintEventProgram> Programs { get; set; }

        /// <summary>
        /// An unordered collection of restraintEventReasons. A categorization of the circumstances or reason for the RestraintEvent.
        /// </summary>
        /// <value>An unordered collection of restraintEventReasons. A categorization of the circumstances or reason for the RestraintEvent.</value>
        [DataMember(Name = "reasons", EmitDefaultValue = false)]
        public List<EdFiRestraintEventReason> Reasons { get; set; }

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
            sb.Append("class EdFiRestraintEvent {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  RestraintEventIdentifier: ").Append(RestraintEventIdentifier).Append("\n");
            sb.Append("  SchoolReference: ").Append(SchoolReference).Append("\n");
            sb.Append("  StudentReference: ").Append(StudentReference).Append("\n");
            sb.Append("  EducationalEnvironmentDescriptor: ").Append(EducationalEnvironmentDescriptor).Append("\n");
            sb.Append("  EventDate: ").Append(EventDate).Append("\n");
            sb.Append("  Programs: ").Append(Programs).Append("\n");
            sb.Append("  Reasons: ").Append(Reasons).Append("\n");
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
            return this.Equals(input as EdFiRestraintEvent);
        }

        /// <summary>
        /// Returns true if EdFiRestraintEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiRestraintEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiRestraintEvent input)
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
                    this.RestraintEventIdentifier == input.RestraintEventIdentifier ||
                    (this.RestraintEventIdentifier != null &&
                    this.RestraintEventIdentifier.Equals(input.RestraintEventIdentifier))
                ) && 
                (
                    this.SchoolReference == input.SchoolReference ||
                    (this.SchoolReference != null &&
                    this.SchoolReference.Equals(input.SchoolReference))
                ) && 
                (
                    this.StudentReference == input.StudentReference ||
                    (this.StudentReference != null &&
                    this.StudentReference.Equals(input.StudentReference))
                ) && 
                (
                    this.EducationalEnvironmentDescriptor == input.EducationalEnvironmentDescriptor ||
                    (this.EducationalEnvironmentDescriptor != null &&
                    this.EducationalEnvironmentDescriptor.Equals(input.EducationalEnvironmentDescriptor))
                ) && 
                (
                    this.EventDate == input.EventDate ||
                    (this.EventDate != null &&
                    this.EventDate.Equals(input.EventDate))
                ) && 
                (
                    this.Programs == input.Programs ||
                    this.Programs != null &&
                    input.Programs != null &&
                    this.Programs.SequenceEqual(input.Programs)
                ) && 
                (
                    this.Reasons == input.Reasons ||
                    this.Reasons != null &&
                    input.Reasons != null &&
                    this.Reasons.SequenceEqual(input.Reasons)
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
                if (this.RestraintEventIdentifier != null)
                    hashCode = hashCode * 59 + this.RestraintEventIdentifier.GetHashCode();
                if (this.SchoolReference != null)
                    hashCode = hashCode * 59 + this.SchoolReference.GetHashCode();
                if (this.StudentReference != null)
                    hashCode = hashCode * 59 + this.StudentReference.GetHashCode();
                if (this.EducationalEnvironmentDescriptor != null)
                    hashCode = hashCode * 59 + this.EducationalEnvironmentDescriptor.GetHashCode();
                if (this.EventDate != null)
                    hashCode = hashCode * 59 + this.EventDate.GetHashCode();
                if (this.Programs != null)
                    hashCode = hashCode * 59 + this.Programs.GetHashCode();
                if (this.Reasons != null)
                    hashCode = hashCode * 59 + this.Reasons.GetHashCode();
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
            // RestraintEventIdentifier (string) maxLength
            if(this.RestraintEventIdentifier != null && this.RestraintEventIdentifier.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RestraintEventIdentifier, length must be less than 20.", new [] { "RestraintEventIdentifier" });
            }

            // EducationalEnvironmentDescriptor (string) maxLength
            if(this.EducationalEnvironmentDescriptor != null && this.EducationalEnvironmentDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EducationalEnvironmentDescriptor, length must be less than 306.", new [] { "EducationalEnvironmentDescriptor" });
            }

            yield break;
        }
    }

}
