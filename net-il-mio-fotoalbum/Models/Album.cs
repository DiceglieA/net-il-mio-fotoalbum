using Microsoft.EntityFrameworkCore;

namespace net_il_mio_fotoalbum.Models
{
    public class AlbumContext : DbContext
    {
        public AlbumContext(DbContextOptions<AlbumContext> options) : base(options) { }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Category> Categories { get; set; }

        public void Seed()
        {
            var fotos = new Photo[]
            {
                new Photo
                {
                    Title = "Seaside",
                    Description = "Spiaggia ",
                    Pic = "https://www.focusjunior.it/content/uploads/2016/09/spiaggia.jpg",
                    IsVisible = true,
                },
                new Photo
                {
                    Title = "Quokka",
                    Description = "Tipico animale australiano",
                    Pic = "https://critter.science/wp-content/uploads/2020/05/quokka1.png",
                    IsVisible = false,
                },
                new Photo
                {
                    Title = "Expo",
                    Description = "expo milano",
                    Pic = "https://media-assets.wired.it/photos/61aa0d3e669135db44015027/16:9/w_1872,h_1053,c_limit/albero%20della%20vita%20mind.jpg",
                    IsVisible = true,
                },

            };
            if (!Photos.Any())
            {
                Photos.AddRange(fotos);
            }
            if (!Categories.Any())
            {
                var seed = new Category[]
                {
                    new()
                    {
                        Name = "Landscapes",
                        Photos = Photos
                    },
                    new()
                    {
                        Name = "Animals"
                    },
                    new()
                    {
                        Name = "Events"
                    },
                };
                Categories.AddRange(seed);
            }
            SaveChanges();
        }
    }
}