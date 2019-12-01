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
        public MainWindow()
        {
            List<Host> hostsList = new List<Host>()
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
                            "https://www.google.com/url?sa=i&source=images&cd=&ved=2ahUKEwjau57Wg5XmAhW2AWMBHfTiB_8QjRx6BAgBEAQ&url=https%3A%2F%2Fzimmernorth.co.il%2F&psig=AOvVaw3GnrsZ7WH7AqisDVvTCV-7&ust=1575309550136642",
                            "https://www.google.com/imgres?imgurl=https%3A%2F%2Fwww.weekend-family.co.il%2Fimages%2Fcustomerimages%2F24006%2Fgallery%2Fimage_24006_1.jpg&imgrefurl=https%3A%2F%2Fwww.weekend-family.co.il%2Fvac_north&docid=9ra-ozaktvLJQM&tbnid=-D7zAAR3Uk1cBM%3A&vet=10ahUKEwjQ2KPCg5XmAhU18uAKHSLABfAQMwiTASg2MDY..i&w=1350&h=900&safe=active&bih=969&biw=1920&q=%D7%A6%D7%99%D7%9E%D7%A8%20%D7%91%D7%A6%D7%A4%D7%95%D7%9F&ved=0ahUKEwjQ2KPCg5XmAhU18uAKHSLABfAQMwiTASg2MDY&iact=mrc&uact=8"
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
                            "https://www.google.com/imgres?imgurl=https%3A%2F%2Fimg.mako.co.il%2F2014%2F12%2F16%2FAchuza1_i.jpg&imgrefurl=https%3A%2F%2Fwww.mako.co.il%2Ftravel-israel%2Fleisure-c9fb1f3ee2bc8110%2FArticle-2c78ca990e15a41006.htm&docid=HUMls6dEMhKspM&tbnid=OuTBRQ-MOwDOLM%3A&vet=10ahUKEwjQ2KPCg5XmAhU18uAKHSLABfAQMwhXKAgwCA..i&w=624&h=383&safe=active&bih=969&biw=1920&q=%D7%A6%D7%99%D7%9E%D7%A8%20%D7%91%D7%A6%D7%A4%D7%95%D7%9F&ved=0ahUKEwjQ2KPCg5XmAhU18uAKHSLABfAQMwhXKAgwCA&iact=mrc&uact=8",
                            "https://www.google.com/imgres?imgurl=https%3A%2F%2Fwww.amirimspa.com%2Fwp-content%2Fuploads%2F2018%2F07%2FQ21A2923-3.jpg&imgrefurl=https%3A%2F%2Fwww.amirimspa.com%2F&docid=ilbpWsZaBqKi9M&tbnid=GIxkRF6z4-zAlM%3A&vet=10ahUKEwjQ2KPCg5XmAhU18uAKHSLABfAQMwiGASgpMCk..i&w=960&h=640&safe=active&bih=969&biw=1920&q=%D7%A6%D7%99%D7%9E%D7%A8%20%D7%91%D7%A6%D7%A4%D7%95%D7%9F&ved=0ahUKEwjQ2KPCg5XmAhU18uAKHSLABfAQMwiGASgpMCk&iact=mrc&uact=8",
                            "https://www.google.com/url?sa=i&source=images&cd=&ved=2ahUKEwj5s4L3hJXmAhUOA2MBHbmHD0YQjRx6BAgBEAQ&url=https%3A%2F%2Fwww.weekendtop.co.il%2Fzimmers_north&psig=AOvVaw3GnrsZ7WH7AqisDVvTCV-7&ust=1575309550136642"
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
                            "https://www.google.com/imgres?imgurl=https%3A%2F%2Fwww.weekend-family.co.il%2Fimages%2Fcustomerimages%2F20887%2Fgallery%2Fimage_20887_31.jpg&imgrefurl=https%3A%2F%2Fwww.weekend-family.co.il%2Fvac_mashabey-sade_darom&docid=DsXAqaYSQlYrKM&tbnid=dWOS7tezZUxUcM%3A&vet=10ahUKEwjCsdf-hZXmAhUyAWMBHRqCDsUQMwhSKA0wDQ..i&w=1024&h=683&safe=active&bih=969&biw=1920&q=%D7%A6%D7%99%D7%9E%D7%A8%20%D7%91%D7%93%D7%A8%D7%95%D7%9D&ved=0ahUKEwjCsdf-hZXmAhUyAWMBHRqCDsUQMwhSKA0wDQ&iact=mrc&uact=8",
                            "https://www.google.com/imgres?imgurl=https%3A%2F%2Fwww.irooms.co.il%2Fgallery%2F1455535319449732jpeg%2F280x2301455535319449732.jpeg&imgrefurl=https%3A%2F%2Fwww.irooms.co.il%2F%25D7%25A6%25D7%2599%25D7%259E%25D7%25A8%25D7%2599%25D7%259D%2B%25D7%2591%25D7%2593%25D7%25A8%25D7%2595%25D7%259D%2B%25D7%259C%25D7%2593%25D7%25AA%25D7%2599%25D7%2599%25D7%259D.html&docid=i-TmgYBMo9NP-M&tbnid=IgldZzUmV80chM%3A&vet=10ahUKEwjCsdf-hZXmAhUyAWMBHRqCDsUQMwijAShRMFE..i&w=280&h=200&safe=active&bih=969&biw=1920&q=%D7%A6%D7%99%D7%9E%D7%A8%20%D7%91%D7%93%D7%A8%D7%95%D7%9D&ved=0ahUKEwjCsdf-hZXmAhUyAWMBHRqCDsUQMwijAShRMFE&iact=mrc&uact=8",
                            "https://www.google.com/imgres?imgurl=https%3A%2F%2Fwww.dayuse.org.il%2Fdayuse%2F28_1474439062(1).jpg&imgrefurl=https%3A%2F%2Fwww.dayuse.org.il%2F%25D7%25A6%25D7%2599%25D7%259E%25D7%25A8%25D7%2599%25D7%259D%2B%25D7%259C%25D7%25A4%25D7%2599%2B%25D7%25A9%25D7%25A2%25D7%2595%25D7%25AA%2B%25D7%2591%25D7%2593%25D7%25A8%25D7%2595%25D7%259D.html&docid=vtc_hk8eFpHZ3M&tbnid=Z0ZZCI-xqQ0Z8M%3A&vet=10ahUKEwjCsdf-hZXmAhUyAWMBHRqCDsUQMwiYAShGMEY..i&w=400&h=264&safe=active&bih=969&biw=1920&q=%D7%A6%D7%99%D7%9E%D7%A8%20%D7%91%D7%93%D7%A8%D7%95%D7%9D&ved=0ahUKEwjCsdf-hZXmAhUyAWMBHRqCDsUQMwiYAShGMEY&iact=mrc&uact=8"
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
                            "https://www.google.com/imgres?imgurl=https%3A%2F%2Fwww.familyzimer.co.il%2Fgallery%2F149121207451_600x500.jpg&imgrefurl=https%3A%2F%2Fwww.familyzimer.co.il%2Fnorth%2Fgolan.html&docid=QvVesshA9TkgPM&tbnid=_9Ht4zMlOEcYUM%3A&vet=10ahUKEwjz6p-qh5XmAhVOcBQKHaRSD2wQMwhXKBIwEg..i&w=556&h=371&safe=active&bih=969&biw=1920&q=%D7%A6%D7%99%D7%9E%D7%A8%20%D7%91%D7%92%D7%95%D7%9C%D7%9F&ved=0ahUKEwjz6p-qh5XmAhVOcBQKHaRSD2wQMwhXKBIwEg&iact=mrc&uact=8",
                            "https://www.google.com/imgres?imgurl=https%3A%2F%2Fwww.zimmer.co.il%2Fzhoney1%2FDSC_8498-Edit.jpg&imgrefurl=https%3A%2F%2Fwww.zimmer.co.il%2Fpremium.asp%3Fsite_id%3D2069&docid=03Sn3seN72FdRM&tbnid=a3UMlb7y0hcKBM%3A&vet=10ahUKEwjz6p-qh5XmAhVOcBQKHaRSD2wQMwhrKBkwGQ..i&w=1024&h=655&safe=active&bih=969&biw=1920&q=%D7%A6%D7%99%D7%9E%D7%A8%20%D7%91%D7%92%D7%95%D7%9C%D7%9F&ved=0ahUKEwjz6p-qh5XmAhVOcBQKHaRSD2wQMwhrKBkwGQ&iact=mrc&uact=8"
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
                            "https://www.google.com/imgres?imgurl=http%3A%2F%2Fimages.mapa.co.il%2Fdatafiles%2Fphotos%2Fpics%2F2_93309_1.jpg&imgrefurl=http%3A%2F%2Fwww.mapa.co.il%2Fgeneral%2Ftextsearchresult_locked.asp%3FtextSearch%3D%25EC%25E9%25F0%25E4%2B%2B%25F6%25E9%25EE%25F8%2B%25E1%25E2%25E5%25EC%25EF%26textSearchWhere%3D%26First%3D1&docid=SIVfWMdIb4i-HM&tbnid=JKgAn1J1uvTNtM%3A&vet=10ahUKEwjz6p-qh5XmAhVOcBQKHaRSD2wQMwhKKAUwBQ..i&w=550&h=367&safe=active&bih=969&biw=1920&q=%D7%A6%D7%99%D7%9E%D7%A8%20%D7%91%D7%92%D7%95%D7%9C%D7%9F&ved=0ahUKEwjz6p-qh5XmAhVOcBQKHaRSD2wQMwhKKAUwBQ&iact=mrc&uact=8",
                            "https://www.google.com/imgres?imgurl=https%3A%2F%2Flookaside.fbsbx.com%2Flookaside%2Fcrawler%2Fmedia%2F%3Fmedia_id%3D180918428607996&imgrefurl=https%3A%2F%2Fes-la.facebook.com%2Fpages%2Fcategory%2FHotel-Resort%2Fbagolan%2Fposts%2F&docid=HX76MYvJ3PSxcM&tbnid=It2BaWObdTK0HM%3A&vet=10ahUKEwjz6p-qh5XmAhVOcBQKHaRSD2wQMwizAShgMGA..i&w=500&h=375&safe=active&bih=969&biw=1920&q=%D7%A6%D7%99%D7%9E%D7%A8%20%D7%91%D7%92%D7%95%D7%9C%D7%9F&ved=0ahUKEwjz6p-qh5XmAhVOcBQKHaRSD2wQMwizAShgMGA&iact=mrc&uact=8",
                            "https://www.google.com/imgres?imgurl=http%3A%2F%2Fimg.b144websites.co.il%2FServices%2FImage.ashx%3FFile%3D481D041A4073095F49150D7F4475095F4C780210427961594B10061B41726758481603105A2A250A%26w%3D-1%26h%3D420%26typ%3D1&imgrefurl=http%3A%2F%2Fwww.betzelhapekan.co.il%2F&docid=zB0WPdm9JEwm0M&tbnid=jgHYvlcacsZyYM%3A&vet=12ahUKEwjkzdiLiJXmAhU2QhUIHTLZCaI4ZBAzKAYwBnoECAEQBw..i&w=560&h=420&safe=active&bih=969&biw=1920&q=%D7%A6%D7%99%D7%9E%D7%A8%20%D7%91%D7%92%D7%95%D7%9C%D7%9F&ved=2ahUKEwjkzdiLiJXmAhU2QhUIHTLZCaI4ZBAzKAYwBnoECAEQBw&iact=mrc&uact=8"
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
                            "https://www.google.com/imgres?imgurl=https%3A%2F%2Fstatic.wixstatic.com%2Fmedia%2F7fc814_0212e61041c94e8394a8498b38c7bbba~mv2_d_5304_3540_s_4_2.jpg%2Fv1%2Ffill%2Fw_560%2Ch_572%2Cal_c%2Cq_80%2Cusm_0.66_1.00_0.01%2F7fc814_0212e61041c94e8394a8498b38c7bbba~mv2_d_5304_3540_s_4_2.webp&imgrefurl=https%3A%2F%2Fwww.karmabagolan.co.il%2Fcopy-of-4&docid=4BDSqg56ynH3sM&tbnid=FZfL3dM0eSt1VM%3A&vet=10ahUKEwjz6p-qh5XmAhVOcBQKHaRSD2wQMwiTAShBMEE..i&w=560&h=572&safe=active&bih=969&biw=1920&q=%D7%A6%D7%99%D7%9E%D7%A8%20%D7%91%D7%92%D7%95%D7%9C%D7%9F&ved=0ahUKEwjz6p-qh5XmAhVOcBQKHaRSD2wQMwiTAShBMEE&iact=mrc&uact=8",
                            "https://www.google.com/imgres?imgurl=https%3A%2F%2Fwww.familyzimer.co.il%2Fgallery%2F154382569202_600x500.jpg&imgrefurl=https%3A%2F%2Fwww.familyzimer.co.il%2Fnorth%2Fgolan.html&docid=QvVesshA9TkgPM&tbnid=vtBffELEqRgLcM%3A&vet=10ahUKEwjz6p-qh5XmAhVOcBQKHaRSD2wQMwixASheMF4..i&w=600&h=400&safe=active&bih=969&biw=1920&q=%D7%A6%D7%99%D7%9E%D7%A8%20%D7%91%D7%92%D7%95%D7%9C%D7%9F&ved=0ahUKEwjz6p-qh5XmAhVOcBQKHaRSD2wQMwixASheMF4&iact=mrc&uact=8"
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
