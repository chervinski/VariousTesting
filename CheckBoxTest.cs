using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace VariousTesting
{
	class CheckBoxTest : Test
	{
		public CheckBoxTest(GroupBox group, string question, string[] possible_answers, int[] correct_indexes) :
			base(group, question, possible_answers, correct_indexes, new List<int>()) { }
		public override bool IsCorrect
			=> (correct_answer as int[]).SequenceEqual((current_answer as List<int>).OrderBy(i => i));
		public override void UpdateControl()
		{
			int i = 0;
			foreach (CheckBox check in Ctrl.Controls)
				if (i < possible_answers.Length)
				{
					check.Visible = true;
					check.Checked = (current_answer as List<int>).Any(index => index == i);
					check.Text = possible_answers[i++];
				}
				else check.Visible = false;
		}
		public override void AnswerChanged(object sender)
		{
			if ((sender as CheckBox).Checked)
				 (current_answer as List<int>).Add   (Ctrl.Controls.IndexOf(sender as CheckBox));
			else (current_answer as List<int>).Remove(Ctrl.Controls.IndexOf(sender as CheckBox));
		}
	}
}
