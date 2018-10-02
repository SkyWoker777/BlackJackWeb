using BlackJack.DataAccess.Enums;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackJack.DataAccess.Entities
{
    [Table("Cards")]
    public class Card: BaseEntity
    {
        public CardRank Rank { get; set; }
        public int Dignity { get; set; }
        public Suit Suit { get; set; }
    }
}
