﻿using CoffeMarket.API.DAL.Entities;

namespace CoffeeMarket.API.DAL.Entities
{
	public class Coffee :EntityBase
	{
        public Guid PR_ID { get; set; }
        public string PR_Name { get; set; }
        public string PR_Price { get; set; }
        public string PR_ListImage { get; set; }
        public string PR_DetailImage { get; set; }
    }
}
