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
    ///  Class for testing UsersApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class UsersApiTests : IDisposable
    {
        private UsersApi instance;

        public UsersApiTests()
        {
            instance = new UsersApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of UsersApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' UsersApi
            //Assert.IsType<UsersApi>(instance);
        }

        /// <summary>
        /// Test ActivateUserRequestUserNameactivatePost
        /// </summary>
        [Fact]
        public void ActivateUserRequestUserNameactivatePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string userName = null;
            //Object body = null;
            //var response = instance.ActivateUserRequestUserNameactivatePost(accept, userName, body);
            //Assert.IsType<User>(response);
        }

        /// <summary>
        /// Test ActivateUsersRequestactivateCreate
        /// </summary>
        [Fact]
        public void ActivateUsersRequestactivateCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //ActivateUsersRequest body = null;
            //instance.ActivateUsersRequestactivateCreate(accept, body);
        }

        /// <summary>
        /// Test CreateUserRequestUserNamePost
        /// </summary>
        [Fact]
        public void CreateUserRequestUserNamePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string userName = null;
            //CreateUserRequest body = null;
            //var response = instance.CreateUserRequestUserNamePost(accept, userName, body);
            //Assert.IsType<User>(response);
        }

        /// <summary>
        /// Test DeactivateUserRequestUserNamedeactivatePost
        /// </summary>
        [Fact]
        public void DeactivateUserRequestUserNamedeactivatePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string userName = null;
            //Object body = null;
            //var response = instance.DeactivateUserRequestUserNamedeactivatePost(accept, userName, body);
            //Assert.IsType<User>(response);
        }

        /// <summary>
        /// Test DeactivateUsersRequestdesactivateCreate
        /// </summary>
        [Fact]
        public void DeactivateUsersRequestdesactivateCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //DeactivateUsersRequest body = null;
            //instance.DeactivateUsersRequestdesactivateCreate(accept, body);
        }

        /// <summary>
        /// Test DeleteUserRequestUserNameDelete
        /// </summary>
        [Fact]
        public void DeleteUserRequestUserNameDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string userName = null;
            //instance.DeleteUserRequestUserNameDelete(accept, userName);
        }

        /// <summary>
        /// Test FindUsersByNameRequestfindPost
        /// </summary>
        [Fact]
        public void FindUsersByNameRequestfindPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //FindUsersByNameRequest body = null;
            //var response = instance.FindUsersByNameRequestfindPost(accept, body);
            //Assert.IsType<FindUsersByNameResult>(response);
        }

        /// <summary>
        /// Test ForceChangeUserPasswordRequestUserNameforceChangePasswordPost
        /// </summary>
        [Fact]
        public void ForceChangeUserPasswordRequestUserNameforceChangePasswordPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string userName = null;
            //ForceChangeUserPasswordRequest body = null;
            //instance.ForceChangeUserPasswordRequestUserNameforceChangePasswordPost(accept, userName, body);
        }

        /// <summary>
        /// Test GetAvailableDomainsRequestdomainsGet
        /// </summary>
        [Fact]
        public void GetAvailableDomainsRequestdomainsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //var response = instance.GetAvailableDomainsRequestdomainsGet(accept);
            //Assert.IsType<List<string>>(response);
        }

        /// <summary>
        /// Test GetUserGroupsRequestUserNamegroupsGet
        /// </summary>
        [Fact]
        public void GetUserGroupsRequestUserNamegroupsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string userName = null;
            //var response = instance.GetUserGroupsRequestUserNamegroupsGet(accept, userName);
            //Assert.IsType<List<Group>>(response);
        }

        /// <summary>
        /// Test GetUserRequestUserNameGet
        /// </summary>
        [Fact]
        public void GetUserRequestUserNameGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string userName = null;
            //var response = instance.GetUserRequestUserNameGet(accept, userName);
            //Assert.IsType<User>(response);
        }

        /// <summary>
        /// Test ResetUserPasswordRequestUserNameresetUserPasswordCreate
        /// </summary>
        [Fact]
        public void ResetUserPasswordRequestUserNameresetUserPasswordCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string userName = null;
            //Object body = null;
            //var response = instance.ResetUserPasswordRequestUserNameresetUserPasswordCreate(accept, userName, body);
            //Assert.IsType<ResetUserPasswordResult>(response);
        }

        /// <summary>
        /// Test SaveUserRequestUserNameCreate
        /// </summary>
        [Fact]
        public void SaveUserRequestUserNameCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string userName = null;
            //SaveUserRequest body = null;
            //var response = instance.SaveUserRequestUserNameCreate(accept, userName, body);
            //Assert.IsType<User>(response);
        }
    }
}
