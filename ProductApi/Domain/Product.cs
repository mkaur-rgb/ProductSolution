using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductApi.Domain;
using ProductApi.Infrastructure;


namespace ProductApi.Domain
{
    public class Product
    {

    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }

    }
}