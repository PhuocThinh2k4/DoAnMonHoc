using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebBanHang.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        [Required(ErrorMessage = "Nhập họ tên đầy đủ")]
        public string CustomerName { get; set; }

        [Required(ErrorMessage = "Nhập địa chỉ giao hàng")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Nhập số điện thoại")]
        public string Phone { get; set; }
        public double Total { set; get; }
        public string State { set; get; }
    }
}
