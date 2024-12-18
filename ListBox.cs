using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Mediator
{
	internal class ListBox : UIControll
	{
		private string _selection = "";
		public ListBox(DialogBoxMediator owner) : base(owner) { }
		public string GetSelection()
		{
			return _selection;
		}
		public void SetSelection(string selection)
		{
			_selection = selection;
			//notify to its owner change of the value
			//passing the entire object
			_owner.Changed(this);
		}
	}
}
