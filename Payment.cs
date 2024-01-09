using System;
using LoanPayment.Enums;

namespace LoanPayment
{
	public class Payment
	{
		public int Id { get; set; }
		public float Amount { get; set; }
		public int LoanId { get; set; }
		public DateTime PayDate { get; set; }
		public PaymentType  Type { get; set; }
	}
}

