﻿using BaseLib.Model;

namespace NorthwndWS.Model.Entities
{
    public class Customer:BaseEntity<string>
    {
        public string CompanyName { get; set; }
        public string? ContactName { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
    }
}
