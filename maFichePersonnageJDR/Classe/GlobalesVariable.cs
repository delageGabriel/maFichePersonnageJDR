﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maFichePersonnageJDR.Classe
{
    class GlobalesVariable
    {
        private const double pdsScrasamax = 0.55;

        private const double pdsEpeeCourte = 0.35;
        
        private const double pdsEpeeLongue = 1.5;

        private const double pdsGlaive = 0.6;

        private const double pdsLatte = 0.5;
        
        private const double pdsSabreCourbe = 0.45;

        private const double pdsContus = 10.0;

        private const double pdsJavelot = 1.0;
        
        private const double pdsFourche = 0.8;

        private const double pdsSarisse = 4.0;

        private const double pdsTrident = 5.0;

        private const double pdsCouteau = 0.21;

        private const double pdsDague = 0.15;

        private const double pdsFaucilleGuerre = 0.30;

        private const double pdsDagueAssassin = 0.20;

        private const double pdsFrancisque = 1.3;

        private const double pdsArc = 1.0;

        private const double pdsArbalete = 2.0;

        private const double pdsFronde = 0.030;

        private const double pdsFouet = 0.13;

        private const double pdsFaucilleChaine = 0.90;

        private const double pdsBatonChene = 0.25;

        private const double pdsSceptre = 0.5;

        private const double pdsSpangenhelm = 4.0;

        private const double pdsCoiffeMaille = 2.5;

        private const double pdsMorion = 1.7;
        
        private const double pdsCerveliere = 1.6;

        private const double pdsChapelFer = 1.9;

        private const double pdsCasqueBarbare = 1.8;

        private const double pdsVetements = 0.2;

        private const double pdsBroigne = 20.0;

        private const double pdsCataphracte = 40.0;
        
        private const double pdsCuirasseBronze = 3.0;

        private const double pdsCuirasseFer = 10.0;

        private const double pdsRobeCuir = 1.0;

        private const double pdsGantsMailles = 0.8;

        private const double pdsGantelet = 1.6;

        private const double pdsMitaines = 0.6;

        private const double pdsMitons = 2.0;

        private const double pdsCuissardes = 8.0;

        private const double pdsPantalonToile = 0.5;

        private const double pdsCnemide = 1.2;

        private const double pdsSandales = 0.26;

        private const double pdsChaussuresCuir = 1.0;

        private const double pdsEcu = 1.7;

        private const double pdsPavois = 11.2;

        private const double pdsBouclierAmande = 2.1;

        private const double pdsBouclierBronze = 1.9;

        private const double pdsPelta = 1.4;

        private const double pdsTorche = 0.5;

        private const double pdsCorde = 0.4;

        private const double pdsOutre = 1.0;

        private const double pdsSac = 0.10;

        private const double pdsTente = 15.0;

        private const string nom = "Nom : ";

        private const string poids = ", Poids : ";

        private const string portee = ", Portée : ";

        private const string quantite = ", Quantitée : ";

        private const string type = ", Type : ";

        private const string degats = ", Dégât(s) : ";

        private const string valeur = ", Valeur : ";

        private const string propriete = ", Propriété : ";

        private const string effets = ", Effets : ";

        private const string taille = ", Taille : ";

        private const int ptsPhysiqueMax = 55;

        private const int ptsMentalMax = 65;

        private const int ptsSocialMax = 30;
        public static double PdsScrasamax => pdsScrasamax;

        public static double PdsEpeeCourte => pdsEpeeCourte;

        public static double PdsEpeeLongue => pdsEpeeLongue;

        public static double PdsGlaive => pdsGlaive;

        public static double PdsLatte => pdsLatte;

        public static double PdsSabreCourbe => pdsSabreCourbe;

        public static double PdsContus => pdsContus;

        public static double PdsJavelot => pdsJavelot;

        public static double PdsFourche => pdsFourche;

        public static double PdsSarisse => pdsSarisse;

        public static double PdsTrident => pdsTrident;

        public static double PdsCouteau => pdsCouteau;

        public static double PdsDague => pdsDague;

        public static double PdsFaucilleGuerre => pdsFaucilleGuerre;

        public static double PdsFrancisque => pdsFrancisque;

        public static double PdsArc => pdsArc;

        public static double PdsArbalete => pdsArbalete;

        public static double PdsFronde => pdsFronde;

        public static double PdsFouet => pdsFouet;

        public static double PdsFaucilleChaine => pdsFaucilleChaine;

        public static double PdsBatonChene => pdsBatonChene;

        public static double PdsSceptre => pdsSceptre;

        public static double PdsSpangenhelm => pdsSpangenhelm;

        public static double PdsCoiffeMaille => pdsCoiffeMaille;

        public static double PdsMorion => pdsMorion;

        public static double PdsCerveliere => pdsCerveliere;

        public static double PdsChapelFer => pdsChapelFer;

        public static double PdsCasqueBarbare => pdsCasqueBarbare;

        public static double PdsVetements => pdsVetements;

        public static double PdsBroigne => pdsBroigne;

        public static double PdsCataphracte => pdsCataphracte;

        public static double PdsCuirasseBronze => pdsCuirasseBronze;

        public static double PdsCuirasseFer => pdsCuirasseFer;

        public static double PdsRobeCuir => pdsRobeCuir;

        public static double PdsGantsMailles => pdsGantsMailles;

        public static double PdsGantelet => pdsGantelet;

        public static double PdsMitaines => pdsMitaines;

        public static double PdsMitons => pdsMitons;

        public static double PdsCuissardes => pdsCuissardes;

        public static double PdsPantalonToile => pdsPantalonToile;

        public static double PdsCnemide => pdsCnemide;

        public static double PdsSandales => pdsSandales;

        public static double PdsChaussuresCuir => pdsChaussuresCuir;

        public static double PdsEcu => pdsEcu;

        public static double PdsPavois => pdsPavois;

        public static double PdsBouclierAmande => pdsBouclierAmande;

        public static double PdsBouclierBronze => pdsBouclierBronze;

        public static double PdsPelta => pdsPelta;

        public static double PdsTorche => pdsTorche;

        public static double PdsCorde => pdsCorde;

        public static double PdsOutre => pdsOutre;

        public static double PdsSac => pdsSac;

        public static double PdsTente => pdsTente;

        public static double PdsDagueAssassin => pdsDagueAssassin;

        public static string Poids => poids;

        public static string Portee => portee;

        public static string Quantite => quantite;

        public static string Type => type;

        public static string Degats => degats;

        public static string Valeur => valeur;

        public static string Propriete => propriete;

        public static string Effets => effets;

        public static string Taille => taille;

        public static string Nom => nom;

        public static int PtsPhysiqueMax => ptsPhysiqueMax;

        public static int PtsMentalMax => ptsMentalMax;

        public static int PtsSocialMax => ptsSocialMax;
    }
}
