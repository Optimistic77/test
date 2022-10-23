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

namespace UiDesign
{
    /// <summary>
    /// usCC.xaml 的交互逻辑
    /// </summary>
    
    public partial class usCC : UserControl
    {
       
        public usCC()
        {
            InitializeComponent();
            //var GridModelList = new List<UserModel>();
            //GridModelList.Add(new UserModel() { 使用单位 = "Vaughan", 应用场景 = "Delaware", 设备编号 = "jack163@outlook.com", 运行状态 = "Quality inspector", 实时阀位 = "S1", BackColor = "#FF7000" });
            //GridModelList.Add(new UserModel() { 使用单位 = "Abbey", 应用场景 = "Florida", 设备编号 = "jack163@outlook.com", 运行状态 = "Quality inspector", 实时阀位 = "S2", BackColor = "#FFC100" });
            //GridModelList.Add(new UserModel() { 使用单位 = "Dahlia", 应用场景 = "Illinois", 设备编号 = "jack163@outlook.com", 运行状态 = "Quality inspector", 实时阀位 = "S1", BackColor = "#FF7000" });
            //GridModelList.Add(new UserModel() { 使用单位 = "Fallon", 应用场景 = "Tennessee", 设备编号 = "jack163@outlook.com", 运行状态 = "Quality inspector", 实时阀位 = "S3", BackColor = "#59E6B5" });
            //GridModelList.Add(new UserModel() { 使用单位 = "Hannah", 应用场景 = "Washington", 设备编号 = "jack163@outlook.com", 运行状态 = "Quality inspector", 实时阀位 = "S4", BackColor = "#FFC100" });
            //GridModelList.Add(new UserModel() { 使用单位 = "Laura", 应用场景 = "Mississippi", 设备编号 = "jack163@outlook.com", 运行状态 = "Quality inspector", 实时阀位 = "S2", BackColor = "#59E6B5" });
            //GridModelList.Add(new UserModel() { 使用单位 = "Lauren", 应用场景 = "Wyoming", 设备编号 = "jack163@outlook.com", 运行状态 = "Quality inspector", 实时阀位 = "S3", BackColor = "#FFC100" });
            //datagrid.ItemsSource = GridModelList;

        }
        public string data { get; set; }
    }
}
