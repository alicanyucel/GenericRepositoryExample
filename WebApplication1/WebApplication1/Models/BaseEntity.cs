using System;

namespace WebApplication1.Models
{
    public class BaseEntity : IEntity
    {
        public int Id { get; set; }
        public DateTime CreatAt { get; set; }=DateTime.Now;

    }
}
