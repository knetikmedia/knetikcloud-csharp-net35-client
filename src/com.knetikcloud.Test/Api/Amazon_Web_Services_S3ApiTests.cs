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
    ///  Class for testing Amazon_Web_Services_S3Api
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class Amazon_Web_Services_S3ApiTests
    {
        private Amazon_Web_Services_S3Api instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Amazon_Web_Services_S3Api();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Amazon_Web_Services_S3Api
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' Amazon_Web_Services_S3Api
            //Assert.IsInstanceOfType(typeof(Amazon_Web_Services_S3Api), instance, "instance is a Amazon_Web_Services_S3Api");
        }

        
        /// <summary>
        /// Test GetDownloadURL
        /// </summary>
        [Test]
        public void GetDownloadURLTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string bucket = null;
            //string path = null;
            //int? expiration = null;
            //var response = instance.GetDownloadURL(bucket, path, expiration);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test GetSignedS3URL
        /// </summary>
        [Test]
        public void GetSignedS3URLTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filename = null;
            //string contentType = null;
            //var response = instance.GetSignedS3URL(filename, contentType);
            //Assert.IsInstanceOf<AmazonS3Activity> (response, "response is AmazonS3Activity");
        }
        
    }

}