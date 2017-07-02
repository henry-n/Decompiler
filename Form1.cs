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
using System.Reflection.Emit;
using System.IO;

namespace decomp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDiscoverTypeInformation_Click(object sender, EventArgs e)
        {
            string TypeName = txtTypeName.Text;
            lstClass.Items.Clear();
            lstMethods.Items.Clear();
            lstArguments.Items.Clear();
            lstFields.Items.Clear();
            lstMembers.Items.Clear();

            //MessageBox.Show(TypeName);

            try
            {

                var DLL = Assembly.LoadFrom(TypeName);
                MessageBox.Show("Success");


                Type[] types = DLL.GetTypes();
                foreach (Type type in types)
                {
                    lstClass.Items.Add(type.FullName);

                    dynamic objClass = Activator.CreateInstance(type);

                    Type parameterType = objClass.GetType();

                    foreach (MemberInfo info in parameterType.GetMembers())
                    {
                        lstMembers.Items.Add(info.Name);
                    }

                    MethodInfo[] method = type.GetMethods(BindingFlags.NonPublic
                                                           | BindingFlags.Public |
                                                           BindingFlags.Static
                                                           | BindingFlags.Instance);
                    foreach (MethodInfo methods in method)
                    {
                        lstMethods.Items.Add(methods);


                        ParameterInfo[] param = methods.GetParameters();
                        foreach (ParameterInfo parameters in param)
                        {
                            lstArguments.Items.Add(methods + ": " + parameters.Name);
                        }


                        //methods.Invoke();

                    }

                    FieldInfo[] field = type.GetFields(BindingFlags.Public |
                                              BindingFlags.NonPublic |
                                              BindingFlags.Instance |
                                              BindingFlags.Static);
                    foreach (var fields in field)
                    {
                        lstFields.Items.Add(fields.Name);
                    }



                }


                foreach (var item in lstFields.SelectedItems)
                {
                    MessageBox.Show(item.ToString());
                }


            }
            catch
            {
                MessageBox.Show("Failed To Load File");
            }

        }

        private void DisplayFiles_Click(object sender, EventArgs e)
        {

            Files_In_Directory.Items.Clear();

            List<Assembly> allAssemblies = new List<Assembly>();
            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            foreach (string dll in Directory.GetFiles(path, "*.dll"))
            {

                Files_In_Directory.Items.Add(Path.GetFileName(dll));

            }

            foreach (string dll in Directory.GetFiles(path, "*.exe"))
            {
                Files_In_Directory.Items.Add(Path.GetFileName(dll));

            }


            /*
            FolderBrowserDialog FBD = new FolderBrowserDialog();

            if(FBD.ShowDialog() == DialogResult.OK)
            {
                Files_In_Directory.Items.Clear();
                string[] files = Directory.GetFiles(FBD.SelectedPath);
                string[] dirs = Directory.GetDirectories(FBD.SelectedPath);

                foreach(string file in files)
                {
                    Files_In_Directory.Items.Add((file));
                }

                foreach (string dir in dirs)
                {
                    Files_In_Directory.Items.Add((dir));
                }
                
            }*/
        }

        private void Files_In_Directory_Click(object sender, EventArgs e)
        {
            var firstSelectedItem = Files_In_Directory.SelectedItems[0];
            string result = Convert.ToString(firstSelectedItem);
            //MessageBox.Show(result);
            txtTypeName.Text = result;
        }


        private void lstMethods_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstFields_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory();
            string complete = Path.Combine(path, "SavedFile.txt");
            //MessageBox.Show(complete);

            using (StreamWriter sw = File.CreateText(complete))
            {
                string TypeName = txtTypeName.Text;

                try
                {

                    var DLL = Assembly.LoadFrom(TypeName);

                    Type[] types = DLL.GetTypes();
                    foreach (Type type in types)
                    {
                        sw.WriteLine("-----Class-----");
                        sw.WriteLine(type.FullName);

                        dynamic objClass = Activator.CreateInstance(type);

                        Type parameterType = objClass.GetType();

                        sw.WriteLine("-----Members-----");

                        foreach (MemberInfo info in parameterType.GetMembers())
                        {
                            sw.WriteLine(info.Name);
                        }
                        
                        MethodInfo[] method = type.GetMethods(BindingFlags.NonPublic
                                                               | BindingFlags.Public |
                                                               BindingFlags.Static
                                                               | BindingFlags.Instance);
                        sw.WriteLine("-----Methods-----");
                        foreach (MethodInfo methods in method)
                        {
                            sw.WriteLine(methods);

                            sw.WriteLine("-----Parameters-----");
                            ParameterInfo[] param = methods.GetParameters();
                            foreach (ParameterInfo parameters in param)
                            {
                                sw.WriteLine(methods + ": " + parameters.Name);
                            }

                        }


                        FieldInfo[] field = type.GetFields(BindingFlags.Public |
                                                  BindingFlags.NonPublic |
                                                  BindingFlags.Instance |
                                                  BindingFlags.Static);
                        sw.WriteLine("-----Fields-----");
                        foreach (var fields in field)
                        {
                            sw.WriteLine(fields.Name);
                        }
                    }

                    MessageBox.Show("File Saved.");
                }
                catch
                {
                    MessageBox.Show("Failed To Load File");
                }

            }
        }
        

        private void lstMembers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
