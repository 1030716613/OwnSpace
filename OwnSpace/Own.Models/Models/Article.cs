﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Own.Models
{
    /// <summary>
    /// 数据库对应的实体
    /// </summary>
    public class Article
    {
        /// <summary>
        /// 文章Id
        /// </summary>
        public int Id { get; set; }
        public string NewsName { get; set; }
        /// <summary>
        /// 文章作者
        /// </summary>
        public string NewsAuthor { get; set; }
        public string Abstract { get; set; }
        public int NewsStatus { get; set; }
        public string NewsImg { get; set; }
        public string NewsLook { get; set; }
        public string NewsTop { get; set; }
        public DateTime NewsTime { get; set; }
        public string Content { get; set; }
        public string NewsUrl { get; set; }
    }
}
