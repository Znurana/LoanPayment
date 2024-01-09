using System;
using System.ComponentModel.Design;

namespace LoanPayment
{
    public  class ServiceOperation
    {
        public static  Company CreateCompany()
        {
            Company company = new Company();
            Console.WriteLine("Enter Company name : ");
             company.Name = Console.ReadLine();
            Console.WriteLine("Enter Company  Description : ");
            company.Description = Console.ReadLine();
            Console.WriteLine("Enter Company Year Founded : ");
            company.YearFounded = int.Parse(Console.ReadLine());
            return company;
        }

        public static Category CreateCategory(int companyid)
        {
            Category category = new Category();
            category.CompanyId = companyid;
            Console.WriteLine("Enter Category name : ");
            category.Name = Console.ReadLine();
            Console.WriteLine("Enter Category  Description : ");
            category.Description = Console.ReadLine();
            return category;

        }

        public static Product CreateProduct(int productCategoryId)
        {
            Product product = new Product();
            Console.WriteLine("Enter Product name : ");
            product.Title = Console.ReadLine();
            Console.WriteLine("Enter Product Description : ");
            product.Description = Console.ReadLine();
            Console.WriteLine("Enter Product Price : ");
            product.Price =float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Product Stock : ");
            product.Stock = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Product Brand : ");
            product.Brand = Console.ReadLine();
            product.CategoryId = productCategoryId;
            return product;


        }

        public static int ShowCompanies(List<Company> createdCompanies)
        {
            foreach (var item in createdCompanies)
            {
                Console.WriteLine(item.Id + " "  +item.Name + " " +  item.Description );
            }

            Console.WriteLine("Select Company Id");
            int selectedId = int.Parse(Console.ReadLine());
            return selectedId;

        }

        public static int ShowCategories(List<Category> categories)
        {
            foreach (var item in categories)
            {
                Console.WriteLine(item.Id + " " + item.Name + " " + item.Description);
            }

            Console.WriteLine("Select Category Id");
            int selectedId = int.Parse(Console.ReadLine());
            return selectedId;

        }
    }

}

