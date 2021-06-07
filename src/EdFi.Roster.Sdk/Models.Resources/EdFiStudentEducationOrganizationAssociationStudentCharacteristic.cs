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
    /// EdFiStudentEducationOrganizationAssociationStudentCharacteristic
    /// </summary>
    [DataContract(Name = "edFi_studentEducationOrganizationAssociationStudentCharacteristic")]
    public partial class EdFiStudentEducationOrganizationAssociationStudentCharacteristic : IEquatable<EdFiStudentEducationOrganizationAssociationStudentCharacteristic>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentEducationOrganizationAssociationStudentCharacteristic" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStudentEducationOrganizationAssociationStudentCharacteristic() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentEducationOrganizationAssociationStudentCharacteristic" /> class.
        /// </summary>
        /// <param name="studentCharacteristicDescriptor">The characteristic designated for the Student. (required).</param>
        /// <param name="designatedBy">The person, organization, or department that designated the characteristic..</param>
        /// <param name="periods">An unordered collection of studentEducationOrganizationAssociationStudentCharacteristicPeriods. The time periods for which characteristic was effective..</param>
        public EdFiStudentEducationOrganizationAssociationStudentCharacteristic(string studentCharacteristicDescriptor = default(string), string designatedBy = default(string), List<EdFiStudentEducationOrganizationAssociationStudentCharacteristicPeriod> periods = default(List<EdFiStudentEducationOrganizationAssociationStudentCharacteristicPeriod>))
        {
            // to ensure "studentCharacteristicDescriptor" is required (not null)
            this.StudentCharacteristicDescriptor = studentCharacteristicDescriptor ?? throw new ArgumentNullException("studentCharacteristicDescriptor is a required property for EdFiStudentEducationOrganizationAssociationStudentCharacteristic and cannot be null");
            this.DesignatedBy = designatedBy;
            this.Periods = periods;
        }

        /// <summary>
        /// The characteristic designated for the Student.
        /// </summary>
        /// <value>The characteristic designated for the Student.</value>
        [DataMember(Name = "studentCharacteristicDescriptor", IsRequired = true, EmitDefaultValue = false)]
        public string StudentCharacteristicDescriptor { get; set; }

        /// <summary>
        /// The person, organization, or department that designated the characteristic.
        /// </summary>
        /// <value>The person, organization, or department that designated the characteristic.</value>
        [DataMember(Name = "designatedBy", EmitDefaultValue = false)]
        public string DesignatedBy { get; set; }

        /// <summary>
        /// An unordered collection of studentEducationOrganizationAssociationStudentCharacteristicPeriods. The time periods for which characteristic was effective.
        /// </summary>
        /// <value>An unordered collection of studentEducationOrganizationAssociationStudentCharacteristicPeriods. The time periods for which characteristic was effective.</value>
        [DataMember(Name = "periods", EmitDefaultValue = false)]
        public List<EdFiStudentEducationOrganizationAssociationStudentCharacteristicPeriod> Periods { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiStudentEducationOrganizationAssociationStudentCharacteristic {\n");
            sb.Append("  StudentCharacteristicDescriptor: ").Append(StudentCharacteristicDescriptor).Append("\n");
            sb.Append("  DesignatedBy: ").Append(DesignatedBy).Append("\n");
            sb.Append("  Periods: ").Append(Periods).Append("\n");
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
            return this.Equals(input as EdFiStudentEducationOrganizationAssociationStudentCharacteristic);
        }

        /// <summary>
        /// Returns true if EdFiStudentEducationOrganizationAssociationStudentCharacteristic instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiStudentEducationOrganizationAssociationStudentCharacteristic to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiStudentEducationOrganizationAssociationStudentCharacteristic input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StudentCharacteristicDescriptor == input.StudentCharacteristicDescriptor ||
                    (this.StudentCharacteristicDescriptor != null &&
                    this.StudentCharacteristicDescriptor.Equals(input.StudentCharacteristicDescriptor))
                ) && 
                (
                    this.DesignatedBy == input.DesignatedBy ||
                    (this.DesignatedBy != null &&
                    this.DesignatedBy.Equals(input.DesignatedBy))
                ) && 
                (
                    this.Periods == input.Periods ||
                    this.Periods != null &&
                    input.Periods != null &&
                    this.Periods.SequenceEqual(input.Periods)
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
                if (this.StudentCharacteristicDescriptor != null)
                    hashCode = hashCode * 59 + this.StudentCharacteristicDescriptor.GetHashCode();
                if (this.DesignatedBy != null)
                    hashCode = hashCode * 59 + this.DesignatedBy.GetHashCode();
                if (this.Periods != null)
                    hashCode = hashCode * 59 + this.Periods.GetHashCode();
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
            // StudentCharacteristicDescriptor (string) maxLength
            if(this.StudentCharacteristicDescriptor != null && this.StudentCharacteristicDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StudentCharacteristicDescriptor, length must be less than 306.", new [] { "StudentCharacteristicDescriptor" });
            }

            // DesignatedBy (string) maxLength
            if(this.DesignatedBy != null && this.DesignatedBy.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DesignatedBy, length must be less than 60.", new [] { "DesignatedBy" });
            }

            yield break;
        }
    }

}
