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
    /// EdFiStudentLearningObjective
    /// </summary>
    [DataContract(Name = "edFi_studentLearningObjective")]
    public partial class EdFiStudentLearningObjective : IEquatable<EdFiStudentLearningObjective>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentLearningObjective" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStudentLearningObjective() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentLearningObjective" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="gradingPeriodReference">gradingPeriodReference (required).</param>
        /// <param name="learningObjectiveReference">learningObjectiveReference (required).</param>
        /// <param name="studentReference">studentReference (required).</param>
        /// <param name="competencyLevelDescriptor">The CompetencyLevel assessed for the student for the referenced LearningObjective. (required).</param>
        /// <param name="diagnosticStatement">A statement provided by the teacher that provides information in addition to the grade or assessment score..</param>
        /// <param name="generalStudentProgramAssociations">An unordered collection of studentLearningObjectiveGeneralStudentProgramAssociations. Relates the Student and Program associated with the LearningObjective..</param>
        /// <param name="studentSectionAssociations">An unordered collection of studentLearningObjectiveStudentSectionAssociations. Relates the Student and Section associated with the LearningObjective..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        public EdFiStudentLearningObjective(string id = default(string), EdFiGradingPeriodReference gradingPeriodReference = default(EdFiGradingPeriodReference), EdFiLearningObjectiveReference learningObjectiveReference = default(EdFiLearningObjectiveReference), EdFiStudentReference studentReference = default(EdFiStudentReference), string competencyLevelDescriptor = default(string), string diagnosticStatement = default(string), List<EdFiStudentLearningObjectiveGeneralStudentProgramAssociation> generalStudentProgramAssociations = default(List<EdFiStudentLearningObjectiveGeneralStudentProgramAssociation>), List<EdFiStudentLearningObjectiveStudentSectionAssociation> studentSectionAssociations = default(List<EdFiStudentLearningObjectiveStudentSectionAssociation>), string etag = default(string))
        {
            // to ensure "gradingPeriodReference" is required (not null)
            this.GradingPeriodReference = gradingPeriodReference ?? throw new ArgumentNullException("gradingPeriodReference is a required property for EdFiStudentLearningObjective and cannot be null");
            // to ensure "learningObjectiveReference" is required (not null)
            this.LearningObjectiveReference = learningObjectiveReference ?? throw new ArgumentNullException("learningObjectiveReference is a required property for EdFiStudentLearningObjective and cannot be null");
            // to ensure "studentReference" is required (not null)
            this.StudentReference = studentReference ?? throw new ArgumentNullException("studentReference is a required property for EdFiStudentLearningObjective and cannot be null");
            // to ensure "competencyLevelDescriptor" is required (not null)
            this.CompetencyLevelDescriptor = competencyLevelDescriptor ?? throw new ArgumentNullException("competencyLevelDescriptor is a required property for EdFiStudentLearningObjective and cannot be null");
            this.Id = id;
            this.DiagnosticStatement = diagnosticStatement;
            this.GeneralStudentProgramAssociations = generalStudentProgramAssociations;
            this.StudentSectionAssociations = studentSectionAssociations;
            this.Etag = etag;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets GradingPeriodReference
        /// </summary>
        [DataMember(Name = "gradingPeriodReference", IsRequired = true, EmitDefaultValue = false)]
        public EdFiGradingPeriodReference GradingPeriodReference { get; set; }

        /// <summary>
        /// Gets or Sets LearningObjectiveReference
        /// </summary>
        [DataMember(Name = "learningObjectiveReference", IsRequired = true, EmitDefaultValue = false)]
        public EdFiLearningObjectiveReference LearningObjectiveReference { get; set; }

        /// <summary>
        /// Gets or Sets StudentReference
        /// </summary>
        [DataMember(Name = "studentReference", IsRequired = true, EmitDefaultValue = false)]
        public EdFiStudentReference StudentReference { get; set; }

        /// <summary>
        /// The CompetencyLevel assessed for the student for the referenced LearningObjective.
        /// </summary>
        /// <value>The CompetencyLevel assessed for the student for the referenced LearningObjective.</value>
        [DataMember(Name = "competencyLevelDescriptor", IsRequired = true, EmitDefaultValue = false)]
        public string CompetencyLevelDescriptor { get; set; }

        /// <summary>
        /// A statement provided by the teacher that provides information in addition to the grade or assessment score.
        /// </summary>
        /// <value>A statement provided by the teacher that provides information in addition to the grade or assessment score.</value>
        [DataMember(Name = "diagnosticStatement", EmitDefaultValue = false)]
        public string DiagnosticStatement { get; set; }

        /// <summary>
        /// An unordered collection of studentLearningObjectiveGeneralStudentProgramAssociations. Relates the Student and Program associated with the LearningObjective.
        /// </summary>
        /// <value>An unordered collection of studentLearningObjectiveGeneralStudentProgramAssociations. Relates the Student and Program associated with the LearningObjective.</value>
        [DataMember(Name = "generalStudentProgramAssociations", EmitDefaultValue = false)]
        public List<EdFiStudentLearningObjectiveGeneralStudentProgramAssociation> GeneralStudentProgramAssociations { get; set; }

        /// <summary>
        /// An unordered collection of studentLearningObjectiveStudentSectionAssociations. Relates the Student and Section associated with the LearningObjective.
        /// </summary>
        /// <value>An unordered collection of studentLearningObjectiveStudentSectionAssociations. Relates the Student and Section associated with the LearningObjective.</value>
        [DataMember(Name = "studentSectionAssociations", EmitDefaultValue = false)]
        public List<EdFiStudentLearningObjectiveStudentSectionAssociation> StudentSectionAssociations { get; set; }

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
            sb.Append("class EdFiStudentLearningObjective {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  GradingPeriodReference: ").Append(GradingPeriodReference).Append("\n");
            sb.Append("  LearningObjectiveReference: ").Append(LearningObjectiveReference).Append("\n");
            sb.Append("  StudentReference: ").Append(StudentReference).Append("\n");
            sb.Append("  CompetencyLevelDescriptor: ").Append(CompetencyLevelDescriptor).Append("\n");
            sb.Append("  DiagnosticStatement: ").Append(DiagnosticStatement).Append("\n");
            sb.Append("  GeneralStudentProgramAssociations: ").Append(GeneralStudentProgramAssociations).Append("\n");
            sb.Append("  StudentSectionAssociations: ").Append(StudentSectionAssociations).Append("\n");
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
            return this.Equals(input as EdFiStudentLearningObjective);
        }

        /// <summary>
        /// Returns true if EdFiStudentLearningObjective instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiStudentLearningObjective to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiStudentLearningObjective input)
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
                    this.GradingPeriodReference == input.GradingPeriodReference ||
                    (this.GradingPeriodReference != null &&
                    this.GradingPeriodReference.Equals(input.GradingPeriodReference))
                ) && 
                (
                    this.LearningObjectiveReference == input.LearningObjectiveReference ||
                    (this.LearningObjectiveReference != null &&
                    this.LearningObjectiveReference.Equals(input.LearningObjectiveReference))
                ) && 
                (
                    this.StudentReference == input.StudentReference ||
                    (this.StudentReference != null &&
                    this.StudentReference.Equals(input.StudentReference))
                ) && 
                (
                    this.CompetencyLevelDescriptor == input.CompetencyLevelDescriptor ||
                    (this.CompetencyLevelDescriptor != null &&
                    this.CompetencyLevelDescriptor.Equals(input.CompetencyLevelDescriptor))
                ) && 
                (
                    this.DiagnosticStatement == input.DiagnosticStatement ||
                    (this.DiagnosticStatement != null &&
                    this.DiagnosticStatement.Equals(input.DiagnosticStatement))
                ) && 
                (
                    this.GeneralStudentProgramAssociations == input.GeneralStudentProgramAssociations ||
                    this.GeneralStudentProgramAssociations != null &&
                    input.GeneralStudentProgramAssociations != null &&
                    this.GeneralStudentProgramAssociations.SequenceEqual(input.GeneralStudentProgramAssociations)
                ) && 
                (
                    this.StudentSectionAssociations == input.StudentSectionAssociations ||
                    this.StudentSectionAssociations != null &&
                    input.StudentSectionAssociations != null &&
                    this.StudentSectionAssociations.SequenceEqual(input.StudentSectionAssociations)
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
                if (this.GradingPeriodReference != null)
                    hashCode = hashCode * 59 + this.GradingPeriodReference.GetHashCode();
                if (this.LearningObjectiveReference != null)
                    hashCode = hashCode * 59 + this.LearningObjectiveReference.GetHashCode();
                if (this.StudentReference != null)
                    hashCode = hashCode * 59 + this.StudentReference.GetHashCode();
                if (this.CompetencyLevelDescriptor != null)
                    hashCode = hashCode * 59 + this.CompetencyLevelDescriptor.GetHashCode();
                if (this.DiagnosticStatement != null)
                    hashCode = hashCode * 59 + this.DiagnosticStatement.GetHashCode();
                if (this.GeneralStudentProgramAssociations != null)
                    hashCode = hashCode * 59 + this.GeneralStudentProgramAssociations.GetHashCode();
                if (this.StudentSectionAssociations != null)
                    hashCode = hashCode * 59 + this.StudentSectionAssociations.GetHashCode();
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
            // CompetencyLevelDescriptor (string) maxLength
            if(this.CompetencyLevelDescriptor != null && this.CompetencyLevelDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CompetencyLevelDescriptor, length must be less than 306.", new [] { "CompetencyLevelDescriptor" });
            }

            // DiagnosticStatement (string) maxLength
            if(this.DiagnosticStatement != null && this.DiagnosticStatement.Length > 1024)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DiagnosticStatement, length must be less than 1024.", new [] { "DiagnosticStatement" });
            }

            yield break;
        }
    }

}
