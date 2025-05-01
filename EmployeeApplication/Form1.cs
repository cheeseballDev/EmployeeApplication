using System.Data;
using System.Reflection.Metadata.Ecma335;
using System.Windows.Forms;
using EmployeeNamespace;
namespace EmployeeApplication
{
    public partial class fromEmployeeDatabase : Form
    {

        private DataTable table;
        public fromEmployeeDatabase()
        {
            table = new DataTable();

            table.Columns.Add("Employee ID", typeof(string));
            table.Columns.Add("First Name", typeof(string));
            table.Columns.Add("Last Name", typeof(string));
            table.Columns.Add("Position", typeof(string));

            InitializeComponent();

            dataGridViewEmployeeDatabase.DataSource = table;

        }


        private void buttonSubmitEmployee_Click(object sender, EventArgs e)
        {
            string employeeId = textBoxEmployeeId.Text.Trim();
            string employeeFirstName = textBoxFirstName.Text.Trim();
            string employeeLastName = textBoxLastName.Text.Trim();
            string employeePosition = textBoxPosition.Text.Trim();
            int parsedId;

            if (string.IsNullOrEmpty(employeeFirstName) || string.IsNullOrEmpty(employeeLastName))
            {
                MessageBox.Show("Missing field in employee first name or employee last name.", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clearTextBox();
                return;
            }

            if (!string.IsNullOrEmpty(employeeId) && !int.TryParse(employeeId, out parsedId))
            {
                MessageBox.Show("Invalid Employee ID format.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clearTextBox();
                return;
            }

            parsedId = string.IsNullOrEmpty(employeeId) ? 0 : int.Parse(employeeId);

            if ((parsedId.ToString().Length < 8 && !string.IsNullOrEmpty(employeeId)) || (parsedId.ToString().Length > 8) && !string.IsNullOrEmpty(employeeId))
            {
                MessageBox.Show("Invalid Employee ID", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clearTextBox();
                return;
            }

            Employee employeeObj;

            employeeObj = string.IsNullOrEmpty(employeeId)
                ? (string.IsNullOrEmpty(employeePosition)
                    ? new Employee(employeeFirstName, employeeLastName)
                    : new Employee(employeeFirstName, employeeLastName, employeePosition))
                : (string.IsNullOrEmpty(employeePosition)
                    ? new Employee(parsedId, employeeFirstName, employeeLastName)
                    : new Employee(parsedId, employeeFirstName, employeeLastName, employeePosition));

            table.Rows.Add(employeeObj.id, employeeObj.firstName, employeeObj.lastName, employeeObj.position);

            clearTextBox();
            return;
        }

        private void clearTextBox()
        {
            textBoxEmployeeId.Clear();
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxPosition.Clear();
        }

        private void buttonRemovePrevious_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmployeeDatabase.CurrentCell != null)
            {
                int selectedIndex = dataGridViewEmployeeDatabase.CurrentCell.RowIndex;
                if (selectedIndex > -1)
                {
                    dataGridViewEmployeeDatabase.Rows.RemoveAt(selectedIndex);
                    dataGridViewEmployeeDatabase.Refresh();
                    return;
                }
            }
            MessageBox.Show("No selected rows", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            dataGridViewEmployeeDatabase.DataSource = null;
        }
    }
}

namespace EmployeeNamespace
{
    public class Employee
    {
        public string id { get; private set; }
        public string firstName { get; private set; }
        public string lastName { get; private set; }
        public string position { get; private set; }

        public Employee(string newFirstName, string newLastName)
        {
            this.id = String.Format("20{0}", generateRandomId());
            this.firstName = newFirstName;
            this.lastName = newLastName;
            this.position = "N/A";
        }

        public Employee(int newId, string newFirstName, string newLastName)
        {
            this.id = newId.ToString();
            this.firstName = newFirstName;
            this.lastName = newLastName;
            this.position = "N/A";
        }

        public Employee(string newFirstName, string newLastName, string newPosition)
        {
            this.id = String.Format("20{0}", generateRandomId());
            this.firstName = newFirstName;
            this.lastName = newLastName;
            this.position = newPosition;
        }

        public Employee(int newId, string newFirstName, string newLastName, string newPosition)
        {
            this.id = newId.ToString();
            this.firstName = newFirstName;
            this.lastName = newLastName;
            this.position = newPosition;
        }

        public int generateRandomId()
        {
            Random random = new Random();
            return random.Next(100000, 999999);
        }

    }
}