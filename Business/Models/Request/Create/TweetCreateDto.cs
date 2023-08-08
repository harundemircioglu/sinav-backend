using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Create
{
    public class TweetCreateDto
    {
        public int user_id { get; set; }
        public string tweet_header { get; set; }
        public string tweet_detail { get; set; }
        public int likes { get; set; }
    }
}
