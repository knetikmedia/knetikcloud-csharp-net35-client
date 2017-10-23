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
    ///  Class for testing ContentPollsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ContentPollsApiTests
    {
        private ContentPollsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ContentPollsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ContentPollsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ContentPollsApi
            //Assert.IsInstanceOfType(typeof(ContentPollsApi), instance, "instance is a ContentPollsApi");
        }

        
        /// <summary>
        /// Test AnswerPoll
        /// </summary>
        [Test]
        public void AnswerPollTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //StringWrapper answerKey = null;
            //var response = instance.AnswerPoll(id, answerKey);
            //Assert.IsInstanceOf<PollResponseResource> (response, "response is PollResponseResource");
        }
        
        /// <summary>
        /// Test CreatePoll
        /// </summary>
        [Test]
        public void CreatePollTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PollResource pollResource = null;
            //var response = instance.CreatePoll(pollResource);
            //Assert.IsInstanceOf<PollResource> (response, "response is PollResource");
        }
        
        /// <summary>
        /// Test CreatePollTemplate
        /// </summary>
        [Test]
        public void CreatePollTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TemplateResource pollTemplateResource = null;
            //var response = instance.CreatePollTemplate(pollTemplateResource);
            //Assert.IsInstanceOf<TemplateResource> (response, "response is TemplateResource");
        }
        
        /// <summary>
        /// Test DeletePoll
        /// </summary>
        [Test]
        public void DeletePollTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.DeletePoll(id);
            
        }
        
        /// <summary>
        /// Test DeletePollTemplate
        /// </summary>
        [Test]
        public void DeletePollTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string cascade = null;
            //instance.DeletePollTemplate(id, cascade);
            
        }
        
        /// <summary>
        /// Test GetPoll
        /// </summary>
        [Test]
        public void GetPollTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetPoll(id);
            //Assert.IsInstanceOf<PollResource> (response, "response is PollResource");
        }
        
        /// <summary>
        /// Test GetPollAnswer
        /// </summary>
        [Test]
        public void GetPollAnswerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetPollAnswer(id);
            //Assert.IsInstanceOf<PollResponseResource> (response, "response is PollResponseResource");
        }
        
        /// <summary>
        /// Test GetPollTemplate
        /// </summary>
        [Test]
        public void GetPollTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetPollTemplate(id);
            //Assert.IsInstanceOf<TemplateResource> (response, "response is TemplateResource");
        }
        
        /// <summary>
        /// Test GetPollTemplates
        /// </summary>
        [Test]
        public void GetPollTemplatesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? size = null;
            //int? page = null;
            //string order = null;
            //var response = instance.GetPollTemplates(size, page, order);
            //Assert.IsInstanceOf<PageResourceTemplateResource> (response, "response is PageResourceTemplateResource");
        }
        
        /// <summary>
        /// Test GetPolls
        /// </summary>
        [Test]
        public void GetPollsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filterCategory = null;
            //string filterTagset = null;
            //string filterText = null;
            //int? size = null;
            //int? page = null;
            //string order = null;
            //var response = instance.GetPolls(filterCategory, filterTagset, filterText, size, page, order);
            //Assert.IsInstanceOf<PageResourcePollResource> (response, "response is PageResourcePollResource");
        }
        
        /// <summary>
        /// Test UpdatePoll
        /// </summary>
        [Test]
        public void UpdatePollTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //PollResource pollResource = null;
            //var response = instance.UpdatePoll(id, pollResource);
            //Assert.IsInstanceOf<PollResource> (response, "response is PollResource");
        }
        
        /// <summary>
        /// Test UpdatePollTemplate
        /// </summary>
        [Test]
        public void UpdatePollTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //TemplateResource pollTemplateResource = null;
            //var response = instance.UpdatePollTemplate(id, pollTemplateResource);
            //Assert.IsInstanceOf<TemplateResource> (response, "response is TemplateResource");
        }
        
    }

}
