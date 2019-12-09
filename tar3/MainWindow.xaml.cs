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

namespace tar3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {        private Host currentHost;
        List<Host> hostsList;
        public MainWindow()
        {
            hostsList = new List<Host>()
        {
            new Host()
            {
                HostName1 = "Yossi",
                Units1 = new List<HostingUnit>()
                {
                    new HostingUnit()
                    {
                        UnitName1="צימר הגליל",
                        Rooms1 = 2,
                        IsSwimmingPool1=true,
                        AllOrders=new List <DateTime>(),
                        Uris=new List<string>()
                        {
                             "https://static.theceomagazine.net/wp-content/uploads/2018/09/13111234/Stevie-Mann-SJR-4-1100x733.jpg",
                            "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQl5LVJzqvc70kSgP590isXxnvvoR8MG_mIWQmo4yt_h6JzAHo22w&s"
                        }
                    },
                    new HostingUnit()
                    {
                        UnitName1="צימר הגליל הקסום",
                        Rooms1 = 3,
                        IsSwimmingPool1=true,
                        AllOrders=new List <DateTime>(),
                        Uris=new List<string>()
                        {
                             "https://pic.rrr.co.il/images/mazalbakineret/103%20(Custom).jpg",
                             "https://pic.rrr.co.il/images/mazalbakineret/91%20(Custom).jpg",
                             "https://pic.rrr.co.il/images/mazalbakineret/108%20(Custom).jpg"
                        }
                    }
                }
            },

            new Host()
            {
                HostName1 = "Moshiko",
                Units1 = new List<HostingUnit>()
                {
                    new HostingUnit()
                    {
                        UnitName1="יטבת הדרום",
                        Rooms1 = 2,
                        IsSwimmingPool1=false,
                        AllOrders=new List <DateTime>(),
                        Uris=new List<string>()
                        {
                            "https://pic.rrr.co.il/images/pinokbakfar/140%20(Custom).jpg",
                            "https://pic.rrr.co.il/images/pinokbakfar/178%20(Custom).jpg",
                            "https://pic.rrr.co.il/images/pinokbakfar/138%20(Custom).jpg"
                        }
                    }
                }
            },

            new Host()
            {
                HostName1 = "Shira",
                Units1 = new List<HostingUnit>()
                {
                    new HostingUnit()
                    {
                        UnitName1="צימר בגולן",
                        Rooms1 = 3,
                        IsSwimmingPool1=false,
                        AllOrders=new List <DateTime>(),
                        Uris=new List<string>()
                        {
                            "https://pic.rrr.co.il/images/ahavaglilit/187%20(Custom).jpg",
                            "https://pic.rrr.co.il/images/ahavaglilit/188%20(Custom).jpg",
                            "https://pic.rrr.co.il/images/ahavaglilit/194%20(Custom).jpg"
                        }
                    },
                    new HostingUnit()
                    {
                        UnitName1="שירת הצימר ",
                        Rooms1 = 2,
                        IsSwimmingPool1=true,
                        AllOrders=new List <DateTime>(),
                        Uris=new List<string>()
                        {
                            "https://pic.rrr.co.il/images/pninashelmakom/254%20(Custom).jpg",
                            "https://pic.rrr.co.il/images/pninashelmakom/284%20(Custom).jpg",
                            "https://pic.rrr.co.il/images/pninashelmakom/262%20(Custom).jpg"
                        }
                    },

                    new HostingUnit()
                    {
                        UnitName1="שירת הגולן",
                        Rooms1 = 1,
                        IsSwimmingPool1=true,
                        AllOrders=new List <DateTime>(),
                        Uris=new List<string>()
                        {
                            "https://pic.rrr.co.il/images/ahuzabash/69%20(Custom).jpg",
                            "https://pic.rrr.co.il/images/ahuzabash/11%20(Custom).jpg"
                        }
                    }
                }
            }
        };
            InitializeComponent();
            cbHostList.ItemsSource = hostsList;
            cbHostList.DisplayMemberPath = "HostName";
            cbHostList.SelectedIndex = 0;
        }

        private void InitializeHost(int index)
        {
            MainGrid.Children.RemoveRange(1, 3);
            currentHost = hostsList[index];
            UpGrid.DataContext = currentHost;
            for (int i = 0; i < currentHost.Units1.Count; i++)
            {
                HostingUnitUserControl a = new HostingUnitUserControl(currentHost.Units1[i]);
                MainGrid.Children.Add(a);
                Grid.SetRow(a, i + 1);
            }
        }
        private void cbHostList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            InitializeHost(cbHostList.SelectedIndex);
        }

    }
}
