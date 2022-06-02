namespace TodoList.Dialogs
{
    partial class TaskDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskDialog));
            this.titleMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.TaskDialoglayoutControl1ConvertedLayout = new DevExpress.XtraLayout.LayoutControl();
            this.descriptionMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.dateEdit = new DevExpress.XtraEditors.DateEdit();
            this.saveSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.closeSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.memoEdit1item = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.titleMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaskDialoglayoutControl1ConvertedLayout)).BeginInit();
            this.TaskDialoglayoutControl1ConvertedLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // titleMemoEdit
            // 
            this.titleMemoEdit.Location = new System.Drawing.Point(12, 33);
            this.titleMemoEdit.Name = "titleMemoEdit";
            this.titleMemoEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleMemoEdit.Properties.Appearance.Options.UseFont = true;
            this.titleMemoEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.titleMemoEdit.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.titleMemoEdit.Properties.LinesCount = 3;
            this.titleMemoEdit.Size = new System.Drawing.Size(621, 75);
            this.titleMemoEdit.StyleController = this.TaskDialoglayoutControl1ConvertedLayout;
            this.titleMemoEdit.TabIndex = 0;
            // 
            // TaskDialoglayoutControl1ConvertedLayout
            // 
            this.TaskDialoglayoutControl1ConvertedLayout.Controls.Add(this.titleMemoEdit);
            this.TaskDialoglayoutControl1ConvertedLayout.Controls.Add(this.descriptionMemoEdit);
            this.TaskDialoglayoutControl1ConvertedLayout.Controls.Add(this.dateEdit);
            this.TaskDialoglayoutControl1ConvertedLayout.Controls.Add(this.saveSimpleButton);
            this.TaskDialoglayoutControl1ConvertedLayout.Controls.Add(this.closeSimpleButton);
            this.TaskDialoglayoutControl1ConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TaskDialoglayoutControl1ConvertedLayout.Location = new System.Drawing.Point(0, 0);
            this.TaskDialoglayoutControl1ConvertedLayout.Name = "TaskDialoglayoutControl1ConvertedLayout";
            this.TaskDialoglayoutControl1ConvertedLayout.Root = this.layoutControlGroup1;
            this.TaskDialoglayoutControl1ConvertedLayout.Size = new System.Drawing.Size(645, 394);
            this.TaskDialoglayoutControl1ConvertedLayout.TabIndex = 1;
            // 
            // descriptionMemoEdit
            // 
            this.descriptionMemoEdit.Location = new System.Drawing.Point(12, 133);
            this.descriptionMemoEdit.MenuManager = this.barManager1;
            this.descriptionMemoEdit.Name = "descriptionMemoEdit";
            this.descriptionMemoEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.descriptionMemoEdit.Properties.Appearance.Options.UseFont = true;
            this.descriptionMemoEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.descriptionMemoEdit.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.descriptionMemoEdit.Properties.LinesCount = 6;
            this.descriptionMemoEdit.Size = new System.Drawing.Size(621, 197);
            this.descriptionMemoEdit.StyleController = this.TaskDialoglayoutControl1ConvertedLayout;
            this.descriptionMemoEdit.TabIndex = 4;
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.MaxItemId = 272;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(645, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 394);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(645, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 394);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(645, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 394);
            // 
            // dateEdit
            // 
            this.dateEdit.EditValue = null;
            this.dateEdit.Location = new System.Drawing.Point(192, 334);
            this.dateEdit.MenuManager = this.barManager1;
            this.dateEdit.Name = "dateEdit";
            this.dateEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateEdit.Properties.Appearance.Options.UseFont = true;
            this.dateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)});
            this.dateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dateEdit.Properties.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.dateEdit_Properties_ButtonPressed);
            this.dateEdit.Size = new System.Drawing.Size(441, 22);
            this.dateEdit.StyleController = this.TaskDialoglayoutControl1ConvertedLayout;
            this.dateEdit.TabIndex = 5;
            // 
            // saveSimpleButton
            // 
            this.saveSimpleButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("saveSimpleButton.ImageOptions.Image")));
            this.saveSimpleButton.Location = new System.Drawing.Point(437, 360);
            this.saveSimpleButton.Name = "saveSimpleButton";
            this.saveSimpleButton.Size = new System.Drawing.Size(96, 22);
            this.saveSimpleButton.StyleController = this.TaskDialoglayoutControl1ConvertedLayout;
            this.saveSimpleButton.TabIndex = 6;
            this.saveSimpleButton.Text = "Zapisz";
            this.saveSimpleButton.Click += new System.EventHandler(this.saveSimpleButton_Click);
            // 
            // closeSimpleButton
            // 
            this.closeSimpleButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("closeSimpleButton.ImageOptions.Image")));
            this.closeSimpleButton.Location = new System.Drawing.Point(537, 360);
            this.closeSimpleButton.Name = "closeSimpleButton";
            this.closeSimpleButton.Size = new System.Drawing.Size(96, 22);
            this.closeSimpleButton.StyleController = this.TaskDialoglayoutControl1ConvertedLayout;
            this.closeSimpleButton.TabIndex = 7;
            this.closeSimpleButton.Text = "Anuluj";
            this.closeSimpleButton.Click += new System.EventHandler(this.closeSimpleButton_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.memoEdit1item,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.emptySpaceItem1});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(645, 394);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // memoEdit1item
            // 
            this.memoEdit1item.AppearanceItemCaption.BackColor = System.Drawing.Color.White;
            this.memoEdit1item.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.memoEdit1item.AppearanceItemCaption.Options.UseBackColor = true;
            this.memoEdit1item.AppearanceItemCaption.Options.UseFont = true;
            this.memoEdit1item.Control = this.titleMemoEdit;
            this.memoEdit1item.Location = new System.Drawing.Point(0, 0);
            this.memoEdit1item.Name = "memoEdit1item";
            this.memoEdit1item.Size = new System.Drawing.Size(625, 100);
            this.memoEdit1item.Text = "Tytuł*";
            this.memoEdit1item.TextLocation = DevExpress.Utils.Locations.Top;
            this.memoEdit1item.TextSize = new System.Drawing.Size(168, 18);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.BackColor = System.Drawing.Color.White;
            this.layoutControlItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.layoutControlItem1.AppearanceItemCaption.Options.UseBackColor = true;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.Control = this.descriptionMemoEdit;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 100);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(625, 222);
            this.layoutControlItem1.Text = "Opis*";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(168, 18);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.BackColor = System.Drawing.Color.White;
            this.layoutControlItem2.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.layoutControlItem2.AppearanceItemCaption.Options.UseBackColor = true;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem2.Control = this.dateEdit;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 322);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(625, 26);
            this.layoutControlItem2.Text = "Data zakończenia zadania";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(168, 18);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.saveSimpleButton;
            this.layoutControlItem3.Location = new System.Drawing.Point(425, 348);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(100, 26);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(100, 26);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(100, 26);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.closeSimpleButton;
            this.layoutControlItem4.Location = new System.Drawing.Point(525, 348);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(100, 26);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(100, 26);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(100, 26);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 348);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(425, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // TaskDialog
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 394);
            this.Controls.Add(this.TaskDialoglayoutControl1ConvertedLayout);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("TaskDialog.IconOptions.Image")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TaskDialog";
            this.Text = "Task";
            this.Shown += new System.EventHandler(this.TaskDialog_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.titleMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaskDialoglayoutControl1ConvertedLayout)).EndInit();
            this.TaskDialoglayoutControl1ConvertedLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.descriptionMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.MemoEdit titleMemoEdit;
        private DevExpress.XtraLayout.LayoutControl TaskDialoglayoutControl1ConvertedLayout;
        private DevExpress.XtraEditors.MemoEdit descriptionMemoEdit;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.DateEdit dateEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem memoEdit1item;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.SimpleButton saveSimpleButton;
        private DevExpress.XtraEditors.SimpleButton closeSimpleButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}