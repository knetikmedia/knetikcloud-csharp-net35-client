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
    /// RefundResource
    /// </summary>
    [DataContract]
    public partial class RefundResource :  IEquatable<RefundResource>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RefundResource" /> class.
        /// </summary>
        /// <param name="Amount">The amount refunded.</param>
        /// <param name="RefundTransactionId">The id of the refund transaction.</param>
        /// <param name="TransactionId">The id of the original transaction.</param>
        public RefundResource(double? Amount = default(double?), int? RefundTransactionId = default(int?), int? TransactionId = default(int?))
        {
            this.Amount = Amount;
            this.RefundTransactionId = RefundTransactionId;
            this.TransactionId = TransactionId;
        }
        
        /// <summary>
        /// The amount refunded
        /// </summary>
        /// <value>The amount refunded</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public double? Amount { get; set; }

        /// <summary>
        /// The id of the refund transaction
        /// </summary>
        /// <value>The id of the refund transaction</value>
        [DataMember(Name="refund_transaction_id", EmitDefaultValue=false)]
        public int? RefundTransactionId { get; set; }

        /// <summary>
        /// The id of the original transaction
        /// </summary>
        /// <value>The id of the original transaction</value>
        [DataMember(Name="transaction_id", EmitDefaultValue=false)]
        public int? TransactionId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RefundResource {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  RefundTransactionId: ").Append(RefundTransactionId).Append("\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
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
            return this.Equals(input as RefundResource);
        }

        /// <summary>
        /// Returns true if RefundResource instances are equal
        /// </summary>
        /// <param name="input">Instance of RefundResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RefundResource input)
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
                    this.RefundTransactionId == input.RefundTransactionId ||
                    (this.RefundTransactionId != null &&
                    this.RefundTransactionId.Equals(input.RefundTransactionId))
                ) && 
                (
                    this.TransactionId == input.TransactionId ||
                    (this.TransactionId != null &&
                    this.TransactionId.Equals(input.TransactionId))
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
                if (this.RefundTransactionId != null)
                    hashCode = hashCode * 59 + this.RefundTransactionId.GetHashCode();
                if (this.TransactionId != null)
                    hashCode = hashCode * 59 + this.TransactionId.GetHashCode();
                return hashCode;
            }
        }

    }

}
