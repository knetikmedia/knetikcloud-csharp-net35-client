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
    /// Cart
    /// </summary>
    [DataContract]
    public partial class Cart :  IEquatable<Cart>
    {
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
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
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Cart" /> class.
        /// </summary>
        /// <param name="AvailableShippingOptions">AvailableShippingOptions.</param>
        /// <param name="CountryTax">CountryTax.</param>
        /// <param name="Coupons">Coupons.</param>
        /// <param name="Created">Created.</param>
        /// <param name="CurrencyCode">CurrencyCode.</param>
        /// <param name="DiscountTotal">DiscountTotal.</param>
        /// <param name="ErrorCode">ErrorCode.</param>
        /// <param name="ErrorMessage">ErrorMessage.</param>
        /// <param name="GrandTotal">GrandTotal.</param>
        /// <param name="Id">Id.</param>
        /// <param name="InvoiceId">InvoiceId.</param>
        /// <param name="Items">Items.</param>
        /// <param name="Owner">Owner.</param>
        /// <param name="SelectedShippingOptions">SelectedShippingOptions.</param>
        /// <param name="Shippable">Shippable.</param>
        /// <param name="ShippingAddress">ShippingAddress.</param>
        /// <param name="ShippingCost">ShippingCost.</param>
        /// <param name="StateTax">StateTax.</param>
        /// <param name="Status">Status.</param>
        /// <param name="Subtotal">Subtotal.</param>
        /// <param name="Updated">Updated.</param>
        public Cart(List<CartShippingOption> AvailableShippingOptions = default(List<CartShippingOption>), decimal? CountryTax = default(decimal?), List<CouponDefinition> Coupons = default(List<CouponDefinition>), long? Created = default(long?), string CurrencyCode = default(string), decimal? DiscountTotal = default(decimal?), int? ErrorCode = default(int?), string ErrorMessage = default(string), decimal? GrandTotal = default(decimal?), string Id = default(string), decimal? InvoiceId = default(decimal?), List<CartLineItem> Items = default(List<CartLineItem>), int? Owner = default(int?), List<CartShippingOption> SelectedShippingOptions = default(List<CartShippingOption>), bool? Shippable = default(bool?), CartShippingAddressRequest ShippingAddress = default(CartShippingAddressRequest), decimal? ShippingCost = default(decimal?), decimal? StateTax = default(decimal?), StatusEnum? Status = default(StatusEnum?), decimal? Subtotal = default(decimal?), long? Updated = default(long?))
        {
            this.AvailableShippingOptions = AvailableShippingOptions;
            this.CountryTax = CountryTax;
            this.Coupons = Coupons;
            this.Created = Created;
            this.CurrencyCode = CurrencyCode;
            this.DiscountTotal = DiscountTotal;
            this.ErrorCode = ErrorCode;
            this.ErrorMessage = ErrorMessage;
            this.GrandTotal = GrandTotal;
            this.Id = Id;
            this.InvoiceId = InvoiceId;
            this.Items = Items;
            this.Owner = Owner;
            this.SelectedShippingOptions = SelectedShippingOptions;
            this.Shippable = Shippable;
            this.ShippingAddress = ShippingAddress;
            this.ShippingCost = ShippingCost;
            this.StateTax = StateTax;
            this.Status = Status;
            this.Subtotal = Subtotal;
            this.Updated = Updated;
        }
        
        /// <summary>
        /// Gets or Sets AvailableShippingOptions
        /// </summary>
        [DataMember(Name="available_shipping_options", EmitDefaultValue=false)]
        public List<CartShippingOption> AvailableShippingOptions { get; set; }

        /// <summary>
        /// Gets or Sets CountryTax
        /// </summary>
        [DataMember(Name="country_tax", EmitDefaultValue=false)]
        public decimal? CountryTax { get; set; }

        /// <summary>
        /// Gets or Sets Coupons
        /// </summary>
        [DataMember(Name="coupons", EmitDefaultValue=false)]
        public List<CouponDefinition> Coupons { get; set; }

        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public long? Created { get; set; }

        /// <summary>
        /// Gets or Sets CurrencyCode
        /// </summary>
        [DataMember(Name="currency_code", EmitDefaultValue=false)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Gets or Sets DiscountTotal
        /// </summary>
        [DataMember(Name="discount_total", EmitDefaultValue=false)]
        public decimal? DiscountTotal { get; set; }

        /// <summary>
        /// Gets or Sets ErrorCode
        /// </summary>
        [DataMember(Name="error_code", EmitDefaultValue=false)]
        public int? ErrorCode { get; set; }

        /// <summary>
        /// Gets or Sets ErrorMessage
        /// </summary>
        [DataMember(Name="error_message", EmitDefaultValue=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Gets or Sets GrandTotal
        /// </summary>
        [DataMember(Name="grand_total", EmitDefaultValue=false)]
        public decimal? GrandTotal { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets InvoiceId
        /// </summary>
        [DataMember(Name="invoice_id", EmitDefaultValue=false)]
        public decimal? InvoiceId { get; set; }

        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public List<CartLineItem> Items { get; set; }

        /// <summary>
        /// Gets or Sets Owner
        /// </summary>
        [DataMember(Name="owner", EmitDefaultValue=false)]
        public int? Owner { get; set; }

        /// <summary>
        /// Gets or Sets SelectedShippingOptions
        /// </summary>
        [DataMember(Name="selected_shipping_options", EmitDefaultValue=false)]
        public List<CartShippingOption> SelectedShippingOptions { get; set; }

        /// <summary>
        /// Gets or Sets Shippable
        /// </summary>
        [DataMember(Name="shippable", EmitDefaultValue=false)]
        public bool? Shippable { get; set; }

        /// <summary>
        /// Gets or Sets ShippingAddress
        /// </summary>
        [DataMember(Name="shipping_address", EmitDefaultValue=false)]
        public CartShippingAddressRequest ShippingAddress { get; set; }

        /// <summary>
        /// Gets or Sets ShippingCost
        /// </summary>
        [DataMember(Name="shipping_cost", EmitDefaultValue=false)]
        public decimal? ShippingCost { get; set; }

        /// <summary>
        /// Gets or Sets StateTax
        /// </summary>
        [DataMember(Name="state_tax", EmitDefaultValue=false)]
        public decimal? StateTax { get; set; }


        /// <summary>
        /// Gets or Sets Subtotal
        /// </summary>
        [DataMember(Name="subtotal", EmitDefaultValue=false)]
        public decimal? Subtotal { get; set; }

        /// <summary>
        /// Gets or Sets Updated
        /// </summary>
        [DataMember(Name="updated", EmitDefaultValue=false)]
        public long? Updated { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Cart {\n");
            sb.Append("  AvailableShippingOptions: ").Append(AvailableShippingOptions).Append("\n");
            sb.Append("  CountryTax: ").Append(CountryTax).Append("\n");
            sb.Append("  Coupons: ").Append(Coupons).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  DiscountTotal: ").Append(DiscountTotal).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  GrandTotal: ").Append(GrandTotal).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  InvoiceId: ").Append(InvoiceId).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  SelectedShippingOptions: ").Append(SelectedShippingOptions).Append("\n");
            sb.Append("  Shippable: ").Append(Shippable).Append("\n");
            sb.Append("  ShippingAddress: ").Append(ShippingAddress).Append("\n");
            sb.Append("  ShippingCost: ").Append(ShippingCost).Append("\n");
            sb.Append("  StateTax: ").Append(StateTax).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Subtotal: ").Append(Subtotal).Append("\n");
            sb.Append("  Updated: ").Append(Updated).Append("\n");
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
            return this.Equals(input as Cart);
        }

        /// <summary>
        /// Returns true if Cart instances are equal
        /// </summary>
        /// <param name="input">Instance of Cart to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Cart input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AvailableShippingOptions == input.AvailableShippingOptions ||
                    (this.AvailableShippingOptions != null &&
                    this.AvailableShippingOptions.SequenceEqual(input.AvailableShippingOptions))
                ) && 
                (
                    this.CountryTax == input.CountryTax ||
                    (this.CountryTax != null &&
                    this.CountryTax.Equals(input.CountryTax))
                ) && 
                (
                    this.Coupons == input.Coupons ||
                    (this.Coupons != null &&
                    this.Coupons.SequenceEqual(input.Coupons))
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.CurrencyCode == input.CurrencyCode ||
                    (this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(input.CurrencyCode))
                ) && 
                (
                    this.DiscountTotal == input.DiscountTotal ||
                    (this.DiscountTotal != null &&
                    this.DiscountTotal.Equals(input.DiscountTotal))
                ) && 
                (
                    this.ErrorCode == input.ErrorCode ||
                    (this.ErrorCode != null &&
                    this.ErrorCode.Equals(input.ErrorCode))
                ) && 
                (
                    this.ErrorMessage == input.ErrorMessage ||
                    (this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(input.ErrorMessage))
                ) && 
                (
                    this.GrandTotal == input.GrandTotal ||
                    (this.GrandTotal != null &&
                    this.GrandTotal.Equals(input.GrandTotal))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.InvoiceId == input.InvoiceId ||
                    (this.InvoiceId != null &&
                    this.InvoiceId.Equals(input.InvoiceId))
                ) && 
                (
                    this.Items == input.Items ||
                    (this.Items != null &&
                    this.Items.SequenceEqual(input.Items))
                ) && 
                (
                    this.Owner == input.Owner ||
                    (this.Owner != null &&
                    this.Owner.Equals(input.Owner))
                ) && 
                (
                    this.SelectedShippingOptions == input.SelectedShippingOptions ||
                    (this.SelectedShippingOptions != null &&
                    this.SelectedShippingOptions.SequenceEqual(input.SelectedShippingOptions))
                ) && 
                (
                    this.Shippable == input.Shippable ||
                    (this.Shippable != null &&
                    this.Shippable.Equals(input.Shippable))
                ) && 
                (
                    this.ShippingAddress == input.ShippingAddress ||
                    (this.ShippingAddress != null &&
                    this.ShippingAddress.Equals(input.ShippingAddress))
                ) && 
                (
                    this.ShippingCost == input.ShippingCost ||
                    (this.ShippingCost != null &&
                    this.ShippingCost.Equals(input.ShippingCost))
                ) && 
                (
                    this.StateTax == input.StateTax ||
                    (this.StateTax != null &&
                    this.StateTax.Equals(input.StateTax))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Subtotal == input.Subtotal ||
                    (this.Subtotal != null &&
                    this.Subtotal.Equals(input.Subtotal))
                ) && 
                (
                    this.Updated == input.Updated ||
                    (this.Updated != null &&
                    this.Updated.Equals(input.Updated))
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
                if (this.AvailableShippingOptions != null)
                    hashCode = hashCode * 59 + this.AvailableShippingOptions.GetHashCode();
                if (this.CountryTax != null)
                    hashCode = hashCode * 59 + this.CountryTax.GetHashCode();
                if (this.Coupons != null)
                    hashCode = hashCode * 59 + this.Coupons.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.CurrencyCode != null)
                    hashCode = hashCode * 59 + this.CurrencyCode.GetHashCode();
                if (this.DiscountTotal != null)
                    hashCode = hashCode * 59 + this.DiscountTotal.GetHashCode();
                if (this.ErrorCode != null)
                    hashCode = hashCode * 59 + this.ErrorCode.GetHashCode();
                if (this.ErrorMessage != null)
                    hashCode = hashCode * 59 + this.ErrorMessage.GetHashCode();
                if (this.GrandTotal != null)
                    hashCode = hashCode * 59 + this.GrandTotal.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.InvoiceId != null)
                    hashCode = hashCode * 59 + this.InvoiceId.GetHashCode();
                if (this.Items != null)
                    hashCode = hashCode * 59 + this.Items.GetHashCode();
                if (this.Owner != null)
                    hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.SelectedShippingOptions != null)
                    hashCode = hashCode * 59 + this.SelectedShippingOptions.GetHashCode();
                if (this.Shippable != null)
                    hashCode = hashCode * 59 + this.Shippable.GetHashCode();
                if (this.ShippingAddress != null)
                    hashCode = hashCode * 59 + this.ShippingAddress.GetHashCode();
                if (this.ShippingCost != null)
                    hashCode = hashCode * 59 + this.ShippingCost.GetHashCode();
                if (this.StateTax != null)
                    hashCode = hashCode * 59 + this.StateTax.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Subtotal != null)
                    hashCode = hashCode * 59 + this.Subtotal.GetHashCode();
                if (this.Updated != null)
                    hashCode = hashCode * 59 + this.Updated.GetHashCode();
                return hashCode;
            }
        }

    }

}
