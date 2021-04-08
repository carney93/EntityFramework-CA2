using System;
using Microsoft.EntityFrameworkCore;                   
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;


namespace EFCoreCA2
{
    [Table("VideoGame")]
    public class VideoGame
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int AgeRating { get; set; }

        [Column(TypeName = "Date")]
        public DateTime ReleaseDate { get; set; }               
    }

    public class VideoGameContext : DbContext          
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=tcp:ca2-ead2.database.windows.net,1433;Initial Catalog = upcomingReleases; Persist Security Info=False;User ID = gcdb; Password=ca2_eadpassword; MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout = 30;");
        }

        public DbSet<VideoGame> VideoGames { get; set; }

    }


    static class Program
    {

        static void Add()
        { 

            using VideoGameContext db = new VideoGameContext();


            VideoGame game1 = new VideoGame() { Title = "Resident Evil Village", AgeRating = 18, ReleaseDate = new DateTime(2021, 5, 7) };
            VideoGame game2 = new VideoGame() { Title = "Mass Effect: Legendary Edition", AgeRating = 16, ReleaseDate = new DateTime(2021, 5, 14) };
            VideoGame game3 = new VideoGame() { Title = "Deathloop", AgeRating = 16, ReleaseDate = new DateTime(2021, 5, 21) };
            VideoGame game4 = new VideoGame() { Title = "Biomutant", AgeRating = 12, ReleaseDate = new DateTime(2021, 5, 25) };
            VideoGame game5 = new VideoGame() { Title = "Ratchet & Clank: Rift Apart", AgeRating = 3, ReleaseDate = new DateTime(2021, 6, 11) };
            VideoGame game6 = new VideoGame() { Title = "Mario Golf: Super Rush ", AgeRating = 3, ReleaseDate = new DateTime(2021, 6, 25) };
            VideoGame game7 = new VideoGame() { Title = "Monster Hunter Stories 2", AgeRating = 16, ReleaseDate = new DateTime(2021, 7, 9) };
            VideoGame game8 = new VideoGame() { Title = "The Legend of Zelda: Skyward Sword HD", AgeRating = 3, ReleaseDate = new DateTime(2021, 7, 14) };
            VideoGame game9 = new VideoGame() { Title = "Humankind", AgeRating = 12, ReleaseDate = new DateTime(2021, 8, 16) };
            VideoGame game10 = new VideoGame() { Title = "Hot Wheels Unleashed", AgeRating = 3, ReleaseDate = new DateTime(2021, 9, 30) };
            VideoGame game11 = new VideoGame() { Title = "Back 4 Blood", AgeRating = 18, ReleaseDate = new DateTime(2021, 10, 12) };
            VideoGame game12 = new VideoGame() { Title = "Far Cry 6", AgeRating = 16, ReleaseDate = new DateTime(2021, 11, 13) };
            VideoGame game13 = new VideoGame() { Title = "Riders Republic", AgeRating = 3, ReleaseDate = new DateTime(2021, 12, 03) };

            db.VideoGames.Add(game1);
            db.VideoGames.Add(game2);
            db.VideoGames.Add(game3);
            db.VideoGames.Add(game4);
            db.VideoGames.Add(game5);
            db.VideoGames.Add(game6);
            db.VideoGames.Add(game7);
            db.VideoGames.Add(game8);
            db.VideoGames.Add(game9);
            db.VideoGames.Add(game10);
            db.VideoGames.Add(game11);
            db.VideoGames.Add(game12);
            db.VideoGames.Add(game12);
            db.VideoGames.Add(game13);

            db.SaveChanges();

        }

        static void Main()
        {
            Add();
        }

    }
}

