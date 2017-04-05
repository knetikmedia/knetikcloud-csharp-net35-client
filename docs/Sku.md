# com.knetikcloud.Model.Sku
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdditionalProperties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | A map of additional properties, keyed on the property name.  Must match the names and types defined in the template for this item type, or be an extra not from the template | [optional] 
**CurrencyCode** | **string** | The currency code for the SKU, a three letter string (ISO3) | 
**Description** | **string** | The description of the SKU (Ex: An item comes in multiple sizes/colors, each needing its own unique description) | [optional] 
**Inventory** | **int?** | The number of SKUs currently in stock | [optional] 
**MinInventoryThreshold** | **int?** | Alerts vendor when SKU inventory drops below this value | [optional] 
**OriginalPrice** | **double?** | The base price before any sale | 
**Price** | **double?** | The current price of the SKU with sales, if any. Set original_price for the base | [optional] 
**Published** | **bool?** | Whether or not the SKU is currently published | [optional] 
**SaleId** | **int?** | The id of a sale affecting the price, if any | [optional] 
**SaleName** | **string** | The name of a sale affecting the price, if any | [optional] 
**_Sku** | **string** | The stock keeping unit (SKU), a unique identifier for a given product.  Max 40 characters | 
**StartDate** | **long?** | The date the sku becomes available, unix timestamp in seconds.  If set to null, sku will become available immediately | [optional] 
**StopDate** | **long?** | The date the sku becomes unavailable, unix timestamp in seconds.  If set to null, sku is always available | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

