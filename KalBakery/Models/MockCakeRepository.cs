using System;
using System.Collections.Generic;
using System.Linq;

namespace KalBakery.Model
{
    public class MockCakeRepository :ICakeRepository
    {

        public MockCakeRepository()
        {
        }

        public IEnumerable<Cake> AllCakes => new List<Cake>
        {
            new Cake{CakeId = 1,
                     Name="Chocolate Cake",
                     Price=10,
                     Description="A delicious Chocolate Cake",
                     InStock=true,
                     ImageThumbnailUrl = "https://localhost:5023/images/kalsBakeryLogocopy.png",
                     ImageUrl = "https://localhost:5023/images/kalsBakeryLogocopy.png"
            },
            new Cake{CakeId = 2,
                    Name="Vanilla Cake",
                    Price=8,
                    Description="A delicious Vanilla Cake",
                    InStock=true,
                    ImageThumbnailUrl = "https://localhost:5023/images/kalsBakeryLogocopy.png",
                    ImageUrl = "https://localhost:5023/images/kalsBakeryLogocopy.png"

            },
            new Cake{CakeId = 3,
                     Name="Strawberry Cake",
                     Price=17,
                     Description="A delicious Strawberry Cake",
                     InStock=true,
                     ImageThumbnailUrl = "https://localhost:5023/images/gettyimages-strawberry.jpg",
                     ImageUrl = "https://localhost:5023/images/gettyimages-strawberry.jpg"
            }

        };

        public Cake GetCakeById(int cakeId)
        {
            return AllCakes.FirstOrDefault(c => c.CakeId == cakeId);
        }
    }
}
