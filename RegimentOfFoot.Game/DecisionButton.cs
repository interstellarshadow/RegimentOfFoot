using System;
using Xwt;

namespace RegimentOfFoot.Game
{
	public class DecisionButton : Button
	{
		public DecisionButton()
			: base()
		{
			this.Style = ButtonStyle.Borderless;
		}

		public DecisionButton(string label)
			: this()
		{
			this.Label = label;
		}



	}
}

