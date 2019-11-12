using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management.Automation;
using System.Collections.ObjectModel;
using System.Management.Automation.Runspaces;
using System.IO;

namespace QuitarModoLectura
{
    public partial class Form1 : Form
    {

        public List<Archivo> archivos { get; set; }
        public string Ruta { get; set; }

        public Form1()
        {
            InitializeComponent();
            archivos = new List<Archivo>();
            //Ruta = @"C:\Program Files (x86)\GroupM\Adplanning";
            //txtRuta.Text= @"C:\Program Files (x86)\GroupM\Adplanning"; 
        }

        private void btEjecutar_Click(object sender, EventArgs e)
        {
            try
            {
                archivos = new List<Archivo>();
                treeView.Nodes.Clear();
                if (string.IsNullOrEmpty(Ruta))
                {
                    Ruta = System.IO.Directory.GetCurrentDirectory();
                    //Ruta = @"C:\Program Files (x86)\GroupM\Adplanning";
                }
                using (Runspace runspace = RunspaceFactory.CreateRunspace())
                {
                    System.Environment.CurrentDirectory = Ruta;
                    runspace.Open();
                    using (Pipeline pipeline = runspace.CreatePipeline())
                    {
                        pipeline.Commands.Add(@"dir");
                        Collection<PSObject> PSOutput = pipeline.Invoke();

                        foreach (PSObject outputItem in PSOutput)
                        {
                            if (outputItem != null)
                            {
                                if (((System.IO.FileSystemInfo)outputItem.BaseObject).Attributes != System.IO.FileAttributes.Directory)
                                {
                                    if (chkSoloLectura.Checked)
                                    {
                                        if (((System.IO.FileInfo)outputItem.BaseObject).IsReadOnly)
                                        {
                                            Archivo a = new Archivo();
                                            a.Ruta = ((System.IO.FileInfo)outputItem.BaseObject).DirectoryName;
                                            a.SoloLectura = ((System.IO.FileInfo)outputItem.BaseObject).IsReadOnly;
                                            a.nombreFichero = ((System.IO.FileInfo)outputItem.BaseObject).Name;
                                            archivos.Add(a);
                                        }
                                    }
                                    else
                                    {
                                        Archivo a = new Archivo();
                                        a.Ruta = ((System.IO.FileInfo)outputItem.BaseObject).DirectoryName;
                                        a.SoloLectura = ((System.IO.FileInfo)outputItem.BaseObject).IsReadOnly;
                                        a.nombreFichero = ((System.IO.FileInfo)outputItem.BaseObject).Name;
                                        archivos.Add(a);
                                    }
                                }
                            }
                        }
                    }
                    runspace.Close();
                }
                if (archivos.Count() > 0)
                {
                    foreach (Archivo item in archivos)
                    {
                        treeView.Nodes.Add(item.ToString());
                    }
                }
                else
                {
                    treeView.Nodes.Add("No hay archivos");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btConvertir_Click(object sender, EventArgs e)
        {

            try
            {
                foreach (Archivo item in archivos.Where(x => x.SoloLectura))
                {
                    FileInfo f = new FileInfo(item.getRutCompleta());
                    f.Attributes = FileAttributes.Normal;
                }

                MessageBox.Show("Proceso Finalizado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btRuta_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtRuta.Text = folderBrowserDialog1.SelectedPath;
                Ruta = folderBrowserDialog1.SelectedPath;
            }
        }

        private void txtRuta_TextChanged(object sender, EventArgs e)
        {
            Ruta = string.IsNullOrEmpty(txtRuta.Text) ? string.Empty : txtRuta.Text;
        }
    }

    public class Archivo
    {
        public bool SoloLectura { get; set; }
        public string nombreFichero { get; set; }
        public string Ruta { get; set; }

        public string getRutCompleta()
        {
            return Ruta + "\\" + nombreFichero;
        }

        public override string ToString()
        {
            return nombreFichero + "(" + SoloLectura.ToString() + ")";
        }
    }
}
