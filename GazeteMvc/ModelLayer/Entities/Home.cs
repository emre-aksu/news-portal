using Microsoft.AspNetCore.Http;

namespace ModelLayer.Entities
{
    public class Home
    {
        public int Id { get; set; }         
        public string Name { get; set; }
        public string Description { get; set; }
        public IFormFile Photo { get; set; }
        public string PhotoPath { get; set; }
    }
}
