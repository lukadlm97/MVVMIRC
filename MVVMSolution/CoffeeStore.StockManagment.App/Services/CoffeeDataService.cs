﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeStore.StockManagment.Model;
using CoffeeStore.StockManagment.DAL;

namespace CoffeeStore.StockManagment.App.Services
{
    class CoffeeDataService : IDataService
    {
        ICoffeeRepository repository;
        public CoffeeDataService(ICoffeeRepository repository)
        {
            this.repository = repository;
        }
        public void DeleteCoffee(Coffee coffee)
        {
            repository.DeleteCoffee(coffee);
        }

        public List<Coffee> GetAllCoffees()
        {
            return repository.GetCoffees();
        }

        public Coffee GetCoffeeDetail(int coffeeId)
        {
            return repository.GetCoffeeById(coffeeId);
        }

        public void UpdateCoffee(Coffee coffee)
        {
            repository.UpdateCoffee(coffee);
        }
    }
}
