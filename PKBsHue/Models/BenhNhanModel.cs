using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PKBsHue.Models
{
    public class BenhNhanModel
    {
        [Key]
        public int Id { get; set; }
        public string MaBN { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public int NamSinh { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string CMND { get; set; }
    }
}
