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
    ///  Class for testing InventoryItemsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class InventoryItemsApiTests : IDisposable
    {
        private InventoryItemsApi instance;

        public InventoryItemsApiTests()
        {
            instance = new InventoryItemsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of InventoryItemsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' InventoryItemsApi
            //Assert.IsType<InventoryItemsApi>(instance);
        }

        /// <summary>
        /// Test CancelAllInventoryReservedItemsRequestreservationsOwnerIdcancelAllPost
        /// </summary>
        [Fact]
        public void CancelAllInventoryReservedItemsRequestreservationsOwnerIdcancelAllPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string ownerId = null;
            //CancelAllInventoryReservedItemsRequest body = null;
            //instance.CancelAllInventoryReservedItemsRequestreservationsOwnerIdcancelAllPost(accept, ownerId, body);
        }

        /// <summary>
        /// Test CancelInventoryReservedItemsRequestreservationsOwnerIdcancelListPost
        /// </summary>
        [Fact]
        public void CancelInventoryReservedItemsRequestreservationsOwnerIdcancelListPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string ownerId = null;
            //CancelInventoryReservedItemsRequest body = null;
            //instance.CancelInventoryReservedItemsRequestreservationsOwnerIdcancelListPost(accept, ownerId, body);
        }

        /// <summary>
        /// Test ChangeInventoryReservedItemsStockStatusRequestreservationsOwnerIdchangeStockStatusPost
        /// </summary>
        [Fact]
        public void ChangeInventoryReservedItemsStockStatusRequestreservationsOwnerIdchangeStockStatusPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string ownerId = null;
            //ChangeInventoryReservedItemsStockStatusRequest body = null;
            //var response = instance.ChangeInventoryReservedItemsStockStatusRequestreservationsOwnerIdchangeStockStatusPost(accept, ownerId, body);
            //Assert.IsType<ChangeInventoryReservedItemsStockStatusResult>(response);
        }

        /// <summary>
        /// Test ConfirmInventoryReservedOrderItemsRequestreservationsOwnerIdconfirmPost
        /// </summary>
        [Fact]
        public void ConfirmInventoryReservedOrderItemsRequestreservationsOwnerIdconfirmPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string ownerId = null;
            //ConfirmInventoryReservedOrderItemsRequest body = null;
            //var response = instance.ConfirmInventoryReservedOrderItemsRequestreservationsOwnerIdconfirmPost(accept, ownerId, body);
            //Assert.IsType<List<InventoryReservedItem>>(response);
        }

        /// <summary>
        /// Test CreateOrUpdateInventoryItemRequestScopeIdInventoryLocationIdSkuCreate
        /// </summary>
        [Fact]
        public void CreateOrUpdateInventoryItemRequestScopeIdInventoryLocationIdSkuCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string scopeId = null;
            //string inventoryLocationId = null;
            //string sku = null;
            //CreateOrUpdateInventoryItemRequest body = null;
            //var response = instance.CreateOrUpdateInventoryItemRequestScopeIdInventoryLocationIdSkuCreate(accept, scopeId, inventoryLocationId, sku, body);
            //Assert.IsType<InventoryItem>(response);
        }

        /// <summary>
        /// Test DecreaseInventoryQuantityRequestScopeIdbySkuSkubyLocationInventoryLocationIddecreaseQuantityPost
        /// </summary>
        [Fact]
        public void DecreaseInventoryQuantityRequestScopeIdbySkuSkubyLocationInventoryLocationIddecreaseQuantityPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string scopeId = null;
            //string sku = null;
            //string inventoryLocationId = null;
            //double quantity = null;
            //Object body = null;
            //var response = instance.DecreaseInventoryQuantityRequestScopeIdbySkuSkubyLocationInventoryLocationIddecreaseQuantityPost(accept, scopeId, sku, inventoryLocationId, quantity, body);
            //Assert.IsType<InventoryQuantity>(response);
        }

        /// <summary>
        /// Test EvaluateInventoryAvailabilityRequestreservationsOwnerIdevaluatePost
        /// </summary>
        [Fact]
        public void EvaluateInventoryAvailabilityRequestreservationsOwnerIdevaluatePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string ownerId = null;
            //EvaluateInventoryAvailabilityRequest body = null;
            //var response = instance.EvaluateInventoryAvailabilityRequestreservationsOwnerIdevaluatePost(accept, ownerId, body);
            //Assert.IsType<List<InventoryItemAvailabilityEvaluationResult>>(response);
        }

        /// <summary>
        /// Test FindInventoryItemStatusByLocationAndSkusRequestScopeIdbyLocationInventoryLocationIdbySkusstatusPost
        /// </summary>
        [Fact]
        public void FindInventoryItemStatusByLocationAndSkusRequestScopeIdbyLocationInventoryLocationIdbySkusstatusPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string scopeId = null;
            //string inventoryLocationId = null;
            //FindInventoryItemStatusByLocationAndSkusRequest body = null;
            //var response = instance.FindInventoryItemStatusByLocationAndSkusRequestScopeIdbyLocationInventoryLocationIdbySkusstatusPost(accept, scopeId, inventoryLocationId, body);
            //Assert.IsType<List<InventoryItemAvailability>>(response);
        }

        /// <summary>
        /// Test FindInventoryItemStatusBySkuAndLocationRequestScopeIdbySkuSkubyLocationInventoryLocationIdstatusPost
        /// </summary>
        [Fact]
        public void FindInventoryItemStatusBySkuAndLocationRequestScopeIdbySkuSkubyLocationInventoryLocationIdstatusPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string scopeId = null;
            //string sku = null;
            //string inventoryLocationId = null;
            //FindInventoryItemStatusBySkuAndLocationRequest body = null;
            //var response = instance.FindInventoryItemStatusBySkuAndLocationRequestScopeIdbySkuSkubyLocationInventoryLocationIdstatusPost(accept, scopeId, sku, inventoryLocationId, body);
            //Assert.IsType<InventoryItemAvailability>(response);
        }

        /// <summary>
        /// Test FindInventoryItemsRequestScopeIdfindPost
        /// </summary>
        [Fact]
        public void FindInventoryItemsRequestScopeIdfindPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string scopeId = null;
            //FindInventoryItemsRequest body = null;
            //var response = instance.FindInventoryItemsRequestScopeIdfindPost(accept, scopeId, body);
            //Assert.IsType<List<InventoryItem>>(response);
        }

        /// <summary>
        /// Test FindInventoryItemsStatusByScopeAndSkuRequestScopeIdbySkuSkustatusPost
        /// </summary>
        [Fact]
        public void FindInventoryItemsStatusByScopeAndSkuRequestScopeIdbySkuSkustatusPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string scopeId = null;
            //string sku = null;
            //FindInventoryItemsStatusByScopeAndSkuRequest body = null;
            //var response = instance.FindInventoryItemsStatusByScopeAndSkuRequestScopeIdbySkuSkustatusPost(accept, scopeId, sku, body);
            //Assert.IsType<List<InventoryItemAvailability>>(response);
        }

        /// <summary>
        /// Test FindInventoryItemsStatusByScopeAndSkusRequestScopeIdbySkusstatusPost
        /// </summary>
        [Fact]
        public void FindInventoryItemsStatusByScopeAndSkusRequestScopeIdbySkusstatusPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string scopeId = null;
            //FindInventoryItemsStatusByScopeAndSkusRequest body = null;
            //var response = instance.FindInventoryItemsStatusByScopeAndSkusRequestScopeIdbySkusstatusPost(accept, scopeId, body);
            //Assert.IsType<List<InventoryItemAvailability>>(response);
        }

        /// <summary>
        /// Test GetInventoryItemBySkuAndLocationRequestScopeIdbySkuSkubyLocationInventoryLocationIdGet
        /// </summary>
        [Fact]
        public void GetInventoryItemBySkuAndLocationRequestScopeIdbySkuSkubyLocationInventoryLocationIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string scopeId = null;
            //string sku = null;
            //string inventoryLocationId = null;
            //DateTime? date = null;
            //var response = instance.GetInventoryItemBySkuAndLocationRequestScopeIdbySkuSkubyLocationInventoryLocationIdGet(accept, scopeId, sku, inventoryLocationId, date);
            //Assert.IsType<InventoryItemStatusDetails>(response);
        }

        /// <summary>
        /// Test GetInventoryItemsByLocationRequestScopeIdbyLocationInventoryLocationIdGet
        /// </summary>
        [Fact]
        public void GetInventoryItemsByLocationRequestScopeIdbyLocationInventoryLocationIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string scopeId = null;
            //string inventoryLocationId = null;
            //var response = instance.GetInventoryItemsByLocationRequestScopeIdbyLocationInventoryLocationIdGet(accept, scopeId, inventoryLocationId);
            //Assert.IsType<List<InventoryItem>>(response);
        }

        /// <summary>
        /// Test GetInventoryItemsByScopeAndSkuRequestScopeIdbySkuSkuGet
        /// </summary>
        [Fact]
        public void GetInventoryItemsByScopeAndSkuRequestScopeIdbySkuSkuGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string scopeId = null;
            //string sku = null;
            //bool? includeChildScopes = null;
            //int? startingIndex = null;
            //int? maximumItems = null;
            //string sortOrderField = null;
            //string sortDirection = null;
            //DateTime? date = null;
            //var response = instance.GetInventoryItemsByScopeAndSkuRequestScopeIdbySkuSkuGet(accept, scopeId, sku, includeChildScopes, startingIndex, maximumItems, sortOrderField, sortDirection, date);
            //Assert.IsType<InventoryItemStatusDetailsQueryResult>(response);
        }

        /// <summary>
        /// Test GetInventoryItemsByScopeAndSkusRequestScopeIdbySkusPost
        /// </summary>
        [Fact]
        public void GetInventoryItemsByScopeAndSkusRequestScopeIdbySkusPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string scopeId = null;
            //GetInventoryItemsByScopeAndSkusRequest body = null;
            //var response = instance.GetInventoryItemsByScopeAndSkusRequestScopeIdbySkusPost(accept, scopeId, body);
            //Assert.IsType<InventoryItemStatusDetailsQueryResult>(response);
        }

        /// <summary>
        /// Test GetInventoryProvidersRequestScopeIdfindProvidersGet
        /// </summary>
        [Fact]
        public void GetInventoryProvidersRequestScopeIdfindProvidersGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string scopeId = null;
            //string cultureName = null;
            //var response = instance.GetInventoryProvidersRequestScopeIdfindProvidersGet(accept, scopeId, cultureName);
            //Assert.IsType<List<InventoryProviderDetails>>(response);
        }

        /// <summary>
        /// Test GetInventoryReservedItemsRequestreservationsOwnerIdGet
        /// </summary>
        [Fact]
        public void GetInventoryReservedItemsRequestreservationsOwnerIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string ownerId = null;
            //var response = instance.GetInventoryReservedItemsRequestreservationsOwnerIdGet(accept, ownerId);
            //Assert.IsType<List<InventoryReservedItem>>(response);
        }

        /// <summary>
        /// Test IncreaseInventoryQuantityRequestScopeIdbySkuSkubyLocationInventoryLocationIdincreaseQuantityPost
        /// </summary>
        [Fact]
        public void IncreaseInventoryQuantityRequestScopeIdbySkuSkubyLocationInventoryLocationIdincreaseQuantityPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string scopeId = null;
            //string sku = null;
            //string inventoryLocationId = null;
            //double quantity = null;
            //Object body = null;
            //var response = instance.IncreaseInventoryQuantityRequestScopeIdbySkuSkubyLocationInventoryLocationIdincreaseQuantityPost(accept, scopeId, sku, inventoryLocationId, quantity, body);
            //Assert.IsType<InventoryQuantity>(response);
        }

        /// <summary>
        /// Test ReserveInventoryItemsRequestreservationsOwnerIdPost
        /// </summary>
        [Fact]
        public void ReserveInventoryItemsRequestreservationsOwnerIdPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string ownerId = null;
            //ReserveInventoryItemsRequest body = null;
            //var response = instance.ReserveInventoryItemsRequestreservationsOwnerIdPost(accept, ownerId, body);
            //Assert.IsType<InventoryReservationResult>(response);
        }
    }
}
