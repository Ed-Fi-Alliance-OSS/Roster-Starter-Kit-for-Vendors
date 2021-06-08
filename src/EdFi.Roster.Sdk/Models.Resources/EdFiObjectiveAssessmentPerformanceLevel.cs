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
    /// EdFiObjectiveAssessmentPerformanceLevel
    /// </summary>
    [DataContract(Name = "edFi_objectiveAssessmentPerformanceLevel")]
    public partial class EdFiObjectiveAssessmentPerformanceLevel : IEquatable<EdFiObjectiveAssessmentPerformanceLevel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiObjectiveAssessmentPerformanceLevel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiObjectiveAssessmentPerformanceLevel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiObjectiveAssessmentPerformanceLevel" /> class.
        /// </summary>
        /// <param name="assessmentReportingMethodDescriptor">The method that the instructor of the class uses to report the performance and achievement of all students. It may be a qualitative method such as individualized teacher comments or a quantitative method such as a letter or numerical grade. In some cases, more than one type of reporting method may be used. (required).</param>
        /// <param name="performanceLevelDescriptor">The performance level(s) defined for the assessment. (required).</param>
        /// <param name="resultDatatypeTypeDescriptor">The datatype of the result. The results can be expressed as a number, percentile, range, level, etc..</param>
        /// <param name="maximumScore">The maximum score to make the indicated level of performance..</param>
        /// <param name="minimumScore">The minimum score required to make the indicated level of performance..</param>
        public EdFiObjectiveAssessmentPerformanceLevel(string assessmentReportingMethodDescriptor = default(string), string performanceLevelDescriptor = default(string), string resultDatatypeTypeDescriptor = default(string), string maximumScore = default(string), string minimumScore = default(string))
        {
            // to ensure "assessmentReportingMethodDescriptor" is required (not null)
            this.AssessmentReportingMethodDescriptor = assessmentReportingMethodDescriptor ?? throw new ArgumentNullException("assessmentReportingMethodDescriptor is a required property for EdFiObjectiveAssessmentPerformanceLevel and cannot be null");
            // to ensure "performanceLevelDescriptor" is required (not null)
            this.PerformanceLevelDescriptor = performanceLevelDescriptor ?? throw new ArgumentNullException("performanceLevelDescriptor is a required property for EdFiObjectiveAssessmentPerformanceLevel and cannot be null");
            this.ResultDatatypeTypeDescriptor = resultDatatypeTypeDescriptor;
            this.MaximumScore = maximumScore;
            this.MinimumScore = minimumScore;
        }

        /// <summary>
        /// The method that the instructor of the class uses to report the performance and achievement of all students. It may be a qualitative method such as individualized teacher comments or a quantitative method such as a letter or numerical grade. In some cases, more than one type of reporting method may be used.
        /// </summary>
        /// <value>The method that the instructor of the class uses to report the performance and achievement of all students. It may be a qualitative method such as individualized teacher comments or a quantitative method such as a letter or numerical grade. In some cases, more than one type of reporting method may be used.</value>
        [DataMember(Name = "assessmentReportingMethodDescriptor", IsRequired = true, EmitDefaultValue = false)]
        public string AssessmentReportingMethodDescriptor { get; set; }

        /// <summary>
        /// The performance level(s) defined for the assessment.
        /// </summary>
        /// <value>The performance level(s) defined for the assessment.</value>
        [DataMember(Name = "performanceLevelDescriptor", IsRequired = true, EmitDefaultValue = false)]
        public string PerformanceLevelDescriptor { get; set; }

        /// <summary>
        /// The datatype of the result. The results can be expressed as a number, percentile, range, level, etc.
        /// </summary>
        /// <value>The datatype of the result. The results can be expressed as a number, percentile, range, level, etc.</value>
        [DataMember(Name = "resultDatatypeTypeDescriptor", EmitDefaultValue = false)]
        public string ResultDatatypeTypeDescriptor { get; set; }

        /// <summary>
        /// The maximum score to make the indicated level of performance.
        /// </summary>
        /// <value>The maximum score to make the indicated level of performance.</value>
        [DataMember(Name = "maximumScore", EmitDefaultValue = false)]
        public string MaximumScore { get; set; }

        /// <summary>
        /// The minimum score required to make the indicated level of performance.
        /// </summary>
        /// <value>The minimum score required to make the indicated level of performance.</value>
        [DataMember(Name = "minimumScore", EmitDefaultValue = false)]
        public string MinimumScore { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiObjectiveAssessmentPerformanceLevel {\n");
            sb.Append("  AssessmentReportingMethodDescriptor: ").Append(AssessmentReportingMethodDescriptor).Append("\n");
            sb.Append("  PerformanceLevelDescriptor: ").Append(PerformanceLevelDescriptor).Append("\n");
            sb.Append("  ResultDatatypeTypeDescriptor: ").Append(ResultDatatypeTypeDescriptor).Append("\n");
            sb.Append("  MaximumScore: ").Append(MaximumScore).Append("\n");
            sb.Append("  MinimumScore: ").Append(MinimumScore).Append("\n");
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
            return this.Equals(input as EdFiObjectiveAssessmentPerformanceLevel);
        }

        /// <summary>
        /// Returns true if EdFiObjectiveAssessmentPerformanceLevel instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiObjectiveAssessmentPerformanceLevel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiObjectiveAssessmentPerformanceLevel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AssessmentReportingMethodDescriptor == input.AssessmentReportingMethodDescriptor ||
                    (this.AssessmentReportingMethodDescriptor != null &&
                    this.AssessmentReportingMethodDescriptor.Equals(input.AssessmentReportingMethodDescriptor))
                ) && 
                (
                    this.PerformanceLevelDescriptor == input.PerformanceLevelDescriptor ||
                    (this.PerformanceLevelDescriptor != null &&
                    this.PerformanceLevelDescriptor.Equals(input.PerformanceLevelDescriptor))
                ) && 
                (
                    this.ResultDatatypeTypeDescriptor == input.ResultDatatypeTypeDescriptor ||
                    (this.ResultDatatypeTypeDescriptor != null &&
                    this.ResultDatatypeTypeDescriptor.Equals(input.ResultDatatypeTypeDescriptor))
                ) && 
                (
                    this.MaximumScore == input.MaximumScore ||
                    (this.MaximumScore != null &&
                    this.MaximumScore.Equals(input.MaximumScore))
                ) && 
                (
                    this.MinimumScore == input.MinimumScore ||
                    (this.MinimumScore != null &&
                    this.MinimumScore.Equals(input.MinimumScore))
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
                if (this.AssessmentReportingMethodDescriptor != null)
                    hashCode = hashCode * 59 + this.AssessmentReportingMethodDescriptor.GetHashCode();
                if (this.PerformanceLevelDescriptor != null)
                    hashCode = hashCode * 59 + this.PerformanceLevelDescriptor.GetHashCode();
                if (this.ResultDatatypeTypeDescriptor != null)
                    hashCode = hashCode * 59 + this.ResultDatatypeTypeDescriptor.GetHashCode();
                if (this.MaximumScore != null)
                    hashCode = hashCode * 59 + this.MaximumScore.GetHashCode();
                if (this.MinimumScore != null)
                    hashCode = hashCode * 59 + this.MinimumScore.GetHashCode();
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
            // AssessmentReportingMethodDescriptor (string) maxLength
            if(this.AssessmentReportingMethodDescriptor != null && this.AssessmentReportingMethodDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AssessmentReportingMethodDescriptor, length must be less than 306.", new [] { "AssessmentReportingMethodDescriptor" });
            }

            // PerformanceLevelDescriptor (string) maxLength
            if(this.PerformanceLevelDescriptor != null && this.PerformanceLevelDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PerformanceLevelDescriptor, length must be less than 306.", new [] { "PerformanceLevelDescriptor" });
            }

            // ResultDatatypeTypeDescriptor (string) maxLength
            if(this.ResultDatatypeTypeDescriptor != null && this.ResultDatatypeTypeDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ResultDatatypeTypeDescriptor, length must be less than 306.", new [] { "ResultDatatypeTypeDescriptor" });
            }

            // MaximumScore (string) maxLength
            if(this.MaximumScore != null && this.MaximumScore.Length > 35)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MaximumScore, length must be less than 35.", new [] { "MaximumScore" });
            }

            // MinimumScore (string) maxLength
            if(this.MinimumScore != null && this.MinimumScore.Length > 35)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MinimumScore, length must be less than 35.", new [] { "MinimumScore" });
            }

            yield break;
        }
    }

}
