using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeons_DragonsCharacterBuilder.ViewModels
{
    class ShellViewModel : Conductor<object>
    {
        public ShellViewModel()
        {
            LoadTitleScreen();
        }
        
        public void LoadTitleScreen()
        {
            ActivateItem(new BondsFlawsIdealsViewModel());
        }
    }
}
