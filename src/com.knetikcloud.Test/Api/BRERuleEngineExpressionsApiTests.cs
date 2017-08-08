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
    ///  Class for testing BRERuleEngineExpressionsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class BRERuleEngineExpressionsApiTests
    {
        private BRERuleEngineExpressionsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new BRERuleEngineExpressionsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of BRERuleEngineExpressionsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' BRERuleEngineExpressionsApi
            //Assert.IsInstanceOfType(typeof(BRERuleEngineExpressionsApi), instance, "instance is a BRERuleEngineExpressionsApi");
        }

        
        /// <summary>
        /// Test GetBREExpressions
        /// </summary>
        [Test]
        public void GetBREExpressionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetBREExpressions();
            //Assert.IsInstanceOf<List<LookupTypeResource>> (response, "response is List<LookupTypeResource>");
        }
        
    }

}