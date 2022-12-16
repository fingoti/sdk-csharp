/*
 * Fingoti API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1
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

using Fingoti.Client;
using Fingoti.Api;
// uncomment below to import models
//using Fingoti.Model;

namespace Fingoti.Test.Api
{
    /// <summary>
    ///  Class for testing FollowingsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class FollowingsApiTests : IDisposable
    {
        private FollowingsApi instance;

        public FollowingsApiTests()
        {
            instance = new FollowingsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of FollowingsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' FollowingsApi
            //Assert.IsType<FollowingsApi>(instance);
        }

        /// <summary>
        /// Test DeleteFollowingsId
        /// </summary>
        [Fact]
        public void DeleteFollowingsIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //var response = instance.DeleteFollowingsId(id);
            //Assert.IsType<Default>(response);
        }

        /// <summary>
        /// Test GetFollowings
        /// </summary>
        [Fact]
        public void GetFollowingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? pageNumber = null;
            //int? itemsPerPage = null;
            //string? followName = null;
            //string? source = null;
            //string? destination = null;
            //var response = instance.GetFollowings(pageNumber, itemsPerPage, followName, source, destination);
            //Assert.IsType<OrganisationFollowingResponse>(response);
        }

        /// <summary>
        /// Test GetFollowingsId
        /// </summary>
        [Fact]
        public void GetFollowingsIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //var response = instance.GetFollowingsId(id);
            //Assert.IsType<OrganisationFollowingResponse>(response);
        }

        /// <summary>
        /// Test PatchFollowingsId
        /// </summary>
        [Fact]
        public void PatchFollowingsIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //PatchFollowRequest? patchFollowRequest = null;
            //var response = instance.PatchFollowingsId(id, patchFollowRequest);
            //Assert.IsType<Default>(response);
        }

        /// <summary>
        /// Test PostFollowings
        /// </summary>
        [Fact]
        public void PostFollowingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AddFollowDto? addFollowDto = null;
            //var response = instance.PostFollowings(addFollowDto);
            //Assert.IsType<DefaultWithId>(response);
        }
    }
}