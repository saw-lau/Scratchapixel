namespace Scratchapixel
{
    /// <summary>
    /// Base class that lessons are derived from.
    /// </summary>
    public abstract class Lesson
    {
        #region General lesson properties.
        /// <summary>
        /// The lesson number.
        /// </summary>
        public abstract int Number { get; }

        /// <summary>
        /// The lesson name.
        /// </summary>
        public abstract string Name { get; }

        /// <summary>
        /// The lesson description.
        /// </summary>
        public abstract string Description { get; }

        /// <summary>
        /// Any notes on the lesson learnt through implementing it.
        /// </summary>
        public abstract string Notes { get; }
        #endregion

        /// <summary>
        /// Each Lesson renders to a Bitmap, which is retrieved by the main form via this property.
        /// </summary>
        public Bitmap? Bitmap { get; protected set; }

        /// <summary>
        /// The control that the bitmap will be drawn on.
        /// </summary>
        /// <remarks>
        /// Primarily passed in so that the lesson can invalidate this to cause a repaint for long-running operations or animation.
        /// </remarks>
        public Control? Control { get; set; }

        /// <summary>
        /// Called when rendering needs to begin.
        /// </summary>
        public void StartRender()
        {
            if (Control != null)
            {
                if ((Bitmap == null || Bitmap.Width != Control.Width || Bitmap.Height != Control.Height) && Control.Width != 0)
                {
                    Bitmap?.Dispose();
                    Bitmap = new Bitmap(Control.Width, Control.Height);
                }
            }

            Render();
        }

        /// <summary>
        /// Clean up any resources.
        /// </summary>
        public void CleanUp()
        {
            Bitmap?.Dispose();
            Bitmap = null;
        }

        /// <summary>
        /// The render method that the lesson needs to provide to render on to the bitmap.
        /// </summary>
        /// <remarks>
        /// When rendering is complete, the control should be invalidated.
        /// </remarks>
        protected abstract void Render();
    }
}
