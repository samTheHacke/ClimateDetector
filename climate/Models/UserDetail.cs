using System;
using System.Collections.Generic;

#nullable disable

namespace climate.Models
{
    public partial class UserDetail
    {
        public int Uid { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
