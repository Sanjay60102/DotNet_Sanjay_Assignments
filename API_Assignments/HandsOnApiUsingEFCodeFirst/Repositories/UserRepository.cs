﻿using HandsOnApiUsingEFCodeFirst.Entities;

namespace HandsOnApiUsingEFCodeFirst.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ECommContext _context;

        public UserRepository(ECommContext context)
        {
            _context = context;
        }

        //public UserRepository()
        //{
        //    _context = new ECommContext();
        //}
        public void Register(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }
        public User ValidUser(string email, string password)
        {
            return _context.Users.SingleOrDefault(u => u.Email == email && u.Password == password);
        }
    }
}
