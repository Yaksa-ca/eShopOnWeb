/*
 * Overture API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Api;
// uncomment below to import models
//using Yaksa.OrckestraCommerce.Client.Model;

namespace Yaksa.OrckestraCommerce.Client.Test.Api
{
    /// <summary>
    ///  Class for testing FulfillmentMethodsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class FulfillmentMethodsApiTests : IDisposable
    {
        private FulfillmentMethodsApi instance;

        public FulfillmentMethodsApiTests()
        {
            instance = new FulfillmentMethodsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of FulfillmentMethodsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' FulfillmentMethodsApi
            //Assert.IsType<FulfillmentMethodsApi>(instance);
        }

        /// <summary>
        /// Test FindCalculatedFulfillmentMethodsRequestScopeIdCustomerIdCartNamePost
        /// </summary>
        [Fact]
        public void FindCalculatedFulfillmentMethodsRequestScopeIdCustomerIdCartNamePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string scopeId = null;
            //string customerId = null;
            //string cartName = null;
            //FindCalculatedFulfillmentMethodsRequest body = null;
            //var response = instance.FindCalculatedFulfillmentMethodsRequestScopeIdCustomerIdCartNamePost(accept, scopeId, customerId, cartName, body);
            //Assert.IsType<List<FulfillmentMethod>>(response);
        }

        /// <summary>
        /// Test GetAvailableFulfillmentMethodsByScopeRequestScopeIdGet
        /// </summary>
        [Fact]
        public void GetAvailableFulfillmentMethodsByScopeRequestScopeIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string scopeId = null;
            //var response = instance.GetAvailableFulfillmentMethodsByScopeRequestScopeIdGet(accept, scopeId);
            //Assert.IsType<GetFulfillmentMethodsResponse>(response);
        }
    }
}
