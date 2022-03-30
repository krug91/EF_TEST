using MyProJect.DTO;
using MyProject.EF;
using MyProject.EF.MyProjectDbContext;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Winform_Entity
{
    public partial class Form1 : Form
    {
        MyProjectDBContext _dbContext;

        public Form1()
        {
            InitializeComponent();
            label1.Text = "Name";
            label2.Text = "Surname";

            _dbContext = new MyProjectDBContext();
            var manager = _dbContext.Managers.Include(x => x.Engineers).FirstOrDefault();

            textBox1.Text = manager.Name;
            textBox2.Text = manager.SurName;
            dataGridView1.AutoGenerateColumns = false;
            bindingSource1.DataSource = manager.Engineers;
            dataGridView1.DataSource = bindingSource1;

            var columns = new List<DataGridViewTextBoxColumn>()
            {
                new DataGridViewTextBoxColumn
                {
                    Name = nameof(Engineer.Name),
                    DataPropertyName = nameof(Engineer.Name),
                }
            };
            dataGridView1.Columns.AddRange(columns.ToArray());
            dataGridView1.AutoResizeColumns();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}