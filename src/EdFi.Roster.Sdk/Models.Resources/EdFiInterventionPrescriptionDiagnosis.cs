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
    /// EdFiInterventionPrescriptionDiagnosis
    /// </summary>
    [DataContract(Name = "edFi_interventionPrescriptionDiagnosis")]
    public partial class EdFiInterventionPrescriptionDiagnosis : IEquatable<EdFiInterventionPrescriptionDiagnosis>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiInterventionPrescriptionDiagnosis" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiInterventionPrescriptionDiagnosis() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiInterventionPrescriptionDiagnosis" /> class.
        /// </summary>
        /// <param name="diagnosisDescriptor">Targeted purpose of the InterventionPrescription (e.g., attendance issue, dropout risk). (required).</param>
        public EdFiInterventionPrescriptionDiagnosis(string diagnosisDescriptor = default(string))
        {
            // to ensure "diagnosisDescriptor" is required (not null)
            this.DiagnosisDescriptor = diagnosisDescriptor ?? throw new ArgumentNullException("diagnosisDescriptor is a required property for EdFiInterventionPrescriptionDiagnosis and cannot be null");
        }

        /// <summary>
        /// Targeted purpose of the InterventionPrescription (e.g., attendance issue, dropout risk).
        /// </summary>
        /// <value>Targeted purpose of the InterventionPrescription (e.g., attendance issue, dropout risk).</value>
        [DataMember(Name = "diagnosisDescriptor", IsRequired = true, EmitDefaultValue = false)]
        public string DiagnosisDescriptor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiInterventionPrescriptionDiagnosis {\n");
            sb.Append("  DiagnosisDescriptor: ").Append(DiagnosisDescriptor).Append("\n");
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
            return this.Equals(input as EdFiInterventionPrescriptionDiagnosis);
        }

        /// <summary>
        /// Returns true if EdFiInterventionPrescriptionDiagnosis instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiInterventionPrescriptionDiagnosis to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiInterventionPrescriptionDiagnosis input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DiagnosisDescriptor == input.DiagnosisDescriptor ||
                    (this.DiagnosisDescriptor != null &&
                    this.DiagnosisDescriptor.Equals(input.DiagnosisDescriptor))
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
                if (this.DiagnosisDescriptor != null)
                    hashCode = hashCode * 59 + this.DiagnosisDescriptor.GetHashCode();
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
            // DiagnosisDescriptor (string) maxLength
            if(this.DiagnosisDescriptor != null && this.DiagnosisDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DiagnosisDescriptor, length must be less than 306.", new [] { "DiagnosisDescriptor" });
            }

            yield break;
        }
    }

}
