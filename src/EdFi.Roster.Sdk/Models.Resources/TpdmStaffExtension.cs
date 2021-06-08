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
    /// TpdmStaffExtension
    /// </summary>
    [DataContract(Name = "tpdm_staffExtension")]
    public partial class TpdmStaffExtension : IEquatable<TpdmStaffExtension>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmStaffExtension" /> class.
        /// </summary>
        /// <param name="genderDescriptor">The gender with which a person associates..</param>
        /// <param name="openStaffPositionReference">openStaffPositionReference.</param>
        /// <param name="educatorPreparationPrograms">An unordered collection of staffEducatorPreparationPrograms. The Educator Preparation Program(s) completed by the teacher..</param>
        /// <param name="highlyQualifiedAcademicSubjects">An unordered collection of staffHighlyQualifiedAcademicSubjects. The academic subject(s) in which the staff is deemed to be \&quot;highly qualified\&quot;..</param>
        /// <param name="educatorResearch">educatorResearch.</param>
        public TpdmStaffExtension(string genderDescriptor = default(string), EdFiOpenStaffPositionReference openStaffPositionReference = default(EdFiOpenStaffPositionReference), List<TpdmStaffEducatorPreparationProgram> educatorPreparationPrograms = default(List<TpdmStaffEducatorPreparationProgram>), List<TpdmStaffHighlyQualifiedAcademicSubject> highlyQualifiedAcademicSubjects = default(List<TpdmStaffHighlyQualifiedAcademicSubject>), TpdmStaffEducatorResearch educatorResearch = default(TpdmStaffEducatorResearch))
        {
            this.GenderDescriptor = genderDescriptor;
            this.OpenStaffPositionReference = openStaffPositionReference;
            this.EducatorPreparationPrograms = educatorPreparationPrograms;
            this.HighlyQualifiedAcademicSubjects = highlyQualifiedAcademicSubjects;
            this.EducatorResearch = educatorResearch;
        }

        /// <summary>
        /// The gender with which a person associates.
        /// </summary>
        /// <value>The gender with which a person associates.</value>
        [DataMember(Name = "genderDescriptor", EmitDefaultValue = false)]
        public string GenderDescriptor { get; set; }

        /// <summary>
        /// Gets or Sets OpenStaffPositionReference
        /// </summary>
        [DataMember(Name = "openStaffPositionReference", EmitDefaultValue = false)]
        public EdFiOpenStaffPositionReference OpenStaffPositionReference { get; set; }

        /// <summary>
        /// An unordered collection of staffEducatorPreparationPrograms. The Educator Preparation Program(s) completed by the teacher.
        /// </summary>
        /// <value>An unordered collection of staffEducatorPreparationPrograms. The Educator Preparation Program(s) completed by the teacher.</value>
        [DataMember(Name = "educatorPreparationPrograms", EmitDefaultValue = false)]
        public List<TpdmStaffEducatorPreparationProgram> EducatorPreparationPrograms { get; set; }

        /// <summary>
        /// An unordered collection of staffHighlyQualifiedAcademicSubjects. The academic subject(s) in which the staff is deemed to be \&quot;highly qualified\&quot;.
        /// </summary>
        /// <value>An unordered collection of staffHighlyQualifiedAcademicSubjects. The academic subject(s) in which the staff is deemed to be \&quot;highly qualified\&quot;.</value>
        [DataMember(Name = "highlyQualifiedAcademicSubjects", EmitDefaultValue = false)]
        public List<TpdmStaffHighlyQualifiedAcademicSubject> HighlyQualifiedAcademicSubjects { get; set; }

        /// <summary>
        /// Gets or Sets EducatorResearch
        /// </summary>
        [DataMember(Name = "educatorResearch", EmitDefaultValue = false)]
        public TpdmStaffEducatorResearch EducatorResearch { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TpdmStaffExtension {\n");
            sb.Append("  GenderDescriptor: ").Append(GenderDescriptor).Append("\n");
            sb.Append("  OpenStaffPositionReference: ").Append(OpenStaffPositionReference).Append("\n");
            sb.Append("  EducatorPreparationPrograms: ").Append(EducatorPreparationPrograms).Append("\n");
            sb.Append("  HighlyQualifiedAcademicSubjects: ").Append(HighlyQualifiedAcademicSubjects).Append("\n");
            sb.Append("  EducatorResearch: ").Append(EducatorResearch).Append("\n");
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
            return this.Equals(input as TpdmStaffExtension);
        }

        /// <summary>
        /// Returns true if TpdmStaffExtension instances are equal
        /// </summary>
        /// <param name="input">Instance of TpdmStaffExtension to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TpdmStaffExtension input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GenderDescriptor == input.GenderDescriptor ||
                    (this.GenderDescriptor != null &&
                    this.GenderDescriptor.Equals(input.GenderDescriptor))
                ) && 
                (
                    this.OpenStaffPositionReference == input.OpenStaffPositionReference ||
                    (this.OpenStaffPositionReference != null &&
                    this.OpenStaffPositionReference.Equals(input.OpenStaffPositionReference))
                ) && 
                (
                    this.EducatorPreparationPrograms == input.EducatorPreparationPrograms ||
                    this.EducatorPreparationPrograms != null &&
                    input.EducatorPreparationPrograms != null &&
                    this.EducatorPreparationPrograms.SequenceEqual(input.EducatorPreparationPrograms)
                ) && 
                (
                    this.HighlyQualifiedAcademicSubjects == input.HighlyQualifiedAcademicSubjects ||
                    this.HighlyQualifiedAcademicSubjects != null &&
                    input.HighlyQualifiedAcademicSubjects != null &&
                    this.HighlyQualifiedAcademicSubjects.SequenceEqual(input.HighlyQualifiedAcademicSubjects)
                ) && 
                (
                    this.EducatorResearch == input.EducatorResearch ||
                    (this.EducatorResearch != null &&
                    this.EducatorResearch.Equals(input.EducatorResearch))
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
                if (this.GenderDescriptor != null)
                    hashCode = hashCode * 59 + this.GenderDescriptor.GetHashCode();
                if (this.OpenStaffPositionReference != null)
                    hashCode = hashCode * 59 + this.OpenStaffPositionReference.GetHashCode();
                if (this.EducatorPreparationPrograms != null)
                    hashCode = hashCode * 59 + this.EducatorPreparationPrograms.GetHashCode();
                if (this.HighlyQualifiedAcademicSubjects != null)
                    hashCode = hashCode * 59 + this.HighlyQualifiedAcademicSubjects.GetHashCode();
                if (this.EducatorResearch != null)
                    hashCode = hashCode * 59 + this.EducatorResearch.GetHashCode();
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
            // GenderDescriptor (string) maxLength
            if(this.GenderDescriptor != null && this.GenderDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for GenderDescriptor, length must be less than 306.", new [] { "GenderDescriptor" });
            }

            yield break;
        }
    }

}