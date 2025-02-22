namespace PresentationsLayer.Areas.GazetePanel.ApiTypes
{
    public class ResmiPutRequest
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public byte[]? Picture { get; set; }
        public string? PhotoPath { get; set; }
    }
}
