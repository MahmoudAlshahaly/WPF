using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfDay01
{
    /// <summary>
    /// Interaction logic for Paint.xaml
    /// </summary>
    public partial class Paint : Window
    {
        public Paint()
        {
            InitializeComponent();
        }
        Brush customColor = new SolidColorBrush(Color.FromRgb(10, 20, 30));
        Random r = new Random();

        private void Change_Color(object sender, RoutedEventArgs e)
        {
           switch( ( (RadioButton) sender).Content.ToString())
            {
                case "Red":
                    Ink.DefaultDrawingAttributes.Color = Colors.Red;
                    break;
                case "Green":
                    Ink.DefaultDrawingAttributes.Color = Colors.Green;
                    break;
                case "Blue":
                    Ink.DefaultDrawingAttributes.Color = Colors.Blue;
                    break;
            }
        }

        private void Change_Mode(object sender, RoutedEventArgs e)
        {
            switch (((RadioButton)sender).Content.ToString())
            {
                case "Ink":
                    Ink.EditingMode = InkCanvasEditingMode.Ink;
                    break;

                case "Select":
                    Ink.EditingMode = InkCanvasEditingMode.Select;
                    break;

                case "Erase":
                    Ink.EditingMode = InkCanvasEditingMode.EraseByPoint;
                    break;
                case "Erase By Strock":
                    Ink.EditingMode = InkCanvasEditingMode.EraseByStroke;
                    break;



            }
        }


        private void Change_DrawingShap(object sender, RoutedEventArgs e)
        {
            switch (((RadioButton)sender).Content.ToString())
            {
                case "ellipce":
                    Ink.DefaultDrawingAttributes.StylusTip = System.Windows.Ink.StylusTip.Ellipse;
                    //Ellipse e1 = new Ellipse();
                    //e1.Width = 100;
                    //e1.Height = 100;

                    //e1.StrokeThickness = 4;
                    //e1.Fill = customColor;
                    //e1.Stroke = Brushes.Aqua;
                    //Canvas.SetLeft(e1, Mouse.GetPosition(Ink).X);
                    //Canvas.SetTop(e1, Mouse.GetPosition(Ink).Y);
                    //Ink.Children.Add(e1);
                    break;

                case "rectangle":
                    //Rectangle r1 = new Rectangle();
                    //r1.Width =100;
                    //r1.Height = 100;

                    //r1.StrokeThickness = 4;
                    //r1.Fill = customColor;
                    //r1.Stroke = Brushes.Crimson;
                    //Canvas.SetLeft(r1, Mouse.GetPosition(Ink).X);
                    //Canvas.SetTop(r1, Mouse.GetPosition(Ink).Y);
                    //Ink.Children.Add(r1);
                    Ink.DefaultDrawingAttributes.StylusTip = System.Windows.Ink.StylusTip.Rectangle;

                    break;
            }
        }

        private void Change_BruchSize(object sender, RoutedEventArgs e)
        {
            switch (((RadioButton)sender).Content.ToString())
            {
                case "small":
                    Ink.DefaultDrawingAttributes.Width = 5;
                    Ink.DefaultDrawingAttributes.Height = 5;
                    break;

                case "normal":
                    Ink.DefaultDrawingAttributes.Width = 20;
                    Ink.DefaultDrawingAttributes.Height = 20;
                    break;
                case "large":
                    Ink.DefaultDrawingAttributes.Width = 50;
                    Ink.DefaultDrawingAttributes.Height = 50;
                    break;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Ink.Strokes.Clear();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Ink.CopySelection();
        }
        string filePath;
        private void btnLoadFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            bool openFileDialogResult = (bool)openFileDialog.ShowDialog();

            if (openFileDialogResult == true)
            {
                filePath = openFileDialog.FileName;

                FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                StrokeCollection strokes = new StrokeCollection(fs);
                Ink.Strokes = strokes;
            }
        }

        private void btnSaveFile_Click(object sender, RoutedEventArgs e)
        {
            if (filePath == null)
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                bool saveFileResult = (bool)(saveFile.ShowDialog());
                if (saveFileResult == true)
                {
                    FileStream fs = new FileStream(saveFile.FileName, FileMode.Create);
                    Ink.Strokes.Save(fs);
                    fs.Close();
                }
            }
            else
            {
                FileStream fs = new FileStream(filePath, FileMode.Create);
                Ink.Strokes.Save(fs);
                fs.Close();
                filePath = null;
            }
        }

        private void btnCut_Click(object sender, RoutedEventArgs e)
        {
            Ink.CutSelection();
        }

        private void BtnPaste_Click(object sender, RoutedEventArgs e)
        {
            Ink.Paste();
        }
    }
}
