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
    ///  Class for testing GamificationLeaderboardsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class GamificationLeaderboardsApiTests
    {
        private GamificationLeaderboardsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new GamificationLeaderboardsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of GamificationLeaderboardsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' GamificationLeaderboardsApi
            //Assert.IsInstanceOfType(typeof(GamificationLeaderboardsApi), instance, "instance is a GamificationLeaderboardsApi");
        }

        
        /// <summary>
        /// Test GetLeaderboard
        /// </summary>
        [Test]
        public void GetLeaderboardTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string contextType = null;
            //string contextId = null;
            //int? size = null;
            //int? page = null;
            //string order = null;
            //var response = instance.GetLeaderboard(contextType, contextId, size, page, order);
            //Assert.IsInstanceOf<LeaderboardResource> (response, "response is LeaderboardResource");
        }
        
        /// <summary>
        /// Test GetLeaderboardRank
        /// </summary>
        [Test]
        public void GetLeaderboardRankTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string contextType = null;
            //string contextId = null;
            //string id = null;
            //var response = instance.GetLeaderboardRank(contextType, contextId, id);
            //Assert.IsInstanceOf<LeaderboardEntryResource> (response, "response is LeaderboardEntryResource");
        }
        
        /// <summary>
        /// Test GetLeaderboardStrategies
        /// </summary>
        [Test]
        public void GetLeaderboardStrategiesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetLeaderboardStrategies();
            //Assert.IsInstanceOf<List<string>> (response, "response is List<string>");
        }
        
    }

}
