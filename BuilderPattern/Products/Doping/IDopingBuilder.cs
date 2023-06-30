using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Products.Doping
{
    public interface IDopingBuilder
    {
        IDopingBuilder WithKetchup();

        void WithOnion();

        void WithAdjika();

        void WithMustard();

        void WithMayonnaise();

        void WithSalt();

        void WithPepper();

        void WithVerdure();

        Doping GetDoping();
    }
}
