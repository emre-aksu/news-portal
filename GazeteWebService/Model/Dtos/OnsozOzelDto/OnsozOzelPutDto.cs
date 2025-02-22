using BaseLib.Model;
using Microsoft.AspNetCore.Http;

namespace Model.Dtos.OnsozOzelDto
{
    public class OnsozOzelPutDto:IDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public IFormFile Picture { get; set; }
        public string? PhotoPath { get; set; }
    }
}
