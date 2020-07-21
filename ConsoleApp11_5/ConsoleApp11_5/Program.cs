using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApp11_5
{
    class Actor
    {
        [Key]
        public int actor_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public DateTime last_update { get; set; }

        public Actor(string first_name, string last_name)
        {
            this.first_name = first_name;
            this.last_name = last_name;
            this.last_update = DateTime.Now;
        }
    }
    class MyData
    {
        public string name { get; private set; }
        public int age { get; private set; }
        public string favoriteColor { get; private set; }
        public bool hasPet { get; private set; }
        public string favoriteSport { get; private set; }


        public MyData(string name, int age, string favoriteColor, bool hasPet, string favoriteSport)
        {
            this.name = name;
            this.age = age;
            this.favoriteColor = favoriteColor;
            this.hasPet = hasPet;
            this.favoriteSport = favoriteSport;
        }
    }
    class SakilaContext : DbContext
    {
        public DbSet<Actor> Actor { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost\sqlexpress;Database=sakila;Trusted_Connection=True;");
        }
    }
    class Film
    {
        public string title { get; set; }
        public string description { get; set; }
        public int  release_year { get; set; } //this may need to be a string
        public byte language_id { get; set; }
        public byte original_language_id { get; set; }
        public byte rental_duration { get; set; }
        public decimal rental_rate { get; set; }
        public Int16 length { get; set; }
        public decimal replacement_cost { get; set; }
        public string rating { get; set; }
        public string special_features{ get; set; }
        public DateTime last_update { get; set; }


    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lab 11_5: Database to C# to HTLM");


        }
    }
}
