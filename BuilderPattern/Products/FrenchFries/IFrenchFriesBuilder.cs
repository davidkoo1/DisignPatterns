using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Products.FrenchFries
{
    public interface IFrenchFriesBuilder
    {

        void WithSauce();

        void WithSpices();

        FrenchFries GetFrenchFries();

    }
}
