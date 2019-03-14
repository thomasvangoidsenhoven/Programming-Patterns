using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public interface IObserver
    {
        void Update(Nut subject);
    }


    public class NutStore : IObserver
    {
        private Nut _nut;

        public NutStore(Nut nut)
        {
            _nut = nut;
            _nut.AddObserver(this);
        }

        public void Update(Nut subject)
        {
            Console.WriteLine($"The nut is now worth {_nut.Price}");
        }
    }
}
