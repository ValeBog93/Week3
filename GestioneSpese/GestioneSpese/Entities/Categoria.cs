using System;
using System.Collections.Generic;
using System.Text;

namespace GestioneSpese.Entities
{
  public  class Categoria : IEntity
    {
        public int ID { get; set; }
        public string Categori { get; set; }
        public ICollection<Spese> Spesa { get; set; } = new List<Spese>();

    }
}
