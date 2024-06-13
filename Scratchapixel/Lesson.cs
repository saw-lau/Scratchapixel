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
        public Bitmap? Bitmap { get; }

        public Control? Control { get; set; }
        public void Render() { }
        
        /// <summary>
        /// Clean up any resources.
        /// </summary>
        public void CleanUp()
        {
            _bitmap = null;
        }

        /// <summary>
        /// Underlying storage for the bitmap.
        /// </summary>
        protected Bitmap? _bitmap;
    }
}
