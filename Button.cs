using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Mediator
{
	internal class Button : UIControll
	{
		public bool _isEnabled;
		public Button(DialogBoxMediator owner) : base(owner)
		{
		}
		public bool IsEnabled()
		{
			return _isEnabled;
		}
		public void SetEnabled(bool enabled)
		{
			_isEnabled = enabled;
			_owner.Changed(this);
		}
	}
}
