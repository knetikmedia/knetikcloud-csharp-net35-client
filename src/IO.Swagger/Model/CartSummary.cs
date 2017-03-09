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
    /// CartSummary
    /// </summary>
    [DataContract]
    public partial class CartSummary :  IEquatable<CartSummary>, IValidatableObject
    {
        /// <summary>
        /// The status of the cart
        /// </summary>
        /// <value>The status of the cart</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum Active for "active"
            /// </summary>
            [EnumMember(Value = "active")]
            Active,
            
            /// <summary>
            /// Enum Processing for "processing"
            /// </summary>
            [EnumMember(Value = "processing")]
            Processing,
            
            /// <summary>
            /// Enum Closed for "closed"
            /// </summary>
            [EnumMember(Value = "closed")]
            Closed,
            
            /// <summary>
            /// Enum Onhold for "onhold"
            /// </summary>
            [EnumMember(Value = "onhold")]
            Onhold
        }

        /// <summary>
        /// The status of the cart
        /// </summary>
        /// <value>The status of the cart</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CartSummary" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public CartSummary()
        {
        }
        
        /// <summary>
        /// The date/time this resource was created in seconds since unix epoch
        /// </summary>
        /// <value>The date/time this resource was created in seconds since unix epoch</value>
        [DataMember(Name="created_date", EmitDefaultValue=false)]
        public long? CreatedDate { get; private set; }
        /// <summary>
        /// The unique id code for the currency used in the cart
        /// </summary>
        /// <value>The unique id code for the currency used in the cart</value>
        [DataMember(Name="currency_code", EmitDefaultValue=false)]
        public string CurrencyCode { get; private set; }
        /// <summary>
        /// The grand total for the cart
        /// </summary>
        /// <value>The grand total for the cart</value>
        [DataMember(Name="grand_total", EmitDefaultValue=false)]
        public double? GrandTotal { get; private set; }
        /// <summary>
        /// The unique ID for the cart
        /// </summary>
        /// <value>The unique ID for the cart</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        /// <summary>
        /// The ID of the invoice associated with this cart
        /// </summary>
        /// <value>The ID of the invoice associated with this cart</value>
        [DataMember(Name="invoice_id", EmitDefaultValue=false)]
        public double? InvoiceId { get; private set; }
        /// <summary>
        /// The number of items in the cart
        /// </summary>
        /// <value>The number of items in the cart</value>
        [DataMember(Name="items_in_cart", EmitDefaultValue=false)]
        public int? ItemsInCart { get; private set; }
        /// <summary>
        /// The subtotal of all items in the cart
        /// </summary>
        /// <value>The subtotal of all items in the cart</value>
        [DataMember(Name="subtotal", EmitDefaultValue=false)]
        public double? Subtotal { get; private set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CartSummary {\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  GrandTotal: ").Append(GrandTotal).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  InvoiceId: ").Append(InvoiceId).Append("\n");
            sb.Append("  ItemsInCart: ").Append(ItemsInCart).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Subtotal: ").Append(Subtotal).Append("\n");
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
            return this.Equals(obj as CartSummary);
        }

        /// <summary>
        /// Returns true if CartSummary instances are equal
        /// </summary>
        /// <param name="other">Instance of CartSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CartSummary other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CreatedDate == other.CreatedDate ||
                    this.CreatedDate != null &&
                    this.CreatedDate.Equals(other.CreatedDate)
                ) && 
                (
                    this.CurrencyCode == other.CurrencyCode ||
                    this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(other.CurrencyCode)
                ) && 
                (
                    this.GrandTotal == other.GrandTotal ||
                    this.GrandTotal != null &&
                    this.GrandTotal.Equals(other.GrandTotal)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.InvoiceId == other.InvoiceId ||
                    this.InvoiceId != null &&
                    this.InvoiceId.Equals(other.InvoiceId)
                ) && 
                (
                    this.ItemsInCart == other.ItemsInCart ||
                    this.ItemsInCart != null &&
                    this.ItemsInCart.Equals(other.ItemsInCart)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.Subtotal == other.Subtotal ||
                    this.Subtotal != null &&
                    this.Subtotal.Equals(other.Subtotal)
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
                if (this.CreatedDate != null)
                    hash = hash * 59 + this.CreatedDate.GetHashCode();
                if (this.CurrencyCode != null)
                    hash = hash * 59 + this.CurrencyCode.GetHashCode();
                if (this.GrandTotal != null)
                    hash = hash * 59 + this.GrandTotal.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.InvoiceId != null)
                    hash = hash * 59 + this.InvoiceId.GetHashCode();
                if (this.ItemsInCart != null)
                    hash = hash * 59 + this.ItemsInCart.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.Subtotal != null)
                    hash = hash * 59 + this.Subtotal.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
