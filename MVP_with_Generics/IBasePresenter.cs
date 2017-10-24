using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_with_Generics
{
    public interface IBasePresenter<TView> where TView:IBaseView
    {
        TView View { get; set; }
    }
}
