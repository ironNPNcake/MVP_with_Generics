﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_with_Generics
{
    public interface IAuctionPresenter : IBasePresenter<IBaseView>
    {
        void ChangeLabel();
    }
}
