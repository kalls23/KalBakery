using System;
namespace KalBakery
{
    public class Cake
    {

        public int CakeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool InStock { get; set; }

        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }

        public Cake()
        {
        }
    }
}
