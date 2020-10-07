using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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

namespace Dota2InsightTool
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Dota2APICall.GetData();
            MessageBox.Show("Test");
            //JToken token = JObject.Parse(Dota2APICall.APIResults);
            //MatchData myDeserializedClass = JsonConvert.DeserializeObject<MatchData>(Dota2APICall.APIResults);

            MatchData.Root test = MatchData.Deserialize(Dota2APICall.APIResults);

            tMainTextBox.Text = test.first_blood_time.ToString();
        }
    }
}
