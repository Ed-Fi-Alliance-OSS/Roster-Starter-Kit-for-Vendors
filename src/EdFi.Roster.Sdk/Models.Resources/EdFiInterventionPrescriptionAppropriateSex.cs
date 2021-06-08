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
    /// EdFiInterventionPrescriptionAppropriateSex
    /// </summary>
    [DataContract(Name = "edFi_interventionPrescriptionAppropriateSex")]
    public partial class EdFiInterventionPrescriptionAppropriateSex : IEquatable<EdFiInterventionPrescriptionAppropriateSex>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiInterventionPrescriptionAppropriateSex" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiInterventionPrescriptionAppropriateSex() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiInterventionPrescriptionAppropriateSex" /> class.
        /// </summary>
        /// <param name="sexDescriptor">Sexes for the InterventionPrescription. If omitted, considered generally applicable. (required).</param>
        public EdFiInterventionPrescriptionAppropriateSex(string sexDescriptor = default(string))
        {
            // to ensure "sexDescriptor" is required (not null)
            this.SexDescriptor = sexDescriptor ?? throw new ArgumentNullException("sexDescriptor is a required property for EdFiInterventionPrescriptionAppropriateSex and cannot be null");
        }

        /// <summary>
        /// Sexes for the InterventionPrescription. If omitted, considered generally applicable.
        /// </summary>
        /// <value>Sexes for the InterventionPrescription. If omitted, considered generally applicable.</value>
        [DataMember(Name = "sexDescriptor", IsRequired = true, EmitDefaultValue = false)]
        public string SexDescriptor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiInterventionPrescriptionAppropriateSex {\n");
            sb.Append("  SexDescriptor: ").Append(SexDescriptor).Append("\n");
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
            return this.Equals(input as EdFiInterventionPrescriptionAppropriateSex);
        }

        /// <summary>
        /// Returns true if EdFiInterventionPrescriptionAppropriateSex instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiInterventionPrescriptionAppropriateSex to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiInterventionPrescriptionAppropriateSex input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SexDescriptor == input.SexDescriptor ||
                    (this.SexDescriptor != null &&
                    this.SexDescriptor.Equals(input.SexDescriptor))
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
                if (this.SexDescriptor != null)
                    hashCode = hashCode * 59 + this.SexDescriptor.GetHashCode();
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
            // SexDescriptor (string) maxLength
            if(this.SexDescriptor != null && this.SexDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SexDescriptor, length must be less than 306.", new [] { "SexDescriptor" });
            }

            yield break;
        }
    }

}
