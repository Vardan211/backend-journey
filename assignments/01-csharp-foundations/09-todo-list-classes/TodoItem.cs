using System;
using System.Collections.Generic;
using System.Text;

namespace _09_todo_list_classes
{
    class TodoItem
    {
        public string Title { get; }
        public bool IsDone { get; private set; }
        public TodoItem(string title)
        {
            var resultate = IsTitleVaild(title);
            if (resultate == false)
            {
                throw new ArgumentNullException("Название задачи не должно быть пустым");
            }

            Title = title;
            IsDone = false;
        }
        public void MarkTask()
        {
            IsDone = true;
        }

        public bool IsTitleVaild(string title)
        {
            if (string.IsNullOrWhiteSpace(title))
                {
                Console.WriteLine("Поле не должен быть пустым");
                return false;
            }
            return true;
        }


    }




}
