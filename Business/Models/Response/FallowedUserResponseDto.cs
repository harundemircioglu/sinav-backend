using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
    public class FallowedUserResponseDto
    {
        public int Id { get; set; }
        public int user_id { get; set; }
        public int fallowed_user_id { get; set; }
        public UserProfileDto User { get; set; }
    }
}
