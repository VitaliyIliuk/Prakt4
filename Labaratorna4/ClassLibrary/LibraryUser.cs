using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ClassLibrary
{
    class LibraryUser:human
    {
        int nambeKvutka { get; set; }
        string dataVudachi { get; set; }
        float moonVnesok { get; set; }
        public int getnambeKvutka() { return nambeKvutka; }
        public string getdataVudachi() { return dataVudachi; }
        public float getmoonVnesok() { return moonVnesok; }
        public void setnambeKvutka(int nambeKvutka) { this.nambeKvutka = nambeKvutka; }
        public void setdataVudachi(string dataVudachi) { this.dataVudachi = dataVudachi; }
        public void setmoonVnesok(float moonVnesok) { this.moonVnesok = moonVnesok; }


        LibraryUser()
        {
            nambeKvutka = 0;
            dataVudachi = "";
            moonVnesok = 0f;
        }
        LibraryUser(int nambeKvutka, string dataVudachi, float moonVnesok, string name, string sourName, string data) : base(name, sourName, data)
        {
            this.nambeKvutka = nambeKvutka;
            this.dataVudachi = dataVudachi;
            this.moonVnesok = moonVnesok;
        }


        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"nambeKvutka: {nambeKvutka}\ndataVudachi: {dataVudachi}\nmoonVnesok: {moonVnesok}");
        }
    }
}
