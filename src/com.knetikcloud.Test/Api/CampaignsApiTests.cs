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
    ///  Class for testing CampaignsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class CampaignsApiTests
    {
        private CampaignsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CampaignsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CampaignsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' CampaignsApi
            //Assert.IsInstanceOfType(typeof(CampaignsApi), instance, "instance is a CampaignsApi");
        }

        
        /// <summary>
        /// Test AddChallengeToCampaign
        /// </summary>
        [Test]
        public void AddChallengeToCampaignTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //long? challengeId = null;
            //instance.AddChallengeToCampaign(id, challengeId);
            
        }
        
        /// <summary>
        /// Test CreateCampaign
        /// </summary>
        [Test]
        public void CreateCampaignTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CampaignResource campaignResource = null;
            //var response = instance.CreateCampaign(campaignResource);
            //Assert.IsInstanceOf<CampaignResource> (response, "response is CampaignResource");
        }
        
        /// <summary>
        /// Test CreateCampaignTemplate
        /// </summary>
        [Test]
        public void CreateCampaignTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TemplateResource campaignTemplateResource = null;
            //var response = instance.CreateCampaignTemplate(campaignTemplateResource);
            //Assert.IsInstanceOf<TemplateResource> (response, "response is TemplateResource");
        }
        
        /// <summary>
        /// Test DeleteCampaign
        /// </summary>
        [Test]
        public void DeleteCampaignTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //instance.DeleteCampaign(id);
            
        }
        
        /// <summary>
        /// Test DeleteCampaignTemplate
        /// </summary>
        [Test]
        public void DeleteCampaignTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string cascade = null;
            //instance.DeleteCampaignTemplate(id, cascade);
            
        }
        
        /// <summary>
        /// Test GetCampaign
        /// </summary>
        [Test]
        public void GetCampaignTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //var response = instance.GetCampaign(id);
            //Assert.IsInstanceOf<CampaignResource> (response, "response is CampaignResource");
        }
        
        /// <summary>
        /// Test GetCampaignChallenges
        /// </summary>
        [Test]
        public void GetCampaignChallengesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //string filterStartDate = null;
            //string filterEndDate = null;
            //int? size = null;
            //int? page = null;
            //string order = null;
            //var response = instance.GetCampaignChallenges(id, filterStartDate, filterEndDate, size, page, order);
            //Assert.IsInstanceOf<PageResourceChallengeResource> (response, "response is PageResourceChallengeResource");
        }
        
        /// <summary>
        /// Test GetCampaignTemplate
        /// </summary>
        [Test]
        public void GetCampaignTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetCampaignTemplate(id);
            //Assert.IsInstanceOf<TemplateResource> (response, "response is TemplateResource");
        }
        
        /// <summary>
        /// Test GetCampaignTemplates
        /// </summary>
        [Test]
        public void GetCampaignTemplatesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? size = null;
            //int? page = null;
            //string order = null;
            //var response = instance.GetCampaignTemplates(size, page, order);
            //Assert.IsInstanceOf<PageResourceTemplateResource> (response, "response is PageResourceTemplateResource");
        }
        
        /// <summary>
        /// Test GetCampaigns
        /// </summary>
        [Test]
        public void GetCampaignsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? filterActive = null;
            //int? size = null;
            //int? page = null;
            //string order = null;
            //var response = instance.GetCampaigns(filterActive, size, page, order);
            //Assert.IsInstanceOf<PageResourceCampaignResource> (response, "response is PageResourceCampaignResource");
        }
        
        /// <summary>
        /// Test RemoveChallengeFromCampaign
        /// </summary>
        [Test]
        public void RemoveChallengeFromCampaignTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? campaignId = null;
            //long? id = null;
            //instance.RemoveChallengeFromCampaign(campaignId, id);
            
        }
        
        /// <summary>
        /// Test UpdateCampaign
        /// </summary>
        [Test]
        public void UpdateCampaignTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //CampaignResource campaignResource = null;
            //var response = instance.UpdateCampaign(id, campaignResource);
            //Assert.IsInstanceOf<CampaignResource> (response, "response is CampaignResource");
        }
        
        /// <summary>
        /// Test UpdateCampaignTemplate
        /// </summary>
        [Test]
        public void UpdateCampaignTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //TemplateResource campaignTemplateResource = null;
            //var response = instance.UpdateCampaignTemplate(id, campaignTemplateResource);
            //Assert.IsInstanceOf<TemplateResource> (response, "response is TemplateResource");
        }
        
    }

}
