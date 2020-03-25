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
        string textures_lines;
        string materials_lines;
        string gldefs_lines = "#include Materials.gl";

        int textureMode = 0; //0-diffuse 1-normal+specular 2-PBR

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
            




            //gldefs




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

            /////////////////////////MAPINFO

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

        private void clearButton_Click(object sender, EventArgs e) //CLEAR BUTTON
        {
            string folderPath = Directory.GetParent(Application.ExecutablePath).ToString();

            Directory.SetCurrentDirectory(folderPath);
            try { Directory.Delete(folderPath + @"\output", true); }
            catch (System.IO.DirectoryNotFoundException) { }

            textBox1.Text = String.Empty;
            textBox4.Text = String.Empty;
            modeldef_lines = String.Empty;
            zscript_lines = String.Empty;
            gldefs_lines = String.Empty;
            materials_lines = String.Empty;
            textures_lines = String.Empty;

            DoomEdNum = 11001;
            DoomEdNums.Clear();

             


        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            NormalSpecularTable.Enabled = !NormalSpecularTable.Enabled;
            textureMode = 1; //0-default 1-normal+specular 2-PBR
        }
        //////////////////////texture definitions////////////////////////////
        private void button5_Click(object sender, EventArgs e) //Diffuse only
        {
            if (diffuseDialog.ShowDialog() == DialogResult.OK)
            {
                var fileName = diffuseDialog.FileName;

            }
        }

        private void button6_Click(object sender, EventArgs e) //diffuse(normal+specular)
        {
            if (diffuseDialog.ShowDialog() == DialogResult.OK)
            {
                var fileName = diffuseDialog.FileName;

            }
        }

        private void button9_Click(object sender, EventArgs e) //diffuse(PBR)
        {
            if (diffuseDialog.ShowDialog() == DialogResult.OK)
            {
                var fileName = diffuseDialog.FileName;

            }
        }

        private void button7_Click(object sender, EventArgs e) //normal(normal+specular)
        {
            if (normalDialog.ShowDialog() == DialogResult.OK)
            {
                var fileName = normalDialog.FileName;

            }
        }

        private void button10_Click(object sender, EventArgs e) //normal(PBR)
        {
            if (normalDialog.ShowDialog() == DialogResult.OK)
            {
                var fileName = normalDialog.FileName;

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (specularDialog.ShowDialog() == DialogResult.OK) //specular
            {
                var fileName = specularDialog.FileName;

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (metallicDialog.ShowDialog() == DialogResult.OK) //metallic
            {
                var fileName = metallicDialog.FileName;

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (roughnessDialog.ShowDialog() == DialogResult.OK) //roughness
            {
                var fileName = roughnessDialog.FileName;

            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (aoDialog.ShowDialog() == DialogResult.OK) //AO Ambient Occlusion AO
            {
                var fileName = aoDialog.FileName;

            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) //default-mode
        {
            DiffuseTable.Enabled = !DiffuseTable.Enabled;
            textureMode = 0; //0-default 1-normal+specular 2-PBR
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e) //pbr-mode
        {
            PBR_Table.Enabled = !PBR_Table.Enabled;
            textureMode = 2; //0-default 1-normal+specular 2-PBR
        }


        /*
         * /////////////////////////////////////////////////////////////////////
         * #####################################################################
         * /////////////////////////////////////////////////////////////////////
         * 
         * 
         *  TEXTURE GENERATE TEXTURE GENERATE TEXTURE GENERATE TEXTURE GENERATE
         * 
         * 
         * /////////////////////////////////////////////////////////////////////
         * #####################################################################
         * /////////////////////////////////////////////////////////////////////
         * 
         * */

        string texSizeY = "0";
        string texSizeX = "0";


        private void button14_Click(object sender, EventArgs e) //generate button at textures
        {

            ///
            ///defining stuff
            ///
            string folderPath = Directory.GetParent(Application.ExecutablePath).ToString();


            string textureName = textureNameTextBox.Text;

            string diffuseName = patchNameTextBox.Text;  //diffuseDialog.SafeFileName;
            string normalName = normalDialog.SafeFileName;
            string specularName = specularDialog.SafeFileName; //a textúra módot csináld majd meg, nem nézi semmi a pipákat
            string metallicName = metallicDialog.SafeFileName; //a méretmutatót csináld meg, alapméret megadót.
            string roughnessName = roughnessDialog.SafeFileName;
            string aoName = aoDialog.SafeFileName;

            string ScaleX = TexScaleXTextBox.Text;
            string ScaleY = TexScaleYTextBox.Text;

            string SizeX = texSizeX;
            string SizeY = texSizeY;

            string specularLevel = "2.0";
            string glossiness = "2.0";
            ///


            //textures file, textures_lines

            textures_lines += "\r\n" +
                "\r\n" +
                $"Texture \"{textureName}\", {SizeX}, {SizeY} \r\n" +
                "{\r\n" +
                $"    XScale {ScaleX}\r\n" +
                $"    YScale {ScaleY}\r\n" +
                $"    Patch \"{diffuseName}\", 0, 0\r\n" +
                "}\r\n";

            if (textureMode == 1) //in case of Normal+Specular setup, write in materials.gl
            {
                materials_lines += "\r\n\r\n" +
                    $"material texture {textureName}\r\n" +
                    "{\r\n" +
                    $"    normal materials/{normalName}\r\n" +
                    $"    specular materials/{specularName}\r\n" +
                    $"    specularlevel {specularLevel}\r\n" +
                    $"    glossiness {glossiness}\r\n" +
                    "}\r\n";
                    
                    
            }

            else if (textureMode == 2) //in case of PBR setup, write in materials.gl
            {
                materials_lines += "\r\n\r\n" +
                    $"material texture {textureName}\r\n" +
                    "{\r\n" +
                    $"    normal materials/{normalName}\r\n" +
                    $"    roughness materials/{roughnessName}\r\n" +
                    $"    metallic materials/{metallicName}\r\n" +
                    $"    ao materials/{aoName}\r\n" +
                    $"    specularlevel {specularLevel}\r\n" +
                    $"    glossiness {glossiness}\r\n" +
                    "}\r\n";


            }













            //Creating the output folder

            System.IO.Directory.CreateDirectory(folderPath + @"\output");
            System.IO.Directory.CreateDirectory(folderPath + @"\output\patches");
            System.IO.Directory.CreateDirectory(folderPath + @"\output\materials");















            Directory.SetCurrentDirectory(folderPath + @"\output");

            /////////////////////////GLDEFS

            if (!File.Exists(@"\GLDefs.txt")) // If file does not exists
            {
                File.Create("GLDefs.txt").Close(); // Create file
                using (StreamWriter sw = File.AppendText("GLDefs.txt"))
                {
                    sw.WriteLine(gldefs_lines); // Write text to .txt file
                }
            }
            else // If file already exists
            {
                File.WriteAllText("GLDefs.txt", String.Empty); // Clear file
                using (StreamWriter sw = File.AppendText(@"\GLDefs.txt"))
                {
                    sw.WriteLine(gldefs_lines); // Write text to .txt file
                }
            }

            /////////////////////////MATERIALS

            if (!File.Exists(@"\Materials.gl")) // If file does not exists
            {
                File.Create("Materials.gl").Close(); // Create file
                using (StreamWriter sw = File.AppendText("Materials.gl"))
                {
                    sw.WriteLine(materials_lines); // Write text to .txt file
                }
            }
            else // If file already exists
            {
                File.WriteAllText("Materials.gl", String.Empty); // Clear file
                using (StreamWriter sw = File.AppendText(@"\Materials.gl"))
                {
                    sw.WriteLine(materials_lines); // Write text to .txt file
                }
            }

            /////////////////////////TEXTURES

            if (!File.Exists(@"\Textures.txt")) // If file does not exists
            {
                File.Create("Textures.txt").Close(); // Create file
                using (StreamWriter sw = File.AppendText("Textures.txt"))
                {
                    sw.WriteLine(textures_lines); // Write text to .txt file
                }
            }
            else // If file already exists
            {
                File.WriteAllText("Textures.txt", String.Empty); // Clear file
                using (StreamWriter sw = File.AppendText(@"\Textures.txt"))
                {
                    sw.WriteLine(textures_lines); // Write text to .txt file
                }
            }










            /*

                                             COPYING TEXTURE FILES

    */      Directory.SetCurrentDirectory(folderPath + @"\output\patches");
            
            //if mode=0 default

            if (textureMode == 0)
            {
                Directory.SetCurrentDirectory(folderPath + @"\output\patches");

                try { File.Copy(diffuseDialog.FileName, Path.Combine(Directory.GetCurrentDirectory(), diffuseName), true); }
                catch (System.IO.FileNotFoundException) { MessageBox.Show("add a diffuse texture first"); }

            }

            //if mode=1 normal+specular

            if (textureMode == 1)
            {
                Directory.SetCurrentDirectory(folderPath + @"\output\patches");
                try { File.Copy(diffuseDialog.FileName, Path.Combine(Directory.GetCurrentDirectory(), diffuseName), true); }
                catch (System.IO.FileNotFoundException) { MessageBox.Show("add a diffuse texture first"); }
                Directory.SetCurrentDirectory(folderPath + @"\output\materials");
                try { File.Copy(normalDialog.FileName, Path.Combine(Directory.GetCurrentDirectory(), normalDialog.SafeFileName), true); }
                catch (System.IO.FileNotFoundException) { MessageBox.Show("add a normal map first"); }
                try { File.Copy(specularDialog.FileName, Path.Combine(Directory.GetCurrentDirectory(), specularDialog.SafeFileName), true); }
                catch (System.IO.FileNotFoundException) { MessageBox.Show("add a specular map first"); }
            }

            //if mode=2 PBR

            if (textureMode == 2)
            {
                Directory.SetCurrentDirectory(folderPath + @"\output\patches");
                try { File.Copy(diffuseDialog.FileName, Path.Combine(Directory.GetCurrentDirectory(), diffuseName), true); }
                catch (System.IO.FileNotFoundException) { MessageBox.Show("add a diffuse texture first"); }
                Directory.SetCurrentDirectory(folderPath + @"\output\materials");
                try { File.Copy(normalDialog.FileName, Path.Combine(Directory.GetCurrentDirectory(), normalDialog.SafeFileName), true); }
                catch (System.IO.FileNotFoundException) { MessageBox.Show("add a normal map first"); }
                try { File.Copy(metallicDialog.FileName, Path.Combine(Directory.GetCurrentDirectory(), metallicDialog.SafeFileName), true); }
                catch (System.IO.FileNotFoundException) { MessageBox.Show("add a metalness map first"); }
                try { File.Copy(roughnessDialog.FileName, Path.Combine(Directory.GetCurrentDirectory(), roughnessDialog.SafeFileName), true); }
                catch (System.IO.FileNotFoundException) { MessageBox.Show("add a roughness map first"); }
                try { File.Copy(aoDialog.FileName, Path.Combine(Directory.GetCurrentDirectory(), aoDialog.SafeFileName), true); }
                catch (System.IO.FileNotFoundException) { MessageBox.Show("add an ambient occlusion map first"); }
            }



            TexturesTextBox.Text = textures_lines;
            MaterialsTextBox.Text = materials_lines;




        }





        /*
         * 
         * ###########################################################################
         * 
         * 
         *                              END OF TEXTURE GENERATION
         * 
         * 
         * ###########################################################################
         * 
         * 
         * */





        private void diffuseDialog_FileOk(object sender, CancelEventArgs e)
        {
            FileInfo file = new FileInfo(diffuseDialog.FileName);
            var sizeInBytes = file.Length;

            Bitmap img = new Bitmap(diffuseDialog.FileName);

            var imageHeight = img.Height;
            var imageWidth = img.Width;
            
        }

        private void TexScaleXTextBox_TextChanged(object sender, EventArgs e)
        {

            float XScale = 1f;
            float YScale = 1f;
            


            try {XScale = Int32.Parse(TexScaleXTextBox.Text); }
            catch (FormatException) { MessageBox.Show("numbers only"); }
            try {YScale = Int32.Parse(TexScaleYTextBox.Text); }
            catch (FormatException) { MessageBox.Show("numbers only"); }

            FileInfo file = new FileInfo(diffuseDialog.FileName);


            try { var sizeInBytes = file.Length; }
            catch (FileNotFoundException) { }


            try
            {
                Bitmap img = new Bitmap(diffuseDialog.FileName);


                var imageHeight = img.Height;
                var imageWidth = img.Width;

                SizeLabel.Text = imageWidth / XScale + "x" + imageHeight / YScale;


                texSizeY = imageHeight.ToString();
                texSizeX = imageWidth.ToString();
            }
            catch (ArgumentException) { }
        }

        private void TexScaleYTextBox_TextChanged(object sender, EventArgs e)
        {

            float XScale = 1f;
            float YScale = 1f;



            try { XScale = Int32.Parse(TexScaleXTextBox.Text); }
            catch (FormatException) { MessageBox.Show("numbers only"); }
            try { YScale = Int32.Parse(TexScaleYTextBox.Text); }
            catch (FormatException) { MessageBox.Show("numbers only"); }

            FileInfo file = new FileInfo(diffuseDialog.FileName);


            try { var sizeInBytes = file.Length; }
            catch (FileNotFoundException) { }


            try
            {
                Bitmap img = new Bitmap(diffuseDialog.FileName);


                var imageHeight = img.Height;
                var imageWidth = img.Width;

                SizeLabel.Text = imageWidth / XScale + "x" + imageHeight / YScale;


                texSizeY = imageHeight.ToString();
                texSizeX = imageWidth.ToString();
            }
            catch (ArgumentException) { }
        }

        private void button15_Click(object sender, EventArgs e)
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
            catch (System.IO.IOException)
            {
                MessageBox.Show("IOException error. Generate first, the pk3 is probably empty."); //error message
            }
        }
    }
}



