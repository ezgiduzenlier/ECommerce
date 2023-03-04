using System;
namespace ECommerce.Entities
{
	public interface IBaseEntity
	{
        int Id { get; set; }
        string? Name { get; set; }
        DateTime AddDate { get; set; }
        short Status { get; set; }
    }
}

