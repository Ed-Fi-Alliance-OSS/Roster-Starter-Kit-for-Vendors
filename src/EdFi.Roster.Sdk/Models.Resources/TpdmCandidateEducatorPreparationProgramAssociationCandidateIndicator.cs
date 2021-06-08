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
    /// TpdmCandidateEducatorPreparationProgramAssociationCandidateIndicator
    /// </summary>
    [DataContract(Name = "tpdm_candidateEducatorPreparationProgramAssociationCandidateIndicator")]
    public partial class TpdmCandidateEducatorPreparationProgramAssociationCandidateIndicator : IEquatable<TpdmCandidateEducatorPreparationProgramAssociationCandidateIndicator>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmCandidateEducatorPreparationProgramAssociationCandidateIndicator" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TpdmCandidateEducatorPreparationProgramAssociationCandidateIndicator() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmCandidateEducatorPreparationProgramAssociationCandidateIndicator" /> class.
        /// </summary>
        /// <param name="designatedBy">The person, organization, or department that designated the program association..</param>
        /// <param name="indicator">The value of the indicator or metric. (required).</param>
        /// <param name="indicatorGroup">The name for a group of indicators..</param>
        /// <param name="indicatorName">The name of the indicator or metric. (required).</param>
        /// <param name="period">period.</param>
        public TpdmCandidateEducatorPreparationProgramAssociationCandidateIndicator(string designatedBy = default(string), string indicator = default(string), string indicatorGroup = default(string), string indicatorName = default(string), TpdmCandidateEducatorPreparationProgramAssociationCandidateIndicatorPeriod period = default(TpdmCandidateEducatorPreparationProgramAssociationCandidateIndicatorPeriod))
        {
            // to ensure "indicator" is required (not null)
            this.Indicator = indicator ?? throw new ArgumentNullException("indicator is a required property for TpdmCandidateEducatorPreparationProgramAssociationCandidateIndicator and cannot be null");
            // to ensure "indicatorName" is required (not null)
            this.IndicatorName = indicatorName ?? throw new ArgumentNullException("indicatorName is a required property for TpdmCandidateEducatorPreparationProgramAssociationCandidateIndicator and cannot be null");
            this.DesignatedBy = designatedBy;
            this.IndicatorGroup = indicatorGroup;
            this.Period = period;
        }

        /// <summary>
        /// The person, organization, or department that designated the program association.
        /// </summary>
        /// <value>The person, organization, or department that designated the program association.</value>
        [DataMember(Name = "designatedBy", EmitDefaultValue = false)]
        public string DesignatedBy { get; set; }

        /// <summary>
        /// The value of the indicator or metric.
        /// </summary>
        /// <value>The value of the indicator or metric.</value>
        [DataMember(Name = "indicator", IsRequired = true, EmitDefaultValue = false)]
        public string Indicator { get; set; }

        /// <summary>
        /// The name for a group of indicators.
        /// </summary>
        /// <value>The name for a group of indicators.</value>
        [DataMember(Name = "indicatorGroup", EmitDefaultValue = false)]
        public string IndicatorGroup { get; set; }

        /// <summary>
        /// The name of the indicator or metric.
        /// </summary>
        /// <value>The name of the indicator or metric.</value>
        [DataMember(Name = "indicatorName", IsRequired = true, EmitDefaultValue = false)]
        public string IndicatorName { get; set; }

        /// <summary>
        /// Gets or Sets Period
        /// </summary>
        [DataMember(Name = "period", EmitDefaultValue = false)]
        public TpdmCandidateEducatorPreparationProgramAssociationCandidateIndicatorPeriod Period { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TpdmCandidateEducatorPreparationProgramAssociationCandidateIndicator {\n");
            sb.Append("  DesignatedBy: ").Append(DesignatedBy).Append("\n");
            sb.Append("  Indicator: ").Append(Indicator).Append("\n");
            sb.Append("  IndicatorGroup: ").Append(IndicatorGroup).Append("\n");
            sb.Append("  IndicatorName: ").Append(IndicatorName).Append("\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
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
            return this.Equals(input as TpdmCandidateEducatorPreparationProgramAssociationCandidateIndicator);
        }

        /// <summary>
        /// Returns true if TpdmCandidateEducatorPreparationProgramAssociationCandidateIndicator instances are equal
        /// </summary>
        /// <param name="input">Instance of TpdmCandidateEducatorPreparationProgramAssociationCandidateIndicator to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TpdmCandidateEducatorPreparationProgramAssociationCandidateIndicator input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DesignatedBy == input.DesignatedBy ||
                    (this.DesignatedBy != null &&
                    this.DesignatedBy.Equals(input.DesignatedBy))
                ) && 
                (
                    this.Indicator == input.Indicator ||
                    (this.Indicator != null &&
                    this.Indicator.Equals(input.Indicator))
                ) && 
                (
                    this.IndicatorGroup == input.IndicatorGroup ||
                    (this.IndicatorGroup != null &&
                    this.IndicatorGroup.Equals(input.IndicatorGroup))
                ) && 
                (
                    this.IndicatorName == input.IndicatorName ||
                    (this.IndicatorName != null &&
                    this.IndicatorName.Equals(input.IndicatorName))
                ) && 
                (
                    this.Period == input.Period ||
                    (this.Period != null &&
                    this.Period.Equals(input.Period))
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
                if (this.DesignatedBy != null)
                    hashCode = hashCode * 59 + this.DesignatedBy.GetHashCode();
                if (this.Indicator != null)
                    hashCode = hashCode * 59 + this.Indicator.GetHashCode();
                if (this.IndicatorGroup != null)
                    hashCode = hashCode * 59 + this.IndicatorGroup.GetHashCode();
                if (this.IndicatorName != null)
                    hashCode = hashCode * 59 + this.IndicatorName.GetHashCode();
                if (this.Period != null)
                    hashCode = hashCode * 59 + this.Period.GetHashCode();
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
            // DesignatedBy (string) maxLength
            if(this.DesignatedBy != null && this.DesignatedBy.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DesignatedBy, length must be less than 60.", new [] { "DesignatedBy" });
            }

            // Indicator (string) maxLength
            if(this.Indicator != null && this.Indicator.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Indicator, length must be less than 60.", new [] { "Indicator" });
            }

            // IndicatorGroup (string) maxLength
            if(this.IndicatorGroup != null && this.IndicatorGroup.Length > 200)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IndicatorGroup, length must be less than 200.", new [] { "IndicatorGroup" });
            }

            // IndicatorName (string) maxLength
            if(this.IndicatorName != null && this.IndicatorName.Length > 200)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IndicatorName, length must be less than 200.", new [] { "IndicatorName" });
            }

            yield break;
        }
    }

}
