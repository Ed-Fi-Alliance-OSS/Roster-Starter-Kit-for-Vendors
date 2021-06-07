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
    /// SectionSession
    /// </summary>
    [DataContract(Name = "section_session")]
    public partial class SectionSession : IEquatable<SectionSession>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SectionSession" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SectionSession() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SectionSession" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="schoolId">The identifier assigned to a school. (required).</param>
        /// <param name="schoolYear">The identifier for the school year. (required).</param>
        /// <param name="termDescriptor">An descriptor value indicating the term (e.g. &#39;Semester&#39;, &#39;Quarter&#39;, etc.). (required).</param>
        /// <param name="sessionName">The identifier for the calendar for the academic session (e.g., 2010/11, 2011 Summer). (required).</param>
        /// <param name="beginDate">Month, day, and year of the first day of the Session. (required).</param>
        /// <param name="endDate">Month, day and year of the last day of the Session. (required).</param>
        /// <param name="totalInstructionalDays">The total number of instructional days in the school calendar. (required).</param>
        public SectionSession(string id = default(string), int schoolId = default(int), int schoolYear = default(int), string termDescriptor = default(string), string sessionName = default(string), DateTime beginDate = default(DateTime), DateTime endDate = default(DateTime), int totalInstructionalDays = default(int))
        {
            // to ensure "id" is required (not null)
            this.Id = id ?? throw new ArgumentNullException("id is a required property for SectionSession and cannot be null");
            this.SchoolId = schoolId;
            this.SchoolYear = schoolYear;
            // to ensure "termDescriptor" is required (not null)
            this.TermDescriptor = termDescriptor ?? throw new ArgumentNullException("termDescriptor is a required property for SectionSession and cannot be null");
            // to ensure "sessionName" is required (not null)
            this.SessionName = sessionName ?? throw new ArgumentNullException("sessionName is a required property for SectionSession and cannot be null");
            this.BeginDate = beginDate;
            this.EndDate = endDate;
            this.TotalInstructionalDays = totalInstructionalDays;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The identifier assigned to a school.
        /// </summary>
        /// <value>The identifier assigned to a school.</value>
        [DataMember(Name = "schoolId", IsRequired = true, EmitDefaultValue = false)]
        public int SchoolId { get; set; }

        /// <summary>
        /// The identifier for the school year.
        /// </summary>
        /// <value>The identifier for the school year.</value>
        [DataMember(Name = "schoolYear", IsRequired = true, EmitDefaultValue = false)]
        public int SchoolYear { get; set; }

        /// <summary>
        /// An descriptor value indicating the term (e.g. &#39;Semester&#39;, &#39;Quarter&#39;, etc.).
        /// </summary>
        /// <value>An descriptor value indicating the term (e.g. &#39;Semester&#39;, &#39;Quarter&#39;, etc.).</value>
        [DataMember(Name = "termDescriptor", IsRequired = true, EmitDefaultValue = false)]
        public string TermDescriptor { get; set; }

        /// <summary>
        /// The identifier for the calendar for the academic session (e.g., 2010/11, 2011 Summer).
        /// </summary>
        /// <value>The identifier for the calendar for the academic session (e.g., 2010/11, 2011 Summer).</value>
        [DataMember(Name = "sessionName", IsRequired = true, EmitDefaultValue = false)]
        public string SessionName { get; set; }

        /// <summary>
        /// Month, day, and year of the first day of the Session.
        /// </summary>
        /// <value>Month, day, and year of the first day of the Session.</value>
        [DataMember(Name = "beginDate", IsRequired = true, EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime BeginDate { get; set; }

        /// <summary>
        /// Month, day and year of the last day of the Session.
        /// </summary>
        /// <value>Month, day and year of the last day of the Session.</value>
        [DataMember(Name = "endDate", IsRequired = true, EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// The total number of instructional days in the school calendar.
        /// </summary>
        /// <value>The total number of instructional days in the school calendar.</value>
        [DataMember(Name = "totalInstructionalDays", IsRequired = true, EmitDefaultValue = false)]
        public int TotalInstructionalDays { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SectionSession {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SchoolId: ").Append(SchoolId).Append("\n");
            sb.Append("  SchoolYear: ").Append(SchoolYear).Append("\n");
            sb.Append("  TermDescriptor: ").Append(TermDescriptor).Append("\n");
            sb.Append("  SessionName: ").Append(SessionName).Append("\n");
            sb.Append("  BeginDate: ").Append(BeginDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  TotalInstructionalDays: ").Append(TotalInstructionalDays).Append("\n");
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
            return this.Equals(input as SectionSession);
        }

        /// <summary>
        /// Returns true if SectionSession instances are equal
        /// </summary>
        /// <param name="input">Instance of SectionSession to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SectionSession input)
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
                    this.SchoolId == input.SchoolId ||
                    this.SchoolId.Equals(input.SchoolId)
                ) && 
                (
                    this.SchoolYear == input.SchoolYear ||
                    this.SchoolYear.Equals(input.SchoolYear)
                ) && 
                (
                    this.TermDescriptor == input.TermDescriptor ||
                    (this.TermDescriptor != null &&
                    this.TermDescriptor.Equals(input.TermDescriptor))
                ) && 
                (
                    this.SessionName == input.SessionName ||
                    (this.SessionName != null &&
                    this.SessionName.Equals(input.SessionName))
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
                    this.TotalInstructionalDays == input.TotalInstructionalDays ||
                    this.TotalInstructionalDays.Equals(input.TotalInstructionalDays)
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
                hashCode = hashCode * 59 + this.SchoolId.GetHashCode();
                hashCode = hashCode * 59 + this.SchoolYear.GetHashCode();
                if (this.TermDescriptor != null)
                    hashCode = hashCode * 59 + this.TermDescriptor.GetHashCode();
                if (this.SessionName != null)
                    hashCode = hashCode * 59 + this.SessionName.GetHashCode();
                if (this.BeginDate != null)
                    hashCode = hashCode * 59 + this.BeginDate.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                hashCode = hashCode * 59 + this.TotalInstructionalDays.GetHashCode();
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
            // TermDescriptor (string) maxLength
            if(this.TermDescriptor != null && this.TermDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TermDescriptor, length must be less than 306.", new [] { "TermDescriptor" });
            }

            // SessionName (string) maxLength
            if(this.SessionName != null && this.SessionName.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SessionName, length must be less than 60.", new [] { "SessionName" });
            }

            yield break;
        }
    }

}
