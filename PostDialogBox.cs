using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Mediator
{
	//concrete mediator
	internal class PostDialogBox : DialogBoxMediator
	{
		//the following list contains all fileds for our UI Component.
		private ListBox _postListBox;
		private TextBox _titleTextBox;
		private Button _saveButton;

		public PostDialogBox()
		{
			//PostDialogBox store a reference to all UI Component 
			//PostDialoxBox can exixts without ui component; is associated with
			//empty arrow on uml diagram
			//each components are uncoupled with each other
			_postListBox = new ListBox(this);
			_titleTextBox = new TextBox(this);
			_saveButton = new Button(this);
			_saveButton.SetEnabled(false);
		}

		public void SimulateUserInteraction()
		{
			Console.WriteLine("I'm simulating post selection.");
			_postListBox.SetSelection("Post 2");
			HowsSituation();
			Console.WriteLine("I'm deleting title");
			_titleTextBox.SetText("");
			HowsSituation();
			Console.WriteLine("I've inserted new title");
			_titleTextBox.SetText("Hello Spank");
			HowsSituation();
		}
		public override void Changed(UIControll uiControll)
		{
			if (uiControll == _postListBox)
			{
				handlePostChanged();
			}
			else if (uiControll == _titleTextBox)
			{
				handleTitleChange();
			}
		}
		private void HowsSituation()
		{
			Console.WriteLine("Title text box text: " + _titleTextBox.GetText());
			Console.WriteLine("Button enabled: " + _saveButton.IsEnabled());
		}
		private void handleTitleChange()
		{
			bool isTitleEmpty = String.IsNullOrEmpty(_titleTextBox.GetText());
			_saveButton.SetEnabled(!isTitleEmpty);
		}

		private void handlePostChanged()
		{
			_titleTextBox.SetText(_postListBox.GetSelection());
			_saveButton.SetEnabled(false);
		}
	}
}
