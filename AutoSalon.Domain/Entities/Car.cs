using System.ComponentModel;
using AutoSalon.Domain.Commons;

namespace AutoSalon.Domain.Entities
{
    public class Car : Auditable
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
    }
}