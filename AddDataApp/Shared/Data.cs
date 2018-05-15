using System;

namespace Shared
{
    public class Data
    {
        #region props
        private string[] types = { "internal", "external" };
        private Guid id;
        private string target;
        private string name;
        private string type;
        private decimal salary;
        private bool ownskey;
        public string[] Types { get => types; }
        public Guid Id { get => id; set => id = value; }
        public string Target { get => target; set => target = value; }
        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }
        public decimal Salary { get => salary; set => salary = value; }
        public bool Ownskey { get => ownskey; set => ownskey = value; }
        #endregion

        public Data(string target, string name, string type, decimal salary, bool ownskey)
        {
            Id = Guid.NewGuid();
            Target = target;
            Name = name;
            Type = type;
            Salary = salary;
            Ownskey = ownskey;
        }

        public Data()
        {
        }
    }
}
