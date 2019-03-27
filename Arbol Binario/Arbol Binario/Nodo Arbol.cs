using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace Arbol_Binario
{
    class Nodo_Arbol
    {
        public int info;                        //Datos Almacenado
        public Nodo_Arbol Izquierda;            //Rama izquiera
        public Nodo_Arbol Derecha;              //Rama Derecha
        public Nodo_Arbol Padre;                //Rama Principal
        public int altura;
        public int nivel;
        public Rectangle nodo;                  //Para dibujar el nodo

        private Arbol_Binario arbol;            //Declarando Objeto
        public Nodo_Arbol() { }                 //Constructor
        public Arbol_Binario Arbol {            //Constructor por defecto
            get { return arbol; }
            set {arbol=value;}
        }
        public Nodo_Arbol(int nueva_info, Nodo_Arbol izquierda, Nodo_Arbol derecha, Nodo_Arbol padre) {     //Constructor con parametros
            info = nueva_info;
            Izquierda = izquierda;
            Derecha=derecha;
            Padre = padre;
            altura = 0;
        }
        public Nodo_Arbol Insertar (int x, Nodo_Arbol t, int Level){
            if(t==null){
            t=new Nodo_Arbol (x,null,null,null);
            t.nivel=Level;
            }else if(x<t.info){
            Level++;
            t.Izquierda=Insertar(x,t.Izquierda,Level);
            }else if (x>t.info){
            Level++;
            t.Derecha=Insertar(x,t.Derecha,Level);
            }else{MessageBox.Show("Dato Existente en el Arbol","Error de ingreso");
            }
            return t;
        }


        public static int Alturas(Nodo_Arbol t) {   //Funcion para calcular la altura
            return t == null ? -1 : t.altura;
        }

        //Graficar Arbol
        private const int Radio = 30;
        private const int DistanciaH = 80;          //Distancia horizontal
        private const int DistanciaV = 10;          //Distancia Vertical

        private int CoordenadaX;                    //Variable de Posicion x
        private int CoordenadaY;                    //Variable de posicion Y

        public void PosicionNodo(ref int xmin, int ymin) {
            int aux1, aux2;
            CoordenadaY = (int)(ymin + Radio / 2);

            if (Izquierda != null) {
                Izquierda.PosicionNodo(ref xmin, ymin + Radio + DistanciaV);
            }

            if ((Izquierda != null) && (Derecha != null)) {
                xmin += DistanciaH;
            }

            if (Derecha != null) {
                Derecha.PosicionNodo(ref xmin, ymin + Radio + DistanciaV);
            }

            if (Izquierda != null && Derecha != null)
                CoordenadaX = (int)((Izquierda.CoordenadaX + Derecha.CoordenadaX) / 2);
            else if (Izquierda != null) {
                aux1 = Izquierda.CoordenadaX;
                Derecha.CoordenadaX = CoordenadaX - 80;
                CoordenadaX = aux1;
            }
            else if (Derecha != null) {
                aux2 = Derecha.CoordenadaX;
                Derecha.CoordenadaX = CoordenadaX + 80;
                CoordenadaX = aux2;
            }
            else { CoordenadaX = (int)(xmin + Radio / 2);
            xmin += Radio;
            }
        }
    }

  
}
