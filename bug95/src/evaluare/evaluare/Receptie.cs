using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evaluare
{
    class Receptie
    {
        byte numar_nopti; // numarul de nopti dorite pentru rezervare
        Camera camera; //camera dorita
        public Receptie(Camera camera, byte numar_nopti)
        {
            this.camera = camera;
            this.numar_nopti = numar_nopti;
            AfiseazaPret();
        }
        void AfiseazaPret()
        {
            Console.WriteLine(new Pret().DaPret(camera, numar_nopti) + " RON");
        }
    }
}
