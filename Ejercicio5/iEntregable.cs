using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio5
{
    interface iEntregable
    {
        void entregar();
        void devolver();
        bool isEntregado();

        bool compareTo(Object a);

    }
}
