using System;

namespace ClassLibrary
{
    public class human : ICloneable
    {
        public human()
        {
            name = "";
            sourName = "";
            data = "";
        }
        public human(string name, string sourName, string data)
        {
            this.name = name;
            this.sourName = sourName;
            this.data = data;
        }
        string name { get; set; }
        string sourName { get; set; }
        string data { get; set; }
        public void setName(string name) { this.name = name; }
        public void setSourName(string sourName) { this.sourName = sourName; }
        public void setData(string data) { this.data = data; }
        public string detsourName() { return sourName; }
        public string detName() { return name; }
        public string detdata() { return data; }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine($"name: {name}\nsourName: {sourName}\ndata: {data}");
        }
    }
}
