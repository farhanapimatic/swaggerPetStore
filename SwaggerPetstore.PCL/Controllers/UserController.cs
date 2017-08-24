/*
 * SwaggerPetstore.PCL
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Converters;
using SwaggerPetstore.PCL;
using SwaggerPetstore.PCL.Utilities;
using SwaggerPetstore.PCL.Http.Request;
using SwaggerPetstore.PCL.Http.Response;
using SwaggerPetstore.PCL.Http.Client;
using SwaggerPetstore.PCL.Exceptions;

namespace SwaggerPetstore.PCL.Controllers
{
    public partial class UserController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static UserController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static UserController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new UserController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Updated user
        /// </summary>
        /// <param name="username">Required parameter: name that need to be updated</param>
        /// <param name="body">Required parameter: Updated user object</param>
        /// <return>Returns the void response from the API call</return>
        public void UpdateUser(string username, Models.User body)
        {
            Task t = UpdateUserAsync(username, body);
            APIHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// Updated user
        /// </summary>
        /// <param name="username">Required parameter: name that need to be updated</param>
        /// <param name="body">Required parameter: Updated user object</param>
        /// <return>Returns the void response from the API call</return>
        public async Task UpdateUserAsync(string username, Models.User body)
        {
            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/user/{username}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "username", username }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "content-type", "application/json; charset=utf-8" }
            };

            //append body params
            var _body = APIHelper.JsonSerialize(body);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.PutBody(_queryUrl, _headers, _body);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);

            //Error handling using HTTP status codes
            if (_response.StatusCode == 400)
                throw new APIException(@"Invalid user supplied", _context);

            if (_response.StatusCode == 404)
                throw new APIException(@"User not found", _context);

            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

        }

        /// <summary>
        /// Delete user
        /// </summary>
        /// <param name="username">Required parameter: The name that needs to be deleted</param>
        /// <return>Returns the void response from the API call</return>
        public void DeleteUser(string username)
        {
            Task t = DeleteUserAsync(username);
            APIHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// Delete user
        /// </summary>
        /// <param name="username">Required parameter: The name that needs to be deleted</param>
        /// <return>Returns the void response from the API call</return>
        public async Task DeleteUserAsync(string username)
        {
            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/user/{username}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "username", username }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Delete(_queryUrl, _headers, null);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);

            //Error handling using HTTP status codes
            if (_response.StatusCode == 400)
                throw new APIException(@"Invalid username supplied", _context);

            if (_response.StatusCode == 404)
                throw new APIException(@"User not found", _context);

            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

        }

        /// <summary>
        /// Logs user into the system
        /// </summary>
        /// <param name="username">Required parameter: The user name for login</param>
        /// <param name="password">Required parameter: The password for login in clear text</param>
        /// <return>Returns the string response from the API call</return>
        public string GetLoginUser(string username, string password)
        {
            Task<string> t = GetLoginUserAsync(username, password);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Logs user into the system
        /// </summary>
        /// <param name="username">Required parameter: The user name for login</param>
        /// <param name="password">Required parameter: The password for login in clear text</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> GetLoginUserAsync(string username, string password)
        {
            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/user/login");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "username", username },
                { "password", password }
            },ArrayDeserializationFormat,ParameterSeparator);


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);

            //Error handling using HTTP status codes
            if (_response.StatusCode == 400)
                throw new APIException(@"Invalid username/password supplied", _context);

            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return _response.Body;
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Get user by user name
        /// </summary>
        /// <param name="username">Required parameter: The name that needs to be fetched. Use user1 for testing.</param>
        /// <return>Returns the Models.User response from the API call</return>
        public Models.User GetUserByName(string username)
        {
            Task<Models.User> t = GetUserByNameAsync(username);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Get user by user name
        /// </summary>
        /// <param name="username">Required parameter: The name that needs to be fetched. Use user1 for testing.</param>
        /// <return>Returns the Models.User response from the API call</return>
        public async Task<Models.User> GetUserByNameAsync(string username)
        {
            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/user/{username}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "username", username }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);

            //Error handling using HTTP status codes
            if (_response.StatusCode == 400)
                throw new APIException(@"Invalid username supplied", _context);

            if (_response.StatusCode == 404)
                throw new APIException(@"User not found", _context);

            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<Models.User>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Create user
        /// </summary>
        /// <param name="body">Required parameter: Created user object</param>
        /// <return>Returns the void response from the API call</return>
        public void CreateUser(Models.User body)
        {
            Task t = CreateUserAsync(body);
            APIHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// Create user
        /// </summary>
        /// <param name="body">Required parameter: Created user object</param>
        /// <return>Returns the void response from the API call</return>
        public async Task CreateUserAsync(Models.User body)
        {
            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/user");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "content-type", "application/json; charset=utf-8" }
            };

            //append body params
            var _body = APIHelper.JsonSerialize(body);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.PostBody(_queryUrl, _headers, _body);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);

            //Error handling using HTTP status codes
            if ((_response.StatusCode < 200) || (_response.StatusCode > 208)) //[200,208] = HTTP OK
                throw new APIException(@"successful operation", _context);

            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

        }

        /// <summary>
        /// Creates list of users with given input array
        /// </summary>
        /// <param name="body">Required parameter: List of user object</param>
        /// <return>Returns the void response from the API call</return>
        public void CreateUsersWithArrayInput(List<Models.User> body)
        {
            Task t = CreateUsersWithArrayInputAsync(body);
            APIHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// Creates list of users with given input array
        /// </summary>
        /// <param name="body">Required parameter: List of user object</param>
        /// <return>Returns the void response from the API call</return>
        public async Task CreateUsersWithArrayInputAsync(List<Models.User> body)
        {
            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/user/createWithArray");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "content-type", "application/json; charset=utf-8" }
            };

            //append body params
            var _body = APIHelper.JsonSerialize(body);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.PostBody(_queryUrl, _headers, _body);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);

            //Error handling using HTTP status codes
            if ((_response.StatusCode < 200) || (_response.StatusCode > 208)) //[200,208] = HTTP OK
                throw new APIException(@"successful operation", _context);

            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

        }

        /// <summary>
        /// Creates list of users with given input array
        /// </summary>
        /// <param name="body">Required parameter: List of user object</param>
        /// <return>Returns the void response from the API call</return>
        public void CreateUsersWithListInput(List<Models.User> body)
        {
            Task t = CreateUsersWithListInputAsync(body);
            APIHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// Creates list of users with given input array
        /// </summary>
        /// <param name="body">Required parameter: List of user object</param>
        /// <return>Returns the void response from the API call</return>
        public async Task CreateUsersWithListInputAsync(List<Models.User> body)
        {
            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/user/createWithList");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "content-type", "application/json; charset=utf-8" }
            };

            //append body params
            var _body = APIHelper.JsonSerialize(body);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.PostBody(_queryUrl, _headers, _body);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);

            //Error handling using HTTP status codes
            if ((_response.StatusCode < 200) || (_response.StatusCode > 208)) //[200,208] = HTTP OK
                throw new APIException(@"successful operation", _context);

            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

        }

        /// <summary>
        /// Logs out current logged in user session
        /// </summary>
        /// <return>Returns the void response from the API call</return>
        public void GetLogoutUser()
        {
            Task t = GetLogoutUserAsync();
            APIHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// Logs out current logged in user session
        /// </summary>
        /// <return>Returns the void response from the API call</return>
        public async Task GetLogoutUserAsync()
        {
            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/user/logout");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);

            //Error handling using HTTP status codes
            if ((_response.StatusCode < 200) || (_response.StatusCode > 208)) //[200,208] = HTTP OK
                throw new APIException(@"successful operation", _context);

            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

        }

    }
} 