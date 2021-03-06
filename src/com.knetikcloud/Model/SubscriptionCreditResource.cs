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
    /// SubscriptionCreditResource
    /// </summary>
    [DataContract]
    public partial class SubscriptionCreditResource :  IEquatable<SubscriptionCreditResource>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionCreditResource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SubscriptionCreditResource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionCreditResource" /> class.
        /// </summary>
        /// <param name="Amount">The amount of the credit, negative for debt (required).</param>
        /// <param name="InventoryId">The id of the subscription inventory entry.</param>
        /// <param name="Reason">The reason for the subscription credit (required).</param>
        public SubscriptionCreditResource(decimal? Amount = default(decimal?), int? InventoryId = default(int?), string Reason = default(string))
        {
            // to ensure "Amount" is required (not null)
            if (Amount == null)
            {
                throw new InvalidDataException("Amount is a required property for SubscriptionCreditResource and cannot be null");
            }
            else
            {
                this.Amount = Amount;
            }
            // to ensure "Reason" is required (not null)
            if (Reason == null)
            {
                throw new InvalidDataException("Reason is a required property for SubscriptionCreditResource and cannot be null");
            }
            else
            {
                this.Reason = Reason;
            }
            this.InventoryId = InventoryId;
        }
        
        /// <summary>
        /// The amount of the credit, negative for debt
        /// </summary>
        /// <value>The amount of the credit, negative for debt</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public decimal? Amount { get; set; }

        /// <summary>
        /// The date this credit was added, unix timestamp in seconds
        /// </summary>
        /// <value>The date this credit was added, unix timestamp in seconds</value>
        [DataMember(Name="created_date", EmitDefaultValue=false)]
        public long? CreatedDate { get; private set; }

        /// <summary>
        /// The id of the credit record
        /// </summary>
        /// <value>The id of the credit record</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }

        /// <summary>
        /// The id of the subscription inventory entry
        /// </summary>
        /// <value>The id of the subscription inventory entry</value>
        [DataMember(Name="inventory_id", EmitDefaultValue=false)]
        public int? InventoryId { get; set; }

        /// <summary>
        /// The reason for the subscription credit
        /// </summary>
        /// <value>The reason for the subscription credit</value>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public string Reason { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubscriptionCreditResource {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  InventoryId: ").Append(InventoryId).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
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
            return this.Equals(input as SubscriptionCreditResource);
        }

        /// <summary>
        /// Returns true if SubscriptionCreditResource instances are equal
        /// </summary>
        /// <param name="input">Instance of SubscriptionCreditResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionCreditResource input)
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
                    this.CreatedDate == input.CreatedDate ||
                    (this.CreatedDate != null &&
                    this.CreatedDate.Equals(input.CreatedDate))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.InventoryId == input.InventoryId ||
                    (this.InventoryId != null &&
                    this.InventoryId.Equals(input.InventoryId))
                ) && 
                (
                    this.Reason == input.Reason ||
                    (this.Reason != null &&
                    this.Reason.Equals(input.Reason))
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
                if (this.CreatedDate != null)
                    hashCode = hashCode * 59 + this.CreatedDate.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.InventoryId != null)
                    hashCode = hashCode * 59 + this.InventoryId.GetHashCode();
                if (this.Reason != null)
                    hashCode = hashCode * 59 + this.Reason.GetHashCode();
                return hashCode;
            }
        }

    }

}
