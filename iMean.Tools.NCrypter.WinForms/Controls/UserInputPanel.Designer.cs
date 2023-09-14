namespace iMean.Tools.NCrypter.WinForms.Controls
{
    partial class UserInputPanel
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInputPanel));
            DevExpress.XtraLayout.ColumnDefinition columnDefinition1 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition2 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition3 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition4 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition5 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition3 = new DevExpress.XtraLayout.RowDefinition();
            this.mainLayoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.keyFilepathButtonEdit = new DevExpress.XtraEditors.ButtonEdit();
            this.decryptButton = new DevExpress.XtraEditors.SimpleButton();
            this.encryptButton = new DevExpress.XtraEditors.SimpleButton();
            this.inputTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.inputTextEditLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.encryptButtonLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.decryptButtonLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.keyFilepathButtonEditLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.mainLayoutControl)).BeginInit();
            this.mainLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.keyFilepathButtonEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputTextEditLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.encryptButtonLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.decryptButtonLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyFilepathButtonEditLayoutControlItem)).BeginInit();
            this.SuspendLayout();
            // 
            // mainLayoutControl
            // 
            this.mainLayoutControl.Controls.Add(this.keyFilepathButtonEdit);
            this.mainLayoutControl.Controls.Add(this.decryptButton);
            this.mainLayoutControl.Controls.Add(this.encryptButton);
            this.mainLayoutControl.Controls.Add(this.inputTextEdit);
            this.mainLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayoutControl.Location = new System.Drawing.Point(0, 0);
            this.mainLayoutControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainLayoutControl.Name = "mainLayoutControl";
            this.mainLayoutControl.Root = this.Root;
            this.mainLayoutControl.Size = new System.Drawing.Size(536, 220);
            this.mainLayoutControl.TabIndex = 0;
            this.mainLayoutControl.Text = "layoutControl1";
            // 
            // keyFilepathButtonEdit
            // 
            this.keyFilepathButtonEdit.Location = new System.Drawing.Point(11, 102);
            this.keyFilepathButtonEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.keyFilepathButtonEdit.Name = "keyFilepathButtonEdit";
            this.keyFilepathButtonEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.keyFilepathButtonEdit.Size = new System.Drawing.Size(514, 28);
            this.keyFilepathButtonEdit.StyleController = this.mainLayoutControl;
            this.keyFilepathButtonEdit.TabIndex = 7;
            this.keyFilepathButtonEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.OnKeyFilepathButtonClick);
            // 
            // decryptButton
            // 
            this.decryptButton.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.decryptButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("decryptButton.ImageOptions.SvgImage")));
            this.decryptButton.Location = new System.Drawing.Point(321, 152);
            this.decryptButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(204, 52);
            this.decryptButton.StyleController = this.mainLayoutControl;
            this.decryptButton.TabIndex = 6;
            this.decryptButton.Text = "DCrypt";
            // 
            // encryptButton
            // 
            this.encryptButton.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.encryptButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("encryptButton.ImageOptions.SvgImage")));
            this.encryptButton.Location = new System.Drawing.Point(11, 152);
            this.encryptButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(202, 52);
            this.encryptButton.StyleController = this.mainLayoutControl;
            this.encryptButton.TabIndex = 5;
            this.encryptButton.Text = "NCrypt";
            // 
            // inputTextEdit
            // 
            this.inputTextEdit.Location = new System.Drawing.Point(11, 40);
            this.inputTextEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputTextEdit.Name = "inputTextEdit";
            this.inputTextEdit.Size = new System.Drawing.Size(514, 28);
            this.inputTextEdit.StyleController = this.mainLayoutControl;
            this.inputTextEdit.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.inputTextEditLayoutControlItem,
            this.encryptButtonLayoutControlItem,
            this.decryptButtonLayoutControlItem,
            this.keyFilepathButtonEditLayoutControlItem});
            this.Root.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.Root.Name = "Root";
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition1.Width = 20D;
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition2.Width = 20D;
            columnDefinition3.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition3.Width = 20D;
            columnDefinition4.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition4.Width = 20D;
            columnDefinition5.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition5.Width = 20D;
            this.Root.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1,
            columnDefinition2,
            columnDefinition3,
            columnDefinition4,
            columnDefinition5});
            rowDefinition1.Height = 20D;
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
            rowDefinition2.Height = 20D;
            rowDefinition2.SizeType = System.Windows.Forms.SizeType.Percent;
            rowDefinition3.Height = 20D;
            rowDefinition3.SizeType = System.Windows.Forms.SizeType.Percent;
            this.Root.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2,
            rowDefinition3});
            this.Root.Size = new System.Drawing.Size(536, 220);
            this.Root.TextVisible = false;
            // 
            // inputTextEditLayoutControlItem
            // 
            this.inputTextEditLayoutControlItem.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center;
            this.inputTextEditLayoutControlItem.Control = this.inputTextEdit;
            this.inputTextEditLayoutControlItem.Location = new System.Drawing.Point(0, 0);
            this.inputTextEditLayoutControlItem.Name = "inputTextEditLayoutControlItem";
            this.inputTextEditLayoutControlItem.OptionsTableLayoutItem.ColumnSpan = 5;
            this.inputTextEditLayoutControlItem.Size = new System.Drawing.Size(518, 68);
            this.inputTextEditLayoutControlItem.Text = "Input:";
            this.inputTextEditLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.inputTextEditLayoutControlItem.TextSize = new System.Drawing.Size(91, 21);
            // 
            // encryptButtonLayoutControlItem
            // 
            this.encryptButtonLayoutControlItem.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center;
            this.encryptButtonLayoutControlItem.Control = this.encryptButton;
            this.encryptButtonLayoutControlItem.Location = new System.Drawing.Point(0, 136);
            this.encryptButtonLayoutControlItem.Name = "encryptButtonLayoutControlItem";
            this.encryptButtonLayoutControlItem.OptionsTableLayoutItem.ColumnSpan = 2;
            this.encryptButtonLayoutControlItem.OptionsTableLayoutItem.RowIndex = 2;
            this.encryptButtonLayoutControlItem.Size = new System.Drawing.Size(206, 68);
            this.encryptButtonLayoutControlItem.TextSize = new System.Drawing.Size(0, 0);
            this.encryptButtonLayoutControlItem.TextVisible = false;
            // 
            // decryptButtonLayoutControlItem
            // 
            this.decryptButtonLayoutControlItem.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center;
            this.decryptButtonLayoutControlItem.Control = this.decryptButton;
            this.decryptButtonLayoutControlItem.Location = new System.Drawing.Point(310, 136);
            this.decryptButtonLayoutControlItem.Name = "decryptButtonLayoutControlItem";
            this.decryptButtonLayoutControlItem.OptionsTableLayoutItem.ColumnIndex = 3;
            this.decryptButtonLayoutControlItem.OptionsTableLayoutItem.ColumnSpan = 2;
            this.decryptButtonLayoutControlItem.OptionsTableLayoutItem.RowIndex = 2;
            this.decryptButtonLayoutControlItem.Size = new System.Drawing.Size(208, 68);
            this.decryptButtonLayoutControlItem.TextSize = new System.Drawing.Size(0, 0);
            this.decryptButtonLayoutControlItem.TextVisible = false;
            // 
            // keyFilepathButtonEditLayoutControlItem
            // 
            this.keyFilepathButtonEditLayoutControlItem.Control = this.keyFilepathButtonEdit;
            this.keyFilepathButtonEditLayoutControlItem.Location = new System.Drawing.Point(0, 68);
            this.keyFilepathButtonEditLayoutControlItem.Name = "keyFilepathButtonEditLayoutControlItem";
            this.keyFilepathButtonEditLayoutControlItem.OptionsTableLayoutItem.ColumnSpan = 5;
            this.keyFilepathButtonEditLayoutControlItem.OptionsTableLayoutItem.RowIndex = 1;
            this.keyFilepathButtonEditLayoutControlItem.Size = new System.Drawing.Size(518, 68);
            this.keyFilepathButtonEditLayoutControlItem.Text = "Key Location:";
            this.keyFilepathButtonEditLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.keyFilepathButtonEditLayoutControlItem.TextSize = new System.Drawing.Size(91, 21);
            // 
            // UserInputPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainLayoutControl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserInputPanel";
            this.Size = new System.Drawing.Size(536, 220);
            ((System.ComponentModel.ISupportInitialize)(this.mainLayoutControl)).EndInit();
            this.mainLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.keyFilepathButtonEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputTextEditLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.encryptButtonLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.decryptButtonLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyFilepathButtonEditLayoutControlItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl mainLayoutControl;
        private DevExpress.XtraEditors.SimpleButton decryptButton;
        private DevExpress.XtraEditors.SimpleButton encryptButton;
        private DevExpress.XtraEditors.TextEdit inputTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem inputTextEditLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlItem encryptButtonLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlItem decryptButtonLayoutControlItem;
        private DevExpress.XtraEditors.ButtonEdit keyFilepathButtonEdit;
        private DevExpress.XtraLayout.LayoutControlItem keyFilepathButtonEditLayoutControlItem;
    }
}
