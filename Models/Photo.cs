﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    public class Photo : BaseModel
    {
        public string Name { get; set; }
        public string ImageType { get; set; }
        public string Content { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
