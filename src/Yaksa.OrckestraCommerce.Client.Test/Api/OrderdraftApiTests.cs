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
    ///  Class for testing OrderdraftApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class OrderdraftApiTests : IDisposable
    {
        private OrderdraftApi instance;

        public OrderdraftApiTests()
        {
            instance = new OrderdraftApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of OrderdraftApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' OrderdraftApi
            //Assert.IsType<OrderdraftApi>(instance);
        }

        /// <summary>
        /// Test GetOrderDraftPaymentRequestScopeIdDraftIdpaymentPaymentIdGet
        /// </summary>
        [Fact]
        public void GetOrderDraftPaymentRequestScopeIdDraftIdpaymentPaymentIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string scopeId = null;
            //string draftId = null;
            //string paymentId = null;
            //var response = instance.GetOrderDraftPaymentRequestScopeIdDraftIdpaymentPaymentIdGet(accept, scopeId, draftId, paymentId);
            //Assert.IsType<Payment>(response);
        }

        /// <summary>
        /// Test UpdateOrderDraftPaymentRequestScopeIdDraftIdpaymentPaymentIdPost
        /// </summary>
        [Fact]
        public void UpdateOrderDraftPaymentRequestScopeIdDraftIdpaymentPaymentIdPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string scopeId = null;
            //string draftId = null;
            //string paymentId = null;
            //UpdateOrderDraftPaymentRequest body = null;
            //var response = instance.UpdateOrderDraftPaymentRequestScopeIdDraftIdpaymentPaymentIdPost(accept, scopeId, draftId, paymentId, body);
            //Assert.IsType<Payment>(response);
        }
    }
}
