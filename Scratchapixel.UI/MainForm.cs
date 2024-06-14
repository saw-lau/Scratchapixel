namespace Scratchapixel.UI
{
    public partial class MainForm : Form
    {
        private readonly LessonRepository _lessonRepository = new();
        private Lesson? _currentLesson = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _lessonRepository.LoadLessons();
            foreach (Lesson lesson in _lessonRepository.Lessons.Values)
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
            if (sender is Control button && button.Tag is Lesson lesson && lesson != _currentLesson)
            {
                _currentLesson?.CleanUp();
                _currentLesson = lesson;
                _nameLabel.Text = lesson.Name;
                _descriptionTextBox.Text = lesson.Description;
                _notesTextBox.Text = lesson.Notes;
                _currentLesson.Control = _outputPanel;
                _currentLesson.StartRender();
            }
        }

        private void OutputPanel_Paint(object sender, PaintEventArgs e)
        {
            if (_currentLesson != null && _currentLesson.Bitmap != null)
            {
                Graphics g = e.Graphics;
                g.DrawImageUnscaled(_currentLesson.Bitmap, 0, 0);
            }
        }

        private void OutputPanel_Resize(object sender, EventArgs e)
        {
            if (_currentLesson != null)
            {
                _currentLesson.StartRender();
            }
        }
    }
}
