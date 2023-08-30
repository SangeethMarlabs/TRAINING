﻿using System;
namespace Domain.Models
{
    public class BaseEntity
    {
        public Int64 Id { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string IpAddress { get; set; }
    }
}
