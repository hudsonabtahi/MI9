## Synopsis

This project is a response to a MI9 coding challenge.
The application has been written as a web api service and been hosted in Microsoft Azure.

The service simply will be invoked with a json data containing a show array as input 
It filters out some items and resend the filtered array with items which contain few key fields.

## Input Data

A json data containing a show array. See sample request at https://github.com/mi9/coding-challenge-samples/blob/master/sample_request.json

## Output Data

Filtered input array and reformed show items. See sample response at https://github.com/mi9/coding-challenge-samples/blob/master/sample_response.json

## Service Host

The service lives in Microsoft Azure cloud with URL http://mi9challenge.azurewebsites.net/

## Technology

The service has been written as an MVC Web Api service with Microsoft Visual Studio 2013 in C#.

## Contents

Models/FilterShowRequest.cs: 	Contains data entities which represent request data including FilterShowRequest, Show, Image, Episode and Season classes

Models/FilterShowResponse.cs: 	Contains data entities which represent response data including FilterShowResponse and ShowSummary classes

ApplicationServices/IFilterShowService.cs: 	prototype for the filter service, filter method, FilterDRMMinimumEpisodeCount, has been introduced. The filter method is designed to be more general as it takes desired DRM value and minimum episode count. It also get the input ShowList and will return the filtered ShowSummery list.

ApplicationServices/FilterShowService.cs: 	implements the IFilterShowService. 

Controllers/FilterShowController.cs:	designed to have dependency injection as FilterShowService. The dependency is passed trough its constructor, even though it makes a default FilterShowService. This controller is inherited from ApiController and has only the post method. In post method validity of request data has been checked and proper error message has been returned in case of bad request data detection. The filter method is invoked and result is returned.

## Tests

Few unit test has been designed as following to check behavior of the service.
