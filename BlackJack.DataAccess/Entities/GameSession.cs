using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.DataAccess.Entities
{
    [Table("GameSessions")]
    public class GameSession: BaseEntity
    {
        public DateTime CreationDate { get; set; }

        public GameSession()
        {
            var date = DateTime.Now;
            CreationDate = new DateTime(date.Year, date.Month, date.Day, date.Hour, date.Minute, 0, DateTimeKind.Utc);
        }
    }
}
