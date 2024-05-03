using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace typograph
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }  
       
        private void UserText_TextChanged(object sender, EventArgs e)
        {
            var methods = new Methods();
            string inputText = UserText.Text;

            //1 правило

            string outputText = methods.RemovingSpace(inputText);

            //2 правило

            outputText = methods.PlusMinus(outputText);

            //3 правило

            outputText = methods.Ellipses(outputText);

            //4 правило

            outputText = methods.Quotes(outputText);

            //5 правило

            outputText = methods.DashToMinus(outputText);

            outputText = methods.SpacesAroundPlusMinus(outputText);
            outputText = methods.SpacesAroundEqual(outputText);
            outputText = methods.SpacesAroundMultilyDivision(outputText);

            //6 правило

            outputText = methods.ExtraCommas(outputText);

            //7 правило(абсурдное)

            outputText = methods.Absurdity(outputText);


            ChangeText.Text = outputText;
        }
    }
}
