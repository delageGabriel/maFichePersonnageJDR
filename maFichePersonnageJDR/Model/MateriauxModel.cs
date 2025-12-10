using maFichePersonnageJDR.Classe;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace maFichePersonnageJDR.Model
{
    class MateriauxModel
    {
        public int IdMateriau { get; set; }
        public string NomMateriau { get; set; }
        public string Categorie { get; set; }
        public string ResistanceTranchant { get; set; }
        public string ResistanceContondant { get; set; }
        public string ResistancePerforant { get; set; }
        public string ResistanceIgnee { get; set; }
        public string ResistanceAquatique { get; set; }
        public string ResistanceCeleste { get; set; }
        public string ResistanceTerrestre { get; set; }
        public string ResistanceChoc { get; set; }
        public string ResistanceAcide { get; set; }
        public string ResistancePression { get; set; }
        public string BonusInitiative { get; set; }
        public string BonusDexterite { get; set; }
        public string BonusVitesse { get; set; }
        public string ResistanceFroid { get; set; }
        public string ResistanceChaud { get; set; }
        public string Poids { get; set; }
        public string Valeur { get; set; }
        public string Description { get; set; }

        //public Dictionary<string, MateriauxModel> GetNameMateriauAndCategorie()
        //{
        //    Dictionary<string, MateriauxModel> materiauxModels = new Dictionary<string, MateriauxModel>();

        //    try
        //    {
        //        SQLiteCommand command = new SQLiteCommand(@"
        //            SELECT nom_materiau, categorie
        //            FROM MATERIAUX
        //            ORDER BY MATERIAUX.categorie DESC;", DatabaseConnection.Instance.GetConnection());

        //        using (SQLiteDataReader reader = command.ExecuteReader())
        //        {
        //            while (reader.Read())
        //            {
        //                MateriauxModel materiaux = new MateriauxModel();

        //                materiaux.NomMateriau = reader.GetString(0);
        //                materiaux.Categorie = reader.GetString(1);

        //                materiauxModels.Add(materiaux.NomMateriau, materiaux);
        //            }
        //        }

        //        return materiauxModels;
        //    }
        //    catch
        //    {
        //        throw;
        //    }
        //}
    }
}
