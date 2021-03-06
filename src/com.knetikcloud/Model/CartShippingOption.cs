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
    /// CartShippingOption
    /// </summary>
    [DataContract]
    public partial class CartShippingOption :  IEquatable<CartShippingOption>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CartShippingOption" /> class.
        /// </summary>
        /// <param name="CurrencyCode">CurrencyCode.</param>
        /// <param name="Description">Description.</param>
        /// <param name="Name">Name.</param>
        /// <param name="OriginalPrice">OriginalPrice.</param>
        /// <param name="Price">Price.</param>
        /// <param name="ShippingItemId">ShippingItemId.</param>
        /// <param name="Sku">Sku.</param>
        /// <param name="Taxable">Taxable.</param>
        /// <param name="VendorId">VendorId.</param>
        /// <param name="VendorName">VendorName.</param>
        public CartShippingOption(string CurrencyCode = default(string), string Description = default(string), string Name = default(string), decimal? OriginalPrice = default(decimal?), decimal? Price = default(decimal?), int? ShippingItemId = default(int?), string Sku = default(string), bool? Taxable = default(bool?), int? VendorId = default(int?), string VendorName = default(string))
        {
            this.CurrencyCode = CurrencyCode;
            this.Description = Description;
            this.Name = Name;
            this.OriginalPrice = OriginalPrice;
            this.Price = Price;
            this.ShippingItemId = ShippingItemId;
            this.Sku = Sku;
            this.Taxable = Taxable;
            this.VendorId = VendorId;
            this.VendorName = VendorName;
        }
        
        /// <summary>
        /// Gets or Sets CurrencyCode
        /// </summary>
        [DataMember(Name="currency_code", EmitDefaultValue=false)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets OriginalPrice
        /// </summary>
        [DataMember(Name="original_price", EmitDefaultValue=false)]
        public decimal? OriginalPrice { get; set; }

        /// <summary>
        /// Gets or Sets Price
        /// </summary>
        [DataMember(Name="price", EmitDefaultValue=false)]
        public decimal? Price { get; set; }

        /// <summary>
        /// Gets or Sets ShippingItemId
        /// </summary>
        [DataMember(Name="shipping_item_id", EmitDefaultValue=false)]
        public int? ShippingItemId { get; set; }

        /// <summary>
        /// Gets or Sets Sku
        /// </summary>
        [DataMember(Name="sku", EmitDefaultValue=false)]
        public string Sku { get; set; }

        /// <summary>
        /// Gets or Sets Taxable
        /// </summary>
        [DataMember(Name="taxable", EmitDefaultValue=false)]
        public bool? Taxable { get; set; }

        /// <summary>
        /// Gets or Sets VendorId
        /// </summary>
        [DataMember(Name="vendor_id", EmitDefaultValue=false)]
        public int? VendorId { get; set; }

        /// <summary>
        /// Gets or Sets VendorName
        /// </summary>
        [DataMember(Name="vendor_name", EmitDefaultValue=false)]
        public string VendorName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CartShippingOption {\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OriginalPrice: ").Append(OriginalPrice).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  ShippingItemId: ").Append(ShippingItemId).Append("\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  Taxable: ").Append(Taxable).Append("\n");
            sb.Append("  VendorId: ").Append(VendorId).Append("\n");
            sb.Append("  VendorName: ").Append(VendorName).Append("\n");
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
            return this.Equals(input as CartShippingOption);
        }

        /// <summary>
        /// Returns true if CartShippingOption instances are equal
        /// </summary>
        /// <param name="input">Instance of CartShippingOption to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CartShippingOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CurrencyCode == input.CurrencyCode ||
                    (this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(input.CurrencyCode))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.OriginalPrice == input.OriginalPrice ||
                    (this.OriginalPrice != null &&
                    this.OriginalPrice.Equals(input.OriginalPrice))
                ) && 
                (
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
                ) && 
                (
                    this.ShippingItemId == input.ShippingItemId ||
                    (this.ShippingItemId != null &&
                    this.ShippingItemId.Equals(input.ShippingItemId))
                ) && 
                (
                    this.Sku == input.Sku ||
                    (this.Sku != null &&
                    this.Sku.Equals(input.Sku))
                ) && 
                (
                    this.Taxable == input.Taxable ||
                    (this.Taxable != null &&
                    this.Taxable.Equals(input.Taxable))
                ) && 
                (
                    this.VendorId == input.VendorId ||
                    (this.VendorId != null &&
                    this.VendorId.Equals(input.VendorId))
                ) && 
                (
                    this.VendorName == input.VendorName ||
                    (this.VendorName != null &&
                    this.VendorName.Equals(input.VendorName))
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
                if (this.CurrencyCode != null)
                    hashCode = hashCode * 59 + this.CurrencyCode.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.OriginalPrice != null)
                    hashCode = hashCode * 59 + this.OriginalPrice.GetHashCode();
                if (this.Price != null)
                    hashCode = hashCode * 59 + this.Price.GetHashCode();
                if (this.ShippingItemId != null)
                    hashCode = hashCode * 59 + this.ShippingItemId.GetHashCode();
                if (this.Sku != null)
                    hashCode = hashCode * 59 + this.Sku.GetHashCode();
                if (this.Taxable != null)
                    hashCode = hashCode * 59 + this.Taxable.GetHashCode();
                if (this.VendorId != null)
                    hashCode = hashCode * 59 + this.VendorId.GetHashCode();
                if (this.VendorName != null)
                    hashCode = hashCode * 59 + this.VendorName.GetHashCode();
                return hashCode;
            }
        }

    }

}
