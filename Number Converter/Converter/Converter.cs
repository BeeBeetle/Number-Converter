using System.Security.Cryptography.X509Certificates;
using Engine;

namespace Converter
{
    public partial class Converter : Form
    {
        public Converter()
        {
            InitializeComponent();
        }
        private void Converter_Load(object sender, EventArgs e)
        {
            //making our list of available bases
            //because of the array in NumberChanger as it stands base 92 is the largest you can go
            //however any base smaller than that could be added
            var listOfBases = new List<NumberBases>();
            listOfBases.Add(new NumberBases() { baseName = "Binary", baseValue = 2 });
            listOfBases.Add(new NumberBases() { baseName = "Trinary", baseValue = 3 });
            listOfBases.Add(new NumberBases() { baseName = "Septecimal", baseValue = 7 });
            listOfBases.Add(new NumberBases() { baseName = "Decimal", baseValue = 10 });
            listOfBases.Add(new NumberBases() { baseName = "Duodecimal", baseValue = 12 });
            listOfBases.Add(new NumberBases() { baseName = "Hexadecimal", baseValue = 16 });
            listOfBases.Add(new NumberBases() { baseName = "Babylonian", baseValue = 60 });
            listOfBases.Add(new NumberBases() { baseName = "Asciidecimal", baseValue = 92 });
            //we need to clone our original list so we can use it in two places
            //otherwise both dropdowns will simply mirror eachother
            var inputBases = new List<NumberBases>(listOfBases);
            var outputBases = new List<NumberBases>(listOfBases);

            //currently the input is locked to decimal
            //this is because I haven't written a reverse conversion yet from base X into anything else
            //other than that this defines our selections so we know what to display when someone wants to make a choice
            //the displaymember is what the user sees
            //the value member determines the number of the base used to convert (.SelectedValue)
            cmbInput.DataSource = inputBases;
            cmbInput.ValueMember = "baseValue";
            cmbInput.DisplayMember = "baseName";
            cmbInput.SelectedIndex = 3;

            cmbOutput.DataSource = outputBases;
            cmbOutput.ValueMember = "baseValue";
            cmbOutput.DisplayMember = "baseName";
            cmbOutput.SelectedIndex = 0;
        }
        private void rtbInput_TextChanged(object sender, EventArgs e)
        {

        }
        private void rtbOutput_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnConvert_Click(object sender, EventArgs e)
        {
            //here we are assigning the output text to the results of the number change method
            //we also have to convert the input (starts as a string) into a number so we can do math
            //the output gets to stay as a string because once we convert it doesn't matter
            //the reverse conversion will be much harder to create because how do you do math on A%,~%*54h
            NumberChanger numberChanger = new NumberChanger();
            rtbOutput.Text = numberChanger.ConversionMethod(Convert.ToUInt64(rtbInput.Text), Convert.ToUInt64(cmbOutput.SelectedValue));
        }
    }
}