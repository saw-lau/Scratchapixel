using Scratchapixel;

namespace LessonA1
{
    public class LessonA1 : ILesson
    {
        public int Number => 1;
        public string Name => "Your Starting Point!";
        public string Description => "A Very Gentle Introduction to Computer Graphics Programming";
        public string Notes => "TBD.";
        public Control? Control { get; set; }

        public void Render()
        {
            if (Control != null)
            {
            }
        }

        public Bitmap? Bitmap => _bitmap;

        public void CleanUp()
        {
            _bitmap = null;
        }

        private Bitmap? _bitmap;
    }
}
