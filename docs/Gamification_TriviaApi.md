# com.knetikcloud.Api.Gamification_TriviaApi

All URIs are relative to *https://jsapi-integration.us-east-1.elasticbeanstalk.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddQuestionAnswers**](Gamification_TriviaApi.md#addquestionanswers) | **POST** /trivia/questions/{question_id}/answers | Add an answer to a question
[**AddQuestionTag**](Gamification_TriviaApi.md#addquestiontag) | **POST** /trivia/questions/{id}/tags | Add a tag to a question
[**AddTagToQuestionsBatch**](Gamification_TriviaApi.md#addtagtoquestionsbatch) | **POST** /trivia/questions/tags | Add a tag to a batch of questions
[**CreateImportJob**](Gamification_TriviaApi.md#createimportjob) | **POST** /trivia/import | Create an import job
[**CreateQuestion**](Gamification_TriviaApi.md#createquestion) | **POST** /trivia/questions | Create a question
[**CreateQuestionTemplate**](Gamification_TriviaApi.md#createquestiontemplate) | **POST** /trivia/questions/templates | Create a question template
[**DeleteImportJob**](Gamification_TriviaApi.md#deleteimportjob) | **DELETE** /trivia/import/{id} | Delete an import job
[**DeleteQuestion**](Gamification_TriviaApi.md#deletequestion) | **DELETE** /trivia/questions/{id} | Delete a question
[**DeleteQuestionAnswers**](Gamification_TriviaApi.md#deletequestionanswers) | **DELETE** /trivia/questions/{question_id}/answers/{id} | Remove an answer from a question
[**DeleteQuestionTemplate**](Gamification_TriviaApi.md#deletequestiontemplate) | **DELETE** /trivia/questions/templates/{id} | Delete a question template
[**GetImportJob**](Gamification_TriviaApi.md#getimportjob) | **GET** /trivia/import/{id} | Get an import job
[**GetImportJobs**](Gamification_TriviaApi.md#getimportjobs) | **GET** /trivia/import | Get a list of import job
[**GetQuestion**](Gamification_TriviaApi.md#getquestion) | **GET** /trivia/questions/{id} | Get a single question
[**GetQuestionAnswer**](Gamification_TriviaApi.md#getquestionanswer) | **GET** /trivia/questions/{question_id}/answers/{id} | Get an answer for a question
[**GetQuestionAnswers**](Gamification_TriviaApi.md#getquestionanswers) | **GET** /trivia/questions/{question_id}/answers | List the answers available for a question
[**GetQuestionDeltas**](Gamification_TriviaApi.md#getquestiondeltas) | **GET** /trivia/questions/delta | List question deltas in ascending order of updated date
[**GetQuestionTags**](Gamification_TriviaApi.md#getquestiontags) | **GET** /trivia/questions/{id}/tags | List the tags for a question
[**GetQuestionTemplate**](Gamification_TriviaApi.md#getquestiontemplate) | **GET** /trivia/questions/templates/{id} | Get a single question template
[**GetQuestionTemplates**](Gamification_TriviaApi.md#getquestiontemplates) | **GET** /trivia/questions/templates | List and search question templates
[**GetQuestions**](Gamification_TriviaApi.md#getquestions) | **GET** /trivia/questions | List and search questions
[**GetQuestionsCount**](Gamification_TriviaApi.md#getquestionscount) | **GET** /trivia/questions/count | Count questions based on filters
[**ProcessImportJob**](Gamification_TriviaApi.md#processimportjob) | **POST** /trivia/import/{id}/process | Start processing an import job
[**RemoveQuestionTag**](Gamification_TriviaApi.md#removequestiontag) | **DELETE** /trivia/questions/{id}/tags/{tag} | Remove a tag from a question
[**RemoveTagToQuestionsBatch**](Gamification_TriviaApi.md#removetagtoquestionsbatch) | **DELETE** /trivia/questions/tags/{tag} | Remove a tag from a batch of questions
[**SearchQuestionTags**](Gamification_TriviaApi.md#searchquestiontags) | **GET** /trivia/tags | List and search tags by the beginning of the string
[**UpdateImportJob**](Gamification_TriviaApi.md#updateimportjob) | **PUT** /trivia/import/{id} | Update an import job
[**UpdateQuestion**](Gamification_TriviaApi.md#updatequestion) | **PUT** /trivia/questions/{id} | Update a question
[**UpdateQuestionAnswer**](Gamification_TriviaApi.md#updatequestionanswer) | **PUT** /trivia/questions/{question_id}/answers/{id} | Update an answer for a question
[**UpdateQuestionTemplate**](Gamification_TriviaApi.md#updatequestiontemplate) | **PUT** /trivia/questions/templates/{id} | Update a question template
[**UpdateQuestionsInBulk**](Gamification_TriviaApi.md#updatequestionsinbulk) | **PUT** /trivia/questions | Bulk update questions


<a name="addquestionanswers"></a>
# **AddQuestionAnswers**
> AnswerResource AddQuestionAnswers (string questionId, AnswerResource answer = null)

Add an answer to a question

<b>Permissions Needed:</b> TRIVIA_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class AddQuestionAnswersExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Gamification_TriviaApi();
            var questionId = questionId_example;  // string | The id of the question
            var answer = new AnswerResource(); // AnswerResource | The new answer (optional) 

            try
            {
                // Add an answer to a question
                AnswerResource result = apiInstance.AddQuestionAnswers(questionId, answer);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Gamification_TriviaApi.AddQuestionAnswers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **questionId** | **string**| The id of the question | 
 **answer** | [**AnswerResource**](AnswerResource.md)| The new answer | [optional] 

### Return type

[**AnswerResource**](AnswerResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addquestiontag"></a>
# **AddQuestionTag**
> void AddQuestionTag (string id, StringWrapper tag = null)

Add a tag to a question

<b>Permissions Needed:</b> TRIVIA_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class AddQuestionTagExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Gamification_TriviaApi();
            var id = id_example;  // string | The id of the question
            var tag = new StringWrapper(); // StringWrapper | The new tag (optional) 

            try
            {
                // Add a tag to a question
                apiInstance.AddQuestionTag(id, tag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Gamification_TriviaApi.AddQuestionTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the question | 
 **tag** | [**StringWrapper**](StringWrapper.md)| The new tag | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addtagtoquestionsbatch"></a>
# **AddTagToQuestionsBatch**
> int? AddTagToQuestionsBatch (StringWrapper tag = null, string filterSearch = null, string filterIdset = null, string filterCategory = null, string filterTag = null, string filterTagset = null, string filterType = null, bool? filterPublished = null, long? filterImportId = null)

Add a tag to a batch of questions

All questions that dont't have the tag and match filters will have it added. The returned number is the number of questions updated. <br><br><b>Permissions Needed:</b> TRIVIA_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class AddTagToQuestionsBatchExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Gamification_TriviaApi();
            var tag = new StringWrapper(); // StringWrapper | The tag to add (optional) 
            var filterSearch = filterSearch_example;  // string | Filter for documents whose question, answers or tags contains provided string (optional) 
            var filterIdset = filterIdset_example;  // string | Filter for documents whose id is in the comma separated list provided (optional) 
            var filterCategory = filterCategory_example;  // string | Filter for questions with specified category, by id (optional) 
            var filterTag = filterTag_example;  // string | Filter for questions with specified tag (optional) 
            var filterTagset = filterTagset_example;  // string | Filter for questions with specified tags (separated by comma) (optional) 
            var filterType = filterType_example;  // string | Filter for questions with specified type (optional) 
            var filterPublished = true;  // bool? | Filter for questions currenctly published or not (optional) 
            var filterImportId = 789;  // long? | Filter for questions from a specific import job (optional) 

            try
            {
                // Add a tag to a batch of questions
                int? result = apiInstance.AddTagToQuestionsBatch(tag, filterSearch, filterIdset, filterCategory, filterTag, filterTagset, filterType, filterPublished, filterImportId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Gamification_TriviaApi.AddTagToQuestionsBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tag** | [**StringWrapper**](StringWrapper.md)| The tag to add | [optional] 
 **filterSearch** | **string**| Filter for documents whose question, answers or tags contains provided string | [optional] 
 **filterIdset** | **string**| Filter for documents whose id is in the comma separated list provided | [optional] 
 **filterCategory** | **string**| Filter for questions with specified category, by id | [optional] 
 **filterTag** | **string**| Filter for questions with specified tag | [optional] 
 **filterTagset** | **string**| Filter for questions with specified tags (separated by comma) | [optional] 
 **filterType** | **string**| Filter for questions with specified type | [optional] 
 **filterPublished** | **bool?**| Filter for questions currenctly published or not | [optional] 
 **filterImportId** | **long?**| Filter for questions from a specific import job | [optional] 

### Return type

**int?**

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createimportjob"></a>
# **CreateImportJob**
> ImportJobResource CreateImportJob (ImportJobResource request = null)

Create an import job

Set up a job to import a set of trivia questions from a cvs file at a remote url. the file will be validated asynchronously but will not be processed until started manually with the process endpoint. <br><br><b>Permissions Needed:</b> TRIVIA_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class CreateImportJobExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Gamification_TriviaApi();
            var request = new ImportJobResource(); // ImportJobResource | The new import job (optional) 

            try
            {
                // Create an import job
                ImportJobResource result = apiInstance.CreateImportJob(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Gamification_TriviaApi.CreateImportJob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**ImportJobResource**](ImportJobResource.md)| The new import job | [optional] 

### Return type

[**ImportJobResource**](ImportJobResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createquestion"></a>
# **CreateQuestion**
> QuestionResource CreateQuestion (QuestionResource question = null)

Create a question

<b>Permissions Needed:</b> TRIVIA_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class CreateQuestionExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Gamification_TriviaApi();
            var question = new QuestionResource(); // QuestionResource | The new question (optional) 

            try
            {
                // Create a question
                QuestionResource result = apiInstance.CreateQuestion(question);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Gamification_TriviaApi.CreateQuestion: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **question** | [**QuestionResource**](QuestionResource.md)| The new question | [optional] 

### Return type

[**QuestionResource**](QuestionResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createquestiontemplate"></a>
# **CreateQuestionTemplate**
> QuestionTemplateResource CreateQuestionTemplate (QuestionTemplateResource questionTemplateResource = null)

Create a question template

Question templates define a type of question and the properties they have. <br><br><b>Permissions Needed:</b> TRIVIA_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class CreateQuestionTemplateExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Gamification_TriviaApi();
            var questionTemplateResource = new QuestionTemplateResource(); // QuestionTemplateResource | The question template resource object (optional) 

            try
            {
                // Create a question template
                QuestionTemplateResource result = apiInstance.CreateQuestionTemplate(questionTemplateResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Gamification_TriviaApi.CreateQuestionTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **questionTemplateResource** | [**QuestionTemplateResource**](QuestionTemplateResource.md)| The question template resource object | [optional] 

### Return type

[**QuestionTemplateResource**](QuestionTemplateResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteimportjob"></a>
# **DeleteImportJob**
> void DeleteImportJob (long? id)

Delete an import job

Also deletes all questions that were imported by it. <br><br><b>Permissions Needed:</b> TRIVIA_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class DeleteImportJobExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Gamification_TriviaApi();
            var id = 789;  // long? | The id of the job

            try
            {
                // Delete an import job
                apiInstance.DeleteImportJob(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Gamification_TriviaApi.DeleteImportJob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The id of the job | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletequestion"></a>
# **DeleteQuestion**
> void DeleteQuestion (string id)

Delete a question

<b>Permissions Needed:</b> TRIVIA_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class DeleteQuestionExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Gamification_TriviaApi();
            var id = id_example;  // string | The id of the question

            try
            {
                // Delete a question
                apiInstance.DeleteQuestion(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Gamification_TriviaApi.DeleteQuestion: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the question | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletequestionanswers"></a>
# **DeleteQuestionAnswers**
> void DeleteQuestionAnswers (string questionId, string id)

Remove an answer from a question

<b>Permissions Needed:</b> TRIVIA_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class DeleteQuestionAnswersExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Gamification_TriviaApi();
            var questionId = questionId_example;  // string | The id of the question
            var id = id_example;  // string | The id of the answer

            try
            {
                // Remove an answer from a question
                apiInstance.DeleteQuestionAnswers(questionId, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Gamification_TriviaApi.DeleteQuestionAnswers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **questionId** | **string**| The id of the question | 
 **id** | **string**| The id of the answer | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletequestiontemplate"></a>
# **DeleteQuestionTemplate**
> void DeleteQuestionTemplate (string id, string cascade = null)

Delete a question template

If cascade = 'detach', it will force delete the template even if it's attached to other objects. <br><br><b>Permissions Needed:</b> TEMPLATE_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class DeleteQuestionTemplateExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Gamification_TriviaApi();
            var id = id_example;  // string | The id of the template
            var cascade = cascade_example;  // string | The value needed to delete used templates (optional) 

            try
            {
                // Delete a question template
                apiInstance.DeleteQuestionTemplate(id, cascade);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Gamification_TriviaApi.DeleteQuestionTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the template | 
 **cascade** | **string**| The value needed to delete used templates | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getimportjob"></a>
# **GetImportJob**
> ImportJobResource GetImportJob (long? id)

Get an import job

<b>Permissions Needed:</b> TRIVIA_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetImportJobExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Gamification_TriviaApi();
            var id = 789;  // long? | The id of the job

            try
            {
                // Get an import job
                ImportJobResource result = apiInstance.GetImportJob(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Gamification_TriviaApi.GetImportJob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The id of the job | 

### Return type

[**ImportJobResource**](ImportJobResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getimportjobs"></a>
# **GetImportJobs**
> PageResourceImportJobResource GetImportJobs (string filterVendor = null, string filterCategory = null, string filterName = null, string filterStatus = null, int? size = null, int? page = null, string order = null)

Get a list of import job

<b>Permissions Needed:</b> TRIVIA_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetImportJobsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Gamification_TriviaApi();
            var filterVendor = filterVendor_example;  // string | Filter for jobs by vendor id (optional) 
            var filterCategory = filterCategory_example;  // string | Filter for jobs by category id (optional) 
            var filterName = filterName_example;  // string | Filter for jobs which name *STARTS* with the given string (optional) 
            var filterStatus = filterStatus_example;  // string | Filter for jobs that are in a specific set of statuses (comma separated) (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // Get a list of import job
                PageResourceImportJobResource result = apiInstance.GetImportJobs(filterVendor, filterCategory, filterName, filterStatus, size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Gamification_TriviaApi.GetImportJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterVendor** | **string**| Filter for jobs by vendor id | [optional] 
 **filterCategory** | **string**| Filter for jobs by category id | [optional] 
 **filterName** | **string**| Filter for jobs which name *STARTS* with the given string | [optional] 
 **filterStatus** | **string**| Filter for jobs that are in a specific set of statuses (comma separated) | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to id:ASC]

### Return type

[**PageResourceImportJobResource**](PageResourceImportJobResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getquestion"></a>
# **GetQuestion**
> QuestionResource GetQuestion (string id)

Get a single question

<b>Permissions Needed:</b> TRIVIA_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetQuestionExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Gamification_TriviaApi();
            var id = id_example;  // string | The id of the question

            try
            {
                // Get a single question
                QuestionResource result = apiInstance.GetQuestion(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Gamification_TriviaApi.GetQuestion: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the question | 

### Return type

[**QuestionResource**](QuestionResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getquestionanswer"></a>
# **GetQuestionAnswer**
> AnswerResource GetQuestionAnswer (string questionId, string id)

Get an answer for a question

<b>Permissions Needed:</b> TRIVIA_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetQuestionAnswerExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Gamification_TriviaApi();
            var questionId = questionId_example;  // string | The id of the question
            var id = id_example;  // string | The id of the answer

            try
            {
                // Get an answer for a question
                AnswerResource result = apiInstance.GetQuestionAnswer(questionId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Gamification_TriviaApi.GetQuestionAnswer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **questionId** | **string**| The id of the question | 
 **id** | **string**| The id of the answer | 

### Return type

[**AnswerResource**](AnswerResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getquestionanswers"></a>
# **GetQuestionAnswers**
> List<AnswerResource> GetQuestionAnswers (string questionId)

List the answers available for a question

<b>Permissions Needed:</b> TRIVIA_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetQuestionAnswersExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Gamification_TriviaApi();
            var questionId = questionId_example;  // string | The id of the question

            try
            {
                // List the answers available for a question
                List&lt;AnswerResource&gt; result = apiInstance.GetQuestionAnswers(questionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Gamification_TriviaApi.GetQuestionAnswers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **questionId** | **string**| The id of the question | 

### Return type

[**List<AnswerResource>**](AnswerResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getquestiondeltas"></a>
# **GetQuestionDeltas**
> List<DeltaResource> GetQuestionDeltas (long? since = null)

List question deltas in ascending order of updated date

The 'since' parameter is important to avoid getting a full list of all questions. Implementors should make sure they pass the updated date of the last resource loaded, not the date of the last request, in order to avoid gaps. <br><br><b>Permissions Needed:</b> TRIVIA_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetQuestionDeltasExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Gamification_TriviaApi();
            var since = 789;  // long? | Timestamp in seconds (optional) 

            try
            {
                // List question deltas in ascending order of updated date
                List&lt;DeltaResource&gt; result = apiInstance.GetQuestionDeltas(since);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Gamification_TriviaApi.GetQuestionDeltas: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **since** | **long?**| Timestamp in seconds | [optional] 

### Return type

[**List<DeltaResource>**](DeltaResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getquestiontags"></a>
# **GetQuestionTags**
> List<string> GetQuestionTags (string id)

List the tags for a question

<b>Permissions Needed:</b> TRIVIA_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetQuestionTagsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Gamification_TriviaApi();
            var id = id_example;  // string | The id of the question

            try
            {
                // List the tags for a question
                List&lt;string&gt; result = apiInstance.GetQuestionTags(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Gamification_TriviaApi.GetQuestionTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the question | 

### Return type

**List<string>**

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getquestiontemplate"></a>
# **GetQuestionTemplate**
> QuestionTemplateResource GetQuestionTemplate (string id)

Get a single question template

<b>Permissions Needed:</b> TEMPLATE_ADMIN or TRIVIA_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetQuestionTemplateExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Gamification_TriviaApi();
            var id = id_example;  // string | The id of the template

            try
            {
                // Get a single question template
                QuestionTemplateResource result = apiInstance.GetQuestionTemplate(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Gamification_TriviaApi.GetQuestionTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the template | 

### Return type

[**QuestionTemplateResource**](QuestionTemplateResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getquestiontemplates"></a>
# **GetQuestionTemplates**
> PageResourceQuestionTemplateResource GetQuestionTemplates (int? size = null, int? page = null, string order = null)

List and search question templates

<b>Permissions Needed:</b> TEMPLATE_ADMIN or TRIVIA_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetQuestionTemplatesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Gamification_TriviaApi();
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // List and search question templates
                PageResourceQuestionTemplateResource result = apiInstance.GetQuestionTemplates(size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Gamification_TriviaApi.GetQuestionTemplates: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to id:ASC]

### Return type

[**PageResourceQuestionTemplateResource**](PageResourceQuestionTemplateResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getquestions"></a>
# **GetQuestions**
> PageResourceQuestionResource GetQuestions (int? size = null, int? page = null, string order = null, string filterSearch = null, string filterIdset = null, string filterCategory = null, string filterTagset = null, string filterTag = null, string filterType = null, bool? filterPublished = null, long? filterImportId = null)

List and search questions

<b>Permissions Needed:</b> TRIVIA_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetQuestionsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Gamification_TriviaApi();
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)
            var filterSearch = filterSearch_example;  // string | Filter for documents whose question, answers or tags contains provided string (optional) 
            var filterIdset = filterIdset_example;  // string | Filter for documents whose id is in the comma separated list provided (optional) 
            var filterCategory = filterCategory_example;  // string | Filter for questions with specified category, by id (optional) 
            var filterTagset = filterTagset_example;  // string | Filter for questions with specified tags (separated by comma) (optional) 
            var filterTag = filterTag_example;  // string | Filter for questions with specified tag (optional) 
            var filterType = filterType_example;  // string | Filter for questions with specified type.  Allowable values: ('TEXT', 'IMAGE', 'VIDEO', 'AUDIO') (optional) 
            var filterPublished = true;  // bool? | Filter for questions currenctly published or not (optional) 
            var filterImportId = 789;  // long? | Filter for questions from a specific import job (optional) 

            try
            {
                // List and search questions
                PageResourceQuestionResource result = apiInstance.GetQuestions(size, page, order, filterSearch, filterIdset, filterCategory, filterTagset, filterTag, filterType, filterPublished, filterImportId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Gamification_TriviaApi.GetQuestions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to id:ASC]
 **filterSearch** | **string**| Filter for documents whose question, answers or tags contains provided string | [optional] 
 **filterIdset** | **string**| Filter for documents whose id is in the comma separated list provided | [optional] 
 **filterCategory** | **string**| Filter for questions with specified category, by id | [optional] 
 **filterTagset** | **string**| Filter for questions with specified tags (separated by comma) | [optional] 
 **filterTag** | **string**| Filter for questions with specified tag | [optional] 
 **filterType** | **string**| Filter for questions with specified type.  Allowable values: (&#39;TEXT&#39;, &#39;IMAGE&#39;, &#39;VIDEO&#39;, &#39;AUDIO&#39;) | [optional] 
 **filterPublished** | **bool?**| Filter for questions currenctly published or not | [optional] 
 **filterImportId** | **long?**| Filter for questions from a specific import job | [optional] 

### Return type

[**PageResourceQuestionResource**](PageResourceQuestionResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getquestionscount"></a>
# **GetQuestionsCount**
> long? GetQuestionsCount (string filterSearch = null, string filterIdset = null, string filterCategory = null, string filterTag = null, string filterTagset = null, string filterType = null, bool? filterPublished = null)

Count questions based on filters

This is also provided by the list endpoint so you don't need to call this for pagination purposes. <br><br><b>Permissions Needed:</b> TRIVIA_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetQuestionsCountExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Gamification_TriviaApi();
            var filterSearch = filterSearch_example;  // string | Filter for documents whose question, answers or tags contains provided string (optional) 
            var filterIdset = filterIdset_example;  // string | Filter for documents whose id is in the comma separated list provided (optional) 
            var filterCategory = filterCategory_example;  // string | Filter for questions with specified category, by id (optional) 
            var filterTag = filterTag_example;  // string | Filter for questions with specified tag (optional) 
            var filterTagset = filterTagset_example;  // string | Filter for questions with specified tags (separated by comma) (optional) 
            var filterType = filterType_example;  // string | Filter for questions with specified type.  Allowable values: ('TEXT', 'IMAGE', 'VIDEO', 'AUDIO') (optional) 
            var filterPublished = true;  // bool? | Filter for questions currenctly published or not (optional) 

            try
            {
                // Count questions based on filters
                long? result = apiInstance.GetQuestionsCount(filterSearch, filterIdset, filterCategory, filterTag, filterTagset, filterType, filterPublished);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Gamification_TriviaApi.GetQuestionsCount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterSearch** | **string**| Filter for documents whose question, answers or tags contains provided string | [optional] 
 **filterIdset** | **string**| Filter for documents whose id is in the comma separated list provided | [optional] 
 **filterCategory** | **string**| Filter for questions with specified category, by id | [optional] 
 **filterTag** | **string**| Filter for questions with specified tag | [optional] 
 **filterTagset** | **string**| Filter for questions with specified tags (separated by comma) | [optional] 
 **filterType** | **string**| Filter for questions with specified type.  Allowable values: (&#39;TEXT&#39;, &#39;IMAGE&#39;, &#39;VIDEO&#39;, &#39;AUDIO&#39;) | [optional] 
 **filterPublished** | **bool?**| Filter for questions currenctly published or not | [optional] 

### Return type

**long?**

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="processimportjob"></a>
# **ProcessImportJob**
> ImportJobResource ProcessImportJob (long? id, bool? publishNow)

Start processing an import job

Will process the CSV file and add new questions asynchronously. The status of the job must be 'VALID'. <br><br><b>Permissions Needed:</b> TRIVIA_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class ProcessImportJobExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Gamification_TriviaApi();
            var id = 789;  // long? | The id of the job
            var publishNow = true;  // bool? | Whether the new questions should be published live immediately

            try
            {
                // Start processing an import job
                ImportJobResource result = apiInstance.ProcessImportJob(id, publishNow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Gamification_TriviaApi.ProcessImportJob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The id of the job | 
 **publishNow** | **bool?**| Whether the new questions should be published live immediately | 

### Return type

[**ImportJobResource**](ImportJobResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removequestiontag"></a>
# **RemoveQuestionTag**
> void RemoveQuestionTag (string id, string tag)

Remove a tag from a question

<b>Permissions Needed:</b> TRIVIA_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class RemoveQuestionTagExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Gamification_TriviaApi();
            var id = id_example;  // string | The id of the question
            var tag = tag_example;  // string | The tag to remove

            try
            {
                // Remove a tag from a question
                apiInstance.RemoveQuestionTag(id, tag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Gamification_TriviaApi.RemoveQuestionTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the question | 
 **tag** | **string**| The tag to remove | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removetagtoquestionsbatch"></a>
# **RemoveTagToQuestionsBatch**
> int? RemoveTagToQuestionsBatch (string tag, string filterSearch = null, string filterIdset = null, string filterCategory = null, string filterTag = null, string filterTagset = null, string filterType = null, bool? filterPublished = null, long? filterImportId = null)

Remove a tag from a batch of questions

ll questions that have the tag and match filters will have it removed. The returned number is the number of questions updated. <br><br><b>Permissions Needed:</b> TRIVIA_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class RemoveTagToQuestionsBatchExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Gamification_TriviaApi();
            var tag = tag_example;  // string | The tag to remove
            var filterSearch = filterSearch_example;  // string | Filter for documents whose question, answers or tags contains provided string (optional) 
            var filterIdset = filterIdset_example;  // string | Filter for documents whose id is in the comma separated list provided (optional) 
            var filterCategory = filterCategory_example;  // string | Filter for questions with specified category, by id (optional) 
            var filterTag = filterTag_example;  // string | Filter for questions with specified tag (optional) 
            var filterTagset = filterTagset_example;  // string | Filter for questions with specified tags (separated by comma) (optional) 
            var filterType = filterType_example;  // string | Filter for questions with specified type.  Allowable values: ('TEXT', 'IMAGE', 'VIDEO', 'AUDIO') (optional) 
            var filterPublished = true;  // bool? | Filter for questions currenctly published or not (optional) 
            var filterImportId = 789;  // long? | Filter for questions from a specific import job (optional) 

            try
            {
                // Remove a tag from a batch of questions
                int? result = apiInstance.RemoveTagToQuestionsBatch(tag, filterSearch, filterIdset, filterCategory, filterTag, filterTagset, filterType, filterPublished, filterImportId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Gamification_TriviaApi.RemoveTagToQuestionsBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tag** | **string**| The tag to remove | 
 **filterSearch** | **string**| Filter for documents whose question, answers or tags contains provided string | [optional] 
 **filterIdset** | **string**| Filter for documents whose id is in the comma separated list provided | [optional] 
 **filterCategory** | **string**| Filter for questions with specified category, by id | [optional] 
 **filterTag** | **string**| Filter for questions with specified tag | [optional] 
 **filterTagset** | **string**| Filter for questions with specified tags (separated by comma) | [optional] 
 **filterType** | **string**| Filter for questions with specified type.  Allowable values: (&#39;TEXT&#39;, &#39;IMAGE&#39;, &#39;VIDEO&#39;, &#39;AUDIO&#39;) | [optional] 
 **filterPublished** | **bool?**| Filter for questions currenctly published or not | [optional] 
 **filterImportId** | **long?**| Filter for questions from a specific import job | [optional] 

### Return type

**int?**

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchquestiontags"></a>
# **SearchQuestionTags**
> List<string> SearchQuestionTags (string filterSearch = null, string filterCategory = null, long? filterImportId = null)

List and search tags by the beginning of the string

For performance reasons, search & category filters are mutually exclusive. If category is specified, search filter will be ignored in order to do fast matches for typeahead. <br><br><b>Permissions Needed:</b> TRIVIA_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class SearchQuestionTagsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Gamification_TriviaApi();
            var filterSearch = filterSearch_example;  // string | Filter for tags starting with the given text (optional) 
            var filterCategory = filterCategory_example;  // string | Filter for tags on questions from a specific category (optional) 
            var filterImportId = 789;  // long? | Filter for tags on questions from a specific import job (optional) 

            try
            {
                // List and search tags by the beginning of the string
                List&lt;string&gt; result = apiInstance.SearchQuestionTags(filterSearch, filterCategory, filterImportId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Gamification_TriviaApi.SearchQuestionTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterSearch** | **string**| Filter for tags starting with the given text | [optional] 
 **filterCategory** | **string**| Filter for tags on questions from a specific category | [optional] 
 **filterImportId** | **long?**| Filter for tags on questions from a specific import job | [optional] 

### Return type

**List<string>**

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateimportjob"></a>
# **UpdateImportJob**
> ImportJobResource UpdateImportJob (long? id, ImportJobResource request = null)

Update an import job

Changes should be made before process is started for there to be any effect. <br><br><b>Permissions Needed:</b> TRIVIA_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class UpdateImportJobExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Gamification_TriviaApi();
            var id = 789;  // long? | The id of the job
            var request = new ImportJobResource(); // ImportJobResource | The updated job (optional) 

            try
            {
                // Update an import job
                ImportJobResource result = apiInstance.UpdateImportJob(id, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Gamification_TriviaApi.UpdateImportJob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The id of the job | 
 **request** | [**ImportJobResource**](ImportJobResource.md)| The updated job | [optional] 

### Return type

[**ImportJobResource**](ImportJobResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatequestion"></a>
# **UpdateQuestion**
> QuestionResource UpdateQuestion (string id, QuestionResource question = null)

Update a question

<b>Permissions Needed:</b> TRIVIA_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class UpdateQuestionExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Gamification_TriviaApi();
            var id = id_example;  // string | The id of the question
            var question = new QuestionResource(); // QuestionResource | The updated question (optional) 

            try
            {
                // Update a question
                QuestionResource result = apiInstance.UpdateQuestion(id, question);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Gamification_TriviaApi.UpdateQuestion: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the question | 
 **question** | [**QuestionResource**](QuestionResource.md)| The updated question | [optional] 

### Return type

[**QuestionResource**](QuestionResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatequestionanswer"></a>
# **UpdateQuestionAnswer**
> void UpdateQuestionAnswer (string questionId, string id, AnswerResource answer = null)

Update an answer for a question

<b>Permissions Needed:</b> TRIVIA_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class UpdateQuestionAnswerExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Gamification_TriviaApi();
            var questionId = questionId_example;  // string | The id of the question
            var id = id_example;  // string | The id of the answer
            var answer = new AnswerResource(); // AnswerResource | The updated answer (optional) 

            try
            {
                // Update an answer for a question
                apiInstance.UpdateQuestionAnswer(questionId, id, answer);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Gamification_TriviaApi.UpdateQuestionAnswer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **questionId** | **string**| The id of the question | 
 **id** | **string**| The id of the answer | 
 **answer** | [**AnswerResource**](AnswerResource.md)| The updated answer | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatequestiontemplate"></a>
# **UpdateQuestionTemplate**
> QuestionTemplateResource UpdateQuestionTemplate (string id, QuestionTemplateResource questionTemplateResource = null)

Update a question template

<b>Permissions Needed:</b> TEMPLATE_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class UpdateQuestionTemplateExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Gamification_TriviaApi();
            var id = id_example;  // string | The id of the template
            var questionTemplateResource = new QuestionTemplateResource(); // QuestionTemplateResource | The question template resource object (optional) 

            try
            {
                // Update a question template
                QuestionTemplateResource result = apiInstance.UpdateQuestionTemplate(id, questionTemplateResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Gamification_TriviaApi.UpdateQuestionTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the template | 
 **questionTemplateResource** | [**QuestionTemplateResource**](QuestionTemplateResource.md)| The question template resource object | [optional] 

### Return type

[**QuestionTemplateResource**](QuestionTemplateResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatequestionsinbulk"></a>
# **UpdateQuestionsInBulk**
> int? UpdateQuestionsInBulk (QuestionResource question = null, string filterSearch = null, string filterIdset = null, string filterCategory = null, string filterTagset = null, string filterType = null, bool? filterPublished = null, long? filterImportId = null)

Bulk update questions

Will update all questions that match filters used (or all questions in system if no filters used). Body should match a question resource with only those properties you wish to set. Null values will be ignored. Returned number is how many were updated. <br><br><b>Permissions Needed:</b> TRIVIA_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class UpdateQuestionsInBulkExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Gamification_TriviaApi();
            var question = new QuestionResource(); // QuestionResource | New values for a set of question fields (optional) 
            var filterSearch = filterSearch_example;  // string | Filter for documents whose question, answers or tags contains provided string (optional) 
            var filterIdset = filterIdset_example;  // string | Filter for documents whose id is in the comma separated list provided (optional) 
            var filterCategory = filterCategory_example;  // string | Filter for questions with specified category, by id (optional) 
            var filterTagset = filterTagset_example;  // string | Filter for questions with specified tags (separated by comma) (optional) 
            var filterType = filterType_example;  // string | Filter for questions with specified type.  Allowable values: ('TEXT', 'IMAGE', 'VIDEO', 'AUDIO') (optional) 
            var filterPublished = true;  // bool? | Filter for questions currenctly published or not (optional) 
            var filterImportId = 789;  // long? | Filter for questions from a specific import job (optional) 

            try
            {
                // Bulk update questions
                int? result = apiInstance.UpdateQuestionsInBulk(question, filterSearch, filterIdset, filterCategory, filterTagset, filterType, filterPublished, filterImportId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Gamification_TriviaApi.UpdateQuestionsInBulk: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **question** | [**QuestionResource**](QuestionResource.md)| New values for a set of question fields | [optional] 
 **filterSearch** | **string**| Filter for documents whose question, answers or tags contains provided string | [optional] 
 **filterIdset** | **string**| Filter for documents whose id is in the comma separated list provided | [optional] 
 **filterCategory** | **string**| Filter for questions with specified category, by id | [optional] 
 **filterTagset** | **string**| Filter for questions with specified tags (separated by comma) | [optional] 
 **filterType** | **string**| Filter for questions with specified type.  Allowable values: (&#39;TEXT&#39;, &#39;IMAGE&#39;, &#39;VIDEO&#39;, &#39;AUDIO&#39;) | [optional] 
 **filterPublished** | **bool?**| Filter for questions currenctly published or not | [optional] 
 **filterImportId** | **long?**| Filter for questions from a specific import job | [optional] 

### Return type

**int?**

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

