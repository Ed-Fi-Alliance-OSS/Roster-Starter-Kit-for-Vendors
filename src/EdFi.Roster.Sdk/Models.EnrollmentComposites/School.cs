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
    /// School
    /// </summary>
    [DataContract(Name = "school")]
    public partial class School : IEquatable<School>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="School" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected School() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="School" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="educationOrganizationCategories">An unordered collection of educationOrganizationCategories.  (required).</param>
        /// <param name="gradeLevels">An unordered collection of schoolGradeLevels.  (required).</param>
        /// <param name="schoolId">The identifier assigned to a school. (required).</param>
        /// <param name="addresses">An unordered collection of educationOrganizationAddresses. .</param>
        /// <param name="identificationCodes">An unordered collection of educationOrganizationIdentificationCodes. .</param>
        /// <param name="institutionTelephones">An unordered collection of educationOrganizationInstitutionTelephones. .</param>
        /// <param name="localEducationAgency">localEducationAgency.</param>
        /// <param name="nameOfInstitution">The full, legally accepted name of the institution. (required).</param>
        /// <param name="schoolCategories">An unordered collection of schoolCategories. .</param>
        /// <param name="schoolTypeDescriptor">The type of education institution as classified by its primary focus..</param>
        /// <param name="shortNameOfInstitution">A short name for the institution..</param>
        /// <param name="webSite">The public web site address (URL) for the EducationOrganization..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        public School(string id = default(string), List<SchoolEducationOrganizationCategory> educationOrganizationCategories = default(List<SchoolEducationOrganizationCategory>), List<SchoolSchoolGradeLevel> gradeLevels = default(List<SchoolSchoolGradeLevel>), int schoolId = default(int), List<SchoolEducationOrganizationAddress> addresses = default(List<SchoolEducationOrganizationAddress>), List<SchoolEducationOrganizationIdentificationCode> identificationCodes = default(List<SchoolEducationOrganizationIdentificationCode>), List<SchoolEducationOrganizationInstitutionTelephone> institutionTelephones = default(List<SchoolEducationOrganizationInstitutionTelephone>), SchoolLocalEducationAgency localEducationAgency = default(SchoolLocalEducationAgency), string nameOfInstitution = default(string), List<SchoolSchoolCategory> schoolCategories = default(List<SchoolSchoolCategory>), string schoolTypeDescriptor = default(string), string shortNameOfInstitution = default(string), string webSite = default(string), string etag = default(string))
        {
            // to ensure "educationOrganizationCategories" is required (not null)
            this.EducationOrganizationCategories = educationOrganizationCategories ?? throw new ArgumentNullException("educationOrganizationCategories is a required property for School and cannot be null");
            // to ensure "gradeLevels" is required (not null)
            this.GradeLevels = gradeLevels ?? throw new ArgumentNullException("gradeLevels is a required property for School and cannot be null");
            this.SchoolId = schoolId;
            // to ensure "nameOfInstitution" is required (not null)
            this.NameOfInstitution = nameOfInstitution ?? throw new ArgumentNullException("nameOfInstitution is a required property for School and cannot be null");
            this.Id = id;
            this.Addresses = addresses;
            this.IdentificationCodes = identificationCodes;
            this.InstitutionTelephones = institutionTelephones;
            this.LocalEducationAgency = localEducationAgency;
            this.SchoolCategories = schoolCategories;
            this.SchoolTypeDescriptor = schoolTypeDescriptor;
            this.ShortNameOfInstitution = shortNameOfInstitution;
            this.WebSite = webSite;
            this.Etag = etag;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// An unordered collection of educationOrganizationCategories. 
        /// </summary>
        /// <value>An unordered collection of educationOrganizationCategories. </value>
        [DataMember(Name = "educationOrganizationCategories", IsRequired = true, EmitDefaultValue = false)]
        public List<SchoolEducationOrganizationCategory> EducationOrganizationCategories { get; set; }

        /// <summary>
        /// An unordered collection of schoolGradeLevels. 
        /// </summary>
        /// <value>An unordered collection of schoolGradeLevels. </value>
        [DataMember(Name = "gradeLevels", IsRequired = true, EmitDefaultValue = false)]
        public List<SchoolSchoolGradeLevel> GradeLevels { get; set; }

        /// <summary>
        /// The identifier assigned to a school.
        /// </summary>
        /// <value>The identifier assigned to a school.</value>
        [DataMember(Name = "schoolId", IsRequired = true, EmitDefaultValue = false)]
        public int SchoolId { get; set; }

        /// <summary>
        /// An unordered collection of educationOrganizationAddresses. 
        /// </summary>
        /// <value>An unordered collection of educationOrganizationAddresses. </value>
        [DataMember(Name = "addresses", EmitDefaultValue = false)]
        public List<SchoolEducationOrganizationAddress> Addresses { get; set; }

        /// <summary>
        /// An unordered collection of educationOrganizationIdentificationCodes. 
        /// </summary>
        /// <value>An unordered collection of educationOrganizationIdentificationCodes. </value>
        [DataMember(Name = "identificationCodes", EmitDefaultValue = false)]
        public List<SchoolEducationOrganizationIdentificationCode> IdentificationCodes { get; set; }

        /// <summary>
        /// An unordered collection of educationOrganizationInstitutionTelephones. 
        /// </summary>
        /// <value>An unordered collection of educationOrganizationInstitutionTelephones. </value>
        [DataMember(Name = "institutionTelephones", EmitDefaultValue = false)]
        public List<SchoolEducationOrganizationInstitutionTelephone> InstitutionTelephones { get; set; }

        /// <summary>
        /// Gets or Sets LocalEducationAgency
        /// </summary>
        [DataMember(Name = "localEducationAgency", EmitDefaultValue = false)]
        public SchoolLocalEducationAgency LocalEducationAgency { get; set; }

        /// <summary>
        /// The full, legally accepted name of the institution.
        /// </summary>
        /// <value>The full, legally accepted name of the institution.</value>
        [DataMember(Name = "nameOfInstitution", IsRequired = true, EmitDefaultValue = false)]
        public string NameOfInstitution { get; set; }

        /// <summary>
        /// An unordered collection of schoolCategories. 
        /// </summary>
        /// <value>An unordered collection of schoolCategories. </value>
        [DataMember(Name = "schoolCategories", EmitDefaultValue = false)]
        public List<SchoolSchoolCategory> SchoolCategories { get; set; }

        /// <summary>
        /// The type of education institution as classified by its primary focus.
        /// </summary>
        /// <value>The type of education institution as classified by its primary focus.</value>
        [DataMember(Name = "schoolTypeDescriptor", EmitDefaultValue = false)]
        public string SchoolTypeDescriptor { get; set; }

        /// <summary>
        /// A short name for the institution.
        /// </summary>
        /// <value>A short name for the institution.</value>
        [DataMember(Name = "shortNameOfInstitution", EmitDefaultValue = false)]
        public string ShortNameOfInstitution { get; set; }

        /// <summary>
        /// The public web site address (URL) for the EducationOrganization.
        /// </summary>
        /// <value>The public web site address (URL) for the EducationOrganization.</value>
        [DataMember(Name = "webSite", EmitDefaultValue = false)]
        public string WebSite { get; set; }

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
            sb.Append("class School {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  EducationOrganizationCategories: ").Append(EducationOrganizationCategories).Append("\n");
            sb.Append("  GradeLevels: ").Append(GradeLevels).Append("\n");
            sb.Append("  SchoolId: ").Append(SchoolId).Append("\n");
            sb.Append("  Addresses: ").Append(Addresses).Append("\n");
            sb.Append("  IdentificationCodes: ").Append(IdentificationCodes).Append("\n");
            sb.Append("  InstitutionTelephones: ").Append(InstitutionTelephones).Append("\n");
            sb.Append("  LocalEducationAgency: ").Append(LocalEducationAgency).Append("\n");
            sb.Append("  NameOfInstitution: ").Append(NameOfInstitution).Append("\n");
            sb.Append("  SchoolCategories: ").Append(SchoolCategories).Append("\n");
            sb.Append("  SchoolTypeDescriptor: ").Append(SchoolTypeDescriptor).Append("\n");
            sb.Append("  ShortNameOfInstitution: ").Append(ShortNameOfInstitution).Append("\n");
            sb.Append("  WebSite: ").Append(WebSite).Append("\n");
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
            return this.Equals(input as School);
        }

        /// <summary>
        /// Returns true if School instances are equal
        /// </summary>
        /// <param name="input">Instance of School to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(School input)
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
                    this.EducationOrganizationCategories == input.EducationOrganizationCategories ||
                    this.EducationOrganizationCategories != null &&
                    input.EducationOrganizationCategories != null &&
                    this.EducationOrganizationCategories.SequenceEqual(input.EducationOrganizationCategories)
                ) && 
                (
                    this.GradeLevels == input.GradeLevels ||
                    this.GradeLevels != null &&
                    input.GradeLevels != null &&
                    this.GradeLevels.SequenceEqual(input.GradeLevels)
                ) && 
                (
                    this.SchoolId == input.SchoolId ||
                    this.SchoolId.Equals(input.SchoolId)
                ) && 
                (
                    this.Addresses == input.Addresses ||
                    this.Addresses != null &&
                    input.Addresses != null &&
                    this.Addresses.SequenceEqual(input.Addresses)
                ) && 
                (
                    this.IdentificationCodes == input.IdentificationCodes ||
                    this.IdentificationCodes != null &&
                    input.IdentificationCodes != null &&
                    this.IdentificationCodes.SequenceEqual(input.IdentificationCodes)
                ) && 
                (
                    this.InstitutionTelephones == input.InstitutionTelephones ||
                    this.InstitutionTelephones != null &&
                    input.InstitutionTelephones != null &&
                    this.InstitutionTelephones.SequenceEqual(input.InstitutionTelephones)
                ) && 
                (
                    this.LocalEducationAgency == input.LocalEducationAgency ||
                    (this.LocalEducationAgency != null &&
                    this.LocalEducationAgency.Equals(input.LocalEducationAgency))
                ) && 
                (
                    this.NameOfInstitution == input.NameOfInstitution ||
                    (this.NameOfInstitution != null &&
                    this.NameOfInstitution.Equals(input.NameOfInstitution))
                ) && 
                (
                    this.SchoolCategories == input.SchoolCategories ||
                    this.SchoolCategories != null &&
                    input.SchoolCategories != null &&
                    this.SchoolCategories.SequenceEqual(input.SchoolCategories)
                ) && 
                (
                    this.SchoolTypeDescriptor == input.SchoolTypeDescriptor ||
                    (this.SchoolTypeDescriptor != null &&
                    this.SchoolTypeDescriptor.Equals(input.SchoolTypeDescriptor))
                ) && 
                (
                    this.ShortNameOfInstitution == input.ShortNameOfInstitution ||
                    (this.ShortNameOfInstitution != null &&
                    this.ShortNameOfInstitution.Equals(input.ShortNameOfInstitution))
                ) && 
                (
                    this.WebSite == input.WebSite ||
                    (this.WebSite != null &&
                    this.WebSite.Equals(input.WebSite))
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
                if (this.EducationOrganizationCategories != null)
                    hashCode = hashCode * 59 + this.EducationOrganizationCategories.GetHashCode();
                if (this.GradeLevels != null)
                    hashCode = hashCode * 59 + this.GradeLevels.GetHashCode();
                hashCode = hashCode * 59 + this.SchoolId.GetHashCode();
                if (this.Addresses != null)
                    hashCode = hashCode * 59 + this.Addresses.GetHashCode();
                if (this.IdentificationCodes != null)
                    hashCode = hashCode * 59 + this.IdentificationCodes.GetHashCode();
                if (this.InstitutionTelephones != null)
                    hashCode = hashCode * 59 + this.InstitutionTelephones.GetHashCode();
                if (this.LocalEducationAgency != null)
                    hashCode = hashCode * 59 + this.LocalEducationAgency.GetHashCode();
                if (this.NameOfInstitution != null)
                    hashCode = hashCode * 59 + this.NameOfInstitution.GetHashCode();
                if (this.SchoolCategories != null)
                    hashCode = hashCode * 59 + this.SchoolCategories.GetHashCode();
                if (this.SchoolTypeDescriptor != null)
                    hashCode = hashCode * 59 + this.SchoolTypeDescriptor.GetHashCode();
                if (this.ShortNameOfInstitution != null)
                    hashCode = hashCode * 59 + this.ShortNameOfInstitution.GetHashCode();
                if (this.WebSite != null)
                    hashCode = hashCode * 59 + this.WebSite.GetHashCode();
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
            // NameOfInstitution (string) maxLength
            if(this.NameOfInstitution != null && this.NameOfInstitution.Length > 75)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for NameOfInstitution, length must be less than 75.", new [] { "NameOfInstitution" });
            }

            // SchoolTypeDescriptor (string) maxLength
            if(this.SchoolTypeDescriptor != null && this.SchoolTypeDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SchoolTypeDescriptor, length must be less than 306.", new [] { "SchoolTypeDescriptor" });
            }

            // ShortNameOfInstitution (string) maxLength
            if(this.ShortNameOfInstitution != null && this.ShortNameOfInstitution.Length > 75)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ShortNameOfInstitution, length must be less than 75.", new [] { "ShortNameOfInstitution" });
            }

            // WebSite (string) maxLength
            if(this.WebSite != null && this.WebSite.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for WebSite, length must be less than 255.", new [] { "WebSite" });
            }

            yield break;
        }
    }

}
