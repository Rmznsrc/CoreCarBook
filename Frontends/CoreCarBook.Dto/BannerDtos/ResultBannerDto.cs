using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCarBook.Dto.BannerDtos
{
    public class ResultBannerDto
    {
        public int BannerID { get; set; }
        public string? Title { get; set; } = null;
        public string? Description { get; set; } = null;
        public string? VideoDescription { get; set; } = null;
        public string? VideoUrl { get; set; } = null;
    }
}
