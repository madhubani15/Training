using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace WinReflectionDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); // instance
            listBox2.Items.Clear();
        }

        private void btnLoadAssembly_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string FileName = openFileDialog1.FileName;
            // stores the path of the file in FileName

            Assembly assemblyObj = Assembly.LoadFrom(FileName);
            // loads a .NET assembly (DLL or EXE) into your application at
            // runtime from the path specified by FileName

            Type[] myType = assemblyObj.GetTypes();
            // types of assembly

            this.ReflectAll(myType[0]);
        }


        // static   : Maintains one copy per class, shared by all objects
        // instance : Maintains one copy per object, aka multiple copies for multiple objects

        public void ReflectAll(Type typeObj) // reflection
        {
            // Getting all methods
            MethodInfo[] methodList = typeObj.GetMethods();

            // getting all properties
            PropertyInfo[] propertyList = typeObj.GetProperties();

            // event info
            //EventInfo[] eventList = type
            //FieldInfo
            //DelegateInfo
            //ConstructorInfo


            // Load All Properties
            foreach (var item in propertyList)
            {
                listBox1.Items.Add(item);
            }

            // Load All Methods
            foreach (var item in methodList)
            {
                listBox2.Items.Add(item);
            }

        }

    }
}
