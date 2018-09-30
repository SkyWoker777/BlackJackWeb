using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.DataAccess.Entities
{
    [Table("Players")]
    public class Player: BaseEntity
    {
        public string Name { get; set; }

        [NotMapped]
        public List<Card> Hand { get; set; }
    }
}
