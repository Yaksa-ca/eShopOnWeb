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
    ///  Class for testing ReportingApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ReportingApiTests : IDisposable
    {
        private ReportingApi instance;

        public ReportingApiTests()
        {
            instance = new ReportingApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ReportingApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ReportingApi
            //Assert.IsType<ReportingApi>(instance);
        }

        /// <summary>
        /// Test CreateSsrsReportPreviewRequestssrsreportsReportIdpreviewsPost
        /// </summary>
        [Fact]
        public void CreateSsrsReportPreviewRequestssrsreportsReportIdpreviewsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string reportId = null;
            //CreateSsrsReportPreviewRequest body = null;
            //var response = instance.CreateSsrsReportPreviewRequestssrsreportsReportIdpreviewsPost(accept, reportId, body);
            //Assert.IsType<ReportPreview>(response);
        }

        /// <summary>
        /// Test ExportSsrsReportRequestssrsreportsReportIdexportPost
        /// </summary>
        [Fact]
        public void ExportSsrsReportRequestssrsreportsReportIdexportPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string reportId = null;
            //ExportSsrsReportRequest body = null;
            //var response = instance.ExportSsrsReportRequestssrsreportsReportIdexportPost(accept, reportId, body);
            //Assert.IsType<TaskInfo>(response);
        }

        /// <summary>
        /// Test GetSsrsRenderingFormatsRequestssrsreportsrenderingformatsGet
        /// </summary>
        [Fact]
        public void GetSsrsRenderingFormatsRequestssrsreportsrenderingformatsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string cultureName = null;
            //var response = instance.GetSsrsRenderingFormatsRequestssrsreportsrenderingformatsGet(accept, cultureName);
            //Assert.IsType<List<string>>(response);
        }

        /// <summary>
        /// Test GetSsrsReportParametersRequestssrsreportsReportIdparametersPost
        /// </summary>
        [Fact]
        public void GetSsrsReportParametersRequestssrsreportsReportIdparametersPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string reportId = null;
            //GetSsrsReportParametersRequest body = null;
            //var response = instance.GetSsrsReportParametersRequestssrsreportsReportIdparametersPost(accept, reportId, body);
            //Assert.IsType<List<ReportParameter>>(response);
        }

        /// <summary>
        /// Test GetSsrsReportsRequestssrsreportsGet
        /// </summary>
        [Fact]
        public void GetSsrsReportsRequestssrsreportsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string cultureName = null;
            //string scopeId = null;
            //var response = instance.GetSsrsReportsRequestssrsreportsGet(accept, cultureName, scopeId);
            //Assert.IsType<List<Report>>(response);
        }
    }
}
