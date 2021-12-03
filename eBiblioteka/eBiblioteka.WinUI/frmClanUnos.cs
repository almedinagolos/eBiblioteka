﻿using eBiblioteka.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBiblioteka.WinUI
{
    public partial class frmClanUnos : Form
    {
        private readonly Clan row;
        private readonly APIService _serviceClan = new APIService("Clan");
        private readonly APIService _serviceGrad = new APIService("Grad");
        private readonly APIService _serviceBiblioteka = new APIService("Biblioteka");


        public frmClanUnos()
        {
            InitializeComponent();
        }
        public frmClanUnos(Clan row) : this()
        {
            this.row = row;
        }

        private async void potvrdaUnosaButton_Click(object sender, EventArgs e)
        {
            var request = new Model.Requests.ClanInsertRequest
            {
                Ime = imeTextBox.Text,
                Prezime = prezimeTextBox.Text,
                JMBG = JMBGTextBox.Text,
                Adresa = adresaTextBox.Text,
                DatumRodjenja = DatumRodjenjaDtp.Value,
                GradID = int.Parse(gradCombo.SelectedValue.ToString()),
                BibliotekaID = int.Parse(bibliotekaCombo.SelectedValue.ToString()),
                Email = emailTextBox.Text

            };

            if (row != null)
            {
                var entity = await _serviceClan.Update<Clan>(row.ClanID, request);
                if (entity != null)
                {
                    MessageBox.Show("Uspješno ste uredili Člana!");
                    DialogResult = DialogResult.OK;
                }
            }
            else
            {
                var entity = await _serviceClan.Insert<Clan>(request);
                if (entity != null)
                {
                    MessageBox.Show("Uspješno ste unijeli Člana!");
                    DialogResult = DialogResult.OK;
                }
            }
        }
        private void UcitajClanove(Clan entity)
        {
            imeTextBox.Text = entity.Ime;
            prezimeTextBox.Text = entity.Prezime;
            JMBGTextBox.Text = entity.JMBG;
            gradCombo.SelectedValue = entity.GradID;
            bibliotekaCombo.SelectedValue = entity.BibliotekaID;
            DatumRodjenjaDtp.Text = entity.DatumRodjenja.ToString();
            emailTextBox.Text = entity.Email;
            adresaTextBox.Text = entity.Adresa;

        }
        private async void frmClanUnos_Load(object sender, EventArgs e)
        {
            Clan entity = null;
            if (row != null)
            {
                entity = await _serviceClan.GetById<Clan>(row.ClanID);
                UcitajClanove(entity);
            }


            await Task.WhenAll(
                UcitajGradove(entity),
                UcitajBiblioteke(entity)
            );
        }
       
        private async Task UcitajBiblioteke(Clan entity)
        {
            var list = await _serviceBiblioteka.GetAll<List<Biblioteka>>(null);
            bibliotekaCombo.DataSource = list;
            bibliotekaCombo.ValueMember = "BibliotekaID";
            bibliotekaCombo.DisplayMember = "Naziv";

            if (entity != null)
                bibliotekaCombo.SelectedValue = entity.BibliotekaID;
        }
        private async Task UcitajGradove(Clan entity)
        {
            var list = await _serviceGrad.GetAll<List<Grad>>(null);
            gradCombo.DataSource = list;
            gradCombo.ValueMember = "GradID";
            gradCombo.DisplayMember = "Naziv";

            if (entity != null)
                gradCombo.SelectedValue = entity.GradID;
        }
    }
}
