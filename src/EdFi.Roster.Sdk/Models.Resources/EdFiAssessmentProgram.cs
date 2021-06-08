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
    /// EdFiAssessmentProgram
    /// </summary>
    [DataContract(Name = "edFi_assessmentProgram")]
    public partial class EdFiAssessmentProgram : IEquatable<EdFiAssessmentProgram>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiAssessmentProgram" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiAssessmentProgram() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiAssessmentProgram" /> class.
        /// </summary>
        /// <param name="programReference">programReference (required).</param>
        public EdFiAssessmentProgram(EdFiProgramReference programReference = default(EdFiProgramReference))
        {
            // to ensure "programReference" is required (not null)
            this.ProgramReference = programReference ?? throw new ArgumentNullException("programReference is a required property for EdFiAssessmentProgram and cannot be null");
        }

        /// <summary>
        /// Gets or Sets ProgramReference
        /// </summary>
        [DataMember(Name = "programReference", IsRequired = true, EmitDefaultValue = false)]
        public EdFiProgramReference ProgramReference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiAssessmentProgram {\n");
            sb.Append("  ProgramReference: ").Append(ProgramReference).Append("\n");
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
            return this.Equals(input as EdFiAssessmentProgram);
        }

        /// <summary>
        /// Returns true if EdFiAssessmentProgram instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiAssessmentProgram to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiAssessmentProgram input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProgramReference == input.ProgramReference ||
                    (this.ProgramReference != null &&
                    this.ProgramReference.Equals(input.ProgramReference))
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
                if (this.ProgramReference != null)
                    hashCode = hashCode * 59 + this.ProgramReference.GetHashCode();
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
