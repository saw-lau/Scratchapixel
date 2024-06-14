using System.Reflection;

namespace Scratchapixel.UI
{
    internal class LessonRepository
    {
        public SortedList<int, Lesson> Lessons { get; }

        public LessonRepository()
        {
            Lessons = [];
        }

        public void LoadLessons()
        {
            Assembly us = Assembly.GetExecutingAssembly();
            foreach (string filename in Directory.GetFiles(".", "*.dll"))
            {
                try
                {
                    Assembly ass = Assembly.LoadFrom(filename);
                    if (ass != us)
                    {
                        // Is it a lesson?
                        foreach (TypeInfo typeInfo in ass.DefinedTypes)
                        {
                            if (typeInfo.IsSubclassOf(typeof(Lesson)))
                            {
                                if (typeInfo.FullName != null && ass.CreateInstance(typeInfo.FullName) is Lesson lesson)
                                {
                                    Lessons.Add(lesson.Number, lesson);
                                }
                            }
                        }
                    }
                }
                catch (Exception e) when (e is BadImageFormatException || e is FileLoadException)
                {
                    // Fine - not interested in these cases.
                }
            }
        }
    }
}
