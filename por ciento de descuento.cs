using System;

namespace por_ciento_de_descuento
{
    class por_ciento_de_descuento
    {
        public int precio;

        public int Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        public int descuento;

        public int Descuento
        {
            get { return descuento; }
            set { descuento = value; }
        }
        public int total;

        public int Total
        {
            get { return total; }
            set { total = value; }
        }
        public static void Cinco(string[] args)
        {
            double precio, desc, total;
            System.Console.WriteLine("ingresar precio: ");
            precio = Convert.ToInt32(Console.ReadLine());
            desc = 0.05 - precio;
            total = precio - desc;
            Console.Write("cancelar monto total de: " + desc);
            Console.ReadKey();
        }
        public static void Quince(string[] args)
        {
            double precio, desc, total;
            System.Console.WriteLine("ingresar precio: ");
            precio = Convert.ToInt32(Console.ReadLine());
            desc = 0.15 - precio;
            desc = precio * 0.15;
            total = precio - desc;
            Console.Write("precio total de ${total}" + desc);
            Console.ReadKey();
        }
        public static void Treinta(string[] args)
        {
            double precio, desc, total;
            System.Console.WriteLine("ingresar precio: ");
            precio = Convert.ToInt32(Console.ReadLine());
            desc = 0.3 - precio;
            total = precio - desc;
            Console.Write("cancelar monto total de: " + desc);
            Console.ReadKey();
        }
        public static void Cincuenta(string[] args)
        {
            double precio, desc, total;
            System.Console.WriteLine("ingresar precio: ");
            precio = Convert.ToInt32(Console.ReadLine());
            desc = 0.5 - precio;
            total = precio - desc;
            Console.Write("cancelar monto total de: " + desc);
            Console.ReadKey();
        }
        public static void Setenta(string[] args)
        {
            double precio, desc, total;
            System.Console.WriteLine("ingresar precio: ");
            precio = Convert.ToInt32(Console.ReadLine());
            desc = 0.7 - precio;
            total = precio / desc;
            Console.Write("cancelar monto total de: " + desc);
            Console.ReadKey();
        }
    }
}
