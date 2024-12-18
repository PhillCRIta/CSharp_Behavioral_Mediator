using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Mediator
{
	public abstract class DialogBoxMediator
	{
		//THIS IS A MEDIATOR - abstract - will be concretize in PostDialogBox class
		//dialog box is the center of the system
		//fileds for all UI component
		public abstract void Changed(UIControll uiControll);
	}
}
