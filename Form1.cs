﻿using System;
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
            /*Animation1.Text = "Idle";
            Animation2.Text = "Walk";
            Animation3.Text = "Attack";
            Animation4.Text = "Death";*/

            

            
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
        string dummy_lines;
        string gldefs_lines = "#include Materials.gl";
        int counter;
        int anumber;
        int snameint;
        string snamestr;
        string alphabet;
        string zeros;
        string frameindex;
        string spritestates;
        string line;

        int textureMode = 0; //0-diffuse 1-normal+specular 2-PBR

        int DoomEdNum = 11000;
        List<string> DoomEdNums = new List<string>();

        private void button3_Click(object sender, EventArgs e)
        {

            alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            counter = 0;
            anumber = 0;
            snameint = 0;
            snamestr = "0000";
            zeros = "000";


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








            // DUMMY SPRITES LINES
            dummy_lines = @"sprite 0000A0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0000B0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0000C0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0000D0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0000E0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0000F0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0000G0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0000H0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0000I0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0000J0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0000K0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0000L0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0000M0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0000N0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0000O0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0000P0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0000Q0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0000R0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0000S0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0000T0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0000U0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0000V0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0000W0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0000X0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0000Y0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0000Z0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0001A0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0001B0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0001C0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0001D0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0001E0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0001F0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0001G0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0001H0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0001I0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0001J0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0001K0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0001L0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0001M0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0001N0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0001O0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0001P0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0001Q0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0001R0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0001S0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0001T0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0001U0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0001V0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0001W0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0001X0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0001Y0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0001Z0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0002A0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0002B0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0002C0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0002D0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0002E0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0002F0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0002G0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0002H0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0002I0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0002J0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0002K0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0002L0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0002M0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0002N0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0002O0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0002P0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0002Q0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0002R0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0002S0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0002T0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0002U0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0002V0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0002W0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0002X0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0002Y0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0002Z0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0003A0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0003B0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0003C0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0003D0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0003E0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0003F0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0003G0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0003H0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0003I0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0003J0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0003K0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0003L0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0003M0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0003N0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0003O0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0003P0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0003Q0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0003R0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0003S0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0003T0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0003U0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0003V0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0003W0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0003X0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0003Y0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0003Z0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0004A0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0004B0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0004C0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0004D0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0004E0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0004F0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0004G0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0004H0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0004I0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0004J0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0004K0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0004L0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0004M0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0004N0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0004O0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0004P0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0004Q0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0004R0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0004S0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0004T0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0004U0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0004V0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0004W0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0004X0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0004Y0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0004Z0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0005A0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0005B0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0005C0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0005D0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0005E0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0005F0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0005G0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0005H0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0005I0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0005J0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0005K0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0005L0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0005M0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0005N0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0005O0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0005P0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0005Q0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0005R0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0005S0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0005T0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0005U0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0005V0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0005W0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0005X0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0005Y0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0005Z0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0006A0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0006B0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0006C0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0006D0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0006E0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0006F0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0006G0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0006H0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0006I0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0006J0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0006K0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0006L0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0006M0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0006N0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0006O0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0006P0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0006Q0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0006R0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0006S0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0006T0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0006U0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0006V0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0006W0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0006X0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0006Y0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0006Z0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0007A0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0007B0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0007C0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0007D0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0007E0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0007F0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0007G0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0007H0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0007I0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0007J0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0007K0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0007L0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0007M0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0007N0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0007O0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0007P0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0007Q0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0007R0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0007S0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0007T0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0007U0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0007V0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0007W0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0007X0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0007Y0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0007Z0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0008A0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0008B0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0008C0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0008D0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0008E0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0008F0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0008G0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0008H0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0008I0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0008J0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0008K0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0008L0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0008M0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0008N0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0008O0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0008P0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0008Q0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0008R0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0008S0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0008T0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0008U0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0008V0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0008W0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0008X0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0008Y0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0008Z0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0009A0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0009B0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0009C0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0009D0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0009E0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0009F0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0009G0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0009H0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0009I0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0009J0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0009K0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0009L0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0009M0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0009N0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0009O0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0009P0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0009Q0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0009R0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0009S0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0009T0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0009U0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0009V0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0009W0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0009X0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0009Y0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0009Z0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0010A0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0010B0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0010C0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0010D0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0010E0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0010F0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0010G0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0010H0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0010I0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0010J0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0010K0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0010L0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0010M0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0010N0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0010O0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0010P0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0010Q0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0010R0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0010S0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0010T0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0010U0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0010V0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0010W0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0010X0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0010Y0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0010Z0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0011A0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0011B0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0011C0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0011D0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0011E0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0011F0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0011G0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0011H0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0011I0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0011J0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0011K0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0011L0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0011M0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0011N0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0011O0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0011P0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0011Q0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0011R0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0011S0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0011T0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0011U0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0011V0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0011W0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0011X0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0011Y0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0011Z0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0012A0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0012B0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0012C0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0012D0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0012E0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0012F0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0012G0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0012H0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0012I0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0012J0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0012K0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0012L0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0012M0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0012N0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0012O0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0012P0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0012Q0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0012R0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0012S0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0012T0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0012U0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0012V0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0012W0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0012X0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0012Y0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0012Z0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0013A0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0013B0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0013C0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0013D0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0013E0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0013F0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0013G0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0013H0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0013I0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0013J0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0013K0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0013L0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0013M0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0013N0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0013O0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0013P0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0013Q0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0013R0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0013S0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0013T0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0013U0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0013V0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0013W0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0013X0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0013Y0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0013Z0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0014A0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0014B0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0014C0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0014D0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0014E0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0014F0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0014G0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0014H0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0014I0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0014J0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0014K0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0014L0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0014M0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0014N0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0014O0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0014P0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0014Q0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0014R0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0014S0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0014T0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0014U0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0014V0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0014W0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0014X0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0014Y0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0014Z0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0015A0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0015B0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0015C0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0015D0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0015E0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0015F0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0015G0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0015H0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0015I0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0015J0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0015K0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0015L0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0015M0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0015N0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0015O0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0015P0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0015Q0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0015R0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0015S0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0015T0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0015U0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0015V0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0015W0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0015X0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0015Y0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0015Z0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0016A0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0016B0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0016C0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0016D0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0016E0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0016F0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0016G0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0016H0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0016I0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0016J0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0016K0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0016L0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0016M0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0016N0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0016O0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0016P0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0016Q0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0016R0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0016S0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0016T0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0016U0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0016V0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0016W0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0016X0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0016Y0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0016Z0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0017A0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0017B0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0017C0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0017D0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0017E0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0017F0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0017G0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0017H0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0017I0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0017J0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0017K0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0017L0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0017M0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0017N0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0017O0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0017P0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0017Q0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0017R0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0017S0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0017T0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0017U0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0017V0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0017W0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0017X0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0017Y0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0017Z0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0018A0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0018B0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0018C0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0018D0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0018E0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0018F0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0018G0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0018H0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0018I0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0018J0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0018K0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0018L0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0018M0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0018N0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0018O0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0018P0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0018Q0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0018R0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0018S0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0018T0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0018U0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0018V0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0018W0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0018X0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0018Y0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0018Z0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0019A0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0019B0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0019C0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0019D0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0019E0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0019F0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0019G0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0019H0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0019I0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0019J0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0019K0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0019L0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0019M0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0019N0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0019O0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0019P0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0019Q0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0019R0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0019S0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0019T0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0019U0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0019V0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0019W0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0019X0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0019Y0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0019Z0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0020A0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0020B0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0020C0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0020D0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0020E0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0020F0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0020G0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0020H0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0020I0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0020J0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0020K0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0020L0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0020M0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0020N0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0020O0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0020P0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0020Q0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0020R0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0020S0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0020T0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0020U0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0020V0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0020W0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0020X0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0020Y0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0020Z0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0021A0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0021B0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0021C0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0021D0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0021E0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0021F0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0021G0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0021H0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0021I0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0021J0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0021K0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0021L0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0021M0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0021N0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0021O0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0021P0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0021Q0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0021R0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0021S0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0021T0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0021U0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0021V0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0021W0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0021X0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0021Y0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0021Z0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0022A0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0022B0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0022C0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0022D0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0022E0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0022F0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0022G0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0022H0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0022I0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0022J0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0022K0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0022L0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0022M0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0022N0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0022O0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0022P0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0022Q0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0022R0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0022S0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0022T0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0022U0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0022V0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0022W0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0022X0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0022Y0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0022Z0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0023A0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0023B0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0023C0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0023D0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0023E0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0023F0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0023G0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0023H0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0023I0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0023J0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0023K0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0023L0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0023M0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0023N0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0023O0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0023P0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0023Q0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0023R0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0023S0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0023T0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0023U0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0023V0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0023W0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0023X0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0023Y0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0023Z0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0024A0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0024B0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0024C0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0024D0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0024E0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0024F0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0024G0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0024H0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0024I0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0024J0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0024K0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0024L0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0024M0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0024N0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0024O0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0024P0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0024Q0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0024R0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0024S0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0024T0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0024U0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0024V0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0024W0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0024X0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0024Y0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0024Z0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0025A0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0025B0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0025C0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0025D0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0025E0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0025F0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0025G0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0025H0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0025I0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0025J0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0025K0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0025L0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0025M0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0025N0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0025O0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0025P0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0025Q0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0025R0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0025S0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0025T0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0025U0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0025V0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0025W0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0025X0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0025Y0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0025Z0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0026A0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0026B0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0026C0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0026D0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0026E0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0026F0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0026G0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0026H0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0026I0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0026J0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0026K0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0026L0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0026M0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0026N0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0026O0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0026P0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0026Q0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0026R0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0026S0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0026T0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0026U0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0026V0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0026W0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0026X0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0026Y0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0026Z0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0027A0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0027B0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0027C0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0027D0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0027E0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0027F0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0027G0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0027H0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0027I0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0027J0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0027K0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0027L0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0027M0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0027N0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0027O0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0027P0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0027Q0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0027R0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0027S0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0027T0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0027U0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0027V0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0027W0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0027X0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0027Y0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0027Z0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0028A0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0028B0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0028C0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0028D0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0028E0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0028F0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0028G0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0028H0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0028I0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0028J0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0028K0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0028L0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0028M0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0028N0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0028O0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0028P0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0028Q0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0028R0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0028S0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0028T0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0028U0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0028V0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0028W0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0028X0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0028Y0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0028Z0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0029A0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0029B0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0029C0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0029D0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0029E0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0029F0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0029G0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0029H0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0029I0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0029J0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0029K0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0029L0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0029M0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0029N0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0029O0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0029P0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0029Q0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0029R0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0029S0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0029T0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0029U0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0029V0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0029W0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0029X0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0029Y0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0029Z0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0030A0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0030B0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0030C0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0030D0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0030E0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0030F0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0030G0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0030H0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0030I0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0030J0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0030K0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0030L0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0030M0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0030N0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0030O0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0030P0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0030Q0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0030R0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0030S0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0030T0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0030U0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0030V0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0030W0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0030X0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0030Y0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0030Z0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0031A0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0031B0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0031C0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0031D0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0031E0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0031F0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0031G0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0031H0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0031I0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0031J0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0031K0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0031L0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0031M0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0031N0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0031O0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0031P0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0031Q0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0031R0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0031S0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0031T0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0031U0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0031V0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0031W0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0031X0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0031Y0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0031Z0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0032A0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0032B0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0032C0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0032D0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0032E0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0032F0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0032G0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0032H0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0032I0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0032J0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0032K0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0032L0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0032M0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0032N0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0032O0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0032P0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0032Q0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0032R0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0032S0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0032T0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0032U0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0032V0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0032W0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0032X0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0032Y0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0032Z0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0033A0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0033B0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0033C0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0033D0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0033E0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0033F0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0033G0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0033H0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0033I0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0033J0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0033K0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0033L0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0033M0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0033N0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0033O0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0033P0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0033Q0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0033R0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0033S0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0033T0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0033U0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0033V0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0033W0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0033X0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0033Y0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0033Z0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0034A0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0034B0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0034C0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0034D0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0034E0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0034F0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0034G0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0034H0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0034I0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0034J0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0034K0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0034L0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0034M0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0034N0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0034O0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0034P0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0034Q0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0034R0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0034S0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0034T0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0034U0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0034V0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0034W0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0034X0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0034Y0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0034Z0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0035A0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0035B0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0035C0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0035D0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0035E0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0035F0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0035G0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0035H0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0035I0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0035J0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0035K0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0035L0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0035M0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0035N0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0035O0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0035P0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0035Q0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0035R0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0035S0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0035T0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0035U0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0035V0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0035W0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0035X0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0035Y0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0035Z0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0036A0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0036B0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0036C0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0036D0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0036E0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0036F0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0036G0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0036H0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0036I0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0036J0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0036K0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0036L0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0036M0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0036N0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0036O0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0036P0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0036Q0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0036R0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0036S0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0036T0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0036U0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0036V0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0036W0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0036X0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0036Y0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0036Z0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0037A0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0037B0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0037C0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0037D0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0037E0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0037F0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0037G0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0037H0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0037I0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0037J0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0037K0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0037L0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0037M0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0037N0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0037O0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0037P0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0037Q0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0037R0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0037S0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0037T0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0037U0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0037V0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0037W0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0037X0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0037Y0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0037Z0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0038A0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0038B0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0038C0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0038D0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0038E0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0038F0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0038G0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0038H0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0038I0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0038J0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0038K0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0038L0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0038M0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0038N0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0038O0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0038P0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0038Q0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0038R0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0038S0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0038T0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0038U0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0038V0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0038W0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0038X0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0038Y0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0038Z0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0039A0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0039B0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0039C0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0039D0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0039E0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0039F0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0039G0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0039H0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0039I0, 1, 1 { patch TNT1A0, 0, 0 {} }
sprite 0039J0, 1, 1 { patch TNT1A0, 0, 0 {} }";


            //SPRITE NAME GENERATOR
            if (checkBox1.Checked) //If animated is checked
            {
                frameindex = "";
                spritestates = "";
                while (counter < Int32.Parse(frameNumber.Text) + 1)
                {
                    
                    snamestr = zeros + snameint.ToString();

                    line = "    FrameIndex " + snamestr + " " + alphabet[anumber] + " " + "0 " + counter.ToString() + "\r\n";
                    frameindex += line;
                    line = "        " + snamestr + " " + alphabet[anumber] + " 1;" + " //" + counter.ToString() + "\r\n";
                    spritestates += line;


                    anumber += 1;
                    counter += 1;

                    if (counter > 259)
                    {
                        zeros = "00";
                    }
                    if (anumber == 26)
                    {
                        snameint += 1;
                        anumber = 0;
                    }
                }
            }
            else //if (!checkBox1.Checked)
            {
                frameindex = "    FrameIndex 0000 A 0 0";
                spritestates = "         0000 A -1;\r\n";
            }




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
                    $"{frameindex} \r\n\r\n" +
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
                "FrameIndex 0000 A 0 0 \r\n\r\n" +
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
                $"{spritestates}" +
                "        Loop;\r\n" +
                "    Death:\r\n" +
                "        0000 A 1;\r\n" +
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

            /////////////////////////DUMMY SPRITES

            if (!File.Exists(@"\textures.DummySprites.lmp")) // If file does not exists
            {
                File.Create("textures.DummySprites.lmp").Close(); // Create file
                using (StreamWriter sw = File.AppendText("textures.DummySprites.lmp"))
                {
                    sw.WriteLine(dummy_lines); // Write text to .txt file
                }
            }
            else // If file already exists
            {
                File.WriteAllText("textures.DummySprites.lmp", String.Empty); // Clear file
                using (StreamWriter sw = File.AppendText(@"\textures.DummySprites.lmp"))
                {
                    sw.WriteLine(dummy_lines); // Write text to .txt file
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
            /*tableLayoutPanel1.Enabled = !tableLayoutPanel1.Enabled;
            tableLayoutPanel1.Visible = !tableLayoutPanel1.Visible;*/
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



