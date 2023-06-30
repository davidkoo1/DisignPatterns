using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Products.Doping
{
    public class DopingBuilder : IDopingBuilder
    {
        private Doping _doping;

        public DopingBuilder()
        {
            _doping = new();
        }

        public IDopingBuilder WithKetchup()
        {
            _doping.Name = "Ketchup";
            _doping.Description = "Sauce";
            _doping._price = 3m;

            return this;
        }

        public void WithOnion()
        {
            _doping.Name = "Onion";
            _doping.Description = "Sauce";
            _doping._price = 2m;
        }

        public void WithAdjika()
        {
            _doping.Name = "Adjika";
            _doping.Description = "Sauce";
            _doping._price = 5m;
        }

        public void WithMustard()
        {
            _doping.Name = "Mustard";
            _doping.Description = "Sauce";
            _doping._price = 3m;
        }

        public void WithMayonnaise()
        {
            _doping.Name = "Mayonnaise";
            _doping.Description = "Sauce";
            _doping._price = 2m;
        }

        public void WithSalt()
        {
            _doping.Name = "Salt";
            _doping.Description = "Spice";
            _doping._price = 1m;
        }

        public void WithPepper()
        {
            _doping.Name = "Pepper";
            _doping.Description = "Spice";
            _doping._price = 2m;
        }

        public void WithVerdure()
        {
            _doping.Name = "Verdure";
            _doping.Description = "Parsley and dill";
            _doping._price = 2m;
        }

        public Doping GetDoping()
        {
            Doping doping = _doping;

            _doping = new();

            return doping;
        }
    }
}
