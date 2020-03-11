using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{


    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();
            ScaleXTextBox.Text = "1";
            ScaleYTextBox.Text = "1";
            ScaleZTextBox.Text = "1";
            OffsetXTextBox.Text = "0";
            OffsetYTextBox.Text = "0";
            OffsetZTextBox.Text = "0";
            Animation1.Text = "Idle";
            Animation2.Text = "Walk";
            Animation3.Text = "Attack";
            Animation4.Text = "Death";

            

            
            checkedListBox1.SetItemChecked(2, true); //check checkboxes by default
            checkedListBox1.SetItemChecked(3, true);
            checkedListBox1.SetItemChecked(4, true);
            checkedListBox1.SetItemChecked(5, true);
            checkedListBox1.SetItemChecked(6, true);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //3d model selection dialog
        {
      

            //3D Model selection
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;
                
            }
        }

        private void button2_Click(object sender, EventArgs e) //texture selection dialog
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                var fileName = openFileDialog2.FileName;

            }
        }








        /*



            GENERATE GENERATE GENERATE GENERATE GENERATE GENERATE GENERATE GENERATE
            GENERATE GENERATE GENERATE GENERATE GENERATE GENERATE GENERATE GENERATE

            GENERATE GENERATE GENERATE GENERATE GENERATE GENERATE GENERATE GENERATE

            GENERATE GENERATE GENERATE GENERATE GENERATE GENERATE GENERATE GENERATE

            GENERATE GENERATE GENERATE GENERATE GENERATE GENERATE GENERATE GENERATE

            GENERATE GENERATE GENERATE GENERATE GENERATE GENERATE GENERATE GENERATE


            

        */


        string modeldef_lines;
        string zscript_lines;
        string mapinfo_lines;

        int DoomEdNum = 11000;
        List<string> DoomEdNums = new List<string>();

        private void button3_Click(object sender, EventArgs e)
        {
            

            string actor = actorName.Text;
            string frames = frameNumber.Text;
            string step = frameStep.Text;
            string folderPath = Directory.GetParent(Application.ExecutablePath).ToString();
            string modelName = openFileDialog1.SafeFileName;
            string textureName = openFileDialog2.SafeFileName;

            string ScaleX = ScaleXTextBox.Text;
            string ScaleY = ScaleYTextBox.Text;
            string ScaleZ = ScaleZTextBox.Text;
            string OffsetX = OffsetXTextBox.Text;
            string OffsetY = OffsetYTextBox.Text;
            string OffsetZ = OffsetZTextBox.Text;

            string AngleOffset = AngleOffsetTextBox.Text;

            //zscript vars

            string inheritance = inheritanceTextBox.Text;
            string health = healthTextBox.Text;
            string radius = radiusTextBox.Text;
            string height = heightTextBox.Text;
            string mass = massTextBox.Text;

            //mapinfo vars

            
            
            string mapinfoLine;
            



            //mapinfo definition for doomednums

            DoomEdNum += 1;
            mapinfoLine = DoomEdNum.ToString() + " = " + $"{actor}";
            DoomEdNums.Add(mapinfoLine);
            string strDoomEdNums = String.Join<string>("\r\n    ", DoomEdNums);






            mapinfo_lines = "DoomEdNums\r\n" +
                "{\r\n" +
                "    " + strDoomEdNums + "\r\n" +
                "}\r\n\r\n\r\n";
            mapInfoTextBox.Text = mapinfo_lines;











            //////////////get checked items

            /*string checkedItems = string.Empty;
            foreach (object Item in checkedListBox1.CheckedItems)
            {
                checkedItems += Item.ToString();
            }
            MessageBox.Show(checkedItems);*/

            List<string> checkedItems = checkedListBox1.CheckedItems.OfType<string>().ToList();
            string strCheckedItems = String.Join<string>("\r\n        ", checkedItems);

            MessageBox.Show(strCheckedItems);













            //MODELDEF
            if (!checkBox2.Checked)
            {
                modeldef_lines += $"Model {actor} \r\n" + "{\r\n" +
                    "Path models \r\n" +
                    $"Model 0 {modelName} \r\n" +
                    $"Skin 0 {textureName} \r\n" +
                    $"Scale {ScaleX} {ScaleY} {ScaleZ} \r\n" +
                    $"Offset {OffsetX} {OffsetY} {OffsetZ} \r\n" +
                    $"AngleOffset {AngleOffset} \r\n" +
                    "\r\n" +
                    "FrameIndex 3DMD A 0 0 \r\n\r\n" +
                    "}\r\n\r\n\r\n";
            }

            else //(checkBox2.Checked) //if rotating is checked
            {
                modeldef_lines += $"Model {actor} \r\n" + "{\r\n" +
                "Path models \r\n" +
                $"Model 0 {modelName} \r\n" +
                $"Skin 0 {textureName} \r\n" +
                $"Scale {ScaleX} {ScaleY} {ScaleZ} \r\n" +
                $"Offset {OffsetX} {OffsetY} {OffsetZ} \r\n" +
                $"AngleOffset {AngleOffset} \r\n" +
                "ROTATING\r\n" +
                "\r\n" +
                "FrameIndex 3DMD A 0 0 \r\n\r\n" +
                "}\r\n\r\n\r\n";
            }

            zscript_lines += $"class {actor} : {inheritance} \r\n" +
                "{\r\n" +
                "    Default\r\n" +
                "    {\r\n" +
                $"        Radius {radius};\r\n" +
                $"        Height {height};\r\n" +
                $"        Health {health};\r\n" +
                "        ProjectilePassHeight -16;\r\n" +
                $"        Mass 1000;\r\n" + "        " + strCheckedItems + "\r\n" + //FLAGS here
                "        }\r\n" +
                "    States\r\n" +
                "    {\r\n" +
                "    Spawn:\r\n" +
                "        3DMD A -1;\r\n" +
                "        Stop;\r\n" +
                "    Death:\r\n" +
                "        3DMD A 1;\r\n" +
                "        Stop;\r\n" +
                "    }\r\n" +
                "}\r\n" +
                "\r\n\r\n\r\n";

            textBox4.Text = modeldef_lines;
            textBox1.Text = zscript_lines;


            // Creating the output folder

            System.IO.Directory.CreateDirectory(folderPath + @"\output" );
            System.IO.Directory.CreateDirectory(folderPath + @"\output\models");

            // Creating the files


            Directory.SetCurrentDirectory(folderPath + @"\output");








            //////////////////////////MODELDEF

            if (!File.Exists(@"\Modeldef.txt")) // If file does not exists
            {
                File.Create("Modeldef.txt").Close(); // Create file
                using (StreamWriter sw = File.AppendText("Modeldef.txt"))
                {
                    sw.WriteLine(modeldef_lines); // Write text to .txt file
                }
            }
            else // If file already exists
            {
                File.WriteAllText("Modeldef.txt", String.Empty); // Clear file
                using (StreamWriter sw = File.AppendText(@"\Modeldef.txt"))
                {
                    sw.WriteLine(modeldef_lines); // Write text to .txt file
                }
            }



            /////////////////////////ZSCRIPT

            if (!File.Exists(@"\ZScript.txt")) // If file does not exists
            {
                File.Create("ZScript.txt").Close(); // Create file
                using (StreamWriter sw = File.AppendText("ZSCript.txt"))
                {
                    sw.WriteLine(zscript_lines); // Write text to .txt file
                }
            }
            else // If file already exists
            {
                File.WriteAllText("ZScript.txt", String.Empty); // Clear file
                using (StreamWriter sw = File.AppendText(@"\ZScript.txt"))
                {
                    sw.WriteLine(zscript_lines); // Write text to .txt file
                }
            }

            /////////////////////////ZSCRIPT

            if (!File.Exists(@"\Mapinfo.txt")) // If file does not exists
            {
                File.Create("Mapinfo.txt").Close(); // Create file
                using (StreamWriter sw = File.AppendText("Mapinfo.txt"))
                {
                    sw.WriteLine(mapinfo_lines); // Write text to .txt file
                }
            }
            else // If file already exists
            {
                File.WriteAllText("Mapinfo.txt", String.Empty); // Clear file
                using (StreamWriter sw = File.AppendText(@"\Mapinfo.txt"))
                {
                    sw.WriteLine(mapinfo_lines); // Write text to .txt file
                }
            }













            Directory.SetCurrentDirectory(folderPath + @"\output\models");

            try { File.Copy(openFileDialog1.FileName, Path.Combine(Directory.GetCurrentDirectory(), openFileDialog1.SafeFileName), true); }
            catch(System.IO.FileNotFoundException) { MessageBox.Show("add a 3D model first"); }
            try { File.Copy(openFileDialog2.FileName, Path.Combine(Directory.GetCurrentDirectory(), openFileDialog2.SafeFileName), true); }
            catch (System.IO.FileNotFoundException) { MessageBox.Show("add a texture first"); }

        }

        /*
         * 
         * 
         * 
         * 
         *          END OF FILE GENERATION
         * 
         * 
         * 
         * 
         * 
         * 
         */

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            tableLayoutPanel1.Enabled = !tableLayoutPanel1.Enabled;
            tableLayoutPanel1.Visible = !tableLayoutPanel1.Visible;
            tableLayoutPanel2.Enabled = !tableLayoutPanel2.Enabled;
            tableLayoutPanel2.Visible = !tableLayoutPanel2.Visible;
        }

        private void button4_Click(object sender, EventArgs e) //Create PK3 Button
        {
            string folderPath = Directory.GetParent(Application.ExecutablePath).ToString();

            try
            {
                if (!File.Exists(folderPath + @"\output.pk3"))
                {
                    ZipFile.CreateFromDirectory(folderPath + @"\output", folderPath + @"\output.pk3");
                }
                else
                {
                    MessageBox.Show("File already exists, will be overwritten. (You can save it now before I overwrite)");
                    File.Delete(folderPath + @"\output.pk3");
                    ZipFile.CreateFromDirectory(folderPath + @"\output", folderPath + @"\output.pk3");
                }
            }
            catch(System.IO.IOException)
            {
                MessageBox.Show("IOException error. Generate first, the pk3 is probably empty."); //error message
            }
        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            string folderPath = Directory.GetParent(Application.ExecutablePath).ToString();

            Directory.SetCurrentDirectory(folderPath);
            try { Directory.Delete(folderPath + @"\output", true); }
            catch (System.IO.DirectoryNotFoundException) { }

            textBox1.Text = String.Empty;
            textBox4.Text = String.Empty;
            modeldef_lines = String.Empty;
            zscript_lines = String.Empty;
            DoomEdNum = 11001;
            DoomEdNums.Clear();

             


        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
