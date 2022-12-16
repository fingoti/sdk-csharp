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
    ///  Class for testing WebhookApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class WebhookApiTests : IDisposable
    {
        private WebhookApi instance;

        public WebhookApiTests()
        {
            instance = new WebhookApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of WebhookApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' WebhookApi
            //Assert.IsType<WebhookApi>(instance);
        }

        /// <summary>
        /// Test DeleteWebhookId
        /// </summary>
        [Fact]
        public void DeleteWebhookIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //var response = instance.DeleteWebhookId(id);
            //Assert.IsType<Default>(response);
        }

        /// <summary>
        /// Test GetWebhook
        /// </summary>
        [Fact]
        public void GetWebhookTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? pageNumber = null;
            //int? itemsPerPage = null;
            //string? webhookNumber = null;
            //string? property = null;
            //var response = instance.GetWebhook(pageNumber, itemsPerPage, webhookNumber, property);
            //Assert.IsType<EngineWebhooksResponse>(response);
        }

        /// <summary>
        /// Test GetWebhookId
        /// </summary>
        [Fact]
        public void GetWebhookIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //int? pageNumber = null;
            //int? itemsPerPage = null;
            //List<int>? status = null;
            //var response = instance.GetWebhookId(id, pageNumber, itemsPerPage, status);
            //Assert.IsType<EngineWebhookResponse>(response);
        }

        /// <summary>
        /// Test GetWebhookLogs
        /// </summary>
        [Fact]
        public void GetWebhookLogsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? pageNumber = null;
            //int? itemsPerPage = null;
            //List<int>? status = null;
            //string? webhookNumber = null;
            //var response = instance.GetWebhookLogs(pageNumber, itemsPerPage, status, webhookNumber);
            //Assert.IsType<WebhookLogsResponse>(response);
        }

        /// <summary>
        /// Test PatchWebhookId
        /// </summary>
        [Fact]
        public void PatchWebhookIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //PatchWebhookRequest? patchWebhookRequest = null;
            //var response = instance.PatchWebhookId(id, patchWebhookRequest);
            //Assert.IsType<Default>(response);
        }

        /// <summary>
        /// Test PostWebhook
        /// </summary>
        [Fact]
        public void PostWebhookTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AddWebhookDto? addWebhookDto = null;
            //var response = instance.PostWebhook(addWebhookDto);
            //Assert.IsType<AddWebhookResult>(response);
        }

        /// <summary>
        /// Test PostWebhookRetry
        /// </summary>
        [Fact]
        public void PostWebhookRetryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //WebhookRetryRequest? webhookRetryRequest = null;
            //var response = instance.PostWebhookRetry(webhookRetryRequest);
            //Assert.IsType<Default>(response);
        }
    }
}
