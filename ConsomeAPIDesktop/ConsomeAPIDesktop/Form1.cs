using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace ConsomeAPIDesktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void button1_ClickAsync(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("");

                var resposta =  await client.GetAsync("");

                string dados = await resposta.Content.ReadAsStringAsync();

                List<Cliente> clientes = new JavaScriptSerializer().Deserialize<List<Cliente>>(dados);

                dataGridView1.DataSource = clientes;



            


            }




        }
    }


    public class Cliente
    {
        public int codigo { get; set; }
        public string Nome { get; set; }
        public int tipo { get; set; }
        public DateTime DataCadastro { get; set;}
        

    }





}
