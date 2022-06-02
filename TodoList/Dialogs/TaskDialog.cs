using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TodoList.Menagers;

namespace TodoList.Dialogs
{
    public partial class TaskDialog : DevExpress.XtraEditors.XtraForm
    {
         tasks _task;
        public tasks Task => _task;
        EnumsManager.OpenFormMode mode;
        public TaskDialog()
        {
            InitializeComponent();
            mode = EnumsManager.OpenFormMode.New;
            _task = new tasks();
        }

        public TaskDialog(tasks tasks)
        {
            InitializeComponent();
            mode = EnumsManager.OpenFormMode.Edit;
            _task = tasks;
        }

        private void _setTitile()
        {
            switch (mode)
            {
                case EnumsManager.OpenFormMode.New:
                    this.Text = "Nowe zadanie";
                    break;
                case EnumsManager.OpenFormMode.Edit:
                    this.Text = "Edycja zadania";
                    FillControls();
                    break;
                default:
                    this.Close();
                    break;
            }
        }

        private void FillControls()
        {
            titleMemoEdit.EditValue = _task.title ;
            descriptionMemoEdit.EditValue = _task.description ;
            dateEdit.EditValue = _task.date ;
        }

        private bool Validate()
        {
            if (string.IsNullOrEmpty(titleMemoEdit.Text))
            {
                MessageManager.ValidationMessage("Nie wprowadziłeś tytułu");
                return false;
            }
            if (string.IsNullOrEmpty(descriptionMemoEdit.Text))
            {
                MessageManager.ValidationMessage("Nie wprowadziłeś Opisu");
                return false;
            }
            return true;
        }
        private void Save()
        {
            try
            {
                if (!Validate())
                    return;

                _task.title = titleMemoEdit.Text;
                _task.description = descriptionMemoEdit.Text;
                _task.date = (DateTime?)dateEdit.EditValue;
                _task.createDate = DateTime.Now;

                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageManager.InfoMessage(ex.Message);
            }
        }

        private void TaskDialog_Shown(object sender, EventArgs e)
        {
            _setTitile();
            if (true)
            {

            }
        }



        private void dateEdit_Properties_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)
            {
                ((BaseEdit)sender).EditValue = null;
            }
        }

        private void saveSimpleButton_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void closeSimpleButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
    }
}