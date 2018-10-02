namespace BlackJack.DataAccess.Migrations
{
    using BlackJack.DataAccess.Entities;
    using BlackJack.DataAccess.Utils;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BlackJack.DataAccess.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BlackJack.DataAccess.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            List<Card> deck = DeckFactory.CreateDeck();
            foreach(var card in deck)
            {
                context.Cards.AddOrUpdate(card);
            }
            context.SaveChanges();
        }
    }
}
