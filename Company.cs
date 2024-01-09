using System;
namespace LoanPayment
{
    public  class Company 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int YearFounded { get; set; } //CustomerPoint
        public List<Category> Categories { get; set; }

        public Company()
        {
            Categories = new List<Category>();
            this.Id = new Random().Next(1, 1000);
        }



    }
}

