﻿using Invention.Domain.Commons;

namespace Invention.Domain.Entities
{
    public class Market : Auditable
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
    }
}
