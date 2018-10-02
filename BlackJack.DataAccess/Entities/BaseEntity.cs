using System;
using System.ComponentModel.DataAnnotations;

namespace BlackJack.DataAccess.Entities
{
    public abstract class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }
    }
}
