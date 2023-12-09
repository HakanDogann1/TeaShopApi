using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaShopApi.DtoLayer.DTOs
{
    public class UpdatePricingDto
    {
        public int PricingId { get; set; }
        public string Title { get; set; }
        public string Icon { get; set; }
        public string Value { get; set; }
    }
}
