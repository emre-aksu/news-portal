using BaseLib.Model;
using Microsoft.AspNetCore.Http;

namespace Model.Dtos.YazarlarDto
{
    public class YazarlarPostDto:IDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public IFormFile Picture { get; set; }
        public string? PhotoPath { get; set; }
        public DateTime? HireDate { get; set; }
        public DateTime? BirthDate { get; set; }
    }
}
