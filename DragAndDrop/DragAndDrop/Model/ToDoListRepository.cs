using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.Internals;

namespace DragAndDrop
{
    public class ToDoListRepository
    {
        #region Constructor

        public ToDoListRepository()
        {

        }

        #endregion

        #region Methods

        internal ObservableCollection<ToDoItem> GetToDoList()
        {
            var todoList = new ObservableCollection<ToDoItem>();
            var random = new Random();

            for (int i = 0; i < toDoLists.Count(); i++)
            {
                var todoItem = new ToDoItem()
                {
                    Name = toDoLists[i],
                    CategoryName = GetCategoryList(i)
                };
                todoList.Add(todoItem);
            }
            return todoList;
        }

        private string GetCategoryList(int pos)
        {
            string toDoCategory;

            if (pos < 4)
                toDoCategory = toDoCategoryLists[0];
            else if (pos < 8)
                toDoCategory = toDoCategoryLists[1];
            else if (pos < 13)
                toDoCategory = toDoCategoryLists[2];
            else
                toDoCategory = toDoCategoryLists[3];
            
            return toDoCategory;
        }

        string[] toDoLists = new string[]
        {
            "item1",
            "item2",
            "item3",
            "item4",
            "item5"
        };

        string[] toDoCategoryLists = new string[]
        {
            "This Week",
            "Next Week",
            "Next Month",
            "Later"
        };

        #endregion
    }
}
