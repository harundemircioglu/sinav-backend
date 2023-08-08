using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
    public class TweetResponseDto
    {
        public int Id { get; set; }
        public int user_id { get; set; }
        public string tweet_header { get; set; }
        public string tweet_detail { get; set; }
        public int likes { get; set; }
        public UserProfileDto User { get; set; }
    }
}
