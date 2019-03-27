using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arbol_Binario
{
    class Arbol_Binario
    {
        public Nodo_Arbol Raiz;
        public Nodo_Arbol aux;

        public Arbol_Binario() {
            aux = new Nodo_Arbol();
        }
        public Arbol_Binario(Nodo_Arbol nueva_raiz) {
            Raiz = nueva_raiz;
        }

        public void Insertar(int x) { }
    }
}
