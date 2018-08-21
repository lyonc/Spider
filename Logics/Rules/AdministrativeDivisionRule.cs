namespace Clsmap.Spider.Logics.Rules
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;
    using HtmlAgilityPack;

    public class AdministrativeDivisionProcess : IGrabProcess
    {
        private HttpClient _httpClient = new HttpClient();

        private List<string> _startUrl = new List<string>
        {
"http://www.tcmap.com.cn/beijing/",
// "http://www.tcmap.com.cn/tianjin/",
// "http://www.tcmap.com.cn/shanghai/",
// "http://www.tcmap.com.cn/chongqing/",
// "http://www.tcmap.com.cn/Tibet/",
// "http://www.tcmap.com.cn/neimenggu/",
// "http://www.tcmap.com.cn/xinjiang/",
// "http://www.tcmap.com.cn/guangxi/",
// "http://www.tcmap.com.cn/ningxia/",
// "http://www.tcmap.com.cn/liaoning/",
// "http://www.tcmap.com.cn/jilin/",
// "http://www.tcmap.com.cn/heilongjiang/",
// "http://www.tcmap.com.cn/hebei/",
// "http://www.tcmap.com.cn/shanxisheng/",
// "http://www.tcmap.com.cn/shanxi/",
// "http://www.tcmap.com.cn/jiangsu/",
// "http://www.tcmap.com.cn/zhejiangsheng/",
// "http://www.tcmap.com.cn/fujian/",
// "http://www.tcmap.com.cn/anhui/",
// "http://www.tcmap.com.cn/jiangxi/",
// "http://www.tcmap.com.cn/shandong/",
// "http://www.tcmap.com.cn/henan/",
// "http://www.tcmap.com.cn/hubei/",
// "http://www.tcmap.com.cn/hunan/",
// "http://www.tcmap.com.cn/guangdong/",
// "http://www.tcmap.com.cn/hainan/",
// "http://www.tcmap.com.cn/sichuan/",
// "http://www.tcmap.com.cn/guizhou/",
// "http://www.tcmap.com.cn/yunnan/",
// "http://www.tcmap.com.cn/gansusheng/",
// "http://www.tcmap.com.cn/qinghai/",
// "http://www.tcmap.com.cn/HongKong/",
// "http://www.tcmap.com.cn/Macau/",
// "http://www.tcmap.com.cn/taiwan/",
        };

        public string BaseUrl { get; set; }

        public List<string> StartUrls { get => _startUrl; set => _startUrl = value; }

        public List<GrabRuleStep> Steps { get; set; }

        public AdministrativeDivisionProcess()
        {
            BaseUrl = "http://www.tcmap.com.cn";

            Steps = new List<GrabRuleStep>()
            {
                new GrabRuleStep
                {
                    Rule = StepOneAsync
                },
            };
        }

        private async Task<List<string>> StepOneAsync(List<string> targets)
        {
            var hrefs = new List<string>();

            foreach (var url in targets)
            {
                try
                {
                    var result = await _httpClient.GetAsync(url);
                    var html = await result.Content.ReadAsStringAsync();

                    var doc = new HtmlDocument();
                    doc.LoadHtml(html);

                    var targetTags = doc.DocumentNode.SelectNodes("//a[@href]");
                    foreach (var link in targetTags)
                    {
                        var href = link.Attributes["href"].Value;
                        hrefs.Add(href);
                        await Console.Out.WriteLineAsync(href);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return hrefs;
        }
    }
}