﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GSBCR.modele;
using GSBCR.BLL;

namespace GSBCR.UI
{
    public partial class FrmMenuVisiteur : Form
    {
        private VISITEUR leVisiteur;
        private VAFFECTATION leProfil;
        public FrmMenuVisiteur(string matricule, string mdp)
        {
            InitializeComponent();
            // chargement du visiteur connecté et de son profil
            try
            {
                //le visiteur doit être passé en paramètre par le menu de connexion
                //Ici initialiser le visiteur en dur
                //visiteur
                leVisiteur = VisiteurManager.ChargerVisiteur(matricule, mdp);
                //leVisiteur = VisiteurManager.ChargerVisiteur("a131", "30BFD069");
                //délégue
                //leVisiteur = VisiteurManager.ChargerVisiteur("r58", "secret18");
                //responsable
                //leVisiteur = VisiteurManager.ChargerVisiteur("r24", "secret18");
                leProfil = VisiteurManager.ChargerAffectationVisiteur(leVisiteur.VIS_MATRICULE);
                if (leProfil.TRA_ROLE == "Délégué")
                {
                    maRégionToolStripMenuItem.Enabled = true;
                }
                else if (leProfil.TRA_ROLE == "Responsable")
                {
                    monSecteurToolStripMenuItem.Enabled = true;
                    mesRapportsEnCoursToolStripMenuItem.Enabled = false;
                    mesRapportsValidésToolStripMenuItem.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().Message);
            }
            
        }

        private void FrmMenuVisiteur_Load(object sender, EventArgs e)
        {
            label2.Text = "Bienvenue " + leVisiteur.Vis_PRENOM + " " + leVisiteur.VIS_NOM;
            label4.Text = "Vous est un : " + leProfil.TRA_ROLE;
            //label3.Text = "Votre région est : " + leProfil;
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void nouveauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RAPPORT_VISITE r = new RAPPORT_VISITE();
            r.RAP_MATRICULE = leVisiteur.VIS_MATRICULE;
            FrmSaisir f = new FrmSaisir(r, true);
            f.ShowDialog();
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<RAPPORT_VISITE> lesRapports = null;
            try
            {
                lesRapports = VisiteurManager.ChargerRapportVisiteurEncours(leVisiteur.VIS_MATRICULE);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (lesRapports != null && lesRapports.Count != 0)
            {
                FrmRapportEnCours f = new FrmRapportEnCours(leVisiteur, lesRapports);
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Aucun rapport en cours", "Gestion Rapports de visite", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lesPraticiensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<PRATICIEN> lp = null;
            try
            {
                lp = VisiteurManager.ChargerPraticiens();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (lp != null && lp.Count != 0)
            {
                FrmPraticien f = new FrmPraticien(leVisiteur, lp);
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Aucun praticien", "Gestion praticien", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void mesRapportsValidésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ouverture du formulaire 
            List<RAPPORT_VISITE> lesRapports = null;
            // Bloc de test
            try
            {
                lesRapports = VisiteurManager.ChargerRapportVisiteurFinis(leVisiteur.VIS_MATRICULE);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            // Test si rapport existe
            if (lesRapports != null && lesRapports.Count != 0)
            {
                FrmRapportValide f = new FrmRapportValide(leVisiteur, lesRapports);
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Aucun rapport de visite validé", "Gestion Rapports de visite", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lesMedicamentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<MEDICAMENT> lm = VisiteurManager.ChargerMedicaments();
            FrmConsultMedicament f = new FrmConsultMedicament(lm);
            f.ShowDialog();
        }
        private void modifierConsulterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (leVisiteur != null)
            {
                FrmModifInfos f = new FrmModifInfos(leVisiteur);
                f.ShowDialog();
            }

        }

        private void changerMonMotDePasseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ( leVisiteur != null )
            {
                FrmModifPwd f = new FrmModifPwd(leVisiteur);
                f.ShowDialog();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
