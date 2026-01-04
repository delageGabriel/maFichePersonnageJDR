CREATE TABLE NEW_ARMURES (
    id_armure INTEGER PRIMARY KEY AUTOINCREMENT,

    -- Informations générales
    nom_armure TEXT NOT NULL,
    taille_armure TEXT,
    type_armure TEXT,

    -- Défense
    valeur_defense INTEGER NOT NULL,

    -- Réduction des dégâts
    reduc_tranchant INTEGER DEFAULT 0,
    reduc_contendant INTEGER DEFAULT 0,
    reduc_perforant INTEGER DEFAULT 0,
    reduc_ignee INTEGER DEFAULT 0,
    reduc_aquatique INTEGER DEFAULT 0,
    reduc_celeste INTEGER DEFAULT 0,
    reduc_terrestre INTEGER DEFAULT 0,
    reduc_choc INTEGER DEFAULT 0,
    reduc_acide INTEGER DEFAULT 0,
    reduc_pression INTEGER DEFAULT 0,

    -- Poids & valeur
    poids_armure INTEGER,
    valeur_armure INTEGER,

    -- Bonus / Malus
    bonus_dexterite INTEGER DEFAULT 0,
    bonus_initiative INTEGER DEFAULT 0,
    bonus_vitesse INTEGER DEFAULT 0,
    bonus_froid INTEGER DEFAULT 0,
    bonus_chaleur INTEGER DEFAULT 0,

    -- Texte libre
    description_armure TEXT,
    composition_armure TEXT
);