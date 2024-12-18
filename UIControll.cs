namespace Behavioral_Mediator
{
	public class UIControll
	{
		//group of ui component
		//all ui component can be grouped 
		//every ui can talk and know its owner
		//every single uicomponent need a single mediator owner
		protected DialogBoxMediator _owner;

		public UIControll(DialogBoxMediator owner)
		{
			_owner = owner;
		}
	}
}