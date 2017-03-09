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

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing PaymentsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class PaymentsApiTests
    {
        private PaymentsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PaymentsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PaymentsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' PaymentsApi
            //Assert.IsInstanceOfType(typeof(PaymentsApi), instance, "instance is a PaymentsApi");
        }

        
        /// <summary>
        /// Test CreatePaymentMethod
        /// </summary>
        [Test]
        public void CreatePaymentMethodTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? userId = null;
            //PaymentMethodResource paymentMethod = null;
            //var response = instance.CreatePaymentMethod(userId, paymentMethod);
            //Assert.IsInstanceOf<PaymentMethodResource> (response, "response is PaymentMethodResource");
        }
        
        /// <summary>
        /// Test DeletePaymentMethod
        /// </summary>
        [Test]
        public void DeletePaymentMethodTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? userId = null;
            //int? id = null;
            //instance.DeletePaymentMethod(userId, id);
            
        }
        
        /// <summary>
        /// Test GetPaymentMethod
        /// </summary>
        [Test]
        public void GetPaymentMethodTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? userId = null;
            //int? id = null;
            //var response = instance.GetPaymentMethod(userId, id);
            //Assert.IsInstanceOf<PaymentMethodResource> (response, "response is PaymentMethodResource");
        }
        
        /// <summary>
        /// Test GetPaymentMethods
        /// </summary>
        [Test]
        public void GetPaymentMethodsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? userId = null;
            //int? size = null;
            //int? page = null;
            //string order = null;
            //var response = instance.GetPaymentMethods(userId, size, page, order);
            //Assert.IsInstanceOf<List<PaymentMethodResource>> (response, "response is List<PaymentMethodResource>");
        }
        
        /// <summary>
        /// Test PaymentAuthorization
        /// </summary>
        [Test]
        public void PaymentAuthorizationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PaymentAuthorizationResource request = null;
            //var response = instance.PaymentAuthorization(request);
            //Assert.IsInstanceOf<PaymentAuthorizationResource> (response, "response is PaymentAuthorizationResource");
        }
        
        /// <summary>
        /// Test PaymentCapture
        /// </summary>
        [Test]
        public void PaymentCaptureTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //instance.PaymentCapture(id);
            
        }
        
        /// <summary>
        /// Test UpdatePaymentMethod
        /// </summary>
        [Test]
        public void UpdatePaymentMethodTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? userId = null;
            //int? id = null;
            //PaymentMethodResource paymentMethod = null;
            //var response = instance.UpdatePaymentMethod(userId, id, paymentMethod);
            //Assert.IsInstanceOf<PaymentMethodResource> (response, "response is PaymentMethodResource");
        }
        
    }

}
