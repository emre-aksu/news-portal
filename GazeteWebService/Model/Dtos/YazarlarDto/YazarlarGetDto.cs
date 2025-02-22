using BaseLib.Model;

namespace Model.Dtos.YazarlarDto
{
    public class YazarlarGetDto:IDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public byte[]? Picture { get; set; }
        public string? PhotoPath { get; set; }
        public DateTime? HireDate { get; set; }
        public DateTime? BirthDate { get; set; }
    }
}
