using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;

namespace dxSample
{
    public class ViewModel: ViewModelBase
    {
        [Command]
        public void OpenWorkspace() {
            System.Diagnostics.Debug.WriteLine("Test");
        }
    }
}
