using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigMuscleShop.Application.Exeptions
{
    public class NotFoundExeption : Exception
    {
        public NotFoundExeption(string name, object key) : base($"{name} ({key}) was not found.")
        {

        }
    }
}
