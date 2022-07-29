using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace WebAPI.Models
{
    public class HangHoaLego
    {
        public string TenHangHoa { get; set; }
        public double DonGia { get; set; }
    }

    public class HangHoa : HangHoaLego
    {
        public Guid MaHangHoa { get; set; }
    }

}