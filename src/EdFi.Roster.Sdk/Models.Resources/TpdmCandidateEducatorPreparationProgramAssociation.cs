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
    /// TpdmCandidateEducatorPreparationProgramAssociation
    /// </summary>
    [DataContract(Name = "tpdm_candidateEducatorPreparationProgramAssociation")]
    public partial class TpdmCandidateEducatorPreparationProgramAssociation : IEquatable<TpdmCandidateEducatorPreparationProgramAssociation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmCandidateEducatorPreparationProgramAssociation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TpdmCandidateEducatorPreparationProgramAssociation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmCandidateEducatorPreparationProgramAssociation" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="beginDate">The begin date for the association. (required).</param>
        /// <param name="candidateReference">candidateReference (required).</param>
        /// <param name="educatorPreparationProgramReference">educatorPreparationProgramReference (required).</param>
        /// <param name="candidateIndicator">candidateIndicator.</param>
        /// <param name="endDate">The end date for the association..</param>
        /// <param name="eppProgramPathwayDescriptor">A code for describing the program pathway, for example: Residency, Internship, Traditional.</param>
        /// <param name="majorSpecialization">The major area for a degree or area of specialization for a certificate..</param>
        /// <param name="minorSpecialization">The major area for a degree or area of specialization for a certificate..</param>
        /// <param name="reasonExitedDescriptor">Reason exited for the association..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        public TpdmCandidateEducatorPreparationProgramAssociation(string id = default(string), DateTime beginDate = default(DateTime), TpdmCandidateReference candidateReference = default(TpdmCandidateReference), TpdmEducatorPreparationProgramReference educatorPreparationProgramReference = default(TpdmEducatorPreparationProgramReference), TpdmCandidateEducatorPreparationProgramAssociationCandidateIndicator candidateIndicator = default(TpdmCandidateEducatorPreparationProgramAssociationCandidateIndicator), DateTime endDate = default(DateTime), string eppProgramPathwayDescriptor = default(string), string majorSpecialization = default(string), string minorSpecialization = default(string), string reasonExitedDescriptor = default(string), string etag = default(string))
        {
            this.BeginDate = beginDate;
            // to ensure "candidateReference" is required (not null)
            this.CandidateReference = candidateReference ?? throw new ArgumentNullException("candidateReference is a required property for TpdmCandidateEducatorPreparationProgramAssociation and cannot be null");
            // to ensure "educatorPreparationProgramReference" is required (not null)
            this.EducatorPreparationProgramReference = educatorPreparationProgramReference ?? throw new ArgumentNullException("educatorPreparationProgramReference is a required property for TpdmCandidateEducatorPreparationProgramAssociation and cannot be null");
            this.Id = id;
            this.CandidateIndicator = candidateIndicator;
            this.EndDate = endDate;
            this.EppProgramPathwayDescriptor = eppProgramPathwayDescriptor;
            this.MajorSpecialization = majorSpecialization;
            this.MinorSpecialization = minorSpecialization;
            this.ReasonExitedDescriptor = reasonExitedDescriptor;
            this.Etag = etag;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The begin date for the association.
        /// </summary>
        /// <value>The begin date for the association.</value>
        [DataMember(Name = "beginDate", IsRequired = true, EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime BeginDate { get; set; }

        /// <summary>
        /// Gets or Sets CandidateReference
        /// </summary>
        [DataMember(Name = "candidateReference", IsRequired = true, EmitDefaultValue = false)]
        public TpdmCandidateReference CandidateReference { get; set; }

        /// <summary>
        /// Gets or Sets EducatorPreparationProgramReference
        /// </summary>
        [DataMember(Name = "educatorPreparationProgramReference", IsRequired = true, EmitDefaultValue = false)]
        public TpdmEducatorPreparationProgramReference EducatorPreparationProgramReference { get; set; }

        /// <summary>
        /// Gets or Sets CandidateIndicator
        /// </summary>
        [DataMember(Name = "candidateIndicator", EmitDefaultValue = false)]
        public TpdmCandidateEducatorPreparationProgramAssociationCandidateIndicator CandidateIndicator { get; set; }

        /// <summary>
        /// The end date for the association.
        /// </summary>
        /// <value>The end date for the association.</value>
        [DataMember(Name = "endDate", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// A code for describing the program pathway, for example: Residency, Internship, Traditional
        /// </summary>
        /// <value>A code for describing the program pathway, for example: Residency, Internship, Traditional</value>
        [DataMember(Name = "eppProgramPathwayDescriptor", EmitDefaultValue = false)]
        public string EppProgramPathwayDescriptor { get; set; }

        /// <summary>
        /// The major area for a degree or area of specialization for a certificate.
        /// </summary>
        /// <value>The major area for a degree or area of specialization for a certificate.</value>
        [DataMember(Name = "majorSpecialization", EmitDefaultValue = false)]
        public string MajorSpecialization { get; set; }

        /// <summary>
        /// The major area for a degree or area of specialization for a certificate.
        /// </summary>
        /// <value>The major area for a degree or area of specialization for a certificate.</value>
        [DataMember(Name = "minorSpecialization", EmitDefaultValue = false)]
        public string MinorSpecialization { get; set; }

        /// <summary>
        /// Reason exited for the association.
        /// </summary>
        /// <value>Reason exited for the association.</value>
        [DataMember(Name = "reasonExitedDescriptor", EmitDefaultValue = false)]
        public string ReasonExitedDescriptor { get; set; }

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
            sb.Append("class TpdmCandidateEducatorPreparationProgramAssociation {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  BeginDate: ").Append(BeginDate).Append("\n");
            sb.Append("  CandidateReference: ").Append(CandidateReference).Append("\n");
            sb.Append("  EducatorPreparationProgramReference: ").Append(EducatorPreparationProgramReference).Append("\n");
            sb.Append("  CandidateIndicator: ").Append(CandidateIndicator).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  EppProgramPathwayDescriptor: ").Append(EppProgramPathwayDescriptor).Append("\n");
            sb.Append("  MajorSpecialization: ").Append(MajorSpecialization).Append("\n");
            sb.Append("  MinorSpecialization: ").Append(MinorSpecialization).Append("\n");
            sb.Append("  ReasonExitedDescriptor: ").Append(ReasonExitedDescriptor).Append("\n");
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
            return this.Equals(input as TpdmCandidateEducatorPreparationProgramAssociation);
        }

        /// <summary>
        /// Returns true if TpdmCandidateEducatorPreparationProgramAssociation instances are equal
        /// </summary>
        /// <param name="input">Instance of TpdmCandidateEducatorPreparationProgramAssociation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TpdmCandidateEducatorPreparationProgramAssociation input)
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
                    this.CandidateReference == input.CandidateReference ||
                    (this.CandidateReference != null &&
                    this.CandidateReference.Equals(input.CandidateReference))
                ) && 
                (
                    this.EducatorPreparationProgramReference == input.EducatorPreparationProgramReference ||
                    (this.EducatorPreparationProgramReference != null &&
                    this.EducatorPreparationProgramReference.Equals(input.EducatorPreparationProgramReference))
                ) && 
                (
                    this.CandidateIndicator == input.CandidateIndicator ||
                    (this.CandidateIndicator != null &&
                    this.CandidateIndicator.Equals(input.CandidateIndicator))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.EppProgramPathwayDescriptor == input.EppProgramPathwayDescriptor ||
                    (this.EppProgramPathwayDescriptor != null &&
                    this.EppProgramPathwayDescriptor.Equals(input.EppProgramPathwayDescriptor))
                ) && 
                (
                    this.MajorSpecialization == input.MajorSpecialization ||
                    (this.MajorSpecialization != null &&
                    this.MajorSpecialization.Equals(input.MajorSpecialization))
                ) && 
                (
                    this.MinorSpecialization == input.MinorSpecialization ||
                    (this.MinorSpecialization != null &&
                    this.MinorSpecialization.Equals(input.MinorSpecialization))
                ) && 
                (
                    this.ReasonExitedDescriptor == input.ReasonExitedDescriptor ||
                    (this.ReasonExitedDescriptor != null &&
                    this.ReasonExitedDescriptor.Equals(input.ReasonExitedDescriptor))
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
                if (this.CandidateReference != null)
                    hashCode = hashCode * 59 + this.CandidateReference.GetHashCode();
                if (this.EducatorPreparationProgramReference != null)
                    hashCode = hashCode * 59 + this.EducatorPreparationProgramReference.GetHashCode();
                if (this.CandidateIndicator != null)
                    hashCode = hashCode * 59 + this.CandidateIndicator.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.EppProgramPathwayDescriptor != null)
                    hashCode = hashCode * 59 + this.EppProgramPathwayDescriptor.GetHashCode();
                if (this.MajorSpecialization != null)
                    hashCode = hashCode * 59 + this.MajorSpecialization.GetHashCode();
                if (this.MinorSpecialization != null)
                    hashCode = hashCode * 59 + this.MinorSpecialization.GetHashCode();
                if (this.ReasonExitedDescriptor != null)
                    hashCode = hashCode * 59 + this.ReasonExitedDescriptor.GetHashCode();
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
            // EppProgramPathwayDescriptor (string) maxLength
            if(this.EppProgramPathwayDescriptor != null && this.EppProgramPathwayDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EppProgramPathwayDescriptor, length must be less than 306.", new [] { "EppProgramPathwayDescriptor" });
            }

            // MajorSpecialization (string) maxLength
            if(this.MajorSpecialization != null && this.MajorSpecialization.Length > 75)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MajorSpecialization, length must be less than 75.", new [] { "MajorSpecialization" });
            }

            // MinorSpecialization (string) maxLength
            if(this.MinorSpecialization != null && this.MinorSpecialization.Length > 75)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MinorSpecialization, length must be less than 75.", new [] { "MinorSpecialization" });
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
