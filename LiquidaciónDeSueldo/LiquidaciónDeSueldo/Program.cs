using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liquidacion
{
    class Program
    {
        static int HorasTrabajadasSemana;
        static int HorasTrabajasfds;
        static int ValorHora;
        static string Mes;
        static int Año;
        static int Rut;
        static string Nombre;
        static string Apellido;
        static int Anticipos;
        static int sueldo;
        static int sueldofds;
        //static int Descuentos;
        static int Bonos;
        static int sueldoLiquido;
        static int sueldoBruto;
        static int previsionSalud;
        static int previsionAfp;
        static int Descuentos;


        static void Main(string[] args)
        {

            mensajeInicial();
            SolicitarHorasTraSem();
            //HorasTrabajadasSemana =
            capturarHorasTrabSem();

            SolicitarHorasTrafds();
            //HorasTrabajasfds = 
            capturarHorasTrabfds();

            SolicitarValorHora();
            capturarValorHora();

            SolicitarMes();
            capturarMes();

            SolicitarRut();
            capturarRut();

            SolicitarAño();
            capturarAño();

            solicitarNombre();
            capturarNombre();

            SolicitarApellido();
            capturarApellido();

            SolicitarAnticipos();
            capturarAnticipos();
            
            
            SolicitarBonos();
            capturarBonos();

            //sueldo = 
                SueldoHora(HorasTrabajadasSemana, ValorHora);
            sueldofds = SueldoHorafds(HorasTrabajasfds, ValorHora);

            sueldoBruto = calcularSueldoBruto(sueldo, sueldofds, Bonos);

            previsionAfp = calcularPrevisionAfp(sueldoBruto);
            previsionSalud = calcularPrevisionSalud(sueldoBruto);
            Descuentos = calcularDescuentos(Anticipos, previsionAfp, previsionSalud);

            sueldoLiquido = calcularSueldoLiquido(sueldoBruto, Descuentos);


            MostrarSueldo();



            System.Console.ReadKey();
            System.Console.Clear();
        }

        static void mensajeInicial()
        {
            Console.WriteLine("Ingrese Datos para Calcular Sueldo ");
            Console.WriteLine("");
        }

        static void SolicitarHorasTraSem()
        {
            Console.WriteLine("Ingrese Cantidad de Horas Trabajadas en la Semana :");
        }

        static void capturarHorasTrabSem()
        {
            int HorasTrabajadasSemana;
            try
            {
                
                HorasTrabajadasSemana = Convert.ToInt16(Console.ReadLine());
                return;
            }

            catch (FormatException)
            {
                Console.WriteLine("Ingrese solo Numeros ");
                return;
 
            }
            
            capturarHorasTrabSem();
            
        }



        static void SolicitarHorasTrafds()
        {
            Console.WriteLine("Ingrese Cantidad de Horas Trabajadas en el fin de Semana :");
        }

        static void capturarHorasTrabfds()
        {
            try
            { 
            int HorasTrabajadasfds;
            HorasTrabajadasfds = Convert.ToInt16(Console.ReadLine());
            return;
             }
        
            catch
            {
                Console.WriteLine("Ingrese solo Numeros :");
            }
            capturarHorasTrabfds();

           
        }


        static void SolicitarValorHora()
        {
            Console.WriteLine("Ingrese el valor de la Hora Trabajada :");
        }

        static void capturarValorHora()
        {
            try
            {
                int ValorHora;
                ValorHora = Convert.ToInt16(Console.ReadLine());
                return;
            }

            catch
            {
                Console.WriteLine("Ingrese solo numeros ");

            }
            capturarValorHora();
        }



        static void SolicitarMes()
        {
            Console.WriteLine("Ingrese el Mes actual  :");
        }

        static void capturarMes()
        {
            try
            {
                String Mes;
                Mes = System.Console.ReadLine();
                return;
            }
            catch
            {
                Console.WriteLine("Ingrese el mes en formato de texto, no Numerico :");
            }
            SolicitarMes();
        }




        static void SolicitarAño()
        {
            Console.WriteLine("Ingrese Año actual :");
        }

        static void capturarAño()
        {
            try
            {
                int Año;
                Año = Convert.ToInt32(Console.ReadLine());
                return;
            }
            catch
            {
                Console.WriteLine("Ingrese año en formato Numerico :");
            }
            capturarAño();
        }

        static void SolicitarRut()
        {
            Console.WriteLine("Ingrese su Rut sin guion :");
        }

        static void capturarRut()
        {
            try
            {
                int Rut;
                Rut = Convert.ToInt32(Console.ReadLine());
                return;
            }
            catch
            {
                Console.WriteLine("Ingrese Rut en Numeros sin guion :");
            }
            capturarRut();
        }



        static void solicitarNombre()
        {
            Console.WriteLine("Ingrese su Nombre  :");
        }

        static void capturarNombre()
        {
            try
            {
                String Nombre;
                Nombre = System.Console.ReadLine();
                return;
            }
            catch
            {
                Console.WriteLine("Ingrese Nombre sin caracteres numericos :");
            }
            capturarNombre();
        }


        static void SolicitarApellido()
        {
            Console.WriteLine("Ingrese sus Apellidos  :");
        }

        static void capturarApellido()
        {
            try
            {
                String Apellido;
                Apellido = System.Console.ReadLine();
                return;
            }
            catch
            {
                Console.WriteLine("Ingrese sus Apellidos sin caracteres Numericos :");
            }
            capturarApellido();
        }

        static void SolicitarAnticipos()
        {
            Console.WriteLine("Ingrese el monto de su Anticipo Mensual :");
        }

        static int capturarAnticipos()
        {
            int Anticipos;
            Anticipos = Convert.ToInt32(Console.ReadLine());
            return Anticipos;
        }



        static void SolicitarBonos()
        {
            Console.WriteLine("Ingrese el valor total de los Bonos   :");
        }

        static void capturarBonos()
        {
            try
            {
                int Bonos;
                Bonos = Convert.ToInt32(Console.ReadLine());
                return;
            }
            catch
            {
                Console.WriteLine("Ingrese valor Numerico   :");
            }
            capturarBonos();
        }
        

        static void SueldoHora(int HorasTrabajasSemana, int ValorHora)
        {
            int sueldo;
            sueldo = HorasTrabajadasSemana * ValorHora;
            return;

        }

        static int SueldoHorafds(int HorasTrabajadasfds, int Valorhora)
        {
            int sueldofds;
            sueldofds = HorasTrabajasfds * ValorHora * 15 / 10;
            return sueldofds;
        }




        static int calcularSueldoBruto(int sueldo, int sueldofds, int Bonos)
        {
            int sueldoBruto;
            sueldoBruto = sueldo + sueldofds + Bonos;
            return sueldoBruto;
        }




        static int calcularPrevisionSalud(int sueldoBruto)
        {
            Console.WriteLine("Seleccione tipo de previsión de Salud");
            Console.WriteLine("[1] Fonasa");
            Console.WriteLine("[2] Isapre");
            int x, previsionSalud;
            x = Convert.ToInt16(Console.ReadLine());

            if (x == 1)
            {
                previsionSalud = (sueldoBruto * 7) / 100;
                return previsionSalud;
            }
            //previsionSalud = x;
            //return x;

            if (x == 2)
            {
                Console.WriteLine("Seleccione su Isapre:  ");
                Console.WriteLine("[1] Cruz Blanca:  ");
                Console.WriteLine("[2] Vida Tres:  ");
                Console.WriteLine("[3] Banmedica:  ");
                Console.WriteLine("[4] asdf:  ");


                x = Convert.ToInt16(Console.ReadLine());

                if (x == 1)
                {
                    previsionSalud = 35000;
                    return previsionSalud;
                }
                //previsionSalud = x;
                //return x;

                if (x == 2)
                {
                    previsionSalud = 45000;
                    return previsionSalud;
                }
                //previsionSalud = x;
                //return x;

                if (x == 3)
                {
                    previsionSalud = 25000;
                    return previsionSalud;
                }
                //previsionSalud = x;
                //return x;

                if (x == 4)
                {
                    previsionSalud = 28000;
                    return previsionSalud;
                }
                previsionSalud = x;
                return x;

            }
            previsionSalud = x;
            return x;



        }



        static int calcularPrevisionAfp(int sueldoBruto)
        {
            Console.WriteLine("Seleccione Su Afp");
            Console.WriteLine("[1] Capital");
            Console.WriteLine("[2] Cuprum");
            Console.WriteLine("[3] Habitat");
            Console.WriteLine("[4] Modelo");

            int x, previsionAfp;
            x = Convert.ToInt16(Console.ReadLine());

            if (x == 1)
            {
                previsionAfp = (sueldoBruto * 144) / 1000;
                return previsionAfp;
            }
            //previsionAfp = x;
            //return x;

            if (x == 2)
            {
                previsionAfp = (sueldoBruto * 148) / 1000;
                return previsionAfp;
            }
            //previsionAfp = x;
            //return x;

            if (x == 3)
            {
                previsionAfp = (sueldoBruto * 127) / 1000;
                return previsionAfp;
            }
            // previsionAfp = x;
            // return x;

            if (x == 4)
            {
                previsionAfp = (sueldoBruto * 77) / 1000;
                return previsionAfp;
            }

            previsionAfp = x;
            return x;

        }

        static int calcularSueldoLiquido(int sueldoBruto, int Descuentos)
        {
            int sueldoLiquido;
            sueldoLiquido = sueldoBruto - Descuentos;
            return sueldoLiquido;
        }

        static int calcularDescuentos(int Anticipos, int previsionSalud, int previsionAfp)
        {
            int Descuentos;
            Descuentos = Anticipos + previsionSalud + previsionAfp;
            return Descuentos;
        }

        static void MostrarSueldo()
        {
            Console.WriteLine("                      LIQUIDACIÓN DE SUELDO ");
            Console.WriteLine("");
            Console.WriteLine(" Nombre:                             " + Nombre + " " + Apellido);
            Console.WriteLine(" Rut:                                " + Rut);
            Console.WriteLine(" Mes:                                " + Mes);
            Console.WriteLine(" Año:                                " + Año);
            Console.WriteLine(" Horas trabajados en la Semana:      " + HorasTrabajadasSemana);
            Console.WriteLine(" Horas trabajados el fin de semana:  " + HorasTrabajasfds);
            Console.WriteLine(" Sueldo por base por Hora:           " + ValorHora);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(" Sueldo por Hora Trabajada durante la semana:            " + sueldo);
            Console.WriteLine(" Sueldo por Hora Trabajada durante el fin de semana:    " + sueldofds);

            Console.WriteLine(" Bonos gratificación y locomoción:                       " + Bonos);
            Console.WriteLine(" Anticipos:                                             " + Anticipos);
            Console.WriteLine(" Prevision de Salud:                                    " + previsionSalud);
            Console.WriteLine(" Afp:                                                   " + previsionAfp);
            Console.WriteLine("");
            Console.WriteLine(" Descuentos :                                            " + Descuentos);
            Console.WriteLine("");
            Console.WriteLine(" Sueldo Bruto :                                         " + sueldoBruto);
            Console.WriteLine("");
            Console.WriteLine(" Sueldo Liquido :                                       " + sueldoLiquido);
            Console.WriteLine(" ");
            Console.WriteLine(" " + DateTime.Now);
        }

    }
}

