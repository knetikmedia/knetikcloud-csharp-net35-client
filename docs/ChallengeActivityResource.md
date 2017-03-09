# IO.Swagger.Model.ChallengeActivityResource
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ActivityId** | **long?** | The id of the activity | 
**ChallengeId** | **long?** | The id of the challenge | [optional] 
**Entitlement** | [**ActivityEntitlementResource**](ActivityEntitlementResource.md) | The entitlement item needed to participate in the activity as part of this event. Null indicates free entry. When creating/updating only id is used. Item must be pre-existing | [optional] 
**Id** | **long?** | The unique ID for this resource | [optional] 
**RewardSet** | [**RewardSetResource**](RewardSetResource.md) | The rewards to give at the end of each occurence of the activity. When creating/updating only id is used. Reward set must be pre-existing | [optional] 
**Settings** | [**List&lt;SelectedSettingResource&gt;**](SelectedSettingResource.md) | The list of settings and the select options | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
