using FarmWinform.Dtos;
using FarmWinform.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FarmWinform
{
    public partial class Form1 : Form
    {
        private AnimalService _animalService = new AnimalService();
        private AnimalDTO animal = new AnimalDTO();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadAnimalTypes();
        }

        private void LoadData()
        {
            dataGridView.AutoGenerateColumns = false;
            var animalData = _animalService.GetAllAnimals();
            dataGridView.DataSource = animalData;
        }

        private void LoadAnimalTypes()
        {
            var animalTypes = _animalService.GetAllAnimalTypes();
            cbAnimalType.DataSource = animalTypes;
            cbAnimalType.DisplayMember = "AnimalName";
            cbAnimalType.ValueMember = "AnimalTypeId";
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (!ValidateField()) return;

            animal.AnimalTypeId = (int)cbAnimalType.SelectedValue;
            animal.MilkProduced = double.Parse(tbMilk.Text.Trim());
            animal.OffspringCount = int.Parse(tbOffspring.Text.Trim());

            _animalService.SaveAnimal(animal);
            Clear();
            LoadData();
            MessageBox.Show("Submitted Successfully!");
        }

        private bool ValidateField()
        {
            // check if the fields are empty
            if (cbAnimalType.Text.Trim() == "")
            {
                MessageBox.Show("Choose the Animal Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbAnimalType.Focus();
                return false;
            }

            if (tbMilk.Text.Trim() == "")
            {
                MessageBox.Show("Enter the amount of milk", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbMilk.Focus();
                return false;
            }

            if (tbOffspring.Text.Trim() == "")
            {
                MessageBox.Show("Enter the number of offspring", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbOffspring.Focus();
                return false;
            }
            return true;
        }

        private void dataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow.Index == -1) return;

            animal.AnimalId = Convert.ToInt32(dataGridView.CurrentRow.Cells["dgAnimalID"].Value);
            var selectedAnimal = _animalService.GetAllAnimals()
                .FirstOrDefault(a => a.AnimalId == animal.AnimalId);

            cbAnimalType.SelectedValue = selectedAnimal.AnimalTypeId;
            tbMilk.Text = selectedAnimal.MilkProduced.ToString();
            tbOffspring.Text = selectedAnimal.OffspringCount.ToString();

            btSave.Text = "Update";
            btnDelete.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure to Delete this Record", "Message", MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            _animalService.DeleteAnimal(animal.AnimalId);
            LoadData();
            Clear();
            MessageBox.Show("Deleted Successfully!");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            cbAnimalType.SelectedIndex = -1;
            tbMilk.Clear();
            tbOffspring.Clear();
            btnDelete.Enabled = false;
        }

        // Handle the event to allow only numbers and one decimal point
        private void tbMilk_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tbOffspring_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
