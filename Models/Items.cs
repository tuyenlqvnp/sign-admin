using System;

namespace web.Models
{
    public class Item
    {
        private int _id;
        private string _id_company;
        private string _code;
        private string _name;
        private double _price;
        private string _unit;
        private string _description;

        public Item()
        {
        }

        public int Id { get => _id; set => _id = value; }
        public string Id_company { get => _id_company; set => _id_company = value; }
        public string Code { get => _code; set => _code = value; }
        public string Name { get => _name; set => _name = value; }
        public double Price { get => _price; set => _price = value; }
        public string Unit { get => _unit; set => _unit = value; }
        public string Description { get => _description; set => _description = value; }
    }
}