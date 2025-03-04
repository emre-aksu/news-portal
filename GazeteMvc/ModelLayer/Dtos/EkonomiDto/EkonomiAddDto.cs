using Microsoft.AspNetCore.Http;

namespace ModelLayer.Dtos.EkonomiDto
{
    public class EkonomiAddDto
    {

        public string Name { get; set; }
        public string Description { get; set; }
        public IFormFile Photo { get; set; }
        public string PhotoPath { get; set; }


    }
}
