using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.SignalR;
namespace MvcMoview.Models;
{
public class Employee: Person
    {
    public String EmployeeId {get; set;}
    public int Age{get;set;}

    }
}