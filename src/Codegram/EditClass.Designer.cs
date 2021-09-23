namespace Codegram
{
    partial class EditClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditClass));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblMessage = new System.Windows.Forms.Label();
            this.classDocumentation = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.className = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.atributeRemove = new System.Windows.Forms.Button();
            this.atributeAdd = new System.Windows.Forms.Button();
            this.atributeSave = new System.Windows.Forms.Button();
            this.atributeAccess = new System.Windows.Forms.GroupBox();
            this.atributeGet = new System.Windows.Forms.CheckBox();
            this.atributeSet = new System.Windows.Forms.CheckBox();
            this.atributeVisibility = new System.Windows.Forms.GroupBox();
            this.atributeProtected = new System.Windows.Forms.RadioButton();
            this.atributePublic = new System.Windows.Forms.RadioButton();
            this.atributePrivate = new System.Windows.Forms.RadioButton();
            this.atributeType = new System.Windows.Forms.ComboBox();
            this.atributeValue = new System.Windows.Forms.TextBox();
            this.atributeName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.atributeList = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.methodRemove = new System.Windows.Forms.Button();
            this.methodAdd = new System.Windows.Forms.Button();
            this.methodCode = new System.Windows.Forms.Button();
            this.methodVisibility = new System.Windows.Forms.GroupBox();
            this.methodProtected = new System.Windows.Forms.RadioButton();
            this.methodPublic = new System.Windows.Forms.RadioButton();
            this.methodPrivate = new System.Windows.Forms.RadioButton();
            this.methodVirtual = new System.Windows.Forms.CheckBox();
            this.methodParameters = new System.Windows.Forms.Button();
            this.methodSave = new System.Windows.Forms.Button();
            this.methodType = new System.Windows.Forms.ComboBox();
            this.methodName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.methodList = new System.Windows.Forms.ListBox();
            this.classSave = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.atributeAccess.SuspendLayout();
            this.atributeVisibility.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.methodVisibility.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(320, 354);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblMessage);
            this.tabPage1.Controls.Add(this.classDocumentation);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.className);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tabPage1.Size = new System.Drawing.Size(312, 321);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Class";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(56, 36);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(105, 20);
            this.lblMessage.TabIndex = 9;
            this.lblMessage.Text = "Name not aviable";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // classDocumentation
            // 
            this.classDocumentation.Location = new System.Drawing.Point(8, 81);
            this.classDocumentation.Multiline = true;
            this.classDocumentation.Name = "classDocumentation";
            this.classDocumentation.Size = new System.Drawing.Size(296, 232);
            this.classDocumentation.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Documentation:";
            // 
            // className
            // 
            this.className.Location = new System.Drawing.Point(60, 8);
            this.className.Name = "className";
            this.className.Size = new System.Drawing.Size(244, 25);
            this.className.TabIndex = 5;
            this.className.TextChanged += new System.EventHandler(this.className_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Name:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.atributeRemove);
            this.tabPage2.Controls.Add(this.atributeAdd);
            this.tabPage2.Controls.Add(this.atributeSave);
            this.tabPage2.Controls.Add(this.atributeAccess);
            this.tabPage2.Controls.Add(this.atributeVisibility);
            this.tabPage2.Controls.Add(this.atributeType);
            this.tabPage2.Controls.Add(this.atributeValue);
            this.tabPage2.Controls.Add(this.atributeName);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.atributeList);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tabPage2.Size = new System.Drawing.Size(312, 321);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Attributes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // atributeRemove
            // 
            this.atributeRemove.Enabled = false;
            this.atributeRemove.Image = global::Codegram.Properties.Resources.minus;
            this.atributeRemove.Location = new System.Drawing.Point(281, 136);
            this.atributeRemove.Name = "atributeRemove";
            this.atributeRemove.Size = new System.Drawing.Size(23, 23);
            this.atributeRemove.TabIndex = 16;
            this.atributeRemove.UseVisualStyleBackColor = true;
            this.atributeRemove.Click += new System.EventHandler(this.atributeRemove_Click);
            // 
            // atributeAdd
            // 
            this.atributeAdd.Image = global::Codegram.Properties.Resources.add;
            this.atributeAdd.Location = new System.Drawing.Point(252, 136);
            this.atributeAdd.Name = "atributeAdd";
            this.atributeAdd.Size = new System.Drawing.Size(23, 23);
            this.atributeAdd.TabIndex = 15;
            this.atributeAdd.UseVisualStyleBackColor = true;
            this.atributeAdd.Click += new System.EventHandler(this.atributeAdd_Click);
            // 
            // atributeSave
            // 
            this.atributeSave.Enabled = false;
            this.atributeSave.Location = new System.Drawing.Point(151, 273);
            this.atributeSave.Name = "atributeSave";
            this.atributeSave.Size = new System.Drawing.Size(153, 33);
            this.atributeSave.TabIndex = 14;
            this.atributeSave.Text = "Save Attribute";
            this.atributeSave.UseVisualStyleBackColor = true;
            this.atributeSave.Click += new System.EventHandler(this.atributeSave_Click);
            // 
            // atributeAccess
            // 
            this.atributeAccess.Controls.Add(this.atributeGet);
            this.atributeAccess.Controls.Add(this.atributeSet);
            this.atributeAccess.Enabled = false;
            this.atributeAccess.Location = new System.Drawing.Point(8, 258);
            this.atributeAccess.Name = "atributeAccess";
            this.atributeAccess.Size = new System.Drawing.Size(137, 53);
            this.atributeAccess.TabIndex = 11;
            this.atributeAccess.TabStop = false;
            this.atributeAccess.Text = "Access";
            // 
            // atributeGet
            // 
            this.atributeGet.AutoSize = true;
            this.atributeGet.Location = new System.Drawing.Point(6, 24);
            this.atributeGet.Name = "atributeGet";
            this.atributeGet.Size = new System.Drawing.Size(48, 24);
            this.atributeGet.TabIndex = 9;
            this.atributeGet.Text = "Get";
            this.atributeGet.UseVisualStyleBackColor = true;
            // 
            // atributeSet
            // 
            this.atributeSet.AutoSize = true;
            this.atributeSet.Location = new System.Drawing.Point(83, 24);
            this.atributeSet.Name = "atributeSet";
            this.atributeSet.Size = new System.Drawing.Size(46, 24);
            this.atributeSet.TabIndex = 10;
            this.atributeSet.Text = "Set";
            this.atributeSet.UseVisualStyleBackColor = true;
            // 
            // atributeVisibility
            // 
            this.atributeVisibility.Controls.Add(this.atributeProtected);
            this.atributeVisibility.Controls.Add(this.atributePublic);
            this.atributeVisibility.Controls.Add(this.atributePrivate);
            this.atributeVisibility.Enabled = false;
            this.atributeVisibility.Location = new System.Drawing.Point(8, 162);
            this.atributeVisibility.Name = "atributeVisibility";
            this.atributeVisibility.Size = new System.Drawing.Size(91, 90);
            this.atributeVisibility.TabIndex = 8;
            this.atributeVisibility.TabStop = false;
            this.atributeVisibility.Text = "Visibility";
            // 
            // atributeProtected
            // 
            this.atributeProtected.AutoSize = true;
            this.atributeProtected.Location = new System.Drawing.Point(6, 60);
            this.atributeProtected.Name = "atributeProtected";
            this.atributeProtected.Size = new System.Drawing.Size(80, 24);
            this.atributeProtected.TabIndex = 11;
            this.atributeProtected.TabStop = true;
            this.atributeProtected.Text = "Protected";
            this.atributeProtected.UseVisualStyleBackColor = true;
            // 
            // atributePublic
            // 
            this.atributePublic.AutoSize = true;
            this.atributePublic.Location = new System.Drawing.Point(6, 20);
            this.atributePublic.Name = "atributePublic";
            this.atributePublic.Size = new System.Drawing.Size(62, 24);
            this.atributePublic.TabIndex = 9;
            this.atributePublic.TabStop = true;
            this.atributePublic.Text = "Public";
            this.atributePublic.UseVisualStyleBackColor = true;
            // 
            // atributePrivate
            // 
            this.atributePrivate.AutoSize = true;
            this.atributePrivate.Location = new System.Drawing.Point(6, 40);
            this.atributePrivate.Name = "atributePrivate";
            this.atributePrivate.Size = new System.Drawing.Size(64, 24);
            this.atributePrivate.TabIndex = 10;
            this.atributePrivate.TabStop = true;
            this.atributePrivate.Text = "Private";
            this.atributePrivate.UseVisualStyleBackColor = true;
            // 
            // atributeType
            // 
            this.atributeType.Enabled = false;
            this.atributeType.FormattingEnabled = true;
            this.atributeType.Items.AddRange(new object[] {
            "int",
            "short",
            "long long",
            "float",
            "double",
            "char"});
            this.atributeType.Location = new System.Drawing.Point(151, 162);
            this.atributeType.Name = "atributeType";
            this.atributeType.Size = new System.Drawing.Size(153, 28);
            this.atributeType.TabIndex = 7;
            // 
            // atributeValue
            // 
            this.atributeValue.Enabled = false;
            this.atributeValue.Location = new System.Drawing.Point(151, 227);
            this.atributeValue.Name = "atributeValue";
            this.atributeValue.Size = new System.Drawing.Size(153, 25);
            this.atributeValue.TabIndex = 5;
            // 
            // atributeName
            // 
            this.atributeName.Enabled = false;
            this.atributeName.Location = new System.Drawing.Point(151, 196);
            this.atributeName.Name = "atributeName";
            this.atributeName.Size = new System.Drawing.Size(153, 25);
            this.atributeName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Value:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Type:";
            // 
            // atributeList
            // 
            this.atributeList.FormattingEnabled = true;
            this.atributeList.ItemHeight = 20;
            this.atributeList.Location = new System.Drawing.Point(8, 10);
            this.atributeList.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.atributeList.Name = "atributeList";
            this.atributeList.Size = new System.Drawing.Size(296, 124);
            this.atributeList.TabIndex = 0;
            this.atributeList.SelectedIndexChanged += new System.EventHandler(this.atributeList_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.methodRemove);
            this.tabPage3.Controls.Add(this.methodAdd);
            this.tabPage3.Controls.Add(this.methodCode);
            this.tabPage3.Controls.Add(this.methodVisibility);
            this.tabPage3.Controls.Add(this.methodVirtual);
            this.tabPage3.Controls.Add(this.methodParameters);
            this.tabPage3.Controls.Add(this.methodSave);
            this.tabPage3.Controls.Add(this.methodType);
            this.tabPage3.Controls.Add(this.methodName);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.methodList);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tabPage3.Size = new System.Drawing.Size(312, 321);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Methods";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // methodRemove
            // 
            this.methodRemove.Enabled = false;
            this.methodRemove.Image = global::Codegram.Properties.Resources.minus;
            this.methodRemove.Location = new System.Drawing.Point(281, 136);
            this.methodRemove.Name = "methodRemove";
            this.methodRemove.Size = new System.Drawing.Size(23, 23);
            this.methodRemove.TabIndex = 27;
            this.methodRemove.UseVisualStyleBackColor = true;
            this.methodRemove.Click += new System.EventHandler(this.methodRemove_Click);
            // 
            // methodAdd
            // 
            this.methodAdd.Image = global::Codegram.Properties.Resources.add;
            this.methodAdd.Location = new System.Drawing.Point(252, 136);
            this.methodAdd.Name = "methodAdd";
            this.methodAdd.Size = new System.Drawing.Size(23, 23);
            this.methodAdd.TabIndex = 26;
            this.methodAdd.UseVisualStyleBackColor = true;
            this.methodAdd.Click += new System.EventHandler(this.methodAdd_Click);
            // 
            // methodCode
            // 
            this.methodCode.Enabled = false;
            this.methodCode.Location = new System.Drawing.Point(8, 273);
            this.methodCode.Name = "methodCode";
            this.methodCode.Size = new System.Drawing.Size(137, 33);
            this.methodCode.TabIndex = 25;
            this.methodCode.Text = "Code";
            this.methodCode.UseVisualStyleBackColor = true;
            this.methodCode.Visible = false;
            // 
            // methodVisibility
            // 
            this.methodVisibility.Controls.Add(this.methodProtected);
            this.methodVisibility.Controls.Add(this.methodPublic);
            this.methodVisibility.Controls.Add(this.methodPrivate);
            this.methodVisibility.Enabled = false;
            this.methodVisibility.Location = new System.Drawing.Point(8, 162);
            this.methodVisibility.Name = "methodVisibility";
            this.methodVisibility.Size = new System.Drawing.Size(91, 90);
            this.methodVisibility.TabIndex = 22;
            this.methodVisibility.TabStop = false;
            this.methodVisibility.Text = "Visibility";
            // 
            // methodProtected
            // 
            this.methodProtected.AutoSize = true;
            this.methodProtected.Location = new System.Drawing.Point(6, 60);
            this.methodProtected.Name = "methodProtected";
            this.methodProtected.Size = new System.Drawing.Size(80, 24);
            this.methodProtected.TabIndex = 11;
            this.methodProtected.TabStop = true;
            this.methodProtected.Text = "Protected";
            this.methodProtected.UseVisualStyleBackColor = true;
            // 
            // methodPublic
            // 
            this.methodPublic.AutoSize = true;
            this.methodPublic.Location = new System.Drawing.Point(6, 20);
            this.methodPublic.Name = "methodPublic";
            this.methodPublic.Size = new System.Drawing.Size(62, 24);
            this.methodPublic.TabIndex = 9;
            this.methodPublic.TabStop = true;
            this.methodPublic.Text = "Public";
            this.methodPublic.UseVisualStyleBackColor = true;
            // 
            // methodPrivate
            // 
            this.methodPrivate.AutoSize = true;
            this.methodPrivate.Location = new System.Drawing.Point(6, 40);
            this.methodPrivate.Name = "methodPrivate";
            this.methodPrivate.Size = new System.Drawing.Size(64, 24);
            this.methodPrivate.TabIndex = 10;
            this.methodPrivate.TabStop = true;
            this.methodPrivate.Text = "Private";
            this.methodPrivate.UseVisualStyleBackColor = true;
            // 
            // methodVirtual
            // 
            this.methodVirtual.AutoSize = true;
            this.methodVirtual.Enabled = false;
            this.methodVirtual.Location = new System.Drawing.Point(14, 251);
            this.methodVirtual.Name = "methodVirtual";
            this.methodVirtual.Size = new System.Drawing.Size(62, 24);
            this.methodVirtual.TabIndex = 12;
            this.methodVirtual.Text = "Virtual";
            this.methodVirtual.UseVisualStyleBackColor = true;
            // 
            // methodParameters
            // 
            this.methodParameters.Enabled = false;
            this.methodParameters.Location = new System.Drawing.Point(151, 227);
            this.methodParameters.Name = "methodParameters";
            this.methodParameters.Size = new System.Drawing.Size(153, 33);
            this.methodParameters.TabIndex = 24;
            this.methodParameters.Text = "Parameters";
            this.methodParameters.UseVisualStyleBackColor = true;
            this.methodParameters.Visible = false;
            // 
            // methodSave
            // 
            this.methodSave.Enabled = false;
            this.methodSave.Location = new System.Drawing.Point(151, 273);
            this.methodSave.Name = "methodSave";
            this.methodSave.Size = new System.Drawing.Size(153, 33);
            this.methodSave.TabIndex = 23;
            this.methodSave.Text = "Save Method";
            this.methodSave.UseVisualStyleBackColor = true;
            this.methodSave.Click += new System.EventHandler(this.methodSave_Click);
            // 
            // methodType
            // 
            this.methodType.Enabled = false;
            this.methodType.FormattingEnabled = true;
            this.methodType.Items.AddRange(new object[] {
            "void",
            "int",
            "short",
            "long long",
            "float",
            "double",
            "char"});
            this.methodType.Location = new System.Drawing.Point(151, 162);
            this.methodType.Name = "methodType";
            this.methodType.Size = new System.Drawing.Size(153, 28);
            this.methodType.TabIndex = 21;
            // 
            // methodName
            // 
            this.methodName.Enabled = false;
            this.methodName.Location = new System.Drawing.Point(151, 196);
            this.methodName.Name = "methodName";
            this.methodName.Size = new System.Drawing.Size(153, 25);
            this.methodName.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(105, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Type:";
            // 
            // methodList
            // 
            this.methodList.FormattingEnabled = true;
            this.methodList.ItemHeight = 20;
            this.methodList.Location = new System.Drawing.Point(8, 10);
            this.methodList.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.methodList.Name = "methodList";
            this.methodList.Size = new System.Drawing.Size(296, 124);
            this.methodList.TabIndex = 15;
            this.methodList.SelectedIndexChanged += new System.EventHandler(this.methodList_SelectedIndexChanged);
            // 
            // classSave
            // 
            this.classSave.Location = new System.Drawing.Point(12, 362);
            this.classSave.Name = "classSave";
            this.classSave.Size = new System.Drawing.Size(114, 33);
            this.classSave.TabIndex = 12;
            this.classSave.Text = "Save Changes";
            this.classSave.UseVisualStyleBackColor = true;
            this.classSave.Click += new System.EventHandler(this.classSave_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(194, 362);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 33);
            this.button2.TabIndex = 13;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // EditClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 405);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.classSave);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Class";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.atributeAccess.ResumeLayout(false);
            this.atributeAccess.PerformLayout();
            this.atributeVisibility.ResumeLayout(false);
            this.atributeVisibility.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.methodVisibility.ResumeLayout(false);
            this.methodVisibility.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox atributeList;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.CheckBox atributeSet;
        private System.Windows.Forms.CheckBox atributeGet;
        private System.Windows.Forms.GroupBox atributeVisibility;
        private System.Windows.Forms.RadioButton atributeProtected;
        private System.Windows.Forms.RadioButton atributePublic;
        private System.Windows.Forms.RadioButton atributePrivate;
        private System.Windows.Forms.ComboBox atributeType;
        private System.Windows.Forms.TextBox atributeValue;
        private System.Windows.Forms.TextBox atributeName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button atributeSave;
        private System.Windows.Forms.GroupBox atributeAccess;
        private System.Windows.Forms.Button methodCode;
        private System.Windows.Forms.GroupBox methodVisibility;
        private System.Windows.Forms.RadioButton methodProtected;
        private System.Windows.Forms.RadioButton methodPublic;
        private System.Windows.Forms.RadioButton methodPrivate;
        private System.Windows.Forms.CheckBox methodVirtual;
        private System.Windows.Forms.Button methodParameters;
        private System.Windows.Forms.Button methodSave;
        private System.Windows.Forms.ComboBox methodType;
        private System.Windows.Forms.TextBox methodName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox methodList;
        private System.Windows.Forms.Button classSave;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox className;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox classDocumentation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button atributeAdd;
        private System.Windows.Forms.Button atributeRemove;
        private System.Windows.Forms.Button methodRemove;
        private System.Windows.Forms.Button methodAdd;
    }
}