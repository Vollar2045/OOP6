using AdapterClasses;
using FacadeClasses;
using System;
using System.Windows.Forms;

namespace OOP6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnAdapterTest_Click(object sender, EventArgs e)
        {
            txtAdapterLog.Clear();
            txtAdapterLog.AppendText("=== Инициализация баллона ===\r\n");
            GasCylinder cylinder = new GasCylinder(volume: 0.05, mass: 0.1, molar: 0.032);
            IGasTarget adapter = new GasObjectAdapter(cylinder);
            txtAdapterLog.AppendText(adapter.GetData() + "\r\n\r\n");
            txtAdapterLog.AppendText("=== Добавляем 0.05 кг газа (ModifMass) ===\r\n");
            adapter.ModifMass(0.05);
            txtAdapterLog.AppendText(adapter.GetData() + "\r\n\r\n");
            txtAdapterLog.AppendText("=== Рассчитываем изменение давления ===\r\n");
            txtAdapterLog.AppendText("При нагреве с 300К до 350К (dT = 50):\r\n");
            double dp = adapter.CalculateDp(300, 50);
            txtAdapterLog.AppendText($"ΔP = {dp:F2} Па\r\n");
        }
        private void btnCalculateInsurance_Click(object sender, EventArgs e)
        {
            try
            {
                InsuranceFacade facade = new InsuranceFacade();
                string type = cmbPropertyType.SelectedItem.ToString();
                double area = (double)numArea.Value;
                int residents = (int)numResidents.Value;
                int year = (int)numYear.Value;
                double wear = (double)numWear.Value;
                int term = (int)numTerm.Value;
                double cost = facade.CalculateInsurance(type, area, residents, year, wear, term);
                lblInsuranceResult.Text = $"Итоговая стоимость страховки: {cost:N2} руб.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
    }
}