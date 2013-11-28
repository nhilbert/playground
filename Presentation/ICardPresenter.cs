using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground.Presentation
{
    public interface ICardPresenter
    {
        void RegisterView(ICardView migView);
        void Next();

    }
}
