using System;
using System.Collections.Generic;

namespace KalBakery.Model
{
    public interface ICakeRepository
    {
        IEnumerable<Cake> AllCakes { get; }
        Cake GetCakeById(int cakeId);
    }
}
