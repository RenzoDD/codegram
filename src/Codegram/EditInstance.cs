using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Codegram
{
    public partial class EditInstance : Form
    {
        Instance instance = null;
        List<Class> classes = null;
        public EditInstance(Instance instance, List<Class> classes)
        {
            InitializeComponent();
            this.instance = instance;
            this.classes = classes;

            cbClasses.DataSource = null;
            cbClasses.DataSource = classes;

            if (instance.cls != null)
                cbClasses.Text = instance.cls.name;
            else
                cbClasses.SelectedIndex = -1;
        }

        private void btnClass_Click(object sender, EventArgs e)
        {
            if (cbClasses.SelectedIndex == -1)
            {
                Class @class = new Class();
                @class.name = "new_class";
                EditClass frm = new EditClass(@class, classes);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    classes.Add(@class);
                    instance.cls = @class;

                    cbClasses.DataSource = null;
                    cbClasses.DataSource = classes;

                    cbClasses.Text = @class.name;
                }
            }
            else
            {
                EditClass frm = new EditClass(instance.cls, classes);
                frm.ShowDialog();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbClasses.SelectedIndex != -1)
            {
                instance.cls = classes[cbClasses.SelectedIndex];
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
