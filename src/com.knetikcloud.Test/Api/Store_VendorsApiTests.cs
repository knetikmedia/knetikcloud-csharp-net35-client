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
    ///  Class for testing Store_VendorsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class Store_VendorsApiTests
    {
        private Store_VendorsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Store_VendorsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Store_VendorsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' Store_VendorsApi
            //Assert.IsInstanceOfType(typeof(Store_VendorsApi), instance, "instance is a Store_VendorsApi");
        }

        
        /// <summary>
        /// Test CreateVendor
        /// </summary>
        [Test]
        public void CreateVendorTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //VendorResource vendor = null;
            //var response = instance.CreateVendor(vendor);
            //Assert.IsInstanceOf<VendorResource> (response, "response is VendorResource");
        }
        
        /// <summary>
        /// Test CreateVendorTemplate
        /// </summary>
        [Test]
        public void CreateVendorTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ItemTemplateResource vendorTemplateResource = null;
            //var response = instance.CreateVendorTemplate(vendorTemplateResource);
            //Assert.IsInstanceOf<ItemTemplateResource> (response, "response is ItemTemplateResource");
        }
        
        /// <summary>
        /// Test DeleteVendor
        /// </summary>
        [Test]
        public void DeleteVendorTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //instance.DeleteVendor(id);
            
        }
        
        /// <summary>
        /// Test DeleteVendorTemplate
        /// </summary>
        [Test]
        public void DeleteVendorTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string cascade = null;
            //instance.DeleteVendorTemplate(id, cascade);
            
        }
        
        /// <summary>
        /// Test GetVendor
        /// </summary>
        [Test]
        public void GetVendorTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //var response = instance.GetVendor(id);
            //Assert.IsInstanceOf<VendorResource> (response, "response is VendorResource");
        }
        
        /// <summary>
        /// Test GetVendorTemplate
        /// </summary>
        [Test]
        public void GetVendorTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetVendorTemplate(id);
            //Assert.IsInstanceOf<ItemTemplateResource> (response, "response is ItemTemplateResource");
        }
        
        /// <summary>
        /// Test GetVendorTemplates
        /// </summary>
        [Test]
        public void GetVendorTemplatesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? size = null;
            //int? page = null;
            //string order = null;
            //var response = instance.GetVendorTemplates(size, page, order);
            //Assert.IsInstanceOf<PageResourceItemTemplateResource> (response, "response is PageResourceItemTemplateResource");
        }
        
        /// <summary>
        /// Test GetVendors
        /// </summary>
        [Test]
        public void GetVendorsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filterName = null;
            //int? size = null;
            //int? page = null;
            //string order = null;
            //var response = instance.GetVendors(filterName, size, page, order);
            //Assert.IsInstanceOf<PageResourceVendorResource> (response, "response is PageResourceVendorResource");
        }
        
        /// <summary>
        /// Test UpdateVendor
        /// </summary>
        [Test]
        public void UpdateVendorTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //VendorResource vendor = null;
            //var response = instance.UpdateVendor(id, vendor);
            //Assert.IsInstanceOf<VendorResource> (response, "response is VendorResource");
        }
        
        /// <summary>
        /// Test UpdateVendorTemplate
        /// </summary>
        [Test]
        public void UpdateVendorTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //ItemTemplateResource vendorTemplateResource = null;
            //var response = instance.UpdateVendorTemplate(id, vendorTemplateResource);
            //Assert.IsInstanceOf<ItemTemplateResource> (response, "response is ItemTemplateResource");
        }
        
    }

}
