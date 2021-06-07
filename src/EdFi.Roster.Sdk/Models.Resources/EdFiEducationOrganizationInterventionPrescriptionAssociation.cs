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
    /// EdFiEducationOrganizationInterventionPrescriptionAssociation
    /// </summary>
    [DataContract(Name = "edFi_educationOrganizationInterventionPrescriptionAssociation")]
    public partial class EdFiEducationOrganizationInterventionPrescriptionAssociation : IEquatable<EdFiEducationOrganizationInterventionPrescriptionAssociation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiEducationOrganizationInterventionPrescriptionAssociation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiEducationOrganizationInterventionPrescriptionAssociation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiEducationOrganizationInterventionPrescriptionAssociation" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="educationOrganizationReference">educationOrganizationReference (required).</param>
        /// <param name="interventionPrescriptionReference">interventionPrescriptionReference (required).</param>
        /// <param name="beginDate">The begin date of the period during which the InterventionPrescription is available..</param>
        /// <param name="endDate">The end date of the period during which the InterventionPrescription is available..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        public EdFiEducationOrganizationInterventionPrescriptionAssociation(string id = default(string), EdFiEducationOrganizationReference educationOrganizationReference = default(EdFiEducationOrganizationReference), EdFiInterventionPrescriptionReference interventionPrescriptionReference = default(EdFiInterventionPrescriptionReference), DateTime beginDate = default(DateTime), DateTime endDate = default(DateTime), string etag = default(string))
        {
            // to ensure "educationOrganizationReference" is required (not null)
            this.EducationOrganizationReference = educationOrganizationReference ?? throw new ArgumentNullException("educationOrganizationReference is a required property for EdFiEducationOrganizationInterventionPrescriptionAssociation and cannot be null");
            // to ensure "interventionPrescriptionReference" is required (not null)
            this.InterventionPrescriptionReference = interventionPrescriptionReference ?? throw new ArgumentNullException("interventionPrescriptionReference is a required property for EdFiEducationOrganizationInterventionPrescriptionAssociation and cannot be null");
            this.Id = id;
            this.BeginDate = beginDate;
            this.EndDate = endDate;
            this.Etag = etag;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets EducationOrganizationReference
        /// </summary>
        [DataMember(Name = "educationOrganizationReference", IsRequired = true, EmitDefaultValue = false)]
        public EdFiEducationOrganizationReference EducationOrganizationReference { get; set; }

        /// <summary>
        /// Gets or Sets InterventionPrescriptionReference
        /// </summary>
        [DataMember(Name = "interventionPrescriptionReference", IsRequired = true, EmitDefaultValue = false)]
        public EdFiInterventionPrescriptionReference InterventionPrescriptionReference { get; set; }

        /// <summary>
        /// The begin date of the period during which the InterventionPrescription is available.
        /// </summary>
        /// <value>The begin date of the period during which the InterventionPrescription is available.</value>
        [DataMember(Name = "beginDate", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime BeginDate { get; set; }

        /// <summary>
        /// The end date of the period during which the InterventionPrescription is available.
        /// </summary>
        /// <value>The end date of the period during which the InterventionPrescription is available.</value>
        [DataMember(Name = "endDate", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime EndDate { get; set; }

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
            sb.Append("class EdFiEducationOrganizationInterventionPrescriptionAssociation {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  EducationOrganizationReference: ").Append(EducationOrganizationReference).Append("\n");
            sb.Append("  InterventionPrescriptionReference: ").Append(InterventionPrescriptionReference).Append("\n");
            sb.Append("  BeginDate: ").Append(BeginDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
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
            return this.Equals(input as EdFiEducationOrganizationInterventionPrescriptionAssociation);
        }

        /// <summary>
        /// Returns true if EdFiEducationOrganizationInterventionPrescriptionAssociation instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiEducationOrganizationInterventionPrescriptionAssociation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiEducationOrganizationInterventionPrescriptionAssociation input)
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
                    this.EducationOrganizationReference == input.EducationOrganizationReference ||
                    (this.EducationOrganizationReference != null &&
                    this.EducationOrganizationReference.Equals(input.EducationOrganizationReference))
                ) && 
                (
                    this.InterventionPrescriptionReference == input.InterventionPrescriptionReference ||
                    (this.InterventionPrescriptionReference != null &&
                    this.InterventionPrescriptionReference.Equals(input.InterventionPrescriptionReference))
                ) && 
                (
                    this.BeginDate == input.BeginDate ||
                    (this.BeginDate != null &&
                    this.BeginDate.Equals(input.BeginDate))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
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
                if (this.EducationOrganizationReference != null)
                    hashCode = hashCode * 59 + this.EducationOrganizationReference.GetHashCode();
                if (this.InterventionPrescriptionReference != null)
                    hashCode = hashCode * 59 + this.InterventionPrescriptionReference.GetHashCode();
                if (this.BeginDate != null)
                    hashCode = hashCode * 59 + this.BeginDate.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
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
            yield break;
        }
    }

}
