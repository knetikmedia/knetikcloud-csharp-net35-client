# IO.Swagger.Model.InventorySubscriptionResource
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BillDate** | **long?** | The date the subscription will be billed | [optional] 
**Credit** | **double?** | A credit of money already applied to a subscription for the next bill, or a debt if negative | [optional] 
**CreditLog** | [**List&lt;SubscriptionCreditResource&gt;**](SubscriptionCreditResource.md) | A record of past and present credit/debt changes | [optional] 
**GraceEnd** | **long?** | The date the grace period ends | [optional] 
**InventoryId** | **int?** | The id of the inventory | [optional] 
**InventoryStatus** | **string** | The inventory status object | [optional] 
**ItemId** | **int?** | The id of the item | [optional] 
**PaymentMethod** | [**PaymentMethodResource**](PaymentMethodResource.md) | The payment method object | [optional] 
**RecurringPrice** | **double?** | The recurring price | [optional] 
**Sku** | **string** | The sku of the subscription | [optional] 
**StartDate** | **long?** | The date the subscription will start | [optional] 
**SubscriptionStatus** | **int?** | The status of the subscription | [optional] 
**User** | [**SimpleUserResource**](SimpleUserResource.md) | The user | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

