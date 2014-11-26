using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IOTServiceWeb.Controllers
{
    using System.Threading.Tasks;

    public class DeviceController : ApiController
    {
        /// <summary>
        /// The authenication proivder.
        /// </summary>
        private readonly ILiveIdAuthenicationProvider authenicationProivder = new LiveIdAuthenicationProvider();

       /// <summary>
        /// Gets the user devices by given user identifier.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <returns>User object</returns>
        [HttpGet]
        [Route("api/v1/{userid}/devices/")]
        public async Task<HttpResponseMessage> Get(string userId)
       {
           return null;
       }

        /// <summary>
        /// Gets the user devices by given user identifier.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <returns>User object</returns>
        [HttpGet]
        [Route("api/v1/me/devices/")]
        public async Task<HttpResponseMessage> Get()
        {
            return null;
        }

        // POST: api/Device
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Device/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Device/5
        public void Delete(int id)
        {
        }
    }
}
