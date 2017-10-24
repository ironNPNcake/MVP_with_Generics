using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVP_with_Generics
{
    public class WeraPresenter : BasePresenter<IBaseView>
    {
        private Wera mojaNajpiekniejsza;
        public override IBaseView View
        {
            get => mojaNajpiekniejsza;
            set => mojaNajpiekniejsza = value as Wera;
        }
        public void zmientekst()
        {
            mojaNajpiekniejsza.getLbl.Text = "KUba idzie jesc";
        }
    }
}