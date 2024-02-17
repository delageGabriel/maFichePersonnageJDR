using maFichePersonnageJDR.Classe;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maFichePersonnageJDR.Model
{
    class InventaireArmesPersonnagesModel
    {
        /// <summary>
        /// Champs
        /// </summary>
        private int idArmesPersonnages;
        private int idArme;
        private int idPersonnage;
        private int quantite;

        /// <summary>
        /// Accesseurs et mutateurs
        /// </summary>
        public int IdArmesPersonnages { get => idArmesPersonnages; set => idArmesPersonnages = value; }
        public int IdArme { get => idArme; set => idArme = value; }
        public int IdPersonnage { get => idPersonnage; set => idPersonnage = value; }
        public int Quantite { get => quantite; set => quantite = value; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idArme"></param>
        /// <param name="idPersonnage"></param>
        /// <param name="quantite"></param>
        public void SaveInventaireArmesPersonnage(int idArme, int idPersonnage, int quantite)
        {
            SQLiteTransaction transaction = DatabaseConnection.Instance.GetConnection().BeginTransaction();

            try
            {


                SQLiteCommand command = new SQLiteCommand("INSERT INTO INVENTAIRE_ARMES_PERSONNAGES (id_arme, id_personnage, quantite) " +
                "VALUES (@idArme, @idPersonnage, @quantite)", DatabaseConnection.Instance.GetConnection());

                command.Parameters.AddWithValue("@idArme", idArme);
                command.Parameters.AddWithValue("@idPersonnage", idPersonnage);
                command.Parameters.AddWithValue("@quantite", quantite);

                int rowsAffected = command.ExecuteNonQuery();

                // Vérification du nombre de lignes affectées
                if (rowsAffected > 0)
                {
                    Console.WriteLine("Insertion réussie. Nombre de lignes affectées : " + rowsAffected);

                    // Commit de la transaction si l'insertion s'est bien déroulée
                    transaction.Commit();
                }
                else
                {
                    Console.WriteLine("Aucune insertion effectuée. Aucune ligne n'a été affectée.");
                    // Vous pouvez lever une exception ou gérer le cas d'échec selon vos besoins.
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                // Assurez-vous de libérer les ressources même en cas d'exception
                transaction?.Dispose();
            }
        }
        /// <summary>
        /// Méthode qui permet de collecter la totalité des armes que le personnage
        /// possède.
        /// </summary>
        /// <param name="idPersonnage">L'ID du personnage dont il faut extraire les armes.</param>
        /// <returns>Le dictionnaire qui contient toutes les informations de toutes les armes du personnage</returns>
        public Dictionary<int, Tuple<ArmesModel, int>> GetArmesPersonnagesByIdPersonnage(int idPersonnage)
        {
            Dictionary<int, Tuple<ArmesModel, int>> dictionaryArmesPersonnage = new Dictionary<int, Tuple<ArmesModel, int>>();

            try
            {
                SQLiteCommand command = new SQLiteCommand("SELECT ARMES.id_armes," +
                    " ARMES.type_arme," +
                    " ARMES.nom_arme," +
                    " ARMES.poids_arme," +
                    " ARMES.allonge_arme," +
                    " ARMES.main_arme," +
                    " ARMES.deg_tranchant," +
                    " ARMES.deg_contondant," +
                    " ARMES.deg_perforant," +
                    " ARMES.deg_ignee," +
                    " ARMES.deg_aqua, " +
                    " ARMES.deg_celeste," +
                    " ARMES.deg_terrestre," +
                    " ARMES.valeur_arme," +
                    " ARMES.description_arme," +
                    " ARMES.description_courte_arme," +
                    " ARMES.special_arme," +
                    " INVENTAIRE_ARMES_PERSONNAGES.quantite FROM ARMES " +
                    " INNER JOIN INVENTAIRE_ARMES_PERSONNAGES ON ARMES.id_armes = INVENTAIRE_ARMES_PERSONNAGES.id_arme " +
                    " WHERE INVENTAIRE_ARMES_PERSONNAGES.id_personnage = @id_personnage", DatabaseConnection.Instance.GetConnection()
                    );
                command.Parameters.AddWithValue("@id_personnage", idPersonnage);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ArmesModel armesCaracteristiques = new ArmesModel();

                        int idArme = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                        armesCaracteristiques.TypeArme = reader.IsDBNull(1) ? "null" : reader.GetString(1);
                        armesCaracteristiques.NomArme = reader.IsDBNull(2) ? "null" : reader.GetString(2);
                        armesCaracteristiques.PoidsArmes = reader.IsDBNull(3) ? 0.0 : reader.GetDouble(3);
                        armesCaracteristiques.AllongeArmes = reader.IsDBNull(4) ? "null" : reader.GetString(4);
                        armesCaracteristiques.MainArmes = reader.IsDBNull(5) ? "null" : reader.GetString(5);
                        armesCaracteristiques.DegTranchant = reader.IsDBNull(6) ? "null" : reader.GetString(6);
                        armesCaracteristiques.DegContondant = reader.IsDBNull(7) ? "null" : reader.GetString(7);
                        armesCaracteristiques.DegPerforant = reader.IsDBNull(8) ? "null" : reader.GetString(8);
                        armesCaracteristiques.DegIgnee = reader.IsDBNull(9) ? "null" : reader.GetString(9);
                        armesCaracteristiques.DegAquatique = reader.IsDBNull(10) ? "null" : reader.GetString(10);
                        armesCaracteristiques.DegCeleste = reader.IsDBNull(11) ? "null" : reader.GetString(11);
                        armesCaracteristiques.DegTerrestre = reader.IsDBNull(12) ? "null" : reader.GetString(12);
                        armesCaracteristiques.ValeurArme = reader.IsDBNull(13) ? 0 : reader.GetInt32(13);
                        armesCaracteristiques.DescriptionArme = reader.IsDBNull(14) ? "null" : reader.GetString(14);
                        armesCaracteristiques.DescriptionCourteArme = reader.IsDBNull(15) ? "null" : reader.GetString(15);
                        armesCaracteristiques.SpecialArme = reader.IsDBNull(16) ? "null" : reader.GetString(16);
                        int quantite = reader.IsDBNull(17) ? 0 : reader.GetInt32(17);

                        Tuple<ArmesModel, int> tupleArmes = new Tuple<ArmesModel, int>(armesCaracteristiques, quantite);

                        dictionaryArmesPersonnage.Add(idArme, tupleArmes);
                    }
                }

                return dictionaryArmesPersonnage;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Une erreur s'est produite !" + ex.Message);
                throw;
            }
            finally
            {
                DatabaseConnection.Instance.CloseConnection();
            }
        }
        /// <summary>
        /// Supprime une arme de l'inventaire du personnage
        /// </summary>
        /// <param name="idArme"></param>
        public void DeleteFromInventairePersonnage(int idArme, int idPersonnage)
        {
            SQLiteTransaction transaction = DatabaseConnection.Instance.GetConnection().BeginTransaction();

            try
            {
                SQLiteCommand command = new SQLiteCommand("DELETE FROM INVENTAIRE_ARMES_PERSONNAGES " +
                    "WHERE id_arme = @idArme AND id_personnage = @idPersonnage", DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@idArme", idArme);
                command.Parameters.AddWithValue("@idPersonnage", idPersonnage);

                int rowsAffected = command.ExecuteNonQuery();

                // Vérification du nombre de lignes affectées
                if (rowsAffected > 0)
                {
                    Console.WriteLine("Suppression réussie. Nombre de lignes affectées : " + rowsAffected);

                    // Commit de la transaction si la suppression s'est bien déroulée
                    transaction.Commit();
                }
                else
                {
                    Console.WriteLine("Aucune suppression effectuée. Aucune ligne n'a été affectée.");
                    // Vous pouvez lever une exception ou gérer le cas d'échec selon vos besoins.
                }
            }
            catch (SQLiteException ex)
            {
                // En cas d'erreur, annulez la transaction
                transaction.Rollback();
                // Vous pouvez ajouter des journaux ou des messages de débogage ici pour diagnostiquer les erreurs.
                Console.WriteLine("Erreur lors de la suppression : " + ex.Message);
                throw ex; // Vous pouvez choisir de lever ou non l'exception après avoir traité les erreurs.
            }
            finally
            {
                // Assurez-vous de libérer les ressources même en cas d'exception
                transaction?.Dispose();
            }
        }

        /// <summary>
        /// Permet de mettre à jour la quantité d'une arme que le personnage possède déjà
        /// </summary>
        /// <param name="idArme"></param>
        /// <param name="idPersonnage"></param>
        /// <param name="nouvelleQte"></param>
        public void UpdateQuantityArmes(int idArme, int idPersonnage, int nouvelleQte)
        {
            try
            {
                SQLiteCommand command = new SQLiteCommand("UPDATE INVENTAIRE_ARMES_PERSONNAGES " +
                    "SET quantite = @nouvelleQuantite " +
                    "WHERE id_arme = @idArme AND id_personnage = @idPersonnage", DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@idArme", idArme);
                command.Parameters.AddWithValue("@idPersonnage", idPersonnage);
                command.Parameters.AddWithValue("@nouvelleQuantite", nouvelleQte);

                Console.WriteLine("Requête SQL : " + command.CommandText);
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine("Mise à jour réussie. Nombre de lignes affectées : " + rowsAffected);
                }
                else
                {
                    Console.WriteLine("Aucune mise à jour effectuée. Aucune ligne n'a été affectée.");
                }
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine("Erreur lors de la mise à jour : " + ex.Message);
                // Vous pouvez également imprimer la stack trace pour obtenir plus d'informations.
                Console.WriteLine("StackTrace : " + ex.StackTrace);
                throw ex;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idPersonnage"></param>
        /// <returns></returns>
        public List<string> GetArmesNameQuantityValueInInventaire(int idPersonnage)
        {
            List<string> nomArmes = new List<string>();
            List<string> valeurArmes = new List<string>();
            List<string> quantiteArmes = new List<string>();
            List<string> listToReturn = new List<string>();

            try
            {
                // Commande
                SQLiteCommand command = new SQLiteCommand(string.Format("SELECT ARMES.nom_arme, INVENTAIRE_ARMES_PERSONNAGES.quantite, ARMES.valeur_arme " +
                    "FROM ARMES " +
                    "INNER JOIN INVENTAIRE_ARMES_PERSONNAGES ON ARMES.id_armes = INVENTAIRE_ARMES_PERSONNAGES.id_arme " +
                    "WHERE INVENTAIRE_ARMES_PERSONNAGES.id_personnage = @idPersonnage"),
                    DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@idPersonnage", idPersonnage);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        InventaireArmesPersonnagesModel inventaireArmesPersonnages = new InventaireArmesPersonnagesModel();

                        // On vérifie si une ligne existe déjà avec le nom prénom du personnage
                        string name = reader["nom_arme"].ToString();
                        string quantite = reader["quantite"].ToString();
                        string valeur = reader["valeur_arme"].ToString();

                        nomArmes.Add(name);
                        quantiteArmes.Add(quantite);
                        valeurArmes.Add(valeur);
                    }
                }

                for (int i = 0; i < nomArmes.Count; i++)
                {
                    listToReturn.Add(nomArmes[i] + ", " + quantiteArmes[i] + ", " + valeurArmes[i]);
                }

                return listToReturn;
            }
            catch (SQLiteException e)
            {
                throw e;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idPersonnage"></param>
        /// <returns></returns>
        public decimal GetPoidsTotalArme(int idPersonnage)
        {
            decimal poidsTotal = 0;

            try
            {
                // Commande
                SQLiteCommand command = new SQLiteCommand(string.Format("SELECT SUM(armes.poids_arme * INVENTAIRE_ARMES_PERSONNAGES.quantite) AS poids_total " +
                    "FROM ARMES " +
                    "INNER JOIN INVENTAIRE_ARMES_PERSONNAGES ON ARMES.id_armes = INVENTAIRE_ARMES_PERSONNAGES.id_arme " +
                    "WHERE INVENTAIRE_ARMES_PERSONNAGES.id_personnage = @idPersonnage"),
                    DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@idPersonnage", idPersonnage);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Supposons que reader est votre objet SqlDataReader
                        poidsTotal = Convert.ToDecimal(reader["poids_total"] is DBNull ? 0 : reader["poids_total"]);
                    }
                }

                return poidsTotal;
            }
            catch (SQLiteException e)
            {
                throw e;
            }
        }

        public int GetQuantityArmesById(int idPersonnage, int idArme)
        {
            int quantity = 1;

            try
            {
                SQLiteCommand command = new SQLiteCommand("SELECT quantite " +
                    "FROM INVENTAIRE_ARMES_PERSONNAGES " +
                    "WHERE id_arme = @idArme AND id_personnage = @idPersonnage", DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@idPersonnage", idPersonnage);
                command.Parameters.AddWithValue("@idArme", idArme);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        quantity = Convert.ToInt32(reader["quantite"] is DBNull ? 0 : reader["quantite"]);
                    }
                }

                return quantity;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
