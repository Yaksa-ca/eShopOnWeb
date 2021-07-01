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
    ///  Class for testing CouponsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class CouponsApiTests : IDisposable
    {
        private CouponsApi instance;

        public CouponsApiTests()
        {
            instance = new CouponsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CouponsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' CouponsApi
            //Assert.IsType<CouponsApi>(instance);
        }

        /// <summary>
        /// Test ConsumeCouponByCodeRequestconsumecodePost
        /// </summary>
        [Fact]
        public void ConsumeCouponByCodeRequestconsumecodePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //ConsumeCouponByCodeRequest body = null;
            //instance.ConsumeCouponByCodeRequestconsumecodePost(accept, body);
        }

        /// <summary>
        /// Test ConsumeCouponRequestconsumePost
        /// </summary>
        [Fact]
        public void ConsumeCouponRequestconsumePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //ConsumeCouponRequest body = null;
            //instance.ConsumeCouponRequestconsumePost(accept, body);
        }

        /// <summary>
        /// Test DeleteCouponByCodeRequestdeletecodeDelete
        /// </summary>
        [Fact]
        public void DeleteCouponByCodeRequestdeletecodeDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string couponCode = null;
            //bool? force = null;
            //var response = instance.DeleteCouponByCodeRequestdeletecodeDelete(accept, couponCode, force);
            //Assert.IsType<DeleteCouponResult>(response);
        }

        /// <summary>
        /// Test GetCouponRequestCouponCodeGet
        /// </summary>
        [Fact]
        public void GetCouponRequestCouponCodeGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string couponCode = null;
            //var response = instance.GetCouponRequestCouponCodeGet(accept, couponCode);
            //Assert.IsType<Coupon>(response);
        }

        /// <summary>
        /// Test GetCouponsRequestvalidatesCustomerIdPost
        /// </summary>
        [Fact]
        public void GetCouponsRequestvalidatesCustomerIdPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string customerId = null;
            //GetCouponsRequest body = null;
            //var response = instance.GetCouponsRequestvalidatesCustomerIdPost(accept, customerId, body);
            //Assert.IsType<List<Coupon>>(response);
        }

        /// <summary>
        /// Test LiberateCouponRequestliberatePost
        /// </summary>
        [Fact]
        public void LiberateCouponRequestliberatePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //LiberateCouponRequest body = null;
            //instance.LiberateCouponRequestliberatePost(accept, body);
        }
    }
}
