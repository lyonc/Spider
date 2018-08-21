namespace Clsmap.Spider.Logics
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Logics.Rules;

    public class Harvest
    {
        public async Task<bool> GoAsync(IGrabProcess rule)
        {   
            List<string> targets = new List<string>();
            
            targets = rule.StartUrls;
            foreach(var step in rule.Steps)
            {
                var list = step.Rule(targets);
                targets = await list;
            }

            return true;
        }
    }
}