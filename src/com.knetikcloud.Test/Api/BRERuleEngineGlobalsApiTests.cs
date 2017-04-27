/* 
 * Knetik Platform API Documentation latest 
 *
 * This is the spec for the Knetik API.  Use this in conjunction with the documentation found at https://knetikcloud.com
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
    ///  Class for testing BRERuleEngineGlobalsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class BRERuleEngineGlobalsApiTests
    {
        private BRERuleEngineGlobalsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new BRERuleEngineGlobalsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of BRERuleEngineGlobalsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' BRERuleEngineGlobalsApi
            //Assert.IsInstanceOfType(typeof(BRERuleEngineGlobalsApi), instance, "instance is a BRERuleEngineGlobalsApi");
        }

        
        /// <summary>
        /// Test CreateBREGlobal
        /// </summary>
        [Test]
        public void CreateBREGlobalTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BreGlobalResource breGlobalResource = null;
            //var response = instance.CreateBREGlobal(breGlobalResource);
            //Assert.IsInstanceOf<BreGlobalResource> (response, "response is BreGlobalResource");
        }
        
        /// <summary>
        /// Test DeleteBREGlobal
        /// </summary>
        [Test]
        public void DeleteBREGlobalTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.DeleteBREGlobal(id);
            
        }
        
        /// <summary>
        /// Test GetBREGlobal
        /// </summary>
        [Test]
        public void GetBREGlobalTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetBREGlobal(id);
            //Assert.IsInstanceOf<BreGlobalResource> (response, "response is BreGlobalResource");
        }
        
        /// <summary>
        /// Test GetBREGlobals
        /// </summary>
        [Test]
        public void GetBREGlobalsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? filterSystem = null;
            //int? size = null;
            //int? page = null;
            //var response = instance.GetBREGlobals(filterSystem, size, page);
            //Assert.IsInstanceOf<PageResourceBreGlobalResource> (response, "response is PageResourceBreGlobalResource");
        }
        
        /// <summary>
        /// Test UpdateBREGlobal
        /// </summary>
        [Test]
        public void UpdateBREGlobalTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //BreGlobalResource breGlobalResource = null;
            //var response = instance.UpdateBREGlobal(id, breGlobalResource);
            //Assert.IsInstanceOf<BreGlobalResource> (response, "response is BreGlobalResource");
        }
        
    }

}
