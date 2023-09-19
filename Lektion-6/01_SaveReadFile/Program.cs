using _01_SaveReadFile.Models;
using _01_SaveReadFile.Services;

var customerService = new CustomerService();
customerService.GetCustomers();

var customer = new Customer
{
    FirstName = "Bob",
    LastName = "Ross",
    Email = "bob@anka.com"
};
customerService.AddToList(customer);


Console.ReadKey();