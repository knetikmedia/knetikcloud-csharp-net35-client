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
    /// StripePaymentRequest
    /// </summary>
    [DataContract]
    public partial class StripePaymentRequest :  IEquatable<StripePaymentRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StripePaymentRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StripePaymentRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StripePaymentRequest" /> class.
        /// </summary>
        /// <param name="Amount">The amount to pay, if not the full remaining balance (leave out to pay in full, but be careful no other partial payment has been started).</param>
        /// <param name="InvoiceId">The id of the invoice to pay (required).</param>
        /// <param name="Token">A token from Stripe to identify payment info to be tied to the customer (required).</param>
        public StripePaymentRequest(decimal? Amount = default(decimal?), int? InvoiceId = default(int?), string Token = default(string))
        {
            // to ensure "InvoiceId" is required (not null)
            if (InvoiceId == null)
            {
                throw new InvalidDataException("InvoiceId is a required property for StripePaymentRequest and cannot be null");
            }
            else
            {
                this.InvoiceId = InvoiceId;
            }
            // to ensure "Token" is required (not null)
            if (Token == null)
            {
                throw new InvalidDataException("Token is a required property for StripePaymentRequest and cannot be null");
            }
            else
            {
                this.Token = Token;
            }
            this.Amount = Amount;
        }
        
        /// <summary>
        /// The amount to pay, if not the full remaining balance (leave out to pay in full, but be careful no other partial payment has been started)
        /// </summary>
        /// <value>The amount to pay, if not the full remaining balance (leave out to pay in full, but be careful no other partial payment has been started)</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public decimal? Amount { get; set; }

        /// <summary>
        /// The id of the invoice to pay
        /// </summary>
        /// <value>The id of the invoice to pay</value>
        [DataMember(Name="invoice_id", EmitDefaultValue=false)]
        public int? InvoiceId { get; set; }

        /// <summary>
        /// A token from Stripe to identify payment info to be tied to the customer
        /// </summary>
        /// <value>A token from Stripe to identify payment info to be tied to the customer</value>
        [DataMember(Name="token", EmitDefaultValue=false)]
        public string Token { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StripePaymentRequest {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  InvoiceId: ").Append(InvoiceId).Append("\n");
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
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as StripePaymentRequest);
        }

        /// <summary>
        /// Returns true if StripePaymentRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of StripePaymentRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StripePaymentRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.InvoiceId == input.InvoiceId ||
                    (this.InvoiceId != null &&
                    this.InvoiceId.Equals(input.InvoiceId))
                ) && 
                (
                    this.Token == input.Token ||
                    (this.Token != null &&
                    this.Token.Equals(input.Token))
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
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.InvoiceId != null)
                    hashCode = hashCode * 59 + this.InvoiceId.GetHashCode();
                if (this.Token != null)
                    hashCode = hashCode * 59 + this.Token.GetHashCode();
                return hashCode;
            }
        }

    }

}
