using PokeApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.ComponentModel;
namespace PokeApp.ViewModels
{
    public class PokemonsVM : INotifyPropertyChanged
    {
        private ObservableCollection<Pokemons> myList;

        public event PropertyChangedEventHandler PropertyChanged;
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
                    Id = 719,
                    Name = "Diancie",
                    Type = "Normal",
                    Image = "Diancie.png"
                }
            };
        }
    }
}
