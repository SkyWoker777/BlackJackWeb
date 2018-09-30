using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackJack.DataAccess.Entities
{
    [Table("GameSessions")]
    public class GameSession: BaseEntity
    {
        public DateTime CreationDate { get; set; }
    }
}
