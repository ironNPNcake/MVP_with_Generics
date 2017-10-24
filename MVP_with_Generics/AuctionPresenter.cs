using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace MVP_with_Generics
{
    public class AuctionPresenter : BasePresenter<IBaseView>
    {
        //IBaseView IBasePresenter<IBaseView>.View { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        // protected override WebForm1 view { get; set; }
        private WebForm1 view { get; set; }
        public override IBaseView View
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
             view.Alfa = "siema";
        }
        public void ChangeLabel()
        {
            view.Labeleczka.Text = "siemaneczkodupeczko";
        }
    }
}