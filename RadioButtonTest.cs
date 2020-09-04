using System;
using System.Windows.Forms;

namespace VariousTesting
{
	class RadioButtonTest : Test
	{
		public RadioButtonTest(GroupBox group, string question, string[] possible_answers, int correct_index) :
			base(group, question, possible_answers, correct_index, -1) { }
		public override bool IsCorrect => (int)correct_answer == (int)current_answer;
		public override void UpdateControl()
		{
			int i = 0;
			foreach (RadioButton radio in Ctrl.Controls)
				if (i < possible_answers.Length)
				{
					radio.Visible = true;
					radio.Checked = i == (int)current_answer;
					radio.Text = possible_answers[i++];
				}
				else radio.Visible = false;
		}
		public override void AnswerChanged(object sender)
			=> current_answer = Ctrl.Controls.IndexOf(sender as RadioButton);
	}
}
