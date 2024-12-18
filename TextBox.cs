using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Mediator
{
	internal class TextBox : UIControll
	{
		public string _text = "";
		public TextBox(DialogBoxMediator owner) : base(owner)
		{
		}

		public string GetText() => _text;
		public void SetText(string text)
		{
			_text = text;
			_owner.Changed(this);
		}
	}
}
