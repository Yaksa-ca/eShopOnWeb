/*
 * Overture API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0.0
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
using OpenAPIDateConverter = Yaksa.OrckestraCommerce.Client.Client.OpenAPIDateConverter;

namespace Yaksa.OrckestraCommerce.Client.Model
{
    /// <summary>
    /// Regroupment of all custom CDMV services, notably for clinics related operations
    /// </summary>
    [DataContract(Name = "CDMVCreateCustomerRequest")]
    public partial class CDMVCreateCustomerRequest : IEquatable<CDMVCreateCustomerRequest>, IValidatableObject
    {
        /// <summary>
        /// The customer&#39;s B2C site profile account type.
        /// </summary>
        /// <value>The customer&#39;s B2C site profile account type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum B2CAccountCreationTypeEnum
        {
            /// <summary>
            /// Enum Invite for value: Invite
            /// </summary>
            [EnumMember(Value = "Invite")]
            Invite = 1,

            /// <summary>
            /// Enum SelfService for value: SelfService
            /// </summary>
            [EnumMember(Value = "SelfService")]
            SelfService = 2

        }


        /// <summary>
        /// The customer&#39;s B2C site profile account type.
        /// </summary>
        /// <value>The customer&#39;s B2C site profile account type.</value>
        [DataMember(Name = "b2CAccountCreationType", EmitDefaultValue = false)]
        public B2CAccountCreationTypeEnum? B2CAccountCreationType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CDMVCreateCustomerRequest" /> class.
        /// </summary>
        /// <param name="emailAddress">Customer email address..</param>
        /// <param name="fileNumber">Customer file numer..</param>
        /// <param name="firstName">Customer first name..</param>
        /// <param name="lastName">Customer last name..</param>
        /// <param name="password">Customer password..</param>
        /// <param name="productIdAuthorizations">Customer product id authorization..</param>
        /// <param name="b2CAccountCreationType">The customer&#39;s B2C site profile account type..</param>
        /// <param name="language">Customer preferred language.</param>
        /// <param name="newsletterOptIn">Whether the customer is subscribed to receive email newsletters.</param>
        /// <param name="originalId">The customer&#39;s original ID. Defaults to the customer&#39;s email address if no value is provided..</param>
        /// <param name="invitationEmailAddress">Customer email address used for the invitation to create his account..</param>
        /// <param name="excludeFromWelcomePromo">True if the customer is not eligible for the Welcome promotion..</param>
        /// <param name="phoneNumber">Customer phone number.</param>
        public CDMVCreateCustomerRequest(string emailAddress = default(string), string fileNumber = default(string), string firstName = default(string), string lastName = default(string), string password = default(string), List<ProductIdAuthorization> productIdAuthorizations = default(List<ProductIdAuthorization>), B2CAccountCreationTypeEnum? b2CAccountCreationType = default(B2CAccountCreationTypeEnum?), string language = default(string), bool newsletterOptIn = default(bool), string originalId = default(string), string invitationEmailAddress = default(string), bool excludeFromWelcomePromo = default(bool), string phoneNumber = default(string))
        {
            this.EmailAddress = emailAddress;
            this.FileNumber = fileNumber;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Password = password;
            this.ProductIdAuthorizations = productIdAuthorizations;
            this.B2CAccountCreationType = b2CAccountCreationType;
            this.Language = language;
            this.NewsletterOptIn = newsletterOptIn;
            this.OriginalId = originalId;
            this.InvitationEmailAddress = invitationEmailAddress;
            this.ExcludeFromWelcomePromo = excludeFromWelcomePromo;
            this.PhoneNumber = phoneNumber;
        }

        /// <summary>
        /// Customer email address.
        /// </summary>
        /// <value>Customer email address.</value>
        [DataMember(Name = "emailAddress", EmitDefaultValue = false)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Customer file numer.
        /// </summary>
        /// <value>Customer file numer.</value>
        [DataMember(Name = "fileNumber", EmitDefaultValue = false)]
        public string FileNumber { get; set; }

        /// <summary>
        /// Customer first name.
        /// </summary>
        /// <value>Customer first name.</value>
        [DataMember(Name = "firstName", EmitDefaultValue = false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Customer last name.
        /// </summary>
        /// <value>Customer last name.</value>
        [DataMember(Name = "lastName", EmitDefaultValue = false)]
        public string LastName { get; set; }

        /// <summary>
        /// Customer password.
        /// </summary>
        /// <value>Customer password.</value>
        [DataMember(Name = "password", EmitDefaultValue = false)]
        public string Password { get; set; }

        /// <summary>
        /// Customer product id authorization.
        /// </summary>
        /// <value>Customer product id authorization.</value>
        [DataMember(Name = "productIdAuthorizations", EmitDefaultValue = false)]
        public List<ProductIdAuthorization> ProductIdAuthorizations { get; set; }

        /// <summary>
        /// Customer preferred language
        /// </summary>
        /// <value>Customer preferred language</value>
        [DataMember(Name = "language", EmitDefaultValue = false)]
        public string Language { get; set; }

        /// <summary>
        /// Whether the customer is subscribed to receive email newsletters
        /// </summary>
        /// <value>Whether the customer is subscribed to receive email newsletters</value>
        [DataMember(Name = "newsletterOptIn", EmitDefaultValue = true)]
        public bool NewsletterOptIn { get; set; }

        /// <summary>
        /// The customer&#39;s original ID. Defaults to the customer&#39;s email address if no value is provided.
        /// </summary>
        /// <value>The customer&#39;s original ID. Defaults to the customer&#39;s email address if no value is provided.</value>
        [DataMember(Name = "originalId", EmitDefaultValue = false)]
        public string OriginalId { get; set; }

        /// <summary>
        /// Customer email address used for the invitation to create his account.
        /// </summary>
        /// <value>Customer email address used for the invitation to create his account.</value>
        [DataMember(Name = "invitationEmailAddress", EmitDefaultValue = false)]
        public string InvitationEmailAddress { get; set; }

        /// <summary>
        /// True if the customer is not eligible for the Welcome promotion.
        /// </summary>
        /// <value>True if the customer is not eligible for the Welcome promotion.</value>
        [DataMember(Name = "excludeFromWelcomePromo", EmitDefaultValue = true)]
        public bool ExcludeFromWelcomePromo { get; set; }

        /// <summary>
        /// Customer phone number
        /// </summary>
        /// <value>Customer phone number</value>
        [DataMember(Name = "phoneNumber", EmitDefaultValue = false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CDMVCreateCustomerRequest {\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  FileNumber: ").Append(FileNumber).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  ProductIdAuthorizations: ").Append(ProductIdAuthorizations).Append("\n");
            sb.Append("  B2CAccountCreationType: ").Append(B2CAccountCreationType).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  NewsletterOptIn: ").Append(NewsletterOptIn).Append("\n");
            sb.Append("  OriginalId: ").Append(OriginalId).Append("\n");
            sb.Append("  InvitationEmailAddress: ").Append(InvitationEmailAddress).Append("\n");
            sb.Append("  ExcludeFromWelcomePromo: ").Append(ExcludeFromWelcomePromo).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
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
            return this.Equals(input as CDMVCreateCustomerRequest);
        }

        /// <summary>
        /// Returns true if CDMVCreateCustomerRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CDMVCreateCustomerRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CDMVCreateCustomerRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EmailAddress == input.EmailAddress ||
                    (this.EmailAddress != null &&
                    this.EmailAddress.Equals(input.EmailAddress))
                ) && 
                (
                    this.FileNumber == input.FileNumber ||
                    (this.FileNumber != null &&
                    this.FileNumber.Equals(input.FileNumber))
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.ProductIdAuthorizations == input.ProductIdAuthorizations ||
                    this.ProductIdAuthorizations != null &&
                    input.ProductIdAuthorizations != null &&
                    this.ProductIdAuthorizations.SequenceEqual(input.ProductIdAuthorizations)
                ) && 
                (
                    this.B2CAccountCreationType == input.B2CAccountCreationType ||
                    this.B2CAccountCreationType.Equals(input.B2CAccountCreationType)
                ) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && 
                (
                    this.NewsletterOptIn == input.NewsletterOptIn ||
                    this.NewsletterOptIn.Equals(input.NewsletterOptIn)
                ) && 
                (
                    this.OriginalId == input.OriginalId ||
                    (this.OriginalId != null &&
                    this.OriginalId.Equals(input.OriginalId))
                ) && 
                (
                    this.InvitationEmailAddress == input.InvitationEmailAddress ||
                    (this.InvitationEmailAddress != null &&
                    this.InvitationEmailAddress.Equals(input.InvitationEmailAddress))
                ) && 
                (
                    this.ExcludeFromWelcomePromo == input.ExcludeFromWelcomePromo ||
                    this.ExcludeFromWelcomePromo.Equals(input.ExcludeFromWelcomePromo)
                ) && 
                (
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
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
                if (this.EmailAddress != null)
                    hashCode = hashCode * 59 + this.EmailAddress.GetHashCode();
                if (this.FileNumber != null)
                    hashCode = hashCode * 59 + this.FileNumber.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.ProductIdAuthorizations != null)
                    hashCode = hashCode * 59 + this.ProductIdAuthorizations.GetHashCode();
                hashCode = hashCode * 59 + this.B2CAccountCreationType.GetHashCode();
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                hashCode = hashCode * 59 + this.NewsletterOptIn.GetHashCode();
                if (this.OriginalId != null)
                    hashCode = hashCode * 59 + this.OriginalId.GetHashCode();
                if (this.InvitationEmailAddress != null)
                    hashCode = hashCode * 59 + this.InvitationEmailAddress.GetHashCode();
                hashCode = hashCode * 59 + this.ExcludeFromWelcomePromo.GetHashCode();
                if (this.PhoneNumber != null)
                    hashCode = hashCode * 59 + this.PhoneNumber.GetHashCode();
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
