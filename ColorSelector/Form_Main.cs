using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace ColorSelector
{
    public partial class Form_main : Form
    {
        public Form_main()
        {
            InitializeComponent();
        }
        #region variable
        public static string datapath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        public static string fullpath = System.Windows.Forms.Application.ExecutablePath;
        public static string filename = System.IO.Path.GetFileNameWithoutExtension(fullpath);
        public static string path = datapath + "\\" + filename + ".xml";
        bool eventlock = false;
        int[] customcolors;
        #endregion
        #region Event
        private void button_color_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.AllowFullOpen = true;
            colorDialog.AnyColor = true;
            colorDialog.FullOpen = true;
            colorDialog.SolidColorOnly = false;
            colorDialog.CustomColors = customcolors;
            colorDialog.Color = panel_color.BackColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                panel_color.BackColor = colorDialog.Color;
                textBox_red.Text = colorDialog.Color.R.ToString();
                textBox_green.Text = colorDialog.Color.G.ToString();
                textBox_blue.Text = colorDialog.Color.B.ToString();
                textBox_rgb.Text = ColorToRgbString(colorDialog.Color);
                customcolors = colorDialog.CustomColors;
            }
        }

        private void textBox_red_TextChanged(object sender, EventArgs e)
        {
            ColorChanged(textBox_red);
        }

        private void textBox_green_TextChanged(object sender, EventArgs e)
        {
            ColorChanged(textBox_green);
        }

        private void textBox_blue_TextChanged(object sender, EventArgs e)
        {
            ColorChanged(textBox_blue);
        }

        private void textBox_rgb_TextChanged(object sender, EventArgs e)
        {
            if (!eventlock)
            {
                try
                {
                    eventlock = true;
                    label_info.Text = "";
                    Color color = (Color)new ColorConverter().ConvertFromString(textBox_rgb.Text);
                    panel_color.BackColor = color;
                    textBox_red.Text = color.R.ToString();
                    textBox_green.Text = color.G.ToString();
                    textBox_blue.Text = color.B.ToString();
                }
                catch
                {
                    label_info.Text = "Wrong value!";
                }
                finally
                {
                    eventlock = false;
                }
            }
        }

        private void Form_main_Load(object sender, EventArgs e)
        {
            try
            {
                if (!eventlock)
                {
                    eventlock = true;
                    textBox_red.Text = "255";
                    textBox_green.Text = "255";
                    textBox_blue.Text = "255";
                    panel_color.BackColor = Color.White;
                    label_info.Text = "";
                    XmlDocument doc = new XmlDocument();
                    if (!File.Exists(path))
                    {
                        XmlElement root = doc.CreateElement("ColorSelector");
                        XmlElement CustomColors = doc.CreateElement("CustomColors");
                        XmlElement MainColor = doc.CreateElement("MainColor");
                        XmlElement MainForm = doc.CreateElement("MainForm");
                        MainForm.SetAttribute("Top", this.Top.ToString());
                        MainForm.SetAttribute("Left", this.Left.ToString());
                        for (int i = 0; i < 16; i++)
                        {
                            XmlElement color = doc.CreateElement("Color");
                            color.InnerText = "16777215";
                            CustomColors.AppendChild(color);
                        }
                        root.AppendChild(CustomColors);
                        MainColor.InnerText = panel_color.BackColor.ToArgb().ToString();
                        root.AppendChild(MainColor);
                        root.AppendChild(MainForm);
                        doc.AppendChild(root);
                        WriteSetting(path, doc);
                        //doc.Save(path);
                    }
                    else
                    {
                        doc = ReadSetting(path);
                        //doc.Load(path);
                        XmlElement MainForm = doc.DocumentElement["MainForm"];
                        this.Top = Convert.ToInt32(MainForm.GetAttribute("Top"));
                        this.Left= Convert.ToInt32(MainForm.GetAttribute("Left"));
                        XmlNodeList CustomColorsList = doc.DocumentElement["CustomColors"].ChildNodes;
                        if (customcolors == null)
                            customcolors = new int[CustomColorsList.Count];
                        for (int i = 0; i < CustomColorsList.Count; i++)
                        {
                            customcolors[i] = Convert.ToInt32(CustomColorsList[i].InnerText);
                        }
                        XmlNode MainColor = doc.DocumentElement["MainColor"];
                        Color color = Color.FromArgb(Convert.ToInt32(MainColor.InnerText));
                        textBox_red.Text = color.R.ToString();
                        textBox_green.Text = color.G.ToString();
                        textBox_blue.Text = color.B.ToString();
                        textBox_rgb.Text = ColorToRgbString(color);
                        panel_color.BackColor = color;
                    }
                }
            }
            catch
            {
                label_info.Text = "Wrong value!";
            }
            finally
            {
                eventlock = false;
            }
        }

        private void Form_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc = ReadSetting(path);
                //doc.Load(path);
                if (customcolors != null)
                {
                    XmlNodeList CustomColorsList = doc.DocumentElement["CustomColors"].ChildNodes;
                    for (int i = 0; i < CustomColorsList.Count; i++)
                    {
                        CustomColorsList[i].InnerText = customcolors[i].ToString();
                    }
                }
                XmlNode MainColor = doc.DocumentElement["MainColor"];
                XmlElement MainForm = doc.DocumentElement["MainForm"];
                MainForm.SetAttribute("Top", this.Top.ToString());
                MainForm.SetAttribute("Left", this.Left.ToString());
                MainColor.InnerText = panel_color.BackColor.ToArgb().ToString();
                WriteSetting(path, doc);
                //doc.Save(path);
            }
            catch
            {

            }
            finally
            {
                Environment.Exit(0);
            }
        }
        #endregion
        #region Functions
        private string ColorToRgbString(Color color)
        {
            string red = Convert.ToString(color.R, 16);
            string green = Convert.ToString(color.G, 16);
            string blue = Convert.ToString(color.B, 16);
            if (red.Length < 2)
            {
                red = "0" + red;
            }
            if (green.Length < 2)
            {
                green = "0" + green;
            }
            if (blue.Length < 2)
            {
                blue = "0" + blue;
            }
            string RgbString = "#" + red + green + blue;
            return RgbString;
        }
        private void ColorChanged(TextBox textBox)
        {
            if (!eventlock)
            {
                try
                {
                    eventlock = true;
                    label_info.Text = "";
                    bool isred = int.TryParse(textBox_red.Text, out int red);
                    bool isgreen = int.TryParse(textBox_green.Text, out int green);
                    bool isblue = int.TryParse(textBox_blue.Text, out int blue);
                    if (!isred || !isgreen || !isblue)
                    {
                        label_info.Text = "Wrong value!";
                    }
                    Color color = Color.FromArgb(red, green, blue);
                    panel_color.BackColor = color;
                    if (textBox != textBox_red)
                        textBox_red.Text = color.R.ToString();
                    if (textBox != textBox_green)
                        textBox_green.Text = color.G.ToString();
                    if (textBox != textBox_blue)
                        textBox_blue.Text = color.B.ToString();
                    textBox_rgb.Text = ColorToRgbString(color);
                }
                catch
                {
                    label_info.Text = "Wrong value!";
                }
                finally
                {
                    eventlock = false;
                }
            }
        }
        #endregion
        #region XmlOperation
        private XmlDocument ReadSetting(string FilePath)
        {
            XmlDocument xmlDocument = new XmlDocument();
            XmlReaderSettings readerSettings = new XmlReaderSettings();
            readerSettings.IgnoreComments = true;
            XmlReader xmlReader = XmlReader.Create(FilePath, readerSettings);
            xmlDocument.Load(xmlReader);
            xmlReader.Close();
            return xmlDocument;
        }
        private void WriteSetting(string FilePath, XmlDocument xmlDocument)
        {
            XmlWriterSettings writerSettings = new XmlWriterSettings();
            writerSettings.Encoding = Encoding.UTF8;
            writerSettings.Indent = true;
            XmlWriter xmlWriter = XmlWriter.Create(FilePath, writerSettings);
            xmlDocument.Save(xmlWriter);
            xmlWriter.Close();
        }
        #endregion
    }
} 
