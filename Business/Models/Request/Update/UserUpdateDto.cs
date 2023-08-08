using Infrastructure.Data.Postgres.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Update
{
    public class UserUpdateDto
    {
        public string name { get; set; } = default!;
        public string email { get; set; } = default!;
        public string phone { get; set; } = default!;
        public UserType UserType { get; set; }
    }
}
