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
    /// TpdmOpenStaffPositionExtension
    /// </summary>
    [DataContract(Name = "tpdm_openStaffPositionExtension")]
    public partial class TpdmOpenStaffPositionExtension : IEquatable<TpdmOpenStaffPositionExtension>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmOpenStaffPositionExtension" /> class.
        /// </summary>
        /// <param name="fundingSourceDescriptor">The funding source for open staff position..</param>
        /// <param name="openStaffPositionReasonDescriptor">The reason for the open staff position (e.g., new position, replacement, etc.)..</param>
        /// <param name="termDescriptor">The first term for the Session during the school year for which the OpenStaffPosition is seeking to fill..</param>
        /// <param name="fullTimeEquivalency">The ratio between the hours of work expected in a position and the hours of work normally expected in a full-time position in the same setting..</param>
        /// <param name="highNeedAcademicSubject">Indicator as to whether the OpenStaffPosition is filling a high-need subject area designated as a teacher shortage that may be eligible for special grants, aid or compensation..</param>
        /// <param name="isActive">Indicator of whether the OpenStaffPosition is currently Active..</param>
        /// <param name="maxSalary">The maximum salary or wage a person is paid before deductions (excluding differentials) but including annuities..</param>
        /// <param name="minSalary">The minimum salary or wage a person is paid before deductions (excluding differentials) but including annuities..</param>
        /// <param name="positionControlNumber">Identifier assigned to the position to be filled..</param>
        /// <param name="totalBudgeted">Including salary, the fully loaded cost budgeted for this teacher..</param>
        /// <param name="schoolYearTypeReference">schoolYearTypeReference.</param>
        public TpdmOpenStaffPositionExtension(string fundingSourceDescriptor = default(string), string openStaffPositionReasonDescriptor = default(string), string termDescriptor = default(string), double fullTimeEquivalency = default(double), bool highNeedAcademicSubject = default(bool), bool isActive = default(bool), double maxSalary = default(double), double minSalary = default(double), string positionControlNumber = default(string), double totalBudgeted = default(double), EdFiSchoolYearTypeReference schoolYearTypeReference = default(EdFiSchoolYearTypeReference))
        {
            this.FundingSourceDescriptor = fundingSourceDescriptor;
            this.OpenStaffPositionReasonDescriptor = openStaffPositionReasonDescriptor;
            this.TermDescriptor = termDescriptor;
            this.FullTimeEquivalency = fullTimeEquivalency;
            this.HighNeedAcademicSubject = highNeedAcademicSubject;
            this.IsActive = isActive;
            this.MaxSalary = maxSalary;
            this.MinSalary = minSalary;
            this.PositionControlNumber = positionControlNumber;
            this.TotalBudgeted = totalBudgeted;
            this.SchoolYearTypeReference = schoolYearTypeReference;
        }

        /// <summary>
        /// The funding source for open staff position.
        /// </summary>
        /// <value>The funding source for open staff position.</value>
        [DataMember(Name = "fundingSourceDescriptor", EmitDefaultValue = false)]
        public string FundingSourceDescriptor { get; set; }

        /// <summary>
        /// The reason for the open staff position (e.g., new position, replacement, etc.).
        /// </summary>
        /// <value>The reason for the open staff position (e.g., new position, replacement, etc.).</value>
        [DataMember(Name = "openStaffPositionReasonDescriptor", EmitDefaultValue = false)]
        public string OpenStaffPositionReasonDescriptor { get; set; }

        /// <summary>
        /// The first term for the Session during the school year for which the OpenStaffPosition is seeking to fill.
        /// </summary>
        /// <value>The first term for the Session during the school year for which the OpenStaffPosition is seeking to fill.</value>
        [DataMember(Name = "termDescriptor", EmitDefaultValue = false)]
        public string TermDescriptor { get; set; }

        /// <summary>
        /// The ratio between the hours of work expected in a position and the hours of work normally expected in a full-time position in the same setting.
        /// </summary>
        /// <value>The ratio between the hours of work expected in a position and the hours of work normally expected in a full-time position in the same setting.</value>
        [DataMember(Name = "fullTimeEquivalency", EmitDefaultValue = false)]
        public double FullTimeEquivalency { get; set; }

        /// <summary>
        /// Indicator as to whether the OpenStaffPosition is filling a high-need subject area designated as a teacher shortage that may be eligible for special grants, aid or compensation.
        /// </summary>
        /// <value>Indicator as to whether the OpenStaffPosition is filling a high-need subject area designated as a teacher shortage that may be eligible for special grants, aid or compensation.</value>
        [DataMember(Name = "highNeedAcademicSubject", EmitDefaultValue = true)]
        public bool HighNeedAcademicSubject { get; set; }

        /// <summary>
        /// Indicator of whether the OpenStaffPosition is currently Active.
        /// </summary>
        /// <value>Indicator of whether the OpenStaffPosition is currently Active.</value>
        [DataMember(Name = "isActive", EmitDefaultValue = true)]
        public bool IsActive { get; set; }

        /// <summary>
        /// The maximum salary or wage a person is paid before deductions (excluding differentials) but including annuities.
        /// </summary>
        /// <value>The maximum salary or wage a person is paid before deductions (excluding differentials) but including annuities.</value>
        [DataMember(Name = "maxSalary", EmitDefaultValue = false)]
        public double MaxSalary { get; set; }

        /// <summary>
        /// The minimum salary or wage a person is paid before deductions (excluding differentials) but including annuities.
        /// </summary>
        /// <value>The minimum salary or wage a person is paid before deductions (excluding differentials) but including annuities.</value>
        [DataMember(Name = "minSalary", EmitDefaultValue = false)]
        public double MinSalary { get; set; }

        /// <summary>
        /// Identifier assigned to the position to be filled.
        /// </summary>
        /// <value>Identifier assigned to the position to be filled.</value>
        [DataMember(Name = "positionControlNumber", EmitDefaultValue = false)]
        public string PositionControlNumber { get; set; }

        /// <summary>
        /// Including salary, the fully loaded cost budgeted for this teacher.
        /// </summary>
        /// <value>Including salary, the fully loaded cost budgeted for this teacher.</value>
        [DataMember(Name = "totalBudgeted", EmitDefaultValue = false)]
        public double TotalBudgeted { get; set; }

        /// <summary>
        /// Gets or Sets SchoolYearTypeReference
        /// </summary>
        [DataMember(Name = "schoolYearTypeReference", EmitDefaultValue = false)]
        public EdFiSchoolYearTypeReference SchoolYearTypeReference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TpdmOpenStaffPositionExtension {\n");
            sb.Append("  FundingSourceDescriptor: ").Append(FundingSourceDescriptor).Append("\n");
            sb.Append("  OpenStaffPositionReasonDescriptor: ").Append(OpenStaffPositionReasonDescriptor).Append("\n");
            sb.Append("  TermDescriptor: ").Append(TermDescriptor).Append("\n");
            sb.Append("  FullTimeEquivalency: ").Append(FullTimeEquivalency).Append("\n");
            sb.Append("  HighNeedAcademicSubject: ").Append(HighNeedAcademicSubject).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  MaxSalary: ").Append(MaxSalary).Append("\n");
            sb.Append("  MinSalary: ").Append(MinSalary).Append("\n");
            sb.Append("  PositionControlNumber: ").Append(PositionControlNumber).Append("\n");
            sb.Append("  TotalBudgeted: ").Append(TotalBudgeted).Append("\n");
            sb.Append("  SchoolYearTypeReference: ").Append(SchoolYearTypeReference).Append("\n");
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
            return this.Equals(input as TpdmOpenStaffPositionExtension);
        }

        /// <summary>
        /// Returns true if TpdmOpenStaffPositionExtension instances are equal
        /// </summary>
        /// <param name="input">Instance of TpdmOpenStaffPositionExtension to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TpdmOpenStaffPositionExtension input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FundingSourceDescriptor == input.FundingSourceDescriptor ||
                    (this.FundingSourceDescriptor != null &&
                    this.FundingSourceDescriptor.Equals(input.FundingSourceDescriptor))
                ) && 
                (
                    this.OpenStaffPositionReasonDescriptor == input.OpenStaffPositionReasonDescriptor ||
                    (this.OpenStaffPositionReasonDescriptor != null &&
                    this.OpenStaffPositionReasonDescriptor.Equals(input.OpenStaffPositionReasonDescriptor))
                ) && 
                (
                    this.TermDescriptor == input.TermDescriptor ||
                    (this.TermDescriptor != null &&
                    this.TermDescriptor.Equals(input.TermDescriptor))
                ) && 
                (
                    this.FullTimeEquivalency == input.FullTimeEquivalency ||
                    this.FullTimeEquivalency.Equals(input.FullTimeEquivalency)
                ) && 
                (
                    this.HighNeedAcademicSubject == input.HighNeedAcademicSubject ||
                    this.HighNeedAcademicSubject.Equals(input.HighNeedAcademicSubject)
                ) && 
                (
                    this.IsActive == input.IsActive ||
                    this.IsActive.Equals(input.IsActive)
                ) && 
                (
                    this.MaxSalary == input.MaxSalary ||
                    this.MaxSalary.Equals(input.MaxSalary)
                ) && 
                (
                    this.MinSalary == input.MinSalary ||
                    this.MinSalary.Equals(input.MinSalary)
                ) && 
                (
                    this.PositionControlNumber == input.PositionControlNumber ||
                    (this.PositionControlNumber != null &&
                    this.PositionControlNumber.Equals(input.PositionControlNumber))
                ) && 
                (
                    this.TotalBudgeted == input.TotalBudgeted ||
                    this.TotalBudgeted.Equals(input.TotalBudgeted)
                ) && 
                (
                    this.SchoolYearTypeReference == input.SchoolYearTypeReference ||
                    (this.SchoolYearTypeReference != null &&
                    this.SchoolYearTypeReference.Equals(input.SchoolYearTypeReference))
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
                if (this.FundingSourceDescriptor != null)
                    hashCode = hashCode * 59 + this.FundingSourceDescriptor.GetHashCode();
                if (this.OpenStaffPositionReasonDescriptor != null)
                    hashCode = hashCode * 59 + this.OpenStaffPositionReasonDescriptor.GetHashCode();
                if (this.TermDescriptor != null)
                    hashCode = hashCode * 59 + this.TermDescriptor.GetHashCode();
                hashCode = hashCode * 59 + this.FullTimeEquivalency.GetHashCode();
                hashCode = hashCode * 59 + this.HighNeedAcademicSubject.GetHashCode();
                hashCode = hashCode * 59 + this.IsActive.GetHashCode();
                hashCode = hashCode * 59 + this.MaxSalary.GetHashCode();
                hashCode = hashCode * 59 + this.MinSalary.GetHashCode();
                if (this.PositionControlNumber != null)
                    hashCode = hashCode * 59 + this.PositionControlNumber.GetHashCode();
                hashCode = hashCode * 59 + this.TotalBudgeted.GetHashCode();
                if (this.SchoolYearTypeReference != null)
                    hashCode = hashCode * 59 + this.SchoolYearTypeReference.GetHashCode();
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
            // FundingSourceDescriptor (string) maxLength
            if(this.FundingSourceDescriptor != null && this.FundingSourceDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FundingSourceDescriptor, length must be less than 306.", new [] { "FundingSourceDescriptor" });
            }

            // OpenStaffPositionReasonDescriptor (string) maxLength
            if(this.OpenStaffPositionReasonDescriptor != null && this.OpenStaffPositionReasonDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for OpenStaffPositionReasonDescriptor, length must be less than 306.", new [] { "OpenStaffPositionReasonDescriptor" });
            }

            // TermDescriptor (string) maxLength
            if(this.TermDescriptor != null && this.TermDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TermDescriptor, length must be less than 306.", new [] { "TermDescriptor" });
            }

            // PositionControlNumber (string) maxLength
            if(this.PositionControlNumber != null && this.PositionControlNumber.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PositionControlNumber, length must be less than 20.", new [] { "PositionControlNumber" });
            }

            yield break;
        }
    }

}
