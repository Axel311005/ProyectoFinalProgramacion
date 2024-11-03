using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Nomina_API.Data;
using Nomina_API.Repository.IRepository;
using SharedModels;

namespace Nomina_API.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly EmpresaContext _context;
        private readonly IPasswordHasher<User> _passwordHasher;

        public UserRepository(EmpresaContext context, IPasswordHasher<User> passwordHasher)
        {
            _context = context;
            _passwordHasher = passwordHasher;
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            return await _context.Users.FindAsync(id);
        }

        public Task<User> GetUserByUsernameAsync(string username)
        {
            return _context.Users.SingleOrDefaultAsync(u => u.UserName == username);
        }

        public async Task RegisterUserAsync(User user, string password)
        {
            user.PasswordHash = _passwordHasher.HashPassword(user, password);
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> ValidateUserAsync(string userName, string password)
        {
            var user = await GetUserByUsernameAsync(userName);
            if (user == null)
            {
                return false;
            }
            var verificationResult =
                _passwordHasher.VerifyHashedPassword(user, user.PasswordHash, password);
            return verificationResult == PasswordVerificationResult.Success;
        }
    }
}
