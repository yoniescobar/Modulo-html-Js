using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using Tarea5C_CONSULTA.Models;

namespace Tarea5C_CONSULTA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LeerCustomer();
        }
        public static void LeerCustomer()
        {
            using (NorthwindContext db = new NorthwindContext())
            {
                IQueryable<Customer> paisLondon = db.Customers.Where(p => p.City == "London")
                                                              .OrderBy(p => p);
                Console.WriteLine("País ------------ Nombre de compania");
                foreach (Customer pais  in paisLondon)
                {
                    Console.WriteLine($"{ pais.City,5} \t\t {pais.CompanyName,-8}  ");
                }

            }

        }

    }
}
