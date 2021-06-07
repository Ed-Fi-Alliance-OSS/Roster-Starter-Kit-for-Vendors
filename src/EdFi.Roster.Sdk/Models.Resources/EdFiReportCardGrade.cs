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
    /// EdFiReportCardGrade
    /// </summary>
    [DataContract(Name = "edFi_reportCardGrade")]
    public partial class EdFiReportCardGrade : IEquatable<EdFiReportCardGrade>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiReportCardGrade" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiReportCardGrade() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiReportCardGrade" /> class.
        /// </summary>
        /// <param name="gradeReference">gradeReference (required).</param>
        public EdFiReportCardGrade(EdFiGradeReference gradeReference = default(EdFiGradeReference))
        {
            // to ensure "gradeReference" is required (not null)
            this.GradeReference = gradeReference ?? throw new ArgumentNullException("gradeReference is a required property for EdFiReportCardGrade and cannot be null");
        }

        /// <summary>
        /// Gets or Sets GradeReference
        /// </summary>
        [DataMember(Name = "gradeReference", IsRequired = true, EmitDefaultValue = false)]
        public EdFiGradeReference GradeReference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiReportCardGrade {\n");
            sb.Append("  GradeReference: ").Append(GradeReference).Append("\n");
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
            return this.Equals(input as EdFiReportCardGrade);
        }

        /// <summary>
        /// Returns true if EdFiReportCardGrade instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiReportCardGrade to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiReportCardGrade input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GradeReference == input.GradeReference ||
                    (this.GradeReference != null &&
                    this.GradeReference.Equals(input.GradeReference))
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
                if (this.GradeReference != null)
                    hashCode = hashCode * 59 + this.GradeReference.GetHashCode();
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
