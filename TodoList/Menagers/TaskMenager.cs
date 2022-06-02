using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList.Menagers
{
    public static class TaskMenager
    {
        public static List<tasks> GetTasks()
        {
            using (var db = new DataEdoTestEntities())
            {
                return db.tasks.ToList();
            }
        }
        public static tasks GetTasks(int id)
        {
            using (var db = new DataEdoTestEntities())
            {
                return db.tasks.FirstOrDefault(x => x.id == id);
            }
        }

        public static tasks AddTask(tasks task)
        {
            using (var db = new DataEdoTestEntities())
            {
                db.tasks.Add(task);
                db.SaveChanges();
                return task;
            }
        }
        public static void AddTasks(List<tasks> task)
        {
            using (var db = new DataEdoTestEntities())
            {
                foreach (var i in task)
                {
                    if (i.id == 0)
                        db.tasks.Add(i);
                    else
                    {
                        var taskdb = db.tasks.FirstOrDefault(x => x.id == i.id);
                        if (taskdb == null)
                            continue;
                        taskdb.title = i.title;
                        taskdb.description = i.description;
                        taskdb.date = i.date;
                        taskdb.modifyDate = i.modifyDate;
                    }
                }
                db.SaveChanges();
            }
        }
     
    }
}
