namespace Clsmap.Spider.Models
{
    public class AdministrativeDivision
    {
        public DivisionLevel Level { get; set; }

        public int OrderNumber { get; set; }

        public AdministrativeDivision Superior { get; set; }

        public string Name { get; set; }

        public string Subfix { get; set; }

        public string FullName => Name + Subfix;

        public override string ToString()
        {
            return FullName;
        }
    }

    public enum DivisionLevel
    {
        /// <summary>
        /// 省级。省，直辖市，自治区，特别行政区
        /// </summary>
        Province,
        /// <summary>
        /// 地级。地级市，直辖市辖区、县，自治州，地区，省辖县
        /// </summary>
        Prefecture,
        /// <summary>
        /// 县级。县，县级市，地级市辖区
        /// </summary>
        County,
        /// <summary>
        /// 乡级。乡，镇（Town），街道（subdistricts）
        /// </summary>
        Township,
        /// <summary>
        /// 村级。村，社区（Residential community）
        /// </summary>
        Village,
        /// <summary>
        /// 组级。村民组，居民组
        /// </summary>
        ResidentialGroup,
    }

    #region USELESS should restore these data in db. 

    public static class Provences
    {
        public static AdministrativeDivision Anhui = new AdministrativeDivision
        {
            Level = DivisionLevel.Province,
            Name = "安徽",
            Subfix = "省"
        };
        
        public static AdministrativeDivision Beijing = new AdministrativeDivision
        {
            Level = DivisionLevel.Province,
            Name = "北京",
            Subfix = "市"
        };

        public static AdministrativeDivision Chongqing = new AdministrativeDivision
        {
            Level = DivisionLevel.Province,
            Name = "重庆",
            Subfix = "市",
        };
        
        public static AdministrativeDivision Fujian = new AdministrativeDivision
        {
            Level = DivisionLevel.Province,
            Name = "福建",
            Subfix = "省",
        };

        public static AdministrativeDivision Gansu = new AdministrativeDivision
        {
            Level = DivisionLevel.Province,
            Name = "甘肃",
            Subfix = "省",
        };

        public static AdministrativeDivision Guangdong = new AdministrativeDivision
        {
            Level = DivisionLevel.Province,
            Name = "广东",
            Subfix = "省",
        };

        public static AdministrativeDivision Guangxi = new AdministrativeDivision
        {
            Level = DivisionLevel.Province,
            Name = "广西",
            Subfix = "壮族自治区",
        };

        public static AdministrativeDivision Guizhou = new AdministrativeDivision
        {
            Level = DivisionLevel.Province,
            Name = "贵州",
            Subfix = "省",
        };

        public static AdministrativeDivision Hainan = new AdministrativeDivision
        {
            Level = DivisionLevel.Province,
            Name = "海南",
            Subfix = "省",
        };

        public static AdministrativeDivision Hebei = new AdministrativeDivision
        {
            Level = DivisionLevel.Province,
            Name = "河北",
            Subfix = "省",
        };

        public static AdministrativeDivision Heilongjiang = new AdministrativeDivision
        {
            Level = DivisionLevel.Province,
            Name = "黑龙江",
            Subfix = "省",
        };

        public static AdministrativeDivision Henan = new AdministrativeDivision
        {
            Level = DivisionLevel.Province,
            Name = "河南",
            Subfix = "省",
        };

        public static AdministrativeDivision Hongkong = new AdministrativeDivision
        {
            Level = DivisionLevel.Province,
            Name = "香港",
            Subfix = "特别行政区",
        };

        public static AdministrativeDivision Hubei = new AdministrativeDivision
        {
            Level = DivisionLevel.Province,
            Name = "湖北",
            Subfix = "省",
        };

        public static AdministrativeDivision Hunan = new AdministrativeDivision
        {
            Level = DivisionLevel.Province,
            Name = "湖南",
            Subfix = "省",
        };

        public static AdministrativeDivision InnerMongolia = new AdministrativeDivision
        {
            Level = DivisionLevel.Province,
            Name = "内蒙古",
            Subfix = "自治区",
        };

        public static AdministrativeDivision Jiangsu = new AdministrativeDivision
        {
            Level = DivisionLevel.Province,
            Name = "江苏",
            Subfix = "省",
        };

        public static AdministrativeDivision Jiangxi = new AdministrativeDivision
        {
            Level = DivisionLevel.Province,
            Name = "江西",
            Subfix = "省",
        };

        public static AdministrativeDivision Jilin = new AdministrativeDivision
        {
            Level = DivisionLevel.Province,
            Name = "吉林",
            Subfix = "省",
        };

        public static AdministrativeDivision Liaoning = new AdministrativeDivision
        {
            Level = DivisionLevel.Province,
            Name = "辽宁",
            Subfix = "省",
        };

        public static AdministrativeDivision Ningxia = new AdministrativeDivision
        {
            Level = DivisionLevel.Province,
            Name = "宁夏",
            Subfix = "回族自治区",
        };

        public static AdministrativeDivision Macau = new AdministrativeDivision
        {
            Level = DivisionLevel.Province,
            Name = "澳门",
            Subfix = "特别行政区",
        };

        public static AdministrativeDivision Qinghai = new AdministrativeDivision
        {
            Level = DivisionLevel.Province,
            Name = "青海",
            Subfix = "省",
        };

        public static AdministrativeDivision Shaanxi = new AdministrativeDivision
        {
            Level = DivisionLevel.Province,
            Name = "陕西",
            Subfix = "省",
        };

        public static AdministrativeDivision Shandong = new AdministrativeDivision
        {
            Level = DivisionLevel.Province,
            Name = "山东",
            Subfix = "省",
        };

        public static AdministrativeDivision Shanghai = new AdministrativeDivision
        {
            Level = DivisionLevel.Province,
            Name = "上海",
            Subfix = "市",
        };

        public static AdministrativeDivision Shanxi = new AdministrativeDivision
        {
            Level = DivisionLevel.Province,
            Name = "山西",
            Subfix = "省",
        };

        public static AdministrativeDivision Sichuan = new AdministrativeDivision
        {
            Level = DivisionLevel.Province,
            Name = "四川",
            Subfix = "省",
        };

        public static AdministrativeDivision Taiwan = new AdministrativeDivision
        {
            Level = DivisionLevel.Province,
            Name = "台湾",
            Subfix = "省",
        };

        public static AdministrativeDivision Tianjin = new AdministrativeDivision
        {
            Level = DivisionLevel.Province,
            Name = "天津",
            Subfix = "市",
        };

        public static AdministrativeDivision Tibet = new AdministrativeDivision
        {
            Level = DivisionLevel.Province,
            Name = "西藏",
            Subfix = "自治区",
        };

        public static AdministrativeDivision Xinjiang = new AdministrativeDivision
        {
            Level = DivisionLevel.Province,
            Name = "新疆",
            Subfix = "维吾尔自治区",
        };

        public static AdministrativeDivision Yunnan = new AdministrativeDivision
        {
            Level = DivisionLevel.Province,
            Name = "云南",
            Subfix = "省",
        };

        public static AdministrativeDivision Zhejiang = new AdministrativeDivision
        {
            Level = DivisionLevel.Province,
            Name = "浙江",
            Subfix = "省",
        };
    }

    public static class Prefecture
    {
        public static AdministrativeDivision Hefei = new AdministrativeDivision
        {
            Level = DivisionLevel.Prefecture,
            OrderNumber = 0,
            Superior = Provences.Anhui,
            Name = "合肥",
            Subfix = "市",
        };
    }

    public static class County
    {
        public static AdministrativeDivision Yaohai = new AdministrativeDivision
        {
            Level = DivisionLevel.County,
            OrderNumber = 0,
            Superior = Prefecture.Hefei,
            Name = "瑶海",
            Subfix = "区"
        };

        public static AdministrativeDivision Baohe = new AdministrativeDivision
        {
            Level = DivisionLevel.County,
            OrderNumber = 0,
            Superior = Prefecture.Hefei,
            Name = "包河",
            Subfix = "区"
        };

        public static AdministrativeDivision Luyang = new AdministrativeDivision
        {
            Level = DivisionLevel.County,
            OrderNumber = 0,
            Superior = Prefecture.Hefei,
            Name = "庐阳",
            Subfix = "区"
        };

        public static AdministrativeDivision Shushan = new AdministrativeDivision
        {
            Level = DivisionLevel.County,
            OrderNumber = 0,
            Superior = Prefecture.Hefei,
            Name = "蜀山",
            Subfix = "区"
        };

        public static AdministrativeDivision ChaoHu = new AdministrativeDivision
        {
            Level = DivisionLevel.County,
            OrderNumber = 0,
            Superior = Prefecture.Hefei,
            Name = "巢湖",
            Subfix = "市"
        };

        public static AdministrativeDivision ChangFeng = new AdministrativeDivision
        {
            Level = DivisionLevel.County,
            OrderNumber = 0,
            Superior = Prefecture.Hefei,
            Name = "长丰",
            Subfix = "县"
        };

        public static AdministrativeDivision Feidong = new AdministrativeDivision
        {
            Level = DivisionLevel.County,
            OrderNumber = 0,
            Superior = Prefecture.Hefei,
            Name = "肥东",
            Subfix = "县"
        };

        public static AdministrativeDivision Feixi = new AdministrativeDivision
        {
            Level = DivisionLevel.County,
            OrderNumber = 0,
            Superior = Prefecture.Hefei,
            Name = "肥西",
            Subfix = "县"
        };

        public static AdministrativeDivision Lujiang = new AdministrativeDivision
        {
            Level = DivisionLevel.County,
            OrderNumber = 0,
            Superior = Prefecture.Hefei,
            Name = "庐江",
            Subfix = "县"
        };
    }

    public static class Township
    {
        public static AdministrativeDivision Sanliaan = new AdministrativeDivision
        {
            Level = DivisionLevel.Township,
            OrderNumber = 0,
            Superior = County.Shushan,
            Name = "三里庵",
            Subfix = "街道",
        };

        public static AdministrativeDivision Daoxiangcun = new AdministrativeDivision
        {
            Level = DivisionLevel.Township,
            OrderNumber = 1,
            Superior = County.Shushan,
            Name = "稻香村",
            Subfix = "街道",
        };

        public static AdministrativeDivision Hupo = new AdministrativeDivision
        {
            Level = DivisionLevel.Township,
            OrderNumber = 2,
            Superior = County.Shushan,
            Name = "琥珀",
            Subfix = "街道",
        };

        public static AdministrativeDivision Nanqi = new AdministrativeDivision
        {
            Level = DivisionLevel.Township,
            OrderNumber = 3,
            Superior = County.Shushan,
            Name = "南七",
            Subfix = "街道",
        };

        public static AdministrativeDivision Xiyuan = new AdministrativeDivision
        {
            Level = DivisionLevel.Township,
            OrderNumber = 4,
            Superior = County.Shushan,
            Name = "西园",
            Subfix = "街道",
        };

        public static AdministrativeDivision Wulidun = new AdministrativeDivision
        {
            Level = DivisionLevel.Township,
            OrderNumber = 5,
            Superior = County.Shushan,
            Name = "五里墩",
            Subfix = "街道",
        };

        public static AdministrativeDivision Heyedi = new AdministrativeDivision
        {
            Level = DivisionLevel.Township,
            OrderNumber = 6,
            Superior = County.Shushan,
            Name = "荷叶地",
            Subfix = "街道",
        };

        public static AdministrativeDivision Bijiashan = new AdministrativeDivision
        {
            Level = DivisionLevel.Township,
            OrderNumber = 7,
            Superior = County.Shushan,
            Name = "笔架山",
            Subfix = "街道",
        };
    }

    public static class Village
    {
        public static AdministrativeDivision Xinlin = new AdministrativeDivision
        {
            Level = DivisionLevel.Township,
            OrderNumber = 0,
            Superior = Township.Nanqi,
            Name = "杏林",
            Subfix = "社区",
        };

        public static AdministrativeDivision Sanlijie = new AdministrativeDivision
        {
            Level = DivisionLevel.Township,
            OrderNumber = 1,
            Superior = Township.Nanqi,
            Name = "二里街",
            Subfix = "社区",
        };

        public static AdministrativeDivision Xinhua = new AdministrativeDivision
        {
            Level = DivisionLevel.Township,
            OrderNumber = 2,
            Superior = Township.Nanqi,
            Name = "新华",
            Subfix = "社区",
        };

        public static AdministrativeDivision Dinggang = new AdministrativeDivision
        {
            Level = DivisionLevel.Township,
            OrderNumber = 3,
            Superior = Township.Nanqi,
            Name = "丁岗",
            Subfix = "社区",
        };

        public static AdministrativeDivision Honggang = new AdministrativeDivision
        {
            Level = DivisionLevel.Township,
            OrderNumber = 4,
            Superior = Township.Nanqi,
            Name = "洪岗",
            Subfix = "社区",
        };

        public static AdministrativeDivision Dingxiang = new AdministrativeDivision
        {
            Level = DivisionLevel.Township,
            OrderNumber = 5,
            Superior = Township.Nanqi,
            Name = "丁香",
            Subfix = "社区",
        };

        public static AdministrativeDivision Keqi = new AdministrativeDivision
        {
            Level = DivisionLevel.Township,
            OrderNumber = 6,
            Superior = Township.Nanqi,
            Name = "科企",
            Subfix = "社区",
        };
    }

    public static class ResidentialGroup
    {

    }

    #endregion USELESS should restore these data in db. 
}