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
    /// EdFiAssessmentPlatformType
    /// </summary>
    [DataContract(Name = "edFi_assessmentPlatformType")]
    public partial class EdFiAssessmentPlatformType : IEquatable<EdFiAssessmentPlatformType>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiAssessmentPlatformType" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiAssessmentPlatformType() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiAssessmentPlatformType" /> class.
        /// </summary>
        /// <param name="platformTypeDescriptor">The platforms with which the assessment may be delivered. (required).</param>
        public EdFiAssessmentPlatformType(string platformTypeDescriptor = default(string))
        {
            // to ensure "platformTypeDescriptor" is required (not null)
            this.PlatformTypeDescriptor = platformTypeDescriptor ?? throw new ArgumentNullException("platformTypeDescriptor is a required property for EdFiAssessmentPlatformType and cannot be null");
        }

        /// <summary>
        /// The platforms with which the assessment may be delivered.
        /// </summary>
        /// <value>The platforms with which the assessment may be delivered.</value>
        [DataMember(Name = "platformTypeDescriptor", IsRequired = true, EmitDefaultValue = false)]
        public string PlatformTypeDescriptor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiAssessmentPlatformType {\n");
            sb.Append("  PlatformTypeDescriptor: ").Append(PlatformTypeDescriptor).Append("\n");
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
            return this.Equals(input as EdFiAssessmentPlatformType);
        }

        /// <summary>
        /// Returns true if EdFiAssessmentPlatformType instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiAssessmentPlatformType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiAssessmentPlatformType input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PlatformTypeDescriptor == input.PlatformTypeDescriptor ||
                    (this.PlatformTypeDescriptor != null &&
                    this.PlatformTypeDescriptor.Equals(input.PlatformTypeDescriptor))
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
                if (this.PlatformTypeDescriptor != null)
                    hashCode = hashCode * 59 + this.PlatformTypeDescriptor.GetHashCode();
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
            // PlatformTypeDescriptor (string) maxLength
            if(this.PlatformTypeDescriptor != null && this.PlatformTypeDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PlatformTypeDescriptor, length must be less than 306.", new [] { "PlatformTypeDescriptor" });
            }

            yield break;
        }
    }

}
