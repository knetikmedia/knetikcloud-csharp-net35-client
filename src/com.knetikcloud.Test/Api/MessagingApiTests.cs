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
    ///  Class for testing MessagingApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class MessagingApiTests
    {
        private MessagingApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new MessagingApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of MessagingApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' MessagingApi
            //Assert.IsInstanceOfType(typeof(MessagingApi), instance, "instance is a MessagingApi");
        }

        
        /// <summary>
        /// Test CompileMessageTemplate
        /// </summary>
        [Test]
        public void CompileMessageTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //MessageTemplateBulkRequest request = null;
            //var response = instance.CompileMessageTemplate(request);
            //Assert.IsInstanceOf<Dictionary<string, string>> (response, "response is Dictionary<string, string>");
        }
        
        /// <summary>
        /// Test CreateMessageTemplate
        /// </summary>
        [Test]
        public void CreateMessageTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //MessageTemplateResource messageTemplate = null;
            //var response = instance.CreateMessageTemplate(messageTemplate);
            //Assert.IsInstanceOf<MessageTemplateResource> (response, "response is MessageTemplateResource");
        }
        
        /// <summary>
        /// Test DeleteMessageTemplate
        /// </summary>
        [Test]
        public void DeleteMessageTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.DeleteMessageTemplate(id);
            
        }
        
        /// <summary>
        /// Test GetMessageTemplate
        /// </summary>
        [Test]
        public void GetMessageTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetMessageTemplate(id);
            //Assert.IsInstanceOf<MessageTemplateResource> (response, "response is MessageTemplateResource");
        }
        
        /// <summary>
        /// Test GetMessageTemplates
        /// </summary>
        [Test]
        public void GetMessageTemplatesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filterTagset = null;
            //string filterTagIntersection = null;
            //string filterTagExclusion = null;
            //int? size = null;
            //int? page = null;
            //string order = null;
            //var response = instance.GetMessageTemplates(filterTagset, filterTagIntersection, filterTagExclusion, size, page, order);
            //Assert.IsInstanceOf<PageResourceMessageTemplateResource> (response, "response is PageResourceMessageTemplateResource");
        }
        
        /// <summary>
        /// Test SendMessage1
        /// </summary>
        [Test]
        public void SendMessage1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //MessageResource messageResource = null;
            //instance.SendMessage1(messageResource);
            
        }
        
        /// <summary>
        /// Test SendRawEmail
        /// </summary>
        [Test]
        public void SendRawEmailTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //RawEmailResource rawEmailResource = null;
            //instance.SendRawEmail(rawEmailResource);
            
        }
        
        /// <summary>
        /// Test SendRawPush
        /// </summary>
        [Test]
        public void SendRawPushTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //RawPushResource rawPushResource = null;
            //instance.SendRawPush(rawPushResource);
            
        }
        
        /// <summary>
        /// Test SendRawSMS
        /// </summary>
        [Test]
        public void SendRawSMSTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //RawSMSResource rawSMSResource = null;
            //instance.SendRawSMS(rawSMSResource);
            
        }
        
        /// <summary>
        /// Test SendTemplatedEmail
        /// </summary>
        [Test]
        public void SendTemplatedEmailTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TemplateEmailResource messageResource = null;
            //instance.SendTemplatedEmail(messageResource);
            
        }
        
        /// <summary>
        /// Test SendTemplatedPush
        /// </summary>
        [Test]
        public void SendTemplatedPushTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TemplatePushResource templatePushResource = null;
            //instance.SendTemplatedPush(templatePushResource);
            
        }
        
        /// <summary>
        /// Test SendTemplatedSMS
        /// </summary>
        [Test]
        public void SendTemplatedSMSTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TemplateSMSResource templateSMSResource = null;
            //instance.SendTemplatedSMS(templateSMSResource);
            
        }
        
        /// <summary>
        /// Test SendWebsocket
        /// </summary>
        [Test]
        public void SendWebsocketTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //WebsocketMessageResource websocketResource = null;
            //instance.SendWebsocket(websocketResource);
            
        }
        
        /// <summary>
        /// Test UpdateMessageTemplate
        /// </summary>
        [Test]
        public void UpdateMessageTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //MessageTemplateResource messageTemplateResource = null;
            //var response = instance.UpdateMessageTemplate(id, messageTemplateResource);
            //Assert.IsInstanceOf<MessageTemplateResource> (response, "response is MessageTemplateResource");
        }
        
    }

}
