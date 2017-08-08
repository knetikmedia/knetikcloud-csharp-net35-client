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
    /// CartLineItem
    /// </summary>
    [DataContract]
    public partial class CartLineItem :  IEquatable<CartLineItem>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CartLineItem" /> class.
        /// </summary>
        /// <param name="CurrencyCode">CurrencyCode.</param>
        /// <param name="Description">Description.</param>
        /// <param name="Discount">Discount.</param>
        /// <param name="LineTotal">LineTotal.</param>
        /// <param name="Name">Name.</param>
        /// <param name="OriginalLineTotal">OriginalLineTotal.</param>
        /// <param name="OriginalUnitPrice">OriginalUnitPrice.</param>
        /// <param name="Qty">Qty.</param>
        /// <param name="SaleName">SaleName.</param>
        /// <param name="Sku">Sku.</param>
        /// <param name="SkuDescription">SkuDescription.</param>
        /// <param name="StoreItemId">StoreItemId.</param>
        /// <param name="Tags">Tags.</param>
        /// <param name="ThumbUrl">ThumbUrl.</param>
        /// <param name="UniqueKey">UniqueKey.</param>
        /// <param name="UnitPrice">UnitPrice.</param>
        /// <param name="VendorId">VendorId.</param>
        /// <param name="VendorName">VendorName.</param>
        public CartLineItem(string CurrencyCode = default(string), string Description = default(string), Discount Discount = default(Discount), double? LineTotal = default(double?), string Name = default(string), double? OriginalLineTotal = default(double?), double? OriginalUnitPrice = default(double?), int? Qty = default(int?), string SaleName = default(string), string Sku = default(string), string SkuDescription = default(string), int? StoreItemId = default(int?), List<string> Tags = default(List<string>), string ThumbUrl = default(string), string UniqueKey = default(string), double? UnitPrice = default(double?), int? VendorId = default(int?), string VendorName = default(string))
        {
            this.CurrencyCode = CurrencyCode;
            this.Description = Description;
            this.Discount = Discount;
            this.LineTotal = LineTotal;
            this.Name = Name;
            this.OriginalLineTotal = OriginalLineTotal;
            this.OriginalUnitPrice = OriginalUnitPrice;
            this.Qty = Qty;
            this.SaleName = SaleName;
            this.Sku = Sku;
            this.SkuDescription = SkuDescription;
            this.StoreItemId = StoreItemId;
            this.Tags = Tags;
            this.ThumbUrl = ThumbUrl;
            this.UniqueKey = UniqueKey;
            this.UnitPrice = UnitPrice;
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
        /// Gets or Sets Discount
        /// </summary>
        [DataMember(Name="discount", EmitDefaultValue=false)]
        public Discount Discount { get; set; }

        /// <summary>
        /// Gets or Sets LineTotal
        /// </summary>
        [DataMember(Name="line_total", EmitDefaultValue=false)]
        public double? LineTotal { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets OriginalLineTotal
        /// </summary>
        [DataMember(Name="original_line_total", EmitDefaultValue=false)]
        public double? OriginalLineTotal { get; set; }

        /// <summary>
        /// Gets or Sets OriginalUnitPrice
        /// </summary>
        [DataMember(Name="original_unit_price", EmitDefaultValue=false)]
        public double? OriginalUnitPrice { get; set; }

        /// <summary>
        /// Gets or Sets Qty
        /// </summary>
        [DataMember(Name="qty", EmitDefaultValue=false)]
        public int? Qty { get; set; }

        /// <summary>
        /// Gets or Sets SaleName
        /// </summary>
        [DataMember(Name="sale_name", EmitDefaultValue=false)]
        public string SaleName { get; set; }

        /// <summary>
        /// Gets or Sets Sku
        /// </summary>
        [DataMember(Name="sku", EmitDefaultValue=false)]
        public string Sku { get; set; }

        /// <summary>
        /// Gets or Sets SkuDescription
        /// </summary>
        [DataMember(Name="sku_description", EmitDefaultValue=false)]
        public string SkuDescription { get; set; }

        /// <summary>
        /// Gets or Sets StoreItemId
        /// </summary>
        [DataMember(Name="store_item_id", EmitDefaultValue=false)]
        public int? StoreItemId { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Gets or Sets ThumbUrl
        /// </summary>
        [DataMember(Name="thumb_url", EmitDefaultValue=false)]
        public string ThumbUrl { get; set; }

        /// <summary>
        /// Gets or Sets UniqueKey
        /// </summary>
        [DataMember(Name="unique_key", EmitDefaultValue=false)]
        public string UniqueKey { get; set; }

        /// <summary>
        /// Gets or Sets UnitPrice
        /// </summary>
        [DataMember(Name="unit_price", EmitDefaultValue=false)]
        public double? UnitPrice { get; set; }

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
            sb.Append("class CartLineItem {\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Discount: ").Append(Discount).Append("\n");
            sb.Append("  LineTotal: ").Append(LineTotal).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OriginalLineTotal: ").Append(OriginalLineTotal).Append("\n");
            sb.Append("  OriginalUnitPrice: ").Append(OriginalUnitPrice).Append("\n");
            sb.Append("  Qty: ").Append(Qty).Append("\n");
            sb.Append("  SaleName: ").Append(SaleName).Append("\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  SkuDescription: ").Append(SkuDescription).Append("\n");
            sb.Append("  StoreItemId: ").Append(StoreItemId).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  ThumbUrl: ").Append(ThumbUrl).Append("\n");
            sb.Append("  UniqueKey: ").Append(UniqueKey).Append("\n");
            sb.Append("  UnitPrice: ").Append(UnitPrice).Append("\n");
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
            return this.Equals(input as CartLineItem);
        }

        /// <summary>
        /// Returns true if CartLineItem instances are equal
        /// </summary>
        /// <param name="input">Instance of CartLineItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CartLineItem input)
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
                    this.Discount == input.Discount ||
                    (this.Discount != null &&
                    this.Discount.Equals(input.Discount))
                ) && 
                (
                    this.LineTotal == input.LineTotal ||
                    (this.LineTotal != null &&
                    this.LineTotal.Equals(input.LineTotal))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.OriginalLineTotal == input.OriginalLineTotal ||
                    (this.OriginalLineTotal != null &&
                    this.OriginalLineTotal.Equals(input.OriginalLineTotal))
                ) && 
                (
                    this.OriginalUnitPrice == input.OriginalUnitPrice ||
                    (this.OriginalUnitPrice != null &&
                    this.OriginalUnitPrice.Equals(input.OriginalUnitPrice))
                ) && 
                (
                    this.Qty == input.Qty ||
                    (this.Qty != null &&
                    this.Qty.Equals(input.Qty))
                ) && 
                (
                    this.SaleName == input.SaleName ||
                    (this.SaleName != null &&
                    this.SaleName.Equals(input.SaleName))
                ) && 
                (
                    this.Sku == input.Sku ||
                    (this.Sku != null &&
                    this.Sku.Equals(input.Sku))
                ) && 
                (
                    this.SkuDescription == input.SkuDescription ||
                    (this.SkuDescription != null &&
                    this.SkuDescription.Equals(input.SkuDescription))
                ) && 
                (
                    this.StoreItemId == input.StoreItemId ||
                    (this.StoreItemId != null &&
                    this.StoreItemId.Equals(input.StoreItemId))
                ) && 
                (
                    this.Tags == input.Tags ||
                    (this.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags))
                ) && 
                (
                    this.ThumbUrl == input.ThumbUrl ||
                    (this.ThumbUrl != null &&
                    this.ThumbUrl.Equals(input.ThumbUrl))
                ) && 
                (
                    this.UniqueKey == input.UniqueKey ||
                    (this.UniqueKey != null &&
                    this.UniqueKey.Equals(input.UniqueKey))
                ) && 
                (
                    this.UnitPrice == input.UnitPrice ||
                    (this.UnitPrice != null &&
                    this.UnitPrice.Equals(input.UnitPrice))
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
                if (this.Discount != null)
                    hashCode = hashCode * 59 + this.Discount.GetHashCode();
                if (this.LineTotal != null)
                    hashCode = hashCode * 59 + this.LineTotal.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.OriginalLineTotal != null)
                    hashCode = hashCode * 59 + this.OriginalLineTotal.GetHashCode();
                if (this.OriginalUnitPrice != null)
                    hashCode = hashCode * 59 + this.OriginalUnitPrice.GetHashCode();
                if (this.Qty != null)
                    hashCode = hashCode * 59 + this.Qty.GetHashCode();
                if (this.SaleName != null)
                    hashCode = hashCode * 59 + this.SaleName.GetHashCode();
                if (this.Sku != null)
                    hashCode = hashCode * 59 + this.Sku.GetHashCode();
                if (this.SkuDescription != null)
                    hashCode = hashCode * 59 + this.SkuDescription.GetHashCode();
                if (this.StoreItemId != null)
                    hashCode = hashCode * 59 + this.StoreItemId.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.ThumbUrl != null)
                    hashCode = hashCode * 59 + this.ThumbUrl.GetHashCode();
                if (this.UniqueKey != null)
                    hashCode = hashCode * 59 + this.UniqueKey.GetHashCode();
                if (this.UnitPrice != null)
                    hashCode = hashCode * 59 + this.UnitPrice.GetHashCode();
                if (this.VendorId != null)
                    hashCode = hashCode * 59 + this.VendorId.GetHashCode();
                if (this.VendorName != null)
                    hashCode = hashCode * 59 + this.VendorName.GetHashCode();
                return hashCode;
            }
        }

    }

}
