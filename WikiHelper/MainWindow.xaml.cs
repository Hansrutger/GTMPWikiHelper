using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WikiHelper
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.Title = "WikiHelper";
            this.ResizeMode = ResizeMode.CanMinimize;
            WindowStartupLocation = WindowStartupLocation.CenterScreen;

            this.CodeBox.Document.Blocks.Clear();
            this.ErrorLbl.Content = "";
            this.InputTextbox.Text = "";
        }

        private void WriteClientSide(string type, string function, List<string> args)
        {
            this.CodeBox.Document.Blocks.Clear();

            string paramStr = "(";
            if (args.Count != 0)
            {
                int counter = 0;
                foreach (string str in args)
                {
                    counter++;

                    paramStr += str;

                    if (counter % 2 == 0 && counter < args.Count)
                    {
                        paramStr += ", ";
                    }
                    else if (counter < args.Count)
                    {
                        paramStr += " ";
                    }
                }
            }

            paramStr += ")";

            this.CodeBox.AppendText("__NOTOC____NOEDITSECTION__{{Template:Client_side_javascript}}" + "\r");
            this.CodeBox.AppendText("Function description here..." + "\r\r");
            this.CodeBox.AppendText("{{New_API}}" + "\r\r");
            this.CodeBox.AppendText("==Syntax==" + "\r");
            this.CodeBox.AppendText("{{inJS| <syntaxhighlight lang=\"JS\" >" + "\r");
            this.CodeBox.AppendText("API." + function + paramStr + ";" + "\r");
            this.CodeBox.AppendText("</syntaxhighlight>" + "\r");

            if (args.Count > 0)
            {
                this.CodeBox.AppendText("\r'''Required Arguments'''" + "\r");

                int counter = 0;
                string currType = "";
                string currPara = "";
                foreach (string str in args)
                {
                    counter++;

                    if (counter % 2 == 0)
                    {
                        currPara = str;

                        this.CodeBox.AppendText("*'''" + currPara + "''' parameter input should be in '''" + currType + "''' type." + "\r");
                    }
                    else
                    {
                        currType = str;
                    }
                }
            }

            if (type != "void")
            {
                this.CodeBox.AppendText("\r\r" + "'''NOTE:''' This function returns data in '''" + type + "''' type." + "\r");
            }

            this.CodeBox.AppendText("}}" + "\r\r");
            this.CodeBox.AppendText("==Usage example==" + "\r");
            this.CodeBox.AppendText("{{inJS| <syntaxhighlight lang=\"JS\" >" + "\r");
            this.CodeBox.AppendText("API." + function + paramStr + ";" + "\r");
            this.CodeBox.AppendText("</syntaxhighlight> }}" + "\r\r");

            this.CodeBox.AppendText("==References==" + "\r");
        }

        private void WriteServerSide(string type, string function, List<string> args)
        {
            this.CodeBox.Document.Blocks.Clear();

            string paramStr = "(";
            if (args.Count != 0)
            {
                int counter = 0;
                foreach (string str in args)
                {
                    counter++;

                    paramStr += str;

                    if (counter % 2 == 0 && counter < args.Count)
                    {
                        paramStr += ", ";
                    }
                    else if (counter < args.Count)
                    {
                        paramStr += " ";
                    }
                }
            }

            paramStr += ")";

            this.CodeBox.AppendText("__NOTOC____NOEDITSECTION__{{Template:Server_side_csharp}}" + "\r");
            this.CodeBox.AppendText("Function description here..." + "\r\r");
            this.CodeBox.AppendText("{{New_API}}" + "\r\r");
            this.CodeBox.AppendText("==Syntax==" + "\r");
            this.CodeBox.AppendText("{{inC#| <syntaxhighlight lang=\"Csharp\" >" + "\r");
            this.CodeBox.AppendText("API." + function + paramStr + ";" + "\r");
            this.CodeBox.AppendText("</syntaxhighlight>" + "\r");

            if (args.Count > 0)
            {
                this.CodeBox.AppendText("\r'''Required Arguments'''" + "\r");

                int counter = 0;
                string currType = "";
                string currPara = "";
                foreach (string str in args)
                {
                    counter++;

                    if (counter % 2 == 0)
                    {
                        currPara = str;

                        this.CodeBox.AppendText("*'''" + currPara + "''' parameter input should be in '''" + currType + "''' type." + "\r");
                    }
                    else
                    {
                        currType = str;
                    }
                }
            }

            if (type != "void")
            {
                this.CodeBox.AppendText("\r\r" + "'''NOTE:''' This function returns data in '''" + type + "''' type." + "\r");
            }

            this.CodeBox.AppendText("}}" + "\r\r");
            this.CodeBox.AppendText("==Usage example==" + "\r");
            this.CodeBox.AppendText("{{inC#| <syntaxhighlight lang=\"CSharp\" >" + "\r");
            this.CodeBox.AppendText("API." + function + paramStr + ";" + "\r");
            this.CodeBox.AppendText("</syntaxhighlight> }}" + "\r\r");

            this.CodeBox.AppendText("==References==" + "\r");
        }

        private void WriteBothSide(string type, string function, List<string> args)
        {
            this.CodeBox.Document.Blocks.Clear();

            string paramStr = "(";
            if (args.Count != 0)
            {
                int counter = 0;
                foreach (string str in args)
                {
                    counter++;

                    paramStr += str;

                    if (counter % 2 == 0 && counter < args.Count)
                    {
                        paramStr += ", ";
                    }
                    else if (counter < args.Count)
                    {
                        paramStr += " ";
                    }
                }
            }

            paramStr += ")";

            this.CodeBox.AppendText("__NOTOC____NOEDITSECTION__{{Template:Shared_function_csharp_javascript}}" + "\r");
            this.CodeBox.AppendText("Function description here..." + "\r\r");
            this.CodeBox.AppendText("{{New_API}}" + "\r\r");
            this.CodeBox.AppendText("==Syntax==" + "\r");
            this.CodeBox.AppendText("{{inC#| <syntaxhighlight lang=\"Csharp\" >" + "\r");
            this.CodeBox.AppendText("API." + function + paramStr + ";" + "\r");
            this.CodeBox.AppendText("</syntaxhighlight>" + "\r");

            if (args.Count > 0)
            {
                this.CodeBox.AppendText("\r'''Required Arguments'''" + "\r");

                int counter = 0;
                string currType = "";
                string currPara = "";
                foreach (string str in args)
                {
                    counter++;

                    if (counter % 2 == 0)
                    {
                        currPara = str;

                        this.CodeBox.AppendText("*'''" + currPara + "''' parameter input should be in '''" + currType + "''' type." + "\r");
                    }
                    else
                    {
                        currType = str;
                    }
                }
            }

            if (type != "void")
            {
                this.CodeBox.AppendText("\r\r" + "'''NOTE:''' This function returns data in '''" + type + "''' type." + "\r");
            }

            this.CodeBox.AppendText("}}" + "\r\r");


            this.CodeBox.AppendText("{{inJS| <syntaxhighlight lang=\"JS\" >" + "\r");
            this.CodeBox.AppendText("API." + function + paramStr + ";" + "\r");
            this.CodeBox.AppendText("</syntaxhighlight>" + "\r");

            if (args.Count > 0)
            {
                this.CodeBox.AppendText("\r'''Required Arguments'''" + "\r");

                int counter = 0;
                string currType = "";
                string currPara = "";
                foreach (string str in args)
                {
                    counter++;

                    if (counter % 2 == 0)
                    {
                        currPara = str;

                        this.CodeBox.AppendText("*'''" + currPara + "''' parameter input should be in '''" + currType + "''' type." + "\r");
                    }
                    else
                    {
                        currType = str;
                    }
                }
            }

            if (type != "void")
            {
                this.CodeBox.AppendText("\r\r" + "'''NOTE:''' This function returns data in '''" + type + "''' type." + "\r");
            }

            this.CodeBox.AppendText("}}" + "\r\r");


            this.CodeBox.AppendText("==Usage example==" + "\r");
            this.CodeBox.AppendText("{{inC#| <syntaxhighlight lang=\"CSharp\" >" + "\r");
            this.CodeBox.AppendText("API." + function + paramStr + ";" + "\r");
            this.CodeBox.AppendText("</syntaxhighlight> }}" + "\r\r");

            this.CodeBox.AppendText("{{inJS| <syntaxhighlight lang=\"Javascript\" >" + "\r");
            this.CodeBox.AppendText("API." + function + paramStr + ";" + "\r");
            this.CodeBox.AppendText("</syntaxhighlight> }}" + "\r\r");

            this.CodeBox.AppendText("==References==" + "\r");
        }

        private void CreatePageBtn_Clicked(object sender, RoutedEventArgs e)
        {
            if (this.InputTextbox.Text.Length <= 7)
            {
                this.ErrorLbl.Content = "Input a real function with format: \"type function\" (eg. \"void startAudioScene(string scene)\")";
                return;
            }

            int sideType = GetSideType();
            if (sideType == 0)
            {
                this.ErrorLbl.Content = "You need to check server- or client-side!";
                return;
            }


            string type = GetReturnType(this.InputTextbox.Text);
            string function = GetFunctionName(this.InputTextbox.Text);
            List<string> args = GetArguments(this.InputTextbox.Text);

            if (type.Length == 0 || function.Length == 0)
            {
                this.ErrorLbl.Content = "Could not find proper type or function name!";
                return;
            }

            if (sideType == 1)
            {
                WriteClientSide(type, function, args);
            }
            else if (sideType == 2)
            {
                WriteServerSide(type, function, args);
            }
            else if (sideType == 3)
            {
                WriteBothSide(type, function, args);
            }
        }

        private string GetReturnType(string input)
        {
            string type = "";

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                {
                    break;
                }

                type += input[i];
            }

            return type;
        }

        private string GetFunctionName(string input)
        {
            string name = "";
            bool foundStart = false;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != ' ' && !foundStart)
                {
                    continue;
                }
                else if (input[i] == ' ')
                {
                    foundStart = true;
                    continue;
                }


                if (input[i] == '(')
                {
                    break;
                }

                name += input[i];
            }

            return name;
        }

        private List<string> GetArguments(string input)
        {
            List<string> args = new List<string>();
            string currArg = "";
            bool foundStart = false;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != '(' && !foundStart)
                {
                    continue;
                }
                else if (input[i] == '(')
                {
                    foundStart = true;
                    continue;
                }

                if (input[i] == ',' || input[i] == ')' || input[i] == ' ')
                {
                    if (i + 1 < input.Length && input[i + 1] == ' ' && input[i] == ',')
                    {
                        i++;
                    }

                    args.Add(currArg);
                    currArg = "";

                    if (input[i] == ')')
                    {
                        break;
                    }
                }
                else
                {
                    currArg += input[i];
                }
            }

            return args;
        }

        private int GetSideType()
        {
            int type = 0;

            if (this.CCheck.IsChecked.Value)
            {
                type = 1;
            }

            if (this.SCheck.IsChecked.Value)
            {
                type = 2;
            }

            if (this.CCheck.IsChecked.Value && this.SCheck.IsChecked.Value)
            {
                type = 3;
            }

            return type;
        }
    }
}
