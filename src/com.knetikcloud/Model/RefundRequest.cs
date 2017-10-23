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
    /// RefundRequest
    /// </summary>
    [DataContract]
    public partial class RefundRequest :  IEquatable<RefundRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RefundRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RefundRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RefundRequest" /> class.
        /// </summary>
        /// <param name="Amount">The amount to refund. If left off, will refund the remaining balance of the transaction or specific item balance (if SKU provided), whichever is less..</param>
        /// <param name="BundleSku">The SKU of a bundle item from the invoice that the target item is within..</param>
        /// <param name="Notes">Notes about or reason for the refund (required).</param>
        /// <param name="Sku">The SKU of a specific item from the invoice to refund. Affects the maximum refund amount (not to exceed the price of this item times quantity on invoice). Transaction must be tied to an invoice if used..</param>
        public RefundRequest(decimal? Amount = default(decimal?), string BundleSku = default(string), string Notes = default(string), string Sku = default(string))
        {
            // to ensure "Notes" is required (not null)
            if (Notes == null)
            {
                throw new InvalidDataException("Notes is a required property for RefundRequest and cannot be null");
            }
            else
            {
                this.Notes = Notes;
            }
            this.Amount = Amount;
            this.BundleSku = BundleSku;
            this.Sku = Sku;
        }
        
        /// <summary>
        /// The amount to refund. If left off, will refund the remaining balance of the transaction or specific item balance (if SKU provided), whichever is less.
        /// </summary>
        /// <value>The amount to refund. If left off, will refund the remaining balance of the transaction or specific item balance (if SKU provided), whichever is less.</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public decimal? Amount { get; set; }

        /// <summary>
        /// The SKU of a bundle item from the invoice that the target item is within.
        /// </summary>
        /// <value>The SKU of a bundle item from the invoice that the target item is within.</value>
        [DataMember(Name="bundle_sku", EmitDefaultValue=false)]
        public string BundleSku { get; set; }

        /// <summary>
        /// Notes about or reason for the refund
        /// </summary>
        /// <value>Notes about or reason for the refund</value>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public string Notes { get; set; }

        /// <summary>
        /// The SKU of a specific item from the invoice to refund. Affects the maximum refund amount (not to exceed the price of this item times quantity on invoice). Transaction must be tied to an invoice if used.
        /// </summary>
        /// <value>The SKU of a specific item from the invoice to refund. Affects the maximum refund amount (not to exceed the price of this item times quantity on invoice). Transaction must be tied to an invoice if used.</value>
        [DataMember(Name="sku", EmitDefaultValue=false)]
        public string Sku { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RefundRequest {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  BundleSku: ").Append(BundleSku).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
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
            return this.Equals(input as RefundRequest);
        }

        /// <summary>
        /// Returns true if RefundRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of RefundRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RefundRequest input)
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
                    this.BundleSku == input.BundleSku ||
                    (this.BundleSku != null &&
                    this.BundleSku.Equals(input.BundleSku))
                ) && 
                (
                    this.Notes == input.Notes ||
                    (this.Notes != null &&
                    this.Notes.Equals(input.Notes))
                ) && 
                (
                    this.Sku == input.Sku ||
                    (this.Sku != null &&
                    this.Sku.Equals(input.Sku))
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
                if (this.BundleSku != null)
                    hashCode = hashCode * 59 + this.BundleSku.GetHashCode();
                if (this.Notes != null)
                    hashCode = hashCode * 59 + this.Notes.GetHashCode();
                if (this.Sku != null)
                    hashCode = hashCode * 59 + this.Sku.GetHashCode();
                return hashCode;
            }
        }

    }

}
