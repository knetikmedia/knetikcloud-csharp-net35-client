# com.knetikcloud.Model.CouponDefinition
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | A unique identifier for the discount. Can be used to remove the discount, and uniqueness within the cart will be enforced. | 
**Description** | **string** | A description for the discount. | [optional] 
**DiscountType** | **string** | The type of discount in terms of how it deducts price. | 
**Exclusive** | **bool?** | Whether this discount is exclusive and cannot be used in conjunction with other discounts/coupons. default&#x3D;false | [optional] 
**MaxDiscount** | **decimal?** | For coupon_cart, a minimum total price that the cart must meet to be valid. | [optional] 
**MaxQuantity** | **int?** | The maximum number of items to count this discount for (not for cart_coupon). | [optional] 
**MinCartTotal** | **decimal?** | For coupon_cart, a minimum total price that the cart must meet to be valid. | [optional] 
**Name** | **string** | A name for the discount. | 
**SelfExclusive** | **bool?** | Whether this coupon is exclusive to itself or not (true means cannot add two of this same coupon to the same cart).  Default &#x3D; false | [optional] 
**TargetItemId** | **int?** | The id of the item this discount applies to, which must be present in the cart. Applies if coupon_type_hint is coupon_single_item or coupon_voucher. | [optional] 
**Type** | **string** | The type of discount in terms of what it applies to. coupon_cart applies to the cart as a whole, other types apply to specific items based on different criteria. | 
**UniqueKey** | **string** | A unique identifier string for the discount. | 
**ValidForTags** | **List&lt;string&gt;** | Which tags this applies for (item must have at least one of them), if coupon_type is coupon_tag. | [optional] 
**Value** | **decimal?** | The amount of the discount. If discount_type is value then this is the raw currency amount to remove. If discount_type is percentage then this will be multiplied by the cart total or item price to get the discount amount (0.5 is half price). | 
**VendorId** | **int?** | Which vendor this applies for, if coupon_type is coupon_vendor. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

