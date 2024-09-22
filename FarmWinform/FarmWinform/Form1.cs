﻿using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace FarmWinform
{
    public partial class Form1 : Form
    {
        Animal animal = new Animal();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dataGridView.AutoGenerateColumns = false;
            using (FarmDbEntities db = new FarmDbEntities())
            {
                dataGridView.DataSource = db.Animals.ToList<Animal>();
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (!ValidateField()) return;

            animal.AnimalTypeId = GetAnimalTypeID(cbAnimalType.Text.Trim());
            animal.MilkProduced = double.Parse(tbMilk.Text.Trim());
            animal.OffspringCount = int.Parse(tbOffspring.Text.Trim());

            // connect db
            using (FarmDbEntities db = new FarmDbEntities())
            {
                if (animal.AnimalId == 0)
                {
                    db.Animals.Add(animal);
                }
                else
                {
                    db.Entry(animal).State = EntityState.Modified;
                }
                db.SaveChanges();
            }
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

        private int GetAnimalTypeID(string animalType)
        {
            if (animalType == "Cow") return 1;
            if (animalType == "Sheep") return 2;
            if (animalType == "Goat") return 3;
            return 0;
        }

        private void dataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow.Index != -1)
            {
                animal.AnimalId = Convert.ToInt32(dataGridView.CurrentRow.Cells["dgAnimalID"].Value);
                using (FarmDbEntities db = new FarmDbEntities())
                {
                    animal = db.Animals.Where(x => x.AnimalId == animal.AnimalId).FirstOrDefault();
                    cbAnimalType.SelectedIndex = 0;
                    tbMilk.Text = animal.MilkProduced.ToString();
                    tbOffspring.Text = animal.OffspringCount.ToString();
                }
                btSave.Text = "Update";
                btnDelete.Enabled = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure to Delete this Record", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (FarmDbEntities db = new FarmDbEntities())
                {
                    var entry = db.Entry(animal);
                    if (entry.State == EntityState.Detached)
                    {
                        db.Animals.Attach(animal);
                        db.Animals.Remove(animal);
                        db.SaveChanges();
                        LoadData();
                        Clear();
                        MessageBox.Show("Deleted Successfully!");
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            cbAnimalType.Items.Clear();
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
