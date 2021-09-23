using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Codegram
{
    public enum State { None, WaitForSetInstance, MoveInstance, Relationship1, Relationship2 }
    public partial class Main : Form
    {
        Relationship relationship = null;
        int end_selected = 0;
        int _x, _y;
        string path = "";

        Object newInstance = null;
        Object clipBoard = null;
        int offSetX, offSetY;

        Diagram diagram = null;
        State state = State.None;

        public Main()
        {
            InitializeComponent();
            diagram = new Diagram();
        }
        public Main(string path)
        {
            InitializeComponent();
            if (File.Exists(path))
            {
                this.path = path;
                diagram = ByteArrayToObject(File.ReadAllBytes(path));
            }
            else
                diagram = new Diagram();

        }

        #region ToolBox        
        private void btnArrow_Click(object sender, EventArgs e)
        {
            state = State.None;
            newInstance = null;
            end_selected = 0;
            relationship = null;
            clipBoard = null;
        }
        private void btnAddInstance_Click(object sender, EventArgs e)
        {
            Instance instance = new Instance();
            EditInstance frm = new EditInstance(instance, diagram.classes);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                newInstance = instance;

                workSpace.Cursor = Cursors.Cross;
                state = State.WaitForSetInstance;
            }
        }
        private void btnAddText_Click(object sender, EventArgs e)
        {
            Codegram.Text text = new Text("This is\r\na text");
            newInstance = text;

            workSpace.Cursor = Cursors.Cross;
            state = State.WaitForSetInstance;
        }
        private void btnAssociation_Click(object sender, EventArgs e)
        {
            newInstance = new Relationship(RelationshipType.Association);
            state = State.Relationship1;
        }
        private void btnDependency_Click(object sender, EventArgs e)
        {
            newInstance = new Relationship(RelationshipType.Dependency);
            state = State.Relationship1;
        }
        private void btnAggregation_Click(object sender, EventArgs e)
        {
            newInstance = new Relationship(RelationshipType.Aggregation);
            state = State.Relationship1;
        }
        private void btnComposition_Click(object sender, EventArgs e)
        {
            newInstance = new Relationship(RelationshipType.Composition);
            state = State.Relationship1;
        }
        private void btnInheritance_Click(object sender, EventArgs e)
        {
            newInstance = new Relationship(RelationshipType.Inheritance);
            state = State.Relationship1;
        }
        #endregion

        #region workSpace
        private void workSpace_MouseDown(object sender, MouseEventArgs e)
        {
            if (state == State.None)
            {
                diagram.selection = diagram.Selection(e.X, e.Y);
                if (diagram.selection != null)
                {
                    offSetX = e.X - diagram.selection.x;
                    offSetY = e.Y - diagram.selection.y;

                    state = State.MoveInstance;
                }


                if (diagram.selection is Instance)
                    txtDocumantation.Text = (diagram.selection as Instance).cls.documentation;
                else if (diagram.selection is Codegram.Text)
                    txtDocumantation.Text = (diagram.selection as Codegram.Text).text;
                else
                    txtDocumantation.Text = "";
            }
            else if (state == State.WaitForSetInstance)
            {
                newInstance.x = e.X;
                newInstance.y = e.Y;
                diagram.objects.Add(newInstance);
                state = State.None;
                workSpace.Cursor = Cursors.Arrow;
            }
            else if (state == State.Relationship1)
            {
                diagram.selection = diagram.Selection(e.X, e.Y);
                if (diagram.selection is Instance)
                {
                    Relationship relationship = newInstance as Relationship;
                    relationship.class1 = diagram.selection as Instance;
                    state = State.Relationship2;
                }
            }
            else if (state == State.Relationship2)
            {

                diagram.selection = diagram.Selection(e.X, e.Y);
                if (diagram.selection is Instance)
                {
                    if (diagram.selection != (newInstance as Relationship).class1)
                    {
                        Relationship relationship = newInstance as Relationship;
                        relationship.class2 = diagram.selection as Instance;
                        state = State.None;

                        diagram.objects.Add(relationship);
                    }
                }
            }
        }
        private void workSpace_MouseMove(object sender, MouseEventArgs e)
        {
            _x = e.X;
            _y = e.Y;
            var cursor = Cursors.Arrow;
            if (state == State.None)
            {
                if (diagram.Selection(e.X, e.Y) != null)
                    cursor = Cursors.Hand;
            }
            else if (state == State.WaitForSetInstance)
            {
                cursor = Cursors.Cross;
            }
            else if (state == State.MoveInstance)
            {
                if (e.X - offSetX >= 0 )
                    diagram.selection.x = e.X - offSetX;

                if (e.Y - offSetY >= 0 )
                    diagram.selection.y = e.Y - offSetY;

                cursor = Cursors.SizeAll;
            }
            else if (state == State.Relationship1)
            {
                cursor = Cursors.Hand;
            }
            else if (state == State.Relationship2)
            {
                cursor = Cursors.Hand;
            }

            workSpace.Cursor = cursor;
        }
        private void workSpace_MouseUp(object sender, MouseEventArgs e)
        {
            if (state != State.Relationship1 && state != State.Relationship2)
            {
                state = State.None;
                workSpace.Cursor = Cursors.Arrow;
            }
        }
        #endregion

        #region rightClickMenu
        private void rightClickMenu_Opening(object sender, CancelEventArgs e)
        {
            btnCopy.Enabled = btnCut.Enabled = diagram.selection != null;
            btnPaste.Enabled = clipBoard != null;

            btnProperties.Enabled = diagram.selection != null;
            btnGetToFront.Enabled = diagram.selection != null;
            btnRemove.Enabled = diagram.selection != null;


            relationship = diagram.GetRelationshipSelected(_x, _y, out end_selected);
            btnMultiplicity.Enabled = relationship != null;
            if (btnMultiplicity.Enabled == true)
            {
                MultiplicityType rt = ( (end_selected == 1)? relationship.class1Multiplicity : relationship.class2Multiplicity );
                btnNone.Checked = rt == MultiplicityType.None;
                btnNoInstance.Checked = rt == MultiplicityType.NoInstance;
                btnNoInstanceOrOneInstance.Checked = rt == MultiplicityType.NoInstanceOrOneInstance;
                btnExactlyOneInstance.Checked = rt == MultiplicityType.ExactlyOneInstance;
                btnZeroOrMoreInstance.Checked = rt == MultiplicityType.ZeroOrMoreInstance;
                btnOneOrMoreInstance.Checked = rt == MultiplicityType.OneOrMoreInstance;
            }
        }
        private void btnProperties_Click(object sender, EventArgs e)
        {
            if (diagram.selection is Instance)
            {
                EditInstance frm = new EditInstance((Instance)diagram.selection, diagram.classes);
                frm.ShowDialog();
            } 
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            List<Object> objects = diagram.objects.FindAll(x => (x is Relationship));
            foreach(Object o in objects)
            {
                Relationship R = o as Relationship;
                if (R.class1 == diagram.selection || R.class2 == diagram.selection)
                    diagram.objects.Remove(o);
            }

            diagram.objects.Remove(diagram.selection);
            diagram.selection = null;
        }
        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (diagram.selection is Instance)
                clipBoard = new Instance((diagram.selection as Instance).cls);
            else if (diagram.selection is Codegram.Text)
                clipBoard = new Codegram.Text((diagram.selection as Codegram.Text).text);
            if (diagram.selection is Codegram.Relationship == false)
            {
                clipBoard.x = diagram.selection.x + 10;
                clipBoard.y = diagram.selection.y + 10;
            }
        }
        private void btnPaste_Click(object sender, EventArgs e)
        {
            clipBoard.x = _x;
            clipBoard.y = _y;
            diagram.objects.Add(clipBoard);

            if (clipBoard is Instance)
                clipBoard = new Instance((clipBoard as Instance).cls);
            else if (clipBoard is Codegram.Text)
                clipBoard = new Codegram.Text((clipBoard as Codegram.Text).text);
        }
        private void btnCut_Click(object sender, EventArgs e)
        {
            clipBoard = diagram.selection;
            clipBoard.x = 0;
            clipBoard.y = 0;

            List<Object> objects = diagram.objects.FindAll(x => (x is Relationship));
            foreach (Object o in objects)
            {
                Relationship R = o as Relationship;
                if (R.class1 == diagram.selection || R.class2 == diagram.selection)
                    diagram.objects.Remove(o);
            }

            diagram.objects.Remove(diagram.selection);
            diagram.selection = null;
        }
        private void btnCopyImage_Click(object sender, EventArgs e)
        {
            int x_min = int.MaxValue, y_min = int.MaxValue;
            int x_max = int.MinValue, y_max = int.MinValue;

            foreach (Object I in diagram.objects.FindAll(x => !(x is Relationship)))
            {
                if (I.x < x_min)
                    x_min = I.x;
                if (I.x + I.width > x_max)
                    x_max = I.x + I.width;

                if (I.y < y_min)
                    y_min = I.y;
                if (I.y + I.height > y_max)
                    y_max = I.y + I.height;
            }
            x_min--; y_min--;
            x_max++; y_max++;
            x_max += 64;
            y_max += 75;

            Bitmap bitmap = new Bitmap(x_max - x_min, y_max - y_min);
            Graphics g = Graphics.FromImage(bitmap);
            g.Clear(diagram.workspace_color);
            diagram.Draw(g, x_min, y_min);
            Clipboard.SetImage(bitmap);
        }

        private void btnNone_Click(object sender, EventArgs e)
        {
            if (end_selected == 1)
                relationship.class1Multiplicity = MultiplicityType.None;
            else if (end_selected == 2)
                relationship.class2Multiplicity = MultiplicityType.None;
        }
        private void btnNoInstance_Click(object sender, EventArgs e)
        {
            if (end_selected == 1)
                relationship.class1Multiplicity = MultiplicityType.NoInstance;
            else if (end_selected == 2)
                relationship.class2Multiplicity = MultiplicityType.NoInstance;
        }
        private void btnNoInstanceOrOneInstance_Click(object sender, EventArgs e)
        {
            if (end_selected == 1)
                relationship.class1Multiplicity = MultiplicityType.NoInstanceOrOneInstance;
            else if (end_selected == 2)
                relationship.class2Multiplicity = MultiplicityType.NoInstanceOrOneInstance;
        }
        private void btnExactlyOneInstance_Click(object sender, EventArgs e)
        {
            if (end_selected == 1)
                relationship.class1Multiplicity = MultiplicityType.ExactlyOneInstance;
            else if (end_selected == 2)
                relationship.class2Multiplicity = MultiplicityType.ExactlyOneInstance;
        }
        private void btnZeroOrMoreInstance_Click(object sender, EventArgs e)
        {
            if (end_selected == 1)
                relationship.class1Multiplicity = MultiplicityType.ZeroOrMoreInstance;
            else if (end_selected == 2)
                relationship.class2Multiplicity = MultiplicityType.ZeroOrMoreInstance;
        }
        private void btnOneOrMoreInstance_Click(object sender, EventArgs e)
        {
            if (end_selected == 1)
                relationship.class1Multiplicity = MultiplicityType.OneOrMoreInstance;
            else if (end_selected == 2)
                relationship.class2Multiplicity = MultiplicityType.OneOrMoreInstance;
        }
        
        private void btnGetToFront_Click(object sender, EventArgs e)
        {
            Object @object = diagram.selection;
            diagram.objects.Remove(diagram.selection);
            diagram.objects.Add(diagram.selection);
        }
        #endregion

        #region TopMenu
        private void btnEdit_DropDownOpened(object sender, EventArgs e)
        {
            btnCopy1.Enabled = btnCut1.Enabled = diagram.selection != null;
            btnPaste1.Enabled = clipBoard != null;

            btnProperties1.Enabled = diagram.selection != null;
            btnGetToFront1.Enabled = diagram.selection != null;
            btnRemove1.Enabled = diagram.selection != null;
        }
    private void btnNew_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Would you like to save the actual diagram?", "Save current diagram", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
                Save();

            diagram = new Diagram();
        }
        private void btnOpen_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Would you like to save the actual diagram?", "Save current diagram", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
                Save();
            Open();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }
        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            SaveAs();
        }
        private void btnExport_Click(object sender, EventArgs e)
        {
            int x_min = int.MaxValue, y_min = int.MaxValue;
            int x_max = int.MinValue, y_max = int.MinValue;

            foreach (Object I in diagram.objects.FindAll(x => !(x is Relationship)))
            {
                if (I.x < x_min)
                    x_min = I.x;
                if (I.x + I.width > x_max)
                    x_max = I.x + I.width;

                if (I.y < y_min)
                    y_min = I.y;
                if (I.y + I.height > y_max)
                    y_max = I.y + I.height;
            }
            x_min--; y_min--;
            x_max++; y_max++;
            x_max += 64;
            y_max += 75;
            Bitmap bitmap = new Bitmap(x_max - x_min, y_max - y_min);
            Graphics g = Graphics.FromImage(bitmap);

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.FileName = "Codegram Image";

            if (diagram.workspace_color != Color.White)
                g.Clear(diagram.workspace_color);

            if (((ToolStripMenuItem)sender).Name == "btnExportPNG")
            {
                dialog.Filter = "PNG File|*.png";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    diagram.Draw(g, x_min, y_min);
                    bitmap.Save(dialog.FileName, ImageFormat.Png);
                }
            }
            else if (((ToolStripMenuItem)sender).Name == "btnExportJPG")
            {
                dialog.Filter = "JPG File|*.jpg";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    g.Clear(diagram.workspace_color); 
                    diagram.Draw(g, x_min, y_min);
                    bitmap.Save(dialog.FileName, ImageFormat.Jpeg);
                }
            }
            else if (((ToolStripMenuItem)sender).Name == "btnExportBMP")
            {
                dialog.Filter = "BMP File|*.bmp";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    g.Clear(diagram.workspace_color);
                    diagram.Draw(g, x_min, y_min);
                    bitmap.Save(dialog.FileName, ImageFormat.Bmp);
                }
            }
            else if (((ToolStripMenuItem)sender).Name == "btnExportGIF")
            {
                dialog.Filter = "GIF File|*.gif";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    g.Clear(diagram.workspace_color);
                    diagram.Draw(g, x_min, y_min);
                    bitmap.Save(dialog.FileName, ImageFormat.Gif);
                }
            }
            else if (((ToolStripMenuItem)sender).Name == "btnExportTIFF")
            {
                dialog.Filter = "TIFF File|*.tiff";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    diagram.Draw(g, x_min, y_min);

                    bitmap.Save(dialog.FileName, ImageFormat.Tiff);
                }
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnWorkSpaceColor_Click(object sender, EventArgs e)
        {
            colorPicker.Color = diagram.workspace_color;
            if (colorPicker.ShowDialog() == DialogResult.OK)
                diagram.workspace_color = colorPicker.Color;
        }
        private void btnBackColor_Click(object sender, EventArgs e)
        {
            colorPicker.Color = diagram.back_color;

            if (colorPicker.ShowDialog() == DialogResult.OK)
                diagram.back_color = colorPicker.Color;
        }
        private void btnForeColor_Click(object sender, EventArgs e)
        {
            colorPicker.Color = diagram.font_color;

            if (colorPicker.ShowDialog() == DialogResult.OK)
                diagram.font_color = colorPicker.Color;
        }
        private void btnHelp_Click(object sender, EventArgs e)
        {
            (new Help()).ShowDialog();
        }
        #endregion

        #region Files
        private byte[] ObjectToByteArray(Diagram obj)
        {
            if (obj == null)
                return null;

            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();
            bf.Serialize(ms, obj);

            return ms.ToArray();
        }
        private Diagram ByteArrayToObject(byte[] arrBytes)
        {
            MemoryStream memStream = new MemoryStream();
            BinaryFormatter binForm = new BinaryFormatter();
            memStream.Write(arrBytes, 0, arrBytes.Length);
            memStream.Seek(0, SeekOrigin.Begin);
            Diagram obj = (Diagram)binForm.Deserialize(memStream);

            return obj;
        }
        void SaveAs()
        {
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                path = saveDialog.FileName;
                Save();
            }
        }
        void Save()
        {
            if (path != "")
            {
                byte[] bytes = ObjectToByteArray(diagram);
                File.WriteAllBytes(path, bytes);
            }
            else
                SaveAs();
        }
        void Open()
        {
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(openDialog.FileName))
                {
                    diagram = ByteArrayToObject(File.ReadAllBytes(openDialog.FileName));
                }
            }
        }
        #endregion



        private void workSpace_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void workSpace_DragDrop(object sender, DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (string path in s)
            {
                FileInfo file = new FileInfo(path);
                if (file.Extension == ".cdg")
                {
                    var res = MessageBox.Show("Would you like to save the actual diagram?", "Before open this diagram", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                    if (res == DialogResult.Yes)
                    { 
                        Save();
                        this.path = path;
                        diagram = ByteArrayToObject(File.ReadAllBytes(path));
                    }
                    else if (res == DialogResult.No)
                    {
                        this.path = path;
                        diagram = ByteArrayToObject(File.ReadAllBytes(path));
                    }
                    break;
                }
            }
        }

        private void workSpace_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Size x = panel1.Size;
            Size a = new Size(Math.Max(x.Width, diagram.Width()), Math.Max(x.Height, diagram.Height()));

            workSpace.Size = a;

            Graphics g = workSpace.CreateGraphics();
            BufferedGraphicsContext bfc = BufferedGraphicsManager.Current;
            BufferedGraphics bf = bfc.Allocate(g, workSpace.ClientRectangle);

            bf.Graphics.Clear(diagram.workspace_color);
            try { diagram.Draw(bf.Graphics, 0, 0); }
            catch { }

            bf.Render(g);
        }

        private void txtDocumantation_TextChanged(object sender, EventArgs e)
        {
            if (diagram.selection is Instance)
                (diagram.selection as Instance).cls.documentation = txtDocumantation.Text;
            else if (diagram.selection is Codegram.Text)
                (diagram.selection as Codegram.Text).text = txtDocumantation.Text;
        }
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            var res = MessageBox.Show("Would you like to save the actual diagram?", "Before close the program", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
                Save();
            else if (res == DialogResult.Cancel)
                e.Cancel = true;
        }
        
    }
}