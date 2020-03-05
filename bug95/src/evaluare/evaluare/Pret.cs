using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evaluare
{
    class Pret
    {
        public decimal DaPret(Camera camera, byte numar_nopti)
        {
            bool reducere = false;

            if (camera.Nume == "1")
            {
                return 200m * numar_nopti;

            }
            else if (camera.Nume == "2" || camera.Nume == "3")
            {
                return 120m * numar_nopti;
            }

            else if (camera.Nume == "4")
            {
                return 150m * numar_nopti;
            }
            else if (camera.Nume == "5" || camera.Nume == "6")
            {
                if (numar_nopti > 3) reducere = true;
                if (reducere)
                {

                    decimal discount = 0.2m * (numar_nopti - 3);
                    return 100m * numar_nopti - discount;

                }
                else return 100m * numar_nopti;
            }
            else throw new Exception("Camera inexistenta");
        }

    }
}
