using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    class Applicant:human
    {
         int ZNObal { get; set; }
         int BalSerOs { get; set; }
         string Zaklad { get; set; }
        public void setZNObal(int ZNObal) { this.ZNObal = ZNObal; }
        public void setBalSerOs(int BalSerOs) { this.BalSerOs = BalSerOs; }
        public void setZaklad(string Zaklad) { this.Zaklad = Zaklad; }
        public int getZNObal() { return ZNObal; }
        public int getBalSerOs() { return BalSerOs; }
        public string getZaklad() { return Zaklad; }



        public Applicant()
        {
            ZNObal = 0;
            BalSerOs = 0;
            Zaklad = "";
        }
        public Applicant(int zno,int bso,string zaklad, string name, string sourName, string data):base(name,sourName,data)
        {
            ZNObal = zno;
            BalSerOs = bso;
            Zaklad = zaklad;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"ZNObal: {ZNObal}\nBalSerOs: {BalSerOs}\nZaklad: {Zaklad}");
        }
    }
}
