using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Own.Models
{
    public class ArticleViewModel
    {
        /// <summary>
        /// 文章Id
        /// </summary>
        public int Id { get; set; }
        public string NewsName { get; set; }
        public string NewsAuthor { get; set; }
        public string Abstract { get; set; }
        public int NewsStatus { get; set; }
        public string NewsImg { get; set; }
        public string NewsLook { get; set; }
        public string NewsTop { get; set; }
        public string NewsTime { get; set; }
        public string Content { get; set; }
        public string NewsUrl { get; set; }
    }
}
