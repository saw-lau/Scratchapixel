namespace Scratchapixel.UI
{
    public partial class MainForm : Form
    {
        private LessonRepository _lessonRepository = new LessonRepository();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _lessonRepository.LoadLessons();
        }
    }
}
