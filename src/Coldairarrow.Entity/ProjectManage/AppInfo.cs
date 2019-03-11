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
        /// Ӧ��ID
        /// </summary>
        [Key, Column(Order = 1)]
        public String Id { get; set; }

        /// <summary>
        /// ��λID
        /// </summary>
        public String CorpId { get; set; }

        /// <summary>
        /// Ӧ������
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
        /// ������
        /// </summary>
        public String Creator { get; set; }

        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// ����״̬
        /// </summary>
        public Int32 IsPublic { get; set; }

        /// <summary>
        /// ʾ��Ӧ��
        /// </summary>
        public Int32 IsExample { get; set; }

        /// <summary>
        /// Ӧ�ý�ͼ
        /// </summary>
        public String AppImage { get; set; }

        /// <summary>
        /// ��ǰ����
        /// </summary>
        public String Token { get; set; }

        /// <summary>
        /// ���ӵ�ַ
        /// </summary>
        public String AppUrl { get; set; }

        /// <summary>
        /// ��ע
        /// </summary>
        public String BZ { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public String Des { get; set; }

        /// <summary>
        /// ����ɾ����ǣ�1��δɾ����2����ɾ����
        /// </summary>
        public Int32 IsAble { get; set; }

        /// <summary>
        /// ����
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