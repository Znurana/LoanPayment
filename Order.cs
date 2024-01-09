using System;
namespace LoanPayment
{
	public class Order
	{
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderBrief { get; set; }
        public List<OrderLine> OrderLines  { get; set; }

    }
}

