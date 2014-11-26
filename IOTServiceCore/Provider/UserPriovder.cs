// ***********************************************************************
// <copyright file="UserPriovder.cs" company="">
//     Copyright (c)  Microsoft Corporation. All rights reserved.
// </copyright>
// ***********************************************************************

namespace IOTServiceCore.Repositories
{
    using System.Threading.Tasks;

    /// <summary>
    /// The user priovder.
    /// </summary>
    public class UserPriovder : IUserPriovder
    {
        #region Static Fields

        /// <summary>
        /// The instance.
        /// </summary>
        private static readonly UserPriovder Instance = new UserPriovder();

        /// <summary>
        /// The repository.
        /// </summary>
        private static readonly DevUserRepository Repository = new DevUserRepository();

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Prevents a default instance of the <see cref="UserPriovder" /> class from being created.
        /// </summary>
        private UserPriovder()
        {
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// The get instance.
        /// </summary>
        /// <returns>The <see cref="UserPriovder" />.</returns>
        public static UserPriovder GetInstance()
        {
            return Instance;
        }

        /// <summary>
        /// The create user.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <param name="user">The user.</param>
        /// <returns>The <see cref="Task" />.</returns>
        public async Task<User> CreateUser(User user)
        {
            await Repository.CreateUser(user);
            return user;
        }

        /// <summary>
        /// The get user by id.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <returns>The <see cref="Task" />.</returns>
        public async Task<User> GetUserById(string userId)
        {
            return await Repository.GetUserById(userId);
        }

        /// <summary>
        /// The update user.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <param name="user">The user.</param>
        /// <returns>The <see cref="Task" />.</returns>
        public async Task<User> UpdateUser(string userId, User user)
        {
            return await Repository.UpdateUser(userId, user);
        }

        #endregion
    }
}