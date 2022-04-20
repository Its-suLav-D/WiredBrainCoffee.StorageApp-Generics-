
// See https://aka.ms/new-console-template for more information
using WiredBrainCoffee.StorageApp.Repositories;
using WiredBrainCoffee.StorageApp.Entities;

var empRepo = new GenericRepository<Employee>();
AddEmployees(empRepo);

GetEmployeeById(empRepo);



var orgRepo = new GenericRepository<Organization>();
AddOrganizations(orgRepo);



static void AddOrganizations(GenericRepository<Organization> orgRepo)
{
    orgRepo.Add(new Organization { Name = "PluralSight" });
    orgRepo.Add(new Organization { Name = "Doble Engineering" });
    orgRepo.Add(new Organization { Name = "Amazon" });


    orgRepo.Save();
}

static void AddEmployees(GenericRepository<Employee> empRepo)
{
    empRepo.Add(new Employee { FirstName = "Julia" });
    empRepo.Add(new Employee { FirstName = "Anna" });
    empRepo.Add(new Employee { FirstName = "Thomas" });

    empRepo.Save();
}

 static void GetEmployeeById(GenericRepository<Employee> empRepo)
{
    var employee = empRepo.GetById(2);
    Console.WriteLine($"Employee with Id 2: {employee}");
}