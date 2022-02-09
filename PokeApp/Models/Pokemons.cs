using System;
using System.Collections.Generic;
using System.Text;

namespace PokeApp.Models
{
    public class Pokemons
    {
        public int id;
        public string name;
        public string type;
        public string image;

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Type
        {
            get => type;
            set => type = value;
        }

        public string Image
        {
            get => image;
            set => image = value;
        }
    }
}
