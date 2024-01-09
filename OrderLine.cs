using System;
namespace LoanPayment
{
	public class OrderLine
	{
		public int Id { get; set; }
		public int ProductId { get; set; }
		public int ProductQuantity  { get; set; }
		public float ProductUnitPrice { get; set; } //Bir mehsulun qiymeti
	}
}

