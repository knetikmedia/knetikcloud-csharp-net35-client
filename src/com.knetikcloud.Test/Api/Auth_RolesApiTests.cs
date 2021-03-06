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
    ///  Class for testing Auth_RolesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class Auth_RolesApiTests
    {
        private Auth_RolesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Auth_RolesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Auth_RolesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' Auth_RolesApi
            //Assert.IsInstanceOfType(typeof(Auth_RolesApi), instance, "instance is a Auth_RolesApi");
        }

        
        /// <summary>
        /// Test CreateRole
        /// </summary>
        [Test]
        public void CreateRoleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //RoleResource roleResource = null;
            //var response = instance.CreateRole(roleResource);
            //Assert.IsInstanceOf<RoleResource> (response, "response is RoleResource");
        }
        
        /// <summary>
        /// Test DeleteRole
        /// </summary>
        [Test]
        public void DeleteRoleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string role = null;
            //bool? force = null;
            //instance.DeleteRole(role, force);
            
        }
        
        /// <summary>
        /// Test GetClientRoles
        /// </summary>
        [Test]
        public void GetClientRolesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string clientKey = null;
            //var response = instance.GetClientRoles(clientKey);
            //Assert.IsInstanceOf<List<RoleResource>> (response, "response is List<RoleResource>");
        }
        
        /// <summary>
        /// Test GetRole
        /// </summary>
        [Test]
        public void GetRoleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string role = null;
            //var response = instance.GetRole(role);
            //Assert.IsInstanceOf<RoleResource> (response, "response is RoleResource");
        }
        
        /// <summary>
        /// Test GetRoles
        /// </summary>
        [Test]
        public void GetRolesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filterName = null;
            //string filterRole = null;
            //int? size = null;
            //int? page = null;
            //string order = null;
            //var response = instance.GetRoles(filterName, filterRole, size, page, order);
            //Assert.IsInstanceOf<PageResourceRoleResource> (response, "response is PageResourceRoleResource");
        }
        
        /// <summary>
        /// Test GetUserRoles
        /// </summary>
        [Test]
        public void GetUserRolesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? userId = null;
            //var response = instance.GetUserRoles(userId);
            //Assert.IsInstanceOf<List<RoleResource>> (response, "response is List<RoleResource>");
        }
        
        /// <summary>
        /// Test SetClientRoles
        /// </summary>
        [Test]
        public void SetClientRolesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string clientKey = null;
            //List<string> rolesList = null;
            //var response = instance.SetClientRoles(clientKey, rolesList);
            //Assert.IsInstanceOf<ClientResource> (response, "response is ClientResource");
        }
        
        /// <summary>
        /// Test SetPermissionsForRole
        /// </summary>
        [Test]
        public void SetPermissionsForRoleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string role = null;
            //List<string> permissionsList = null;
            //var response = instance.SetPermissionsForRole(role, permissionsList);
            //Assert.IsInstanceOf<RoleResource> (response, "response is RoleResource");
        }
        
        /// <summary>
        /// Test SetUserRoles
        /// </summary>
        [Test]
        public void SetUserRolesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? userId = null;
            //List<string> rolesList = null;
            //var response = instance.SetUserRoles(userId, rolesList);
            //Assert.IsInstanceOf<UserResource> (response, "response is UserResource");
        }
        
        /// <summary>
        /// Test UpdateRole
        /// </summary>
        [Test]
        public void UpdateRoleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string role = null;
            //RoleResource roleResource = null;
            //var response = instance.UpdateRole(role, roleResource);
            //Assert.IsInstanceOf<RoleResource> (response, "response is RoleResource");
        }
        
    }

}
