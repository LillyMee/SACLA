namespace SACLA.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
	using SACLA.Models.Data;

	internal sealed class Configuration : DbMigrationsConfiguration<SACLA.Models.Data.PaperDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(SACLA.Models.Data.PaperDbContext context)
        {
            //add papers
            context.Paper.AddOrUpdate(s => s.title,
                new Paper { title = "Welcome to ASP.net", paperAbstract = "lillydhliwayo@gmail.com" },
                new Paper { title = "I love ASP.net", paperAbstract= "lillydhliwayo@gmail.com" },
                new Paper { title = "Let me Code!", paperAbstract = "lillydhliwayo@gmail.com" },
                new Paper { title = "Coding is too hard.", paperAbstract = "lillydhliwayo@gmail.com" });
        }
    }
}
