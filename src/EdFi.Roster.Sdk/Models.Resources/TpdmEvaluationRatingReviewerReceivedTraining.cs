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
    /// TpdmEvaluationRatingReviewerReceivedTraining
    /// </summary>
    [DataContract(Name = "tpdm_evaluationRatingReviewerReceivedTraining")]
    public partial class TpdmEvaluationRatingReviewerReceivedTraining : IEquatable<TpdmEvaluationRatingReviewerReceivedTraining>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmEvaluationRatingReviewerReceivedTraining" /> class.
        /// </summary>
        /// <param name="interRaterReliabilityScore">A score indicating how much homogeneity, or consensus, there is in the ratings given by judges..</param>
        /// <param name="receivedTrainingDate">The date on which the person administering the performance meausre received training on how to conduct performance measures..</param>
        public TpdmEvaluationRatingReviewerReceivedTraining(int interRaterReliabilityScore = default(int), DateTime receivedTrainingDate = default(DateTime))
        {
            this.InterRaterReliabilityScore = interRaterReliabilityScore;
            this.ReceivedTrainingDate = receivedTrainingDate;
        }

        /// <summary>
        /// A score indicating how much homogeneity, or consensus, there is in the ratings given by judges.
        /// </summary>
        /// <value>A score indicating how much homogeneity, or consensus, there is in the ratings given by judges.</value>
        [DataMember(Name = "interRaterReliabilityScore", EmitDefaultValue = false)]
        public int InterRaterReliabilityScore { get; set; }

        /// <summary>
        /// The date on which the person administering the performance meausre received training on how to conduct performance measures.
        /// </summary>
        /// <value>The date on which the person administering the performance meausre received training on how to conduct performance measures.</value>
        [DataMember(Name = "receivedTrainingDate", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime ReceivedTrainingDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TpdmEvaluationRatingReviewerReceivedTraining {\n");
            sb.Append("  InterRaterReliabilityScore: ").Append(InterRaterReliabilityScore).Append("\n");
            sb.Append("  ReceivedTrainingDate: ").Append(ReceivedTrainingDate).Append("\n");
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
            return this.Equals(input as TpdmEvaluationRatingReviewerReceivedTraining);
        }

        /// <summary>
        /// Returns true if TpdmEvaluationRatingReviewerReceivedTraining instances are equal
        /// </summary>
        /// <param name="input">Instance of TpdmEvaluationRatingReviewerReceivedTraining to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TpdmEvaluationRatingReviewerReceivedTraining input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InterRaterReliabilityScore == input.InterRaterReliabilityScore ||
                    this.InterRaterReliabilityScore.Equals(input.InterRaterReliabilityScore)
                ) && 
                (
                    this.ReceivedTrainingDate == input.ReceivedTrainingDate ||
                    (this.ReceivedTrainingDate != null &&
                    this.ReceivedTrainingDate.Equals(input.ReceivedTrainingDate))
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
                hashCode = hashCode * 59 + this.InterRaterReliabilityScore.GetHashCode();
                if (this.ReceivedTrainingDate != null)
                    hashCode = hashCode * 59 + this.ReceivedTrainingDate.GetHashCode();
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
