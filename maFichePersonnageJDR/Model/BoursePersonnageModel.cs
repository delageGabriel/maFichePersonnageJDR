using maFichePersonnageJDR.Classe;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maFichePersonnageJDR.Model
{
    class BoursePersonnageModel
    {
        /// <summary>
        /// Champs
        /// </summary>
        private int idBoursePersonnage;
        private int idPersonnage;
        private int pieceOr;
        private int pieceArgent;
        private int pieceCuivre;

        /// <summary>
        /// Accesseurs et mutateurs
        /// </summary>
        public int IdBoursePersonnage { get => idBoursePersonnage; set => idBoursePersonnage = value; }
        public int IdPersonnage { get => idPersonnage; set => idPersonnage = value; }
        public int PieceOr { get => pieceOr; set => pieceOr = value; }
        public int PieceArgent { get => pieceArgent; set => pieceArgent = value; }
        public int PieceCuivre { get => pieceCuivre; set => pieceCuivre = value; }

        public void SaveMonnaiePersonnage(int idPersonnage, int pieceOr, int pieceArgent, int pieceCuivre)
        {
            try
            {
                SQLiteCommand command = new SQLiteCommand("INSERT INTO BOURSE_PERSONNAGE (id_personnage, piece_or, piece_argent, piece_cuivre)" +
                    "VALUES (@idPersonnage, @pieceOr, @pieceArgent, @pieceCuivre)", DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@idPersonnage", idPersonnage);
                command.Parameters.AddWithValue("@pieceOr", pieceOr);
                command.Parameters.AddWithValue("@pieceArgent", pieceArgent);
                command.Parameters.AddWithValue("@pieceCuivre", pieceCuivre);

                int rowsAffected = command.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {

                throw ex;
            }
        }
    }
}
