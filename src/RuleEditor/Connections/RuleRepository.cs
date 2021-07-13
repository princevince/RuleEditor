using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using RuleEditor.Data;

namespace RuleEditor
{
    public class RuleRepository
    {
        private readonly RuleEditorContext context;

        public RuleRepository(RuleEditorContext context)
        {
            this.context = context;
        }

        public List<Rule> GetRules() {
            var x = context.Rules;
            return new List<Rule>();
        }
    }
}