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
    /// EdFiStudentNeglectedOrDelinquentProgramAssociation
    /// </summary>
    [DataContract(Name = "edFi_studentNeglectedOrDelinquentProgramAssociation")]
    public partial class EdFiStudentNeglectedOrDelinquentProgramAssociation : IEquatable<EdFiStudentNeglectedOrDelinquentProgramAssociation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentNeglectedOrDelinquentProgramAssociation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStudentNeglectedOrDelinquentProgramAssociation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentNeglectedOrDelinquentProgramAssociation" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="beginDate">The earliest date the student is involved with the program. Typically, this is the date the student becomes eligible for the program. (required).</param>
        /// <param name="educationOrganizationReference">educationOrganizationReference (required).</param>
        /// <param name="programReference">programReference (required).</param>
        /// <param name="studentReference">studentReference (required).</param>
        /// <param name="elaProgressLevelDescriptor">The progress measured from pre- to post- test for ELA..</param>
        /// <param name="endDate">The month, day, and year on which the Student exited the Program or stopped receiving services..</param>
        /// <param name="mathematicsProgressLevelDescriptor">The progress measured from pre- to post-test for Mathematics..</param>
        /// <param name="neglectedOrDelinquentProgramDescriptor">The type of program under ESEA Title I, Part D, Subpart 1 (state programs) or Subpart 2 (LEA)..</param>
        /// <param name="neglectedOrDelinquentProgramServices">An unordered collection of studentNeglectedOrDelinquentProgramAssociationNeglectedOrDelinquentProgramServices. Indicates the service(s) being provided to the Student by the Neglected or Delinquent Program..</param>
        /// <param name="participationStatus">participationStatus.</param>
        /// <param name="programParticipationStatuses">An unordered collection of generalStudentProgramAssociationProgramParticipationStatuses. The status of the student&#39;s program participation..</param>
        /// <param name="reasonExitedDescriptor">The reason the child left the Program within a school or district..</param>
        /// <param name="servedOutsideOfRegularSession">Indicates whether the Student received services during the summer session or between sessions..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        public EdFiStudentNeglectedOrDelinquentProgramAssociation(string id = default(string), DateTime beginDate = default(DateTime), EdFiEducationOrganizationReference educationOrganizationReference = default(EdFiEducationOrganizationReference), EdFiProgramReference programReference = default(EdFiProgramReference), EdFiStudentReference studentReference = default(EdFiStudentReference), string elaProgressLevelDescriptor = default(string), DateTime endDate = default(DateTime), string mathematicsProgressLevelDescriptor = default(string), string neglectedOrDelinquentProgramDescriptor = default(string), List<EdFiStudentNeglectedOrDelinquentProgramAssociationNeglectedOrDelinquentProgramService> neglectedOrDelinquentProgramServices = default(List<EdFiStudentNeglectedOrDelinquentProgramAssociationNeglectedOrDelinquentProgramService>), EdFiGeneralStudentProgramAssociationParticipationStatus participationStatus = default(EdFiGeneralStudentProgramAssociationParticipationStatus), List<EdFiGeneralStudentProgramAssociationProgramParticipationStatus> programParticipationStatuses = default(List<EdFiGeneralStudentProgramAssociationProgramParticipationStatus>), string reasonExitedDescriptor = default(string), bool servedOutsideOfRegularSession = default(bool), string etag = default(string))
        {
            this.BeginDate = beginDate;
            // to ensure "educationOrganizationReference" is required (not null)
            this.EducationOrganizationReference = educationOrganizationReference ?? throw new ArgumentNullException("educationOrganizationReference is a required property for EdFiStudentNeglectedOrDelinquentProgramAssociation and cannot be null");
            // to ensure "programReference" is required (not null)
            this.ProgramReference = programReference ?? throw new ArgumentNullException("programReference is a required property for EdFiStudentNeglectedOrDelinquentProgramAssociation and cannot be null");
            // to ensure "studentReference" is required (not null)
            this.StudentReference = studentReference ?? throw new ArgumentNullException("studentReference is a required property for EdFiStudentNeglectedOrDelinquentProgramAssociation and cannot be null");
            this.Id = id;
            this.ElaProgressLevelDescriptor = elaProgressLevelDescriptor;
            this.EndDate = endDate;
            this.MathematicsProgressLevelDescriptor = mathematicsProgressLevelDescriptor;
            this.NeglectedOrDelinquentProgramDescriptor = neglectedOrDelinquentProgramDescriptor;
            this.NeglectedOrDelinquentProgramServices = neglectedOrDelinquentProgramServices;
            this.ParticipationStatus = participationStatus;
            this.ProgramParticipationStatuses = programParticipationStatuses;
            this.ReasonExitedDescriptor = reasonExitedDescriptor;
            this.ServedOutsideOfRegularSession = servedOutsideOfRegularSession;
            this.Etag = etag;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The earliest date the student is involved with the program. Typically, this is the date the student becomes eligible for the program.
        /// </summary>
        /// <value>The earliest date the student is involved with the program. Typically, this is the date the student becomes eligible for the program.</value>
        [DataMember(Name = "beginDate", IsRequired = true, EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime BeginDate { get; set; }

        /// <summary>
        /// Gets or Sets EducationOrganizationReference
        /// </summary>
        [DataMember(Name = "educationOrganizationReference", IsRequired = true, EmitDefaultValue = false)]
        public EdFiEducationOrganizationReference EducationOrganizationReference { get; set; }

        /// <summary>
        /// Gets or Sets ProgramReference
        /// </summary>
        [DataMember(Name = "programReference", IsRequired = true, EmitDefaultValue = false)]
        public EdFiProgramReference ProgramReference { get; set; }

        /// <summary>
        /// Gets or Sets StudentReference
        /// </summary>
        [DataMember(Name = "studentReference", IsRequired = true, EmitDefaultValue = false)]
        public EdFiStudentReference StudentReference { get; set; }

        /// <summary>
        /// The progress measured from pre- to post- test for ELA.
        /// </summary>
        /// <value>The progress measured from pre- to post- test for ELA.</value>
        [DataMember(Name = "elaProgressLevelDescriptor", EmitDefaultValue = false)]
        public string ElaProgressLevelDescriptor { get; set; }

        /// <summary>
        /// The month, day, and year on which the Student exited the Program or stopped receiving services.
        /// </summary>
        /// <value>The month, day, and year on which the Student exited the Program or stopped receiving services.</value>
        [DataMember(Name = "endDate", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// The progress measured from pre- to post-test for Mathematics.
        /// </summary>
        /// <value>The progress measured from pre- to post-test for Mathematics.</value>
        [DataMember(Name = "mathematicsProgressLevelDescriptor", EmitDefaultValue = false)]
        public string MathematicsProgressLevelDescriptor { get; set; }

        /// <summary>
        /// The type of program under ESEA Title I, Part D, Subpart 1 (state programs) or Subpart 2 (LEA).
        /// </summary>
        /// <value>The type of program under ESEA Title I, Part D, Subpart 1 (state programs) or Subpart 2 (LEA).</value>
        [DataMember(Name = "neglectedOrDelinquentProgramDescriptor", EmitDefaultValue = false)]
        public string NeglectedOrDelinquentProgramDescriptor { get; set; }

        /// <summary>
        /// An unordered collection of studentNeglectedOrDelinquentProgramAssociationNeglectedOrDelinquentProgramServices. Indicates the service(s) being provided to the Student by the Neglected or Delinquent Program.
        /// </summary>
        /// <value>An unordered collection of studentNeglectedOrDelinquentProgramAssociationNeglectedOrDelinquentProgramServices. Indicates the service(s) being provided to the Student by the Neglected or Delinquent Program.</value>
        [DataMember(Name = "neglectedOrDelinquentProgramServices", EmitDefaultValue = false)]
        public List<EdFiStudentNeglectedOrDelinquentProgramAssociationNeglectedOrDelinquentProgramService> NeglectedOrDelinquentProgramServices { get; set; }

        /// <summary>
        /// Gets or Sets ParticipationStatus
        /// </summary>
        [DataMember(Name = "participationStatus", EmitDefaultValue = false)]
        public EdFiGeneralStudentProgramAssociationParticipationStatus ParticipationStatus { get; set; }

        /// <summary>
        /// An unordered collection of generalStudentProgramAssociationProgramParticipationStatuses. The status of the student&#39;s program participation.
        /// </summary>
        /// <value>An unordered collection of generalStudentProgramAssociationProgramParticipationStatuses. The status of the student&#39;s program participation.</value>
        [DataMember(Name = "programParticipationStatuses", EmitDefaultValue = false)]
        public List<EdFiGeneralStudentProgramAssociationProgramParticipationStatus> ProgramParticipationStatuses { get; set; }

        /// <summary>
        /// The reason the child left the Program within a school or district.
        /// </summary>
        /// <value>The reason the child left the Program within a school or district.</value>
        [DataMember(Name = "reasonExitedDescriptor", EmitDefaultValue = false)]
        public string ReasonExitedDescriptor { get; set; }

        /// <summary>
        /// Indicates whether the Student received services during the summer session or between sessions.
        /// </summary>
        /// <value>Indicates whether the Student received services during the summer session or between sessions.</value>
        [DataMember(Name = "servedOutsideOfRegularSession", EmitDefaultValue = true)]
        public bool ServedOutsideOfRegularSession { get; set; }

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
            sb.Append("class EdFiStudentNeglectedOrDelinquentProgramAssociation {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  BeginDate: ").Append(BeginDate).Append("\n");
            sb.Append("  EducationOrganizationReference: ").Append(EducationOrganizationReference).Append("\n");
            sb.Append("  ProgramReference: ").Append(ProgramReference).Append("\n");
            sb.Append("  StudentReference: ").Append(StudentReference).Append("\n");
            sb.Append("  ElaProgressLevelDescriptor: ").Append(ElaProgressLevelDescriptor).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  MathematicsProgressLevelDescriptor: ").Append(MathematicsProgressLevelDescriptor).Append("\n");
            sb.Append("  NeglectedOrDelinquentProgramDescriptor: ").Append(NeglectedOrDelinquentProgramDescriptor).Append("\n");
            sb.Append("  NeglectedOrDelinquentProgramServices: ").Append(NeglectedOrDelinquentProgramServices).Append("\n");
            sb.Append("  ParticipationStatus: ").Append(ParticipationStatus).Append("\n");
            sb.Append("  ProgramParticipationStatuses: ").Append(ProgramParticipationStatuses).Append("\n");
            sb.Append("  ReasonExitedDescriptor: ").Append(ReasonExitedDescriptor).Append("\n");
            sb.Append("  ServedOutsideOfRegularSession: ").Append(ServedOutsideOfRegularSession).Append("\n");
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
            return this.Equals(input as EdFiStudentNeglectedOrDelinquentProgramAssociation);
        }

        /// <summary>
        /// Returns true if EdFiStudentNeglectedOrDelinquentProgramAssociation instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiStudentNeglectedOrDelinquentProgramAssociation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiStudentNeglectedOrDelinquentProgramAssociation input)
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
                    this.BeginDate == input.BeginDate ||
                    (this.BeginDate != null &&
                    this.BeginDate.Equals(input.BeginDate))
                ) && 
                (
                    this.EducationOrganizationReference == input.EducationOrganizationReference ||
                    (this.EducationOrganizationReference != null &&
                    this.EducationOrganizationReference.Equals(input.EducationOrganizationReference))
                ) && 
                (
                    this.ProgramReference == input.ProgramReference ||
                    (this.ProgramReference != null &&
                    this.ProgramReference.Equals(input.ProgramReference))
                ) && 
                (
                    this.StudentReference == input.StudentReference ||
                    (this.StudentReference != null &&
                    this.StudentReference.Equals(input.StudentReference))
                ) && 
                (
                    this.ElaProgressLevelDescriptor == input.ElaProgressLevelDescriptor ||
                    (this.ElaProgressLevelDescriptor != null &&
                    this.ElaProgressLevelDescriptor.Equals(input.ElaProgressLevelDescriptor))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.MathematicsProgressLevelDescriptor == input.MathematicsProgressLevelDescriptor ||
                    (this.MathematicsProgressLevelDescriptor != null &&
                    this.MathematicsProgressLevelDescriptor.Equals(input.MathematicsProgressLevelDescriptor))
                ) && 
                (
                    this.NeglectedOrDelinquentProgramDescriptor == input.NeglectedOrDelinquentProgramDescriptor ||
                    (this.NeglectedOrDelinquentProgramDescriptor != null &&
                    this.NeglectedOrDelinquentProgramDescriptor.Equals(input.NeglectedOrDelinquentProgramDescriptor))
                ) && 
                (
                    this.NeglectedOrDelinquentProgramServices == input.NeglectedOrDelinquentProgramServices ||
                    this.NeglectedOrDelinquentProgramServices != null &&
                    input.NeglectedOrDelinquentProgramServices != null &&
                    this.NeglectedOrDelinquentProgramServices.SequenceEqual(input.NeglectedOrDelinquentProgramServices)
                ) && 
                (
                    this.ParticipationStatus == input.ParticipationStatus ||
                    (this.ParticipationStatus != null &&
                    this.ParticipationStatus.Equals(input.ParticipationStatus))
                ) && 
                (
                    this.ProgramParticipationStatuses == input.ProgramParticipationStatuses ||
                    this.ProgramParticipationStatuses != null &&
                    input.ProgramParticipationStatuses != null &&
                    this.ProgramParticipationStatuses.SequenceEqual(input.ProgramParticipationStatuses)
                ) && 
                (
                    this.ReasonExitedDescriptor == input.ReasonExitedDescriptor ||
                    (this.ReasonExitedDescriptor != null &&
                    this.ReasonExitedDescriptor.Equals(input.ReasonExitedDescriptor))
                ) && 
                (
                    this.ServedOutsideOfRegularSession == input.ServedOutsideOfRegularSession ||
                    this.ServedOutsideOfRegularSession.Equals(input.ServedOutsideOfRegularSession)
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
                if (this.BeginDate != null)
                    hashCode = hashCode * 59 + this.BeginDate.GetHashCode();
                if (this.EducationOrganizationReference != null)
                    hashCode = hashCode * 59 + this.EducationOrganizationReference.GetHashCode();
                if (this.ProgramReference != null)
                    hashCode = hashCode * 59 + this.ProgramReference.GetHashCode();
                if (this.StudentReference != null)
                    hashCode = hashCode * 59 + this.StudentReference.GetHashCode();
                if (this.ElaProgressLevelDescriptor != null)
                    hashCode = hashCode * 59 + this.ElaProgressLevelDescriptor.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.MathematicsProgressLevelDescriptor != null)
                    hashCode = hashCode * 59 + this.MathematicsProgressLevelDescriptor.GetHashCode();
                if (this.NeglectedOrDelinquentProgramDescriptor != null)
                    hashCode = hashCode * 59 + this.NeglectedOrDelinquentProgramDescriptor.GetHashCode();
                if (this.NeglectedOrDelinquentProgramServices != null)
                    hashCode = hashCode * 59 + this.NeglectedOrDelinquentProgramServices.GetHashCode();
                if (this.ParticipationStatus != null)
                    hashCode = hashCode * 59 + this.ParticipationStatus.GetHashCode();
                if (this.ProgramParticipationStatuses != null)
                    hashCode = hashCode * 59 + this.ProgramParticipationStatuses.GetHashCode();
                if (this.ReasonExitedDescriptor != null)
                    hashCode = hashCode * 59 + this.ReasonExitedDescriptor.GetHashCode();
                hashCode = hashCode * 59 + this.ServedOutsideOfRegularSession.GetHashCode();
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
            // ElaProgressLevelDescriptor (string) maxLength
            if(this.ElaProgressLevelDescriptor != null && this.ElaProgressLevelDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ElaProgressLevelDescriptor, length must be less than 306.", new [] { "ElaProgressLevelDescriptor" });
            }

            // MathematicsProgressLevelDescriptor (string) maxLength
            if(this.MathematicsProgressLevelDescriptor != null && this.MathematicsProgressLevelDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MathematicsProgressLevelDescriptor, length must be less than 306.", new [] { "MathematicsProgressLevelDescriptor" });
            }

            // NeglectedOrDelinquentProgramDescriptor (string) maxLength
            if(this.NeglectedOrDelinquentProgramDescriptor != null && this.NeglectedOrDelinquentProgramDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for NeglectedOrDelinquentProgramDescriptor, length must be less than 306.", new [] { "NeglectedOrDelinquentProgramDescriptor" });
            }

            // ReasonExitedDescriptor (string) maxLength
            if(this.ReasonExitedDescriptor != null && this.ReasonExitedDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReasonExitedDescriptor, length must be less than 306.", new [] { "ReasonExitedDescriptor" });
            }

            yield break;
        }
    }

}
