using MedNotes.Models;
using Microsoft.EntityFrameworkCore;

namespace MedNotes.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(
            DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }
        
        public DbSet<Note> Notes { get; set; }
    }
}