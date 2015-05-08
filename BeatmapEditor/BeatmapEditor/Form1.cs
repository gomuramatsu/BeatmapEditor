using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BeatmapEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int cs = -1;
        int ar = -1;
        int od = -1;
        int hp = -1;
        string version = "";
        string inputF = "";
        string outputF = "";

        //version Input
        private void versionInput_TextChanged(object sender, EventArgs e)
        {
            version = versionInput.Text;
        }

        //CS
        private void csInput_TextChanged(object sender, EventArgs e)
        {
            int csInt;
            bool isNumerical = int.TryParse(csInput.Text, out csInt);
            if (isNumerical){
                cs = csInt;
            }
        }
        
        //AR
        private void arInput_TextChanged(object sender, EventArgs e)
        {
            int arInt;
            bool isNumerical = int.TryParse(arInput.Text, out arInt);
            if (isNumerical)
            {
                ar = arInt;
            }
        }

        //OD
        private void odInput_TextChanged(object sender, EventArgs e)
        {
            int odInt;
            bool isNumerical = int.TryParse(odInput.Text, out odInt);
            if (isNumerical)
            {
                od = odInt;
            }
        }

        //HP
        private void hpInput_TextChanged(object sender, EventArgs e)
        {
            int hpInt;
            bool isNumerical = int.TryParse(hpInput.Text, out hpInt);
            if (isNumerical)
            {
                hp = hpInt;
            }
        }

        //Create Beatmap
        private void start_Click(object sender, EventArgs e)
        {
            createDiff();
            MessageBox.Show("New difficulty created: " + version + "\nCS: " + cs.ToString() + " AR: " + ar.ToString() + " OD: " + od.ToString() + " HP: " + hp.ToString());

        }


        private void createDiff()
        {
            //open and copy difficulty and make modifications
            try
            {
                // Will not overwrite if the destination file already exists.
                outputF = System.IO.Path.ChangeExtension(inputF, null) +"[" +  version + "]" + ".OSU";
                File.Copy(inputF, outputF);
            }

            // Catch exception if the file was already copied. 
            catch (IOException copyError)
            {
                Console.WriteLine(copyError.Message);
            }

            //Open and change stuff on outputF
        }

        private void browse_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "osu files (*.osu)|*.osu";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                inputF = openFileDialog1.FileName;
                filePath.Text = inputF;
            }

        }

    }
}
