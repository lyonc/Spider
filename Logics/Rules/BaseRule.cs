namespace Clsmap.Spider.Logics.Rules
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IGrabProcess
    {
        /// for relative urls.
        string BaseUrl { get; set; }

        List<string> StartUrls { get; set; }

        List<GrabRuleStep> Steps { get; set; }
    }

    public class GrabRuleStep
    {
        public Func<List<string>, Task<List<string>>> Rule { get; set; }
    }
}