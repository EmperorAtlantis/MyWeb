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
    /// 土地信息
    /// 映射表: LandInfo
    /// </summary>
    [Table("LandInfo")]
    public class Land
    {
        /// <summary>
        /// 土地信息id
        /// </summary>
        [Key][Required]
        public int L_Id { get; set; }

    }
}
