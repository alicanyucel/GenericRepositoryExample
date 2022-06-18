using System;

namespace WebApplication1.Models
{
    public interface IEntity
    {
        public int Id { get; set; }
        public DateTime CreatAt { get; set; }

    }
}
