﻿using System.Transactions;

namespace TransactionApp.Models
{
    public class Customer:BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; } 
        public string Phone { get; set; }
        public string Email { get; set; }
        public ICollection<Transaction> Transactions { get; set; }
    }
}
