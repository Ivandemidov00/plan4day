using Microsoft.EntityFrameworkCore;
using plan4day.Model;

namespace plan4day.Context
{
    public class UserContext:DbContext,IUserContext
    {
        public DbSet<user> Users { get; set; }
        public DbSet<friendship> Friendships { get; set; }
        
        
        
    }
}