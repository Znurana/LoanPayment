using System;
using LoanPayment.Enums;

namespace LoanPayment
{
	public class Loan
	{
		public int Id { get; set; }
		public string Number { get; set; } //Kreditin nomresi Customer e aidd
		public Order Order  { get; set; }
		public float Amount { get; set; }
		public float CurrentDepth { get; set; }
		public float MonthlyPayment { get; set; }
		public int Term { get; set; }
		public LoanStatusType StatusType{ get; set; }
	}
}

