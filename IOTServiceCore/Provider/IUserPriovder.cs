namespace IOTServiceCore.Repositories
{
    using System.Threading.Tasks;

    public interface IUserPriovder
    {
        /// <summary>
        /// The create user.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <param name="user">The user.</param>
        /// <returns>The <see cref="Task" />.</returns>
        Task<User> CreateUser(User user);

        /// <summary>
        /// The get user by id.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <returns>The <see cref="Task" />.</returns>
        Task<User> GetUserById(string userId);

        /// <summary>
        /// The update user.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <param name="user">The user.</param>
        /// <returns>The <see cref="Task" />.</returns>
        Task<User> UpdateUser(string userId, User user);
    }
}