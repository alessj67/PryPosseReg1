using System;
using System.Collections.Generic;
using System.Text;

namespace PryPosseReg1
{
    internal class clsVector
    {
        //Declarar una etructura para el registro de clientes

        public struct RegCli
        {
            public int codigo;
            public decimal deuda;
            public decimal limite;
            public string usuario;

        };

        public static RegCli[] clientes = new RegCli[5];

        public static int ind = 0;

        public static void Precarga()
        {
            clientes[ind].codigo = 1;
            clientes[ind].usuario = "Dr.Alvarez";
            clientes[ind].limite = 100;
            clientes[ind].deuda = 50;
            ind++;

            clientes[ind].codigo = 2;
            clientes[ind].usuario = "Antonela Pane";
            clientes[ind].limite = 200;
            clientes[ind].deuda = 100;
            ind++;

            clientes[ind].codigo = 3;
            clientes[ind].usuario = "Tatiana";
            clientes[ind].limite = 300;
            clientes[ind].deuda = 150;
            ind++;

            clientes[ind].codigo = 4;
            clientes[ind].usuario = "Nerea";
            clientes[ind].limite = 500;
            clientes[ind].deuda = 250;
            ind++;
        }

        public void Agregar(string cod, string usu, string lim, string deu)
        {
            if (ind < clientes.Length)
            {
                //Busqueda secuencial
                Int32 i = 0;
                while (clientes[i].codigo != Convert.ToInt32(cod) && i < clsVector.ind)
                {
                    i++;
                }
                if (ind == 1)
                {
                    clientes[ind].codigo = Convert.ToInt32(cod);
                    clientes[ind].usuario = usu;
                    clientes[ind].limite = Convert.ToDecimal(lim);
                    clientes[ind].deuda = Convert.ToInt32(deu);
                }
                else
                {
                    MessageBox.Show("el codigo ya existe");
                }

            }
        }
        public void OrdenarCodigoAscendente()
        {

            RegCli aux;

            for (int i = 0; i < ind - 1; i++)
            {
                for (Int32 k = 0; k < ind - 1; k++)
                {
                    if (clientes[k].codigo > clientes[k + 1].codigo)
                    {
                        aux = clientes[k];
                        clientes[k] = clientes[k + 1];
                        clientes[k + 1] = aux;
                    }
                }
            }
        }

        public void OrdenarCodigoDescendente()
        {

            RegCli aux;

            for (int i = 0; i < ind - 1; i++)
            {
                for (Int32 k = 0; k < ind - 1; k++)
                {
                    if (clientes[k].codigo < clientes[k + 1].codigo)
                    {
                        aux = clientes[k];
                        clientes[k] = clientes[k + 1];
                        clientes[k + 1] = aux;
                    }
                }
            }
        }

        public void OrdenarNombreAscendente()
        {
            RegCli aux;

            for (int i = 0; i < ind - 1; i++)
            {
                for (Int32 k = 0; k < ind - 1; k++)
                {
                    if (clientes[k].usuario.CompareTo(clientes[k + 1].usuario) > 0)
                    {
                        aux = clientes[k];
                        clientes[k] = clientes[k + 1];
                        clientes[k + 1] = aux;
                    }

                }
            }
        }

        public void OrdenarNombreDescendente()
        {
            RegCli aux;

            for (int i = 0; i < ind - 1; i++)
            {
                for (Int32 k = 0; k < ind - 1; k++)
                {
                    if (clientes[k].usuario.CompareTo(clientes[k + 1].usuario) < 0)
                    {
                        aux = clientes[k];
                        clientes[k] = clientes[k + 1];
                        clientes[k + 1] = aux;
                    }

                }
            }
        }

        public void OrdenarDeudaAscendente()
        {
            RegCli aux;

            for (int i = 0; i < ind - 1; i++)
            {
                for (Int32 k = 0; k < ind - 1; k++)
                {
                    if (clientes[k].deuda > clientes[k + 1].deuda)
                    {
                        aux = clientes[k];
                        clientes[k] = clientes[k + 1];
                        clientes[k + 1] = aux;
                    }

                }
            }
        }

        public void OrdenarDeudaDescendente()
        {
            RegCli aux;

            for (int i = 0; i < ind - 1; i++)
            {
                for (Int32 k = 0; k < ind - 1; k++)
                {
                    if (clientes[k].deuda < clientes[k + 1].deuda)
                    {
                        aux = clientes[k];
                        clientes[k] = clientes[k + 1];
                        clientes[k + 1] = aux;
                    }

                }
            }
        }

        public void OrdenarLimiteAscendente()
        {
            RegCli aux;

            for (int i = 0; i < ind - 1; i++)
            {
                for (Int32 k = 0; k < ind - 1; k++)
                {
                    if (clientes[k].limite > clientes[k + 1].limite)
                    {
                        aux = clientes[k];
                        clientes[k] = clientes[k + 1];
                        clientes[k + 1] = aux;
                    }

                }
            }
        }


        public void OrdenarLimiteDescendente()
        {
            RegCli aux;

            for (int i = 0; i < ind - 1; i++)
            {
                for (Int32 k = 0; k < ind - 1; k++)
                {
                    if (clientes[k].limite < clientes[k + 1].limite)
                    {
                        aux = clientes[k];
                        clientes[k] = clientes[k + 1];
                        clientes[k + 1] = aux;
                    }

                }
            }
        }
    }
}
