using BaseLib.Model;
using System.Security.Cryptography;

namespace Model.Dtos.EkonomiDto
{
    public class EkonomiGetDto:IDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public byte[]? Picture { get; set; }
        public string? PhotoPath { get; set; }
    }
}
