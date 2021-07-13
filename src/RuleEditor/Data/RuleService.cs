using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using RuleEditor.Data;
using System.Threading.Tasks;

namespace RuleEditor.Data
{
    public class RuleService
    {
        private readonly RuleEditorContext context;

        public RuleService(RuleEditorContext context)
        {
            this.context = context;
        }

        public async Task<List<Rule>> GetRules() {
            return await context.Rules.ToListAsync().ConfigureAwait(false);
        }
    }
}