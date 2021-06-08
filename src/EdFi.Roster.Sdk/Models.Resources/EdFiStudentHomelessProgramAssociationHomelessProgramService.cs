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
    /// EdFiStudentHomelessProgramAssociationHomelessProgramService
    /// </summary>
    [DataContract(Name = "edFi_studentHomelessProgramAssociationHomelessProgramService")]
    public partial class EdFiStudentHomelessProgramAssociationHomelessProgramService : IEquatable<EdFiStudentHomelessProgramAssociationHomelessProgramService>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentHomelessProgramAssociationHomelessProgramService" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStudentHomelessProgramAssociationHomelessProgramService() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentHomelessProgramAssociationHomelessProgramService" /> class.
        /// </summary>
        /// <param name="homelessProgramServiceDescriptor">Indicates the service being provided to the student by the Homeless Program. (required).</param>
        /// <param name="primaryIndicator">True if service is a primary service..</param>
        /// <param name="serviceBeginDate">First date the Student was in this option for the current school year..</param>
        /// <param name="serviceEndDate">Last date the Student was in this option for the current school year..</param>
        public EdFiStudentHomelessProgramAssociationHomelessProgramService(string homelessProgramServiceDescriptor = default(string), bool primaryIndicator = default(bool), DateTime serviceBeginDate = default(DateTime), DateTime serviceEndDate = default(DateTime))
        {
            // to ensure "homelessProgramServiceDescriptor" is required (not null)
            this.HomelessProgramServiceDescriptor = homelessProgramServiceDescriptor ?? throw new ArgumentNullException("homelessProgramServiceDescriptor is a required property for EdFiStudentHomelessProgramAssociationHomelessProgramService and cannot be null");
            this.PrimaryIndicator = primaryIndicator;
            this.ServiceBeginDate = serviceBeginDate;
            this.ServiceEndDate = serviceEndDate;
        }

        /// <summary>
        /// Indicates the service being provided to the student by the Homeless Program.
        /// </summary>
        /// <value>Indicates the service being provided to the student by the Homeless Program.</value>
        [DataMember(Name = "homelessProgramServiceDescriptor", IsRequired = true, EmitDefaultValue = false)]
        public string HomelessProgramServiceDescriptor { get; set; }

        /// <summary>
        /// True if service is a primary service.
        /// </summary>
        /// <value>True if service is a primary service.</value>
        [DataMember(Name = "primaryIndicator", EmitDefaultValue = true)]
        public bool PrimaryIndicator { get; set; }

        /// <summary>
        /// First date the Student was in this option for the current school year.
        /// </summary>
        /// <value>First date the Student was in this option for the current school year.</value>
        [DataMember(Name = "serviceBeginDate", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime ServiceBeginDate { get; set; }

        /// <summary>
        /// Last date the Student was in this option for the current school year.
        /// </summary>
        /// <value>Last date the Student was in this option for the current school year.</value>
        [DataMember(Name = "serviceEndDate", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime ServiceEndDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiStudentHomelessProgramAssociationHomelessProgramService {\n");
            sb.Append("  HomelessProgramServiceDescriptor: ").Append(HomelessProgramServiceDescriptor).Append("\n");
            sb.Append("  PrimaryIndicator: ").Append(PrimaryIndicator).Append("\n");
            sb.Append("  ServiceBeginDate: ").Append(ServiceBeginDate).Append("\n");
            sb.Append("  ServiceEndDate: ").Append(ServiceEndDate).Append("\n");
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
            return this.Equals(input as EdFiStudentHomelessProgramAssociationHomelessProgramService);
        }

        /// <summary>
        /// Returns true if EdFiStudentHomelessProgramAssociationHomelessProgramService instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiStudentHomelessProgramAssociationHomelessProgramService to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiStudentHomelessProgramAssociationHomelessProgramService input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HomelessProgramServiceDescriptor == input.HomelessProgramServiceDescriptor ||
                    (this.HomelessProgramServiceDescriptor != null &&
                    this.HomelessProgramServiceDescriptor.Equals(input.HomelessProgramServiceDescriptor))
                ) && 
                (
                    this.PrimaryIndicator == input.PrimaryIndicator ||
                    this.PrimaryIndicator.Equals(input.PrimaryIndicator)
                ) && 
                (
                    this.ServiceBeginDate == input.ServiceBeginDate ||
                    (this.ServiceBeginDate != null &&
                    this.ServiceBeginDate.Equals(input.ServiceBeginDate))
                ) && 
                (
                    this.ServiceEndDate == input.ServiceEndDate ||
                    (this.ServiceEndDate != null &&
                    this.ServiceEndDate.Equals(input.ServiceEndDate))
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
                if (this.HomelessProgramServiceDescriptor != null)
                    hashCode = hashCode * 59 + this.HomelessProgramServiceDescriptor.GetHashCode();
                hashCode = hashCode * 59 + this.PrimaryIndicator.GetHashCode();
                if (this.ServiceBeginDate != null)
                    hashCode = hashCode * 59 + this.ServiceBeginDate.GetHashCode();
                if (this.ServiceEndDate != null)
                    hashCode = hashCode * 59 + this.ServiceEndDate.GetHashCode();
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
            // HomelessProgramServiceDescriptor (string) maxLength
            if(this.HomelessProgramServiceDescriptor != null && this.HomelessProgramServiceDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for HomelessProgramServiceDescriptor, length must be less than 306.", new [] { "HomelessProgramServiceDescriptor" });
            }

            yield break;
        }
    }

}
