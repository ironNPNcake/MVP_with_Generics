using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVP_with_Generics
{
    public class BaseView<TPesenter> : System.Web.UI.Page, IBaseView where TPesenter : IBasePresenter<IBaseView>, new()
    {
        protected TPesenter _presenter;
        public void AttachPresenter()
        {
            _presenter = new TPesenter();
            _presenter.View = this;
        }
    }
}