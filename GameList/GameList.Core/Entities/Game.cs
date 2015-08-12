namespace GameList.Core.Entities
{
    public class Game : Base
    {
        public string Description { get; set; }
        public string Studio { get; set; }
        public byte[] Image { get; set; }
    }
}
