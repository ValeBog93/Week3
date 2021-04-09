using System;
using System.Collections.Generic;
using System.Text;

namespace GestioneSpese.Entities
{
  public  class Spese:IEntity
    {
        public int ID { get; set; }
        public DateTime Data { get; set; }
        public Categoria Categoria { get; set; }
        public int CategoriaId { get; set; }
        public string Descizione { get; set; }
        public string Utente { get; set; }
        public decimal Importo { get; set; }
        public byte Approvato { get; set; }

        public ICollection<Categoria> Categorie { get; set; } = new List<Categoria>();

    }
}
