using GeometriaClienRestApiDesktop.Dtos;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Guia13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       async private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string url = "http://localhost:5194/api/Geometria";

                using var client = new HttpClient();

                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri(url)
                };

                var response = await client.SendAsync(request);
            
                listBox1.Items.Clear();
                if (response.IsSuccessStatusCode)
                {
                    var lista = await response.Content.ReadFromJsonAsync<List<FiguraDto>>();

                    listBox1.DataSource = lista;
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
