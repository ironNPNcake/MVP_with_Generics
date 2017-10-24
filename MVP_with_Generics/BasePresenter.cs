using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVP_with_Generics
{
    public abstract class BasePresenter<TView>:IBasePresenter<TView> where TView : IBaseView
    {
        public abstract TView View { get; set; }

    }
}