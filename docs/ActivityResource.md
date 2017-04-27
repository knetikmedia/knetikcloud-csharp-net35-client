# com.knetikcloud.Model.ActivityResource
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdditionalProperties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | A map of additional properties, keyed on the property name.  Must match the names and types defined in the template for this item type | [optional] 
**CreatedDate** | **long?** | The date/time this resource was created in seconds since unix epoch | [optional] 
**Entitlements** | [**List&lt;ActivityEntitlementResource&gt;**](ActivityEntitlementResource.md) | The list of items that can be used for entitlement (wager amounts/etc) | [optional] 
**Id** | **long?** | The unique ID for that resource | [optional] 
**Launch** | **string** | Details about how to launch the activity | [optional] 
**LongDescription** | **string** | The user friendly name of that resource. Defaults to blank string | [optional] 
**Name** | **string** | The user friendly name of that resource | 
**RewardSet** | [**RewardSetResource**](RewardSetResource.md) | The rewards to give at the end of each occurence of the activity. When creating/updating only id is used. Reward set must be pre-existing | [optional] 
**Settings** | [**List&lt;AvailableSettingResource&gt;**](AvailableSettingResource.md) | The list of settings and their options available for this activity. Not populated when getting listing | [optional] 
**ShortDescription** | **string** | The user friendly name of that resource. Defaults to blank string | [optional] 
**Template** | **bool?** | Whether this activity is a template for other activities. Default: false | [optional] 
**TemplateId** | **string** | An activity template this activity is validated against (private). May be null and no validation of additional_properties will be done | [optional] 
**Type** | **string** | The type of the activity | 
**UniqueKey** | **string** | The unique key (for static reference in code) of the activity | [optional] 
**UpdatedDate** | **long?** | The date/time this resource was last updated in seconds since unix epoch | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

