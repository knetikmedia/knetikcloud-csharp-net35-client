# com.knetikcloud.Api.ReportingChallengesApi

All URIs are relative to *https://sandbox.knetikcloud.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetChallengeEventLeaderboard**](ReportingChallengesApi.md#getchallengeeventleaderboard) | **GET** /reporting/events/leaderboard | Retrieve a challenge event leaderboard details
[**GetChallengeEventParticipants**](ReportingChallengesApi.md#getchallengeeventparticipants) | **GET** /reporting/events/participants | Retrieve a challenge event participant details


<a name="getchallengeeventleaderboard"></a>
# **GetChallengeEventLeaderboard**
> PageResourceChallengeEventParticipantResource GetChallengeEventLeaderboard (long? filterEvent = null, int? size = null, int? page = null, string order = null)

Retrieve a challenge event leaderboard details

Lists all leaderboard entries with additional user details

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetChallengeEventLeaderboardExample
    {
        public void main()
        {
            var apiInstance = new ReportingChallengesApi();
            var filterEvent = 789;  // long? | A sepecific challenge event id (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional) 

            try
            {
                // Retrieve a challenge event leaderboard details
                PageResourceChallengeEventParticipantResource result = apiInstance.GetChallengeEventLeaderboard(filterEvent, size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportingChallengesApi.GetChallengeEventLeaderboard: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterEvent** | **long?**| A sepecific challenge event id | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] 

### Return type

[**PageResourceChallengeEventParticipantResource**](PageResourceChallengeEventParticipantResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchallengeeventparticipants"></a>
# **GetChallengeEventParticipants**
> PageResourceChallengeEventParticipantResource GetChallengeEventParticipants (long? filterEvent = null, int? size = null, int? page = null, string order = null)

Retrieve a challenge event participant details

Lists all user submitted scores sorted by value, including those that do not apear in the leaderboard due to value or aggregation

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetChallengeEventParticipantsExample
    {
        public void main()
        {
            var apiInstance = new ReportingChallengesApi();
            var filterEvent = 789;  // long? | A sepecific challenge event id (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional) 

            try
            {
                // Retrieve a challenge event participant details
                PageResourceChallengeEventParticipantResource result = apiInstance.GetChallengeEventParticipants(filterEvent, size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportingChallengesApi.GetChallengeEventParticipants: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterEvent** | **long?**| A sepecific challenge event id | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] 

### Return type

[**PageResourceChallengeEventParticipantResource**](PageResourceChallengeEventParticipantResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

