using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MVP_with_Generics
{
    public partial class WebForm1 : BaseView<AuctionPresenter>, IBaseView
    {
        //AuctionPresenter presenter; 
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
                AttachPresenter();
        }
        public String alfa
        {
            get
            {
                return "alfa";
            }
            set
            {
                alfa = value;
            }
        }
        public Label Labeleczka
        {
            get { return labelka; }
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            AttachPresenter();
            _presenter.changeLabel();
        }
    }
}