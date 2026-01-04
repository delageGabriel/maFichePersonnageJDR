using System;
using System.Collections.Generic;
using maFichePersonnageJDR.Classe;
using System.Data.SQLite;

namespace maFichePersonnageJDR.Model
{
    class NewArmuresModel
    {  
        public List<string> GetArmureNamesByType(string type)
        {
            List<string> namesArmure = new List<string>();
            type = type.Replace(type, "%" + type + "%");

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();

                SQLiteCommand command = new SQLiteCommand(
                    "SELECT nom_armure " +
                    "FROM NEW_ARMURES " +
                    "WHERE type_armure LIKE @type;",
                DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@type", type);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        namesArmure.Add(reader.GetString(0));
                    }
                }

                return namesArmure;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public string GetArmureSizeByName(string name)
        {
            string armureSize = string.Empty;

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();

                SQLiteCommand command = new SQLiteCommand(
                    "SELECT taille_armure " +
                    "FROM NEW_ARMURES " +
                    "WHERE nom_armure = @name;",
                DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@name", name);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        armureSize = reader.GetString(0);
                    }
                }

                return armureSize;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public string GetArmureTypeByName(string name)
        {
            string typeArmure = string.Empty;

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();

                SQLiteCommand command = new SQLiteCommand(
                    "SELECT type_armure " +
                    "FROM NEW_ARMURES " +
                    "WHERE nom_armure = @name;",
                DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@name", name);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        typeArmure = reader.GetString(0);
                    }
                }

                return typeArmure;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public string GetArmurePrerequisByName(string name)
        {
            string armurePrerequis = string.Empty;

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();

                SQLiteCommand command = new SQLiteCommand(
                    "SELECT pre_requis_armure " +
                    "FROM NEW_ARMURES " +
                    "WHERE nom_armure = @name;",
                DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@name", name);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        armurePrerequis = reader.GetString(0);
                    }
                }

                return armurePrerequis;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public string GetArmureDefenseValueByName(string name)
        {
            string armureDefenseValue = string.Empty;

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();

                SQLiteCommand command = new SQLiteCommand(
                    "SELECT valeur_defense " +
                    "FROM NEW_ARMURES " +
                    "WHERE nom_armure = @name;",
                DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@name", name);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        armureDefenseValue = Convert.ToInt32(reader["valeur_defense"]).ToString();
                    }
                }

                return armureDefenseValue;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public string GetArmureTranchantReductionValueByName(string name)
        {
            string armureTranchantReduction = string.Empty;

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();

                SQLiteCommand command = new SQLiteCommand(
                    "SELECT reduc_tranchant " +
                    "FROM NEW_ARMURES " +
                    "WHERE nom_armure = @name;",
                DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@name", name);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        armureTranchantReduction = Convert.ToInt32(reader["reduc_tranchant"]).ToString();
                    }
                }

                return armureTranchantReduction;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public string GetArmureContondantReductionValueByName(string name)
        {
            string armureContondantReduction = string.Empty;

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();

                SQLiteCommand command = new SQLiteCommand(
                    "SELECT reduc_contendant " +
                    "FROM NEW_ARMURES " +
                    "WHERE nom_armure = @name;",
                DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@name", name);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        armureContondantReduction = Convert.ToInt32(reader["reduc_contendant"]).ToString();
                    }
                }

                return armureContondantReduction;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public string GetArmurePerforantReductionValueByName(string name)
        {
            string armurePerforantReduction = string.Empty;

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();

                SQLiteCommand command = new SQLiteCommand(
                    "SELECT reduc_perforant " +
                    "FROM NEW_ARMURES " +
                    "WHERE nom_armure = @name;",
                DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@name", name);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        armurePerforantReduction = Convert.ToInt32(reader["reduc_perforant"]).ToString();
                    }
                }

                return armurePerforantReduction;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public string GetArmureIgneeReductionValueByName(string name)
        {
            string armureIgneeReduction = string.Empty;

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();

                SQLiteCommand command = new SQLiteCommand(
                    "SELECT reduc_ignee " +
                    "FROM NEW_ARMURES " +
                    "WHERE nom_armure = @name;",
                DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@name", name);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        armureIgneeReduction = Convert.ToInt32(reader["reduc_ignee"]).ToString();
                    }
                }

                return armureIgneeReduction;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public string GetArmureAquatiqueReductionValueByName(string name)
        {
            string armureAquatiqueReduction = string.Empty;

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();

                SQLiteCommand command = new SQLiteCommand(
                    "SELECT reduc_aquatique " +
                    "FROM NEW_ARMURES " +
                    "WHERE nom_armure = @name;",
                DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@name", name);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        armureAquatiqueReduction = Convert.ToInt32(reader["reduc_aquatique"]).ToString();
                    }
                }

                return armureAquatiqueReduction;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public string GetArmureCelesteReductionValueByName(string name)
        {
            string armureCelesteReduction = string.Empty;

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();

                SQLiteCommand command = new SQLiteCommand(
                    "SELECT reduc_celeste " +
                    "FROM NEW_ARMURES " +
                    "WHERE nom_armure = @name;",
                DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@name", name);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        armureCelesteReduction = Convert.ToInt32(reader["reduc_celeste"]).ToString();
                    }
                }

                return armureCelesteReduction;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public string GetArmureTerrestreReductionValueByName(string name)
        {
            string armureTerrestreReduction = string.Empty;

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();

                SQLiteCommand command = new SQLiteCommand(
                    "SELECT reduc_terrestre " +
                    "FROM NEW_ARMURES " +
                    "WHERE nom_armure = @name;",
                DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@name", name);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        armureTerrestreReduction = Convert.ToInt32(reader["reduc_terrestre"]).ToString();
                    }
                }

                return armureTerrestreReduction;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public string GetArmureChocReductionValueByName(string name)
        {
            string armureChocReduction = string.Empty;

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();

                SQLiteCommand command = new SQLiteCommand(
                    "SELECT reduc_choc " +
                    "FROM NEW_ARMURES " +
                    "WHERE nom_armure = @name;",
                DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@name", name);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        armureChocReduction = Convert.ToInt32(reader["reduc_choc"]).ToString();
                    }
                }

                return armureChocReduction;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public string GetArmureAcideReductionValueByName(string name)
        {
            string armureAcideReduction = string.Empty;

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();

                SQLiteCommand command = new SQLiteCommand(
                    "SELECT reduc_acide " +
                    "FROM NEW_ARMURES " +
                    "WHERE nom_armure = @name;",
                DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@name", name);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        armureAcideReduction = Convert.ToInt32(reader["reduc_acide"]).ToString();
                    }
                }

                return armureAcideReduction;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public string GetArmurePressionReductionValueByName(string name)
        {
            string armurePressionReduction = string.Empty;

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();

                SQLiteCommand command = new SQLiteCommand(
                    "SELECT reduc_pression " +
                    "FROM NEW_ARMURES " +
                    "WHERE nom_armure = @name;",
                DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@name", name);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        armurePressionReduction = Convert.ToInt32(reader["reduc_pression"]).ToString();
                    }
                }

                return armurePressionReduction;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public string GetArmureWeightValueByName(string name)
        {
            string armureWeight = string.Empty;

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();

                SQLiteCommand command = new SQLiteCommand(
                    "SELECT poids_armure " +
                    "FROM NEW_ARMURES " +
                    "WHERE nom_armure = @name;",
                DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@name", name);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        armureWeight = Convert.ToInt32(reader["poids_armure"]).ToString();
                    }
                }

                return armureWeight;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public string GetArmureValueByName(string name)
        {
            string armureValue = string.Empty;

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();

                SQLiteCommand command = new SQLiteCommand(
                    "SELECT valeur_armure " +
                    "FROM NEW_ARMURES " +
                    "WHERE nom_armure = @name;",
                DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@name", name);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        armureValue = Convert.ToInt32(reader["valeur_armure"]).ToString();
                    }
                }

                return armureValue;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public string GetArmureDexteriteBonusByName(string name)
        {
            string armureBonusDexterite = string.Empty;

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();

                SQLiteCommand command = new SQLiteCommand(
                    "SELECT bonus_dexterite " +
                    "FROM NEW_ARMURES " +
                    "WHERE nom_armure = @name;",
                DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@name", name);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        armureBonusDexterite = Convert.ToInt32(reader["bonus_dexterite"]).ToString();
                    }
                }

                return armureBonusDexterite;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public string GetArmureInitiativeBonusByName(string name)
        {
            string armureBonusInitiative = string.Empty;

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();

                SQLiteCommand command = new SQLiteCommand(
                    "SELECT bonus_initiative " +
                    "FROM NEW_ARMURES " +
                    "WHERE nom_armure = @name;",
                DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@name", name);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        armureBonusInitiative = Convert.ToInt32(reader["bonus_initiative"]).ToString();
                    }
                }

                return armureBonusInitiative;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public string GetArmureVitesseBonusByName(string name)
        {
            string armureBonusVitesse = string.Empty;

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();

                SQLiteCommand command = new SQLiteCommand(
                    "SELECT bonus_vitesse " +
                    "FROM NEW_ARMURES " +
                    "WHERE nom_armure = @name;",
                DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@name", name);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        armureBonusVitesse = Convert.ToInt32(reader["bonus_vitesse"]).ToString();
                    }
                }

                return armureBonusVitesse;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public string GetArmureFroidBonusByName(string name)
        {
            string armureFroid = string.Empty;

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();

                SQLiteCommand command = new SQLiteCommand(
                    "SELECT bonus_froid " +
                    "FROM NEW_ARMURES " +
                    "WHERE nom_armure = @name;",
                DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@name", name);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        armureFroid = Convert.ToInt32(reader["bonus_froid"]).ToString();
                    }
                }

                return armureFroid;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public string GetArmureChaleurBonusByName(string name)
        {
            string armureChaleur = string.Empty;

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();

                SQLiteCommand command = new SQLiteCommand(
                    "SELECT bonus_chaleur " +
                    "FROM NEW_ARMURES " +
                    "WHERE nom_armure = @name;",
                DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@name", name);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        armureChaleur = Convert.ToInt32(reader["bonus_chaleur"]).ToString();
                    }
                }

                return armureChaleur;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public string GetArmureEffectByName(string name)
        {
            string armureEffets = string.Empty;

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();

                SQLiteCommand command = new SQLiteCommand(
                    "SELECT effet_armure " +
                    "FROM NEW_ARMURES " +
                    "WHERE nom_armure = @name;",
                DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@name", name);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        armureEffets = reader.GetString(0);
                    }
                }

                return armureEffets;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public string GetArmureCompositionByName(string name)
        {
            string armureComposition = string.Empty;

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();

                SQLiteCommand command = new SQLiteCommand(
                    "SELECT composition_armure " +
                    "FROM NEW_ARMURES " +
                    "WHERE nom_armure = @name;",
                DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@name", name);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        armureComposition = reader.GetString(0);
                    }
                }

                return armureComposition;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
