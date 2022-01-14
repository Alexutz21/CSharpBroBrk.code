using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeTutorials
{
    //#######################################################################################
    class Masina    //New Class
    {
        public string marca;
        public string model;
        public int anFabricatie;
        public string culoare;
        public int km;

        public void MasinutaMea()   //Method
        {
            Console.WriteLine("Masina mea este un " + marca + " model " + model + ", an de fabricatie " + anFabricatie + ", culoare" + culoare + " si are " + km + " de km.");
        }
        public static void MasinaRunExample()
        {
            Masina MyMl = new Masina();
            MyMl.marca = "Mercedes";
            MyMl.model = "Ml";
            MyMl.culoare = "negru";
            MyMl.km = 116000;
            MyMl.anFabricatie = 2009;

            //Run my method
            MyMl.MasinutaMea();
            Console.WriteLine();
        }
    }

    //#######################################################################################
    public class Telefon    //New Class
    {
        private string firma;
        private char model;
        private int anFabricatie;
        private string culoare;

        public void TelefonulMeu()  //Method
        {
            Console.WriteLine("Telefonul meu este {0}, model {1} si e din {2} si e de culoarea {3}. ",firma,model,anFabricatie,culoare);
        }
        public static void TelefonulMeuRunExample()
        {
            Telefon telefonul1 = new Telefon();
            telefonul1.firma = "Iphone";
            telefonul1.model = '7';
            telefonul1.anFabricatie = 2019;
            telefonul1.culoare = "solid gold";

            telefonul1.TelefonulMeu();
            Console.WriteLine();
        }
    }

    //#######################################################################################
    public class Laptop     //New Class 
    {
        public string marca;
        public string culoare;
        public int capacitateRam;
        public string marcaProcesor;

        public void MyLaptop()  //Method
        {
            Console.WriteLine($"Laptopul {marca} este de culoarea {culoare}, are {capacitateRam} capacitate ram si un procesor {marcaProcesor}.");
        }
        public static void MyLaptopRunExample()
        {
            Laptop Lenovo1 = new Laptop();
            Lenovo1.marca = "Lenovo";
            Lenovo1.capacitateRam = 16;
            Lenovo1.culoare = "negru";
            Lenovo1.marcaProcesor = "Intel Core";

            Lenovo1.MyLaptop();
            Console.WriteLine();
        }
    }



}
