using Microsoft.EntityFrameworkCore;
using RuleEditor.Data;
using Npgsql.EntityFrameworkCore.PostgreSQL;

namespace RuleEditor
{
    public class RuleEditorContext : DbContext
    {
        public DbSet<Rule> Rules { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(
                @"Host=localhost;Database=RuleEditor;Username=vincent;Password=spa50reine");
        }
    }
}