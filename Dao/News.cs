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
    /// 新闻头条
    /// 映射表: News
    /// </summary>
    [Table("News")]
    public class News
    {
        /// <summary>
        /// 新闻id
        /// </summary>
        [Key][Required][Index]
        public int N_Id { get; set; }

        /// <summary>
        /// 新闻标题
        /// </summary>
        [Required]
        public string N_Title { get; set; }
        /// <summary>
        /// 新闻类型
        /// </summary>
        public string N_Tyep { get; set; }

        /// <summary>
        /// 新闻正文
        /// </summary>
        [Required]
        public string N_Text { get; set; }

        /// <summary>
        /// 新闻出处
        /// </summary>
        public string N_Provenance { get; set; }

        /// <summary>
        /// 新闻发布时间
        /// </summary>
        [Required]
        public DateTime N_Date { get; set; }

        /// <summary>
        /// 新闻来源地
        /// </summary>
        public string N_Province { get; set; }
        /// <summary>
        /// 发布者
        /// </summary>
        public string N_Promulgator { get; set; }
    }
}
