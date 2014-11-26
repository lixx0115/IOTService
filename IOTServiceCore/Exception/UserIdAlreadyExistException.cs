// ***********************************************************************
// <copyright file="UserIdAlreadyExistException.cs" company="Microsoft">
//     Copyright (c)  Microsoft Corporation. All rights reserved.
// </copyright>
// ***********************************************************************

namespace IOTServiceCore.Exception
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The user id already exist exception.
    /// </summary>
    [Serializable]
    public class UserIdAlreadyExistException : Exception
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="UserIdAlreadyExistException" /> class.
        /// </summary>
        public UserIdAlreadyExistException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserIdAlreadyExistException" /> class.
        /// </summary>
        /// <param name="message">The message.</param>
        public UserIdAlreadyExistException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserIdAlreadyExistException" /> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="inner">The inner.</param>
        public UserIdAlreadyExistException(string message, Exception inner)
            : base(message, inner)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserIdAlreadyExistException" /> class.
        /// </summary>
        /// <param name="info">The info.</param>
        /// <param name="context">The context.</param>
        protected UserIdAlreadyExistException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        #endregion
    }
}