using System;
using System.Collections.Generic;

namespace KalBakery.ViewModels
{
    public class CakeListViewModel
    {
      public IEnumerable<Cake> Cakes { get; set; }
      public string Title { get; set; }
    }
}
