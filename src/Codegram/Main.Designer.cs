namespace Codegram
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNew = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSave = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExport = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExportPNG = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExportJPG = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExportBMP = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExportGIF = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExportTIFF = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnClose = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnProperties1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRemove1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCopy1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPaste1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCut1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.btnGetToFront1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBackColor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnForeColor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnWorkSpaceColor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCopyImage = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsTools = new System.Windows.Forms.ToolStrip();
            this.btnArrow = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAddInstance = new System.Windows.Forms.ToolStripButton();
            this.btnAddText = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAssociation = new System.Windows.Forms.ToolStripButton();
            this.btnDependency = new System.Windows.Forms.ToolStripButton();
            this.btnAggregation = new System.Windows.Forms.ToolStripButton();
            this.btnComposition = new System.Windows.Forms.ToolStripButton();
            this.btnInheritance = new System.Windows.Forms.ToolStripButton();
            this.txtDocumantation = new System.Windows.Forms.TextBox();
            this.workSpace = new System.Windows.Forms.Panel();
            this.rightClickMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnProperties = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMultiplicity = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNone = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNoInstance = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNoInstanceOrOneInstance = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExactlyOneInstance = new System.Windows.Forms.ToolStripMenuItem();
            this.btnZeroOrMoreInstance = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOneOrMoreInstance = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCut = new System.Windows.Forms.ToolStripMenuItem();
            this.copyImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnGetToFront = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveDialog = new System.Windows.Forms.SaveFileDialog();
            this.openDialog = new System.Windows.Forms.OpenFileDialog();
            this.colorPicker = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.msMenu.SuspendLayout();
            this.tsTools.SuspendLayout();
            this.rightClickMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.BackColor = System.Drawing.SystemColors.Control;
            this.msMenu.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.btnEdit,
            this.viewToolStripMenuItem,
            this.btnHelp});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.msMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.msMenu.Size = new System.Drawing.Size(532, 28);
            this.msMenu.TabIndex = 0;
            this.msMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNew,
            this.btnOpen,
            this.toolStripSeparator9,
            this.btnSave,
            this.btnSaveAs,
            this.btnExport,
            this.toolStripSeparator5,
            this.btnClose});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(42, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // btnNew
            // 
            this.btnNew.Image = global::Codegram.Properties.Resources._new;
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(129, 24);
            this.btnNew.Text = "New";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Image = global::Codegram.Properties.Resources.open;
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(129, 24);
            this.btnOpen.Text = "Open";
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(126, 6);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::Codegram.Properties.Resources.save;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(129, 24);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.Image = global::Codegram.Properties.Resources.save_as;
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(129, 24);
            this.btnSaveAs.Text = "Save as";
            this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
            // 
            // btnExport
            // 
            this.btnExport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExportPNG,
            this.btnExportJPG,
            this.btnExportBMP,
            this.btnExportGIF,
            this.btnExportTIFF});
            this.btnExport.Image = global::Codegram.Properties.Resources.export;
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(129, 24);
            this.btnExport.Text = "Export as";
            // 
            // btnExportPNG
            // 
            this.btnExportPNG.Image = global::Codegram.Properties.Resources.png;
            this.btnExportPNG.Name = "btnExportPNG";
            this.btnExportPNG.Size = new System.Drawing.Size(106, 24);
            this.btnExportPNG.Text = "PNG";
            this.btnExportPNG.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnExportJPG
            // 
            this.btnExportJPG.Image = global::Codegram.Properties.Resources.jpg;
            this.btnExportJPG.Name = "btnExportJPG";
            this.btnExportJPG.Size = new System.Drawing.Size(106, 24);
            this.btnExportJPG.Text = "JPG";
            this.btnExportJPG.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnExportBMP
            // 
            this.btnExportBMP.Image = global::Codegram.Properties.Resources.bmp;
            this.btnExportBMP.Name = "btnExportBMP";
            this.btnExportBMP.Size = new System.Drawing.Size(106, 24);
            this.btnExportBMP.Text = "BMP";
            this.btnExportBMP.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnExportGIF
            // 
            this.btnExportGIF.Image = global::Codegram.Properties.Resources.gif;
            this.btnExportGIF.Name = "btnExportGIF";
            this.btnExportGIF.Size = new System.Drawing.Size(106, 24);
            this.btnExportGIF.Text = "GIF";
            this.btnExportGIF.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnExportTIFF
            // 
            this.btnExportTIFF.Image = global::Codegram.Properties.Resources.tiff;
            this.btnExportTIFF.Name = "btnExportTIFF";
            this.btnExportTIFF.Size = new System.Drawing.Size(106, 24);
            this.btnExportTIFF.Text = "TIFF";
            this.btnExportTIFF.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(126, 6);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::Codegram.Properties.Resources.close;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(129, 24);
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnProperties1,
            this.btnRemove1,
            this.toolStripSeparator10,
            this.btnCopy1,
            this.btnPaste1,
            this.btnCut1,
            this.toolStripSeparator11,
            this.btnGetToFront1});
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(42, 24);
            this.btnEdit.Text = "Edit";
            this.btnEdit.DropDownOpened += new System.EventHandler(this.btnEdit_DropDownOpened);
            // 
            // btnProperties1
            // 
            this.btnProperties1.Image = global::Codegram.Properties.Resources.properties;
            this.btnProperties1.Name = "btnProperties1";
            this.btnProperties1.Size = new System.Drawing.Size(167, 24);
            this.btnProperties1.Text = "Properties";
            this.btnProperties1.Click += new System.EventHandler(this.btnProperties_Click);
            // 
            // btnRemove1
            // 
            this.btnRemove1.Image = global::Codegram.Properties.Resources.minus;
            this.btnRemove1.Name = "btnRemove1";
            this.btnRemove1.Size = new System.Drawing.Size(167, 24);
            this.btnRemove1.Text = "Remove";
            this.btnRemove1.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(164, 6);
            // 
            // btnCopy1
            // 
            this.btnCopy1.Image = global::Codegram.Properties.Resources.copy;
            this.btnCopy1.Name = "btnCopy1";
            this.btnCopy1.Size = new System.Drawing.Size(167, 24);
            this.btnCopy1.Text = "Copy";
            this.btnCopy1.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnPaste1
            // 
            this.btnPaste1.Image = global::Codegram.Properties.Resources.paste;
            this.btnPaste1.Name = "btnPaste1";
            this.btnPaste1.Size = new System.Drawing.Size(167, 24);
            this.btnPaste1.Text = "Paste";
            this.btnPaste1.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // btnCut1
            // 
            this.btnCut1.Image = global::Codegram.Properties.Resources.cut;
            this.btnCut1.Name = "btnCut1";
            this.btnCut1.Size = new System.Drawing.Size(167, 24);
            this.btnCut1.Text = "Cut";
            this.btnCut1.Click += new System.EventHandler(this.btnCut_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(164, 6);
            // 
            // btnGetToFront1
            // 
            this.btnGetToFront1.Image = global::Codegram.Properties.Resources.front;
            this.btnGetToFront1.Name = "btnGetToFront1";
            this.btnGetToFront1.Size = new System.Drawing.Size(167, 24);
            this.btnGetToFront1.Text = "Bring to the front";
            this.btnGetToFront1.Click += new System.EventHandler(this.btnGetToFront_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBackColor,
            this.toolStripSeparator7,
            this.copyToolStripMenuItem,
            this.btnForeColor,
            this.toolStripSeparator6,
            this.btnWorkSpaceColor,
            this.toolStripSeparator8,
            this.btnCopyImage});
            this.viewToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.viewToolStripMenuItem.Text = "Graphics";
            // 
            // btnBackColor
            // 
            this.btnBackColor.Image = global::Codegram.Properties.Resources.backcolor;
            this.btnBackColor.Name = "btnBackColor";
            this.btnBackColor.Size = new System.Drawing.Size(175, 24);
            this.btnBackColor.Text = "BackColor";
            this.btnBackColor.Click += new System.EventHandler(this.btnBackColor_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(172, 6);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = global::Codegram.Properties.Resources.font;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.copyToolStripMenuItem.Text = "Font";
            // 
            // btnForeColor
            // 
            this.btnForeColor.Image = global::Codegram.Properties.Resources.fontcolor;
            this.btnForeColor.Name = "btnForeColor";
            this.btnForeColor.Size = new System.Drawing.Size(175, 24);
            this.btnForeColor.Text = "ForeColor";
            this.btnForeColor.Click += new System.EventHandler(this.btnForeColor_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(172, 6);
            // 
            // btnWorkSpaceColor
            // 
            this.btnWorkSpaceColor.Image = global::Codegram.Properties.Resources.workarea;
            this.btnWorkSpaceColor.Name = "btnWorkSpaceColor";
            this.btnWorkSpaceColor.Size = new System.Drawing.Size(175, 24);
            this.btnWorkSpaceColor.Text = "WorkSpace Color";
            this.btnWorkSpaceColor.Click += new System.EventHandler(this.btnWorkSpaceColor_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(172, 6);
            // 
            // btnCopyImage
            // 
            this.btnCopyImage.Image = global::Codegram.Properties.Resources.export;
            this.btnCopyImage.Name = "btnCopyImage";
            this.btnCopyImage.Size = new System.Drawing.Size(175, 24);
            this.btnCopyImage.Text = "Copy Image";
            this.btnCopyImage.Click += new System.EventHandler(this.btnCopyImage_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(47, 24);
            this.btnHelp.Text = "Help";
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // tsTools
            // 
            this.tsTools.BackColor = System.Drawing.SystemColors.Control;
            this.tsTools.Dock = System.Windows.Forms.DockStyle.Left;
            this.tsTools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnArrow,
            this.toolStripSeparator1,
            this.btnAddInstance,
            this.btnAddText,
            this.toolStripSeparator2,
            this.btnAssociation,
            this.btnDependency,
            this.btnAggregation,
            this.btnComposition,
            this.btnInheritance});
            this.tsTools.Location = new System.Drawing.Point(0, 28);
            this.tsTools.Name = "tsTools";
            this.tsTools.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsTools.Size = new System.Drawing.Size(24, 377);
            this.tsTools.TabIndex = 2;
            this.tsTools.Text = "toolStrip2";
            // 
            // btnArrow
            // 
            this.btnArrow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnArrow.Image = global::Codegram.Properties.Resources.arrow;
            this.btnArrow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnArrow.Name = "btnArrow";
            this.btnArrow.Size = new System.Drawing.Size(21, 20);
            this.btnArrow.Text = "Cursor";
            this.btnArrow.Click += new System.EventHandler(this.btnArrow_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(21, 6);
            // 
            // btnAddInstance
            // 
            this.btnAddInstance.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddInstance.Image = global::Codegram.Properties.Resources._class;
            this.btnAddInstance.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddInstance.Name = "btnAddInstance";
            this.btnAddInstance.Size = new System.Drawing.Size(21, 20);
            this.btnAddInstance.Text = "Instance";
            this.btnAddInstance.Click += new System.EventHandler(this.btnAddInstance_Click);
            // 
            // btnAddText
            // 
            this.btnAddText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddText.Image = global::Codegram.Properties.Resources.text;
            this.btnAddText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddText.Name = "btnAddText";
            this.btnAddText.Size = new System.Drawing.Size(21, 20);
            this.btnAddText.Text = "Text";
            this.btnAddText.Click += new System.EventHandler(this.btnAddText_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(21, 6);
            // 
            // btnAssociation
            // 
            this.btnAssociation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAssociation.Image = global::Codegram.Properties.Resources.association;
            this.btnAssociation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAssociation.Name = "btnAssociation";
            this.btnAssociation.Size = new System.Drawing.Size(21, 20);
            this.btnAssociation.Text = "Association";
            this.btnAssociation.Click += new System.EventHandler(this.btnAssociation_Click);
            // 
            // btnDependency
            // 
            this.btnDependency.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDependency.Image = global::Codegram.Properties.Resources.dependency;
            this.btnDependency.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDependency.Name = "btnDependency";
            this.btnDependency.Size = new System.Drawing.Size(21, 20);
            this.btnDependency.Text = "Dependency";
            this.btnDependency.Click += new System.EventHandler(this.btnDependency_Click);
            // 
            // btnAggregation
            // 
            this.btnAggregation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAggregation.Image = global::Codegram.Properties.Resources.aggregation;
            this.btnAggregation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAggregation.Name = "btnAggregation";
            this.btnAggregation.Size = new System.Drawing.Size(21, 20);
            this.btnAggregation.Text = "Aggregation";
            this.btnAggregation.Click += new System.EventHandler(this.btnAggregation_Click);
            // 
            // btnComposition
            // 
            this.btnComposition.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnComposition.Image = global::Codegram.Properties.Resources.compotition;
            this.btnComposition.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnComposition.Name = "btnComposition";
            this.btnComposition.Size = new System.Drawing.Size(21, 20);
            this.btnComposition.Text = "Composition";
            this.btnComposition.Click += new System.EventHandler(this.btnComposition_Click);
            // 
            // btnInheritance
            // 
            this.btnInheritance.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnInheritance.Image = global::Codegram.Properties.Resources.inherency;
            this.btnInheritance.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInheritance.Name = "btnInheritance";
            this.btnInheritance.Size = new System.Drawing.Size(21, 20);
            this.btnInheritance.Text = "Inheritance";
            this.btnInheritance.Click += new System.EventHandler(this.btnInheritance_Click);
            // 
            // txtDocumantation
            // 
            this.txtDocumantation.BackColor = System.Drawing.Color.White;
            this.txtDocumantation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtDocumantation.Enabled = false;
            this.txtDocumantation.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumantation.Location = new System.Drawing.Point(24, 340);
            this.txtDocumantation.Multiline = true;
            this.txtDocumantation.Name = "txtDocumantation";
            this.txtDocumantation.Size = new System.Drawing.Size(508, 65);
            this.txtDocumantation.TabIndex = 3;
            this.txtDocumantation.TextChanged += new System.EventHandler(this.txtDocumantation_TextChanged);
            // 
            // workSpace
            // 
            this.workSpace.AllowDrop = true;
            this.workSpace.BackColor = System.Drawing.Color.White;
            this.workSpace.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.workSpace.ContextMenuStrip = this.rightClickMenu;
            this.workSpace.Location = new System.Drawing.Point(0, 0);
            this.workSpace.Name = "workSpace";
            this.workSpace.Size = new System.Drawing.Size(496, 296);
            this.workSpace.TabIndex = 4;
            this.workSpace.DragDrop += new System.Windows.Forms.DragEventHandler(this.workSpace_DragDrop);
            this.workSpace.DragEnter += new System.Windows.Forms.DragEventHandler(this.workSpace_DragEnter);
            this.workSpace.Paint += new System.Windows.Forms.PaintEventHandler(this.workSpace_Paint);
            this.workSpace.MouseDown += new System.Windows.Forms.MouseEventHandler(this.workSpace_MouseDown);
            this.workSpace.MouseMove += new System.Windows.Forms.MouseEventHandler(this.workSpace_MouseMove);
            this.workSpace.MouseUp += new System.Windows.Forms.MouseEventHandler(this.workSpace_MouseUp);
            // 
            // rightClickMenu
            // 
            this.rightClickMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnProperties,
            this.btnMultiplicity,
            this.btnRemove,
            this.toolStripSeparator4,
            this.btnCopy,
            this.btnPaste,
            this.btnCut,
            this.copyImageToolStripMenuItem,
            this.toolStripSeparator3,
            this.btnGetToFront});
            this.rightClickMenu.Name = "contextMenuStrip1";
            this.rightClickMenu.Size = new System.Drawing.Size(166, 192);
            this.rightClickMenu.Opening += new System.ComponentModel.CancelEventHandler(this.rightClickMenu_Opening);
            // 
            // btnProperties
            // 
            this.btnProperties.Image = global::Codegram.Properties.Resources.properties;
            this.btnProperties.Name = "btnProperties";
            this.btnProperties.Size = new System.Drawing.Size(165, 22);
            this.btnProperties.Text = "Properties";
            this.btnProperties.Click += new System.EventHandler(this.btnProperties_Click);
            // 
            // btnMultiplicity
            // 
            this.btnMultiplicity.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNone,
            this.btnNoInstance,
            this.btnNoInstanceOrOneInstance,
            this.btnExactlyOneInstance,
            this.btnZeroOrMoreInstance,
            this.btnOneOrMoreInstance});
            this.btnMultiplicity.Name = "btnMultiplicity";
            this.btnMultiplicity.Size = new System.Drawing.Size(165, 22);
            this.btnMultiplicity.Text = "Multiplicity";
            // 
            // btnNone
            // 
            this.btnNone.Name = "btnNone";
            this.btnNone.Size = new System.Drawing.Size(103, 22);
            this.btnNone.Text = "None";
            this.btnNone.Click += new System.EventHandler(this.btnNone_Click);
            // 
            // btnNoInstance
            // 
            this.btnNoInstance.Name = "btnNoInstance";
            this.btnNoInstance.Size = new System.Drawing.Size(103, 22);
            this.btnNoInstance.Text = "0";
            this.btnNoInstance.Click += new System.EventHandler(this.btnNoInstance_Click);
            // 
            // btnNoInstanceOrOneInstance
            // 
            this.btnNoInstanceOrOneInstance.Name = "btnNoInstanceOrOneInstance";
            this.btnNoInstanceOrOneInstance.Size = new System.Drawing.Size(103, 22);
            this.btnNoInstanceOrOneInstance.Text = "0..1";
            this.btnNoInstanceOrOneInstance.Click += new System.EventHandler(this.btnNoInstanceOrOneInstance_Click);
            // 
            // btnExactlyOneInstance
            // 
            this.btnExactlyOneInstance.Name = "btnExactlyOneInstance";
            this.btnExactlyOneInstance.Size = new System.Drawing.Size(103, 22);
            this.btnExactlyOneInstance.Text = "1";
            this.btnExactlyOneInstance.Click += new System.EventHandler(this.btnExactlyOneInstance_Click);
            // 
            // btnZeroOrMoreInstance
            // 
            this.btnZeroOrMoreInstance.Name = "btnZeroOrMoreInstance";
            this.btnZeroOrMoreInstance.Size = new System.Drawing.Size(103, 22);
            this.btnZeroOrMoreInstance.Text = "0..*";
            this.btnZeroOrMoreInstance.Click += new System.EventHandler(this.btnZeroOrMoreInstance_Click);
            // 
            // btnOneOrMoreInstance
            // 
            this.btnOneOrMoreInstance.Name = "btnOneOrMoreInstance";
            this.btnOneOrMoreInstance.Size = new System.Drawing.Size(103, 22);
            this.btnOneOrMoreInstance.Text = "1..*";
            this.btnOneOrMoreInstance.Click += new System.EventHandler(this.btnOneOrMoreInstance_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Image = global::Codegram.Properties.Resources.minus;
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(165, 22);
            this.btnRemove.Text = "Remove";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(162, 6);
            // 
            // btnCopy
            // 
            this.btnCopy.Image = global::Codegram.Properties.Resources.copy;
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(165, 22);
            this.btnCopy.Text = "Copy";
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnPaste
            // 
            this.btnPaste.Image = global::Codegram.Properties.Resources.paste;
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(165, 22);
            this.btnPaste.Text = "Paste";
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // btnCut
            // 
            this.btnCut.Image = global::Codegram.Properties.Resources.cut;
            this.btnCut.Name = "btnCut";
            this.btnCut.Size = new System.Drawing.Size(165, 22);
            this.btnCut.Text = "Cut";
            this.btnCut.Click += new System.EventHandler(this.btnCut_Click);
            // 
            // copyImageToolStripMenuItem
            // 
            this.copyImageToolStripMenuItem.Image = global::Codegram.Properties.Resources.export;
            this.copyImageToolStripMenuItem.Name = "copyImageToolStripMenuItem";
            this.copyImageToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.copyImageToolStripMenuItem.Text = "Copy Image";
            this.copyImageToolStripMenuItem.Click += new System.EventHandler(this.btnCopyImage_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(162, 6);
            // 
            // btnGetToFront
            // 
            this.btnGetToFront.Image = global::Codegram.Properties.Resources.front;
            this.btnGetToFront.Name = "btnGetToFront";
            this.btnGetToFront.Size = new System.Drawing.Size(165, 22);
            this.btnGetToFront.Text = "Bring to the front";
            this.btnGetToFront.Click += new System.EventHandler(this.btnGetToFront_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.ContextMenuStrip = this.rightClickMenu;
            this.panel1.Controls.Add(this.workSpace);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(24, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(508, 312);
            this.panel1.TabIndex = 5;
            // 
            // saveDialog
            // 
            this.saveDialog.FileName = "New Codegram FIle";
            this.saveDialog.Filter = "Codegram File|*.cdg";
            // 
            // openDialog
            // 
            this.openDialog.Filter = "Codegram File|*.cdg";
            this.openDialog.Title = "Open your Codegram File";
            // 
            // colorPicker
            // 
            this.colorPicker.FullOpen = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 33;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 405);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtDocumantation);
            this.Controls.Add(this.tsTools);
            this.Controls.Add(this.msMenu);
            this.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMenu;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MinimumSize = new System.Drawing.Size(548, 444);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Codegram";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.tsTools.ResumeLayout(false);
            this.tsTools.PerformLayout();
            this.rightClickMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnHelp;
        private System.Windows.Forms.ToolStrip tsTools;
        private System.Windows.Forms.TextBox txtDocumantation;
        private System.Windows.Forms.Panel workSpace;
        private System.Windows.Forms.ToolStripButton btnArrow;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnAddInstance;
        private System.Windows.Forms.ToolStripButton btnAddText;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnAssociation;
        private System.Windows.Forms.ToolStripButton btnDependency;
        private System.Windows.Forms.ToolStripButton btnAggregation;
        private System.Windows.Forms.ToolStripButton btnComposition;
        private System.Windows.Forms.ToolStripButton btnInheritance;
        private System.Windows.Forms.ContextMenuStrip rightClickMenu;
        private System.Windows.Forms.ToolStripMenuItem btnCopy;
        private System.Windows.Forms.ToolStripMenuItem btnPaste;
        private System.Windows.Forms.ToolStripMenuItem btnCut;
        private System.Windows.Forms.ToolStripMenuItem btnProperties;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem btnGetToFront;
        private System.Windows.Forms.ToolStripMenuItem btnRemove;
        private System.Windows.Forms.ToolStripMenuItem btnNew;
        private System.Windows.Forms.ToolStripMenuItem btnOpen;
        private System.Windows.Forms.ToolStripMenuItem btnSave;
        private System.Windows.Forms.ToolStripMenuItem btnSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem btnClose;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem btnEdit;
        private System.Windows.Forms.ToolStripMenuItem btnProperties1;
        private System.Windows.Forms.ToolStripMenuItem btnRemove1;
        private System.Windows.Forms.ToolStripMenuItem btnCopy1;
        private System.Windows.Forms.ToolStripMenuItem btnPaste1;
        private System.Windows.Forms.ToolStripMenuItem btnCut1;
        private System.Windows.Forms.ToolStripMenuItem btnGetToFront1;
        private System.Windows.Forms.ToolStripMenuItem btnBackColor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem btnForeColor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem btnWorkSpaceColor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem btnCopyImage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripMenuItem btnMultiplicity;
        private System.Windows.Forms.ToolStripMenuItem btnNone;
        private System.Windows.Forms.ToolStripMenuItem btnNoInstance;
        private System.Windows.Forms.ToolStripMenuItem btnNoInstanceOrOneInstance;
        private System.Windows.Forms.ToolStripMenuItem btnExactlyOneInstance;
        private System.Windows.Forms.ToolStripMenuItem btnZeroOrMoreInstance;
        private System.Windows.Forms.ToolStripMenuItem btnOneOrMoreInstance;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem btnExport;
        private System.Windows.Forms.SaveFileDialog saveDialog;
        private System.Windows.Forms.OpenFileDialog openDialog;
        private System.Windows.Forms.ToolStripMenuItem btnExportPNG;
        private System.Windows.Forms.ToolStripMenuItem btnExportJPG;
        private System.Windows.Forms.ToolStripMenuItem btnExportBMP;
        private System.Windows.Forms.ToolStripMenuItem btnExportGIF;
        private System.Windows.Forms.ToolStripMenuItem btnExportTIFF;
        private System.Windows.Forms.ToolStripMenuItem copyImageToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorPicker;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.Timer timer1;
    }
}

