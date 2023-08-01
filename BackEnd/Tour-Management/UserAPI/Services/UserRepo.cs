using Microsoft.Data.SqlClient;
using UserAPI.Interfaces;
using UserAPI.Models;
using UserAPI.Utilities;

namespace UserAPI.Services
{
    public class UserRepo:IRepo<User,int>
    {
        private readonly UserContext _context;

        public UserRepo(UserContext context)
        {
            _context=context;
        }

        public async Task<User?> Add(User item)
        {
            try
            {
                _context.Users.Add(item);
                await _context.SaveChangesAsync();
                return item;
            }
            catch (SqlException ex)
            {
                throw new InvalidSqlException(ex.Number);
            }
            catch (Exception ex)
            {
                var sqlException = ex.InnerException as SqlException;
                if (sqlException != null)
                    throw sqlException;
                throw new Exception();
            }
        }

        public Task<User?> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<User?> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<User>?> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<User?> Update(User item)
        {
            throw new NotImplementedException();
        }
    }
}
