using BethanysPieShop.Models;
using System.Collections;
using System.Collections.Generic;

namespace BethanysPieShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Pie> PiesOfTheWeek { get; set; }
    }
}
