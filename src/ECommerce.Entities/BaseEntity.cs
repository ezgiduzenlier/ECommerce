using System;
namespace ECommerce.Entities
{
    public class BaseEntity : IBaseEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime AddDate { get; set; }
        public short Status { get; set; }
    }
}

