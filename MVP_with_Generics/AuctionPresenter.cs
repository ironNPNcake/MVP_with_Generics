using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace MVP_with_Generics
{
    public class AuctionPresenter :BasePresenter<WebForm1>
    {
        //IBaseView IBasePresenter<IBaseView>.View { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override WebForm1 View { get; set; }

        public IBaseView view
        {
            get
            {
                return view;
            }
            set
            {
                view = value as WebForm1;
            }
        }
        
        public void ChangeAlfa()
        {
           // view.alfa = "siema";
        }
        public void changeLabel()
        {
           // System.Web.UI.WebControls.Label abc = view.Labeleczka;
            //abc.Text = "siemaneczkodupeczko";
        }
    }
}