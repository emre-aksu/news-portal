using Microsoft.AspNetCore.Http;

namespace ModelLayer.Dtos.HomeDto
{
    public class HomeEditDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IFormFile Photo { get; set; }
        public string PhotoPath { get; set; }
    }
}
