using BaseLib.Model;
using Microsoft.AspNetCore.Http;

namespace Model.Dtos.HomeDto
{
    public class HomePostDto:IDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public IFormFile Picture { get; set; }
        public string? PhotoPath { get; set; }
    }
}
