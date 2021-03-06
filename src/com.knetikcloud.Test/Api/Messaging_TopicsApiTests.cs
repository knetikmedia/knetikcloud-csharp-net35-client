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
    ///  Class for testing Messaging_TopicsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class Messaging_TopicsApiTests
    {
        private Messaging_TopicsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Messaging_TopicsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Messaging_TopicsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' Messaging_TopicsApi
            //Assert.IsInstanceOfType(typeof(Messaging_TopicsApi), instance, "instance is a Messaging_TopicsApi");
        }

        
        /// <summary>
        /// Test DisableTopicSubscriber
        /// </summary>
        [Test]
        public void DisableTopicSubscriberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string userId = null;
            //ValueWrapperboolean disabled = null;
            //instance.DisableTopicSubscriber(id, userId, disabled);
            
        }
        
        /// <summary>
        /// Test GetTopicSubscriber
        /// </summary>
        [Test]
        public void GetTopicSubscriberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string userId = null;
            //var response = instance.GetTopicSubscriber(id, userId);
            //Assert.IsInstanceOf<TopicSubscriberResource> (response, "response is TopicSubscriberResource");
        }
        
        /// <summary>
        /// Test GetUserTopics
        /// </summary>
        [Test]
        public void GetUserTopicsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetUserTopics(id);
            //Assert.IsInstanceOf<PageResourceTopicResource> (response, "response is PageResourceTopicResource");
        }
        
    }

}
