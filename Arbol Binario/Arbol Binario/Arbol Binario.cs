using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

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

        public void Insertar(int x) {
            if (Raiz == null)
            {
                Raiz = new Nodo_Arbol(x, null, null, null);
                Raiz.nivel = 0;
            }
            else { Raiz = Raiz.Insertar(x, Raiz, Raiz.nivel); }
        }


        public void DibujarArbol(Graphics grafo, Font fuente, Brush Relleno, Brush RellenoFuente, Pen Lapiz, Brush encuentro) {
            int x = 200;
            int y = 75;

            if (Raiz == null) return;
            Raiz.PosicionNodo(ref x, y);
            Raiz.DibujarRamas(grafo,Lapiz);
            Raiz.DibujarNodo(grafo,fuente,Relleno,RellenoFuente,Lapiz,encuentro);
        }


        public int x1 = 400;
        public int y2 = 75;

        public void colorear(Graphics grafo, Font fuente, Brush Relleno, Brush RellenoFuente,Pen Lapiz,Nodo_Arbol Raiz,bool post,bool inor,bool preor) {
            Brush entorno = Brushes.Red;

        }
    }
}
