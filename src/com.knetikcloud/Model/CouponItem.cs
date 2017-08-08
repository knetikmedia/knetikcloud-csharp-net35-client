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
    /// CouponItem
    /// </summary>
    [DataContract]
    public partial class CouponItem : StoreItem,  IEquatable<CouponItem>
    {
        /// <summary>
        /// The type of coupon
        /// </summary>
        /// <value>The type of coupon</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CouponTypeHintEnum
        {
            
            /// <summary>
            /// Enum Cart for "coupon_cart"
            /// </summary>
            [EnumMember(Value = "coupon_cart")]
            Cart,
            
            /// <summary>
            /// Enum Singleitem for "coupon_single_item"
            /// </summary>
            [EnumMember(Value = "coupon_single_item")]
            Singleitem,
            
            /// <summary>
            /// Enum Voucher for "coupon_voucher"
            /// </summary>
            [EnumMember(Value = "coupon_voucher")]
            Voucher,
            
            /// <summary>
            /// Enum Vendor for "coupon_vendor"
            /// </summary>
            [EnumMember(Value = "coupon_vendor")]
            Vendor,
            
            /// <summary>
            /// Enum Tag for "coupon_tag"
            /// </summary>
            [EnumMember(Value = "coupon_tag")]
            Tag
        }

        /// <summary>
        /// The type of discount in terms of how it deducts price. Value based discount not available for coupon_cart type coupons
        /// </summary>
        /// <value>The type of discount in terms of how it deducts price. Value based discount not available for coupon_cart type coupons</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DiscountTypeEnum
        {
            
            /// <summary>
            /// Enum Value for "value"
            /// </summary>
            [EnumMember(Value = "value")]
            Value,
            
            /// <summary>
            /// Enum Percentage for "percentage"
            /// </summary>
            [EnumMember(Value = "percentage")]
            Percentage
        }

        /// <summary>
        /// The type of coupon
        /// </summary>
        /// <value>The type of coupon</value>
        [DataMember(Name="coupon_type_hint", EmitDefaultValue=false)]
        public CouponTypeHintEnum? CouponTypeHint { get; set; }
        /// <summary>
        /// The type of discount in terms of how it deducts price. Value based discount not available for coupon_cart type coupons
        /// </summary>
        /// <value>The type of discount in terms of how it deducts price. Value based discount not available for coupon_cart type coupons</value>
        [DataMember(Name="discount_type", EmitDefaultValue=false)]
        public DiscountTypeEnum? DiscountType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CouponItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CouponItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CouponItem" /> class.
        /// </summary>
        /// <param name="AdditionalProperties">A map of additional properties, keyed on the property name.  Must match the names and types defined in the template for this item type, or be an extra not from the template.</param>
        /// <param name="Behaviors">The behaviors linked to the item, describing various options and interactions. May not be included in item lists.</param>
        /// <param name="Category">A category for filtering items.</param>
        /// <param name="LongDescription">A long description of the item.</param>
        /// <param name="Name">The name of the item (required).</param>
        /// <param name="ShortDescription">A short description of the item, max 255 chars.</param>
        /// <param name="Sort">A number to use in sorting items.  Default 500.</param>
        /// <param name="Tags">List of tags used for filtering items.</param>
        /// <param name="Template">An item template this item is validated against.  May be null and no validation of additional_properties will be done.  Default &#x3D; null.</param>
        /// <param name="TypeHint">The type of the item (required).</param>
        /// <param name="UniqueKey">The unique key for the item.</param>
        /// <param name="Displayable">Whether or not the item is currently displayable.  Default &#x3D; true.</param>
        /// <param name="GeoCountryList">A list of country ID to include in the blacklist/whitelist geo policy.</param>
        /// <param name="ShippingTier">Provides the abstract shipping needs if this item is physical and can be shipped.  A value of zero means no shipping needed.  Default &#x3D; 0.</param>
        /// <param name="Skus">The skus for the item. Each defines a unique configuration for the item to be purchased (Large-Blue, Small-Green, etc). These are what is ultimately selected in the store and added to the cart (required).</param>
        /// <param name="StoreEnd">The date the item will leave the store, unix timestamp in seconds.  If set to null, item will never leave the store.</param>
        /// <param name="StoreStart">The date the item will appear in the store, unix timestamp in seconds.  If set to null, item will appear in store immediately.</param>
        /// <param name="VendorId">The vendor who provides the item (required).</param>
        /// <param name="CouponTypeHint">The type of coupon (required).</param>
        /// <param name="DiscountMax">The amount this coupon is maxed out at.  Applies if coupon_type_hint is coupon_cart.</param>
        /// <param name="DiscountMinCartValue">The minimium amount needed in the cart for the coupon to apply.  Applies if coupon_type_hint is coupon_cart.</param>
        /// <param name="DiscountType">The type of discount in terms of how it deducts price. Value based discount not available for coupon_cart type coupons (required).</param>
        /// <param name="DiscountValue">The amount the coupon will discount the item. If discount_type is &#39;value&#39; this will be a flat amount of currency. If discount type is &#39;percentage&#39; this will be a fraction (0.2 for 20% off) multiplied by the price of the matching item or items. (required).</param>
        /// <param name="Exclusive">Whether this coupon is exclusive or not (true means cannot be in same cart as another).  Default &#x3D; false.</param>
        /// <param name="ItemId">The id of the item the coupon is applied to.  Applies if coupon_type_hint is coupon_single_item or coupon_voucher.</param>
        /// <param name="MaxQuantity">The maximum quantity of items the coupon can apply to, null if no limit and minimum 1 otherwise.  Applies if coupon_type_hint is coupon_single_item or coupon_voucher.</param>
        /// <param name="SelfExclusive">Whether this coupon is exclusive to itself or not (true means cannot add two of this same coupon to the same cart).  Default &#x3D; false.</param>
        /// <param name="ValidForTags">A list of tags for a coupon.  The coupon can only apply to an item that has at least one of these tags.  Applies if coupon_type_hint is coupon_tag.</param>
        public CouponItem(Dictionary<string, Property> AdditionalProperties = default(Dictionary<string, Property>), List<Behavior> Behaviors = default(List<Behavior>), string Category = default(string), string LongDescription = default(string), string Name = default(string), string ShortDescription = default(string), int? Sort = default(int?), List<string> Tags = default(List<string>), string Template = default(string), string TypeHint = default(string), string UniqueKey = default(string), bool? Displayable = default(bool?), List<string> GeoCountryList = default(List<string>), GeoPolicyTypeEnum? GeoPolicyType = default(GeoPolicyTypeEnum?), int? ShippingTier = default(int?), List<Sku> Skus = default(List<Sku>), long? StoreEnd = default(long?), long? StoreStart = default(long?), int? VendorId = default(int?), CouponTypeHintEnum? CouponTypeHint = default(CouponTypeHintEnum?), double? DiscountMax = default(double?), double? DiscountMinCartValue = default(double?), DiscountTypeEnum? DiscountType = default(DiscountTypeEnum?), double? DiscountValue = default(double?), bool? Exclusive = default(bool?), int? ItemId = default(int?), int? MaxQuantity = default(int?), bool? SelfExclusive = default(bool?), List<string> ValidForTags = default(List<string>))
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for CouponItem and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "TypeHint" is required (not null)
            if (TypeHint == null)
            {
                throw new InvalidDataException("TypeHint is a required property for CouponItem and cannot be null");
            }
            else
            {
                this.TypeHint = TypeHint;
            }
            // to ensure "Skus" is required (not null)
            if (Skus == null)
            {
                throw new InvalidDataException("Skus is a required property for CouponItem and cannot be null");
            }
            else
            {
                this.Skus = Skus;
            }
            // to ensure "VendorId" is required (not null)
            if (VendorId == null)
            {
                throw new InvalidDataException("VendorId is a required property for CouponItem and cannot be null");
            }
            else
            {
                this.VendorId = VendorId;
            }
            // to ensure "CouponTypeHint" is required (not null)
            if (CouponTypeHint == null)
            {
                throw new InvalidDataException("CouponTypeHint is a required property for CouponItem and cannot be null");
            }
            else
            {
                this.CouponTypeHint = CouponTypeHint;
            }
            // to ensure "DiscountType" is required (not null)
            if (DiscountType == null)
            {
                throw new InvalidDataException("DiscountType is a required property for CouponItem and cannot be null");
            }
            else
            {
                this.DiscountType = DiscountType;
            }
            // to ensure "DiscountValue" is required (not null)
            if (DiscountValue == null)
            {
                throw new InvalidDataException("DiscountValue is a required property for CouponItem and cannot be null");
            }
            else
            {
                this.DiscountValue = DiscountValue;
            }
            this.AdditionalProperties = AdditionalProperties;
            this.Behaviors = Behaviors;
            this.Category = Category;
            this.LongDescription = LongDescription;
            this.ShortDescription = ShortDescription;
            this.Sort = Sort;
            this.Tags = Tags;
            this.Template = Template;
            this.UniqueKey = UniqueKey;
            this.Displayable = Displayable;
            this.GeoCountryList = GeoCountryList;
            this.ShippingTier = ShippingTier;
            this.StoreEnd = StoreEnd;
            this.StoreStart = StoreStart;
            this.DiscountMax = DiscountMax;
            this.DiscountMinCartValue = DiscountMinCartValue;
            this.Exclusive = Exclusive;
            this.ItemId = ItemId;
            this.MaxQuantity = MaxQuantity;
            this.SelfExclusive = SelfExclusive;
            this.ValidForTags = ValidForTags;
        }
        
        /// <summary>
        /// A map of additional properties, keyed on the property name.  Must match the names and types defined in the template for this item type, or be an extra not from the template
        /// </summary>
        /// <value>A map of additional properties, keyed on the property name.  Must match the names and types defined in the template for this item type, or be an extra not from the template</value>
        [DataMember(Name="additional_properties", EmitDefaultValue=false)]
        public Dictionary<string, Property> AdditionalProperties { get; set; }

        /// <summary>
        /// The behaviors linked to the item, describing various options and interactions. May not be included in item lists
        /// </summary>
        /// <value>The behaviors linked to the item, describing various options and interactions. May not be included in item lists</value>
        [DataMember(Name="behaviors", EmitDefaultValue=false)]
        public List<Behavior> Behaviors { get; set; }

        /// <summary>
        /// A category for filtering items
        /// </summary>
        /// <value>A category for filtering items</value>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public string Category { get; set; }

        /// <summary>
        /// The date the item was created, unix timestamp in seconds
        /// </summary>
        /// <value>The date the item was created, unix timestamp in seconds</value>
        [DataMember(Name="created_date", EmitDefaultValue=false)]
        public long? CreatedDate { get; private set; }

        /// <summary>
        /// The id of the item
        /// </summary>
        /// <value>The id of the item</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }

        /// <summary>
        /// A long description of the item
        /// </summary>
        /// <value>A long description of the item</value>
        [DataMember(Name="long_description", EmitDefaultValue=false)]
        public string LongDescription { get; set; }

        /// <summary>
        /// The name of the item
        /// </summary>
        /// <value>The name of the item</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// A short description of the item, max 255 chars
        /// </summary>
        /// <value>A short description of the item, max 255 chars</value>
        [DataMember(Name="short_description", EmitDefaultValue=false)]
        public string ShortDescription { get; set; }

        /// <summary>
        /// A number to use in sorting items.  Default 500
        /// </summary>
        /// <value>A number to use in sorting items.  Default 500</value>
        [DataMember(Name="sort", EmitDefaultValue=false)]
        public int? Sort { get; set; }

        /// <summary>
        /// List of tags used for filtering items
        /// </summary>
        /// <value>List of tags used for filtering items</value>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// An item template this item is validated against.  May be null and no validation of additional_properties will be done.  Default &#x3D; null
        /// </summary>
        /// <value>An item template this item is validated against.  May be null and no validation of additional_properties will be done.  Default &#x3D; null</value>
        [DataMember(Name="template", EmitDefaultValue=false)]
        public string Template { get; set; }

        /// <summary>
        /// The type of the item
        /// </summary>
        /// <value>The type of the item</value>
        [DataMember(Name="type_hint", EmitDefaultValue=false)]
        public string TypeHint { get; set; }

        /// <summary>
        /// The unique key for the item
        /// </summary>
        /// <value>The unique key for the item</value>
        [DataMember(Name="unique_key", EmitDefaultValue=false)]
        public string UniqueKey { get; set; }

        /// <summary>
        /// The date the item was last updated, unix timestamp in seconds
        /// </summary>
        /// <value>The date the item was last updated, unix timestamp in seconds</value>
        [DataMember(Name="updated_date", EmitDefaultValue=false)]
        public long? UpdatedDate { get; private set; }

        /// <summary>
        /// Whether or not the item is currently displayable.  Default &#x3D; true
        /// </summary>
        /// <value>Whether or not the item is currently displayable.  Default &#x3D; true</value>
        [DataMember(Name="displayable", EmitDefaultValue=false)]
        public bool? Displayable { get; set; }

        /// <summary>
        /// A list of country ID to include in the blacklist/whitelist geo policy
        /// </summary>
        /// <value>A list of country ID to include in the blacklist/whitelist geo policy</value>
        [DataMember(Name="geo_country_list", EmitDefaultValue=false)]
        public List<string> GeoCountryList { get; set; }

        /// <summary>
        /// Provides the abstract shipping needs if this item is physical and can be shipped.  A value of zero means no shipping needed.  Default &#x3D; 0
        /// </summary>
        /// <value>Provides the abstract shipping needs if this item is physical and can be shipped.  A value of zero means no shipping needed.  Default &#x3D; 0</value>
        [DataMember(Name="shipping_tier", EmitDefaultValue=false)]
        public int? ShippingTier { get; set; }

        /// <summary>
        /// The skus for the item. Each defines a unique configuration for the item to be purchased (Large-Blue, Small-Green, etc). These are what is ultimately selected in the store and added to the cart
        /// </summary>
        /// <value>The skus for the item. Each defines a unique configuration for the item to be purchased (Large-Blue, Small-Green, etc). These are what is ultimately selected in the store and added to the cart</value>
        [DataMember(Name="skus", EmitDefaultValue=false)]
        public List<Sku> Skus { get; set; }

        /// <summary>
        /// The date the item will leave the store, unix timestamp in seconds.  If set to null, item will never leave the store
        /// </summary>
        /// <value>The date the item will leave the store, unix timestamp in seconds.  If set to null, item will never leave the store</value>
        [DataMember(Name="store_end", EmitDefaultValue=false)]
        public long? StoreEnd { get; set; }

        /// <summary>
        /// The date the item will appear in the store, unix timestamp in seconds.  If set to null, item will appear in store immediately
        /// </summary>
        /// <value>The date the item will appear in the store, unix timestamp in seconds.  If set to null, item will appear in store immediately</value>
        [DataMember(Name="store_start", EmitDefaultValue=false)]
        public long? StoreStart { get; set; }

        /// <summary>
        /// The vendor who provides the item
        /// </summary>
        /// <value>The vendor who provides the item</value>
        [DataMember(Name="vendor_id", EmitDefaultValue=false)]
        public int? VendorId { get; set; }


        /// <summary>
        /// The amount this coupon is maxed out at.  Applies if coupon_type_hint is coupon_cart
        /// </summary>
        /// <value>The amount this coupon is maxed out at.  Applies if coupon_type_hint is coupon_cart</value>
        [DataMember(Name="discount_max", EmitDefaultValue=false)]
        public double? DiscountMax { get; set; }

        /// <summary>
        /// The minimium amount needed in the cart for the coupon to apply.  Applies if coupon_type_hint is coupon_cart
        /// </summary>
        /// <value>The minimium amount needed in the cart for the coupon to apply.  Applies if coupon_type_hint is coupon_cart</value>
        [DataMember(Name="discount_min_cart_value", EmitDefaultValue=false)]
        public double? DiscountMinCartValue { get; set; }


        /// <summary>
        /// The amount the coupon will discount the item. If discount_type is &#39;value&#39; this will be a flat amount of currency. If discount type is &#39;percentage&#39; this will be a fraction (0.2 for 20% off) multiplied by the price of the matching item or items.
        /// </summary>
        /// <value>The amount the coupon will discount the item. If discount_type is &#39;value&#39; this will be a flat amount of currency. If discount type is &#39;percentage&#39; this will be a fraction (0.2 for 20% off) multiplied by the price of the matching item or items.</value>
        [DataMember(Name="discount_value", EmitDefaultValue=false)]
        public double? DiscountValue { get; set; }

        /// <summary>
        /// Whether this coupon is exclusive or not (true means cannot be in same cart as another).  Default &#x3D; false
        /// </summary>
        /// <value>Whether this coupon is exclusive or not (true means cannot be in same cart as another).  Default &#x3D; false</value>
        [DataMember(Name="exclusive", EmitDefaultValue=false)]
        public bool? Exclusive { get; set; }

        /// <summary>
        /// The id of the item the coupon is applied to.  Applies if coupon_type_hint is coupon_single_item or coupon_voucher
        /// </summary>
        /// <value>The id of the item the coupon is applied to.  Applies if coupon_type_hint is coupon_single_item or coupon_voucher</value>
        [DataMember(Name="item_id", EmitDefaultValue=false)]
        public int? ItemId { get; set; }

        /// <summary>
        /// The maximum quantity of items the coupon can apply to, null if no limit and minimum 1 otherwise.  Applies if coupon_type_hint is coupon_single_item or coupon_voucher
        /// </summary>
        /// <value>The maximum quantity of items the coupon can apply to, null if no limit and minimum 1 otherwise.  Applies if coupon_type_hint is coupon_single_item or coupon_voucher</value>
        [DataMember(Name="max_quantity", EmitDefaultValue=false)]
        public int? MaxQuantity { get; set; }

        /// <summary>
        /// Whether this coupon is exclusive to itself or not (true means cannot add two of this same coupon to the same cart).  Default &#x3D; false
        /// </summary>
        /// <value>Whether this coupon is exclusive to itself or not (true means cannot add two of this same coupon to the same cart).  Default &#x3D; false</value>
        [DataMember(Name="self_exclusive", EmitDefaultValue=false)]
        public bool? SelfExclusive { get; set; }

        /// <summary>
        /// A list of tags for a coupon.  The coupon can only apply to an item that has at least one of these tags.  Applies if coupon_type_hint is coupon_tag
        /// </summary>
        /// <value>A list of tags for a coupon.  The coupon can only apply to an item that has at least one of these tags.  Applies if coupon_type_hint is coupon_tag</value>
        [DataMember(Name="valid_for_tags", EmitDefaultValue=false)]
        public List<string> ValidForTags { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CouponItem {\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("  Behaviors: ").Append(Behaviors).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LongDescription: ").Append(LongDescription).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ShortDescription: ").Append(ShortDescription).Append("\n");
            sb.Append("  Sort: ").Append(Sort).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Template: ").Append(Template).Append("\n");
            sb.Append("  TypeHint: ").Append(TypeHint).Append("\n");
            sb.Append("  UniqueKey: ").Append(UniqueKey).Append("\n");
            sb.Append("  UpdatedDate: ").Append(UpdatedDate).Append("\n");
            sb.Append("  Displayable: ").Append(Displayable).Append("\n");
            sb.Append("  GeoCountryList: ").Append(GeoCountryList).Append("\n");
            sb.Append("  ShippingTier: ").Append(ShippingTier).Append("\n");
            sb.Append("  Skus: ").Append(Skus).Append("\n");
            sb.Append("  StoreEnd: ").Append(StoreEnd).Append("\n");
            sb.Append("  StoreStart: ").Append(StoreStart).Append("\n");
            sb.Append("  VendorId: ").Append(VendorId).Append("\n");
            sb.Append("  CouponTypeHint: ").Append(CouponTypeHint).Append("\n");
            sb.Append("  DiscountMax: ").Append(DiscountMax).Append("\n");
            sb.Append("  DiscountMinCartValue: ").Append(DiscountMinCartValue).Append("\n");
            sb.Append("  DiscountType: ").Append(DiscountType).Append("\n");
            sb.Append("  DiscountValue: ").Append(DiscountValue).Append("\n");
            sb.Append("  Exclusive: ").Append(Exclusive).Append("\n");
            sb.Append("  ItemId: ").Append(ItemId).Append("\n");
            sb.Append("  MaxQuantity: ").Append(MaxQuantity).Append("\n");
            sb.Append("  SelfExclusive: ").Append(SelfExclusive).Append("\n");
            sb.Append("  ValidForTags: ").Append(ValidForTags).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public  new string ToJson()
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
            return this.Equals(input as CouponItem);
        }

        /// <summary>
        /// Returns true if CouponItem instances are equal
        /// </summary>
        /// <param name="input">Instance of CouponItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CouponItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AdditionalProperties == input.AdditionalProperties ||
                    (this.AdditionalProperties != null &&
                    this.AdditionalProperties.SequenceEqual(input.AdditionalProperties))
                ) && 
                (
                    this.Behaviors == input.Behaviors ||
                    (this.Behaviors != null &&
                    this.Behaviors.SequenceEqual(input.Behaviors))
                ) && 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
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
                    this.LongDescription == input.LongDescription ||
                    (this.LongDescription != null &&
                    this.LongDescription.Equals(input.LongDescription))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ShortDescription == input.ShortDescription ||
                    (this.ShortDescription != null &&
                    this.ShortDescription.Equals(input.ShortDescription))
                ) && 
                (
                    this.Sort == input.Sort ||
                    (this.Sort != null &&
                    this.Sort.Equals(input.Sort))
                ) && 
                (
                    this.Tags == input.Tags ||
                    (this.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags))
                ) && 
                (
                    this.Template == input.Template ||
                    (this.Template != null &&
                    this.Template.Equals(input.Template))
                ) && 
                (
                    this.TypeHint == input.TypeHint ||
                    (this.TypeHint != null &&
                    this.TypeHint.Equals(input.TypeHint))
                ) && 
                (
                    this.UniqueKey == input.UniqueKey ||
                    (this.UniqueKey != null &&
                    this.UniqueKey.Equals(input.UniqueKey))
                ) && 
                (
                    this.UpdatedDate == input.UpdatedDate ||
                    (this.UpdatedDate != null &&
                    this.UpdatedDate.Equals(input.UpdatedDate))
                ) && 
                (
                    this.Displayable == input.Displayable ||
                    (this.Displayable != null &&
                    this.Displayable.Equals(input.Displayable))
                ) && 
                (
                    this.GeoCountryList == input.GeoCountryList ||
                    (this.GeoCountryList != null &&
                    this.GeoCountryList.SequenceEqual(input.GeoCountryList))
                ) && 
                (
                    this.ShippingTier == input.ShippingTier ||
                    (this.ShippingTier != null &&
                    this.ShippingTier.Equals(input.ShippingTier))
                ) && 
                (
                    this.Skus == input.Skus ||
                    (this.Skus != null &&
                    this.Skus.SequenceEqual(input.Skus))
                ) && 
                (
                    this.StoreEnd == input.StoreEnd ||
                    (this.StoreEnd != null &&
                    this.StoreEnd.Equals(input.StoreEnd))
                ) && 
                (
                    this.StoreStart == input.StoreStart ||
                    (this.StoreStart != null &&
                    this.StoreStart.Equals(input.StoreStart))
                ) && 
                (
                    this.VendorId == input.VendorId ||
                    (this.VendorId != null &&
                    this.VendorId.Equals(input.VendorId))
                ) && 
                (
                    this.CouponTypeHint == input.CouponTypeHint ||
                    (this.CouponTypeHint != null &&
                    this.CouponTypeHint.Equals(input.CouponTypeHint))
                ) && 
                (
                    this.DiscountMax == input.DiscountMax ||
                    (this.DiscountMax != null &&
                    this.DiscountMax.Equals(input.DiscountMax))
                ) && 
                (
                    this.DiscountMinCartValue == input.DiscountMinCartValue ||
                    (this.DiscountMinCartValue != null &&
                    this.DiscountMinCartValue.Equals(input.DiscountMinCartValue))
                ) && 
                (
                    this.DiscountType == input.DiscountType ||
                    (this.DiscountType != null &&
                    this.DiscountType.Equals(input.DiscountType))
                ) && 
                (
                    this.DiscountValue == input.DiscountValue ||
                    (this.DiscountValue != null &&
                    this.DiscountValue.Equals(input.DiscountValue))
                ) && 
                (
                    this.Exclusive == input.Exclusive ||
                    (this.Exclusive != null &&
                    this.Exclusive.Equals(input.Exclusive))
                ) && 
                (
                    this.ItemId == input.ItemId ||
                    (this.ItemId != null &&
                    this.ItemId.Equals(input.ItemId))
                ) && 
                (
                    this.MaxQuantity == input.MaxQuantity ||
                    (this.MaxQuantity != null &&
                    this.MaxQuantity.Equals(input.MaxQuantity))
                ) && 
                (
                    this.SelfExclusive == input.SelfExclusive ||
                    (this.SelfExclusive != null &&
                    this.SelfExclusive.Equals(input.SelfExclusive))
                ) && 
                (
                    this.ValidForTags == input.ValidForTags ||
                    (this.ValidForTags != null &&
                    this.ValidForTags.SequenceEqual(input.ValidForTags))
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
                if (this.AdditionalProperties != null)
                    hashCode = hashCode * 59 + this.AdditionalProperties.GetHashCode();
                if (this.Behaviors != null)
                    hashCode = hashCode * 59 + this.Behaviors.GetHashCode();
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.CreatedDate != null)
                    hashCode = hashCode * 59 + this.CreatedDate.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.LongDescription != null)
                    hashCode = hashCode * 59 + this.LongDescription.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ShortDescription != null)
                    hashCode = hashCode * 59 + this.ShortDescription.GetHashCode();
                if (this.Sort != null)
                    hashCode = hashCode * 59 + this.Sort.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.Template != null)
                    hashCode = hashCode * 59 + this.Template.GetHashCode();
                if (this.TypeHint != null)
                    hashCode = hashCode * 59 + this.TypeHint.GetHashCode();
                if (this.UniqueKey != null)
                    hashCode = hashCode * 59 + this.UniqueKey.GetHashCode();
                if (this.UpdatedDate != null)
                    hashCode = hashCode * 59 + this.UpdatedDate.GetHashCode();
                if (this.Displayable != null)
                    hashCode = hashCode * 59 + this.Displayable.GetHashCode();
                if (this.GeoCountryList != null)
                    hashCode = hashCode * 59 + this.GeoCountryList.GetHashCode();
                if (this.ShippingTier != null)
                    hashCode = hashCode * 59 + this.ShippingTier.GetHashCode();
                if (this.Skus != null)
                    hashCode = hashCode * 59 + this.Skus.GetHashCode();
                if (this.StoreEnd != null)
                    hashCode = hashCode * 59 + this.StoreEnd.GetHashCode();
                if (this.StoreStart != null)
                    hashCode = hashCode * 59 + this.StoreStart.GetHashCode();
                if (this.VendorId != null)
                    hashCode = hashCode * 59 + this.VendorId.GetHashCode();
                if (this.CouponTypeHint != null)
                    hashCode = hashCode * 59 + this.CouponTypeHint.GetHashCode();
                if (this.DiscountMax != null)
                    hashCode = hashCode * 59 + this.DiscountMax.GetHashCode();
                if (this.DiscountMinCartValue != null)
                    hashCode = hashCode * 59 + this.DiscountMinCartValue.GetHashCode();
                if (this.DiscountType != null)
                    hashCode = hashCode * 59 + this.DiscountType.GetHashCode();
                if (this.DiscountValue != null)
                    hashCode = hashCode * 59 + this.DiscountValue.GetHashCode();
                if (this.Exclusive != null)
                    hashCode = hashCode * 59 + this.Exclusive.GetHashCode();
                if (this.ItemId != null)
                    hashCode = hashCode * 59 + this.ItemId.GetHashCode();
                if (this.MaxQuantity != null)
                    hashCode = hashCode * 59 + this.MaxQuantity.GetHashCode();
                if (this.SelfExclusive != null)
                    hashCode = hashCode * 59 + this.SelfExclusive.GetHashCode();
                if (this.ValidForTags != null)
                    hashCode = hashCode * 59 + this.ValidForTags.GetHashCode();
                return hashCode;
            }
        }

    }

}
