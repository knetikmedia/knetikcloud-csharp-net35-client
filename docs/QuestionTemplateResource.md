# IO.Swagger.Model.QuestionTemplateResource
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AnswerProperty** | [**PropertyDefinitionResource**](PropertyDefinitionResource.md) | A property definition for all answers. If included each answer must match this definition&#39;s type and be valid | [optional] 
**CreatedDate** | **long?** | The date/time this resource was created in seconds since unix epoch | [optional] 
**Id** | **string** | The id of the template | [optional] 
**Name** | **string** | The name of the template | 
**Properties** | [**List&lt;PropertyDefinitionResource&gt;**](PropertyDefinitionResource.md) | The customized properties that are present | [optional] 
**QuestionProperty** | [**PropertyDefinitionResource**](PropertyDefinitionResource.md) | A property definition for the question itself. If included the answer must match this definition&#39;s type and be valid | [optional] 
**UpdatedDate** | **long?** | The date/time this resource was last updated in seconds since unix epoch | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
