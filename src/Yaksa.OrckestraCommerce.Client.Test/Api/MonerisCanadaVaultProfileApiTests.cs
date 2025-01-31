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
    ///  Class for testing MonerisCanadaVaultProfileApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class MonerisCanadaVaultProfileApiTests : IDisposable
    {
        private MonerisCanadaVaultProfileApi instance;

        public MonerisCanadaVaultProfileApiTests()
        {
            instance = new MonerisCanadaVaultProfileApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of MonerisCanadaVaultProfileApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' MonerisCanadaVaultProfileApi
            //Assert.IsType<MonerisCanadaVaultProfileApi>(instance);
        }

        /// <summary>
        /// Test CreateCartPaymentVaultProfileRequestcartsScopeIdCustomerIdCartNamepaymentsPaymentIdPost
        /// </summary>
        [Fact]
        public void CreateCartPaymentVaultProfileRequestcartsScopeIdCustomerIdCartNamepaymentsPaymentIdPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string scopeId = null;
            //string customerId = null;
            //string cartName = null;
            //string paymentId = null;
            //CreateCartPaymentVaultProfileRequest body = null;
            //var response = instance.CreateCartPaymentVaultProfileRequestcartsScopeIdCustomerIdCartNamepaymentsPaymentIdPost(accept, scopeId, customerId, cartName, paymentId, body);
            //Assert.IsType<VaultProfileCreationResult>(response);
        }

        /// <summary>
        /// Test CreateOrderDraftPaymentVaultProfileRequestorderdraftScopeIdDraftIdpaymentsPaymentIdPost
        /// </summary>
        [Fact]
        public void CreateOrderDraftPaymentVaultProfileRequestorderdraftScopeIdDraftIdpaymentsPaymentIdPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string scopeId = null;
            //string draftId = null;
            //string paymentId = null;
            //CreateOrderDraftPaymentVaultProfileRequest body = null;
            //var response = instance.CreateOrderDraftPaymentVaultProfileRequestorderdraftScopeIdDraftIdpaymentsPaymentIdPost(accept, scopeId, draftId, paymentId, body);
            //Assert.IsType<VaultProfileCreationResult>(response);
        }
    }
}
