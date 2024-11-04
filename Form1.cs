namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SendBTN_Click(object sender, EventArgs e)
        {
            if (!conditionsCheckBox.Checked)
            {
                MessageBox.Show("���������� �������� � ��������� �������.");
                return;
            }

            string name = Name_textBox.Text;
            string surname = Surname_textBox2.Text;
            string eventType = comboBoxEventType.SelectedItem?.ToString() ?? "�� �������";
            string date = eventCalendar.SelectionRange.Start.ToShortDateString();
            string time = Event_dateTimePicker.Value.ToShortTimeString();
            string format = radioBtn_Online.Checked ? "������" : "�������";

            MessageBox.Show($"����������� �������!\n\n���: {name}\n�������: {surname}\n������: {format}\n�������: {eventType}\n����: {date}\n�����: {time}");
        }
        private void ClearBTN_Click(object sender, EventArgs e)
        {
            Name_textBox.Text = "";
            Surname_textBox2.Text = "";
            Email_textBox3.Text = "";
            textBox4.Text = "";
            comboBoxEventType.SelectedIndex = -1;
            eventCalendar.SetDate(DateTime.Today);
            Event_dateTimePicker.Value = DateTime.Now;
            radioBtn_Online.Checked = false;
            radioBtn_Offline.Checked = false;
            for (int i = 0; i < checkedListBox.Items.Count; i++)
                checkedListBox.SetItemChecked(i, false);
            conditionsCheckBox.Checked = false;
        }
        private void conditionsCheckBox_CheckedChanged(object sender, EventArgs e)
        { }
        private void Name_textBox_TextChanged(object sender, EventArgs e)
        { }
        private void Surname_textBox2_TextChanged(object sender, EventArgs e)
        { }
        private void Email_textBox3_TextChanged(object sender, EventArgs e)
        { }
        private void textBox4_TextChanged(object sender, EventArgs e)
        { }
        private void comboBoxEventType_SelectedIndexChanged(object sender, EventArgs e)
        { }
        private void radioBtn_Offline_CheckedChanged(object sender, EventArgs e)
        { }
        private void checkedListBox_SelectedIndexChanged(object sender, EventArgs e)
        { }
    }
}
