using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UprDanLab15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection connection;

        //Поменять PC2 на название твоего сервера. Зайти в App.config и внести эту строку туда
        string connectionString = "Data Source=PC2;Initial Catalog=Tolsokorova_Grishin_ITb-212;Integrated Security=True";

        private void Form1_Load(object sender, EventArgs e)
        {
            connection=new SqlConnection(connectionString);

            connection.Open();

           
            timer1.Start();

            dataGridView1.Columns.Add("","AI_ID");
            dataGridView1.Columns.Add("", "Name");
            dataGridView1.Columns.Add("", "Role");

            y = BallPicture.Location.Y;
            ballX = BallPicture.Location.X;
            ballY=BallPicture.Location.Y;
            ballJumpHeight = 140;
        }

        private void ServiceAI_InsertButton_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO dbo.Service_AIs (Name, Role) VALUES (@ServiceAI_Name, @ServiceAI_Role);";

            SqlCommand theQuery = new SqlCommand(insertQuery);

            SqlParameter nameParammeter = new SqlParameter();

            nameParammeter.ParameterName = "ServiceAI_Name";
            nameParammeter.SqlDbType = SqlDbType.NVarChar;
            nameParammeter.Value = NameTextBox.Text;

            SqlParameter roleParameter = new SqlParameter();

            roleParameter.ParameterName = "ServiceAI_Role";
            roleParameter.SqlDbType = SqlDbType.NVarChar;
            roleParameter.Value = RoleTextBox.Text;

            theQuery.Parameters.Add(nameParammeter);
            theQuery.Parameters.Add(roleParameter);

            theQuery.Connection = connection;
            theQuery.ExecuteNonQuery();
        }

        private void ExtractFromSubjectsButton_Click(object sender, EventArgs e)
        {
            string selectQuery = "SELECT * FROM Subjects;";

            SqlCommand theQuery = new SqlCommand( selectQuery );
            theQuery.Connection= connection;
            SqlDataReader theResult = theQuery.ExecuteReader();

            theResult.Close();
            theResult = theQuery.ExecuteReader();

            int k = 0;

            if (theResult.HasRows)
            {
                while (theResult.Read())
                {
                    dataGridView1.Rows.Add();

                    dataGridView1[0,k].Value=theResult["Subject_ID"].ToString();
                    dataGridView1[1, k].Value = theResult["Name"].ToString();
                    dataGridView1[2, k].Value = theResult["Birth_Year"].ToString();

                    k++;
                }
            }
        }

        bool fall;
        int y = 327;
        int k = 0;
        int ballX;
        int ballY;
        int ballJumpHeight;
        private void timer1_Tick(object sender, EventArgs e)
        {
            BallPicture.Location=new Point(ballX,y);

            if (y > ballY-ballJumpHeight && !fall)
            {
                y -= 10;
                
            }
            else if (y < ballY && fall)
            {
                y += 10;

                
            }

            if (y == ballY-ballJumpHeight)
            {
                fall = true;
            }

            if (y == ballY)
            {
                fall = false;
                k++;
                BounceLabel.Text = $"{k}";           
            }
        }

        private void CreateNewTestButton_Click(object sender, EventArgs e)
        {
            string inQuery = "CreateNewTest";
            SqlCommand inQueryInstance = new SqlCommand(inQuery, connection);
            inQueryInstance.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter subjectIDParameter = new SqlParameter();
            subjectIDParameter.ParameterName = "@SubjectID";
            subjectIDParameter.SqlDbType=SqlDbType.Int;
            subjectIDParameter.Value = int.Parse(SubjectIDtextBox.Text);
            inQueryInstance.Parameters.Add(subjectIDParameter);

            SqlParameter chamberIDParameter = new SqlParameter();
            chamberIDParameter.ParameterName = "@Test_Chumber_Id";
            chamberIDParameter.SqlDbType=SqlDbType.Int;
            chamberIDParameter.Value=int.Parse(ChamberIDtextBox.Text);
            inQueryInstance.Parameters.Add(chamberIDParameter);

            SqlParameter WTTimeParameter = new SqlParameter();
            WTTimeParameter.ParameterName = "@WT_time";
            WTTimeParameter.SqlDbType = SqlDbType.Int;
            WTTimeParameter.Value=int.Parse(WTTimeTextBox.Text);
            inQueryInstance.Parameters.Add(WTTimeParameter);

            SqlParameter resultParameter = new SqlParameter();
            resultParameter.ParameterName = "@Result";
            resultParameter.SqlDbType = SqlDbType.NVarChar;
            resultParameter.Value=ResultTextBox.Text;
            inQueryInstance.Parameters.Add(resultParameter);

            SqlParameter dateParameter = new SqlParameter();
            dateParameter.ParameterName = "@WT_date";
            dateParameter.SqlDbType = SqlDbType.DateTime;
            dateParameter.Value = DateParameterPicker.Value;
            inQueryInstance.Parameters.Add(dateParameter);

            inQueryInstance.ExecuteNonQuery();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string changeQuery = "ChangeDateOfTest";
            SqlCommand changeQueryInstance = new SqlCommand(changeQuery, connection);
            changeQueryInstance.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter testIDParameter=new SqlParameter();
            testIDParameter.ParameterName = "@Test_ID";
            testIDParameter.SqlDbType = SqlDbType.Int;
            testIDParameter.Value=int.Parse(TestIDTextBox.Text);
            changeQueryInstance.Parameters.Add(testIDParameter);

            SqlParameter newDateParameter= new SqlParameter();
            newDateParameter.ParameterName = "@WT_date";
            newDateParameter.SqlDbType= SqlDbType.DateTime;
            newDateParameter.Value=NewDateDatePicker.Value;
            changeQueryInstance.Parameters.Add(newDateParameter);

            changeQueryInstance.ExecuteNonQuery();
        }
    }
}
