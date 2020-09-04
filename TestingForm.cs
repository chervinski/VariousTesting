using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace VariousTesting
{
	public partial class TestingForm : Form
	{
		private Test[] tests;
		private GroupBox radios = new GroupBox(), checks = new GroupBox();
		private TextBox text = new TextBox();
		private int current_test_index = 0;
		public TestingForm()
		{
			InitializeComponent();
			tests = new Test[] {
				new RadioButtonTest(radios, "C# class can inherit multiple . . .", new string[] { "classes", "interfaces", "abstract classes", "static classes" }, 1),
				new CheckBoxTest(checks, "Which of the following can contain null in C#?", new string[] { "int", "int?", "int[]", "Int32" }, new int[] { 1, 2 }),
				new RadioButtonTest(radios, "Is this statement correct in C#: \"Private members of the base class are visible in the derived class if the derived class is nested in its base class\"?", new string[] { "Yes", "No" }, 0),
				new TextBoxTest(text, "What is the default value for built-in integral and floating-point numeric types in C#?", "0"),
				new CheckBoxTest(checks, "Which of the following are structures but not classes in C#?", new string[] { "int", "double", "string" }, new int[] { 0, 1 })
			};

			radios.Controls.AddRange(new RadioButton[4] { new RadioButton(), new RadioButton(), new RadioButton(), new RadioButton() });
			checks.Controls.AddRange(new CheckBox[4] { new CheckBox(), new CheckBox(), new CheckBox(), new CheckBox() });
			radios.Location = checks.Location = text.Location = new Point(prev.Location.X, question.Location.Y + question.Height + 10);
			radios.Size = checks.Size = new Size(Width - radios.Location.X, Height - radios.Location.Y);
			
			GroupBox group = radios;
			for (int i = 0, y = 0; i < 2; ++i, y = 0, group = checks)
				foreach (Control control in group.Controls)
				{
					control.Location = new Point(0, y);
					control.Width = Width - control.Location.X;
					control.Click += Box_Changed;
					y += control.Height + 10;
				}
			text.TextChanged += Box_Changed;

			Controls.Add(radios);
			Controls.Add(checks);
			Controls.Add(text);

			UpdateCurrentQuestion();
			prev.Visible = false;
		}
		private void UpdateCurrentQuestion()
		{
			count.Text = $"{current_test_index + 1} / {tests.Length}";
			question.Text = tests[current_test_index].Question;
			tests[current_test_index].Ctrl.Visible = true;
			tests[current_test_index].UpdateControl();
		}
		private void Box_Changed(object sender, EventArgs e)
		{
			tests[current_test_index].AnswerChanged(sender);
		}
		private void Button_Click(object sender, EventArgs e)
		{
			if ((sender as Button) == next && current_test_index == tests.Length - 1)
			{
				MessageBox.Show($"Correct answers: {tests.Count(t => t.IsCorrect)} / {tests.Length}");
				return;
			}
			tests[current_test_index].Ctrl.Visible = false;
			current_test_index += (sender as Button) == next ? 1 : -1;
			UpdateCurrentQuestion();
			prev.Visible = current_test_index != 0;
			next.Text = current_test_index != tests.Length - 1 ? "Next" : "Finish";
		}
	}
}
