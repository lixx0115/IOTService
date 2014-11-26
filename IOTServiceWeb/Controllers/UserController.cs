// ***********************************************************************
// <copyright file="UserController.cs" company="">
//     Copyright (c)  Microsoft Corporation. All rights reserved.
// </copyright>
// ***********************************************************************

namespace IOTServiceWeb.Controllers
{
    using System.Net;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System.Web.Http;

    using IOTServiceCore;
    using IOTServiceCore.Repositories;

    /// <summary>
    /// The user controller.
    /// </summary>
    public class UserController : ApiController
    {
        #region Fields

        /// <summary>
        /// The authenication proivder.
        /// </summary>
        private readonly ILiveIdAuthenicationProvider authenicationProivder = new LiveIdAuthenicationProvider();

        /// <summary>
        /// The user provider.
        /// </summary>
        private readonly IUserPriovder userProvider = UserPriovder.GetInstance();

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// Deletes the user object specified user identifier.This api intended for trusted internal microsoft portal
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <returns>HttpResponseMessage object.</returns>
        [HttpDelete]
        [Route("api/v1/users/{userId}/")]
        public HttpResponseMessage Delete(string userId)
        {
            return this.Request.CreateResponse(415);
        }

        /// <summary>
        /// Gets the specified user by given user identifier. This api intended for trusted internal microsoft portal
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <returns>User object</returns>
        [HttpGet]
        [Route("api/v1/users/{userid}/")]
        public async Task<HttpResponseMessage> Get(string userId)
        {
            var result = await this.userProvider.GetUserById(userId);

            return this.Request.CreateResponse(HttpStatusCode.OK, result);
        }

        /// <summary>
        /// Gets the specified user object of the authenticated live id .
        /// </summary>
        /// <returns>User object</returns>
        [HttpGet]
        [Route("api/v1/me/")]
        public async Task<HttpResponseMessage> Get()
        {
            string userId = this.authenicationProivder.GetLiveId();
            var result = await this.userProvider.GetUserById(userId);

            return this.Request.CreateResponse(HttpStatusCode.OK, result);
        }

        /// <summary>
        /// Create the user object for specified user identifier. This api intended for trusted internal microsoft portal
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <param name="user">The user.</param>
        /// <returns>HttpResponseMessage object</returns>[HttpPost]
        [Route("api/v1/users/")]
        public async Task<HttpResponseMessage> Post( [FromBody] User user)
        {
            
            await this.userProvider.CreateUser(user);

            return this.Request.CreateResponse(HttpStatusCode.OK);
        }

        /// <summary>
        /// Update the specified user object for the authenticated live id. This api intended for trusted internal microsoft portal
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <param name="user">The user.</param>
        /// <returns>HttpResponseMessage object</returns>
        [HttpPut]
        [Route("api/v1/users/{userId}/")]
        public async Task<HttpResponseMessage> Put(string userId, [FromBody] User user)
        {
            await this.userProvider.UpdateUser(userId, user);

            return this.Request.CreateResponse(HttpStatusCode.OK);
        }

        /// <summary>
        /// Update the specified user object of the authenticated live id
        /// </summary>
        /// <param name="user">The user.</param>
        /// <returns>HttpResponseMessage object</returns>
        [HttpPut]
        [Route("api/v1/me/")]
        public async Task<HttpResponseMessage> Put([FromBody] User user)
        {
            string userId = this.authenicationProivder.GetLiveId();

            await this.userProvider.UpdateUser(userId, user);

            return this.Request.CreateResponse(HttpStatusCode.OK);
        }

        #endregion
    }
}