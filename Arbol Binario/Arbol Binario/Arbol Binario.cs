using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Collections;

namespace Arbol_Binario
{
    class Arbol_Binario
    {
        public Nodo_Arbol Raiz;

       //public Nodo_Arbol aux;

       /* public Arbol_Binario() {
            aux = new Nodo_Arbol();
        }*/
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


        public void Buscar(int x) {

            if (Raiz != null)
            {
                Raiz.contarlevel(Raiz, Raiz.nivel);

                for(int a=0; a<=Raiz.num;a++){
                    Raiz.recorer(x,Raiz,Raiz.nivel,a);
                    int[] n = new int[15];
                    int valor = Convert.ToInt32(Raiz.cola.Count);
                    for (int val = 0; val <= valor - 1; val++)
                    {
                        int res = Convert.ToInt32(Raiz.cola.Dequeue());
                       
                        
                    }
                }


                
            }
            else { MessageBox.Show("nada"); }
        }

        public void DibujarArbol(Graphics grafo, Font fuente, Brush Relleno, Brush RellenoFuente, Pen Lapiz, Brush encuentro) {
            int x = 250;
            int y = 75;

            if (Raiz == null) return;
            Raiz.PosicionNodo(ref x, y);
            Raiz.DibujarRamas(grafo,Lapiz);
            Raiz.DibujarNodo(grafo,fuente,Relleno,RellenoFuente,Lapiz,encuentro);
        }


        public int x1 =400;
        public int y2 = 75;

    }
}
