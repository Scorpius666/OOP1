using SquirrelFramework.Domain.Model;
using SquirrelFramework.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonload_Click(object sender, EventArgs e)
        {
            Human zhansan = new Human();
            zhansan.Age = 19;
            HumanCurdRepository database = new HumanCurdRepository();
            database.Add(zhansan);
            this.dataGridView.DataSource = database.GetAll();
        }
        class HumanCurdRepository : RepositoryBase<Human> { }
        class Human : DomainModel
        {
            public void Eat(int foodsize)
            {
                HungerIndex = HungerIndex + foodsize / 4;
            }//成员方法 行为
            public Human()
            {

            }
            private int hungerIndex;
            //唯一标识符
            public string Name;
            public bool Gender;
            public int Age;
            public DateTime Birthday;
            public string Professional;

            public int HungerIndex { get => hungerIndex; set => hungerIndex = value; }
            //成员变量 属性
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
