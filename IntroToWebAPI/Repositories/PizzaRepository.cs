using IntroToWebAPI.Interfaces;
using IntroToWebAPI.Models;

namespace IntroToWebAPI.Repositories;

public class PizzaRepository : IPizzaRepository
{

    private static List<Pizza> _pizzaData = new()
    {
        new Pizza() 
        { 
         Id = 1,
         CrustType = "thick",
         Extras = "",
         Size = "Large",
         Toppings = new() { "pepperoni", "sausage", "jalapenos" 
         } 
        
        },
        new Pizza()
        { 
         Id = 2,
         CrustType = "thin",
         Extras = "",
         Size = "Medium",
         Toppings = new() { "ham", "sausage", "jalapenos"
         }

        },
        new Pizza()
        {
         Id=3,
         CrustType = "Deep Dish",
         Extras = "",
         Size = "Large",
         Toppings = new() { "Chicken", "sausage", "Bacon"
         }

        },
        new Pizza()
        {
         Id = 4,
         CrustType = "thin",
         Extras = "",
         Size = "Small",
         Toppings = new() { "cheese"
         }

        }

};

    public Pizza GetById(int id)
    {
        return _pizzaData.FirstOrDefault(p => p.Id == id);
    }

    public List<Pizza> GetAll()
    {
        return _pizzaData;
    }

    public bool Create (Pizza value)
    {
        _pizzaData.Add(value);
        
    }

    public void Delete (int id)
    {
        Pizza pizzaToDelete =  _pizzaData.FirstOrDefault(p => p.Id == id);
        _pizzaData.Remove(pizzaToDelete);

      
    }


}