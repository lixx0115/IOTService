// ***********************************************************************
// <copyright file="Device.cs" company="Microsoft">
//     Copyright (c)  Microsoft Corporation. All rights reserved.
// </copyright>
// ***********************************************************************

namespace IOTServiceCore
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The device.
    /// </summary>
    public class Device
    {
        #region Properties

        /// <summary>
        /// Gets or sets the API end point.
        /// </summary>
        /// <value>The API end point.</value>
        public string ApiEndPoint { get; set; }

        /// <summary>
        /// Gets or sets the device description.
        /// </summary>
        /// <value>The device description.</value>
        public string DeviceDescription { get; set; }

        /// <summary>
        /// Gets or sets the device model.
        /// </summary>
        /// <value>The device model.</value>
        public string DeviceModel { get; set; }

        /// <summary>
        /// Gets or sets the feed id.
        /// </summary>
        /// <value>The feed identifier.</value>
        public string FeedId { get; set; }

        /// <summary>
        /// Gets or sets the feed url.
        /// </summary>
        /// <value>The feed URL.</value>
        public string FeedUrl { get; set; }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        /// <value>The identifier.</value>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the tags.
        /// </summary>
        /// <value>The tags.</value>
        public KeyValuePair<string, string>[] Tags { get; set; }

        /// <summary>
        /// Gets or sets the created date.
        /// </summary>
        /// <value>The created date.</value>
        public DateTimeOffset CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the created by user identifier.
        /// </summary>
        /// <value>The created by user identifier.</value>
        public string CreatedByUserId { get; set; }

        #endregion
    }
}