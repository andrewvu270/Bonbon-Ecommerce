using Bonbon_Ecommerce.Models;
using System.Collections.Generic;

namespace Bonbon_Ecommerce.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Candy> CandyOnSale { get; set; }
    }
}
