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
    /// EdFiEducationContentDerivativeSourceURI
    /// </summary>
    [DataContract(Name = "edFi_educationContentDerivativeSourceURI")]
    public partial class EdFiEducationContentDerivativeSourceURI : IEquatable<EdFiEducationContentDerivativeSourceURI>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiEducationContentDerivativeSourceURI" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiEducationContentDerivativeSourceURI() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiEducationContentDerivativeSourceURI" /> class.
        /// </summary>
        /// <param name="derivativeSourceURI">The URI (typical a URL) pointing to an education content item. (required).</param>
        public EdFiEducationContentDerivativeSourceURI(string derivativeSourceURI = default(string))
        {
            // to ensure "derivativeSourceURI" is required (not null)
            this.DerivativeSourceURI = derivativeSourceURI ?? throw new ArgumentNullException("derivativeSourceURI is a required property for EdFiEducationContentDerivativeSourceURI and cannot be null");
        }

        /// <summary>
        /// The URI (typical a URL) pointing to an education content item.
        /// </summary>
        /// <value>The URI (typical a URL) pointing to an education content item.</value>
        [DataMember(Name = "derivativeSourceURI", IsRequired = true, EmitDefaultValue = false)]
        public string DerivativeSourceURI { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiEducationContentDerivativeSourceURI {\n");
            sb.Append("  DerivativeSourceURI: ").Append(DerivativeSourceURI).Append("\n");
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
            return this.Equals(input as EdFiEducationContentDerivativeSourceURI);
        }

        /// <summary>
        /// Returns true if EdFiEducationContentDerivativeSourceURI instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiEducationContentDerivativeSourceURI to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiEducationContentDerivativeSourceURI input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DerivativeSourceURI == input.DerivativeSourceURI ||
                    (this.DerivativeSourceURI != null &&
                    this.DerivativeSourceURI.Equals(input.DerivativeSourceURI))
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
                if (this.DerivativeSourceURI != null)
                    hashCode = hashCode * 59 + this.DerivativeSourceURI.GetHashCode();
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
            // DerivativeSourceURI (string) maxLength
            if(this.DerivativeSourceURI != null && this.DerivativeSourceURI.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DerivativeSourceURI, length must be less than 255.", new [] { "DerivativeSourceURI" });
            }

            yield break;
        }
    }

}
