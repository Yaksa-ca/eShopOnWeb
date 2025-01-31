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
    ///  Class for testing IntegrationApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class IntegrationApiTests : IDisposable
    {
        private IntegrationApi instance;

        public IntegrationApiTests()
        {
            instance = new IntegrationApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of IntegrationApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' IntegrationApi
            //Assert.IsType<IntegrationApi>(instance);
        }

        /// <summary>
        /// Test ExportOrderSchemaRequestordersschemaexportPost
        /// </summary>
        [Fact]
        public void ExportOrderSchemaRequestordersschemaexportPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //ExportOrderSchemaRequest body = null;
            //var response = instance.ExportOrderSchemaRequestordersschemaexportPost(accept, body);
            //Assert.IsType<TaskInfo>(response);
        }

        /// <summary>
        /// Test ExportProductPricesRequestproductsScopeIdpricesexportPost
        /// </summary>
        [Fact]
        public void ExportProductPricesRequestproductsScopeIdpricesexportPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string scopeId = null;
            //ExportProductPricesRequest body = null;
            //var response = instance.ExportProductPricesRequestproductsScopeIdpricesexportPost(accept, scopeId, body);
            //Assert.IsType<List<ProductPriceExportInfo>>(response);
        }

        /// <summary>
        /// Test ExportProductsRequestproductsScopeIdexportPost
        /// </summary>
        [Fact]
        public void ExportProductsRequestproductsScopeIdexportPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string scopeId = null;
            //ExportProductsRequest body = null;
            //var response = instance.ExportProductsRequestproductsScopeIdexportPost(accept, scopeId, body);
            //Assert.IsType<TaskInfo>(response);
        }

        /// <summary>
        /// Test ExportProfileSchemaRequestprofilesschemaexportPost
        /// </summary>
        [Fact]
        public void ExportProfileSchemaRequestprofilesschemaexportPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //ExportProfileSchemaRequest body = null;
            //var response = instance.ExportProfileSchemaRequestprofilesschemaexportPost(accept, body);
            //Assert.IsType<TaskInfo>(response);
        }

        /// <summary>
        /// Test ExportProfilesRequestprofilesexportPost
        /// </summary>
        [Fact]
        public void ExportProfilesRequestprofilesexportPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //ExportProfilesRequest body = null;
            //var response = instance.ExportProfilesRequestprofilesexportPost(accept, body);
            //Assert.IsType<TaskInfo>(response);
        }

        /// <summary>
        /// Test ImportInventoryItemsRequestinventoryItemsimportPost
        /// </summary>
        [Fact]
        public void ImportInventoryItemsRequestinventoryItemsimportPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //ImportInventoryItemsRequest body = null;
            //var response = instance.ImportInventoryItemsRequestinventoryItemsimportPost(accept, body);
            //Assert.IsType<TaskInfo>(response);
        }

        /// <summary>
        /// Test ImportOrderSchemaRequestordersschemaimportPost
        /// </summary>
        [Fact]
        public void ImportOrderSchemaRequestordersschemaimportPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //ImportOrderSchemaRequest body = null;
            //var response = instance.ImportOrderSchemaRequestordersschemaimportPost(accept, body);
            //Assert.IsType<TaskInfo>(response);
        }

        /// <summary>
        /// Test ImportOrdersRequestordersimportPost
        /// </summary>
        [Fact]
        public void ImportOrdersRequestordersimportPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //ImportOrdersRequest body = null;
            //var response = instance.ImportOrdersRequestordersimportPost(accept, body);
            //Assert.IsType<TaskInfo>(response);
        }

        /// <summary>
        /// Test ImportProductsPricesRequestproductsScopeIdpricesimportPost
        /// </summary>
        [Fact]
        public void ImportProductsPricesRequestproductsScopeIdpricesimportPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string scopeId = null;
            //ImportProductsPricesRequest body = null;
            //var response = instance.ImportProductsPricesRequestproductsScopeIdpricesimportPost(accept, scopeId, body);
            //Assert.IsType<TaskInfo>(response);
        }

        /// <summary>
        /// Test ImportProductsRequestproductsScopeIdimportPost
        /// </summary>
        [Fact]
        public void ImportProductsRequestproductsScopeIdimportPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string scopeId = null;
            //ImportProductsRequest body = null;
            //var response = instance.ImportProductsRequestproductsScopeIdimportPost(accept, scopeId, body);
            //Assert.IsType<TaskInfo>(response);
        }

        /// <summary>
        /// Test ImportProfileSchemaRequestprofilesschemaimportPost
        /// </summary>
        [Fact]
        public void ImportProfileSchemaRequestprofilesschemaimportPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //ImportProfileSchemaRequest body = null;
            //var response = instance.ImportProfileSchemaRequestprofilesschemaimportPost(accept, body);
            //Assert.IsType<TaskInfo>(response);
        }

        /// <summary>
        /// Test ImportProfilesRequestprofilesimportPost
        /// </summary>
        [Fact]
        public void ImportProfilesRequestprofilesimportPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //ImportProfilesRequest body = null;
            //var response = instance.ImportProfilesRequestprofilesimportPost(accept, body);
            //Assert.IsType<TaskInfo>(response);
        }
    }
}
