namespace PresentationsLayer.Areas.GazetePanel.ApiTypes
{
    public class HomePostRequest
    {
       
        public string? Name { get; set; }
        public string? Description { get; set; }
        public byte[]? Picture { get; set; }
        public string? PhotoPath { get; set; }
    }
}
