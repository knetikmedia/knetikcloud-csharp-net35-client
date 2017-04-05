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
    ///  Class for testing GamificationAchievementsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class GamificationAchievementsApiTests
    {
        private GamificationAchievementsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new GamificationAchievementsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of GamificationAchievementsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' GamificationAchievementsApi
            //Assert.IsInstanceOfType(typeof(GamificationAchievementsApi), instance, "instance is a GamificationAchievementsApi");
        }

        
        /// <summary>
        /// Test CreateAchievement
        /// </summary>
        [Test]
        public void CreateAchievementTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AchievementDefinitionResource achievement = null;
            //var response = instance.CreateAchievement(achievement);
            //Assert.IsInstanceOf<AchievementDefinitionResource> (response, "response is AchievementDefinitionResource");
        }
        
        /// <summary>
        /// Test CreateAchievementTemplate
        /// </summary>
        [Test]
        public void CreateAchievementTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TemplateResource template = null;
            //var response = instance.CreateAchievementTemplate(template);
            //Assert.IsInstanceOf<TemplateResource> (response, "response is TemplateResource");
        }
        
        /// <summary>
        /// Test DeleteAchievement
        /// </summary>
        [Test]
        public void DeleteAchievementTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //instance.DeleteAchievement(name);
            
        }
        
        /// <summary>
        /// Test DeleteAchievementTemplate
        /// </summary>
        [Test]
        public void DeleteAchievementTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string cascade = null;
            //instance.DeleteAchievementTemplate(id, cascade);
            
        }
        
        /// <summary>
        /// Test GetAchievement
        /// </summary>
        [Test]
        public void GetAchievementTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //var response = instance.GetAchievement(name);
            //Assert.IsInstanceOf<AchievementDefinitionResource> (response, "response is AchievementDefinitionResource");
        }
        
        /// <summary>
        /// Test GetAchievementTemplate
        /// </summary>
        [Test]
        public void GetAchievementTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetAchievementTemplate(id);
            //Assert.IsInstanceOf<TemplateResource> (response, "response is TemplateResource");
        }
        
        /// <summary>
        /// Test GetAchievementTemplates
        /// </summary>
        [Test]
        public void GetAchievementTemplatesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? size = null;
            //int? page = null;
            //string order = null;
            //var response = instance.GetAchievementTemplates(size, page, order);
            //Assert.IsInstanceOf<PageResourceTemplateResource> (response, "response is PageResourceTemplateResource");
        }
        
        /// <summary>
        /// Test GetAchievementTriggers
        /// </summary>
        [Test]
        public void GetAchievementTriggersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetAchievementTriggers();
            //Assert.IsInstanceOf<List<BreTriggerResource>> (response, "response is List<BreTriggerResource>");
        }
        
        /// <summary>
        /// Test GetAchievements
        /// </summary>
        [Test]
        public void GetAchievementsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filterTagset = null;
            //string filterName = null;
            //bool? filterHidden = null;
            //bool? filterDerived = null;
            //int? size = null;
            //int? page = null;
            //string order = null;
            //var response = instance.GetAchievements(filterTagset, filterName, filterHidden, filterDerived, size, page, order);
            //Assert.IsInstanceOf<PageResourceAchievementDefinitionResource> (response, "response is PageResourceAchievementDefinitionResource");
        }
        
        /// <summary>
        /// Test GetDerivedAchievements
        /// </summary>
        [Test]
        public void GetDerivedAchievementsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //var response = instance.GetDerivedAchievements(name);
            //Assert.IsInstanceOf<List<AchievementDefinitionResource>> (response, "response is List<AchievementDefinitionResource>");
        }
        
        /// <summary>
        /// Test GetUserAchievementProgress
        /// </summary>
        [Test]
        public void GetUserAchievementProgressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? userId = null;
            //string achievementName = null;
            //var response = instance.GetUserAchievementProgress(userId, achievementName);
            //Assert.IsInstanceOf<UserAchievementGroupResource> (response, "response is UserAchievementGroupResource");
        }
        
        /// <summary>
        /// Test GetUserAchievementsProgress
        /// </summary>
        [Test]
        public void GetUserAchievementsProgressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? userId = null;
            //bool? filterAchievementDerived = null;
            //string filterAchievementTagset = null;
            //string filterAchievementName = null;
            //int? size = null;
            //int? page = null;
            //var response = instance.GetUserAchievementsProgress(userId, filterAchievementDerived, filterAchievementTagset, filterAchievementName, size, page);
            //Assert.IsInstanceOf<PageResourceUserAchievementGroupResource> (response, "response is PageResourceUserAchievementGroupResource");
        }
        
        /// <summary>
        /// Test GetUsersAchievementProgress
        /// </summary>
        [Test]
        public void GetUsersAchievementProgressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string achievementName = null;
            //bool? filterAchievementDerived = null;
            //string filterAchievementTagset = null;
            //string filterAchievementName = null;
            //int? size = null;
            //int? page = null;
            //var response = instance.GetUsersAchievementProgress(achievementName, filterAchievementDerived, filterAchievementTagset, filterAchievementName, size, page);
            //Assert.IsInstanceOf<PageResourceUserAchievementGroupResource> (response, "response is PageResourceUserAchievementGroupResource");
        }
        
        /// <summary>
        /// Test GetUsersAchievementsProgress
        /// </summary>
        [Test]
        public void GetUsersAchievementsProgressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? filterAchievementDerived = null;
            //string filterAchievementTagset = null;
            //string filterAchievementName = null;
            //int? size = null;
            //int? page = null;
            //var response = instance.GetUsersAchievementsProgress(filterAchievementDerived, filterAchievementTagset, filterAchievementName, size, page);
            //Assert.IsInstanceOf<PageResourceUserAchievementGroupResource> (response, "response is PageResourceUserAchievementGroupResource");
        }
        
        /// <summary>
        /// Test IncrementAchievementProgress
        /// </summary>
        [Test]
        public void IncrementAchievementProgressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? userId = null;
            //string achievementName = null;
            //int? progress = null;
            //var response = instance.IncrementAchievementProgress(userId, achievementName, progress);
            //Assert.IsInstanceOf<UserAchievementGroupResource> (response, "response is UserAchievementGroupResource");
        }
        
        /// <summary>
        /// Test SetAchievementProgress
        /// </summary>
        [Test]
        public void SetAchievementProgressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? userId = null;
            //string achievementName = null;
            //int? progress = null;
            //var response = instance.SetAchievementProgress(userId, achievementName, progress);
            //Assert.IsInstanceOf<UserAchievementGroupResource> (response, "response is UserAchievementGroupResource");
        }
        
        /// <summary>
        /// Test UpdateAchievement
        /// </summary>
        [Test]
        public void UpdateAchievementTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //AchievementDefinitionResource achievement = null;
            //var response = instance.UpdateAchievement(name, achievement);
            //Assert.IsInstanceOf<AchievementDefinitionResource> (response, "response is AchievementDefinitionResource");
        }
        
        /// <summary>
        /// Test UpdateAchievementTemplate
        /// </summary>
        [Test]
        public void UpdateAchievementTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //TemplateResource template = null;
            //var response = instance.UpdateAchievementTemplate(id, template);
            //Assert.IsInstanceOf<TemplateResource> (response, "response is TemplateResource");
        }
        
    }

}
