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
using System.Text.RegularExpressions;

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
        List<string> inputFArr = new List<string>(); 

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
            for (var i = 0; i < inputFArr.Count; i++ )
            {
                createDiff(inputFArr[i]);

            }
            MessageBox.Show("New difficulty created: " + version);

        }


        private void createDiff(string mapPath)
        {
            //open and copy difficulty and make modifications
            try
            {
                // Will not overwrite if the destination file already exists.
                outputF = System.IO.Path.ChangeExtension(mapPath, null) +"[" +  version + "]" + ".OSU";
                File.Copy(mapPath, outputF);
            }

            // Catch exception if the file was already copied. 
            catch (IOException copyError)
            {
                Console.WriteLine(copyError.Message);
            }
            
            //Open and change stuff on outputF

            File.WriteAllText(outputF, Regex.Replace(File.ReadAllText(outputF), "Version:.*", "Version:" + version + "\n"));
            if (hp != -1)
                File.WriteAllText(outputF, Regex.Replace(File.ReadAllText(outputF), "HPDrainRate:.*", "HPDrainRate:" + hp + " \n"));
            if (cs != -1)
                File.WriteAllText(outputF, Regex.Replace(File.ReadAllText(outputF), "CircleSize:.*", "CircleSize:" + cs + " \n"));
            if (od != -1)
                File.WriteAllText(outputF, Regex.Replace(File.ReadAllText(outputF), "OverallDifficulty:.*", "OverallDifficulty:" + od + " \n"));
            if (ar != -1)
                File.WriteAllText(outputF, Regex.Replace(File.ReadAllText(outputF), "ApproachRate:.*", "ApproachRate:" + ar + "\n"));
        }
        /*
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
         */
        private void browse_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "osu files (*.osu)|*.osu";
            openFileDialog1.Multiselect = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string tempFolder = System.IO.Path.GetTempPath();
                foreach (string fileName in openFileDialog1.FileNames)
                {
                    inputFArr.Add(fileName);
                    //filePath.Text = filePath.Text + "\n" + fileName;
                    mapList.Items.Add(filePath.Text + "\n" + Path.GetFileNameWithoutExtension(fileName));
                    
                }
                //inputF = openFileDialog1.FileName;
                //filePath.Text = inputF;
            }

        }



    }
}
