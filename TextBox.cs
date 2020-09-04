using System;
using System.Windows.Forms;

namespace VariousTesting
{
	class TextBoxTest : Test
	{
		public TextBoxTest(TextBox text_box, string question, string answer) :
			base(text_box, question, null, answer, null) { }
		public override bool IsCorrect
			=> string.Equals(correct_answer as string, current_answer as string, StringComparison.OrdinalIgnoreCase);
		public override void UpdateControl() => Ctrl.Text = current_answer as string;
		public override void AnswerChanged(object sender) => current_answer = (sender as TextBox).Text;
	}
}
