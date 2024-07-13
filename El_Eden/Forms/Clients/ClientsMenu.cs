using El_Eden.MySQL.TablesObjects;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace El_Eden.Forms.Clients
{
    public partial class ClientsMenu : Form
    {
        private ClientDao clientDao = new ClientDao();

        private string firstName = "";
        private string lastName = "";
        private string phoneNumber = "";
        private string email = "";
        private string address = "";
        private string neighborhood = "";
        private Double totalSales;

        private string state = "search";
        private List<int> ClientIDs = new List<int>();

        public ClientsMenu()
        {
            InitializeComponent();
            lbWelcome.Text += Config.name + " !";
            lbDateTime.Text = "";
            timerDateTime.Start();
            loadDgvClients();
        }

        #region METHODS
        private void loadDgvClients()
        {
            // TRUE != "" - FALSE == "";
            bool nameAux = tbNameTp1.Text == "" ? false : true;
            bool lastNameAux = tbLastNameTp1.Text == "" ? false : true;
            bool neighborhoodAux = tbNeighborhoodTp1.Text == "" ? false : true;

            string firstName = tbNameTp1.Text;
            string lastName = tbLastNameTp1.Text;
            string neighborhood = tbNeighborhoodTp1.Text;

            void loadDgvData(List<MySQL.TablesObjects.Client> clients)
            {
                foreach (MySQL.TablesObjects.Client client in clients)
                {
                    int row = dgvClients.Rows.Add();

                    dgvClients.Rows[row].Cells[0].Value = client.client_id;
                    dgvClients.Rows[row].Cells[1].Value = client.first_name;
                    dgvClients.Rows[row].Cells[2].Value = client.last_name;
                    dgvClients.Rows[row].Cells[3].Value = client.tel_number;
                    dgvClients.Rows[row].Cells[4].Value = client.email;
                    dgvClients.Rows[row].Cells[5].Value = client.address;
                    dgvClients.Rows[row].Cells[6].Value = client.neighborhood;
                    dgvClients.Rows[row].Cells[7].Value = client.total_sales;
                }
            }

            List<MySQL.TablesObjects.Client> clients;

            // IF none data is provided
            if (!nameAux && !lastNameAux && !neighborhoodAux)
            {
                clients = clientDao.getClients("", "", "");
                loadDgvData(clients);
                clients.Clear();
            }
            // IF only name data provided
            else if (nameAux && !lastNameAux && !neighborhoodAux)
            {
                clients = clientDao.getClients("*", "", $"AND first_name LIKE '%{firstName}%'");
                loadDgvData(clients);
                clients.Clear();
            }
            // IF only last name data provided
            else if (!nameAux && lastNameAux && !neighborhoodAux)
            {
                clients = clientDao.getClients("*", "", $"AND last_name LIKE '%{lastName}%'");
                loadDgvData(clients);
                clients.Clear();
            }
            // IF only neighborhood data provided
            else if (!nameAux && !lastNameAux && neighborhoodAux)
            {
                clients = clientDao.getClients("*", "", $"AND neighborhood LIKE '%{neighborhood}%'");
                loadDgvData(clients);
                clients.Clear();
            }
            // IF name and last name data provided
            else if (nameAux && lastNameAux && !neighborhoodAux)
            {
                clients = clientDao.getClients("*", "", $"AND first_name LIKE '%{firstName}%' AND last_name LIKE '%{lastName}%'");
                loadDgvData(clients);
                clients.Clear();
            }
            // IF name and neighborhood data provided
            else if (nameAux && !lastNameAux && neighborhoodAux)
            {
                clients = clientDao.getClients("*", "", $"AND first_name LIKE '%{firstName}%' AND neighborhood LIKE '%{neighborhood}%'");
                loadDgvData(clients);
                clients.Clear();
            }
            // IF last name and neighborhood data provided
            else if (!nameAux && lastNameAux && neighborhoodAux)
            {
                clients = clientDao.getClients("*", "", $"AND last_name LIKE '%{lastName}%' AND neighborhood LIKE '%{neighborhood}%'");
                loadDgvData(clients);
                clients.Clear();
            }
            // IF all data provided
            else if (nameAux && lastNameAux && neighborhoodAux)
            {
                clients = clientDao.getClients("*", "", $"AND first_name LIKE '%{firstName}%' AND last_name LIKE '%{lastName}%' AND neighborhood LIKE '%{neighborhood}%'");
                loadDgvData(clients);
                clients.Clear();
            }
        }

        private void changeValuesState(string state)
        {
            switch (state)
            {
                case "modify":
                    this.state = "modify";
                    lbOptions.Text = "- MODIFICANDO CLIENTES -";
                    gbSelectOption.BackColor = Color.LemonChiffon;
                    gbSelectOption.ForeColor = Color.Black;
                    dgvClients.BackgroundColor = Color.Black;
                    btnModifyTp1.BackColor = Color.Black;
                    btnModifyTp1.ForeColor = Color.LemonChiffon;
                    btnModifyTp1.Text = "LISTO";
                    dgvCol1.ReadOnly = false;
                    dgvCol2.ReadOnly = false;
                    dgvCol3.ReadOnly = false;
                    dgvCol4.ReadOnly = false;
                    dgvCol5.ReadOnly = false;
                    dgvCol6.ReadOnly = false;
                    dgvCol7.ReadOnly = false;
                    btnSearchTp1.Enabled = false;
                    dgvCol8.Visible = true;
                    btnDeleteTp1.Enabled = true;
                    break;
                case "add":
                    this.state = "add";
                    lbOptions.Text = "- Agregar Clientes -";
                    gbSelectOption.BackColor = Color.Black;
                    gbSelectOption.ForeColor = Color.LemonChiffon;
                    dgvClients.BackgroundColor = Color.LemonChiffon;
                    btnModifyTp1.BackColor = Color.LemonChiffon;
                    btnModifyTp1.ForeColor = Color.Black;
                    btnModifyTp1.Text = "MODIFICAR";
                    dgvCol1.ReadOnly = false;
                    dgvCol2.ReadOnly = false;
                    dgvCol3.ReadOnly = false;
                    dgvCol4.ReadOnly = false;
                    dgvCol5.ReadOnly = false;
                    dgvCol6.ReadOnly = false;
                    dgvCol7.ReadOnly = false;
                    lbHelp.Visible = true;
                    break;
                default:
                    this.state = "search";
                    lbOptions.Text = "- Buscar Clientes -";
                    gbSelectOption.BackColor = Color.Black;
                    gbSelectOption.ForeColor = Color.LemonChiffon;
                    dgvClients.BackgroundColor = Color.LemonChiffon;
                    btnModifyTp1.BackColor = Color.LemonChiffon;
                    btnModifyTp1.ForeColor = Color.Black;
                    btnModifyTp1.Text = "MODIFICAR";
                    dgvCol1.ReadOnly = true;
                    dgvCol2.ReadOnly = true;
                    dgvCol3.ReadOnly = true;
                    dgvCol4.ReadOnly = true;
                    dgvCol5.ReadOnly = true;
                    dgvCol6.ReadOnly = true;
                    dgvCol7.ReadOnly = true;
                    lbHelp.Visible = false;
                    btnSearchTp1.Enabled = true;
                    dgvCol8.Visible = false;
                    btnDeleteTp1.Enabled = false;
                    break;
            }
        }
        #endregion

        #region EVENTS
        private void label_MouseEnter(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            Styles.label_MouseEnter(label);
        }
        private void label_MouseLeave(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            Styles.label_MouseLeave(label);
        }
        private void timerDateTime_Tick(object sender, EventArgs e)
        {
            // Actualizar el texto del Label con la fecha y hora actual
            DateTime now = DateTime.Now;
            lbDateTime.Text = now.Day.ToString().PadLeft(2, '0') + "/" + now.Month.ToString().PadLeft(2, '0') + "/" + now.Year.ToString().PadLeft(2, '0') + " " + now.Hour.ToString().PadLeft(2, '0') + ":" + now.Minute.ToString().PadLeft(2, '0') + ":" + now.Second.ToString().PadLeft(2, '0');
        }
        /// <summary>
        ///     TEXT BOX's TEXT CHANGED EVENT
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBoxAux = (TextBox)sender;
            if (textBoxAux.Name.ToString().Contains("tbName"))
            {
                firstName = textBoxAux.Text;
            }
            if (textBoxAux.Name.ToString().Contains("tbAddress"))
            {
                address = textBoxAux.Text;
            }
            if (textBoxAux.Name.ToString().Contains("tbPhone"))
            {
                phoneNumber = textBoxAux.Text;
            }
            if (textBoxAux.Name.ToString().Contains("tbEmail"))
            {
                email = textBoxAux.Text;
            }
            if (textBoxAux.Name.ToString().Contains("tbLastName"))
            {
                lastName = textBoxAux.Text;
            }
            if (textBoxAux.Name.ToString().Contains("tbNeighborhood"))
            {
                neighborhood = textBoxAux.Text;
            }
        }
        #endregion

        #region UPPER TOOL
        private void pnlUpperTool_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Permitir arrastrar el formulario
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        // P/Invoke para permitir el arrastre del formulario
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        private void btnAddClientTp2_Click(object sender, EventArgs e)
        {
            if (tbNameTp2.Text == "") { MessageBox.Show("Debe ingresar el NOMBRE del cliente antes de continuar.", "ADVERTENCIA"); }
            else if (tbAddressTp2.Text == "") { MessageBox.Show("Debe ingresar la DIRECCIÓN del cliente antes de continuar.", "ADVERTENCIA"); }
            else if (tbPhoneTp2.Text == "") { MessageBox.Show("Debe ingresar un NÚMERO DE TELÉFONO del cliente antes de continuar.", "ADVERTENCIA"); }
            else
            {
                MySQL.TablesObjects.Client client = new MySQL.TablesObjects.Client(0, firstName, lastName, phoneNumber, email, address, neighborhood, 1);
                clientDao.addClient(client);
                dgvClients.Rows.Clear();
                loadDgvClients();
                dgvClients.Refresh();
                
                firstName = "";
                lastName = "";
                phoneNumber = "";
                email = "";
                address = "";
                neighborhood = "";
             }
        }

        private void btnSearchTp1_Click(object sender, EventArgs e)
        {
            dgvClients.Rows.Clear();
            loadDgvClients();
            dgvClients.Refresh();
            btnModifyTp1.Enabled = true;
        }

        private void btnModifyTp1_Click(object sender, EventArgs e)
        {
            if (state == "search")
            {
                changeValuesState("modify");
            }
            else
            {
                if (ClientIDs.Count != 0)
                {
                    try
                    {
                        foreach (DataGridViewRow dgvRowClient in dgvClients.Rows)
                        {
                            try
                            {
                                int client_id = Int32.Parse(dgvRowClient.Cells[0].Value.ToString());
                                if (ClientIDs.Contains(client_id))
                                {
                                    string firstName = dgvRowClient.Cells[1].Value.ToString() ?? "";
                                    string lastName = dgvRowClient.Cells[2].Value.ToString() ?? "";
                                    string telNumber = dgvRowClient.Cells[3].Value.ToString() ?? "";
                                    string email = dgvRowClient.Cells[4].Value.ToString() ?? "";
                                    string address = dgvRowClient.Cells[5].Value.ToString() ?? "";
                                    string neighborhood = dgvRowClient.Cells[6].Value.ToString() ?? "";

                                    MySQL.TablesObjects.Client modifiedClient = new MySQL.TablesObjects.Client(client_id, firstName, lastName, telNumber, email, address, neighborhood, 1);
                                    clientDao.modifyClient(modifiedClient);
                                }
                            }
                            catch (NullReferenceException)
                            {
                                MessageBox.Show("Los valores se han modificado exitosamente.", "Mensaje");
                                ClientIDs.Clear();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ha ocurrido un error intentando modificar los valores:\n\n{ex.Message}", "ERROR");
                        ClientIDs.Clear();
                    }
                }
                dgvClients.Rows.Clear();
                loadDgvClients();
                changeValuesState("");
                ClientIDs.Clear();    
            }
        }

        private void tcClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Tp1Search
            if (btnSearchTp1.Visible == true)
            {
                changeValuesState("");
                dgvClients.Rows.Clear();
                loadDgvClients();
            }
            // Tp2Add
            if (btnAddClientTp2.Visible == true)
            {
                changeValuesState("add");
                dgvClients.Rows.Clear();
            }
        }

        private void dgvClients_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (state == "modify" && dgvClients.Rows.Count != 0)
            {
                int aux = 0;
                for (int i = 0; i < (dgvClients.Rows.Count - 1); i++) { if (dgvClients.Rows[i].Cells[8].Value == "true") { aux++; } }
                if (aux > 0) { btnModifyTp1.Enabled = false; }
                else
                {
                    btnModifyTp1.Enabled = true;
                    try
                    {
                        int selectedID = Int32.Parse(dgvClients.Rows[e.RowIndex].Cells[0].Value.ToString());
                        if (!ClientIDs.Contains(selectedID))
                        {
                            ClientIDs.Add(selectedID);
                        }
                    }
                    catch (NullReferenceException) { }
                }
            }
        }


        private void btnDeleteTp1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgvRowClient in dgvClients.Rows)
            {
                try
                {
                    int client_id = Int32.Parse(dgvRowClient.Cells[0].Value.ToString());
                    if (dgvRowClient.Cells[8].Value.ToString() == "true")
                    {
                        string firstName = dgvRowClient.Cells[1].Value.ToString() ?? "";
                        string lastName = dgvRowClient.Cells[2].Value.ToString() ?? "";
                        string telNumber = dgvRowClient.Cells[3].Value.ToString() ?? "";
                        string email = dgvRowClient.Cells[4].Value.ToString() ?? "";
                        string address = dgvRowClient.Cells[5].Value.ToString() ?? "";
                        string neighborhood = dgvRowClient.Cells[6].Value.ToString() ?? "";

                        MySQL.TablesObjects.Client modifiedClient = new MySQL.TablesObjects.Client(client_id, firstName, lastName, telNumber, email, address, neighborhood, 0);
                        clientDao.modifyClient(modifiedClient);
                    }
                }
                catch (NullReferenceException)
                {
                    dgvRowClient.Cells[8].Value = "false";
                }
            }
            dgvClients.Rows.Clear();
            loadDgvClients();
        }
    }
}
