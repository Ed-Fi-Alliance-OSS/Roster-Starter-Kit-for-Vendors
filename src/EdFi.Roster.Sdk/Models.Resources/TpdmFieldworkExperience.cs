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
    /// TpdmFieldworkExperience
    /// </summary>
    [DataContract(Name = "tpdm_fieldworkExperience")]
    public partial class TpdmFieldworkExperience : IEquatable<TpdmFieldworkExperience>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmFieldworkExperience" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TpdmFieldworkExperience() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmFieldworkExperience" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="beginDate">The month, day, and year on which the staff first starts fieldwork. (required).</param>
        /// <param name="fieldworkIdentifier">The unique identifier for the fieldwork experience (required).</param>
        /// <param name="educatorPreparationProgramReference">educatorPreparationProgramReference.</param>
        /// <param name="schoolReference">schoolReference.</param>
        /// <param name="studentReference">studentReference (required).</param>
        /// <param name="coteaching">coteaching.</param>
        /// <param name="endDate">The month, day, and year on which the staff ends fieldwork..</param>
        /// <param name="fieldworkTypeDescriptor">The type of fieldwork being executed by a staff. (required).</param>
        /// <param name="hoursCompleted">The number of hours completed during the fieldwork experience..</param>
        /// <param name="programGatewayDescriptor">The descriptor holds the program gateway that is associated with continuation in a program..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        public TpdmFieldworkExperience(string id = default(string), DateTime beginDate = default(DateTime), string fieldworkIdentifier = default(string), TpdmEducatorPreparationProgramReference educatorPreparationProgramReference = default(TpdmEducatorPreparationProgramReference), EdFiSchoolReference schoolReference = default(EdFiSchoolReference), EdFiStudentReference studentReference = default(EdFiStudentReference), TpdmFieldworkExperienceCoteaching coteaching = default(TpdmFieldworkExperienceCoteaching), DateTime endDate = default(DateTime), string fieldworkTypeDescriptor = default(string), double hoursCompleted = default(double), string programGatewayDescriptor = default(string), string etag = default(string))
        {
            this.BeginDate = beginDate;
            // to ensure "fieldworkIdentifier" is required (not null)
            this.FieldworkIdentifier = fieldworkIdentifier ?? throw new ArgumentNullException("fieldworkIdentifier is a required property for TpdmFieldworkExperience and cannot be null");
            // to ensure "studentReference" is required (not null)
            this.StudentReference = studentReference ?? throw new ArgumentNullException("studentReference is a required property for TpdmFieldworkExperience and cannot be null");
            // to ensure "fieldworkTypeDescriptor" is required (not null)
            this.FieldworkTypeDescriptor = fieldworkTypeDescriptor ?? throw new ArgumentNullException("fieldworkTypeDescriptor is a required property for TpdmFieldworkExperience and cannot be null");
            this.Id = id;
            this.EducatorPreparationProgramReference = educatorPreparationProgramReference;
            this.SchoolReference = schoolReference;
            this.Coteaching = coteaching;
            this.EndDate = endDate;
            this.HoursCompleted = hoursCompleted;
            this.ProgramGatewayDescriptor = programGatewayDescriptor;
            this.Etag = etag;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The month, day, and year on which the staff first starts fieldwork.
        /// </summary>
        /// <value>The month, day, and year on which the staff first starts fieldwork.</value>
        [DataMember(Name = "beginDate", IsRequired = true, EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime BeginDate { get; set; }

        /// <summary>
        /// The unique identifier for the fieldwork experience
        /// </summary>
        /// <value>The unique identifier for the fieldwork experience</value>
        [DataMember(Name = "fieldworkIdentifier", IsRequired = true, EmitDefaultValue = false)]
        public string FieldworkIdentifier { get; set; }

        /// <summary>
        /// Gets or Sets EducatorPreparationProgramReference
        /// </summary>
        [DataMember(Name = "educatorPreparationProgramReference", EmitDefaultValue = false)]
        public TpdmEducatorPreparationProgramReference EducatorPreparationProgramReference { get; set; }

        /// <summary>
        /// Gets or Sets SchoolReference
        /// </summary>
        [DataMember(Name = "schoolReference", EmitDefaultValue = false)]
        public EdFiSchoolReference SchoolReference { get; set; }

        /// <summary>
        /// Gets or Sets StudentReference
        /// </summary>
        [DataMember(Name = "studentReference", IsRequired = true, EmitDefaultValue = false)]
        public EdFiStudentReference StudentReference { get; set; }

        /// <summary>
        /// Gets or Sets Coteaching
        /// </summary>
        [DataMember(Name = "coteaching", EmitDefaultValue = false)]
        public TpdmFieldworkExperienceCoteaching Coteaching { get; set; }

        /// <summary>
        /// The month, day, and year on which the staff ends fieldwork.
        /// </summary>
        /// <value>The month, day, and year on which the staff ends fieldwork.</value>
        [DataMember(Name = "endDate", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// The type of fieldwork being executed by a staff.
        /// </summary>
        /// <value>The type of fieldwork being executed by a staff.</value>
        [DataMember(Name = "fieldworkTypeDescriptor", IsRequired = true, EmitDefaultValue = false)]
        public string FieldworkTypeDescriptor { get; set; }

        /// <summary>
        /// The number of hours completed during the fieldwork experience.
        /// </summary>
        /// <value>The number of hours completed during the fieldwork experience.</value>
        [DataMember(Name = "hoursCompleted", EmitDefaultValue = false)]
        public double HoursCompleted { get; set; }

        /// <summary>
        /// The descriptor holds the program gateway that is associated with continuation in a program.
        /// </summary>
        /// <value>The descriptor holds the program gateway that is associated with continuation in a program.</value>
        [DataMember(Name = "programGatewayDescriptor", EmitDefaultValue = false)]
        public string ProgramGatewayDescriptor { get; set; }

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
            sb.Append("class TpdmFieldworkExperience {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  BeginDate: ").Append(BeginDate).Append("\n");
            sb.Append("  FieldworkIdentifier: ").Append(FieldworkIdentifier).Append("\n");
            sb.Append("  EducatorPreparationProgramReference: ").Append(EducatorPreparationProgramReference).Append("\n");
            sb.Append("  SchoolReference: ").Append(SchoolReference).Append("\n");
            sb.Append("  StudentReference: ").Append(StudentReference).Append("\n");
            sb.Append("  Coteaching: ").Append(Coteaching).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  FieldworkTypeDescriptor: ").Append(FieldworkTypeDescriptor).Append("\n");
            sb.Append("  HoursCompleted: ").Append(HoursCompleted).Append("\n");
            sb.Append("  ProgramGatewayDescriptor: ").Append(ProgramGatewayDescriptor).Append("\n");
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
            return this.Equals(input as TpdmFieldworkExperience);
        }

        /// <summary>
        /// Returns true if TpdmFieldworkExperience instances are equal
        /// </summary>
        /// <param name="input">Instance of TpdmFieldworkExperience to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TpdmFieldworkExperience input)
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
                    this.FieldworkIdentifier == input.FieldworkIdentifier ||
                    (this.FieldworkIdentifier != null &&
                    this.FieldworkIdentifier.Equals(input.FieldworkIdentifier))
                ) && 
                (
                    this.EducatorPreparationProgramReference == input.EducatorPreparationProgramReference ||
                    (this.EducatorPreparationProgramReference != null &&
                    this.EducatorPreparationProgramReference.Equals(input.EducatorPreparationProgramReference))
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
                    this.Coteaching == input.Coteaching ||
                    (this.Coteaching != null &&
                    this.Coteaching.Equals(input.Coteaching))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.FieldworkTypeDescriptor == input.FieldworkTypeDescriptor ||
                    (this.FieldworkTypeDescriptor != null &&
                    this.FieldworkTypeDescriptor.Equals(input.FieldworkTypeDescriptor))
                ) && 
                (
                    this.HoursCompleted == input.HoursCompleted ||
                    this.HoursCompleted.Equals(input.HoursCompleted)
                ) && 
                (
                    this.ProgramGatewayDescriptor == input.ProgramGatewayDescriptor ||
                    (this.ProgramGatewayDescriptor != null &&
                    this.ProgramGatewayDescriptor.Equals(input.ProgramGatewayDescriptor))
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
                if (this.FieldworkIdentifier != null)
                    hashCode = hashCode * 59 + this.FieldworkIdentifier.GetHashCode();
                if (this.EducatorPreparationProgramReference != null)
                    hashCode = hashCode * 59 + this.EducatorPreparationProgramReference.GetHashCode();
                if (this.SchoolReference != null)
                    hashCode = hashCode * 59 + this.SchoolReference.GetHashCode();
                if (this.StudentReference != null)
                    hashCode = hashCode * 59 + this.StudentReference.GetHashCode();
                if (this.Coteaching != null)
                    hashCode = hashCode * 59 + this.Coteaching.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.FieldworkTypeDescriptor != null)
                    hashCode = hashCode * 59 + this.FieldworkTypeDescriptor.GetHashCode();
                hashCode = hashCode * 59 + this.HoursCompleted.GetHashCode();
                if (this.ProgramGatewayDescriptor != null)
                    hashCode = hashCode * 59 + this.ProgramGatewayDescriptor.GetHashCode();
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
            // FieldworkIdentifier (string) maxLength
            if(this.FieldworkIdentifier != null && this.FieldworkIdentifier.Length > 64)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FieldworkIdentifier, length must be less than 64.", new [] { "FieldworkIdentifier" });
            }

            // FieldworkTypeDescriptor (string) maxLength
            if(this.FieldworkTypeDescriptor != null && this.FieldworkTypeDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FieldworkTypeDescriptor, length must be less than 306.", new [] { "FieldworkTypeDescriptor" });
            }

            // ProgramGatewayDescriptor (string) maxLength
            if(this.ProgramGatewayDescriptor != null && this.ProgramGatewayDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ProgramGatewayDescriptor, length must be less than 306.", new [] { "ProgramGatewayDescriptor" });
            }

            yield break;
        }
    }

}