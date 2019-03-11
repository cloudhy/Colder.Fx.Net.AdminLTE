using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coldairarrow.Entity.ProjectManage
{
    /// <summary>
    /// AppInfo
    /// </summary>
    [Table("AppInfo")]
    public class AppInfo
    {

        /// <summary>
        /// 应用ID
        /// </summary>
        [Key, Column(Order = 1)]
        public String Id { get; set; }

        /// <summary>
        /// 单位ID
        /// </summary>
        public String CorpId { get; set; }

        /// <summary>
        /// 应用名称
        /// </summary>
        public String Name { get; set; }

        /// <summary>
        /// CompanyName
        /// </summary>
        public String CompanyName { get; set; }

        /// <summary>
        /// BriefName
        /// </summary>
        public String BriefName { get; set; }

        /// <summary>
        /// DataExchange
        /// </summary>
        public String DataExchange { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public String Creator { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 公开状态
        /// </summary>
        public Int32 IsPublic { get; set; }

        /// <summary>
        /// 示范应用
        /// </summary>
        public Int32 IsExample { get; set; }

        /// <summary>
        /// 应用截图
        /// </summary>
        public String AppImage { get; set; }

        /// <summary>
        /// 当前令牌
        /// </summary>
        public String Token { get; set; }

        /// <summary>
        /// 链接地址
        /// </summary>
        public String AppUrl { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public String BZ { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public String Des { get; set; }

        /// <summary>
        /// 虚拟删除标记（1：未删除，2：已删除）
        /// </summary>
        public Int32 IsAble { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public Int32 OrderX { get; set; }

        /// <summary>
        /// LeaderName
        /// </summary>
        public String LeaderName { get; set; }

        /// <summary>
        /// LeaderPhone
        /// </summary>
        public String LeaderPhone { get; set; }

        /// <summary>
        /// OwnerCompanyName
        /// </summary>
        public String OwnerCompanyName { get; set; }

        /// <summary>
        /// OwnerCompanyCode
        /// </summary>
        public String OwnerCompanyCode { get; set; }

        /// <summary>
        /// SourceNetId
        /// </summary>
        public String SourceNetId { get; set; }

        /// <summary>
        /// ShareNetId
        /// </summary>
        public String ShareNetId { get; set; }

    }
}