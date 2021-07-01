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
    /// MembershipConfiguration
    /// </summary>
    [DataContract(Name = "MembershipConfiguration")]
    public partial class MembershipConfiguration : IEquatable<MembershipConfiguration>, IValidatableObject
    {
        /// <summary>
        /// The strategy used to store the password MembershipPasswordStrategy
        /// </summary>
        /// <value>The strategy used to store the password MembershipPasswordStrategy</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PasswordStrategyEnum
        {
            /// <summary>
            /// Enum Clear for value: Clear
            /// </summary>
            [EnumMember(Value = "Clear")]
            Clear = 1,

            /// <summary>
            /// Enum Hashed for value: Hashed
            /// </summary>
            [EnumMember(Value = "Hashed")]
            Hashed = 2,

            /// <summary>
            /// Enum Encrypted for value: Encrypted
            /// </summary>
            [EnumMember(Value = "Encrypted")]
            Encrypted = 3

        }


        /// <summary>
        /// The strategy used to store the password MembershipPasswordStrategy
        /// </summary>
        /// <value>The strategy used to store the password MembershipPasswordStrategy</value>
        [DataMember(Name = "passwordStrategy", EmitDefaultValue = false)]
        public PasswordStrategyEnum? PasswordStrategy { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MembershipConfiguration" /> class.
        /// </summary>
        /// <param name="accountLockDownMinutes">The account lock down time (in minutes).</param>
        /// <param name="enablePasswordReset">Indicates whether the current membership provider is configured to allow customers to reset their passwords.</param>
        /// <param name="enablePasswordRetrieval">Indicates whether the current membership provider is configured to allow users to retrieve their passwords.</param>
        /// <param name="maxInvalidPasswordAttempts">The number of invalid password or password-answer attempts allowed before the membership user is locked out.</param>
        /// <param name="minRequiredNonAlphanumericCharacters">The minimum number of special characters that must be present in a valid password.</param>
        /// <param name="minRequiredPasswordLength">The minimum required length for a password.</param>
        /// <param name="passwordAttemptWindow">The time window (in minutes) between which consecutive failed attempts to provide a valid password or password answer are tracked.</param>
        /// <param name="passwordFailedAttemptDelaySeconds">The delay to apply on a failed login attempt.</param>
        /// <param name="passwordStrategy">The strategy used to store the password MembershipPasswordStrategy.</param>
        /// <param name="passwordStrengthRegularExpression">The regular expression used to validate the strength level of a password.</param>
        /// <param name="requiresQuestionAndAnswer">Indicates whether the default membership provider requires the user to answer a password question (and answer) for password reset and retrieval.</param>
        /// <param name="requiresUniqueEmail">Indicating whether the customer email addresses should be unique across the system.</param>
        /// <param name="tokenExpirationMinutes">The expiration time of reset password ticket (in minutes).</param>
        public MembershipConfiguration(int accountLockDownMinutes = default(int), bool enablePasswordReset = default(bool), bool enablePasswordRetrieval = default(bool), int maxInvalidPasswordAttempts = default(int), int minRequiredNonAlphanumericCharacters = default(int), int minRequiredPasswordLength = default(int), int passwordAttemptWindow = default(int), double passwordFailedAttemptDelaySeconds = default(double), PasswordStrategyEnum? passwordStrategy = default(PasswordStrategyEnum?), string passwordStrengthRegularExpression = default(string), bool requiresQuestionAndAnswer = default(bool), bool requiresUniqueEmail = default(bool), int tokenExpirationMinutes = default(int))
        {
            this.AccountLockDownMinutes = accountLockDownMinutes;
            this.EnablePasswordReset = enablePasswordReset;
            this.EnablePasswordRetrieval = enablePasswordRetrieval;
            this.MaxInvalidPasswordAttempts = maxInvalidPasswordAttempts;
            this.MinRequiredNonAlphanumericCharacters = minRequiredNonAlphanumericCharacters;
            this.MinRequiredPasswordLength = minRequiredPasswordLength;
            this.PasswordAttemptWindow = passwordAttemptWindow;
            this.PasswordFailedAttemptDelaySeconds = passwordFailedAttemptDelaySeconds;
            this.PasswordStrategy = passwordStrategy;
            this.PasswordStrengthRegularExpression = passwordStrengthRegularExpression;
            this.RequiresQuestionAndAnswer = requiresQuestionAndAnswer;
            this.RequiresUniqueEmail = requiresUniqueEmail;
            this.TokenExpirationMinutes = tokenExpirationMinutes;
        }

        /// <summary>
        /// The account lock down time (in minutes)
        /// </summary>
        /// <value>The account lock down time (in minutes)</value>
        [DataMember(Name = "accountLockDownMinutes", EmitDefaultValue = false)]
        public int AccountLockDownMinutes { get; set; }

        /// <summary>
        /// Indicates whether the current membership provider is configured to allow customers to reset their passwords
        /// </summary>
        /// <value>Indicates whether the current membership provider is configured to allow customers to reset their passwords</value>
        [DataMember(Name = "enablePasswordReset", EmitDefaultValue = true)]
        public bool EnablePasswordReset { get; set; }

        /// <summary>
        /// Indicates whether the current membership provider is configured to allow users to retrieve their passwords
        /// </summary>
        /// <value>Indicates whether the current membership provider is configured to allow users to retrieve their passwords</value>
        [DataMember(Name = "enablePasswordRetrieval", EmitDefaultValue = true)]
        public bool EnablePasswordRetrieval { get; set; }

        /// <summary>
        /// The number of invalid password or password-answer attempts allowed before the membership user is locked out
        /// </summary>
        /// <value>The number of invalid password or password-answer attempts allowed before the membership user is locked out</value>
        [DataMember(Name = "maxInvalidPasswordAttempts", EmitDefaultValue = false)]
        public int MaxInvalidPasswordAttempts { get; set; }

        /// <summary>
        /// The minimum number of special characters that must be present in a valid password
        /// </summary>
        /// <value>The minimum number of special characters that must be present in a valid password</value>
        [DataMember(Name = "minRequiredNonAlphanumericCharacters", EmitDefaultValue = false)]
        public int MinRequiredNonAlphanumericCharacters { get; set; }

        /// <summary>
        /// The minimum required length for a password
        /// </summary>
        /// <value>The minimum required length for a password</value>
        [DataMember(Name = "minRequiredPasswordLength", EmitDefaultValue = false)]
        public int MinRequiredPasswordLength { get; set; }

        /// <summary>
        /// The time window (in minutes) between which consecutive failed attempts to provide a valid password or password answer are tracked
        /// </summary>
        /// <value>The time window (in minutes) between which consecutive failed attempts to provide a valid password or password answer are tracked</value>
        [DataMember(Name = "passwordAttemptWindow", EmitDefaultValue = false)]
        public int PasswordAttemptWindow { get; set; }

        /// <summary>
        /// The delay to apply on a failed login attempt
        /// </summary>
        /// <value>The delay to apply on a failed login attempt</value>
        [DataMember(Name = "passwordFailedAttemptDelaySeconds", EmitDefaultValue = false)]
        public double PasswordFailedAttemptDelaySeconds { get; set; }

        /// <summary>
        /// The regular expression used to validate the strength level of a password
        /// </summary>
        /// <value>The regular expression used to validate the strength level of a password</value>
        [DataMember(Name = "passwordStrengthRegularExpression", EmitDefaultValue = false)]
        public string PasswordStrengthRegularExpression { get; set; }

        /// <summary>
        /// Indicates whether the default membership provider requires the user to answer a password question (and answer) for password reset and retrieval
        /// </summary>
        /// <value>Indicates whether the default membership provider requires the user to answer a password question (and answer) for password reset and retrieval</value>
        [DataMember(Name = "requiresQuestionAndAnswer", EmitDefaultValue = true)]
        public bool RequiresQuestionAndAnswer { get; set; }

        /// <summary>
        /// Indicating whether the customer email addresses should be unique across the system
        /// </summary>
        /// <value>Indicating whether the customer email addresses should be unique across the system</value>
        [DataMember(Name = "requiresUniqueEmail", EmitDefaultValue = true)]
        public bool RequiresUniqueEmail { get; set; }

        /// <summary>
        /// The expiration time of reset password ticket (in minutes)
        /// </summary>
        /// <value>The expiration time of reset password ticket (in minutes)</value>
        [DataMember(Name = "tokenExpirationMinutes", EmitDefaultValue = false)]
        public int TokenExpirationMinutes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MembershipConfiguration {\n");
            sb.Append("  AccountLockDownMinutes: ").Append(AccountLockDownMinutes).Append("\n");
            sb.Append("  EnablePasswordReset: ").Append(EnablePasswordReset).Append("\n");
            sb.Append("  EnablePasswordRetrieval: ").Append(EnablePasswordRetrieval).Append("\n");
            sb.Append("  MaxInvalidPasswordAttempts: ").Append(MaxInvalidPasswordAttempts).Append("\n");
            sb.Append("  MinRequiredNonAlphanumericCharacters: ").Append(MinRequiredNonAlphanumericCharacters).Append("\n");
            sb.Append("  MinRequiredPasswordLength: ").Append(MinRequiredPasswordLength).Append("\n");
            sb.Append("  PasswordAttemptWindow: ").Append(PasswordAttemptWindow).Append("\n");
            sb.Append("  PasswordFailedAttemptDelaySeconds: ").Append(PasswordFailedAttemptDelaySeconds).Append("\n");
            sb.Append("  PasswordStrategy: ").Append(PasswordStrategy).Append("\n");
            sb.Append("  PasswordStrengthRegularExpression: ").Append(PasswordStrengthRegularExpression).Append("\n");
            sb.Append("  RequiresQuestionAndAnswer: ").Append(RequiresQuestionAndAnswer).Append("\n");
            sb.Append("  RequiresUniqueEmail: ").Append(RequiresUniqueEmail).Append("\n");
            sb.Append("  TokenExpirationMinutes: ").Append(TokenExpirationMinutes).Append("\n");
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
            return this.Equals(input as MembershipConfiguration);
        }

        /// <summary>
        /// Returns true if MembershipConfiguration instances are equal
        /// </summary>
        /// <param name="input">Instance of MembershipConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MembershipConfiguration input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccountLockDownMinutes == input.AccountLockDownMinutes ||
                    this.AccountLockDownMinutes.Equals(input.AccountLockDownMinutes)
                ) && 
                (
                    this.EnablePasswordReset == input.EnablePasswordReset ||
                    this.EnablePasswordReset.Equals(input.EnablePasswordReset)
                ) && 
                (
                    this.EnablePasswordRetrieval == input.EnablePasswordRetrieval ||
                    this.EnablePasswordRetrieval.Equals(input.EnablePasswordRetrieval)
                ) && 
                (
                    this.MaxInvalidPasswordAttempts == input.MaxInvalidPasswordAttempts ||
                    this.MaxInvalidPasswordAttempts.Equals(input.MaxInvalidPasswordAttempts)
                ) && 
                (
                    this.MinRequiredNonAlphanumericCharacters == input.MinRequiredNonAlphanumericCharacters ||
                    this.MinRequiredNonAlphanumericCharacters.Equals(input.MinRequiredNonAlphanumericCharacters)
                ) && 
                (
                    this.MinRequiredPasswordLength == input.MinRequiredPasswordLength ||
                    this.MinRequiredPasswordLength.Equals(input.MinRequiredPasswordLength)
                ) && 
                (
                    this.PasswordAttemptWindow == input.PasswordAttemptWindow ||
                    this.PasswordAttemptWindow.Equals(input.PasswordAttemptWindow)
                ) && 
                (
                    this.PasswordFailedAttemptDelaySeconds == input.PasswordFailedAttemptDelaySeconds ||
                    this.PasswordFailedAttemptDelaySeconds.Equals(input.PasswordFailedAttemptDelaySeconds)
                ) && 
                (
                    this.PasswordStrategy == input.PasswordStrategy ||
                    this.PasswordStrategy.Equals(input.PasswordStrategy)
                ) && 
                (
                    this.PasswordStrengthRegularExpression == input.PasswordStrengthRegularExpression ||
                    (this.PasswordStrengthRegularExpression != null &&
                    this.PasswordStrengthRegularExpression.Equals(input.PasswordStrengthRegularExpression))
                ) && 
                (
                    this.RequiresQuestionAndAnswer == input.RequiresQuestionAndAnswer ||
                    this.RequiresQuestionAndAnswer.Equals(input.RequiresQuestionAndAnswer)
                ) && 
                (
                    this.RequiresUniqueEmail == input.RequiresUniqueEmail ||
                    this.RequiresUniqueEmail.Equals(input.RequiresUniqueEmail)
                ) && 
                (
                    this.TokenExpirationMinutes == input.TokenExpirationMinutes ||
                    this.TokenExpirationMinutes.Equals(input.TokenExpirationMinutes)
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
                hashCode = hashCode * 59 + this.AccountLockDownMinutes.GetHashCode();
                hashCode = hashCode * 59 + this.EnablePasswordReset.GetHashCode();
                hashCode = hashCode * 59 + this.EnablePasswordRetrieval.GetHashCode();
                hashCode = hashCode * 59 + this.MaxInvalidPasswordAttempts.GetHashCode();
                hashCode = hashCode * 59 + this.MinRequiredNonAlphanumericCharacters.GetHashCode();
                hashCode = hashCode * 59 + this.MinRequiredPasswordLength.GetHashCode();
                hashCode = hashCode * 59 + this.PasswordAttemptWindow.GetHashCode();
                hashCode = hashCode * 59 + this.PasswordFailedAttemptDelaySeconds.GetHashCode();
                hashCode = hashCode * 59 + this.PasswordStrategy.GetHashCode();
                if (this.PasswordStrengthRegularExpression != null)
                    hashCode = hashCode * 59 + this.PasswordStrengthRegularExpression.GetHashCode();
                hashCode = hashCode * 59 + this.RequiresQuestionAndAnswer.GetHashCode();
                hashCode = hashCode * 59 + this.RequiresUniqueEmail.GetHashCode();
                hashCode = hashCode * 59 + this.TokenExpirationMinutes.GetHashCode();
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
