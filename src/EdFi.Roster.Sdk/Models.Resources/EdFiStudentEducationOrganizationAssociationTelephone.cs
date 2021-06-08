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
    /// EdFiStudentEducationOrganizationAssociationTelephone
    /// </summary>
    [DataContract(Name = "edFi_studentEducationOrganizationAssociationTelephone")]
    public partial class EdFiStudentEducationOrganizationAssociationTelephone : IEquatable<EdFiStudentEducationOrganizationAssociationTelephone>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentEducationOrganizationAssociationTelephone" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStudentEducationOrganizationAssociationTelephone() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentEducationOrganizationAssociationTelephone" /> class.
        /// </summary>
        /// <param name="telephoneNumberTypeDescriptor">The type of communication number listed for an individual or organization. (required).</param>
        /// <param name="telephoneNumber">The telephone number including the area code, and extension, if applicable. (required).</param>
        /// <param name="doNotPublishIndicator">An indication that the telephone number should not be published..</param>
        /// <param name="orderOfPriority">The order of priority assigned to telephone numbers to define which number to attempt first, second, etc..</param>
        /// <param name="textMessageCapabilityIndicator">An indication that the telephone number is technically capable of sending and receiving Short Message Service (SMS) text messages..</param>
        public EdFiStudentEducationOrganizationAssociationTelephone(string telephoneNumberTypeDescriptor = default(string), string telephoneNumber = default(string), bool doNotPublishIndicator = default(bool), int orderOfPriority = default(int), bool textMessageCapabilityIndicator = default(bool))
        {
            // to ensure "telephoneNumberTypeDescriptor" is required (not null)
            this.TelephoneNumberTypeDescriptor = telephoneNumberTypeDescriptor ?? throw new ArgumentNullException("telephoneNumberTypeDescriptor is a required property for EdFiStudentEducationOrganizationAssociationTelephone and cannot be null");
            // to ensure "telephoneNumber" is required (not null)
            this.TelephoneNumber = telephoneNumber ?? throw new ArgumentNullException("telephoneNumber is a required property for EdFiStudentEducationOrganizationAssociationTelephone and cannot be null");
            this.DoNotPublishIndicator = doNotPublishIndicator;
            this.OrderOfPriority = orderOfPriority;
            this.TextMessageCapabilityIndicator = textMessageCapabilityIndicator;
        }

        /// <summary>
        /// The type of communication number listed for an individual or organization.
        /// </summary>
        /// <value>The type of communication number listed for an individual or organization.</value>
        [DataMember(Name = "telephoneNumberTypeDescriptor", IsRequired = true, EmitDefaultValue = false)]
        public string TelephoneNumberTypeDescriptor { get; set; }

        /// <summary>
        /// The telephone number including the area code, and extension, if applicable.
        /// </summary>
        /// <value>The telephone number including the area code, and extension, if applicable.</value>
        [DataMember(Name = "telephoneNumber", IsRequired = true, EmitDefaultValue = false)]
        public string TelephoneNumber { get; set; }

        /// <summary>
        /// An indication that the telephone number should not be published.
        /// </summary>
        /// <value>An indication that the telephone number should not be published.</value>
        [DataMember(Name = "doNotPublishIndicator", EmitDefaultValue = true)]
        public bool DoNotPublishIndicator { get; set; }

        /// <summary>
        /// The order of priority assigned to telephone numbers to define which number to attempt first, second, etc.
        /// </summary>
        /// <value>The order of priority assigned to telephone numbers to define which number to attempt first, second, etc.</value>
        [DataMember(Name = "orderOfPriority", EmitDefaultValue = false)]
        public int OrderOfPriority { get; set; }

        /// <summary>
        /// An indication that the telephone number is technically capable of sending and receiving Short Message Service (SMS) text messages.
        /// </summary>
        /// <value>An indication that the telephone number is technically capable of sending and receiving Short Message Service (SMS) text messages.</value>
        [DataMember(Name = "textMessageCapabilityIndicator", EmitDefaultValue = true)]
        public bool TextMessageCapabilityIndicator { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiStudentEducationOrganizationAssociationTelephone {\n");
            sb.Append("  TelephoneNumberTypeDescriptor: ").Append(TelephoneNumberTypeDescriptor).Append("\n");
            sb.Append("  TelephoneNumber: ").Append(TelephoneNumber).Append("\n");
            sb.Append("  DoNotPublishIndicator: ").Append(DoNotPublishIndicator).Append("\n");
            sb.Append("  OrderOfPriority: ").Append(OrderOfPriority).Append("\n");
            sb.Append("  TextMessageCapabilityIndicator: ").Append(TextMessageCapabilityIndicator).Append("\n");
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
            return this.Equals(input as EdFiStudentEducationOrganizationAssociationTelephone);
        }

        /// <summary>
        /// Returns true if EdFiStudentEducationOrganizationAssociationTelephone instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiStudentEducationOrganizationAssociationTelephone to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiStudentEducationOrganizationAssociationTelephone input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TelephoneNumberTypeDescriptor == input.TelephoneNumberTypeDescriptor ||
                    (this.TelephoneNumberTypeDescriptor != null &&
                    this.TelephoneNumberTypeDescriptor.Equals(input.TelephoneNumberTypeDescriptor))
                ) && 
                (
                    this.TelephoneNumber == input.TelephoneNumber ||
                    (this.TelephoneNumber != null &&
                    this.TelephoneNumber.Equals(input.TelephoneNumber))
                ) && 
                (
                    this.DoNotPublishIndicator == input.DoNotPublishIndicator ||
                    this.DoNotPublishIndicator.Equals(input.DoNotPublishIndicator)
                ) && 
                (
                    this.OrderOfPriority == input.OrderOfPriority ||
                    this.OrderOfPriority.Equals(input.OrderOfPriority)
                ) && 
                (
                    this.TextMessageCapabilityIndicator == input.TextMessageCapabilityIndicator ||
                    this.TextMessageCapabilityIndicator.Equals(input.TextMessageCapabilityIndicator)
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
                if (this.TelephoneNumberTypeDescriptor != null)
                    hashCode = hashCode * 59 + this.TelephoneNumberTypeDescriptor.GetHashCode();
                if (this.TelephoneNumber != null)
                    hashCode = hashCode * 59 + this.TelephoneNumber.GetHashCode();
                hashCode = hashCode * 59 + this.DoNotPublishIndicator.GetHashCode();
                hashCode = hashCode * 59 + this.OrderOfPriority.GetHashCode();
                hashCode = hashCode * 59 + this.TextMessageCapabilityIndicator.GetHashCode();
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
            // TelephoneNumberTypeDescriptor (string) maxLength
            if(this.TelephoneNumberTypeDescriptor != null && this.TelephoneNumberTypeDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TelephoneNumberTypeDescriptor, length must be less than 306.", new [] { "TelephoneNumberTypeDescriptor" });
            }

            // TelephoneNumber (string) maxLength
            if(this.TelephoneNumber != null && this.TelephoneNumber.Length > 24)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TelephoneNumber, length must be less than 24.", new [] { "TelephoneNumber" });
            }

            yield break;
        }
    }

}
