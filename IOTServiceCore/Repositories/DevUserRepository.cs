// ***********************************************************************
// <copyright file="DevUserRepository.cs" company="">
//     Copyright (c)  Microsoft Corporation. All rights reserved.
// </copyright>
// ***********************************************************************
namespace IOTServiceCore.Repositories
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using IOTServiceCore.Exception;

    /// <summary>
    /// Class DevUserRepository.
    /// </summary>
    public class DevUserRepository
    {
        #region Fields

        /// <summary>
        /// The store
        /// </summary>
        private readonly Dictionary<string, User> store = new Dictionary<string, User>();

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// Creates the specified user.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <exception cref="IOTServiceCore.Exception.UserIdAlreadyExistException"></exception>
        public async Task CreateUser(User user)
        {
            if (this.store.ContainsKey(user.Id))
            {
                throw new UserIdAlreadyExistException(string.Format("user id {0} exist", user.Id));
            }

            this.store.Add(user.Id, user);
        }

        /// <summary>
        /// Gets the user by Id.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <returns>User.</returns>
        public async Task<User> GetUserById(string userId)
        {
            return this.store[userId];
        }

        /// <summary>
        /// Updates the user.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <param name="user">The user.</param>
        /// <returns>User.</returns>
        public async Task<User> UpdateUser(string userId, User user)
        {
            this.store[userId] = user;
            return user;
        }

        #endregion
    }
}