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
    ///  Class for testing FulfillmentsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class FulfillmentsApiTests : IDisposable
    {
        private FulfillmentsApi instance;

        public FulfillmentsApiTests()
        {
            instance = new FulfillmentsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of FulfillmentsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' FulfillmentsApi
            //Assert.IsType<FulfillmentsApi>(instance);
        }

        /// <summary>
        /// Test AddFulfillmentCompetitionLocationsRequestcompetitionsScopeIdFulfillmentCompetitionIdlocationsPost
        /// </summary>
        [Fact]
        public void AddFulfillmentCompetitionLocationsRequestcompetitionsScopeIdFulfillmentCompetitionIdlocationsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string scopeId = null;
            //string fulfillmentCompetitionId = null;
            //AddFulfillmentCompetitionLocationsRequest body = null;
            //var response = instance.AddFulfillmentCompetitionLocationsRequestcompetitionsScopeIdFulfillmentCompetitionIdlocationsPost(accept, scopeId, fulfillmentCompetitionId, body);
            //Assert.IsType<FulfillmentCompetition>(response);
        }

        /// <summary>
        /// Test ChangeFulfillmentCompetitionLocationStatusRequestcompetitionsScopeIdFulfillmentCompetitionIdlocationsFulfillmentLocationIdstatusCreate
        /// </summary>
        [Fact]
        public void ChangeFulfillmentCompetitionLocationStatusRequestcompetitionsScopeIdFulfillmentCompetitionIdlocationsFulfillmentLocationIdstatusCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string scopeId = null;
            //string fulfillmentCompetitionId = null;
            //string fulfillmentLocationId = null;
            //ChangeFulfillmentCompetitionLocationStatusRequest body = null;
            //var response = instance.ChangeFulfillmentCompetitionLocationStatusRequestcompetitionsScopeIdFulfillmentCompetitionIdlocationsFulfillmentLocationIdstatusCreate(accept, scopeId, fulfillmentCompetitionId, fulfillmentLocationId, body);
            //Assert.IsType<FulfillmentCompetition>(response);
        }

        /// <summary>
        /// Test ChangeFulfillmentCompetitionStatusRequestcompetitionsScopeIdFulfillmentCompetitionIdstatusCreate
        /// </summary>
        [Fact]
        public void ChangeFulfillmentCompetitionStatusRequestcompetitionsScopeIdFulfillmentCompetitionIdstatusCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string scopeId = null;
            //string fulfillmentCompetitionId = null;
            //ChangeFulfillmentCompetitionStatusRequest body = null;
            //var response = instance.ChangeFulfillmentCompetitionStatusRequestcompetitionsScopeIdFulfillmentCompetitionIdstatusCreate(accept, scopeId, fulfillmentCompetitionId, body);
            //Assert.IsType<FulfillmentCompetition>(response);
        }

        /// <summary>
        /// Test ConfirmFulfillmentCarrierQuotesRequestcarriersScopeIdFulfillmentCarrierIdquotesconfirmPost
        /// </summary>
        [Fact]
        public void ConfirmFulfillmentCarrierQuotesRequestcarriersScopeIdFulfillmentCarrierIdquotesconfirmPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string scopeId = null;
            //string fulfillmentCarrierId = null;
            //ConfirmFulfillmentCarrierQuotesRequest body = null;
            //var response = instance.ConfirmFulfillmentCarrierQuotesRequestcarriersScopeIdFulfillmentCarrierIdquotesconfirmPost(accept, scopeId, fulfillmentCarrierId, body);
            //Assert.IsType<ConfirmFulfillmentCarrierQuotesResponse>(response);
        }

        /// <summary>
        /// Test CreateFulfillmentCarrierManifestRequestcarriersScopeIdFulfillmentCarrierIdmanifestsPost
        /// </summary>
        [Fact]
        public void CreateFulfillmentCarrierManifestRequestcarriersScopeIdFulfillmentCarrierIdmanifestsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string scopeId = null;
            //string fulfillmentCarrierId = null;
            //CreateFulfillmentCarrierManifestRequest body = null;
            //var response = instance.CreateFulfillmentCarrierManifestRequestcarriersScopeIdFulfillmentCarrierIdmanifestsPost(accept, scopeId, fulfillmentCarrierId, body);
            //Assert.IsType<CreateFulfillmentCarrierManifestResponse>(response);
        }

        /// <summary>
        /// Test CreateFulfillmentCompetitionRequestcompetitionsScopeIdPost
        /// </summary>
        [Fact]
        public void CreateFulfillmentCompetitionRequestcompetitionsScopeIdPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string scopeId = null;
            //CreateFulfillmentCompetitionRequest body = null;
            //var response = instance.CreateFulfillmentCompetitionRequestcompetitionsScopeIdPost(accept, scopeId, body);
            //Assert.IsType<FulfillmentCompetition>(response);
        }

        /// <summary>
        /// Test CreateFulfillmentPackageRequestpackagesScopeIdPost
        /// </summary>
        [Fact]
        public void CreateFulfillmentPackageRequestpackagesScopeIdPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string scopeId = null;
            //CreateFulfillmentPackageRequest body = null;
            //var response = instance.CreateFulfillmentPackageRequestpackagesScopeIdPost(accept, scopeId, body);
            //Assert.IsType<FulfillmentPackage>(response);
        }

        /// <summary>
        /// Test CreateFulfillmentPackageTypeRequestpackageTypesScopeIdPost
        /// </summary>
        [Fact]
        public void CreateFulfillmentPackageTypeRequestpackageTypesScopeIdPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string scopeId = null;
            //CreateFulfillmentPackageTypeRequest body = null;
            //var response = instance.CreateFulfillmentPackageTypeRequestpackageTypesScopeIdPost(accept, scopeId, body);
            //Assert.IsType<FulfillmentPackageType>(response);
        }

        /// <summary>
        /// Test CreateFulfillmentSLARequestSLAsScopeIdPost
        /// </summary>
        [Fact]
        public void CreateFulfillmentSLARequestSLAsScopeIdPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string scopeId = null;
            //CreateFulfillmentSLARequest body = null;
            //var response = instance.CreateFulfillmentSLARequestSLAsScopeIdPost(accept, scopeId, body);
            //Assert.IsType<FulfillmentSLA>(response);
        }

        /// <summary>
        /// Test CreateOrUpdateFulfillmentExceptionRequestexceptionsScopeIdFulfillmentLocationIdOrderIdShipmentIdLineItemIdCreate
        /// </summary>
        [Fact]
        public void CreateOrUpdateFulfillmentExceptionRequestexceptionsScopeIdFulfillmentLocationIdOrderIdShipmentIdLineItemIdCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string scopeId = null;
            //string fulfillmentLocationId = null;
            //string orderId = null;
            //string shipmentId = null;
            //string lineItemId = null;
            //CreateOrUpdateFulfillmentExceptionRequest body = null;
            //var response = instance.CreateOrUpdateFulfillmentExceptionRequestexceptionsScopeIdFulfillmentLocationIdOrderIdShipmentIdLineItemIdCreate(accept, scopeId, fulfillmentLocationId, orderId, shipmentId, lineItemId, body);
            //Assert.IsType<FulfillmentException>(response);
        }

        /// <summary>
        /// Test DeleteFulfillmentCompetitionRequestcompetitionsScopeIdFulfillmentCompetitionIdDelete
        /// </summary>
        [Fact]
        public void DeleteFulfillmentCompetitionRequestcompetitionsScopeIdFulfillmentCompetitionIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string scopeId = null;
            //string fulfillmentCompetitionId = null;
            //instance.DeleteFulfillmentCompetitionRequestcompetitionsScopeIdFulfillmentCompetitionIdDelete(accept, scopeId, fulfillmentCompetitionId);
        }

        /// <summary>
        /// Test DeleteFulfillmentExceptionRequestexceptionsScopeIdFulfillmentLocationIdOrderIdShipmentIdLineItemIdDelete
        /// </summary>
        [Fact]
        public void DeleteFulfillmentExceptionRequestexceptionsScopeIdFulfillmentLocationIdOrderIdShipmentIdLineItemIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string scopeId = null;
            //string fulfillmentLocationId = null;
            //string orderId = null;
            //string shipmentId = null;
            //string lineItemId = null;
            //instance.DeleteFulfillmentExceptionRequestexceptionsScopeIdFulfillmentLocationIdOrderIdShipmentIdLineItemIdDelete(accept, scopeId, fulfillmentLocationId, orderId, shipmentId, lineItemId);
        }

        /// <summary>
        /// Test DeleteFulfillmentPackageForShipmentRequestpackagesScopeIdbyShipmentShipmentIdDelete
        /// </summary>
        [Fact]
        public void DeleteFulfillmentPackageForShipmentRequestpackagesScopeIdbyShipmentShipmentIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string scopeId = null;
            //string shipmentId = null;
            //instance.DeleteFulfillmentPackageForShipmentRequestpackagesScopeIdbyShipmentShipmentIdDelete(accept, scopeId, shipmentId);
        }

        /// <summary>
        /// Test DeleteFulfillmentPackageRequestpackagesScopeIdIdDelete
        /// </summary>
        [Fact]
        public void DeleteFulfillmentPackageRequestpackagesScopeIdIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string scopeId = null;
            //string id = null;
            //instance.DeleteFulfillmentPackageRequestpackagesScopeIdIdDelete(accept, scopeId, id);
        }

        /// <summary>
        /// Test DeleteFulfillmentPackageTypeRequestpackageTypesScopeIdIdDelete
        /// </summary>
        [Fact]
        public void DeleteFulfillmentPackageTypeRequestpackageTypesScopeIdIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string scopeId = null;
            //string id = null;
            //instance.DeleteFulfillmentPackageTypeRequestpackageTypesScopeIdIdDelete(accept, scopeId, id);
        }

        /// <summary>
        /// Test DisableFulfillmentSLARequestSLAsdisablePost
        /// </summary>
        [Fact]
        public void DisableFulfillmentSLARequestSLAsdisablePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //DisableFulfillmentSLARequest body = null;
            //var response = instance.DisableFulfillmentSLARequestSLAsdisablePost(accept, body);
            //Assert.IsType<FulfillmentSLA>(response);
        }

        /// <summary>
        /// Test FindFulfillmentCompetitionsCountRequestcompetitionsScopeIdcountPost
        /// </summary>
        [Fact]
        public void FindFulfillmentCompetitionsCountRequestcompetitionsScopeIdcountPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string scopeId = null;
            //FindFulfillmentCompetitionsCountRequest body = null;
            //var response = instance.FindFulfillmentCompetitionsCountRequestcompetitionsScopeIdcountPost(accept, scopeId, body);
            //Assert.IsType<QueryCountResult>(response);
        }

        /// <summary>
        /// Test FindFulfillmentCompetitionsRequestcompetitionsScopeIdfindPost
        /// </summary>
        [Fact]
        public void FindFulfillmentCompetitionsRequestcompetitionsScopeIdfindPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string scopeId = null;
            //FindFulfillmentCompetitionsRequest body = null;
            //var response = instance.FindFulfillmentCompetitionsRequestcompetitionsScopeIdfindPost(accept, scopeId, body);
            //Assert.IsType<FulfillmentCompetitionQueryResult>(response);
        }

        /// <summary>
        /// Test FindFulfillmentManifestPackagesRequestpackagesScopeIdfindmanifestGet
        /// </summary>
        [Fact]
        public void FindFulfillmentManifestPackagesRequestpackagesScopeIdfindmanifestGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string scopeId = null;
            //string fulfillmentLocationId = null;
            //string shippingProviderId = null;
            //string fulfillmentStatus = null;
            //DateTime? manifestedFrom = null;
            //DateTime? manifestedTo = null;
            //string manifestReferenceId = null;
            //bool? includePackagesWithManifest = null;
            //bool? includePackagesWithoutManifest = null;
            //bool? includePackageItems = null;
            //string carrierAccountIdOutbound = null;
            //string carrierAccountNameOutbound = null;
            //string carrierNameOutbound = null;
            //string carrierServiceLevelOutbound = null;
            //string carrierManifestRequirement = null;
            //var response = instance.FindFulfillmentManifestPackagesRequestpackagesScopeIdfindmanifestGet(accept, scopeId, fulfillmentLocationId, shippingProviderId, fulfillmentStatus, manifestedFrom, manifestedTo, manifestReferenceId, includePackagesWithManifest, includePackagesWithoutManifest, includePackageItems, carrierAccountIdOutbound, carrierAccountNameOutbound, carrierNameOutbound, carrierServiceLevelOutbound, carrierManifestRequirement);
            //Assert.IsType<FulfillmentPackageResult>(response);
        }

        /// <summary>
        /// Test FindFulfillmentOrdersRequestordersScopeIdfindPost
        /// </summary>
        [Fact]
        public void FindFulfillmentOrdersRequestordersScopeIdfindPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string scopeId = null;
            //FindFulfillmentOrdersRequest body = null;
            //var response = instance.FindFulfillmentOrdersRequestordersScopeIdfindPost(accept, scopeId, body);
            //Assert.IsType<FulfillmentOrderQueryResult>(response);
        }

        /// <summary>
        /// Test FindFulfillmentPackageTypesRequestpackageTypesScopeIdfindPost
        /// </summary>
        [Fact]
        public void FindFulfillmentPackageTypesRequestpackageTypesScopeIdfindPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string scopeId = null;
            //FindFulfillmentPackageTypesRequest body = null;
            //var response = instance.FindFulfillmentPackageTypesRequestpackageTypesScopeIdfindPost(accept, scopeId, body);
            //Assert.IsType<FulfillmentPackageTypeResult>(response);
        }

        /// <summary>
        /// Test FindFulfillmentPackagesRequestpackagesScopeIdfindGet
        /// </summary>
        [Fact]
        public void FindFulfillmentPackagesRequestpackagesScopeIdfindGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string scopeId = null;
            //string orderId = null;
            //List<string> shipmentIds = null;
            //string cultureName = null;
            //bool? includeFulfillmentPackageType = null;
            //var response = instance.FindFulfillmentPackagesRequestpackagesScopeIdfindGet(accept, scopeId, orderId, shipmentIds, cultureName, includeFulfillmentPackageType);
            //Assert.IsType<FulfillmentPackageResult>(response);
        }

        /// <summary>
        /// Test FindFulfillmentSLARequestSLAsScopeIdfindPost
        /// </summary>
        [Fact]
        public void FindFulfillmentSLARequestSLAsScopeIdfindPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string scopeId = null;
            //FindFulfillmentSLARequest body = null;
            //var response = instance.FindFulfillmentSLARequestSLAsScopeIdfindPost(accept, scopeId, body);
            //Assert.IsType<FulfillmentSLAQueryResult>(response);
        }

        /// <summary>
        /// Test GetFulfillmentCarrierDocumentsRequestcarriersScopeIdFulfillmentCarrierIdquotesdocumentsPost
        /// </summary>
        [Fact]
        public void GetFulfillmentCarrierDocumentsRequestcarriersScopeIdFulfillmentCarrierIdquotesdocumentsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string scopeId = null;
            //string fulfillmentCarrierId = null;
            //GetFulfillmentCarrierDocumentsRequest body = null;
            //var response = instance.GetFulfillmentCarrierDocumentsRequestcarriersScopeIdFulfillmentCarrierIdquotesdocumentsPost(accept, scopeId, fulfillmentCarrierId, body);
            //Assert.IsType<GetFulfillmentCarrierDocumentsResponse>(response);
        }

        /// <summary>
        /// Test GetFulfillmentCarrierQuotesRequestcarriersScopeIdFulfillmentCarrierIdquotesPost
        /// </summary>
        [Fact]
        public void GetFulfillmentCarrierQuotesRequestcarriersScopeIdFulfillmentCarrierIdquotesPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string scopeId = null;
            //string fulfillmentCarrierId = null;
            //GetFulfillmentCarrierQuotesRequest body = null;
            //var response = instance.GetFulfillmentCarrierQuotesRequestcarriersScopeIdFulfillmentCarrierIdquotesPost(accept, scopeId, fulfillmentCarrierId, body);
            //Assert.IsType<GetFulfillmentCarrierQuotesResponse>(response);
        }

        /// <summary>
        /// Test GetFulfillmentCompetitionRequestcompetitionsScopeIdFulfillmentCompetitionIdGet
        /// </summary>
        [Fact]
        public void GetFulfillmentCompetitionRequestcompetitionsScopeIdFulfillmentCompetitionIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string scopeId = null;
            //string fulfillmentCompetitionId = null;
            //var response = instance.GetFulfillmentCompetitionRequestcompetitionsScopeIdFulfillmentCompetitionIdGet(accept, scopeId, fulfillmentCompetitionId);
            //Assert.IsType<FulfillmentCompetition>(response);
        }

        /// <summary>
        /// Test GetFulfillmentExceptionsRequestexceptionsScopeIdFulfillmentLocationIdOrderIdGet
        /// </summary>
        [Fact]
        public void GetFulfillmentExceptionsRequestexceptionsScopeIdFulfillmentLocationIdOrderIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string scopeId = null;
            //string fulfillmentLocationId = null;
            //string orderId = null;
            //var response = instance.GetFulfillmentExceptionsRequestexceptionsScopeIdFulfillmentLocationIdOrderIdGet(accept, scopeId, fulfillmentLocationId, orderId);
            //Assert.IsType<FulfillmentExceptionResult>(response);
        }

        /// <summary>
        /// Test GetFulfillmentPackageRequestpackagesScopeIdIdGet
        /// </summary>
        [Fact]
        public void GetFulfillmentPackageRequestpackagesScopeIdIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string scopeId = null;
            //string id = null;
            //string cultureName = null;
            //bool? includeFulfillmentPackageType = null;
            //var response = instance.GetFulfillmentPackageRequestpackagesScopeIdIdGet(accept, scopeId, id, cultureName, includeFulfillmentPackageType);
            //Assert.IsType<FulfillmentPackage>(response);
        }

        /// <summary>
        /// Test GetFulfillmentPackageTypeRequestpackageTypesScopeIdIdGet
        /// </summary>
        [Fact]
        public void GetFulfillmentPackageTypeRequestpackageTypesScopeIdIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string scopeId = null;
            //string id = null;
            //bool? includeParentScopes = null;
            //var response = instance.GetFulfillmentPackageTypeRequestpackageTypesScopeIdIdGet(accept, scopeId, id, includeParentScopes);
            //Assert.IsType<FulfillmentPackageType>(response);
        }

        /// <summary>
        /// Test GetFulfillmentSLARequestSLAsScopeIdIdGet
        /// </summary>
        [Fact]
        public void GetFulfillmentSLARequestSLAsScopeIdIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string scopeId = null;
            //string id = null;
            //var response = instance.GetFulfillmentSLARequestSLAsScopeIdIdGet(accept, scopeId, id);
            //Assert.IsType<FulfillmentSLA>(response);
        }

        /// <summary>
        /// Test RefundFulfillmentCarrierQuotesRequestcarriersScopeIdFulfillmentCarrierIdquotesrefundPost
        /// </summary>
        [Fact]
        public void RefundFulfillmentCarrierQuotesRequestcarriersScopeIdFulfillmentCarrierIdquotesrefundPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string scopeId = null;
            //string fulfillmentCarrierId = null;
            //RefundFulfillmentCarrierQuotesRequest body = null;
            //instance.RefundFulfillmentCarrierQuotesRequestcarriersScopeIdFulfillmentCarrierIdquotesrefundPost(accept, scopeId, fulfillmentCarrierId, body);
        }

        /// <summary>
        /// Test RemoveFulfillmentCompetitionLocationsRequestcompetitionsScopeIdFulfillmentCompetitionIdlocationsDelete
        /// </summary>
        [Fact]
        public void RemoveFulfillmentCompetitionLocationsRequestcompetitionsScopeIdFulfillmentCompetitionIdlocationsDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string scopeId = null;
            //string fulfillmentCompetitionId = null;
            //List<string> fulfillmentLocationIds = null;
            //var response = instance.RemoveFulfillmentCompetitionLocationsRequestcompetitionsScopeIdFulfillmentCompetitionIdlocationsDelete(accept, scopeId, fulfillmentCompetitionId, fulfillmentLocationIds);
            //Assert.IsType<FulfillmentCompetition>(response);
        }

        /// <summary>
        /// Test TransferFulfillmentPackageItemsRequestpackagesScopeIdtransferFulfillmentPackageItemsPost
        /// </summary>
        [Fact]
        public void TransferFulfillmentPackageItemsRequestpackagesScopeIdtransferFulfillmentPackageItemsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string scopeId = null;
            //TransferFulfillmentPackageItemsRequest body = null;
            //var response = instance.TransferFulfillmentPackageItemsRequestpackagesScopeIdtransferFulfillmentPackageItemsPost(accept, scopeId, body);
            //Assert.IsType<FulfillmentPackage>(response);
        }

        /// <summary>
        /// Test UpdateFulfillmentPackageRequestpackagesScopeIdIdCreate
        /// </summary>
        [Fact]
        public void UpdateFulfillmentPackageRequestpackagesScopeIdIdCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string scopeId = null;
            //string id = null;
            //UpdateFulfillmentPackageRequest body = null;
            //var response = instance.UpdateFulfillmentPackageRequestpackagesScopeIdIdCreate(accept, scopeId, id, body);
            //Assert.IsType<FulfillmentPackage>(response);
        }

        /// <summary>
        /// Test UpdateFulfillmentPackageTypeRequestpackageTypesScopeIdIdCreate
        /// </summary>
        [Fact]
        public void UpdateFulfillmentPackageTypeRequestpackageTypesScopeIdIdCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string scopeId = null;
            //string id = null;
            //UpdateFulfillmentPackageTypeRequest body = null;
            //var response = instance.UpdateFulfillmentPackageTypeRequestpackageTypesScopeIdIdCreate(accept, scopeId, id, body);
            //Assert.IsType<FulfillmentPackageType>(response);
        }
    }
}
