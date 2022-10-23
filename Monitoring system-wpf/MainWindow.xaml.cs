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
using System.Windows.Threading;
using UiDesign.ViewModel;
using LiveCharts.Wpf;
using LiveCharts;

namespace UiDesign
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new MainViewModel();
            //var GridModelList = new List<UserModel>();
            //GridModelList.Add(new UserModel() { 使用单位 = "Vaughan", 应用场景 = "Delaware", 设备编号 = "jack163@outlook.com", 运行状态 = "Quality inspector", 实时阀位 = "S1", BackColor = "#FF7000" });
            //GridModelList.Add(new UserModel() { 使用单位 = "Abbey", 应用场景 = "Florida", 设备编号 = "jack163@outlook.com", 运行状态 = "Quality inspector", 实时阀位 = "S2", BackColor = "#FFC100" });
            //GridModelList.Add(new UserModel() { 使用单位 = "Dahlia", 应用场景 = "Illinois", 设备编号 = "jack163@outlook.com", 运行状态 = "Quality inspector", 实时阀位 = "S1", BackColor = "#FF7000" });
            //GridModelList.Add(new UserModel() { 使用单位 = "Fallon", 应用场景 = "Tennessee", 设备编号 = "jack163@outlook.com", 运行状态 = "Quality inspector", 实时阀位 = "S3", BackColor = "#59E6B5" });
            //GridModelList.Add(new UserModel() { 使用单位 = "Hannah", 应用场景 = "Washington", 设备编号 = "jack163@outlook.com", 运行状态 = "Quality inspector", 实时阀位 = "S4", BackColor = "#FFC100" });
            //GridModelList.Add(new UserModel() { 使用单位 = "Laura", 应用场景 = "Mississippi", 设备编号 = "jack163@outlook.com", 运行状态 = "Quality inspector", 实时阀位 = "S2", BackColor = "#59E6B5" });
            //GridModelList.Add(new UserModel() { 使用单位 = "Lauren", 应用场景 = "Wyoming", 设备编号 = "jack163@outlook.com", 运行状态 = "Quality inspector", 实时阀位 = "S3", BackColor = "#FFC100" });
            var GridModelList = new List<UserModel>();
            GridModelList.Add(new UserModel() { 使用单位 = "天津奥美自动化", 应用场景 = "测试设备", 设备编号 = "AM2012788", 运行状态 = "现场待机", 实时阀位 = "35.5%", 维护等级 = "#59E6B5", 开关次数 = "52", 振动参数 = "0.74g/20Hz" });
            GridModelList.Add(new UserModel() { 使用单位 = "中海油燃气三河分公司", 应用场景 = "天然气行业", 设备编号 = "AM2012789", 运行状态 = "远程关运行", 实时阀位 = "69.7%", 维护等级 = "#59E6B5", 开关次数 = "284", 振动参数 = "0.75g/180Hz" });
            GridModelList.Add(new UserModel() { 使用单位 = "中石化天津分公司", 应用场景 = "石化行业", 设备编号 = "AM2012790", 运行状态 = "远程开运行", 实时阀位 = "29.7%", 维护等级 = "#59E6B5", 开关次数 = "84", 振动参数 = "0.75g/180Hz" });
            GridModelList.Add(new UserModel() { 使用单位 = "上海宝钢", 应用场景 = "钢铁制造业", 设备编号 = "AM2012791", 运行状态 = "远程关运行", 实时阀位 = "69.7%", 维护等级 = "#59E6B5", 开关次数 = "84", 振动参数 = "0.85g/480Hz" });
            GridModelList.Add(new UserModel() { 使用单位 = "上海宝钢", 应用场景 = "钢铁制造业", 设备编号 = "AM2012792", 运行状态 = "现场开运行", 实时阀位 = "31.7%", 维护等级 = "#59E6B5", 开关次数 = "184", 振动参数 = "0.25g/402Hz" });
            GridModelList.Add(new UserModel() { 使用单位 = "沈阳鼓风集团", 应用场景 = "煤炭行业", 设备编号 = "AM2012786", 运行状态 = "设备离线", 实时阀位 = " —— ", 维护等级 = "#FF7000", 开关次数 = "228", 振动参数 = "0.75g/96Hz" });
            GridModelList.Add(new UserModel() { 使用单位 = "沈阳鼓风集团", 应用场景 = "煤炭行业", 设备编号 = "AM2012797", 运行状态 = "阀门关过力矩", 实时阀位 = " 0% ", 维护等级 = "#FF7000", 开关次数 = "128", 振动参数 = "1.75g/96Hz" });
            GridModelList.Add(new UserModel() { 使用单位 = "连云港石化有限公司", 应用场景 = "石化行业", 设备编号 = "AM2012795", 运行状态 = "远程待机", 实时阀位 = "100%", 维护等级 = "#FFC100", 开关次数 = "576", 振动参数 = "0.48g/199Hz" });
            GridModelList.Add(new UserModel() { 使用单位 = "连云港石化有限公司", 应用场景 = "石化行业", 设备编号 = "AM2012796", 运行状态 = "现场关运行", 实时阀位 = "30.9%", 维护等级 = "#59E6B5", 开关次数 = "176", 振动参数 = "1.38g/99Hz" });
            GridModelList.Add(new UserModel() { 使用单位 = "山西左权焦化", 应用场景 = "焦化行业", 设备编号 = "AM2012799", 运行状态 = "阀门开过力矩", 实时阀位 = "12.8%", 维护等级 = "#FF7000", 开关次数 = "257", 振动参数 = "0.57g/457Hz" });
            GridModelList.Add(new UserModel() { 使用单位 = "山西左权焦化", 应用场景 = "焦化行业", 设备编号 = "AM2012800", 运行状态 = "远程待机", 实时阀位 = "62.8%", 维护等级 = "#FFC100", 开关次数 = "57", 振动参数 = "2.57g/472Hz" });
            GridModelList.Add(new UserModel() { 使用单位 = "四平自来水公司", 应用场景 = "城市供水", 设备编号 = "AM2012753", 运行状态 = "阀门温度过高", 实时阀位 = "45.8%", 维护等级 = "#59E6B5", 开关次数 = "985", 振动参数 = "2.24g/24Hz" });
            datagrid.ItemsSource = GridModelList;
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(500);
            timer.Tick += timer_Tick;
            timer.Start();
            //表格样式设置
           //chart1.
        }
        void timer_Tick(object sender,EventArgs e)
        {
            datetime.Text = DateTime.Now.ToString();
        }

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Menu_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }
        private void 窗口最大化(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Maximized)
            {
                this.WindowState = WindowState.Normal;
            }
            else
            {
                this.WindowState = WindowState.Maximized;

            }

        }

        private void 窗口最小化(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void 窗口帮助(object sender, RoutedEventArgs e)
        {

        }

        private void 关闭窗口(object sender, RoutedEventArgs e)
        {
            System.Environment.Exit(0);//退出系统
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ButtonState == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }
    }
}
