﻿using Scratchapixel;

namespace LessonA1
{
    public class LessonA1 : Lesson
    {
        public override int Number => 1;
        public override string Name => "Your Starting Point!";
        public override string Description => "A Very Gentle Introduction to Computer Graphics Programming";
        public override string Notes => "TBD.";

        protected override void Render()
        {
            if (Bitmap != null && Control != null)
            {
                Graphics g = Graphics.FromImage(Bitmap);
                g.FillRectangle(Brushes.Azure, Control.ClientRectangle);
                Control.Invalidate();
            }
        }
    }
}
