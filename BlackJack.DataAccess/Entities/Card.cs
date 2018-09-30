using BlackJack.DataAccess.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
