using Ex.Command.RedoUndo.Commands;

namespace Ex.Command.RedoUndo
{
    public partial class Form1 : Form
    {
        private InvokerEditText _invokerEditText;
        public Form1()
        {
            _invokerEditText = new InvokerEditText();
            InitializeComponent();
        }

        private void undo_btn_Click(object sender, EventArgs e)
        {
            result_lbl.Text = _invokerEditText.Undo();
        }

        private void setText_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("please enter your text");
            }

            result_lbl.Text = _invokerEditText.ExecuteCommand(textBox1.Text);
            textBox1.Text = "";
        }

        private void redo_btn_Click(object sender, EventArgs e)
        {
            result_lbl.Text = _invokerEditText.Redo();

        }
    }
}
