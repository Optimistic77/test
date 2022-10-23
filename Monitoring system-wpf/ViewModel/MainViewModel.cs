using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UiDesign.ViewModel
{
    public class MainViewModel
    {
        public MainViewModel()
        {
            Init();
        }

        public ObservableCollection<ModuleInfo> Modules { get; set; }
        public ObservableCollection<UserModel> GridModelList { get; set; }


        private void Init()
        {
            Modules = new ObservableCollection<ModuleInfo>();
            Modules.Add(new ModuleInfo() { IconFont = "\xe637", Title = "实时状态监测" });
            Modules.Add(new ModuleInfo() { IconFont = "\xe63a", Title = "历史报警记录" });
            Modules.Add(new ModuleInfo() { IconFont = "\xe604", Title = "报警处理记录" });
            Modules.Add(new ModuleInfo() { IconFont = "\xe711", Title = "设备数据查询" });
            Modules.Add(new ModuleInfo() { IconFont = "\xe638", Title = "设备管理后台" });
            Modules.Add(new ModuleInfo() { IconFont = "\xe622", Title = "软件系统设置" });
            Modules.Add(new ModuleInfo() { IconFont = "\xe607", Title = "软件使用说明" });
            Modules.Add(new ModuleInfo() { IconFont = "\xe63b", Title = "奥美公司介绍" });
        }

    }
}
