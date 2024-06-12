namespace Scratchapixel
{
    public interface ILesson
    {
        public int Number { get; }
        public string Name { get; }
        public string Description { get; }
        public string Notes { get; }
        public Control? Control { get; set; }
        public void Render();
        public Bitmap? Bitmap { get; }
        public void CleanUp();
    }
}
