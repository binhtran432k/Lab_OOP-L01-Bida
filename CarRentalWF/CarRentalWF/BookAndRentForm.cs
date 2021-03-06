﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalWF
{
    public partial class BookAndRentForm : Form
    {
        readonly CarRentalManagement _carRentalManagement = CarRentalManagement.GetInstance();
        readonly BindingSource _vehicleBindingSource = new BindingSource();
        private bool _searching;
        private string _searchInfo;
        public BookAndRentForm()
        {
            InitializeComponent();
        }

        private void BookAndRentForm_Load(object sender, EventArgs e)
        {
            _vehicleBindingSource.DataSource = _carRentalManagement.GetAvailableVehicleList();

            vehicleGridView.AutoGenerateColumns = false;
            vehicleGridView.DataSource = _vehicleBindingSource;
            _searching = false;
        }

        private void BtnRent_Click(object sender, EventArgs e)
        {
            int index = (int)vehicleGridView.SelectedRows[0].Cells[0].Value;
            Vehicle vec = _carRentalManagement.GetVehicle(index);
            Form rentForm = new RentUserForm(vec);

            rentForm.FormClosed += (s, a) =>
            {
                _vehicleBindingSource.DataSource = _carRentalManagement.GetAvailableVehicleList();
            };

            rentForm.Show();
        }

        private void BtnBook_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm(true);

            searchForm.FormClosed += (s, a) =>
            {
                Form rentForm = new RentUserForm(searchForm.Vehicle);
                rentForm.FormClosed += (ss, aa) =>
                {
                    _vehicleBindingSource.DataSource = _carRentalManagement.GetAvailableVehicleList();
                };

                rentForm.Show();
            };

            searchForm.Show();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (_searching)
            {
                _vehicleBindingSource.DataSource = _carRentalManagement.GetAvailableVehicleList();
                _vehicleBindingSource.ResetBindings(true);
                btnSearch.Text = "Search Vehicle";
                _searching = false;
            }
            else
            {
                SearchForm searchForm = new SearchForm();

                searchForm.FormClosed += (s, a) =>
                {
                    _vehicleBindingSource.DataSource = searchForm.VehicleList;
                    _vehicleBindingSource.ResetBindings(true);
                    btnSearch.Text = "Clear Search";
                    _searching = true;
                };

                searchForm.Show();
            }
        }
    }
}
