namespace Tyuiu.ShakirovaGM.Sprint7.Project.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonInfo_SGM_Click(object sender, EventArgs e)
        {
            FormInfo formInfo = new FormInfo();
            formInfo.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonGoFormBooks_SGM_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormBooksInfo formBooksInfo = new FormBooksInfo();
            formBooksInfo.ShowDialog();
        }

        private void buttonGoFormPeopleInfo_SGM_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPeopleInfo formPeopleInfo = new FormPeopleInfo();
            formPeopleInfo.ShowDialog();
        }
    }
}
