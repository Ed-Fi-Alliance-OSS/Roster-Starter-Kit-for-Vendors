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
    /// EdFiSurveyQuestionReference
    /// </summary>
    [DataContract(Name = "edFi_surveyQuestionReference")]
    public partial class EdFiSurveyQuestionReference : IEquatable<EdFiSurveyQuestionReference>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiSurveyQuestionReference" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiSurveyQuestionReference() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiSurveyQuestionReference" /> class.
        /// </summary>
        /// <param name="_namespace">Namespace for the Survey. (required).</param>
        /// <param name="questionCode">The identifying code for the question, unique for the survey. (required).</param>
        /// <param name="surveyIdentifier">The unique survey identifier from the survey tool. (required).</param>
        /// <param name="link">link.</param>
        public EdFiSurveyQuestionReference(string _namespace = default(string), string questionCode = default(string), string surveyIdentifier = default(string), Link link = default(Link))
        {
            // to ensure "_namespace" is required (not null)
            this.Namespace = _namespace ?? throw new ArgumentNullException("_namespace is a required property for EdFiSurveyQuestionReference and cannot be null");
            // to ensure "questionCode" is required (not null)
            this.QuestionCode = questionCode ?? throw new ArgumentNullException("questionCode is a required property for EdFiSurveyQuestionReference and cannot be null");
            // to ensure "surveyIdentifier" is required (not null)
            this.SurveyIdentifier = surveyIdentifier ?? throw new ArgumentNullException("surveyIdentifier is a required property for EdFiSurveyQuestionReference and cannot be null");
            this.Link = link;
        }

        /// <summary>
        /// Namespace for the Survey.
        /// </summary>
        /// <value>Namespace for the Survey.</value>
        [DataMember(Name = "namespace", IsRequired = true, EmitDefaultValue = false)]
        public string Namespace { get; set; }

        /// <summary>
        /// The identifying code for the question, unique for the survey.
        /// </summary>
        /// <value>The identifying code for the question, unique for the survey.</value>
        [DataMember(Name = "questionCode", IsRequired = true, EmitDefaultValue = false)]
        public string QuestionCode { get; set; }

        /// <summary>
        /// The unique survey identifier from the survey tool.
        /// </summary>
        /// <value>The unique survey identifier from the survey tool.</value>
        [DataMember(Name = "surveyIdentifier", IsRequired = true, EmitDefaultValue = false)]
        public string SurveyIdentifier { get; set; }

        /// <summary>
        /// Gets or Sets Link
        /// </summary>
        [DataMember(Name = "link", EmitDefaultValue = false)]
        public Link Link { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiSurveyQuestionReference {\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  QuestionCode: ").Append(QuestionCode).Append("\n");
            sb.Append("  SurveyIdentifier: ").Append(SurveyIdentifier).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
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
            return this.Equals(input as EdFiSurveyQuestionReference);
        }

        /// <summary>
        /// Returns true if EdFiSurveyQuestionReference instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiSurveyQuestionReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiSurveyQuestionReference input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Namespace == input.Namespace ||
                    (this.Namespace != null &&
                    this.Namespace.Equals(input.Namespace))
                ) && 
                (
                    this.QuestionCode == input.QuestionCode ||
                    (this.QuestionCode != null &&
                    this.QuestionCode.Equals(input.QuestionCode))
                ) && 
                (
                    this.SurveyIdentifier == input.SurveyIdentifier ||
                    (this.SurveyIdentifier != null &&
                    this.SurveyIdentifier.Equals(input.SurveyIdentifier))
                ) && 
                (
                    this.Link == input.Link ||
                    (this.Link != null &&
                    this.Link.Equals(input.Link))
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
                if (this.Namespace != null)
                    hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                if (this.QuestionCode != null)
                    hashCode = hashCode * 59 + this.QuestionCode.GetHashCode();
                if (this.SurveyIdentifier != null)
                    hashCode = hashCode * 59 + this.SurveyIdentifier.GetHashCode();
                if (this.Link != null)
                    hashCode = hashCode * 59 + this.Link.GetHashCode();
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
            // Namespace (string) maxLength
            if(this.Namespace != null && this.Namespace.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Namespace, length must be less than 255.", new [] { "Namespace" });
            }

            // QuestionCode (string) maxLength
            if(this.QuestionCode != null && this.QuestionCode.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for QuestionCode, length must be less than 60.", new [] { "QuestionCode" });
            }

            // SurveyIdentifier (string) maxLength
            if(this.SurveyIdentifier != null && this.SurveyIdentifier.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SurveyIdentifier, length must be less than 60.", new [] { "SurveyIdentifier" });
            }

            yield break;
        }
    }

}
