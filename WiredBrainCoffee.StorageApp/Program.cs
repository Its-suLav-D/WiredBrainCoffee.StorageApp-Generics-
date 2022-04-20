
// See https://aka.ms/new-console-template for more information
using WiredBrainCoffee.StorageApp.Repositories;
using WiredBrainCoffee.StorageApp.Entities;

var empRepo = new GenericRepositoryWithRemove<Employee>();
empRepo.Add(new Employee {FirstName="Julia" });
empRepo.Add(new Employee { FirstName = "Anna" });
empRepo.Add(new Employee { FirstName = "Thomas" });

empRepo.Save(); 


var orgRepo = new GenericRepository<Organization>();

orgRepo.Add(new Organization { Name = "PluralSight" });
orgRepo.Add(new Organization { Name = "Doble Engineering" });
orgRepo.Add(new Organization { Name = "Amazon" });


orgRepo.Save();
