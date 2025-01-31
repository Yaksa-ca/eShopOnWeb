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
    ///  Class for testing TemplatesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class TemplatesApiTests : IDisposable
    {
        private TemplatesApi instance;

        public TemplatesApiTests()
        {
            instance = new TemplatesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TemplatesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' TemplatesApi
            //Assert.IsType<TemplatesApi>(instance);
        }

        /// <summary>
        /// Test CreateOrUpdateTemplateVariableRequestScopeIdVariablesNameCreate
        /// </summary>
        [Fact]
        public void CreateOrUpdateTemplateVariableRequestScopeIdVariablesNameCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string scopeId = null;
            //string name = null;
            //CreateOrUpdateTemplateVariableRequest body = null;
            //var response = instance.CreateOrUpdateTemplateVariableRequestScopeIdVariablesNameCreate(accept, scopeId, name, body);
            //Assert.IsType<TemplateVariable>(response);
        }

        /// <summary>
        /// Test CreateTemplateRequestScopeIdTypeNamePost
        /// </summary>
        [Fact]
        public void CreateTemplateRequestScopeIdTypeNamePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string scopeId = null;
            //string type = null;
            //string name = null;
            //CreateTemplateRequest body = null;
            //var response = instance.CreateTemplateRequestScopeIdTypeNamePost(accept, scopeId, type, name, body);
            //Assert.IsType<Template>(response);
        }

        /// <summary>
        /// Test DeleteTemplateRequestScopeIdTypeNameDelete
        /// </summary>
        [Fact]
        public void DeleteTemplateRequestScopeIdTypeNameDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string scopeId = null;
            //string type = null;
            //string name = null;
            //instance.DeleteTemplateRequestScopeIdTypeNameDelete(accept, scopeId, type, name);
        }

        /// <summary>
        /// Test DeleteTemplateVariableRequestScopeIdVariablesNameDelete
        /// </summary>
        [Fact]
        public void DeleteTemplateVariableRequestScopeIdVariablesNameDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string scopeId = null;
            //string name = null;
            //instance.DeleteTemplateVariableRequestScopeIdVariablesNameDelete(accept, scopeId, name);
        }

        /// <summary>
        /// Test GetTemplateByNameRequestScopeIdTypeNameGet
        /// </summary>
        [Fact]
        public void GetTemplateByNameRequestScopeIdTypeNameGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string scopeId = null;
            //string type = null;
            //string name = null;
            //bool? includeContents = null;
            //List<string> cultures = null;
            //bool? activeOnly = null;
            //bool? replaceTemplateVariables = null;
            //var response = instance.GetTemplateByNameRequestScopeIdTypeNameGet(accept, scopeId, type, name, includeContents, cultures, activeOnly, replaceTemplateVariables);
            //Assert.IsType<Template>(response);
        }

        /// <summary>
        /// Test GetTemplateVariablesRequestScopeIdVariablesGet
        /// </summary>
        [Fact]
        public void GetTemplateVariablesRequestScopeIdVariablesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string scopeId = null;
            //var response = instance.GetTemplateVariablesRequestScopeIdVariablesGet(accept, scopeId);
            //Assert.IsType<List<TemplateVariable>>(response);
        }

        /// <summary>
        /// Test GetTemplatesRequestScopeIdTypeGet
        /// </summary>
        [Fact]
        public void GetTemplatesRequestScopeIdTypeGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string scopeId = null;
            //string type = null;
            //bool? includeContents = null;
            //bool? activeOnly = null;
            //List<string> cultures = null;
            //bool? replaceTemplateVariables = null;
            //var response = instance.GetTemplatesRequestScopeIdTypeGet(accept, scopeId, type, includeContents, activeOnly, cultures, replaceTemplateVariables);
            //Assert.IsType<List<Template>>(response);
        }

        /// <summary>
        /// Test UpdateTemplateRequestScopeIdTypeNameCultureCreate
        /// </summary>
        [Fact]
        public void UpdateTemplateRequestScopeIdTypeNameCultureCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string scopeId = null;
            //string type = null;
            //string name = null;
            //string culture = null;
            //UpdateTemplateRequest body = null;
            //var response = instance.UpdateTemplateRequestScopeIdTypeNameCultureCreate(accept, scopeId, type, name, culture, body);
            //Assert.IsType<Template>(response);
        }
    }
}
