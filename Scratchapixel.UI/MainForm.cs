namespace Scratchapixel.UI
{
    public partial class MainForm : Form
    {
        private readonly LessonRepository _lessonRepository = new();
        private ILesson? _currentLesson = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _lessonRepository.LoadLessons();
            foreach (ILesson lesson in _lessonRepository.Lessons.Values)
            {
                Button lessonButton = new()
                {
                    Text = lesson.Number.ToString(),
                    Tag = lesson
                };

                lessonButton.Click += LessonButton_Click;
                _lessonsPanel.Controls.Add(lessonButton);
            }
        }

        private void LessonButton_Click(object? sender, EventArgs e)
        {
            if (sender is Control button && button.Tag is ILesson lesson && lesson != _currentLesson)
            {
                _currentLesson?.CleanUp();
                _currentLesson = lesson;
                _nameLabel.Text = lesson.Name;
                _descriptionTextBox.Text = lesson.Description;
                _notesTextBox.Text = lesson.Notes;
                _currentLesson.Control = _outputPanel;
                _outputPanel.Invalidate();
            }
        }

        private void OutputPanel_Paint(object sender, PaintEventArgs e)
        {
            if (sender is Control control)
            {
                Bitmap bitmap = new(control.Width, control.Height);
                Graphics bitmapGraphics = Graphics.FromImage(bitmap);
                bitmapGraphics.FillRectangle(Brushes.Cyan, control.ClientRectangle);
                bitmapGraphics.DrawLine(Pens.Magenta, 10f, 10f, 30f, 40f);
                Graphics g = e.Graphics;
                g.DrawImageUnscaled(bitmap, 0, 0);

                if (_currentLesson != null)
                {
                    _currentLesson.Render();
                }
            }
        }

        private void OutputPanel_Resize(object sender, EventArgs e)
        {
            _outputPanel.Invalidate();
        }
    }
}
