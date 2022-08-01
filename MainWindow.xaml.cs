using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.IO;
using System.Windows.Shapes;

namespace GAZ.CSC.WpfApplicationTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {///<summary>
        ///    wpf application to read and format data
        ///</summary>
        ///<summary>
        ///    constructor MainWindow
        ///</summary>
        public MainWindow()
        {
            InitializeComponent();
        }
     
        ///<summary>
        ///    read a line data enteret by user.
        ///    format the data and display result
        ///    formatted textbox control 
        ///</summary>
        ///<param name="sender"></param>
        ///<param name="e"></param>
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string line = TestInput.Text;//create string
           
                line = line.Replace(",", "y:");//format
                line = "x:" + line  + "\n";//merge 
                FormattedText.Text+=line;//out line
            }

        ///<summary>
        ///    after the window has loaded, read data from the standart input.
        ///    format each line and display the results in the formattedtext textblock control
        ///</summary>
            /// <param name="sender"></param>
        ///<param name="e"></param>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            StreamReader sr = new StreamReader("c:\\users\\admin\\documents\\visual studio 2010\\Projects\\GAZ.CSCourse.TestConsoleApplication\\GAZ.CSCourse.TestConsoleApplication\\DataFile.txt");
            
             string line;//create string
           while((line=sr.ReadLine()) !=null)
            {
             line = line.Replace(",", "y:");//format
                line = "x:" + line  + "\n";//merge 
                FormattedText.Text+=line;//out line
            }
               
            }
        } 
        }
    

