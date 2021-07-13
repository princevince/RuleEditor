using Microsoft.EntityFrameworkCore;
using RuleEditor.Data;
using Npgsql.EntityFrameworkCore.PostgreSQL;
using Microsoft.Extensions.Options;

namespace RuleEditor
{
    public class RuleEditorContext : DbContext
    {
        private readonly DatabaseOptions dbOptions;

        public RuleEditorContext(IOptions<DatabaseOptions> dbOptions) {
            this.dbOptions = dbOptions.Value;
        }

        public DbSet<Rule> Rules { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(
                $"Host=localhost;Database=RuleEditor;Username={dbOptions.User};Password={dbOptions.Password}");
        }
    }
}