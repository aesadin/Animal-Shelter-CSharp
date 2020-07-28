using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.ComponentModel.DataAnnotations;

namespace AnimalShelter.Models
{
  public class Animal
  {
    public int AnimalId { get; set; }
    public string Type { get; set; }
    public int Age { get; set; }
    public string Breed { get; set; }
    public string Name { get; set; }

  }
}