using PokeApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace PokeApp.ViewModels
{
    public class PokemonsVM
    {
        private ObservableCollection<Pokemons> myList;

        public ObservableCollection<Pokemons> MyList
        {
            get { return myList; }
            set { myList = value; }
        }

        public PokemonsVM()
        {
            MyList = new ObservableCollection<Pokemons>() {
                new Pokemons()
                {
                    Id = 1,
                    Name = "Diancie",
                    Type = "Normal"
                },
            };
        }
    }
}
