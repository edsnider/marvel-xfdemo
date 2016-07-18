namespace MarvelDemo.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string IconPath { get; set; }
        public int SeriesId { get; set; }
        public Image Thumbnail { get; set; }
    }
}
