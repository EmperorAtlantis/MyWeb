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
    /// 后台管理者
    /// 映射数据表:  Managers
    /// </summary>
    [Table("Managers")]
    public class Manager
    {
        /// <summary>
        /// 管理者id
        /// </summary>
        [Key][Required][Index]
        public int M_Id { get; set; }
        /// <summary>
        /// 管理者
        /// </summary>
        [Required][MaxLength(50)]
        public string M_Name { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        [Required][MaxLength(50)]
        public string M_Password { get; set; }
        /// <summary>
        /// 权利级别
        /// </summary>
        [Required]
        public int M_Power { get; set; }
        
    }
}
