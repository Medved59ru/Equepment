using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Equepment
{
    public partial class MainForm : Form
    {
        SqlConnection sqlConnection;
        string duration;
        string sortby = "Date";

        public bool Cancel { get; private set; }

        public MainForm()
        {
            InitializeComponent();
            datePickAdd.Value = DateTime.Today;
            dtPickUpdate.Value = DateTime.Today;

        }
        #region Загрузка формы
        private async void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.database1DataSet.Users);
            string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\afigi\Desktop\курсовая\Equepment\Database1.mdf; Integrated Security = True";

            sqlConnection = new SqlConnection(connectionString);
            await sqlConnection.OpenAsync();
            string query = "SELECT * FROM TOOL1";
            SqlCommand command = new SqlCommand(query, sqlConnection);

            SqlDataReader reader = await command.ExecuteReaderAsync();

            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[6]);
                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
            }

            reader.Close();

            sqlConnection.Close();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);


        }
        #endregion

        #region  Работа с меню
        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
            this.Close();
        }
        #endregion

        #region Добавить запись в журнал
        private async void btnInsert_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbBoxBegH.Text) && !string.IsNullOrWhiteSpace(cmbBoxBegH.Text) &&
                !string.IsNullOrEmpty(cmbBoxBegM.Text) && !string.IsNullOrWhiteSpace(cmbBoxBegM.Text) &&
                !string.IsNullOrEmpty(cmbBoxEndH.Text) && !string.IsNullOrWhiteSpace(cmbBoxEndH.Text) &&
                !string.IsNullOrEmpty(cmbBoxEndM.Text) && !string.IsNullOrWhiteSpace(cmbBoxEndM.Text) &&
                !string.IsNullOrEmpty(cmbBoxUser.Text) && !string.IsNullOrWhiteSpace(cmbBoxUser.Text))
            {

                await sqlConnection.OpenAsync();
                string query = "INSERT INTO TOOL1 (Date, Time_beging, Time_end, Duration, [User]) VALUES (@Date, @Time_beging, @Time_end, @Duration, @User)";
                string timeBegining = GetTime(cmbBoxBegH.Text, cmbBoxBegM.Text);
                string timeEnd = GetTime(cmbBoxEndH.Text, cmbBoxEndM.Text);

                SqlCommand insert = new SqlCommand(query, sqlConnection);


                insert.Parameters.AddWithValue("Date", datePickAdd.Value);
                insert.Parameters.AddWithValue("Time_beging", timeBegining);
                insert.Parameters.AddWithValue("Time_end", timeEnd);
                insert.Parameters.AddWithValue("Duration", duration);
                insert.Parameters.AddWithValue("User", cmbBoxUser.Text);

                await insert.ExecuteNonQueryAsync();
                sqlConnection.Close();
                ReFresh();
                cmbBoxBegH.Text = "08";
                cmbBoxBegM.Text = "48";
                cmbBoxEndH.Text = "18";
                cmbBoxEndM.Text = "00";
                btnInsert.Enabled = false;

            }
            else
            {
                MessageBox.Show(" ВСЕ ПОЛЯ НЕОБХОДИМО ЗАПОЛНИТЬ", "ОШИБКА ВВОДА", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        #endregion

        #region Дополнительные методы
        /// <summary>
        /// Метод обновляет журнал после любых изменений в базе данных
        /// </summary>
        private async void ReFresh()
        {
            dataGridView1.Rows.Clear();
            string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\afigi\Desktop\курсовая\Equepment\Database1.mdf; Integrated Security = True";
            sqlConnection = new SqlConnection(connectionString);
            await sqlConnection.OpenAsync();
            string query = "SELECT * FROM TOOL1";
            SqlCommand command = new SqlCommand(query, sqlConnection);

            SqlDataReader reader = await command.ExecuteReaderAsync();

            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[6]);
                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
            }

            reader.Close();

            sqlConnection.Close();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);

        }

        /// <summary>
        /// Сцепляет значения текста введенного в комбобоксе для вставки в базу данных
        /// </summary>
        /// <param name="H"> часы </param>
        /// <param name="M"> минуты </param>
        /// <returns> тест для базы </returns>
        private string GetTime(string H, string M)
        {
            string value = H + ":" + M;
            return value;
        }
        /// <summary>
        /// Вычисляет продолжительность работы в часах и минутах
        /// </summary>
        /// <param name="H1"></param>
        /// <param name="H2"></param>
        /// <param name="M1"></param>
        /// <param name="M2"></param>
        /// <returns></returns>
        public string GetDuration(string H1, string H2, string M1, string M2, Label lbl)
        {
            int beginingHour = int.Parse(H1);
            int endHour = int.Parse(H2);
            int beginingMin = int.Parse(M1);
            int endMin = int.Parse(M2);
            string value = null;
            int difHour = endHour - beginingHour;
            int difMin = endMin - beginingMin;

            if ((difHour >= 0 && difMin >= 0) || (difHour >= 1 && difMin < 0 && difMin >= -59))
            {

                DateTime timeBegining = new DateTime(1984, 03, 08, beginingHour, beginingMin, 00);
                DateTime timeEnd = new DateTime(1984, 03, 08, endHour, endMin, 00);
                TimeSpan diff = timeEnd - timeBegining;
                value = diff.ToString();

                value = value.Remove(5);
                lbl.ForeColor = Color.Green;
            }
            else
            {
                MessageBox.Show("НЕОБХОДИМО ПРОВЕРИТЬ КОРРЕКТНОСТЬ ВВОДА ВРЕМЕНИ НАЧАЛА И КОНЦА РАБОТЫ ПРИБОРА", "ОШИБКА ВВОДА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbl.ForeColor = Color.Red;
            }

            return value;
        }

        private string InPutControl(TextBox box)
        {
            int number;
            string value = null;
            bool v = int.TryParse(box.Text, out number);
            if (!v || number <= 0)
            {
                MessageBox.Show("Необходимо ввести номер записи из журнала", "ОШИБКА ВВОДА", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                box.Focus();
                box.Text = null;
                value = null;
            }
            else
            {
                value = number.ToString();
            }

            return value;
        }
        #endregion

        #region Удалить запись
        private async void btnDelete_Click_1(object sender, EventArgs e)
        {
            string id = InPutControl(txtBoxDelete);
            if (!string.IsNullOrEmpty(txtBoxDelete.Text) && !string.IsNullOrWhiteSpace(txtBoxDelete.Text) && id != null)
            {
                MessageBox.Show($"ВЫ УДАЛЯЕТЕ ЗАПИСЬ № {txtBoxDelete.Text}", "УДАЛЕНИЕ ЗАПИСИ", MessageBoxButtons.OK, MessageBoxIcon.Question); ;

                await sqlConnection.OpenAsync();

                string query = "DELETE FROM TOOL1 WHERE [Id] = @Id";

                SqlCommand delete = new SqlCommand(query, sqlConnection);

                delete.Parameters.AddWithValue("Id", id);

                await delete.ExecuteNonQueryAsync();

                sqlConnection.Close();

                txtBoxDelete.Clear();

                ReFresh();
            }
            else
            {
                MessageBox.Show(" ВСЕ ПОЛЯ НЕОБХОДИМО ЗАПОЛНИТЬ", "ОШИБКА ВВОДА", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }



        #endregion

        #region События оформления кнопок
        private void btnUpdateDuration_Click_1(object sender, EventArgs e)
        {
            duration = GetDuration(cmbBoxBegH.Text, cmbBoxEndH.Text, cmbBoxBegM.Text, cmbBoxEndM.Text, lblDurHour);
            if (duration != null)
            {
                lblDurHour.Text = duration;
                btnInsert.Enabled = true;
            }
            else
            {
                btnInsert.Enabled = false;
            }

        }

        private void btnInsert_MouseEnter(object sender, EventArgs e)
        {
            btnInsert.ForeColor = Color.Blue;
        }

        private void btnInsert_MouseLeave(object sender, EventArgs e)
        {
            btnInsert.ForeColor = Color.Black;
        }

        private void btnUpdateDuration_MouseEnter(object sender, EventArgs e)
        {
            btnUpdateDuration.ForeColor = Color.Blue;
        }

        private void btnUpdateDuration_MouseLeave(object sender, EventArgs e)
        {
            btnUpdateDuration.ForeColor = Color.Black;
        }

        private void btnDurUpdate_MouseEnter(object sender, EventArgs e)
        {
            btnDurUpdate.ForeColor = Color.Blue;
        }

        private void btnDurUpdate_MouseLeave(object sender, EventArgs e)
        {
            btnDurUpdate.ForeColor = Color.Black;
        }

        private void btnUpdate_MouseEnter(object sender, EventArgs e)
        {
            btnUpdate.ForeColor = Color.Blue;
        }

        private void btnUpdate_MouseLeave(object sender, EventArgs e)
        {
            btnUpdate.ForeColor = Color.Black;
        }
        private void btnCreateReport_MouseEnter(object sender, EventArgs e)
        {
            btnCreateReport.ForeColor = Color.Blue;
        }

        private void btnCreateReport_MouseLeave(object sender, EventArgs e)
        {
            btnCreateReport.ForeColor = Color.Black;
        }
        #endregion

        #region Исправить запись в журнале
        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            string id = InPutControl(txtBoxUpDate);
            if (!string.IsNullOrEmpty(cmbBxBegHUd.Text) && !string.IsNullOrWhiteSpace(cmbBxBegHUd.Text) &&
                !string.IsNullOrEmpty(cmbBxBegMUd.Text) && !string.IsNullOrWhiteSpace(cmbBxBegMUd.Text) &&
                !string.IsNullOrEmpty(cmbBxEndHUd.Text) && !string.IsNullOrWhiteSpace(cmbBxEndHUd.Text) &&
                !string.IsNullOrEmpty(cmbBxEndMUd.Text) && !string.IsNullOrWhiteSpace(cmbBoxEndM.Text) &&
                !string.IsNullOrEmpty(cmbBoxUser.Text) && !string.IsNullOrWhiteSpace(cmbBoxUser.Text) &&
                !string.IsNullOrEmpty(txtBoxUpDate.Text) && !string.IsNullOrWhiteSpace(txtBoxUpDate.Text) && id != null)
            {


                await sqlConnection.OpenAsync();

                string query = "UPDATE TOOL1  SET [Date] = @Date, [Time_beging]=@Time_beging, [Time_end]= @Time_end, [Duration] = @Duration, [User]=@User WHERE [Id]=@Id";
                string timeBegining = GetTime(cmbBxBegHUd.Text, cmbBxBegMUd.Text);
                string timeEnd = GetTime(cmbBxEndHUd.Text, cmbBxEndMUd.Text);



                SqlCommand update = new SqlCommand(query, sqlConnection);

                update.Parameters.AddWithValue("Id", id);
                update.Parameters.AddWithValue("Date", dtPickUpdate.Value);
                update.Parameters.AddWithValue("Time_beging", timeBegining);
                update.Parameters.AddWithValue("Time_end", timeEnd);
                update.Parameters.AddWithValue("Duration", duration);
                update.Parameters.AddWithValue("User", cmbBoxUser.Text);

                await update.ExecuteNonQueryAsync();
                sqlConnection.Close();
                ReFresh();
                txtBoxUpDate.Clear();
                cmbBxBegHUd.Text = "08";
                cmbBxBegMUd.Text = "48";
                cmbBxEndHUd.Text = "18";
                cmbBxEndMUd.Text = "00";
                btnUpdate.Enabled = false;

            }
            else
            {
                MessageBox.Show(" ВСЕ ПОЛЯ НЕОБХОДИМО ЗАПОЛНИТЬ", "ОШИБКА ВВОДА", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void btnDurUpdate_Click(object sender, EventArgs e)
        {
            duration = GetDuration(cmbBxBegHUd.Text, cmbBxEndHUd.Text, cmbBxBegMUd.Text, cmbBxEndMUd.Text, lblUpDateDur);
            if (duration != null)
            {
                lblUpDateDur.Text = duration;
                btnUpdate.Enabled = true;
            }
            else
            {
                btnUpdate.Enabled = false;
            }



        }




        #endregion

        #region Сформировать отчет
        private async void btnCreateReport_Click(object sender, EventArgs e)
        {
            DateTime begining_day = new DateTime();
            begining_day = Convert.ToDateTime(dtPickReport1.Text);
            DateTime end_day = new DateTime();
            end_day = Convert.ToDateTime(dtPickReport2.Text);

            dataGridView2.Rows.Clear();
            string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\afigi\Desktop\курсовая\Equepment\Database1.mdf; Integrated Security = True";
            sqlConnection = new SqlConnection(connectionString);
            await sqlConnection.OpenAsync();
            string query = $"SELECT * FROM TOOL1 WHERE [Date] BETWEEN @BEGINING_DAY AND @END_DAY ORDER BY {sortby}";


            SqlCommand command = new SqlCommand(query, sqlConnection);
            command.Parameters.AddWithValue("BEGINING_DAY", begining_day);
            command.Parameters.AddWithValue("END_DAY", end_day);

            SqlDataReader reader = await command.ExecuteReaderAsync();

            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[6]);
                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
            }

            reader.Close();

            sqlConnection.Close();

            foreach (string[] s in data)
                dataGridView2.Rows.Add(s);


        }

        #endregion



        #region Переключатель выбора сортировки
        private void RBNote_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                sortby = "Id";
                
            }
        }

        private void RBBegining_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                sortby = "Time_beging";
                
            }
        }

        private void RBEnd_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                sortby = "Time_end";
              
            }
        }

        private void RBDur_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                sortby = "Duration";
                
            }
        }

        private void RBUser_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                sortby = "[User]";
                
            }
        }

        private void RBDate_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if(radioButton.Checked)
            {
                sortby = "Date";
            }

        }
        #endregion


    }
}
