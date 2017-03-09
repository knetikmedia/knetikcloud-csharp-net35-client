# com.knetikcloud.Model.ActivityOccurrenceResource
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ActivityId** | **long?** | The id of the activity | 
**ChallengeActivityId** | **long?** | The id of the challenge activity (as part of the event, required if eventId set) | [optional] 
**CreatedDate** | **long?** | The date this occurrence was created, unix timestamp in seconds | [optional] 
**Entitlement** | [**ActivityEntitlementResource**](ActivityEntitlementResource.md) | The entitlement item required to enter the occurrence. Required if not part of an event. Must come from the set of entitlement items listed in the activity | [optional] 
**EventId** | **long?** | The id of the event | [optional] 
**Id** | **long?** | The id of the activity occurrence | [optional] 
**RewardStatus** | **string** | Indicate if the rewards have been given out already | [optional] 
**Settings** | [**List&lt;SelectedSettingResource&gt;**](SelectedSettingResource.md) | The list of settings and their options available for this activity. Should be null on create if and only if part of an event | [optional] 
**Simulated** | **bool?** | Whether this occurrence will be played as a simulation. | [optional] 
**StartDate** | **long?** | The date this occurrence was started, unix timestamp in seconds. null if not yet started | [optional] 
**Status** | **string** | The current status of the occurrence (default: OPEN) | [optional] 
**UpdatedDate** | **long?** | The date this occurrence was last updated, unix timestamp in seconds | [optional] 
**Users** | [**List&lt;ActivityUserResource&gt;**](ActivityUserResource.md) | The list of users playing in this occurrence. Can only be set directly with ACTIVITIES_ADMIN permission | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

