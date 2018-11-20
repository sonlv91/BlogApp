using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlogApp.API.Helpers;
using BlogApp.API.Models;

namespace BlogApp.API.Data
{
    public interface IBlogRepository
    {
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveAll();
        Task<PagedList<User>> GetUsers(UserParams userParams);
        Task<User> GetUser(int id);
        Task<Photo> GetMainPhotoForUser(int userId);
        Task<Photo> GetPhoto(int id);
        Task<Like> GetLike(int userId, int recipientId);
    }
}