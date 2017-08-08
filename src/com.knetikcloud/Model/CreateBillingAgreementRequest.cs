/* 
 * Knetik Platform API Documentation latest 
 *
 * This is the spec for the Knetik API.  Use this in conjunction with the documentation found at https://knetikcloud.com.
 *
 * OpenAPI spec version: latest 
 * Contact: support@knetik.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = com.knetikcloud.Client.SwaggerDateConverter;

namespace com.knetikcloud.Model
{
    /// <summary>
    /// CreateBillingAgreementRequest
    /// </summary>
    [DataContract]
    public partial class CreateBillingAgreementRequest :  IEquatable<CreateBillingAgreementRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBillingAgreementRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateBillingAgreementRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBillingAgreementRequest" /> class.
        /// </summary>
        /// <param name="CancelUrl">The endpoint URL to which PayPal should forward the user if they cancel (do not accept) the agreement (required).</param>
        /// <param name="ReturnUrl">The endpoint URL to which PayPal should forward the user after they accept the agreement. This endpoint will receive information needed for the next step (required).</param>
        /// <param name="UserId">The ID of the user. Defaults to the logged in user.</param>
        public CreateBillingAgreementRequest(string CancelUrl = default(string), string ReturnUrl = default(string), int? UserId = default(int?))
        {
            // to ensure "CancelUrl" is required (not null)
            if (CancelUrl == null)
            {
                throw new InvalidDataException("CancelUrl is a required property for CreateBillingAgreementRequest and cannot be null");
            }
            else
            {
                this.CancelUrl = CancelUrl;
            }
            // to ensure "ReturnUrl" is required (not null)
            if (ReturnUrl == null)
            {
                throw new InvalidDataException("ReturnUrl is a required property for CreateBillingAgreementRequest and cannot be null");
            }
            else
            {
                this.ReturnUrl = ReturnUrl;
            }
            this.UserId = UserId;
        }
        
        /// <summary>
        /// The endpoint URL to which PayPal should forward the user if they cancel (do not accept) the agreement
        /// </summary>
        /// <value>The endpoint URL to which PayPal should forward the user if they cancel (do not accept) the agreement</value>
        [DataMember(Name="cancel_url", EmitDefaultValue=false)]
        public string CancelUrl { get; set; }

        /// <summary>
        /// The endpoint URL to which PayPal should forward the user after they accept the agreement. This endpoint will receive information needed for the next step
        /// </summary>
        /// <value>The endpoint URL to which PayPal should forward the user after they accept the agreement. This endpoint will receive information needed for the next step</value>
        [DataMember(Name="return_url", EmitDefaultValue=false)]
        public string ReturnUrl { get; set; }

        /// <summary>
        /// The ID of the user. Defaults to the logged in user
        /// </summary>
        /// <value>The ID of the user. Defaults to the logged in user</value>
        [DataMember(Name="user_id", EmitDefaultValue=false)]
        public int? UserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateBillingAgreementRequest {\n");
            sb.Append("  CancelUrl: ").Append(CancelUrl).Append("\n");
            sb.Append("  ReturnUrl: ").Append(ReturnUrl).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateBillingAgreementRequest);
        }

        /// <summary>
        /// Returns true if CreateBillingAgreementRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateBillingAgreementRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateBillingAgreementRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CancelUrl == input.CancelUrl ||
                    (this.CancelUrl != null &&
                    this.CancelUrl.Equals(input.CancelUrl))
                ) && 
                (
                    this.ReturnUrl == input.ReturnUrl ||
                    (this.ReturnUrl != null &&
                    this.ReturnUrl.Equals(input.ReturnUrl))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
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
                if (this.CancelUrl != null)
                    hashCode = hashCode * 59 + this.CancelUrl.GetHashCode();
                if (this.ReturnUrl != null)
                    hashCode = hashCode * 59 + this.ReturnUrl.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                return hashCode;
            }
        }

    }

}
