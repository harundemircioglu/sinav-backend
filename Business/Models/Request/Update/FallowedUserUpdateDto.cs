using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Update
{
    public class FallowedUserUpdateDto
    {
        public int user_id { get; set; }
        public int fallowed_user_id { get; set; }
    }
}
