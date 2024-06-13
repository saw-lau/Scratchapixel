using Scratchapixel;

namespace LessonA1
{
    public class LessonA1 : Lesson
    {
        public override int Number => 1;
        public override string Name => "Your Starting Point!";
        public override string Description => "A Very Gentle Introduction to Computer Graphics Programming";
        public override string Notes => "TBD.";

        public override void Render()
        {
            if (Control != null)
            {
                if (Bitmap == null || Bitmap.Width != Control.Width || Bitmap.Height != Control.Height)
                {
                    Bitmap?.Dispose();
                    Bitmap = new Bitmap(Control.Width, Control.Height);
                }
            }
        }
    }
}
