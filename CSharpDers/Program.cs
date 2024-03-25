using CSharpDers.Business;
using CSharpDers.DateAccess.Concretes;
using CSharpDers.Entities;



CourseManager courseManager = new(new EfCourseDal());
List<Course> courses2 = courseManager.GetAll();

for (int i = 0; i < courses2.Count; i++)
{
    Console.WriteLine(courses2[i].Name + "/" + courses2[i].Price);
}

IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.NationalIdentity = "12345678931";
customer1.FirstName = "Metin";
customer1.LastName = "Yıldız";
customer1.CustomerNumber = "123431";

IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.NationalIdentity = "12345678911";
customer2.FirstName = "Mami";
customer2.LastName = "Arslan";
customer2.CustomerNumber = "122345";

CorporateCustomer customer3 = new CorporateCustomer();
customer3.Id = 3;
customer3.Name = "kodlamaio";
customer3.CustomerNumber = "987654";
customer3.TaxNumber = "12345678999";

CorporateCustomer customer4 = new CorporateCustomer();
customer4.Id = 4;
customer4.Name = "abcd";
customer4.CustomerNumber = "987455";
customer4.TaxNumber = "98765432111";

BaseCustomer[] customers = { customer1, customer2,  customer3, customer4 };

foreach (BaseCustomer customer in customers)
{
    Console.WriteLine(customer.CustomerNumber);
}