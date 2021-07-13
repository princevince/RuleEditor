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
            var x = context.Rules;
            return await Task.FromResult(new List<Rule>()).ConfigureAwait(false);
        }
    }
}