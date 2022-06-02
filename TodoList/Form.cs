using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraSplashScreen;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TodoList.Dialogs;
using TodoList.Menagers;

namespace TodoList
{
    public partial class Form : DevExpress.XtraEditors.XtraForm
    {
        List<tasks> _tasksList = new List<tasks>();
        string fileName = "ToDoList.json";
        bool isSave = false;

        #region Constructors
        public Form()
        {
            InitializeComponent();
        }
        #endregion

        #region  Methods

        private tasks GetSelectedRow()
        {
            return (tasks)ItemsTileView.GetFocusedRow() ?? null;
        }

        private void _Add()
        {
            try
            {
                using (TaskDialog dlg = new TaskDialog())
                {
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        _tasksList.Add(dlg.Task);
                        _Refresh();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageManager.InfoMessage(ex.Message);
            }
        }

        private void _Edit()
        {
            try
            {
                var tasks = GetSelectedRow();
                if (tasks == null)
                {
                    MessageManager.InfoMessage("Nie wybrano żadnego zadania");
                    return;
                }
                using (TaskDialog dlg = new TaskDialog(tasks))
                {
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        tasks task = _tasksList.FirstOrDefault(x => x == tasks);
                        if (task != null)
                        {
                            task.title = dlg.Task.title;
                            task.description = dlg.Task.description;
                            task.date = dlg.Task.date;
                            task.modifyDate = DateTime.Now;
                        }
                        _Refresh();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageManager.InfoMessage(ex.Message);
            }
        }

        private void _Refresh()
        {
            try
            {
                int handle = ItemsTileView.FocusedRowHandle;
                int topRowIndex = ItemsTileView.GetFocusedDataSourceRowIndex();
                ItemsGridControl.DataSource = _tasksList;
                ItemsGridControl.RefreshDataSource();
                ItemsTileView.FocusedRowHandle = handle;
                ItemsTileView.ViewRowHandleToDataSourceIndex(topRowIndex);
            }
            catch (Exception ex)
            {
                MessageManager.InfoMessage(ex.Message);
            }
        }
        private void _Save()
        {
            try
            {
                if (MessageManager.QuestionMessage("Czy chcesz zapisać do bazy danych - Yes\n czy do pliku - No") == DialogResult.Yes)
                    TaskMenager.AddTasks(_tasksList);
                else
                {
                    var jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(_tasksList);
                    File.WriteAllText(fileName, jsonString);
                }
                isSave = true;
                MessageManager.InfoMessage("Pomyślnie zapisano");
            }
            catch (Exception ex)
            {
                MessageManager.InfoMessage(ex.Message);
            }
        }

        private void _Load()
        {
            try
            {
                if (File.Exists(fileName) && MessageManager.QuestionMessage("Czy chcesz wczytać z pliku  - Yes\n lub z bazy danych - No") == DialogResult.Yes)
                {
                    string jsonStrings = File.ReadAllText(fileName);
                    _tasksList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<tasks>>(jsonStrings);
                }
                else
                    _tasksList = TaskMenager.GetTasks();

                _Refresh();
            }
            catch (Exception ex)
            {
                MessageManager.InfoMessage(ex.Message);
            }
        }

        #endregion

        #region  Events

        private void Form_Shown(object sender, EventArgs e)
        {
            _Load();
        }

        private void ItemsTileView_DoubleClick(object sender, EventArgs e)
        {
            _Edit();
        }

        private void addSimpleButton_Click(object sender, EventArgs e)
        {
            _Add();
        }

        private void editSimpleButton_Click(object sender, EventArgs e)
        {
            _Edit();
        }

        private void ItemsTileView_CustomItemTemplate(object sender, DevExpress.XtraGrid.Views.Tile.TileViewCustomItemTemplateEventArgs e)
        {
            try
            {
                var item = ItemsTileView.GetRow(e.RowHandle) as tasks;
                if (item == null)
                    return;
                if (item.date == null)
                    e.Template = e.Templates["templateNoDate"];

            }
            catch (Exception ex)
            {
                MessageManager.InfoMessage(ex.Message);
            }

        }

        private void saveSimpleButton_Click(object sender, EventArgs e)
        {
            _Save();
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isSave)
                _Save();
        }
        #endregion
    }
}
