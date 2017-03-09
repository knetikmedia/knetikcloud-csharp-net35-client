/* 
 * Knetik Platform API Documentation latest 
 *
 * This is the spec for the Knetik API.  Use this in conjunction with the documentation found at https://knetikcloud.com
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

namespace IO.Swagger.Model
{
    /// <summary>
    /// FinalizePayPalPaymentRequest
    /// </summary>
    [DataContract]
    public partial class FinalizePayPalPaymentRequest :  IEquatable<FinalizePayPalPaymentRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FinalizePayPalPaymentRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FinalizePayPalPaymentRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FinalizePayPalPaymentRequest" /> class.
        /// </summary>
        /// <param name="InvoiceId">The ID of the invoice that is being paid. Must match the invoice sent in originally (required).</param>
        /// <param name="PayerId">The ID of the payer that PayPal returned with the user at the return URL (required).</param>
        /// <param name="Token">The token that PayPal returned with the user in the return URL (required).</param>
        public FinalizePayPalPaymentRequest(int? InvoiceId = default(int?), string PayerId = default(string), string Token = default(string))
        {
            // to ensure "InvoiceId" is required (not null)
            if (InvoiceId == null)
            {
                throw new InvalidDataException("InvoiceId is a required property for FinalizePayPalPaymentRequest and cannot be null");
            }
            else
            {
                this.InvoiceId = InvoiceId;
            }
            // to ensure "PayerId" is required (not null)
            if (PayerId == null)
            {
                throw new InvalidDataException("PayerId is a required property for FinalizePayPalPaymentRequest and cannot be null");
            }
            else
            {
                this.PayerId = PayerId;
            }
            // to ensure "Token" is required (not null)
            if (Token == null)
            {
                throw new InvalidDataException("Token is a required property for FinalizePayPalPaymentRequest and cannot be null");
            }
            else
            {
                this.Token = Token;
            }
        }
        
        /// <summary>
        /// The ID of the invoice that is being paid. Must match the invoice sent in originally
        /// </summary>
        /// <value>The ID of the invoice that is being paid. Must match the invoice sent in originally</value>
        [DataMember(Name="invoice_id", EmitDefaultValue=false)]
        public int? InvoiceId { get; set; }
        /// <summary>
        /// The ID of the payer that PayPal returned with the user at the return URL
        /// </summary>
        /// <value>The ID of the payer that PayPal returned with the user at the return URL</value>
        [DataMember(Name="payer_id", EmitDefaultValue=false)]
        public string PayerId { get; set; }
        /// <summary>
        /// The token that PayPal returned with the user in the return URL
        /// </summary>
        /// <value>The token that PayPal returned with the user in the return URL</value>
        [DataMember(Name="token", EmitDefaultValue=false)]
        public string Token { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FinalizePayPalPaymentRequest {\n");
            sb.Append("  InvoiceId: ").Append(InvoiceId).Append("\n");
            sb.Append("  PayerId: ").Append(PayerId).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as FinalizePayPalPaymentRequest);
        }

        /// <summary>
        /// Returns true if FinalizePayPalPaymentRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of FinalizePayPalPaymentRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FinalizePayPalPaymentRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.InvoiceId == other.InvoiceId ||
                    this.InvoiceId != null &&
                    this.InvoiceId.Equals(other.InvoiceId)
                ) && 
                (
                    this.PayerId == other.PayerId ||
                    this.PayerId != null &&
                    this.PayerId.Equals(other.PayerId)
                ) && 
                (
                    this.Token == other.Token ||
                    this.Token != null &&
                    this.Token.Equals(other.Token)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.InvoiceId != null)
                    hash = hash * 59 + this.InvoiceId.GetHashCode();
                if (this.PayerId != null)
                    hash = hash * 59 + this.PayerId.GetHashCode();
                if (this.Token != null)
                    hash = hash * 59 + this.Token.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
