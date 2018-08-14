using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dao
{
    /// <summary>
    /// 客户
    /// 映射数据表: Customer
    /// </summary>
    [Table("Customer")]
    public class Customer
    {
        /// <summary>
        /// 客户id
        /// </summary>
        [Key]
        [Required]
        [Index]
        public int C_Id { get; set; }
        /// <summary>
        /// 客户的用户名
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string C_Username { get; set; }
        /// <summary>
        /// 客户登录密码
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string C_PassWord { get; set; }
        /// <summary>
        /// 个性签名
        /// </summary>
        [MaxLength(300)]
        public string C_Signature { get; set; }
        /// <summary>
        /// 客户真实姓名
        /// </summary>
        public string C_RealName { get; set; }
        /// <summary>
        /// 客户性别: 0,女   1,男
        /// </summary>
        //[Required]
        public bool C_Sex { get; set; }
        /// <summary>
        /// 客户电话
        /// </summary>
        public string C_Tel { get; set; }
        /// <summary>
        /// 客户传真
        /// </summary>
        public string C_Fax { get; set; }
        /// <summary>
        /// 客户电子邮件
        /// </summary>
        public string C_Email { get; set; }
        /// <summary>
        /// 客户地址
        /// </summary>
        public string C_Address { get; set; }
        /// <summary>
        /// 客户注册时间
        /// </summary>
        public DateTime C_RegistrationDate { get; set; }
        /// <summary>
        /// 企业名称
        /// </summary>
        public string C_Company { get; set; }
        /// <summary>
        /// 企业类型
        /// </summary>
        public int C_CompanyType { get; set; }
        /// <summary>
        /// 登录次数
        /// </summary>
        public double C_LogNum { get; set; }
        /// <summary>
        /// 最后一次登录时间
        /// </summary>
        public DateTime C_LastLog { get; set; }
        /// <summary>
        /// vip是否过期
        /// </summary>
        [Required]
        public bool C_IsVip { get; set; }
        /// <summary>
        /// 账户是否可用
        /// </summary>
        [Required]
        public bool C_IsUsable { get; set; }

    }
}
