using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ClassLibrary
{
    class Teacher:human
    {
        string posada { get; set; }
        string kafedra { get; set; }
        string VNavZaklad { get; set; }
        public void setposada(string posada) { this.posada = posada; }
        public void setkafedra(string kafedra) { this.VNavZaklad = kafedra; }
        public void setVNavZaklad(string VNavZaklad) { this.VNavZaklad = VNavZaklad; }
        public string getposada() { return posada; }
        public string getkafedra() { return kafedra; }
        public string getVNavZaklad() { return VNavZaklad; }

        Teacher()
        {
            posada = "";
            kafedra = "";
            VNavZaklad = "";
        }
        Teacher(string posada, string kafedra, string VNavZaklad, string name, string sourName, string data) : base(name, sourName, data)
        {
            this.posada = posada;
            this.kafedra = kafedra;
            this.VNavZaklad = VNavZaklad;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"posada: {posada}\nkafedra: {kafedra}\nVNavZaklad: {VNavZaklad}");
        }
    }
}
