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
    /// TpdmFieldworkExperienceCoteaching
    /// </summary>
    [DataContract(Name = "tpdm_fieldworkExperienceCoteaching")]
    public partial class TpdmFieldworkExperienceCoteaching : IEquatable<TpdmFieldworkExperienceCoteaching>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmFieldworkExperienceCoteaching" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TpdmFieldworkExperienceCoteaching() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmFieldworkExperienceCoteaching" /> class.
        /// </summary>
        /// <param name="coteachingBeginDate">The month, day, and year on which the teacher candidate first starts co-teaching. (required).</param>
        /// <param name="coteachingEndDate">The month, day, and year on which the teacher candidate stopped co-teaching..</param>
        public TpdmFieldworkExperienceCoteaching(DateTime coteachingBeginDate = default(DateTime), DateTime coteachingEndDate = default(DateTime))
        {
            this.CoteachingBeginDate = coteachingBeginDate;
            this.CoteachingEndDate = coteachingEndDate;
        }

        /// <summary>
        /// The month, day, and year on which the teacher candidate first starts co-teaching.
        /// </summary>
        /// <value>The month, day, and year on which the teacher candidate first starts co-teaching.</value>
        [DataMember(Name = "coteachingBeginDate", IsRequired = true, EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime CoteachingBeginDate { get; set; }

        /// <summary>
        /// The month, day, and year on which the teacher candidate stopped co-teaching.
        /// </summary>
        /// <value>The month, day, and year on which the teacher candidate stopped co-teaching.</value>
        [DataMember(Name = "coteachingEndDate", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime CoteachingEndDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TpdmFieldworkExperienceCoteaching {\n");
            sb.Append("  CoteachingBeginDate: ").Append(CoteachingBeginDate).Append("\n");
            sb.Append("  CoteachingEndDate: ").Append(CoteachingEndDate).Append("\n");
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
            return this.Equals(input as TpdmFieldworkExperienceCoteaching);
        }

        /// <summary>
        /// Returns true if TpdmFieldworkExperienceCoteaching instances are equal
        /// </summary>
        /// <param name="input">Instance of TpdmFieldworkExperienceCoteaching to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TpdmFieldworkExperienceCoteaching input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CoteachingBeginDate == input.CoteachingBeginDate ||
                    (this.CoteachingBeginDate != null &&
                    this.CoteachingBeginDate.Equals(input.CoteachingBeginDate))
                ) && 
                (
                    this.CoteachingEndDate == input.CoteachingEndDate ||
                    (this.CoteachingEndDate != null &&
                    this.CoteachingEndDate.Equals(input.CoteachingEndDate))
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
                if (this.CoteachingBeginDate != null)
                    hashCode = hashCode * 59 + this.CoteachingBeginDate.GetHashCode();
                if (this.CoteachingEndDate != null)
                    hashCode = hashCode * 59 + this.CoteachingEndDate.GetHashCode();
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
