namespace LoanPayment;

class Program
{
    static List<Company> companies = new List<Company>();

    static void Main(string[] args)
    {
        ShowMenu();
    }

    public static void MainMenu()
    {

        Console.WriteLine("1. Create company ");
        Console.WriteLine("2. Create category ");
        Console.WriteLine("3. Create product ");
        Console.WriteLine("4. Create User ");
        Console.WriteLine("6. Exit ");
    }

    public static void ShowMenu()
    {
        int menu, companyId = 0;
        Company selectedCompany = null;
        do
        {
            MainMenu();
            Console.Write("Choose from menu: (number 1-6 )" );
            menu = int.Parse(Console.ReadLine());
            switch (menu)
            {
                case 1:
                    Console.WriteLine($"You choose Create Company ");
                    Company company = ServiceOperation.CreateCompany();
                    companies.Add(company);
                    break;
                case 2:
                    Console.WriteLine($"You choose Create Category ");
                    companyId = ServiceOperation.ShowCompanies(companies);
                    Category category = ServiceOperation.CreateCategory(companyId);
                     selectedCompany = companies.Where(x => x.Id == companyId).FirstOrDefault();
                    selectedCompany.Categories.Add(category);
                    break;
                case 3:
                    Console.WriteLine($"You choose Create product");
                    companyId = ServiceOperation.ShowCompanies(companies);
                     selectedCompany = companies.Where(x => x.Id == companyId).FirstOrDefault(); //secim
                   int selectedCategoryId= ServiceOperation.ShowCategories(selectedCompany.Categories); //categorileri gosterir ve secir
                    Product product = ServiceOperation.CreateProduct(selectedCategoryId);
                    Category selectedcategory = selectedCompany.Categories.Where(x => x.Id == selectedCategoryId).FirstOrDefault();
                    selectedcategory.Products.Add(product);
                    break;
                case 4:
                    break;
                default:
                    break;
            }
        } while (menu != 6);

    }





}











