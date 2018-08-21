namespace Clsmap.Spider.Models
{
    /// <summary>
    /// 地址信息。主要指联系地址，如公司地址，家庭地址等。
    /// </summary>
    public class Address
    {
        /// <summary>
        /// 安徽省
        /// </summary>
        public AdministrativeDivision Province { get; set; }

        /// <summary>
        /// 合肥市，滁州市
        /// </summary>
        public AdministrativeDivision Prefecture { get; set; }

        /// <summary>
        /// 蜀山区，明光市
        /// </summary>
        public AdministrativeDivision County { get; set; }

        /// <summary>
        /// 南七街道，（明西街道，女山湖镇）
        /// </summary>
        public AdministrativeDivision Township { get; set; }

        /// <summary>
        /// 丁香社区，光明村
        /// </summary>
        public AdministrativeDivision Village { get; set; }

        /// <summary>
        /// 黄山花园小区，王岗组
        /// </summary>
        public AdministrativeDivision ResidentialGroup { get; set; }

        /// <summary>
        /// 系统未能列出的详细地址，如XX路XX号
        /// </summary>
        public string Detail { get; set; }

        public override string ToString()
        {
            return Province?.ToString() + Prefecture?.ToString() + County?.ToString()
                + Township?.ToString() + Village?.ToString() + ResidentialGroup?.ToString()
                + Detail;
        }
    }
}