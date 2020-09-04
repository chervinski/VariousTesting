using System;
using System.Windows.Forms;

namespace VariousTesting
{
	abstract class Test
	{
		public Control Ctrl { get; }
		public string Question { get; }
		protected string[] possible_answers; // is used for RadioButton and CheckBox
		protected object correct_answer;
		protected object current_answer;
		protected Test(Control control, string question, string[] possible_answers, object correct_answer, object current_answer)
		{
			Ctrl = control;
			Question = question;
			this.possible_answers = possible_answers;
			this.correct_answer = correct_answer;
			this.current_answer = current_answer;
		}

		public abstract bool IsCorrect { get; }
		public abstract void UpdateControl();
		public abstract void AnswerChanged(object sender);
	}
}
