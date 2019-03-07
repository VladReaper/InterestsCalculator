using System;
using System.Globalization;

namespace InterestsCalculator
{
  public partial class MainForm : System.Windows.Forms.Form
  {
    private static readonly CultureInfo s_cultureInfo = new CultureInfo("en-gb", false);

    public MainForm()
    {
      InitializeComponent();
    }

    public decimal CalculateInterests(decimal accountBalance)
    {
      var interests = decimal.Multiply(accountBalance, GetBandValue(accountBalance)) / 100;
      
      return decimal.Round(interests, 2);
    }

    private decimal GetBandValue(decimal balance)
    {
      if (balance < 1000)
        return Constants.Band1;
      if (1000m < balance && balance < 5000m)
        return Constants.Band2;
      if (5000m < balance && balance < 10000m)
        return Constants.Band3;
      if (10000m < balance && balance < 50000m)
        return Constants.Band4;
      if (50000m < balance)
        return Constants.Band5;

      return 0;
    }
    
    private void accountBalanceNumeric_ValueChanged(object sender, EventArgs e)
    {
      var accountBalance = accountBalanceNumeric.Value;

      interestsTextBox.Text = CalculateInterests(accountBalance).ToString("C", s_cultureInfo);
    }
  }
}
