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
    ///  Class for testing SearchApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class SearchApiTests : IDisposable
    {
        private SearchApi instance;

        public SearchApiTests()
        {
            instance = new SearchApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SearchApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' SearchApi
            //Assert.IsType<SearchApi>(instance);
        }

        /// <summary>
        /// Test AddOrUpdateVariantSearchConfigurationRequestScopeIdconfigurationsvariantCreate
        /// </summary>
        [Fact]
        public void AddOrUpdateVariantSearchConfigurationRequestScopeIdconfigurationsvariantCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string scopeId = null;
            //AddOrUpdateVariantSearchConfigurationRequest body = null;
            //var response = instance.AddOrUpdateVariantSearchConfigurationRequestScopeIdconfigurationsvariantCreate(accept, scopeId, body);
            //Assert.IsType<string>(response);
        }

        /// <summary>
        /// Test AdvancedSearchRequestScopeIdCultureNameadvancedIndexNamePost
        /// </summary>
        [Fact]
        public void AdvancedSearchRequestScopeIdCultureNameadvancedIndexNamePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string scopeId = null;
            //string cultureName = null;
            //string indexName = null;
            //AdvancedSearchRequest body = null;
            //var response = instance.AdvancedSearchRequestScopeIdCultureNameadvancedIndexNamePost(accept, scopeId, cultureName, indexName, body);
            //Assert.IsType<SearchResult>(response);
        }

        /// <summary>
        /// Test GetVariantSearchConfigurationsRequestScopeIdconfigurationsvariantGet
        /// </summary>
        [Fact]
        public void GetVariantSearchConfigurationsRequestScopeIdconfigurationsvariantGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string scopeId = null;
            //var response = instance.GetVariantSearchConfigurationsRequestScopeIdconfigurationsvariantGet(accept, scopeId);
            //Assert.IsType<List<VariantSearchConfiguration>>(response);
        }

        /// <summary>
        /// Test IndexCustomersRequestindexescustomersCreate
        /// </summary>
        [Fact]
        public void IndexCustomersRequestindexescustomersCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //IndexCustomersRequest body = null;
            //var response = instance.IndexCustomersRequestindexescustomersCreate(accept, body);
            //Assert.IsType<List<TaskInfo>>(response);
        }

        /// <summary>
        /// Test IndexInventoriesRequestindexesinventoriesCreate
        /// </summary>
        [Fact]
        public void IndexInventoriesRequestindexesinventoriesCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //IndexInventoriesRequest body = null;
            //var response = instance.IndexInventoriesRequestindexesinventoriesCreate(accept, body);
            //Assert.IsType<List<TaskInfo>>(response);
        }

        /// <summary>
        /// Test IndexProductsRequestindexesproductsCreate
        /// </summary>
        [Fact]
        public void IndexProductsRequestindexesproductsCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //IndexProductsRequest body = null;
            //var response = instance.IndexProductsRequestindexesproductsCreate(accept, body);
            //Assert.IsType<List<TaskInfo>>(response);
        }

        /// <summary>
        /// Test IndexStoresRequestindexesstoresCreate
        /// </summary>
        [Fact]
        public void IndexStoresRequestindexesstoresCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //IndexStoresRequest body = null;
            //var response = instance.IndexStoresRequestindexesstoresCreate(accept, body);
            //Assert.IsType<List<TaskInfo>>(response);
        }

        /// <summary>
        /// Test SearchAvailableProductsByCategoryRequestScopeIdCultureNameavailableProductsbyCategoryCategoryNamePost
        /// </summary>
        [Fact]
        public void SearchAvailableProductsByCategoryRequestScopeIdCultureNameavailableProductsbyCategoryCategoryNamePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string scopeId = null;
            //string cultureName = null;
            //string categoryName = null;
            //SearchAvailableProductsByCategoryRequest body = null;
            //var response = instance.SearchAvailableProductsByCategoryRequestScopeIdCultureNameavailableProductsbyCategoryCategoryNamePost(accept, scopeId, cultureName, categoryName, body);
            //Assert.IsType<SearchAvailableProductsByCategoryResponse>(response);
        }

        /// <summary>
        /// Test SearchAvailableProductsRequestScopeIdCultureNameavailableProductsPost
        /// </summary>
        [Fact]
        public void SearchAvailableProductsRequestScopeIdCultureNameavailableProductsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string scopeId = null;
            //string cultureName = null;
            //SearchAvailableProductsRequest body = null;
            //var response = instance.SearchAvailableProductsRequestScopeIdCultureNameavailableProductsPost(accept, scopeId, cultureName, body);
            //Assert.IsType<ProductSearchResult>(response);
        }

        /// <summary>
        /// Test SearchBySearchQueryRequestScopeIdCultureNamebySearchQueryQueryTypeQueryNamePost
        /// </summary>
        [Fact]
        public void SearchBySearchQueryRequestScopeIdCultureNamebySearchQueryQueryTypeQueryNamePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string scopeId = null;
            //string cultureName = null;
            //string queryType = null;
            //string queryName = null;
            //SearchBySearchQueryRequest body = null;
            //var response = instance.SearchBySearchQueryRequestScopeIdCultureNamebySearchQueryQueryTypeQueryNamePost(accept, scopeId, cultureName, queryType, queryName, body);
            //Assert.IsType<SearchQueryResult>(response);
        }

        /// <summary>
        /// Test SearchCustomersRequestScopeIdCultureNamecustomersPost
        /// </summary>
        [Fact]
        public void SearchCustomersRequestScopeIdCultureNamecustomersPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string scopeId = null;
            //string cultureName = null;
            //SearchCustomersRequest body = null;
            //var response = instance.SearchCustomersRequestScopeIdCultureNamecustomersPost(accept, scopeId, cultureName, body);
            //Assert.IsType<SearchResult>(response);
        }

        /// <summary>
        /// Test SearchProductByIdsRequestScopeIdCultureNameproductsbyIdsPost
        /// </summary>
        [Fact]
        public void SearchProductByIdsRequestScopeIdCultureNameproductsbyIdsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string scopeId = null;
            //string cultureName = null;
            //SearchProductByIdsRequest body = null;
            //var response = instance.SearchProductByIdsRequestScopeIdCultureNameproductsbyIdsPost(accept, scopeId, cultureName, body);
            //Assert.IsType<SearchResult>(response);
        }

        /// <summary>
        /// Test SearchProductBySavedQueryRequestScopeIdCultureNameproductsbySavedQueryQueryIdPost
        /// </summary>
        [Fact]
        public void SearchProductBySavedQueryRequestScopeIdCultureNameproductsbySavedQueryQueryIdPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string scopeId = null;
            //string cultureName = null;
            //string queryId = null;
            //SearchProductBySavedQueryRequest body = null;
            //var response = instance.SearchProductBySavedQueryRequestScopeIdCultureNameproductsbySavedQueryQueryIdPost(accept, scopeId, cultureName, queryId, body);
            //Assert.IsType<SearchResult>(response);
        }

        /// <summary>
        /// Test SearchProductRequestScopeIdCultureNameproductsPost
        /// </summary>
        [Fact]
        public void SearchProductRequestScopeIdCultureNameproductsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string scopeId = null;
            //string cultureName = null;
            //SearchProductRequest body = null;
            //var response = instance.SearchProductRequestScopeIdCultureNameproductsPost(accept, scopeId, cultureName, body);
            //Assert.IsType<SearchResult>(response);
        }

        /// <summary>
        /// Test SearchSimilarProductsRequestScopeIdCultureNameproductssimilarProductIdPost
        /// </summary>
        [Fact]
        public void SearchSimilarProductsRequestScopeIdCultureNameproductssimilarProductIdPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string scopeId = null;
            //string cultureName = null;
            //string productId = null;
            //SearchSimilarProductsRequest body = null;
            //var response = instance.SearchSimilarProductsRequestScopeIdCultureNameproductssimilarProductIdPost(accept, scopeId, cultureName, productId, body);
            //Assert.IsType<SearchResult>(response);
        }
    }
}
