using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MVP_with_Generics
{
    public partial class Wera : BaseView<WeraPresenter>
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                AttachPresenter();
        }

        protected void btnW_Click(object sender, EventArgs e)
        {
            AttachPresenter();
            _presenter.zmientekst();
                }
        public Button getButton
        {
            get => btnW;
        }
        public Label getLbl
        {
            get => tutajtekst;
        }
    }
}