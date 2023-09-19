using _01_SaveReadFile.Models;
using System.Text.Json;

namespace _01_SaveReadFile.Services;

internal class CustomerService
{
    private List<Customer> _customerList = new List<Customer>();

    public void AddToList(Customer customer)
    {
        _customerList.Add(customer);

        var json = JsonSerializer.Serialize(_customerList);
        FileService.SaveToFile(json);
    }

    public void GetCustomers()
    {
        var content = FileService.ReadFromFile();
        if (!string.IsNullOrEmpty(content))
            _customerList = JsonSerializer.Deserialize<List<Customer>>(content)!;


        foreach (var customer in _customerList)
        {
            Console.WriteLine($"{customer.FirstName} {customer.LastName} <{customer.Email}>");
        }
    }
}
