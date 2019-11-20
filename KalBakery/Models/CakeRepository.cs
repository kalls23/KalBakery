using System;
using System.Collections.Generic;
using KalBakery.Model;
using System.Linq;

namespace KalBakery.Models
{
    public class CakeRepository : ICakeRepository
    {
        private readonly BakeryDbContext _bakeryContext;

        public CakeRepository(BakeryDbContext bakeryContext)
        {
            _bakeryContext = bakeryContext;
        }

        public IEnumerable<Cake> AllCakes
        {
            get
            {
                return _bakeryContext.Cakes;
            }
        }

        Cake ICakeRepository.GetCakeById(int cakeId)
        {
            return _bakeryContext.Cakes.FirstOrDefault(c => c.CakeId == cakeId);
        }
    }
}
