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
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace EdFi.Roster.Sdk.Models.EnrollmentComposites
{
    /// <summary>
    /// StudentStudentEducationOrganizationAssociationStudentEducationOrganizationAssociationRace
    /// </summary>
    [DataContract(Name = "student_studentEducationOrganizationAssociation_studentEducationOrganizationAssociationRace")]
    public partial class StudentStudentEducationOrganizationAssociationStudentEducationOrganizationAssociationRace : IEquatable<StudentStudentEducationOrganizationAssociationStudentEducationOrganizationAssociationRace>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StudentStudentEducationOrganizationAssociationStudentEducationOrganizationAssociationRace" /> class.
        /// </summary>
        [JsonConstructor]
        protected StudentStudentEducationOrganizationAssociationStudentEducationOrganizationAssociationRace() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StudentStudentEducationOrganizationAssociationStudentEducationOrganizationAssociationRace" /> class.
        /// </summary>
        /// <param name="raceDescriptor">The general racial category which most clearly reflects the individual&#39;s recognition of his or her community or with which the individual most identifies as last reported to the education organization. The data model allows for multiple entries so that each individual can specify all appropriate races. (required).</param>
        public StudentStudentEducationOrganizationAssociationStudentEducationOrganizationAssociationRace(string raceDescriptor = default(string))
        {
            // to ensure "raceDescriptor" is required (not null)
            this.RaceDescriptor = raceDescriptor ?? throw new ArgumentNullException("raceDescriptor is a required property for StudentStudentEducationOrganizationAssociationStudentEducationOrganizationAssociationRace and cannot be null");
        }

        /// <summary>
        /// The general racial category which most clearly reflects the individual&#39;s recognition of his or her community or with which the individual most identifies as last reported to the education organization. The data model allows for multiple entries so that each individual can specify all appropriate races.
        /// </summary>
        /// <value>The general racial category which most clearly reflects the individual&#39;s recognition of his or her community or with which the individual most identifies as last reported to the education organization. The data model allows for multiple entries so that each individual can specify all appropriate races.</value>
        [DataMember(Name = "raceDescriptor", IsRequired = true, EmitDefaultValue = false)]
        public string RaceDescriptor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StudentStudentEducationOrganizationAssociationStudentEducationOrganizationAssociationRace {\n");
            sb.Append("  RaceDescriptor: ").Append(RaceDescriptor).Append("\n");
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
            return this.Equals(input as StudentStudentEducationOrganizationAssociationStudentEducationOrganizationAssociationRace);
        }

        /// <summary>
        /// Returns true if StudentStudentEducationOrganizationAssociationStudentEducationOrganizationAssociationRace instances are equal
        /// </summary>
        /// <param name="input">Instance of StudentStudentEducationOrganizationAssociationStudentEducationOrganizationAssociationRace to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StudentStudentEducationOrganizationAssociationStudentEducationOrganizationAssociationRace input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RaceDescriptor == input.RaceDescriptor ||
                    (this.RaceDescriptor != null &&
                    this.RaceDescriptor.Equals(input.RaceDescriptor))
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
                if (this.RaceDescriptor != null)
                    hashCode = hashCode * 59 + this.RaceDescriptor.GetHashCode();
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
            // RaceDescriptor (string) maxLength
            if(this.RaceDescriptor != null && this.RaceDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RaceDescriptor, length must be less than 306.", new [] { "RaceDescriptor" });
            }

            yield break;
        }
    }

}
