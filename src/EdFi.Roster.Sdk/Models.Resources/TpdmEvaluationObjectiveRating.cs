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
    /// TpdmEvaluationObjectiveRating
    /// </summary>
    [DataContract(Name = "tpdm_evaluationObjectiveRating")]
    public partial class TpdmEvaluationObjectiveRating : IEquatable<TpdmEvaluationObjectiveRating>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmEvaluationObjectiveRating" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TpdmEvaluationObjectiveRating() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmEvaluationObjectiveRating" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="evaluationObjectiveReference">evaluationObjectiveReference (required).</param>
        /// <param name="evaluationRatingReference">evaluationRatingReference (required).</param>
        /// <param name="comments">Any comments about the performance evaluation to be captured..</param>
        /// <param name="objectiveRatingLevelDescriptor">The rating level achieved based upon the rating or score..</param>
        /// <param name="results">An unordered collection of evaluationObjectiveRatingResults. The numerical summary rating or score for the evaluation Objective..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        public TpdmEvaluationObjectiveRating(string id = default(string), TpdmEvaluationObjectiveReference evaluationObjectiveReference = default(TpdmEvaluationObjectiveReference), TpdmEvaluationRatingReference evaluationRatingReference = default(TpdmEvaluationRatingReference), string comments = default(string), string objectiveRatingLevelDescriptor = default(string), List<TpdmEvaluationObjectiveRatingResult> results = default(List<TpdmEvaluationObjectiveRatingResult>), string etag = default(string))
        {
            // to ensure "evaluationObjectiveReference" is required (not null)
            this.EvaluationObjectiveReference = evaluationObjectiveReference ?? throw new ArgumentNullException("evaluationObjectiveReference is a required property for TpdmEvaluationObjectiveRating and cannot be null");
            // to ensure "evaluationRatingReference" is required (not null)
            this.EvaluationRatingReference = evaluationRatingReference ?? throw new ArgumentNullException("evaluationRatingReference is a required property for TpdmEvaluationObjectiveRating and cannot be null");
            this.Id = id;
            this.Comments = comments;
            this.ObjectiveRatingLevelDescriptor = objectiveRatingLevelDescriptor;
            this.Results = results;
            this.Etag = etag;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets EvaluationObjectiveReference
        /// </summary>
        [DataMember(Name = "evaluationObjectiveReference", IsRequired = true, EmitDefaultValue = false)]
        public TpdmEvaluationObjectiveReference EvaluationObjectiveReference { get; set; }

        /// <summary>
        /// Gets or Sets EvaluationRatingReference
        /// </summary>
        [DataMember(Name = "evaluationRatingReference", IsRequired = true, EmitDefaultValue = false)]
        public TpdmEvaluationRatingReference EvaluationRatingReference { get; set; }

        /// <summary>
        /// Any comments about the performance evaluation to be captured.
        /// </summary>
        /// <value>Any comments about the performance evaluation to be captured.</value>
        [DataMember(Name = "comments", EmitDefaultValue = false)]
        public string Comments { get; set; }

        /// <summary>
        /// The rating level achieved based upon the rating or score.
        /// </summary>
        /// <value>The rating level achieved based upon the rating or score.</value>
        [DataMember(Name = "objectiveRatingLevelDescriptor", EmitDefaultValue = false)]
        public string ObjectiveRatingLevelDescriptor { get; set; }

        /// <summary>
        /// An unordered collection of evaluationObjectiveRatingResults. The numerical summary rating or score for the evaluation Objective.
        /// </summary>
        /// <value>An unordered collection of evaluationObjectiveRatingResults. The numerical summary rating or score for the evaluation Objective.</value>
        [DataMember(Name = "results", EmitDefaultValue = false)]
        public List<TpdmEvaluationObjectiveRatingResult> Results { get; set; }

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
            sb.Append("class TpdmEvaluationObjectiveRating {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  EvaluationObjectiveReference: ").Append(EvaluationObjectiveReference).Append("\n");
            sb.Append("  EvaluationRatingReference: ").Append(EvaluationRatingReference).Append("\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
            sb.Append("  ObjectiveRatingLevelDescriptor: ").Append(ObjectiveRatingLevelDescriptor).Append("\n");
            sb.Append("  Results: ").Append(Results).Append("\n");
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
            return this.Equals(input as TpdmEvaluationObjectiveRating);
        }

        /// <summary>
        /// Returns true if TpdmEvaluationObjectiveRating instances are equal
        /// </summary>
        /// <param name="input">Instance of TpdmEvaluationObjectiveRating to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TpdmEvaluationObjectiveRating input)
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
                    this.EvaluationObjectiveReference == input.EvaluationObjectiveReference ||
                    (this.EvaluationObjectiveReference != null &&
                    this.EvaluationObjectiveReference.Equals(input.EvaluationObjectiveReference))
                ) && 
                (
                    this.EvaluationRatingReference == input.EvaluationRatingReference ||
                    (this.EvaluationRatingReference != null &&
                    this.EvaluationRatingReference.Equals(input.EvaluationRatingReference))
                ) && 
                (
                    this.Comments == input.Comments ||
                    (this.Comments != null &&
                    this.Comments.Equals(input.Comments))
                ) && 
                (
                    this.ObjectiveRatingLevelDescriptor == input.ObjectiveRatingLevelDescriptor ||
                    (this.ObjectiveRatingLevelDescriptor != null &&
                    this.ObjectiveRatingLevelDescriptor.Equals(input.ObjectiveRatingLevelDescriptor))
                ) && 
                (
                    this.Results == input.Results ||
                    this.Results != null &&
                    input.Results != null &&
                    this.Results.SequenceEqual(input.Results)
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
                if (this.EvaluationObjectiveReference != null)
                    hashCode = hashCode * 59 + this.EvaluationObjectiveReference.GetHashCode();
                if (this.EvaluationRatingReference != null)
                    hashCode = hashCode * 59 + this.EvaluationRatingReference.GetHashCode();
                if (this.Comments != null)
                    hashCode = hashCode * 59 + this.Comments.GetHashCode();
                if (this.ObjectiveRatingLevelDescriptor != null)
                    hashCode = hashCode * 59 + this.ObjectiveRatingLevelDescriptor.GetHashCode();
                if (this.Results != null)
                    hashCode = hashCode * 59 + this.Results.GetHashCode();
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
            // Comments (string) maxLength
            if(this.Comments != null && this.Comments.Length > 1024)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Comments, length must be less than 1024.", new [] { "Comments" });
            }

            // ObjectiveRatingLevelDescriptor (string) maxLength
            if(this.ObjectiveRatingLevelDescriptor != null && this.ObjectiveRatingLevelDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ObjectiveRatingLevelDescriptor, length must be less than 306.", new [] { "ObjectiveRatingLevelDescriptor" });
            }

            yield break;
        }
    }

}
