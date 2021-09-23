using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Codegram
{
    public partial class EditClass : Form
    {
        Class @class = null;
        List<Class> classes = null;
        List<Atribute> atributes = new List<Atribute>();
        List<Method> methods = new List<Method>();

        Atribute atribute = null;
        Method method = null;

        public EditClass(Class @class, List<Class> classes)
        {
            InitializeComponent();
            this.@class = @class;
            this.classes = classes;

            className.Text = @class.name;

            foreach (Atribute a in @class.atributes)
                atributes.Add(new Atribute(a));

            foreach (Method m in @class.methods)
                methods.Add(new Method(m));

            classDocumentation.Text = @class.documentation;

            atributeList.DataSource = null;
            atributeList.DataSource = atributes;

            methodList.DataSource = null;
            methodList.DataSource = methods;

        }

        #region Attributes
        private void atributeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (atributeList.SelectedIndex != -1)
            {
                atribute = atributes[atributeList.SelectedIndex];
                atributeVisibility.Enabled = true;
                atributePublic.Checked = (atribute.visibility == VisibilityType.Public);
                atributePrivate.Checked = (atribute.visibility == VisibilityType.Private);
                atributeProtected.Checked = (atribute.visibility == VisibilityType.Protected);

                atributeType.Enabled = true;
                atributeType.Text = atribute.type;

                atributeName.Enabled = true;
                atributeName.Text = atribute.name;

                atributeValue.Enabled = true;
                atributeValue.Text = atribute.initial_value;

                atributeAccess.Enabled = true;
                atributeGet.Checked = atribute.get;
                atributeSet.Checked = atribute.set;

                atributeSave.Enabled = true;

                atributeName.Focus();
                atributeName.SelectAll();
            }
            else
            {
                atributeVisibility.Enabled = false;
                atributePublic.Checked = atributePrivate.Checked = atributeProtected.Checked = false;

                atributeType.Enabled = false;
                atributeType.Text = "";
                atributeName.Enabled = false;
                atributeName.Text = "";
                atributeValue.Enabled = false;
                atributeValue.Text = "";


                atributeAccess.Enabled = false;
                atributeGet.Checked = atributeSet.Checked = false;

                atributeSave.Enabled = false;
            }
        }
        private void atributeAdd_Click(object sender, EventArgs e)
        {
            Atribute atribute = new Atribute();
            atribute.name = "new_attribute";
            atribute.type = "int";
            atribute.visibility = VisibilityType.Private;
            atributes.Add(atribute);

            atributeList.DataSource = null;
            atributeList.DataSource = atributes;

            atributeList.SelectedIndex = atributeList.Items.Count - 1;
            atributeRemove.Enabled = true;
        }
        private void atributeRemove_Click(object sender, EventArgs e)
        {
            if (atributeList.SelectedIndex != -1)
                atributes.RemoveAt(atributeList.SelectedIndex);

            atributeList.DataSource = null;
            atributeList.DataSource = atributes;

            atributeList.SelectedIndex = -1;

            if (atributeList.Items.Count == 0)
                atributeRemove.Enabled = false;
            else
                atributeRemove.Enabled = true;
        }
        private void atributeSave_Click(object sender, EventArgs e)
        {
            if (atributeType.Text != "")
            {
                if (atributeName.Text != "")
                {
                    if (atributePublic.Checked == true)
                        atribute.visibility = VisibilityType.Public;
                    else if (atributePrivate.Checked == true)
                        atribute.visibility = VisibilityType.Private;
                    else if (atributeProtected.Checked == true)
                        atribute.visibility = VisibilityType.Protected;

                    atribute.type = atributeType.Text;
                    atribute.name = atributeName.Text;
                    atribute.initial_value = atributeValue.Text;

                    atribute.get = atributeGet.Checked;
                    atribute.set = atributeSet.Checked;

                    atributeList.DataSource = null;
                    atributeList.DataSource = atributes;
                }
                else
                    MessageBox.Show("The attribute name is required", "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show("The attribute type is required", "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        #endregion

        #region Methods
        private void methodList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (methodList.SelectedIndex != -1)
            {
                method = methods[methodList.SelectedIndex];
                methodVisibility.Enabled = true;
                methodPublic.Checked = (method.visibility == VisibilityType.Public);
                methodPrivate.Checked = (method.visibility == VisibilityType.Private);
                methodProtected.Checked = (method.visibility == VisibilityType.Protected);

                methodType.Enabled = true;
                methodType.Text = method.type;

                methodName.Enabled = true;
                methodName.Text = method.name;

                methodVirtual.Enabled = true;
                methodVirtual.Checked = method.@virtual;

                atributeSave.Enabled = true;
                methodSave.Enabled = true;

                atributeName.Focus();
                atributeName.SelectAll();
            }
            else
            {
                methodVisibility.Enabled = false;
                methodPublic.Checked = methodPrivate.Checked = methodProtected.Checked = false;

                methodType.Enabled = false;
                methodType.Text = "";
                methodName.Enabled = false;
                methodName.Text = "";

                methodParameters.Enabled = false;

                methodVirtual.Enabled = false;
                methodVirtual.Checked = false;

                methodCode.Enabled = false;

                methodSave.Enabled = false;
            }
        }
        private void methodAdd_Click(object sender, EventArgs e)
        {
            Method method = new Method();
            method.name = "new_method";
            method.type = "void";
            method.visibility = VisibilityType.Public;

            methods.Add(method);

            methodList.DataSource = null;
            methodList.DataSource = methods;

            methodList.SelectedIndex = methodList.Items.Count - 1;
            methodRemove.Enabled = true;
        }
        private void methodRemove_Click(object sender, EventArgs e)
        {
            if (methodList.SelectedIndex != -1)
                methods.RemoveAt(methodList.SelectedIndex);

            methodList.DataSource = null;
            methodList.DataSource = methods;

            methodList.SelectedIndex = -1;

            if (methodList.Items.Count == 0)
                methodRemove.Enabled = false;
            else
                methodRemove.Enabled = true;
        }
        private void methodSave_Click(object sender, EventArgs e)
        {
            if (methodType.Text != "")
            {
                if (methodName.Text != "")
                {
                    if (methodPublic.Checked == true)
                        method.visibility = VisibilityType.Public;
                    else if (methodPrivate.Checked == true)
                        method.visibility = VisibilityType.Private;
                    else if (methodProtected.Checked == true)
                        method.visibility = VisibilityType.Protected;

                    method.type = methodType.Text;
                    method.name = methodName.Text;
                    method.@virtual = methodVirtual.Checked;

                    methodList.DataSource = null;
                    methodList.DataSource = methods;
                }
                else
                    MessageBox.Show("The method name is required", "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show("The method type is required", "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        #endregion

        private void className_TextChanged(object sender, EventArgs e)
        {
            Class result = classes.Find(x => x.name == className.Text);
            if ((result == null || result == @class) && className.Text != "")
            {
                lblMessage.Text = "Name aviable";
                lblMessage.ForeColor = Color.Green;
            }
            else
            {
                lblMessage.Text = "Name not aviable";
                lblMessage.ForeColor = Color.Red;
            }
        }
        private void classSave_Click(object sender, EventArgs e)
        {
            if (className.Text != "")
            {
                Class result = classes.Find(x => x.name == className.Text);
                if (result == null || result == @class)
                {
                    @class.name = className.Text;
                    @class.documentation = classDocumentation.Text;
                    @class.atributes = atributes;
                    @class.methods = methods;
                    this.DialogResult = DialogResult.OK;
                }
                else
                    MessageBox.Show("There is another class whit this name", "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show("The class name is required", "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }
    }
}