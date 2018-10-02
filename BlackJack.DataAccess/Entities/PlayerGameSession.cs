using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.DataAccess.Entities
{
    [Table("PlayerGameSession")]
    public class PlayerGameSession : BaseEntity
    {
        [ForeignKey("Player")]
        public Guid PlayerId { get; set; }
        public virtual Player Player { get; set; }

        [ForeignKey("GameSession")]
        public Guid GameSessionId { get; set; }
        public virtual GameSession GameSession { get; set; }

        public int Wins { get; set; }
        public int Defeats { get; set; }
    }
}
