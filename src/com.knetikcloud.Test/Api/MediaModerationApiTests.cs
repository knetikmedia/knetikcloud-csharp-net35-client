/* 
 * Knetik Platform API Documentation latest 
 *
 * This is the spec for the Knetik API.  Use this in conjunction with the documentation found at https://knetikcloud.com.
 *
 * OpenAPI spec version: latest 
 * Contact: support@knetik.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using com.knetikcloud.Client;
using com.knetikcloud.Api;
using com.knetikcloud.Model;

namespace com.knetikcloud.Test
{
    /// <summary>
    ///  Class for testing MediaModerationApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class MediaModerationApiTests
    {
        private MediaModerationApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new MediaModerationApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of MediaModerationApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' MediaModerationApi
            //Assert.IsInstanceOfType(typeof(MediaModerationApi), instance, "instance is a MediaModerationApi");
        }

        
        /// <summary>
        /// Test AddFlag
        /// </summary>
        [Test]
        public void AddFlagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //FlagResource flagResource = null;
            //var response = instance.AddFlag(flagResource);
            //Assert.IsInstanceOf<FlagResource> (response, "response is FlagResource");
        }
        
        /// <summary>
        /// Test DeleteFlag
        /// </summary>
        [Test]
        public void DeleteFlagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string contextName = null;
            //string contextId = null;
            //int? userId = null;
            //instance.DeleteFlag(contextName, contextId, userId);
            
        }
        
        /// <summary>
        /// Test GetFlags
        /// </summary>
        [Test]
        public void GetFlagsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filterContext = null;
            //string filterContextId = null;
            //int? filterUserId = null;
            //int? size = null;
            //int? page = null;
            //var response = instance.GetFlags(filterContext, filterContextId, filterUserId, size, page);
            //Assert.IsInstanceOf<PageResourceFlagResource> (response, "response is PageResourceFlagResource");
        }
        
        /// <summary>
        /// Test GetModerationReport
        /// </summary>
        [Test]
        public void GetModerationReportTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //var response = instance.GetModerationReport(id);
            //Assert.IsInstanceOf<FlagReportResource> (response, "response is FlagReportResource");
        }
        
        /// <summary>
        /// Test GetModerationReports
        /// </summary>
        [Test]
        public void GetModerationReportsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? excludeResolved = null;
            //string filterContext = null;
            //string filterContextId = null;
            //int? size = null;
            //int? page = null;
            //var response = instance.GetModerationReports(excludeResolved, filterContext, filterContextId, size, page);
            //Assert.IsInstanceOf<PageResourceFlagReportResource> (response, "response is PageResourceFlagReportResource");
        }
        
        /// <summary>
        /// Test UpdateModerationReport
        /// </summary>
        [Test]
        public void UpdateModerationReportTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //FlagReportResource flagReportResource = null;
            //instance.UpdateModerationReport(id, flagReportResource);
            
        }
        
    }

}
