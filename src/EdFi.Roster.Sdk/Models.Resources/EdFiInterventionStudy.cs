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
    /// EdFiInterventionStudy
    /// </summary>
    [DataContract(Name = "edFi_interventionStudy")]
    public partial class EdFiInterventionStudy : IEquatable<EdFiInterventionStudy>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiInterventionStudy" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiInterventionStudy() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiInterventionStudy" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="interventionStudyIdentificationCode">A unique number or alphanumeric code assigned to an intervention study. (required).</param>
        /// <param name="educationOrganizationReference">educationOrganizationReference (required).</param>
        /// <param name="interventionPrescriptionReference">interventionPrescriptionReference (required).</param>
        /// <param name="appropriateGradeLevels">An unordered collection of interventionStudyAppropriateGradeLevels. Grade levels participating in this study..</param>
        /// <param name="appropriateSexes">An unordered collection of interventionStudyAppropriateSexes. Sexes participating in this study. If omitted, considered generally applicable..</param>
        /// <param name="deliveryMethodDescriptor">The way in which an intervention was implemented: individual, small group, whole class, or whole school. (required).</param>
        /// <param name="educationContents">An unordered collection of interventionStudyEducationContents. Relates the education content source to the education content..</param>
        /// <param name="interventionClassDescriptor">The way in which an intervention is used: curriculum, supplement, or practice. (required).</param>
        /// <param name="interventionEffectivenesses">An unordered collection of interventionStudyInterventionEffectivenesses. Measurement of the effectiveness of the InterventionStudy per diagnosis..</param>
        /// <param name="learningResourceMetadataURIs">An unordered collection of interventionStudyLearningResourceMetadataURIs. The URI (typical a URL) pointing to the metadata entry in a LRMI metadata repository, which describes this content item..</param>
        /// <param name="participants">The number of participants observed in the study. (required).</param>
        /// <param name="populationServeds">An unordered collection of interventionStudyPopulationServeds. A subset of students that are the focus of the InterventionStudy..</param>
        /// <param name="stateAbbreviations">An unordered collection of interventionStudyStateAbbreviations. The abbreviation for the state (within the United States) or outlying area, the school system of which the participants of the study are considered to be a part..</param>
        /// <param name="uris">An unordered collection of interventionStudyURIs. The URI (typical a URL) pointing to an education content item..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        public EdFiInterventionStudy(string id = default(string), string interventionStudyIdentificationCode = default(string), EdFiEducationOrganizationReference educationOrganizationReference = default(EdFiEducationOrganizationReference), EdFiInterventionPrescriptionReference interventionPrescriptionReference = default(EdFiInterventionPrescriptionReference), List<EdFiInterventionStudyAppropriateGradeLevel> appropriateGradeLevels = default(List<EdFiInterventionStudyAppropriateGradeLevel>), List<EdFiInterventionStudyAppropriateSex> appropriateSexes = default(List<EdFiInterventionStudyAppropriateSex>), string deliveryMethodDescriptor = default(string), List<EdFiInterventionStudyEducationContent> educationContents = default(List<EdFiInterventionStudyEducationContent>), string interventionClassDescriptor = default(string), List<EdFiInterventionStudyInterventionEffectiveness> interventionEffectivenesses = default(List<EdFiInterventionStudyInterventionEffectiveness>), List<EdFiInterventionStudyLearningResourceMetadataURI> learningResourceMetadataURIs = default(List<EdFiInterventionStudyLearningResourceMetadataURI>), int participants = default(int), List<EdFiInterventionStudyPopulationServed> populationServeds = default(List<EdFiInterventionStudyPopulationServed>), List<EdFiInterventionStudyStateAbbreviation> stateAbbreviations = default(List<EdFiInterventionStudyStateAbbreviation>), List<EdFiInterventionStudyURI> uris = default(List<EdFiInterventionStudyURI>), string etag = default(string))
        {
            // to ensure "interventionStudyIdentificationCode" is required (not null)
            this.InterventionStudyIdentificationCode = interventionStudyIdentificationCode ?? throw new ArgumentNullException("interventionStudyIdentificationCode is a required property for EdFiInterventionStudy and cannot be null");
            // to ensure "educationOrganizationReference" is required (not null)
            this.EducationOrganizationReference = educationOrganizationReference ?? throw new ArgumentNullException("educationOrganizationReference is a required property for EdFiInterventionStudy and cannot be null");
            // to ensure "interventionPrescriptionReference" is required (not null)
            this.InterventionPrescriptionReference = interventionPrescriptionReference ?? throw new ArgumentNullException("interventionPrescriptionReference is a required property for EdFiInterventionStudy and cannot be null");
            // to ensure "deliveryMethodDescriptor" is required (not null)
            this.DeliveryMethodDescriptor = deliveryMethodDescriptor ?? throw new ArgumentNullException("deliveryMethodDescriptor is a required property for EdFiInterventionStudy and cannot be null");
            // to ensure "interventionClassDescriptor" is required (not null)
            this.InterventionClassDescriptor = interventionClassDescriptor ?? throw new ArgumentNullException("interventionClassDescriptor is a required property for EdFiInterventionStudy and cannot be null");
            this.Participants = participants;
            this.Id = id;
            this.AppropriateGradeLevels = appropriateGradeLevels;
            this.AppropriateSexes = appropriateSexes;
            this.EducationContents = educationContents;
            this.InterventionEffectivenesses = interventionEffectivenesses;
            this.LearningResourceMetadataURIs = learningResourceMetadataURIs;
            this.PopulationServeds = populationServeds;
            this.StateAbbreviations = stateAbbreviations;
            this.Uris = uris;
            this.Etag = etag;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// A unique number or alphanumeric code assigned to an intervention study.
        /// </summary>
        /// <value>A unique number or alphanumeric code assigned to an intervention study.</value>
        [DataMember(Name = "interventionStudyIdentificationCode", IsRequired = true, EmitDefaultValue = false)]
        public string InterventionStudyIdentificationCode { get; set; }

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
        /// An unordered collection of interventionStudyAppropriateGradeLevels. Grade levels participating in this study.
        /// </summary>
        /// <value>An unordered collection of interventionStudyAppropriateGradeLevels. Grade levels participating in this study.</value>
        [DataMember(Name = "appropriateGradeLevels", EmitDefaultValue = false)]
        public List<EdFiInterventionStudyAppropriateGradeLevel> AppropriateGradeLevels { get; set; }

        /// <summary>
        /// An unordered collection of interventionStudyAppropriateSexes. Sexes participating in this study. If omitted, considered generally applicable.
        /// </summary>
        /// <value>An unordered collection of interventionStudyAppropriateSexes. Sexes participating in this study. If omitted, considered generally applicable.</value>
        [DataMember(Name = "appropriateSexes", EmitDefaultValue = false)]
        public List<EdFiInterventionStudyAppropriateSex> AppropriateSexes { get; set; }

        /// <summary>
        /// The way in which an intervention was implemented: individual, small group, whole class, or whole school.
        /// </summary>
        /// <value>The way in which an intervention was implemented: individual, small group, whole class, or whole school.</value>
        [DataMember(Name = "deliveryMethodDescriptor", IsRequired = true, EmitDefaultValue = false)]
        public string DeliveryMethodDescriptor { get; set; }

        /// <summary>
        /// An unordered collection of interventionStudyEducationContents. Relates the education content source to the education content.
        /// </summary>
        /// <value>An unordered collection of interventionStudyEducationContents. Relates the education content source to the education content.</value>
        [DataMember(Name = "educationContents", EmitDefaultValue = false)]
        public List<EdFiInterventionStudyEducationContent> EducationContents { get; set; }

        /// <summary>
        /// The way in which an intervention is used: curriculum, supplement, or practice.
        /// </summary>
        /// <value>The way in which an intervention is used: curriculum, supplement, or practice.</value>
        [DataMember(Name = "interventionClassDescriptor", IsRequired = true, EmitDefaultValue = false)]
        public string InterventionClassDescriptor { get; set; }

        /// <summary>
        /// An unordered collection of interventionStudyInterventionEffectivenesses. Measurement of the effectiveness of the InterventionStudy per diagnosis.
        /// </summary>
        /// <value>An unordered collection of interventionStudyInterventionEffectivenesses. Measurement of the effectiveness of the InterventionStudy per diagnosis.</value>
        [DataMember(Name = "interventionEffectivenesses", EmitDefaultValue = false)]
        public List<EdFiInterventionStudyInterventionEffectiveness> InterventionEffectivenesses { get; set; }

        /// <summary>
        /// An unordered collection of interventionStudyLearningResourceMetadataURIs. The URI (typical a URL) pointing to the metadata entry in a LRMI metadata repository, which describes this content item.
        /// </summary>
        /// <value>An unordered collection of interventionStudyLearningResourceMetadataURIs. The URI (typical a URL) pointing to the metadata entry in a LRMI metadata repository, which describes this content item.</value>
        [DataMember(Name = "learningResourceMetadataURIs", EmitDefaultValue = false)]
        public List<EdFiInterventionStudyLearningResourceMetadataURI> LearningResourceMetadataURIs { get; set; }

        /// <summary>
        /// The number of participants observed in the study.
        /// </summary>
        /// <value>The number of participants observed in the study.</value>
        [DataMember(Name = "participants", IsRequired = true, EmitDefaultValue = false)]
        public int Participants { get; set; }

        /// <summary>
        /// An unordered collection of interventionStudyPopulationServeds. A subset of students that are the focus of the InterventionStudy.
        /// </summary>
        /// <value>An unordered collection of interventionStudyPopulationServeds. A subset of students that are the focus of the InterventionStudy.</value>
        [DataMember(Name = "populationServeds", EmitDefaultValue = false)]
        public List<EdFiInterventionStudyPopulationServed> PopulationServeds { get; set; }

        /// <summary>
        /// An unordered collection of interventionStudyStateAbbreviations. The abbreviation for the state (within the United States) or outlying area, the school system of which the participants of the study are considered to be a part.
        /// </summary>
        /// <value>An unordered collection of interventionStudyStateAbbreviations. The abbreviation for the state (within the United States) or outlying area, the school system of which the participants of the study are considered to be a part.</value>
        [DataMember(Name = "stateAbbreviations", EmitDefaultValue = false)]
        public List<EdFiInterventionStudyStateAbbreviation> StateAbbreviations { get; set; }

        /// <summary>
        /// An unordered collection of interventionStudyURIs. The URI (typical a URL) pointing to an education content item.
        /// </summary>
        /// <value>An unordered collection of interventionStudyURIs. The URI (typical a URL) pointing to an education content item.</value>
        [DataMember(Name = "uris", EmitDefaultValue = false)]
        public List<EdFiInterventionStudyURI> Uris { get; set; }

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
            sb.Append("class EdFiInterventionStudy {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  InterventionStudyIdentificationCode: ").Append(InterventionStudyIdentificationCode).Append("\n");
            sb.Append("  EducationOrganizationReference: ").Append(EducationOrganizationReference).Append("\n");
            sb.Append("  InterventionPrescriptionReference: ").Append(InterventionPrescriptionReference).Append("\n");
            sb.Append("  AppropriateGradeLevels: ").Append(AppropriateGradeLevels).Append("\n");
            sb.Append("  AppropriateSexes: ").Append(AppropriateSexes).Append("\n");
            sb.Append("  DeliveryMethodDescriptor: ").Append(DeliveryMethodDescriptor).Append("\n");
            sb.Append("  EducationContents: ").Append(EducationContents).Append("\n");
            sb.Append("  InterventionClassDescriptor: ").Append(InterventionClassDescriptor).Append("\n");
            sb.Append("  InterventionEffectivenesses: ").Append(InterventionEffectivenesses).Append("\n");
            sb.Append("  LearningResourceMetadataURIs: ").Append(LearningResourceMetadataURIs).Append("\n");
            sb.Append("  Participants: ").Append(Participants).Append("\n");
            sb.Append("  PopulationServeds: ").Append(PopulationServeds).Append("\n");
            sb.Append("  StateAbbreviations: ").Append(StateAbbreviations).Append("\n");
            sb.Append("  Uris: ").Append(Uris).Append("\n");
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
            return this.Equals(input as EdFiInterventionStudy);
        }

        /// <summary>
        /// Returns true if EdFiInterventionStudy instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiInterventionStudy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiInterventionStudy input)
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
                    this.InterventionStudyIdentificationCode == input.InterventionStudyIdentificationCode ||
                    (this.InterventionStudyIdentificationCode != null &&
                    this.InterventionStudyIdentificationCode.Equals(input.InterventionStudyIdentificationCode))
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
                    this.AppropriateGradeLevels == input.AppropriateGradeLevels ||
                    this.AppropriateGradeLevels != null &&
                    input.AppropriateGradeLevels != null &&
                    this.AppropriateGradeLevels.SequenceEqual(input.AppropriateGradeLevels)
                ) && 
                (
                    this.AppropriateSexes == input.AppropriateSexes ||
                    this.AppropriateSexes != null &&
                    input.AppropriateSexes != null &&
                    this.AppropriateSexes.SequenceEqual(input.AppropriateSexes)
                ) && 
                (
                    this.DeliveryMethodDescriptor == input.DeliveryMethodDescriptor ||
                    (this.DeliveryMethodDescriptor != null &&
                    this.DeliveryMethodDescriptor.Equals(input.DeliveryMethodDescriptor))
                ) && 
                (
                    this.EducationContents == input.EducationContents ||
                    this.EducationContents != null &&
                    input.EducationContents != null &&
                    this.EducationContents.SequenceEqual(input.EducationContents)
                ) && 
                (
                    this.InterventionClassDescriptor == input.InterventionClassDescriptor ||
                    (this.InterventionClassDescriptor != null &&
                    this.InterventionClassDescriptor.Equals(input.InterventionClassDescriptor))
                ) && 
                (
                    this.InterventionEffectivenesses == input.InterventionEffectivenesses ||
                    this.InterventionEffectivenesses != null &&
                    input.InterventionEffectivenesses != null &&
                    this.InterventionEffectivenesses.SequenceEqual(input.InterventionEffectivenesses)
                ) && 
                (
                    this.LearningResourceMetadataURIs == input.LearningResourceMetadataURIs ||
                    this.LearningResourceMetadataURIs != null &&
                    input.LearningResourceMetadataURIs != null &&
                    this.LearningResourceMetadataURIs.SequenceEqual(input.LearningResourceMetadataURIs)
                ) && 
                (
                    this.Participants == input.Participants ||
                    this.Participants.Equals(input.Participants)
                ) && 
                (
                    this.PopulationServeds == input.PopulationServeds ||
                    this.PopulationServeds != null &&
                    input.PopulationServeds != null &&
                    this.PopulationServeds.SequenceEqual(input.PopulationServeds)
                ) && 
                (
                    this.StateAbbreviations == input.StateAbbreviations ||
                    this.StateAbbreviations != null &&
                    input.StateAbbreviations != null &&
                    this.StateAbbreviations.SequenceEqual(input.StateAbbreviations)
                ) && 
                (
                    this.Uris == input.Uris ||
                    this.Uris != null &&
                    input.Uris != null &&
                    this.Uris.SequenceEqual(input.Uris)
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
                if (this.InterventionStudyIdentificationCode != null)
                    hashCode = hashCode * 59 + this.InterventionStudyIdentificationCode.GetHashCode();
                if (this.EducationOrganizationReference != null)
                    hashCode = hashCode * 59 + this.EducationOrganizationReference.GetHashCode();
                if (this.InterventionPrescriptionReference != null)
                    hashCode = hashCode * 59 + this.InterventionPrescriptionReference.GetHashCode();
                if (this.AppropriateGradeLevels != null)
                    hashCode = hashCode * 59 + this.AppropriateGradeLevels.GetHashCode();
                if (this.AppropriateSexes != null)
                    hashCode = hashCode * 59 + this.AppropriateSexes.GetHashCode();
                if (this.DeliveryMethodDescriptor != null)
                    hashCode = hashCode * 59 + this.DeliveryMethodDescriptor.GetHashCode();
                if (this.EducationContents != null)
                    hashCode = hashCode * 59 + this.EducationContents.GetHashCode();
                if (this.InterventionClassDescriptor != null)
                    hashCode = hashCode * 59 + this.InterventionClassDescriptor.GetHashCode();
                if (this.InterventionEffectivenesses != null)
                    hashCode = hashCode * 59 + this.InterventionEffectivenesses.GetHashCode();
                if (this.LearningResourceMetadataURIs != null)
                    hashCode = hashCode * 59 + this.LearningResourceMetadataURIs.GetHashCode();
                hashCode = hashCode * 59 + this.Participants.GetHashCode();
                if (this.PopulationServeds != null)
                    hashCode = hashCode * 59 + this.PopulationServeds.GetHashCode();
                if (this.StateAbbreviations != null)
                    hashCode = hashCode * 59 + this.StateAbbreviations.GetHashCode();
                if (this.Uris != null)
                    hashCode = hashCode * 59 + this.Uris.GetHashCode();
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
            // InterventionStudyIdentificationCode (string) maxLength
            if(this.InterventionStudyIdentificationCode != null && this.InterventionStudyIdentificationCode.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for InterventionStudyIdentificationCode, length must be less than 60.", new [] { "InterventionStudyIdentificationCode" });
            }

            // DeliveryMethodDescriptor (string) maxLength
            if(this.DeliveryMethodDescriptor != null && this.DeliveryMethodDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DeliveryMethodDescriptor, length must be less than 306.", new [] { "DeliveryMethodDescriptor" });
            }

            // InterventionClassDescriptor (string) maxLength
            if(this.InterventionClassDescriptor != null && this.InterventionClassDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for InterventionClassDescriptor, length must be less than 306.", new [] { "InterventionClassDescriptor" });
            }

            yield break;
        }
    }

}
