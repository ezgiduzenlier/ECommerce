using System;
namespace ECommerce.Entities

{
	public class Product:BaseEntity
	{
		public  string? Description { get; set; }
		public decimal Price { get; set; }
		public int CategoryId{ get; set; }
		public int BrandId { get; set; }
		public int Stock { get; set; }
	}
}

