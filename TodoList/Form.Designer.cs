namespace TodoList
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            DevExpress.XtraGrid.Views.Tile.ItemTemplate itemTemplate1 = new DevExpress.XtraGrid.Views.Tile.ItemTemplate();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition1 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement1 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement2 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition1 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition2 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition2 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition3 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition3 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition4 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableSpan tableSpan1 = new DevExpress.XtraEditors.TableLayout.TableSpan();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement3 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement4 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement5 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement6 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            this.colTitle = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.Form1layoutControl1ConvertedLayout = new DevExpress.XtraLayout.LayoutControl();
            this.saveSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.editSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.addSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.ItemsGridControl = new DevExpress.XtraGrid.GridControl();
            this.ItemsTileView = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.groupControl1item = new DevExpress.XtraLayout.LayoutControlGroup();
            this.addLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.editLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.saveLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.Form1layoutControl1ConvertedLayout)).BeginInit();
            this.Form1layoutControl1ConvertedLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsTileView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // colTitle
            // 
            this.colTitle.AppearanceCell.Options.UseTextOptions = true;
            this.colTitle.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colTitle.Caption = "Tytuł";
            this.colTitle.DisplayFormat.FormatString = "g";
            this.colTitle.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colTitle.FieldName = "title";
            this.colTitle.Name = "colTitle";
            this.colTitle.OptionsColumn.AllowEdit = false;
            this.colTitle.Visible = true;
            this.colTitle.VisibleIndex = 0;
            // 
            // colDescription
            // 
            this.colDescription.AppearanceCell.Options.UseTextOptions = true;
            this.colDescription.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colDescription.Caption = "Opis";
            this.colDescription.FieldName = "description";
            this.colDescription.Name = "colDescription";
            this.colDescription.OptionsColumn.AllowEdit = false;
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 1;
            // 
            // colDate
            // 
            this.colDate.Caption = "Data";
            this.colDate.FieldName = "date";
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 2;
            // 
            // Form1layoutControl1ConvertedLayout
            // 
            this.Form1layoutControl1ConvertedLayout.Controls.Add(this.saveSimpleButton);
            this.Form1layoutControl1ConvertedLayout.Controls.Add(this.editSimpleButton);
            this.Form1layoutControl1ConvertedLayout.Controls.Add(this.addSimpleButton);
            this.Form1layoutControl1ConvertedLayout.Controls.Add(this.ItemsGridControl);
            this.Form1layoutControl1ConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Form1layoutControl1ConvertedLayout.Location = new System.Drawing.Point(0, 0);
            this.Form1layoutControl1ConvertedLayout.Name = "Form1layoutControl1ConvertedLayout";
            this.Form1layoutControl1ConvertedLayout.Root = this.layoutControlGroup1;
            this.Form1layoutControl1ConvertedLayout.Size = new System.Drawing.Size(949, 540);
            this.Form1layoutControl1ConvertedLayout.TabIndex = 1;
            // 
            // saveSimpleButton
            // 
            this.saveSimpleButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("saveSimpleButton.ImageOptions.Image")));
            this.saveSimpleButton.Location = new System.Drawing.Point(15, 121);
            this.saveSimpleButton.Name = "saveSimpleButton";
            this.saveSimpleButton.Size = new System.Drawing.Size(106, 22);
            this.saveSimpleButton.StyleController = this.Form1layoutControl1ConvertedLayout;
            this.saveSimpleButton.TabIndex = 7;
            this.saveSimpleButton.Text = "Zapisz";
            this.saveSimpleButton.Click += new System.EventHandler(this.saveSimpleButton_Click);
            // 
            // editSimpleButton
            // 
            this.editSimpleButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("editSimpleButton.ImageOptions.Image")));
            this.editSimpleButton.Location = new System.Drawing.Point(15, 40);
            this.editSimpleButton.Name = "editSimpleButton";
            this.editSimpleButton.Size = new System.Drawing.Size(106, 22);
            this.editSimpleButton.StyleController = this.Form1layoutControl1ConvertedLayout;
            this.editSimpleButton.TabIndex = 6;
            this.editSimpleButton.Text = "Edytuj";
            this.editSimpleButton.Click += new System.EventHandler(this.editSimpleButton_Click);
            // 
            // addSimpleButton
            // 
            this.addSimpleButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("addSimpleButton.ImageOptions.Image")));
            this.addSimpleButton.Location = new System.Drawing.Point(15, 14);
            this.addSimpleButton.Name = "addSimpleButton";
            this.addSimpleButton.Size = new System.Drawing.Size(106, 22);
            this.addSimpleButton.StyleController = this.Form1layoutControl1ConvertedLayout;
            this.addSimpleButton.TabIndex = 5;
            this.addSimpleButton.Text = "Dodaj ";
            this.addSimpleButton.Click += new System.EventHandler(this.addSimpleButton_Click);
            // 
            // ItemsGridControl
            // 
            this.ItemsGridControl.Location = new System.Drawing.Point(150, 12);
            this.ItemsGridControl.MainView = this.ItemsTileView;
            this.ItemsGridControl.Name = "ItemsGridControl";
            this.ItemsGridControl.Size = new System.Drawing.Size(787, 516);
            this.ItemsGridControl.TabIndex = 4;
            this.ItemsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ItemsTileView});
            // 
            // ItemsTileView
            // 
            this.ItemsTileView.Appearance.ItemFocused.BackColor = System.Drawing.Color.DodgerBlue;
            this.ItemsTileView.Appearance.ItemFocused.BackColor2 = System.Drawing.Color.LightSkyBlue;
            this.ItemsTileView.Appearance.ItemFocused.Options.UseBackColor = true;
            this.ItemsTileView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTitle,
            this.colDescription,
            this.colDate});
            this.ItemsTileView.GridControl = this.ItemsGridControl;
            this.ItemsTileView.Name = "ItemsTileView";
            this.ItemsTileView.OptionsTiles.GroupTextPadding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.ItemsTileView.OptionsTiles.IndentBetweenGroups = 0;
            this.ItemsTileView.OptionsTiles.IndentBetweenItems = 0;
            this.ItemsTileView.OptionsTiles.ItemSize = new System.Drawing.Size(704, 90);
            this.ItemsTileView.OptionsTiles.LayoutMode = DevExpress.XtraGrid.Views.Tile.TileViewLayoutMode.List;
            this.ItemsTileView.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.ItemsTileView.OptionsTiles.Padding = new System.Windows.Forms.Padding(0);
            this.ItemsTileView.OptionsTiles.RowCount = 0;
            tableColumnDefinition1.Length.Value = 623D;
            itemTemplate1.Columns.Add(tableColumnDefinition1);
            tileViewItemElement1.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            tileViewItemElement1.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement1.Appearance.Normal.Options.UseTextOptions = true;
            tileViewItemElement1.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            tileViewItemElement1.Column = this.colTitle;
            tileViewItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement1.Text = "colTitle";
            tileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            tileViewItemElement2.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement2.Appearance.Normal.Options.UseTextOptions = true;
            tileViewItemElement2.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            tileViewItemElement2.Column = this.colDescription;
            tileViewItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement2.RowIndex = 1;
            tileViewItemElement2.Text = "colDescription";
            tileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            itemTemplate1.Elements.Add(tileViewItemElement1);
            itemTemplate1.Elements.Add(tileViewItemElement2);
            itemTemplate1.Name = "templateNoDate";
            tableRowDefinition1.Length.Value = 39D;
            tableRowDefinition2.Length.Value = 65D;
            itemTemplate1.Rows.Add(tableRowDefinition1);
            itemTemplate1.Rows.Add(tableRowDefinition2);
            this.ItemsTileView.Templates.Add(itemTemplate1);
            tableColumnDefinition2.Length.Value = 589D;
            tableColumnDefinition3.Length.Value = 91D;
            this.ItemsTileView.TileColumns.Add(tableColumnDefinition2);
            this.ItemsTileView.TileColumns.Add(tableColumnDefinition3);
            tableRowDefinition3.Length.Value = 39D;
            tableRowDefinition4.Length.Value = 65D;
            this.ItemsTileView.TileRows.Add(tableRowDefinition3);
            this.ItemsTileView.TileRows.Add(tableRowDefinition4);
            tableSpan1.ColumnIndex = 1;
            tableSpan1.RowSpan = 2;
            this.ItemsTileView.TileSpans.Add(tableSpan1);
            tileViewItemElement3.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            tileViewItemElement3.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement3.Appearance.Normal.Options.UseTextOptions = true;
            tileViewItemElement3.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            tileViewItemElement3.Column = this.colTitle;
            tileViewItemElement3.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement3.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement3.Text = "colTitle";
            tileViewItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement4.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            tileViewItemElement4.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement4.Appearance.Normal.Options.UseTextOptions = true;
            tileViewItemElement4.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            tileViewItemElement4.Column = this.colDescription;
            tileViewItemElement4.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement4.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement4.RowIndex = 1;
            tileViewItemElement4.Text = "colDescription";
            tileViewItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement5.Column = this.colDate;
            tileViewItemElement5.ColumnIndex = 1;
            tileViewItemElement5.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement5.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement5.RowIndex = 1;
            tileViewItemElement5.Text = "colDate";
            tileViewItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement6.ColumnIndex = 1;
            tileViewItemElement6.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement6.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement6.Text = "Data zakończenia";
            tileViewItemElement6.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter;
            tileViewItemElement6.TextLocation = new System.Drawing.Point(0, 10);
            this.ItemsTileView.TileTemplate.Add(tileViewItemElement3);
            this.ItemsTileView.TileTemplate.Add(tileViewItemElement4);
            this.ItemsTileView.TileTemplate.Add(tileViewItemElement5);
            this.ItemsTileView.TileTemplate.Add(tileViewItemElement6);
            this.ItemsTileView.CustomItemTemplate += new DevExpress.XtraGrid.Views.Tile.TileViewCustomItemTemplateEventHandler(this.ItemsTileView_CustomItemTemplate);
            this.ItemsTileView.DoubleClick += new System.EventHandler(this.ItemsTileView_DoubleClick);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.groupControl1item,
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(949, 540);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // groupControl1item
            // 
            this.groupControl1item.ExpandButtonVisible = true;
            this.groupControl1item.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.addLayoutControlItem,
            this.emptySpaceItem1,
            this.editLayoutControlItem,
            this.emptySpaceItem2,
            this.saveLayoutControlItem});
            this.groupControl1item.Location = new System.Drawing.Point(0, 0);
            this.groupControl1item.Name = "groupControl1item";
            this.groupControl1item.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.groupControl1item.Size = new System.Drawing.Size(138, 520);
            this.groupControl1item.Text = "Akcje";
            this.groupControl1item.TextLocation = DevExpress.Utils.Locations.Right;
            // 
            // addLayoutControlItem
            // 
            this.addLayoutControlItem.Control = this.addSimpleButton;
            this.addLayoutControlItem.Location = new System.Drawing.Point(0, 0);
            this.addLayoutControlItem.MaxSize = new System.Drawing.Size(110, 26);
            this.addLayoutControlItem.MinSize = new System.Drawing.Size(110, 26);
            this.addLayoutControlItem.Name = "addLayoutControlItem";
            this.addLayoutControlItem.Size = new System.Drawing.Size(110, 26);
            this.addLayoutControlItem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.addLayoutControlItem.TextSize = new System.Drawing.Size(0, 0);
            this.addLayoutControlItem.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 133);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(110, 382);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // editLayoutControlItem
            // 
            this.editLayoutControlItem.Control = this.editSimpleButton;
            this.editLayoutControlItem.Location = new System.Drawing.Point(0, 26);
            this.editLayoutControlItem.MaxSize = new System.Drawing.Size(110, 26);
            this.editLayoutControlItem.MinSize = new System.Drawing.Size(110, 26);
            this.editLayoutControlItem.Name = "editLayoutControlItem";
            this.editLayoutControlItem.Size = new System.Drawing.Size(110, 26);
            this.editLayoutControlItem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.editLayoutControlItem.TextSize = new System.Drawing.Size(0, 0);
            this.editLayoutControlItem.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 52);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(110, 55);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // saveLayoutControlItem
            // 
            this.saveLayoutControlItem.Control = this.saveSimpleButton;
            this.saveLayoutControlItem.Location = new System.Drawing.Point(0, 107);
            this.saveLayoutControlItem.MaxSize = new System.Drawing.Size(110, 26);
            this.saveLayoutControlItem.MinSize = new System.Drawing.Size(110, 26);
            this.saveLayoutControlItem.Name = "saveLayoutControlItem";
            this.saveLayoutControlItem.Size = new System.Drawing.Size(110, 26);
            this.saveLayoutControlItem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.saveLayoutControlItem.TextSize = new System.Drawing.Size(0, 0);
            this.saveLayoutControlItem.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.ItemsGridControl;
            this.layoutControlItem1.Location = new System.Drawing.Point(138, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(791, 520);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 540);
            this.Controls.Add(this.Form1layoutControl1ConvertedLayout);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Form.IconOptions.LargeImage")));
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista zadań";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            this.Shown += new System.EventHandler(this.Form_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.Form1layoutControl1ConvertedLayout)).EndInit();
            this.Form1layoutControl1ConvertedLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsTileView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl Form1layoutControl1ConvertedLayout;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup groupControl1item;
        private DevExpress.XtraEditors.SimpleButton saveSimpleButton;
        private DevExpress.XtraEditors.SimpleButton editSimpleButton;
        private DevExpress.XtraEditors.SimpleButton addSimpleButton;
        private DevExpress.XtraGrid.GridControl ItemsGridControl;
        private DevExpress.XtraLayout.LayoutControlItem addLayoutControlItem;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem editLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlItem saveLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Views.Tile.TileView ItemsTileView;
        private DevExpress.XtraGrid.Columns.TileViewColumn colTitle;
        private DevExpress.XtraGrid.Columns.TileViewColumn colDescription;
        private DevExpress.XtraGrid.Columns.TileViewColumn colDate;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
    }
}

