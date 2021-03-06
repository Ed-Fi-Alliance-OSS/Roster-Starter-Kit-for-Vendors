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
    /// LocalEducationAgency
    /// </summary>
    [DataContract(Name = "localEducationAgency")]
    public partial class LocalEducationAgency : IEquatable<LocalEducationAgency>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LocalEducationAgency" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LocalEducationAgency() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LocalEducationAgency" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="localEducationAgencyId">The identifier assigned to a local education agency. (required).</param>
        /// <param name="addresses">An unordered collection of educationOrganizationAddresses. .</param>
        /// <param name="charterStatusDescriptor">A school or agency providing free public elementary or secondary education to eligible students under a specific charter granted by the state legislature or other appropriate authority and designated by such authority to be a charter school..</param>
        /// <param name="identificationCodes">An unordered collection of educationOrganizationIdentificationCodes. .</param>
        /// <param name="institutionTelephones">An unordered collection of educationOrganizationInstitutionTelephones. .</param>
        /// <param name="localEducationAgencyCategoryDescriptor">The category of local education agency/district. For example: Independent or Charter. (required).</param>
        /// <param name="nameOfInstitution">The full, legally accepted name of the institution. (required).</param>
        /// <param name="shortNameOfInstitution">A short name for the institution..</param>
        /// <param name="stateEducationAgencyId">The identifier assigned to a state education agency..</param>
        /// <param name="webSite">The public web site address (URL) for the EducationOrganization..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        public LocalEducationAgency(string id = default(string), int localEducationAgencyId = default(int), List<LocalEducationAgencyEducationOrganizationAddress> addresses = default(List<LocalEducationAgencyEducationOrganizationAddress>), string charterStatusDescriptor = default(string), List<LocalEducationAgencyEducationOrganizationIdentificationCode> identificationCodes = default(List<LocalEducationAgencyEducationOrganizationIdentificationCode>), List<LocalEducationAgencyEducationOrganizationInstitutionTelephone> institutionTelephones = default(List<LocalEducationAgencyEducationOrganizationInstitutionTelephone>), string localEducationAgencyCategoryDescriptor = default(string), string nameOfInstitution = default(string), string shortNameOfInstitution = default(string), int stateEducationAgencyId = default(int), string webSite = default(string), string etag = default(string))
        {
            this.LocalEducationAgencyId = localEducationAgencyId;
            // to ensure "localEducationAgencyCategoryDescriptor" is required (not null)
            this.LocalEducationAgencyCategoryDescriptor = localEducationAgencyCategoryDescriptor ?? throw new ArgumentNullException("localEducationAgencyCategoryDescriptor is a required property for LocalEducationAgency and cannot be null");
            // to ensure "nameOfInstitution" is required (not null)
            this.NameOfInstitution = nameOfInstitution ?? throw new ArgumentNullException("nameOfInstitution is a required property for LocalEducationAgency and cannot be null");
            this.Id = id;
            this.Addresses = addresses;
            this.CharterStatusDescriptor = charterStatusDescriptor;
            this.IdentificationCodes = identificationCodes;
            this.InstitutionTelephones = institutionTelephones;
            this.ShortNameOfInstitution = shortNameOfInstitution;
            this.StateEducationAgencyId = stateEducationAgencyId;
            this.WebSite = webSite;
            this.Etag = etag;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The identifier assigned to a local education agency.
        /// </summary>
        /// <value>The identifier assigned to a local education agency.</value>
        [DataMember(Name = "localEducationAgencyId", IsRequired = true, EmitDefaultValue = false)]
        public int LocalEducationAgencyId { get; set; }

        /// <summary>
        /// An unordered collection of educationOrganizationAddresses. 
        /// </summary>
        /// <value>An unordered collection of educationOrganizationAddresses. </value>
        [DataMember(Name = "addresses", EmitDefaultValue = false)]
        public List<LocalEducationAgencyEducationOrganizationAddress> Addresses { get; set; }

        /// <summary>
        /// A school or agency providing free public elementary or secondary education to eligible students under a specific charter granted by the state legislature or other appropriate authority and designated by such authority to be a charter school.
        /// </summary>
        /// <value>A school or agency providing free public elementary or secondary education to eligible students under a specific charter granted by the state legislature or other appropriate authority and designated by such authority to be a charter school.</value>
        [DataMember(Name = "charterStatusDescriptor", EmitDefaultValue = false)]
        public string CharterStatusDescriptor { get; set; }

        /// <summary>
        /// An unordered collection of educationOrganizationIdentificationCodes. 
        /// </summary>
        /// <value>An unordered collection of educationOrganizationIdentificationCodes. </value>
        [DataMember(Name = "identificationCodes", EmitDefaultValue = false)]
        public List<LocalEducationAgencyEducationOrganizationIdentificationCode> IdentificationCodes { get; set; }

        /// <summary>
        /// An unordered collection of educationOrganizationInstitutionTelephones. 
        /// </summary>
        /// <value>An unordered collection of educationOrganizationInstitutionTelephones. </value>
        [DataMember(Name = "institutionTelephones", EmitDefaultValue = false)]
        public List<LocalEducationAgencyEducationOrganizationInstitutionTelephone> InstitutionTelephones { get; set; }

        /// <summary>
        /// The category of local education agency/district. For example: Independent or Charter.
        /// </summary>
        /// <value>The category of local education agency/district. For example: Independent or Charter.</value>
        [DataMember(Name = "localEducationAgencyCategoryDescriptor", IsRequired = true, EmitDefaultValue = false)]
        public string LocalEducationAgencyCategoryDescriptor { get; set; }

        /// <summary>
        /// The full, legally accepted name of the institution.
        /// </summary>
        /// <value>The full, legally accepted name of the institution.</value>
        [DataMember(Name = "nameOfInstitution", IsRequired = true, EmitDefaultValue = false)]
        public string NameOfInstitution { get; set; }

        /// <summary>
        /// A short name for the institution.
        /// </summary>
        /// <value>A short name for the institution.</value>
        [DataMember(Name = "shortNameOfInstitution", EmitDefaultValue = false)]
        public string ShortNameOfInstitution { get; set; }

        /// <summary>
        /// The identifier assigned to a state education agency.
        /// </summary>
        /// <value>The identifier assigned to a state education agency.</value>
        [DataMember(Name = "stateEducationAgencyId", EmitDefaultValue = false)]
        public int StateEducationAgencyId { get; set; }

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
            sb.Append("class LocalEducationAgency {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LocalEducationAgencyId: ").Append(LocalEducationAgencyId).Append("\n");
            sb.Append("  Addresses: ").Append(Addresses).Append("\n");
            sb.Append("  CharterStatusDescriptor: ").Append(CharterStatusDescriptor).Append("\n");
            sb.Append("  IdentificationCodes: ").Append(IdentificationCodes).Append("\n");
            sb.Append("  InstitutionTelephones: ").Append(InstitutionTelephones).Append("\n");
            sb.Append("  LocalEducationAgencyCategoryDescriptor: ").Append(LocalEducationAgencyCategoryDescriptor).Append("\n");
            sb.Append("  NameOfInstitution: ").Append(NameOfInstitution).Append("\n");
            sb.Append("  ShortNameOfInstitution: ").Append(ShortNameOfInstitution).Append("\n");
            sb.Append("  StateEducationAgencyId: ").Append(StateEducationAgencyId).Append("\n");
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
            return this.Equals(input as LocalEducationAgency);
        }

        /// <summary>
        /// Returns true if LocalEducationAgency instances are equal
        /// </summary>
        /// <param name="input">Instance of LocalEducationAgency to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LocalEducationAgency input)
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
                    this.LocalEducationAgencyId == input.LocalEducationAgencyId ||
                    this.LocalEducationAgencyId.Equals(input.LocalEducationAgencyId)
                ) && 
                (
                    this.Addresses == input.Addresses ||
                    this.Addresses != null &&
                    input.Addresses != null &&
                    this.Addresses.SequenceEqual(input.Addresses)
                ) && 
                (
                    this.CharterStatusDescriptor == input.CharterStatusDescriptor ||
                    (this.CharterStatusDescriptor != null &&
                    this.CharterStatusDescriptor.Equals(input.CharterStatusDescriptor))
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
                    this.LocalEducationAgencyCategoryDescriptor == input.LocalEducationAgencyCategoryDescriptor ||
                    (this.LocalEducationAgencyCategoryDescriptor != null &&
                    this.LocalEducationAgencyCategoryDescriptor.Equals(input.LocalEducationAgencyCategoryDescriptor))
                ) && 
                (
                    this.NameOfInstitution == input.NameOfInstitution ||
                    (this.NameOfInstitution != null &&
                    this.NameOfInstitution.Equals(input.NameOfInstitution))
                ) && 
                (
                    this.ShortNameOfInstitution == input.ShortNameOfInstitution ||
                    (this.ShortNameOfInstitution != null &&
                    this.ShortNameOfInstitution.Equals(input.ShortNameOfInstitution))
                ) && 
                (
                    this.StateEducationAgencyId == input.StateEducationAgencyId ||
                    this.StateEducationAgencyId.Equals(input.StateEducationAgencyId)
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
                hashCode = hashCode * 59 + this.LocalEducationAgencyId.GetHashCode();
                if (this.Addresses != null)
                    hashCode = hashCode * 59 + this.Addresses.GetHashCode();
                if (this.CharterStatusDescriptor != null)
                    hashCode = hashCode * 59 + this.CharterStatusDescriptor.GetHashCode();
                if (this.IdentificationCodes != null)
                    hashCode = hashCode * 59 + this.IdentificationCodes.GetHashCode();
                if (this.InstitutionTelephones != null)
                    hashCode = hashCode * 59 + this.InstitutionTelephones.GetHashCode();
                if (this.LocalEducationAgencyCategoryDescriptor != null)
                    hashCode = hashCode * 59 + this.LocalEducationAgencyCategoryDescriptor.GetHashCode();
                if (this.NameOfInstitution != null)
                    hashCode = hashCode * 59 + this.NameOfInstitution.GetHashCode();
                if (this.ShortNameOfInstitution != null)
                    hashCode = hashCode * 59 + this.ShortNameOfInstitution.GetHashCode();
                hashCode = hashCode * 59 + this.StateEducationAgencyId.GetHashCode();
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
            // CharterStatusDescriptor (string) maxLength
            if(this.CharterStatusDescriptor != null && this.CharterStatusDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CharterStatusDescriptor, length must be less than 306.", new [] { "CharterStatusDescriptor" });
            }

            // LocalEducationAgencyCategoryDescriptor (string) maxLength
            if(this.LocalEducationAgencyCategoryDescriptor != null && this.LocalEducationAgencyCategoryDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LocalEducationAgencyCategoryDescriptor, length must be less than 306.", new [] { "LocalEducationAgencyCategoryDescriptor" });
            }

            // NameOfInstitution (string) maxLength
            if(this.NameOfInstitution != null && this.NameOfInstitution.Length > 75)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for NameOfInstitution, length must be less than 75.", new [] { "NameOfInstitution" });
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
