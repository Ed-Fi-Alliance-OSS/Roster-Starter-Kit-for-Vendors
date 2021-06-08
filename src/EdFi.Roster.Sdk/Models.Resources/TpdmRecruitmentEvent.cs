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
    /// TpdmRecruitmentEvent
    /// </summary>
    [DataContract(Name = "tpdm_recruitmentEvent")]
    public partial class TpdmRecruitmentEvent : IEquatable<TpdmRecruitmentEvent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmRecruitmentEvent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TpdmRecruitmentEvent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmRecruitmentEvent" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="eventDate">The date of the event. (required).</param>
        /// <param name="eventTitle">The title of the event. (required).</param>
        /// <param name="educationOrganizationReference">educationOrganizationReference (required).</param>
        /// <param name="eventDescription">The long description of the event..</param>
        /// <param name="eventLocation">The location of the event..</param>
        /// <param name="recruitmentEventTypeDescriptor">The type of event. (required).</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        public TpdmRecruitmentEvent(string id = default(string), DateTime eventDate = default(DateTime), string eventTitle = default(string), EdFiEducationOrganizationReference educationOrganizationReference = default(EdFiEducationOrganizationReference), string eventDescription = default(string), string eventLocation = default(string), string recruitmentEventTypeDescriptor = default(string), string etag = default(string))
        {
            this.EventDate = eventDate;
            // to ensure "eventTitle" is required (not null)
            this.EventTitle = eventTitle ?? throw new ArgumentNullException("eventTitle is a required property for TpdmRecruitmentEvent and cannot be null");
            // to ensure "educationOrganizationReference" is required (not null)
            this.EducationOrganizationReference = educationOrganizationReference ?? throw new ArgumentNullException("educationOrganizationReference is a required property for TpdmRecruitmentEvent and cannot be null");
            // to ensure "recruitmentEventTypeDescriptor" is required (not null)
            this.RecruitmentEventTypeDescriptor = recruitmentEventTypeDescriptor ?? throw new ArgumentNullException("recruitmentEventTypeDescriptor is a required property for TpdmRecruitmentEvent and cannot be null");
            this.Id = id;
            this.EventDescription = eventDescription;
            this.EventLocation = eventLocation;
            this.Etag = etag;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The date of the event.
        /// </summary>
        /// <value>The date of the event.</value>
        [DataMember(Name = "eventDate", IsRequired = true, EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime EventDate { get; set; }

        /// <summary>
        /// The title of the event.
        /// </summary>
        /// <value>The title of the event.</value>
        [DataMember(Name = "eventTitle", IsRequired = true, EmitDefaultValue = false)]
        public string EventTitle { get; set; }

        /// <summary>
        /// Gets or Sets EducationOrganizationReference
        /// </summary>
        [DataMember(Name = "educationOrganizationReference", IsRequired = true, EmitDefaultValue = false)]
        public EdFiEducationOrganizationReference EducationOrganizationReference { get; set; }

        /// <summary>
        /// The long description of the event.
        /// </summary>
        /// <value>The long description of the event.</value>
        [DataMember(Name = "eventDescription", EmitDefaultValue = false)]
        public string EventDescription { get; set; }

        /// <summary>
        /// The location of the event.
        /// </summary>
        /// <value>The location of the event.</value>
        [DataMember(Name = "eventLocation", EmitDefaultValue = false)]
        public string EventLocation { get; set; }

        /// <summary>
        /// The type of event.
        /// </summary>
        /// <value>The type of event.</value>
        [DataMember(Name = "recruitmentEventTypeDescriptor", IsRequired = true, EmitDefaultValue = false)]
        public string RecruitmentEventTypeDescriptor { get; set; }

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
            sb.Append("class TpdmRecruitmentEvent {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  EventDate: ").Append(EventDate).Append("\n");
            sb.Append("  EventTitle: ").Append(EventTitle).Append("\n");
            sb.Append("  EducationOrganizationReference: ").Append(EducationOrganizationReference).Append("\n");
            sb.Append("  EventDescription: ").Append(EventDescription).Append("\n");
            sb.Append("  EventLocation: ").Append(EventLocation).Append("\n");
            sb.Append("  RecruitmentEventTypeDescriptor: ").Append(RecruitmentEventTypeDescriptor).Append("\n");
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
            return this.Equals(input as TpdmRecruitmentEvent);
        }

        /// <summary>
        /// Returns true if TpdmRecruitmentEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of TpdmRecruitmentEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TpdmRecruitmentEvent input)
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
                    this.EventDate == input.EventDate ||
                    (this.EventDate != null &&
                    this.EventDate.Equals(input.EventDate))
                ) && 
                (
                    this.EventTitle == input.EventTitle ||
                    (this.EventTitle != null &&
                    this.EventTitle.Equals(input.EventTitle))
                ) && 
                (
                    this.EducationOrganizationReference == input.EducationOrganizationReference ||
                    (this.EducationOrganizationReference != null &&
                    this.EducationOrganizationReference.Equals(input.EducationOrganizationReference))
                ) && 
                (
                    this.EventDescription == input.EventDescription ||
                    (this.EventDescription != null &&
                    this.EventDescription.Equals(input.EventDescription))
                ) && 
                (
                    this.EventLocation == input.EventLocation ||
                    (this.EventLocation != null &&
                    this.EventLocation.Equals(input.EventLocation))
                ) && 
                (
                    this.RecruitmentEventTypeDescriptor == input.RecruitmentEventTypeDescriptor ||
                    (this.RecruitmentEventTypeDescriptor != null &&
                    this.RecruitmentEventTypeDescriptor.Equals(input.RecruitmentEventTypeDescriptor))
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
                if (this.EventDate != null)
                    hashCode = hashCode * 59 + this.EventDate.GetHashCode();
                if (this.EventTitle != null)
                    hashCode = hashCode * 59 + this.EventTitle.GetHashCode();
                if (this.EducationOrganizationReference != null)
                    hashCode = hashCode * 59 + this.EducationOrganizationReference.GetHashCode();
                if (this.EventDescription != null)
                    hashCode = hashCode * 59 + this.EventDescription.GetHashCode();
                if (this.EventLocation != null)
                    hashCode = hashCode * 59 + this.EventLocation.GetHashCode();
                if (this.RecruitmentEventTypeDescriptor != null)
                    hashCode = hashCode * 59 + this.RecruitmentEventTypeDescriptor.GetHashCode();
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
            // EventTitle (string) maxLength
            if(this.EventTitle != null && this.EventTitle.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EventTitle, length must be less than 50.", new [] { "EventTitle" });
            }

            // EventDescription (string) maxLength
            if(this.EventDescription != null && this.EventDescription.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EventDescription, length must be less than 255.", new [] { "EventDescription" });
            }

            // EventLocation (string) maxLength
            if(this.EventLocation != null && this.EventLocation.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EventLocation, length must be less than 255.", new [] { "EventLocation" });
            }

            // RecruitmentEventTypeDescriptor (string) maxLength
            if(this.RecruitmentEventTypeDescriptor != null && this.RecruitmentEventTypeDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RecruitmentEventTypeDescriptor, length must be less than 306.", new [] { "RecruitmentEventTypeDescriptor" });
            }

            yield break;
        }
    }

}