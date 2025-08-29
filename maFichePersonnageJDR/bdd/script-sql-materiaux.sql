ou

-- CUIR TANNÉ

BEGIN TRANSACTION;

-- 1) Matériau
INSERT OR IGNORE INTO MATERIAUX (nom_materiau, categorie, realisme, description)
VALUES ('Cuir tanné', 'Transformé', 'reel', 'Cuir travaillé et assoupli, utilisé pour armures basiques');

-- 2) Coût & rareté (à ajuster si besoin)
INSERT OR IGNORE INTO MATERIAUX_COUTS (id_materiau, base_valeur, rarete)
SELECT id_materiau, 40, 2
FROM MATERIAUX
WHERE nom_materiau='Cuir tanné';

-- 3) Effets par qualité
-- ============ TRANCHANT ============
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 0  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant'  WHERE m.nom_materiau='Cuir tanné';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 1  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant'  WHERE m.nom_materiau='Cuir tanné';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, 2   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant'  WHERE m.nom_materiau='Cuir tanné';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, 4   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant'  WHERE m.nom_materiau='Cuir tanné';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, 6   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant'  WHERE m.nom_materiau='Cuir tanné';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 10  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant'  WHERE m.nom_materiau='Cuir tanné';

-- ============ CONTONDANT ============
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 0  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Cuir tanné';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 1  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Cuir tanné';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, 2   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Cuir tanné';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, 3   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Cuir tanné';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, 5   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Cuir tanné';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 7   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Cuir tanné';

-- ============ PERFORANT ============
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 1  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant'  WHERE m.nom_materiau='Cuir tanné';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant'  WHERE m.nom_materiau='Cuir tanné';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, 3   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant'  WHERE m.nom_materiau='Cuir tanné';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, 4   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant'  WHERE m.nom_materiau='Cuir tanné';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, 6   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant'  WHERE m.nom_materiau='Cuir tanné';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 9   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant'  WHERE m.nom_materiau='Cuir tanné';

-- ============ IGNÉE ============
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -9 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee'      WHERE m.nom_materiau='Cuir tanné';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -6 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee'      WHERE m.nom_materiau='Cuir tanné';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, -4  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee'      WHERE m.nom_materiau='Cuir tanné';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, -3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee'      WHERE m.nom_materiau='Cuir tanné';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, -2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee'      WHERE m.nom_materiau='Cuir tanné';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, -1  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee'      WHERE m.nom_materiau='Cuir tanné';

-- ============ TERRESTRE ============
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 0  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre'  WHERE m.nom_materiau='Cuir tanné';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 1  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre'  WHERE m.nom_materiau='Cuir tanné';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, 2   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre'  WHERE m.nom_materiau='Cuir tanné';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, 3   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre'  WHERE m.nom_materiau='Cuir tanné';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, 5   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre'  WHERE m.nom_materiau='Cuir tanné';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 8   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre'  WHERE m.nom_materiau='Cuir tanné';

COMMIT;

-- BOIS

BEGIN TRANSACTION;

-- 1) Matériau
INSERT OR IGNORE INTO MATERIAUX (nom_materiau, categorie, realisme, description)
VALUES ('Bois', 'Végétal', 'reel', 'Matériau organique solide, utilisé pour boucliers et armures rudimentaires');

-- 2) Coût & rareté (à ajuster si besoin)
INSERT OR IGNORE INTO MATERIAUX_COUTS (id_materiau, base_valeur, rarete)
SELECT id_materiau, 30, 1
FROM MATERIAUX
WHERE nom_materiau='Bois';

-- 3) Effets par qualité
-- ============ TRANCHANT ============
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 1  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant'  WHERE m.nom_materiau='Bois';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant'  WHERE m.nom_materiau='Bois';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, 3   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant'  WHERE m.nom_materiau='Bois';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, 5   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant'  WHERE m.nom_materiau='Bois';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, 7   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant'  WHERE m.nom_materiau='Bois';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 11  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant'  WHERE m.nom_materiau='Bois';

-- ============ CONTONDANT ============
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 0  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Bois';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 1  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Bois';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, 2   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Bois';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, 3   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Bois';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, 5   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Bois';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 7   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Bois';

-- ============ PERFORANT ============
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 0  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant'  WHERE m.nom_materiau='Bois';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 1  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant'  WHERE m.nom_materiau='Bois';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, 2   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant'  WHERE m.nom_materiau='Bois';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, 3   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant'  WHERE m.nom_materiau='Bois';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, 5   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant'  WHERE m.nom_materiau='Bois';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 8   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant'  WHERE m.nom_materiau='Bois';

-- ============ IGNÉE ============
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -26 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Bois';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -17 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Bois';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, -11  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Bois';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, -8   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Bois';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, -5   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Bois';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, -3   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Bois';

-- ============ AQUATIQUE ============
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -9  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Bois';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -6  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Bois';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, -4   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Bois';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, -3   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Bois';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, -2   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Bois';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, -1   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Bois';

COMMIT;

-- BEGIN TRANSACTION;

-- 1) Matériau
INSERT OR IGNORE INTO MATERIAUX (nom_materiau, categorie, realisme, description)
VALUES ('Roche', 'Minéral', 'reel', 'Matière solide, dense et rigide, utilisée pour armures massives ou golems');

-- 2) Coût & rareté (à ajuster selon ton équilibrage)
INSERT OR IGNORE INTO MATERIAUX_COUTS (id_materiau, base_valeur, rarete)
SELECT id_materiau, 80, 2
FROM MATERIAUX
WHERE nom_materiau='Roche';

-- 3) Effets par qualité
-- ============ TRANCHANT ============
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Roche';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Roche';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, 5   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Roche';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, 7   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Roche';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, 11  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Roche';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 17  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Roche';

-- ============ CONTONDANT ============
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 1  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Roche';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Roche';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, 3   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Roche';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, 4   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Roche';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, 6   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Roche';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 9   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Roche';

-- ============ PERFORANT ============
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 0  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Roche';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 1  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Roche';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, 2   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Roche';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, 4   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Roche';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, 6   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Roche';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 10  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Roche';

-- ============ IGNÉE ============
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 0  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Roche';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 1  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Roche';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, 2   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Roche';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, 3   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Roche';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, 5   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Roche';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 8   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Roche';

-- ============ AQUATIQUE ============
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -6 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Roche';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Roche';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, -3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Roche';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, -2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Roche';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, -1  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Roche';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 0   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Roche';

-- ============ CÉLESTE ============
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -6 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Roche';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Roche';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, -3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Roche';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, -2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Roche';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, -1  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Roche';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 0   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Roche';

-- ============ TERRESTRE ============
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Roche';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Roche';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, 4   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Roche';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, 7   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Roche';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, 10  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Roche';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 15  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Roche';

COMMIT;

-- CHAIR PUTRÉFIÉE

BEGIN TRANSACTION;

-- 1) Matériau
INSERT OR IGNORE INTO MATERIAUX (nom_materiau, categorie, realisme, description)
VALUES ('Chair Putréfiée', 'Organique', 'fantasy', 'Tissus en décomposition, extrêmement vulnérables, utilisés pour des créatures mortes-vivantes.');

-- 2) Coût & rareté (faible valeur car c’est de la chair abîmée)
INSERT OR IGNORE INTO MATERIAUX_COUTS (id_materiau, base_valeur, rarete)
SELECT id_materiau, 5, 1
FROM MATERIAUX
WHERE nom_materiau='Chair Putréfiée';

-- 3) Effets par qualité
-- ============ TRANCHANT ============
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -33 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Chair Putréfiée';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -22 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Chair Putréfiée';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, -15  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Chair Putréfiée';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, -10  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Chair Putréfiée';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, -6   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Chair Putréfiée';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, -4   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Chair Putréfiée';

-- ============ CONTONDANT ============
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -28 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Chair Putréfiée';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -19 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Chair Putréfiée';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, -12  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Chair Putréfiée';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, -8   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Chair Putréfiée';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, -5   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Chair Putréfiée';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, -4   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Chair Putréfiée';

-- ============ PERFORANT ============
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -29 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Chair Putréfiée';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -19 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Chair Putréfiée';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, -13  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Chair Putréfiée';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, -8   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Chair Putréfiée';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, -6   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Chair Putréfiée';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, -4   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Chair Putréfiée';

-- ============ IGNÉE ============
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -40 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Chair Putréfiée';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -27 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Chair Putréfiée';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, -18  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Chair Putréfiée';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, -12  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Chair Putréfiée';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, -8   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Chair Putréfiée';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, -5   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Chair Putréfiée';

-- ============ AQUATIQUE ============
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -30 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Chair Putréfiée';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -20 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Chair Putréfiée';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, -13  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Chair Putréfiée';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, -9   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Chair Putréfiée';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, -6   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Chair Putréfiée';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, -4   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Chair Putréfiée';

-- ============ CÉLESTE ============
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -30 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Chair Putréfiée';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -20 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Chair Putréfiée';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, -13  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Chair Putréfiée';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, -9   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Chair Putréfiée';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, -6   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Chair Putréfiée';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, -4   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Chair Putréfiée';

-- ============ TERRESTRE ============
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -30 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Chair Putréfiée';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -20 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Chair Putréfiée';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, -13  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Chair Putréfiée';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, -9   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Chair Putréfiée';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, -6   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Chair Putréfiée';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, -4   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Chair Putréfiée';

COMMIT;

-- ARGILE

-- 1) Matériau
INSERT OR IGNORE INTO MATERIAUX (nom_materiau, categorie, realisme, description)
VALUES ('Argile', 'Minéral', 'reel', 'Argile compactée/séchée, très bonne contre les chocs et l eau, faible contre feu.');

-- 2) Coût & rareté (base = valeur à qualité 0)
INSERT OR IGNORE INTO MATERIAUX_COUTS (id_materiau, base_valeur, rarete)
SELECT id_materiau, 30, 2
FROM MATERIAUX
WHERE nom_materiau='Argile';

-- 3) Effets (id_materiau, id_effet, qualite, valeur)

-- Tranchant
INSERT OR REPLACE INTO MATERIAUX_EFFETS
SELECT (SELECT id_materiau FROM MATERIAUX WHERE nom_materiau='Argile'),
       (SELECT id_effet FROM REF_EFFETS WHERE code='tranchant'),
       q, v
FROM (
  SELECT -2 AS q,  0 AS v
  UNION ALL SELECT -1, -1
  UNION ALL SELECT  0, -2
  UNION ALL SELECT  1, -3
  UNION ALL SELECT  2, -5
  UNION ALL SELECT  3, -8
);

-- Contondant
INSERT OR REPLACE INTO MATERIAUX_EFFETS
SELECT (SELECT id_materiau FROM MATERIAUX WHERE nom_materiau='Argile'),
       (SELECT id_effet FROM REF_EFFETS WHERE code='contondant'),
       q, v
FROM (
  SELECT -2 AS q, 19 AS v
  UNION ALL SELECT -1, 13
  UNION ALL SELECT  0,  8
  UNION ALL SELECT  1,  6
  UNION ALL SELECT  2,  4
  UNION ALL SELECT  3,  2
);

-- Perforant
INSERT OR REPLACE INTO MATERIAUX_EFFETS
SELECT (SELECT id_materiau FROM MATERIAUX WHERE nom_materiau='Argile'),
       (SELECT id_effet FROM REF_EFFETS WHERE code='perforant'),
       q, v
FROM (
  SELECT -2 AS q, -1 AS v
  UNION ALL SELECT -1, -2
  UNION ALL SELECT  0, -3
  UNION ALL SELECT  1, -5
  UNION ALL SELECT  2, -7
  UNION ALL SELECT  3, -11
);

-- Ignée
INSERT OR REPLACE INTO MATERIAUX_EFFETS
SELECT (SELECT id_materiau FROM MATERIAUX WHERE nom_materiau='Argile'),
       (SELECT id_effet FROM REF_EFFETS WHERE code='ignee'),
       q, v
FROM (
  SELECT -2 AS q, -1 AS v
  UNION ALL SELECT -1, -2
  UNION ALL SELECT  0, -4
  UNION ALL SELECT  1, -6
  UNION ALL SELECT  2, -9
  UNION ALL SELECT  3, -13
);

-- Aquatique
INSERT OR REPLACE INTO MATERIAUX_EFFETS
SELECT (SELECT id_materiau FROM MATERIAUX WHERE nom_materiau='Argile'),
       (SELECT id_effet FROM REF_EFFETS WHERE code='aquatique'),
       q, v
FROM (
  SELECT -2 AS q, 26 AS v
  UNION ALL SELECT -1, 17
  UNION ALL SELECT  0, 11
  UNION ALL SELECT  1,  8
  UNION ALL SELECT  2,  5
  UNION ALL SELECT  3,  3
);

-- Céleste
INSERT OR REPLACE INTO MATERIAUX_EFFETS
SELECT (SELECT id_materiau FROM MATERIAUX WHERE nom_materiau='Argile'),
       (SELECT id_effet FROM REF_EFFETS WHERE code='celeste'),
       q, v
FROM (
  SELECT -2 AS q,  9 AS v
  UNION ALL SELECT -1,  6
  UNION ALL SELECT  0,  4
  UNION ALL SELECT  1,  3
  UNION ALL SELECT  2,  2
  UNION ALL SELECT  3,  1
);

-- Terrestre
INSERT OR REPLACE INTO MATERIAUX_EFFETS
SELECT (SELECT id_materiau FROM MATERIAUX WHERE nom_materiau='Argile'),
       (SELECT id_effet FROM REF_EFFETS WHERE code='terrestre'),
       q, v
FROM (
  SELECT -2 AS q,  5 AS v
  UNION ALL SELECT -1,  3
  UNION ALL SELECT  0,  2
  UNION ALL SELECT  1,  1
  UNION ALL SELECT  2,  0
  UNION ALL SELECT  3, -1
);

-- ===== BONUS / MALUS =====

-- Poisons
INSERT OR REPLACE INTO MATERIAUX_EFFETS
SELECT (SELECT id_materiau FROM MATERIAUX WHERE nom_materiau='Argile'),
       (SELECT id_effet FROM REF_EFFETS WHERE code='poisons'), q, v
FROM (
  SELECT -2 AS q, -1 AS v
  UNION ALL SELECT -1, -1
  UNION ALL SELECT  0, -2
  UNION ALL SELECT  1, -3
  UNION ALL SELECT  2, -4
  UNION ALL SELECT  3, -6
);

-- Paralysie
INSERT OR REPLACE INTO MATERIAUX_EFFETS
SELECT (SELECT id_materiau FROM MATERIAUX WHERE nom_materiau='Argile'),
       (SELECT id_effet FROM REF_EFFETS WHERE code='paralysie'), q, v
FROM (
  SELECT -2 AS q, -1 AS v
  UNION ALL SELECT -1, -1
  UNION ALL SELECT  0, -2
  UNION ALL SELECT  1, -3
  UNION ALL SELECT  2, -5
  UNION ALL SELECT  3, -7
);

-- Malédictions (0 partout)
INSERT OR REPLACE INTO MATERIAUX_EFFETS
SELECT (SELECT id_materiau FROM MATERIAUX WHERE nom_materiau='Argile'),
       (SELECT id_effet FROM REF_EFFETS WHERE code='maledictions'), q, v
FROM (
  SELECT -2 AS q, 0 AS v
  UNION ALL SELECT -1, 0
  UNION ALL SELECT  0, 0
  UNION ALL SELECT  1, 0
  UNION ALL SELECT  2, 0
  UNION ALL SELECT  3, 0
);

-- Saignement
INSERT OR REPLACE INTO MATERIAUX_EFFETS
SELECT (SELECT id_materiau FROM MATERIAUX WHERE nom_materiau='Argile'),
       (SELECT id_effet FROM REF_EFFETS WHERE code='saignement'), q, v
FROM (
  SELECT -2 AS q,  0 AS v
  UNION ALL SELECT -1,  0
  UNION ALL SELECT  0, -2
  UNION ALL SELECT  1, -3
  UNION ALL SELECT  2, -5
  UNION ALL SELECT  3, -10
);

-- Choc
INSERT OR REPLACE INTO MATERIAUX_EFFETS
SELECT (SELECT id_materiau FROM MATERIAUX WHERE nom_materiau='Argile'),
       (SELECT id_effet FROM REF_EFFETS WHERE code='choc'), q, v
FROM (
  SELECT -2 AS q,  1 AS v
  UNION ALL SELECT -1,  1
  UNION ALL SELECT  0,  0
  UNION ALL SELECT  1, -2
  UNION ALL SELECT  2, -4
  UNION ALL SELECT  3, -6
);

-- Maladies
INSERT OR REPLACE INTO MATERIAUX_EFFETS
SELECT (SELECT id_materiau FROM MATERIAUX WHERE nom_materiau='Argile'),
       (SELECT id_effet FROM REF_EFFETS WHERE code='maladies'), q, v
FROM (
  SELECT -2 AS q,  0 AS v
  UNION ALL SELECT -1, -1
  UNION ALL SELECT  0, -2
  UNION ALL SELECT  1, -3
  UNION ALL SELECT  2, -5
  UNION ALL SELECT  3, -8
);

-- Acide
INSERT OR REPLACE INTO MATERIAUX_EFFETS
SELECT (SELECT id_materiau FROM MATERIAUX WHERE nom_materiau='Argile'),
       (SELECT id_effet FROM REF_EFFETS WHERE code='acide'), q, v
FROM (
  SELECT -2 AS q,  1 AS v
  UNION ALL SELECT -1,  0
  UNION ALL SELECT  0, -2
  UNION ALL SELECT  1, -3
  UNION ALL SELECT  2, -5
  UNION ALL SELECT  3, -7
);

-- ===== Chute / Températures / Initiative / Vitesse / Dextérité =====

-- Chute
INSERT OR REPLACE INTO MATERIAUX_EFFETS
SELECT (SELECT id_materiau FROM MATERIAUX WHERE nom_materiau='Argile'),
       (SELECT id_effet FROM REF_EFFETS WHERE code='chute'), q, v
FROM (
  SELECT -2 AS q,  2 AS v
  UNION ALL SELECT -1,  1
  UNION ALL SELECT  0,  0
  UNION ALL SELECT  1,  0
  UNION ALL SELECT  2, -1
  UNION ALL SELECT  3, -2
);

-- Chaleur (°C)
INSERT OR REPLACE INTO MATERIAUX_EFFETS
SELECT (SELECT id_materiau FROM MATERIAUX WHERE nom_materiau='Argile'),
       (SELECT id_effet FROM REF_EFFETS WHERE code='chaleur'), q, v
FROM (
  SELECT -2 AS q, 24 AS v
  UNION ALL SELECT -1, 25
  UNION ALL SELECT  0, 25
  UNION ALL SELECT  1, 26
  UNION ALL SELECT  2, 26
  UNION ALL SELECT  3, 27
);

-- Froid (°C)
INSERT OR REPLACE INTO MATERIAUX_EFFETS
SELECT (SELECT id_materiau FROM MATERIAUX WHERE nom_materiau='Argile'),
       (SELECT id_effet FROM REF_EFFETS WHERE code='froid'), q, v
FROM (
  SELECT -2 AS q, 19 AS v
  UNION ALL SELECT -1, 18
  UNION ALL SELECT  0, 17
  UNION ALL SELECT  1, 16
  UNION ALL SELECT  2, 15
  UNION ALL SELECT  3, 14
);

-- Initiative
INSERT OR REPLACE INTO MATERIAUX_EFFETS
SELECT (SELECT id_materiau FROM MATERIAUX WHERE nom_materiau='Argile'),
       (SELECT id_effet FROM REF_EFFETS WHERE code='initiative'), q, v
FROM (
  SELECT -2 AS q, 0 AS v
  UNION ALL SELECT -1, 0
  UNION ALL SELECT  0, 0
  UNION ALL SELECT  1, 0
  UNION ALL SELECT  2, 0
  UNION ALL SELECT  3, 0
);

-- Vitesse (m)
INSERT OR REPLACE INTO MATERIAUX_EFFETS
SELECT (SELECT id_materiau FROM MATERIAUX WHERE nom_materiau='Argile'),
       (SELECT id_effet FROM REF_EFFETS WHERE code='vitesse'), q, v
FROM (
  SELECT -2 AS q, 0 AS v
  UNION ALL SELECT -1, 0
  UNION ALL SELECT  0, 0
  UNION ALL SELECT  1, 0
  UNION ALL SELECT  2, 0
  UNION ALL SELECT  3, 0
);

-- Dextérité
INSERT OR REPLACE INTO MATERIAUX_EFFETS
SELECT (SELECT id_materiau FROM MATERIAUX WHERE nom_materiau='Argile'),
       (SELECT id_effet FROM REF_EFFETS WHERE code='dexterite'), q, v
FROM (
  SELECT -2 AS q, 0 AS v
  UNION ALL SELECT -1, 0
  UNION ALL SELECT  0, 0
  UNION ALL SELECT  1, 0
  UNION ALL SELECT  2, 0
  UNION ALL SELECT  3, 0
);

-- 4) Poids par qualité
INSERT OR REPLACE INTO MATERIAUX_POIDS (id_materiau, qualite, poids)
SELECT (SELECT id_materiau FROM MATERIAUX WHERE nom_materiau='Argile'),
       q, p
FROM (
  SELECT -2 AS q,  9 AS p
  UNION ALL SELECT -1,  9
  UNION ALL SELECT  0, 12
  UNION ALL SELECT  1, 14
  UNION ALL SELECT  2, 14
  UNION ALL SELECT  3, 17
);

-- 5) Valeur par qualité
INSERT OR REPLACE INTO MATERIAUX_VALEUR (id_materiau, qualite, valeur)
SELECT (SELECT id_materiau FROM MATERIAUX WHERE nom_materiau='Argile'),
       q, v
FROM (
  SELECT -2 AS q,  7 AS v
  UNION ALL SELECT -1, 10
  UNION ALL SELECT  0, 30
  UNION ALL SELECT  1, 50
  UNION ALL SELECT  2, 100
  UNION ALL SELECT  3, 200
);

-- OSSEMENTS

BEGIN TRANSACTION;

-- 1) Matériau
INSERT OR IGNORE INTO MATERIAUX (nom_materiau, categorie, realisme, description)
VALUES ('Ossements', 'Organique', 'réaliste', 'Fragments osseux utilisés comme protection. Cassants mais relativement résistants aux armes de base.');

-- 2) Coût & rareté (plutôt faible, ressource commune)
INSERT OR IGNORE INTO MATERIAUX_COUTS (id_materiau, base_valeur, rarete)
SELECT id_materiau, 12, 1
FROM MATERIAUX
WHERE nom_materiau='Ossements';

-- 3) Effets par qualité
-- ============ TRANCHANT ============
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 1  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Ossements';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Ossements';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, 3   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Ossements';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, 4   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Ossements';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, 6   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Ossements';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 9   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Ossements';

-- ============ CONTONDANT ============
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 0  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Ossements';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 1  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Ossements';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, 2   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Ossements';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, 3   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Ossements';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, 5   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Ossements';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 7   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Ossements';

-- ============ PERFORANT ============
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 0  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Ossements';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 1  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Ossements';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, 2   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Ossements';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, 3   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Ossements';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, 5   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Ossements';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 7   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Ossements';

-- ============ IGNÉE ============
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -20 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Ossements';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -13 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Ossements';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, -9   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Ossements';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, -6   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Ossements';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, -4   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Ossements';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, -3   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Ossements';

-- ============ AQUATIQUE ============
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -10 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Ossements';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -7  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Ossements';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, -4  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Ossements';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, -3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Ossements';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, -2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Ossements';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, -1  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Ossements';

-- ============ CÉLESTE ============
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -10 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Ossements';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -7  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Ossements';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, -4  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Ossements';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, -3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Ossements';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, -2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Ossements';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, -1  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Ossements';

-- ============ TERRESTRE ============
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -1 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Ossements';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 0  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Ossements';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, 1  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Ossements';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, 2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Ossements';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, 3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Ossements';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 5  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Ossements';

COMMIT;

-- CUIVRE

BEGIN TRANSACTION;

-- 1) Matériau
INSERT OR IGNORE INTO MATERIAUX (nom_materiau, categorie, realisme, description)
VALUES ('Cuivre', 'Métallique', 'réaliste', 'Métal rouge malléable, utilisé dans certaines armures primitives. Bon contre le physique mais vulnérable à l’énergie céleste et à la chaleur.');

-- 2) Coût & rareté (métal commun)
INSERT OR IGNORE INTO MATERIAUX_COUTS (id_materiau, base_valeur, rarete)
SELECT id_materiau, 25, 2
FROM MATERIAUX
WHERE nom_materiau='Cuivre';

-- 3) Effets par qualité
-- ============ TRANCHANT ============
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Cuivre';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Cuivre';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, 4   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Cuivre';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, 6   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Cuivre';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, 9   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Cuivre';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 14  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Cuivre';

-- ============ CONTONDANT ============
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 1  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Cuivre';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Cuivre';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, 3   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Cuivre';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, 4   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Cuivre';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, 6   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Cuivre';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 9   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Cuivre';

-- ============ PERFORANT ============
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 1  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Cuivre';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Cuivre';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, 3   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Cuivre';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, 5   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Cuivre';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, 7   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Cuivre';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 11  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Cuivre';

-- ============ IGNÉE ============
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -16 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Cuivre';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -11 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Cuivre';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, -7   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Cuivre';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, -5   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Cuivre';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, -3   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Cuivre';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, -2   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Cuivre';

-- ============ AQUATIQUE ============
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 0  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Cuivre';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 1  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Cuivre';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, 2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Cuivre';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, 3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Cuivre';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, 5  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Cuivre';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 8  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Cuivre';

-- ============ CÉLESTE ============
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -20 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Cuivre';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -13 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Cuivre';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, -9   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Cuivre';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, -6   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Cuivre';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, -4   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Cuivre';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, -3   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Cuivre';

-- ============ TERRESTRE ============
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -7 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Cuivre';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -5 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Cuivre';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, -3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Cuivre';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, -2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Cuivre';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, -1  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Cuivre';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 0   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Cuivre';

COMMIT;

-- FER

BEGIN TRANSACTION;

-- 1) Matériau
INSERT OR IGNORE INTO MATERIAUX (nom_materiau, categorie, realisme, description)
VALUES ('Fer', 'Métallique', 'réaliste', 'Métal dur et lourd. Offre une bonne protection physique, mais vulnérable à l’eau, à la chaleur et aux énergies célestes.');

-- 2) Coût & rareté
INSERT OR IGNORE INTO MATERIAUX_COUTS (id_materiau, base_valeur, rarete)
SELECT id_materiau, 40, 3
FROM MATERIAUX
WHERE nom_materiau='Fer';

-- 3) Effets par qualité
-- ============ TRANCHANT ============
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Fer';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Fer';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, 5   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Fer';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, 7   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Fer';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, 11  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Fer';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 16  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Fer';

-- ============ CONTONDANT ============
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 1  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Fer';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Fer';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, 3   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Fer';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, 5   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Fer';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, 7   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Fer';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 11  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Fer';

-- ============ PERFORANT ============
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Fer';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Fer';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, 4   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Fer';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, 6   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Fer';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, 9   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Fer';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 14  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Fer';

-- ============ IGNÉE ============
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -14 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Fer';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -9  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Fer';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, -6   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Fer';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, -4   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Fer';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, -3   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Fer';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, -2   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Fer';

-- ============ AQUATIQUE ============
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -17 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Fer';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -11 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Fer';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, -7   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Fer';
INSERT OR REPLACE INT

-- ACIER

BEGIN TRANSACTION;

-- 1) Matériau
INSERT OR IGNORE INTO MATERIAUX (nom_materiau, categorie, realisme, description)
VALUES ('Acier', 'Métallique', 'réaliste', 'Alliage de fer et de carbone. Très solide et résistant aux attaques physiques, mais vulnérable à la rouille et aux énergies magiques.');

-- 2) Coût & rareté
INSERT OR IGNORE INTO MATERIAUX_COUTS (id_materiau, base_valeur, rarete)
SELECT id_materiau, 60, 4
FROM MATERIAUX
WHERE nom_materiau='Acier';

-- 3) Effets par qualité
-- ============ TRANCHANT ============
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Acier';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Acier';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, 5   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Acier';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, 8   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Acier';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, 12  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Acier';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 18  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Acier';

-- ============ CONTONDANT ============
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 1  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Acier';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Acier';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, 4   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Acier';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, 6   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Acier';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, 9   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Acier';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 13  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Acier';

-- ============ PERFORANT ============
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Acier';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Acier';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, 5   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Acier';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, 7   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Acier';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, 11  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Acier';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 16  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Acier';

-- ============ IGNÉE ============
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -12 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Acier';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -8  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Acier';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, -5   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Acier';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, -3   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Acier';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, -2   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Acier';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, -1   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Acier';

-- ============ AQUATIQUE ============
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -17 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Acier';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -11 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Acier';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, -7   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Acier';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, -5   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Acier';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, -3   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Acier';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, -1   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Acier';

-- ============ CÉLESTE ============
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -18 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Acier';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -12 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Acier';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, -5   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Acier';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, -3   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Acier';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, -2   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Acier';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, -1   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Acier';

-- ============ TERRESTRE ============
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -6 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Acier';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Acier';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, -3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Acier';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, -2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Acier';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, -1  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Acier';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 0   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Acier';

COMMIT;

-- ARGENT

BEGIN TRANSACTION;

-- 1) Matériau
INSERT OR IGNORE INTO MATERIAUX (nom_materiau, categorie, realisme, description)
VALUES ('Argent', 'Métallique', 'réaliste', 'Métal précieux et ductile. Bon tranchant et perforant, faible contre les énergies célestes.');

-- 2) Coût & rareté
INSERT OR IGNORE INTO MATERIAUX_COUTS (id_materiau, base_valeur, rarete)
SELECT id_materiau, 100, 5
FROM MATERIAUX
WHERE nom_materiau='Argent';

-- 3) Effets par qualité
-- ============ TRANCHANT ============
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 1  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Argent';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Argent';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, 5   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Argent';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, 7   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Argent';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, 11  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Argent';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 17  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Argent';

-- ============ PERFORANT ============
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 1  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Argent';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Argent';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, 3   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Argent';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, 4   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Argent';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, 7   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Argent';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 10  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Argent';

-- ============ IGNÉE ============
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -8 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Argent';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -5 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Argent';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, -3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Argent';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, -2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Argent';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, -1  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Argent';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 0   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Argent';

-- ============ AQUATIQUE ============
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 1  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Argent';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Argent';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, 3   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Argent';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, 4   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Argent';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, 7   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Argent';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 10  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Argent';

-- ============ CÉLESTE ============
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -24 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Argent';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -16 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Argent';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, -11  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Argent';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, -7   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Argent';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, -5   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Argent';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, -3   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Argent';

-- ============ TERRESTRE ============
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -11 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Argent';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -7  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Argent';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, -5   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Argent';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, -3   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Argent';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, -2   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Argent';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, -1   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Argent';

COMMIT;

-- OR

BEGIN TRANSACTION;

-- 1) Matériau
INSERT OR IGNORE INTO MATERIAUX (nom_materiau, categorie, realisme, description)
VALUES ('Or', 'Métallique', 'réaliste', 'Métal précieux, très ductile et malléable. Faible physiquement mais conducteur des énergies.');

-- 2) Coût & rareté
INSERT OR IGNORE INTO MATERIAUX_COUTS (id_materiau, base_valeur, rarete)
SELECT id_materiau, 150, 6
FROM MATERIAUX
WHERE nom_materiau='Or';

-- 3) Effets par qualité
-- ============ TRANCHANT ============
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -6 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Or';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Or';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, -3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Or';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, -2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Or';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, -1  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Or';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 0   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Or';

-- ============ CONTONDANT ============
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -8 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Or';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -5 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Or';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, -3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Or';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, -2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Or';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, -1  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Or';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 0   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Or';

-- ============ PERFORANT ============
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -7 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Or';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -5 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Or';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, -3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Or';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, -2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Or';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, -1  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Or';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 0   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Or';

-- ============ IGNÉE ============
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 1 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Or';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Or';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, 3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Or';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, 4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Or';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, 6 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Or';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 9 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Or';

-- ============ AQUATIQUE ============
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Or';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Or';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, 4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Or';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, 7 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Or';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, 10 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Or';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 15 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Or';

-- ============ CÉLESTE ============
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -22 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Or';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -14 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Or';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, -10 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Or';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, -6  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Or';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, -4  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Or';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, -3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Or';

-- ============ TERRESTRE ============
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 0 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Or';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 1 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Or';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, 2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Or';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, 3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Or';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, 5 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Or';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 8 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Or';

COMMIT;

-- METAL NOBLE
BEGIN TRANSACTION;

-- 1) Matériau
INSERT OR IGNORE INTO MATERIAUX (nom_materiau, categorie, realisme, description)
VALUES ('Métal Noble', 'Métallique', 'fantaisiste', 'Alliage rare et précieux, stable et polyvalent. Excellente résistance générale.');

-- 2) Coût & rareté
INSERT OR IGNORE INTO MATERIAUX_COUTS (id_materiau, base_valeur, rarete)
SELECT id_materiau, 300, 8
FROM MATERIAUX
WHERE nom_materiau='Métal Noble';

-- 3) Effets par qualité
-- TRANCHANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Métal Noble';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Métal Noble';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, 4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Métal Noble';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, 7 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Métal Noble';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, 10 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Métal Noble';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 15 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Métal Noble';

-- CONTONDANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Métal Noble';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Métal Noble';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, 4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Métal Noble';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, 7 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Métal Noble';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, 10 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Métal Noble';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 15 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Métal Noble';

-- PERFORANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Métal Noble';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Métal Noble';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, 4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Métal Noble';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, 7 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Métal Noble';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, 10 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Métal Noble';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 15 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Métal Noble';

-- IGNÉE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 0 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Métal Noble';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 1 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Métal Noble';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, 2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Métal Noble';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, 3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Métal Noble';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, 5 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Métal Noble';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 7 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Métal Noble';

-- AQUATIQUE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 0 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Métal Noble';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 1 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Métal Noble';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, 2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Métal Noble';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, 3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Métal Noble';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, 5 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Métal Noble';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 7 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Métal Noble';

-- CÉLESTE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 0 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Métal Noble';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 1 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Métal Noble';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, 2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Métal Noble';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, 3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Métal Noble';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, 5 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Métal Noble';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 7 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Métal Noble';

-- TERRESTRE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 0 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Métal Noble';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 1 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Métal Noble';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, 2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Métal Noble';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, 3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Métal Noble';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, 5 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Métal Noble';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 7 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Métal Noble';

COMMIT;


-- BRONZE

BEGIN TRANSACTION;

-- 1) Matériau
INSERT OR IGNORE INTO MATERIAUX (nom_materiau, categorie, realisme, description)
VALUES ('Bronze', 'Métallique', 'historique', 'Alliage ancien de cuivre et d\'étain. Résistant mais moins efficace face aux armes contondantes et aux énergies célestes.');

-- 2) Coût & rareté
INSERT OR IGNORE INTO MATERIAUX_COUTS (id_materiau, base_valeur, rarete)
SELECT id_materiau, 120, 5
FROM MATERIAUX
WHERE nom_materiau='Bronze';

-- 3) Effets par qualité

-- TRANCHANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 1 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Bronze';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Bronze';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, 4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Bronze';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, 6 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Bronze';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, 9 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Bronze';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 14 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Bronze';

-- CONTONDANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -12 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Bronze';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -8  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Bronze';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, -5  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Bronze';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, -3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Bronze';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, -2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Bronze';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, -1  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Bronze';

-- PERFORANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 1 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Bronze';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Bronze';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, 3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Bronze';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, 4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Bronze';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, 6 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Bronze';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 9 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Bronze';

-- IGNÉE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -11 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Bronze';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -7  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Bronze';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, -5  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Bronze';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, -3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Bronze';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, -2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Bronze';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, -1  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Bronze';

-- AQUATIQUE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 0 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Bronze';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 1 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Bronze';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, 3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Bronze';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, 3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Bronze';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, 5 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Bronze';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 8 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Bronze';

-- CÉLESTE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -26 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Bronze';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -17 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Bronze';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, -11 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Bronze';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, -8  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Bronze';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, -5  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Bronze';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, -3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Bronze';

-- TERRESTRE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -12 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Bronze';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -8  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Bronze';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, -5  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Bronze';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, -3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Bronze';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, -2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Bronze';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, -1  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Bronze';

COMMIT;


-- RUBIS

BEGIN TRANSACTION;

-- 1) Matériau
INSERT OR IGNORE INTO MATERIAUX (nom_materiau, categorie, realisme, description)
VALUES ('Rubis', 'Minéral', 'fantaisiste', 'Pierre précieuse rouge, fragile face aux attaques physiques mais très liée au feu et aux énergies mystiques.');

-- 2) Coût & rareté
INSERT OR IGNORE INTO MATERIAUX_COUTS (id_materiau, base_valeur, rarete)
SELECT id_materiau, 1000, 9
FROM MATERIAUX
WHERE nom_materiau='Rubis';

-- 3) Effets par qualité

-- TRANCHANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -16 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Rubis';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -11 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Rubis';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, -7  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Rubis';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, -5  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Rubis';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, -3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Rubis';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, -2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Rubis';

-- CONTONDANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -17 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Rubis';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -11 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Rubis';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, -7  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Rubis';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, -5  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Rubis';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, -3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Rubis';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, -2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Rubis';

-- PERFORANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -15 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Rubis';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -10 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Rubis';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, -7  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Rubis';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, -4  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Rubis';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, -3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Rubis';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, -2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Rubis';

-- IGNÉE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Rubis';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 4  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Rubis';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, 6  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Rubis';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, 9  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Rubis';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, 13 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Rubis';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 20 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Rubis';

-- AQUATIQUE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -10 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Rubis';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -7  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Rubis';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, -4  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Rubis';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, -3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Rubis';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, -2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Rubis';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, -1  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Rubis';

-- CÉLESTE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 1 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Rubis';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Rubis';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, 3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Rubis';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, 4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Rubis';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, 6 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Rubis';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 9 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Rubis';

-- TERRESTRE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 1 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Rubis';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Rubis';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, 3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Rubis';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, 4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Rubis';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, 6 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Rubis';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 9 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Rubis';

COMMIT;

-- SAPHIR

BEGIN TRANSACTION;

-- 1) Matériau
INSERT OR IGNORE INTO MATERIAUX (nom_materiau, categorie, realisme, description)
VALUES ('Saphir', 'Minéral', 'fantaisiste', 'Pierre précieuse bleue, fragile physiquement mais étroitement liée à l’eau et aux forces célestes.');

-- 2) Coût & rareté
INSERT OR IGNORE INTO MATERIAUX_COUTS (id_materiau, base_valeur, rarete)
SELECT id_materiau, 1000, 9
FROM MATERIAUX
WHERE nom_materiau='Saphir';

-- 3) Effets par qualité

-- TRANCHANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -16 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Saphir';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -11 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Saphir';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, -7  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Saphir';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, -5  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Saphir';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, -3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Saphir';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, -2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Saphir';

-- CONTONDANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -17 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Saphir';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -11 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Saphir';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, -7  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Saphir';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, -5  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Saphir';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, -3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Saphir';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, -2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Saphir';

-- PERFORANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -15 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Saphir';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -10 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Saphir';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, -7  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Saphir';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, -4  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Saphir';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, -3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Saphir';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, -2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Saphir';

-- IGNÉE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -10 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Saphir';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -7  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Saphir';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, -4  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Saphir';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, -3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Saphir';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, -2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Saphir';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, -1  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Saphir';

-- AQUATIQUE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Saphir';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 4  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Saphir';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, 6  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Saphir';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, 9  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Saphir';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, 13 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Saphir';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 20 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Saphir';

-- CÉLESTE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 1 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Saphir';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Saphir';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, 3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Saphir';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, 4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Saphir';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, 6 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Saphir';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 9 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Saphir';

-- TERRESTRE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 1 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Saphir';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Saphir';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, 3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Saphir';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, 4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Saphir';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, 6 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Saphir';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 9 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Saphir';

COMMIT;

-- EMERAUDE

BEGIN TRANSACTION;

-- 1) Matériau
INSERT OR IGNORE INTO MATERIAUX (nom_materiau, categorie, realisme, description)
VALUES ('Émeraude', 'Minéral', 'fantaisiste', 'Pierre précieuse verte, fragile physiquement mais fortement liée aux forces célestes et protectrice contre le feu et l’eau.');

-- 2) Coût & rareté
INSERT OR IGNORE INTO MATERIAUX_COUTS (id_materiau, base_valeur, rarete)
SELECT id_materiau, 1000, 9
FROM MATERIAUX
WHERE nom_materiau='Émeraude';

-- 3) Effets par qualité

-- TRANCHANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -16 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Émeraude';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -11 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Émeraude';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, -7  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Émeraude';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, -5  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Émeraude';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, -3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Émeraude';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, -2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Émeraude';

-- CONTONDANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -17 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Émeraude';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -11 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Émeraude';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, -7  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Émeraude';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, -5  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Émeraude';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, -3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Émeraude';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, -2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Émeraude';

-- PERFORANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -15 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Émeraude';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -10 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Émeraude';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, -7  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Émeraude';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, -4  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Émeraude';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, -3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Émeraude';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, -2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Émeraude';

-- IGNÉE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 1 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Émeraude';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Émeraude';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, 3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Émeraude';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, 4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Émeraude';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, 6 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Émeraude';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 9 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Émeraude';

-- AQUATIQUE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 1 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Émeraude';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Émeraude';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, 3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Émeraude';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, 4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Émeraude';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, 6 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Émeraude';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 9 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Émeraude';

-- CÉLESTE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Émeraude';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 4  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Émeraude';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, 6  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Émeraude';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, 9  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Émeraude';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, 13 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Émeraude';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 20 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Émeraude';

-- TERRESTRE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -10 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Émeraude';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -7  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Émeraude';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, -4  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Émeraude';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, -3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Émeraude';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, -2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Émeraude';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, -1  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Émeraude';

COMMIT;

-- TOPAZE

BEGIN TRANSACTION;

-- 1) Matériau
INSERT OR IGNORE INTO MATERIAUX (nom_materiau, categorie, realisme, description)
VALUES ('Topaze', 'Minéral', 'fantaisiste', 'Pierre précieuse jaune doré, fragile physiquement mais fortement liée aux forces terrestres et aux énergies élémentaires.');

-- 2) Coût & rareté
INSERT OR IGNORE INTO MATERIAUX_COUTS (id_materiau, base_valeur, rarete)
SELECT id_materiau, 900, 8
FROM MATERIAUX
WHERE nom_materiau='Topaze';

-- 3) Effets par qualité

-- TRANCHANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -16 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Topaze';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -11 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Topaze';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, -7  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Topaze';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, -5  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Topaze';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, -3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Topaze';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, -2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Topaze';

-- CONTONDANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -17 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Topaze';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -11 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Topaze';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, -7  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Topaze';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, -5  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Topaze';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, -3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Topaze';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, -2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Topaze';

-- PERFORANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -15 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Topaze';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -10 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Topaze';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, -7  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Topaze';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, -4  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Topaze';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, -3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Topaze';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, -2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Topaze';

-- IGNÉE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 1 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Topaze';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Topaze';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, 3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Topaze';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, 4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Topaze';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, 6 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Topaze';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 9 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Topaze';

-- AQUATIQUE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 1 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Topaze';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Topaze';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, 3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Topaze';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, 4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Topaze';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, 6 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Topaze';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 9 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Topaze';

-- CÉLESTE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -10 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Topaze';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -7  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Topaze';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, -4  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Topaze';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, -3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Topaze';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, -2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Topaze';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, -1  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Topaze';

-- TERRESTRE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Topaze';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 4  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Topaze';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, 6  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Topaze';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, 9  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Topaze';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, 13 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Topaze';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 20 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Topaze';

COMMIT;

-- DIAMANT

BEGIN TRANSACTION;

-- 1) Matériau
INSERT OR IGNORE INTO MATERIAUX (nom_materiau, categorie, realisme, description)
VALUES ('Diamant', 'Minéral', 'fantaisiste', 'Pierre précieuse la plus dure connue, fragilisée face aux attaques physiques mais renforçant de manière équilibrée toutes les affinités élémentaires.');

-- 2) Coût & rareté
INSERT OR IGNORE INTO MATERIAUX_COUTS (id_materiau, base_valeur, rarete)
SELECT id_materiau, 1500, 10
FROM MATERIAUX
WHERE nom_materiau='Diamant';

-- 3) Effets par qualité

-- TRANCHANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -8 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Diamant';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -5 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Diamant';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, -3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Diamant';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, -5 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Diamant';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, -2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Diamant';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, -1 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Diamant';

-- CONTONDANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -8 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Diamant';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -5 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Diamant';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, -3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Diamant';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, -5 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Diamant';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, -2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Diamant';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, -1 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Diamant';

-- PERFORANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -8 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Diamant';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -5 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Diamant';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, -3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Diamant';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, -5 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Diamant';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, -2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Diamant';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, -1 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Diamant';

-- IGNÉE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 1 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Diamant';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Diamant';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, 3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Diamant';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, 4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Diamant';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, 6 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Diamant';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 9 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Diamant';

-- AQUATIQUE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 1 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Diamant';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Diamant';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, 3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Diamant';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, 4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Diamant';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, 6 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Diamant';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 9 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Diamant';

-- CÉLESTE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 1 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Diamant';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Diamant';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, 3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Diamant';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, 4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Diamant';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, 6 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Diamant';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 9 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Diamant';

-- TERRESTRE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 1 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Diamant';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Diamant';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, 3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Diamant';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, 4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Diamant';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, 6 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Diamant';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 9 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Diamant';

COMMIT;

-- MITHRIL

BEGIN TRANSACTION;

-- 1) Matériau
INSERT OR IGNORE INTO MATERIAUX (nom_materiau, categorie, realisme, description)
VALUES ('Mithril', 'Métal', 'fantaisiste', 'Métal légendaire, plus léger et résistant que l’acier. Offre des bonus équilibrés et universels, adapté à toutes les armes et armures.');

-- 2) Coût & rareté
INSERT OR IGNORE INTO MATERIAUX_COUTS (id_materiau, base_valeur, rarete)
SELECT id_materiau, 2000, 10
FROM MATERIAUX
WHERE nom_materiau='Mithril';

-- 3) Effets par qualité

-- TRANCHANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Mithril';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Mithril';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, 4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Mithril';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, 7 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Mithril';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, 10 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Mithril';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 15 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Mithril';

-- CONTONDANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Mithril';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Mithril';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, 4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Mithril';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, 7 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Mithril';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, 10 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Mithril';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 15 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Mithril';

-- PERFORANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Mithril';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Mithril';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, 4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Mithril';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, 7 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Mithril';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, 10 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Mithril';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 15 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Mithril';

-- IGNÉE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 1 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Mithril';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Mithril';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, 3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Mithril';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, 5 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Mithril';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, 8 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Mithril';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 12 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Mithril';

-- AQUATIQUE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 1 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Mithril';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Mithril';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, 3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Mithril';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, 5 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Mithril';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, 8 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Mithril';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 12 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Mithril';

-- CÉLESTE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 1 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Mithril';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Mithril';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, 3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Mithril';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, 5 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Mithril';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, 8 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Mithril';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 12 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Mithril';

-- TERRESTRE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 1 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Mithril';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Mithril';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, 3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Mithril';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, 5 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Mithril';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, 8 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Mithril';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 12 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Mithril';

COMMIT;

-- ORICHALQUE

BEGIN TRANSACTION;

-- 1) Matériau
INSERT OR IGNORE INTO MATERIAUX (nom_materiau, categorie, realisme, description)
VALUES ('Orichalque', 'Métal', 'fantaisiste', 'Métal mythique surpassant tous les autres, conférant des bonus colossaux et équilibrés dans tous les domaines.');

-- 2) Coût & rareté
INSERT OR IGNORE INTO MATERIAUX_COUTS (id_materiau, base_valeur, rarete)
SELECT id_materiau, 5000, 11
FROM MATERIAUX
WHERE nom_materiau='Orichalque';

-- 3) Effets par qualité

-- TRANCHANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Orichalque';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 6 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Orichalque';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, 9 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Orichalque';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, 13 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Orichalque';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, 20 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Orichalque';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 30 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Orichalque';

-- CONTONDANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Orichalque';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 6 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Orichalque';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, 9 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Orichalque';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, 13 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Orichalque';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, 20 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Orichalque';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 30 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Orichalque';

-- PERFORANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Orichalque';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 6 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Orichalque';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, 9 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Orichalque';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, 13 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Orichalque';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, 20 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Orichalque';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 30 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Orichalque';

-- IGNÉE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Orichalque';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 6 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Orichalque';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, 9 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Orichalque';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, 13 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Orichalque';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, 20 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Orichalque';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 30 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Orichalque';

-- AQUATIQUE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Orichalque';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 6 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Orichalque';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, 9 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Orichalque';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, 13 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Orichalque';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, 20 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Orichalque';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 30 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Orichalque';

-- CÉLESTE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Orichalque';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 6 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Orichalque';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, 9 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Orichalque';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, 13 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Orichalque';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, 20 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Orichalque';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 30 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Orichalque';

-- TERRESTRE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Orichalque';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 6 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Orichalque';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, 9 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Orichalque';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, 13 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Orichalque';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, 20 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Orichalque';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 30 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Orichalque';

COMMIT;

-- FOURRURE

BEGIN TRANSACTION;

-- 1) Matériau
INSERT OR IGNORE INTO MATERIAUX (nom_materiau, categorie, realisme, description)
VALUES ('Fourrure', 'Organique', 'réaliste', 'Matériau souple et isolant, efficace contre certains éléments mais très vulnérable au feu et aux dégâts physiques.');

-- 2) Coût & rareté
INSERT OR IGNORE INTO MATERIAUX_COUTS (id_materiau, base_valeur, rarete)
SELECT id_materiau, 25, 2
FROM MATERIAUX
WHERE nom_materiau='Fourrure';

-- 3) Effets par qualité

-- TRANCHANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Fourrure';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Fourrure';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, -1 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Fourrure';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, 0 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Fourrure';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, 1 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Fourrure';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Fourrure';

-- CONTONDANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -5 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Fourrure';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Fourrure';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, -2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Fourrure';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, -1 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Fourrure';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, 0 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Fourrure';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 1 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Fourrure';

-- PERFORANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -7 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Fourrure';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -5 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Fourrure';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, -3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Fourrure';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, -2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Fourrure';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, -1 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Fourrure';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 0 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Fourrure';

-- IGNÉE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -12 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Fourrure';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -8 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Fourrure';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, -5 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Fourrure';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, -3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Fourrure';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, -2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Fourrure';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, -1 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Fourrure';

-- AQUATIQUE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 0 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Fourrure';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 1 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Fourrure';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, 2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Fourrure';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, 3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Fourrure';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, 5 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Fourrure';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 7 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Fourrure';

-- TERRESTRE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 0 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Fourrure';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 1 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Fourrure';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 0, 2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Fourrure';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 1, 3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Fourrure';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 2, 5 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Fourrure';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, 3, 8 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Fourrure';

COMMIT;

-- CUIR ANIMAL

BEGIN TRANSACTION;

-- 1) Matériau
INSERT OR IGNORE INTO MATERIAUX (nom_materiau, categorie, realisme, description)
VALUES ('Cuir animal', 'Organique', 'réaliste', 'Cuir tanné provenant d’animaux, plus résistant que la peau brute mais encore vulnérable au feu.');

-- 2) Coût & rareté (ajuste selon ton équilibre de jeu)
INSERT OR IGNORE INTO MATERIAUX_COUTS (id_materiau, base_valeur, rarete)
SELECT id_materiau, 40, 4
FROM MATERIAUX
WHERE nom_materiau='Cuir animal';

-- 3) Effets par qualité

-- TRANCHANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 1  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant'  WHERE m.nom_materiau='Cuir animal';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant'  WHERE m.nom_materiau='Cuir animal';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, 3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant'  WHERE m.nom_materiau='Cuir animal';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, 5  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant'  WHERE m.nom_materiau='Cuir animal';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 8  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant'  WHERE m.nom_materiau='Cuir animal';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 12 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant'  WHERE m.nom_materiau='Cuir animal';

-- CONTONDANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -7 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Cuir animal';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -5 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Cuir animal';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, -3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Cuir animal';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, -2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Cuir animal';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, -1 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Cuir animal';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 0  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Cuir animal';

-- PERFORANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 1  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Cuir animal';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Cuir animal';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, 3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Cuir animal';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, 4  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Cuir animal';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 7  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Cuir animal';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 10 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Cuir animal';

-- IGNÉE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -17 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Cuir animal';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -11 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Cuir animal';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, -7  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Cuir animal';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, -5  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Cuir animal';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, -3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Cuir animal';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, -2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Cuir animal';

-- AQUATIQUE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 0 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Cuir animal';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 1 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Cuir animal';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, 2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Cuir animal';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, 3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Cuir animal';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 5 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Cuir animal';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 8 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Cuir animal';

-- TERRESTRE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 1  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Cuir animal';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Cuir animal';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, 4  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Cuir animal';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, 6  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Cuir animal';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 9  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Cuir animal';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 13 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Cuir animal';

COMMIT;

-- CUIRASSE EPAISSE

BEGIN TRANSACTION;

-- 1) Matériau
INSERT OR IGNORE INTO MATERIAUX (nom_materiau, categorie, realisme, description)
VALUES ('Cuirasse épaisse', 'Organique', 'réaliste', 'Cuir épais et travaillé, offrant une protection robuste contre les dégâts physiques.');

-- 2) Coût & rareté (ajuste librement si besoin)
INSERT OR IGNORE INTO MATERIAUX_COUTS (id_materiau, base_valeur, rarete)
SELECT id_materiau, 80, 6
FROM MATERIAUX
WHERE nom_materiau='Cuirasse épaisse';

-- 3) Effets par qualité

-- TRANCHANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant'  WHERE m.nom_materiau='Cuirasse épaisse';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 4  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant'  WHERE m.nom_materiau='Cuirasse épaisse';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, 6  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant'  WHERE m.nom_materiau='Cuirasse épaisse';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, 9  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant'  WHERE m.nom_materiau='Cuirasse épaisse';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 13 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant'  WHERE m.nom_materiau='Cuirasse épaisse';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 20 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant'  WHERE m.nom_materiau='Cuirasse épaisse';

-- CONTONDANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Cuirasse épaisse';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 4  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Cuirasse épaisse';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, 6  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Cuirasse épaisse';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, 10 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Cuirasse épaisse';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 15 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Cuirasse épaisse';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 22 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Cuirasse épaisse';

-- PERFORANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Cuirasse épaisse';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Cuirasse épaisse';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, 4  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Cuirasse épaisse';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, 7  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Cuirasse épaisse';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 10 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Cuirasse épaisse';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 15 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Cuirasse épaisse';

-- IGNÉE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -11 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Cuirasse épaisse';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -7  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Cuirasse épaisse';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, -5  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Cuirasse épaisse';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, -3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Cuirasse épaisse';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, -2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Cuirasse épaisse';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, -1  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Cuirasse épaisse';

-- AQUATIQUE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 1  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Cuirasse épaisse';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Cuirasse épaisse';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, 3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Cuirasse épaisse';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, 4  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Cuirasse épaisse';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 6  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Cuirasse épaisse';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 9  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Cuirasse épaisse';

-- CÉLESTE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 1  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Cuirasse épaisse';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Cuirasse épaisse';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, 3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Cuirasse épaisse';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, 4  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Cuirasse épaisse';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 6  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Cuirasse épaisse';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 9  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Cuirasse épaisse';

-- TERRESTRE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 1  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Cuirasse épaisse';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Cuirasse épaisse';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, 4  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Cuirasse épaisse';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, 6  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Cuirasse épaisse';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 9  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Cuirasse épaisse';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 13 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Cuirasse épaisse';

COMMIT;

-- PEAU HUILÉES OU CIRÉES

BEGIN TRANSACTION;

-- 1) Matériau
INSERT OR IGNORE INTO MATERIAUX (nom_materiau, categorie, realisme, description)
VALUES ('Peau huilées ou cirées', 'Organique', 'réaliste', 'Peau traitée avec des huiles ou cires, offrant une meilleure résistance à l’eau.');

-- 2) Coût & rareté (à ajuster selon ton système)
INSERT OR IGNORE INTO MATERIAUX_COUTS (id_materiau, base_valeur, rarete)
SELECT id_materiau, 50, 5
FROM MATERIAUX
WHERE nom_materiau='Peau huilées ou cirées';

-- 3) Effets par qualité

-- TRANCHANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 1  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant'  WHERE m.nom_materiau='Peau huilées ou cirées';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant'  WHERE m.nom_materiau='Peau huilées ou cirées';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, 3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant'  WHERE m.nom_materiau='Peau huilées ou cirées';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, 4  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant'  WHERE m.nom_materiau='Peau huilées ou cirées';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 7  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant'  WHERE m.nom_materiau='Peau huilées ou cirées';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 10 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant'  WHERE m.nom_materiau='Peau huilées ou cirées';

-- CONTONDANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Peau huilées ou cirées';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Peau huilées ou cirées';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, -1 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Peau huilées ou cirées';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1,  0 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Peau huilées ou cirées';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2,  1 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Peau huilées ou cirées';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3,  2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Peau huilées ou cirées';

-- PERFORANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 0  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Peau huilées ou cirées';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 1  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Peau huilées ou cirées';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, 2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Peau huilées ou cirées';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, 3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Peau huilées ou cirées';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 5  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Peau huilées ou cirées';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 8  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Peau huilées ou cirées';

-- IGNÉE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -15 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Peau huilées ou cirées';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -10 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Peau huilées ou cirées';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, -7  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Peau huilées ou cirées';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, -4  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Peau huilées ou cirées';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, -3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Peau huilées ou cirées';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, -2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Peau huilées ou cirées';

-- AQUATIQUE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 1   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Peau huilées ou cirées';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 2   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Peau huilées ou cirées';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, 3   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Peau huilées ou cirées';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, 5   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Peau huilées ou cirées';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 8   FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Peau huilées ou cirées';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 12  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Peau huilées ou cirées';

-- TERRESTRE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 1  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Peau huilées ou cirées';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Peau huilées ou cirées';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, 3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Peau huilées ou cirées';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, 5  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Peau huilées ou cirées';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 7  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Peau huilées ou cirées';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 11 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Peau huilées ou cirées';

COMMIT;

-- EXOSQUELETTE D'INSECTE

BEGIN TRANSACTION;

-- 1) Matériau
INSERT OR IGNORE INTO MATERIAUX (nom_materiau, categorie, realisme, description)
VALUES ('Exosquelette d’insecte', 'Organique', 'réaliste', 'Carapace chitineuse résistante des insectes, légère mais vulnérable aux chocs.');

-- 2) Coût & rareté (à ajuster selon ton système)
INSERT OR IGNORE INTO MATERIAUX_COUTS (id_materiau, base_valeur, rarete)
SELECT id_materiau, 35, 4
FROM MATERIAUX
WHERE nom_materiau='Exosquelette d’insecte';

-- 3) Effets par qualité

-- TRANCHANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 1  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant'  WHERE m.nom_materiau='Exosquelette d’insecte';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant'  WHERE m.nom_materiau='Exosquelette d’insecte';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, 3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant'  WHERE m.nom_materiau='Exosquelette d’insecte';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, 5  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant'  WHERE m.nom_materiau='Exosquelette d’insecte';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 7  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant'  WHERE m.nom_materiau='Exosquelette d’insecte';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 11 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant'  WHERE m.nom_materiau='Exosquelette d’insecte';

-- CONTONDANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -17 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Exosquelette d’insecte';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -9  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Exosquelette d’insecte';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, -6  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Exosquelette d’insecte';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, -4  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Exosquelette d’insecte';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, -3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Exosquelette d’insecte';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, -2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Exosquelette d’insecte';

-- PERFORANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -5 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Exosquelette d’insecte';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Exosquelette d’insecte';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, -2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Exosquelette d’insecte';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, -1 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Exosquelette d’insecte';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2,  0 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Exosquelette d’insecte';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3,  1 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Exosquelette d’insecte';

-- IGNÉE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -18 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Exosquelette d’insecte';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -12 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Exosquelette d’insecte';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, -8  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Exosquelette d’insecte';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, -5  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Exosquelette d’insecte';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, -3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Exosquelette d’insecte';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, -2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Exosquelette d’insecte';

-- AQUATIQUE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -1 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Exosquelette d’insecte';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1,  0 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Exosquelette d’insecte';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0,  1 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Exosquelette d’insecte';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1,  2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Exosquelette d’insecte';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2,  3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Exosquelette d’insecte';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3,  4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Exosquelette d’insecte';

-- TERRESTRE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 1  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Exosquelette d’insecte';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Exosquelette d’insecte';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, 3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Exosquelette d’insecte';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, 4  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Exosquelette d’insecte';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 7  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Exosquelette d’insecte';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 10 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Exosquelette d’insecte';

COMMIT;

-- CARAPACE DE TORTUE

BEGIN TRANSACTION;

-- 1) Matériau
INSERT OR IGNORE INTO MATERIAUX (nom_materiau, categorie, realisme, description)
VALUES ('Carapace de tortue', 'Organique', 'réaliste', 'Carapace solide et protectrice, offrant une excellente défense physique et aquatique.');

-- 2) Coût & rareté (ajuste si besoin pour ton équilibrage)
INSERT OR IGNORE INTO MATERIAUX_COUTS (id_materiau, base_valeur, rarete)
SELECT id_materiau, 100, 7
FROM MATERIAUX
WHERE nom_materiau='Carapace de tortue';

-- 3) Effets par qualité

-- TRANCHANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant'  WHERE m.nom_materiau='Carapace de tortue';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 4  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant'  WHERE m.nom_materiau='Carapace de tortue';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, 6  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant'  WHERE m.nom_materiau='Carapace de tortue';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, 9  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant'  WHERE m.nom_materiau='Carapace de tortue';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 14 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant'  WHERE m.nom_materiau='Carapace de tortue';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 21 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant'  WHERE m.nom_materiau='Carapace de tortue';

-- CONTONDANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 1  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Carapace de tortue';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Carapace de tortue';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, 3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Carapace de tortue';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, 4  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Carapace de tortue';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 7  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Carapace de tortue';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 10 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Carapace de tortue';

-- PERFORANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Carapace de tortue';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Carapace de tortue';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, 5  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Carapace de tortue';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, 8  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Carapace de tortue';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 12 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Carapace de tortue';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 18 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Carapace de tortue';

-- IGNÉE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -16 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Carapace de tortue';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -11 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Carapace de tortue';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, -7  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Carapace de tortue';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, -5  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Carapace de tortue';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, -3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Carapace de tortue';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, -2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Carapace de tortue';

-- AQUATIQUE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Carapace de tortue';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Carapace de tortue';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, 4  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Carapace de tortue';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, 7  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Carapace de tortue';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 10 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Carapace de tortue';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 15 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Carapace de tortue';

-- CÉLESTE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -7 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Carapace de tortue';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Carapace de tortue';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, -2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Carapace de tortue';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, -1 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Carapace de tortue';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2,  0 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Carapace de tortue';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3,  1 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Carapace de tortue';

-- TERRESTRE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Carapace de tortue';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Carapace de tortue';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, 4  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Carapace de tortue';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, 6  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Carapace de tortue';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 9  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Carapace de tortue';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 14 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Carapace de tortue';

COMMIT;

-- CARAPACE DE CRABE/HOMARD

BEGIN TRANSACTION;

-- 1) Matériau
INSERT OR IGNORE INTO MATERIAUX (nom_materiau, categorie, realisme, description)
VALUES ('Carapace de crabe/homard', 'Organique', 'réaliste', 'Carapace rigide et segmentée, excellente défense aquatique mais fragile face aux impacts.');

-- 2) Coût & rareté (à ajuster selon ton équilibre)
INSERT OR IGNORE INTO MATERIAUX_COUTS (id_materiau, base_valeur, rarete)
SELECT id_materiau, 120, 8
FROM MATERIAUX
WHERE nom_materiau='Carapace de crabe/homard';

-- 3) Effets par qualité

-- TRANCHANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 1  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant'  WHERE m.nom_materiau='Carapace de crabe/homard';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant'  WHERE m.nom_materiau='Carapace de crabe/homard';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, 3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant'  WHERE m.nom_materiau='Carapace de crabe/homard';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, 4  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant'  WHERE m.nom_materiau='Carapace de crabe/homard';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 6  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant'  WHERE m.nom_materiau='Carapace de crabe/homard';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 9  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant'  WHERE m.nom_materiau='Carapace de crabe/homard';

-- CONTONDANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -22 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Carapace de crabe/homard';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -15 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Carapace de crabe/homard';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, -10 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Carapace de crabe/homard';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, -6  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Carapace de crabe/homard';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, -4  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Carapace de crabe/homard';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, -3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Carapace de crabe/homard';

-- PERFORANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Carapace de crabe/homard';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Carapace de crabe/homard';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, 4  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Carapace de crabe/homard';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, 6  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Carapace de crabe/homard';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 9  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Carapace de crabe/homard';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 14 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Carapace de crabe/homard';

-- IGNÉE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -12 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Carapace de crabe/homard';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -8  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Carapace de crabe/homard';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, -5  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Carapace de crabe/homard';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, -3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Carapace de crabe/homard';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, -2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Carapace de crabe/homard';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, -1  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Carapace de crabe/homard';

-- AQUATIQUE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Carapace de crabe/homard';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 4  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Carapace de crabe/homard';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, 6  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Carapace de crabe/homard';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, 9  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Carapace de crabe/homard';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 13 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Carapace de crabe/homard';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 20 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Carapace de crabe/homard';

-- CÉLESTE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -9 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Carapace de crabe/homard';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -6 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Carapace de crabe/homard';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, -4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Carapace de crabe/homard';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, -3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Carapace de crabe/homard';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, -2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Carapace de crabe/homard';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, -1 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Carapace de crabe/homard';

-- TERRESTRE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Carapace de crabe/homard';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Carapace de crabe/homard';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, 4  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Carapace de crabe/homard';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, 7  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Carapace de crabe/homard';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 10 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Carapace de crabe/homard';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 15 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Carapace de crabe/homard';

COMMIT;

-- CARAPACE DE TATOU

BEGIN TRANSACTION;

-- 1) Matériau
INSERT OR IGNORE INTO MATERIAUX (nom_materiau, categorie, realisme, description)
VALUES ('Carapace de tatou', 'Organique', 'réaliste', 'Carapace segmentée du tatou, flexible mais offrant une bonne défense.');

-- 2) Coût & rareté (à ajuster selon ton équilibre de jeu)
INSERT OR IGNORE INTO MATERIAUX_COUTS (id_materiau, base_valeur, rarete)
SELECT id_materiau, 110, 7
FROM MATERIAUX
WHERE nom_materiau='Carapace de tatou';

-- 3) Effets par qualité

-- TRANCHANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant'  WHERE m.nom_materiau='Carapace de tatou';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 4  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant'  WHERE m.nom_materiau='Carapace de tatou';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, 6  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant'  WHERE m.nom_materiau='Carapace de tatou';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, 8  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant'  WHERE m.nom_materiau='Carapace de tatou';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 13 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant'  WHERE m.nom_materiau='Carapace de tatou';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 19 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant'  WHERE m.nom_materiau='Carapace de tatou';

-- CONTONDANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 1  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Carapace de tatou';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Carapace de tatou';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, 3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Carapace de tatou';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, 5  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Carapace de tatou';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 8  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Carapace de tatou';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 12 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Carapace de tatou';

-- PERFORANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Carapace de tatou';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Carapace de tatou';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, 5  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Carapace de tatou';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, 7  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Carapace de tatou';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 11 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Carapace de tatou';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 16 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Carapace de tatou';

-- IGNÉE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -14 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Carapace de tatou';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -9  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Carapace de tatou';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, -6  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Carapace de tatou';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, -4  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Carapace de tatou';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, -3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Carapace de tatou';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, -2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Carapace de tatou';

-- AQUATIQUE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 0 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Carapace de tatou';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 1 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Carapace de tatou';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, 2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Carapace de tatou';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, 3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Carapace de tatou';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 5 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Carapace de tatou';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 7 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Carapace de tatou';

-- CÉLESTE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -8 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Carapace de tatou';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -5 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Carapace de tatou';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, -3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Carapace de tatou';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, -2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Carapace de tatou';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, -1 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Carapace de tatou';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3,  0 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Carapace de tatou';

-- TERRESTRE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 1  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Carapace de tatou';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Carapace de tatou';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, 4  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Carapace de tatou';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, 6  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Carapace de tatou';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 9  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Carapace de tatou';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 13 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Carapace de tatou';

COMMIT;

-- CARAPACE DE PANGOLIN

BEGIN TRANSACTION;

-- 1) Matériau
INSERT OR IGNORE INTO MATERIAUX (nom_materiau, categorie, realisme, description)
VALUES ('Carapace de pangolin', 'Organique', 'réaliste', 'Carapace écailleuse du pangolin, robuste et protectrice.');

-- 2) Coût & rareté (ajustables selon ton équilibrage)
INSERT OR IGNORE INTO MATERIAUX_COUTS (id_materiau, base_valeur, rarete)
SELECT id_materiau, 140, 8
FROM MATERIAUX
WHERE nom_materiau='Carapace de pangolin';

-- 3) Effets par qualité

-- TRANCHANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant'  WHERE m.nom_materiau='Carapace de pangolin';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant'  WHERE m.nom_materiau='Carapace de pangolin';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, 5  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant'  WHERE m.nom_materiau='Carapace de pangolin';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, 7  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant'  WHERE m.nom_materiau='Carapace de pangolin';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 11 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant'  WHERE m.nom_materiau='Carapace de pangolin';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 17 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant'  WHERE m.nom_materiau='Carapace de pangolin';

-- CONTONDANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 1  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Carapace de pangolin';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Carapace de pangolin';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, 3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Carapace de pangolin';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, 5  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Carapace de pangolin';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 7  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Carapace de pangolin';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 11 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Carapace de pangolin';

-- PERFORANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 1  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Carapace de pangolin';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Carapace de pangolin';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, 3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Carapace de pangolin';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, 5  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Carapace de pangolin';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 8  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Carapace de pangolin';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 12 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Carapace de pangolin';

-- IGNÉE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -15 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Carapace de pangolin';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -10 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Carapace de pangolin';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, -7  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Carapace de pangolin';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, -4  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Carapace de pangolin';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, -3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Carapace de pangolin';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, -2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Carapace de pangolin';

-- AQUATIQUE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -7 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Carapace de pangolin';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -5 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Carapace de pangolin';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, -3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Carapace de pangolin';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, -2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Carapace de pangolin';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, -1 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Carapace de pangolin';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3,  0 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Carapace de pangolin';

-- CÉLESTE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -8 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Carapace de pangolin';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -5 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Carapace de pangolin';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, -3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Carapace de pangolin';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, -2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Carapace de pangolin';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, -1 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Carapace de pangolin';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3,  0 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Carapace de pangolin';

-- TERRESTRE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 1  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Carapace de pangolin';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Carapace de pangolin';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, 3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Carapace de pangolin';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, 5  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Carapace de pangolin';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 7  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Carapace de pangolin';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 11 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Carapace de pangolin';

COMMIT;

-- ÉCAILLES DE POISSON

BEGIN TRANSACTION;

-- 1) Matériau
INSERT OR IGNORE INTO MATERIAUX (nom_materiau, categorie, realisme, description)
VALUES ('Écailles de poisson', 'Organique', 'réaliste', 'Écailles protectrices de poisson, excellentes contre l’eau mais vulnérables aux chocs.');

-- 2) Coût & rareté (à ajuster selon ton système)
INSERT OR IGNORE INTO MATERIAUX_COUTS (id_materiau, base_valeur, rarete)
SELECT id_materiau, 120, 6
FROM MATERIAUX
WHERE nom_materiau='Écailles de poisson';

-- 3) Effets par qualité

-- TRANCHANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Écailles de poisson';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -1 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Écailles de poisson';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0,  0 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Écailles de poisson';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1,  3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Écailles de poisson';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2,  6 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Écailles de poisson';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 12 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Écailles de poisson';

-- CONTONDANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -16 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Écailles de poisson';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -11 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Écailles de poisson';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0,  -7 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Écailles de poisson';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1,  -5 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Écailles de poisson';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2,  -3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Écailles de poisson';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3,  -2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Écailles de poisson';

-- PERFORANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 1 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Écailles de poisson';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Écailles de poisson';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, 3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Écailles de poisson';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, 4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Écailles de poisson';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 6 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Écailles de poisson';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 9 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Écailles de poisson';

-- IGNÉE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -14 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Écailles de poisson';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -9  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Écailles de poisson';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, -6  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Écailles de poisson';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, -4  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Écailles de poisson';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, -3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Écailles de poisson';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, -2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Écailles de poisson';

-- AQUATIQUE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Écailles de poisson';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Écailles de poisson';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, 5  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Écailles de poisson';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, 7  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Écailles de poisson';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 11 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Écailles de poisson';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 16 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Écailles de poisson';

-- CÉLESTE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -18 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Écailles de poisson';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -12 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Écailles de poisson';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, -8  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Écailles de poisson';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, -5  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Écailles de poisson';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, -3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Écailles de poisson';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, -2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Écailles de poisson';

-- TERRESTRE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 0 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Écailles de poisson';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 1 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Écailles de poisson';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, 2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Écailles de poisson';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, 3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Écailles de poisson';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Écailles de poisson';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 6 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Écailles de poisson';

COMMIT;

-- ÉCAILLES DE SERPENT

BEGIN TRANSACTION;

-- 1) Matériau
INSERT OR IGNORE INTO MATERIAUX (nom_materiau, categorie, realisme, description)
VALUES ('Écailles de serpent', 'Organique', 'réaliste', 'Écailles de serpent, souples et résistantes, mais vulnérables aux attaques perforantes.');

-- 2) Coût & rareté (à ajuster si besoin)
INSERT OR IGNORE INTO MATERIAUX_COUTS (id_materiau, base_valeur, rarete)
SELECT id_materiau, 100, 5
FROM MATERIAUX
WHERE nom_materiau='Écailles de serpent';

-- 3) Effets par qualité

-- TRANCHANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 0  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Écailles de serpent';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Écailles de serpent';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, 3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Écailles de serpent';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, 4  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Écailles de serpent';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 7  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Écailles de serpent';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 13 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Écailles de serpent';

-- CONTONDANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -15 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Écailles de serpent';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -10 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Écailles de serpent';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0,  -7 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Écailles de serpent';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1,  -4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Écailles de serpent';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2,  -3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Écailles de serpent';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3,  -2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Écailles de serpent';

-- PERFORANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -10 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Écailles de serpent';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -7  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Écailles de serpent';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, -4  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Écailles de serpent';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, -3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Écailles de serpent';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, -2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Écailles de serpent';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, -1  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Écailles de serpent';

-- IGNÉE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -12 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Écailles de serpent';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -8  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Écailles de serpent';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, -5  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Écailles de serpent';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, -3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Écailles de serpent';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, -2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Écailles de serpent';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, -1  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Écailles de serpent';

-- AQUATIQUE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 0 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Écailles de serpent';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 1 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Écailles de serpent';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, 2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Écailles de serpent';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, 3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Écailles de serpent';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 5 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Écailles de serpent';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 8 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Écailles de serpent';

-- TERRESTRE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 1 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Écailles de serpent';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Écailles de serpent';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, 3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Écailles de serpent';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, 4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Écailles de serpent';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 6 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Écailles de serpent';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 9 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Écailles de serpent';

COMMIT;

-- ÉCAILLES DE LÉZARD

BEGIN TRANSACTION;

-- 1) Matériau
INSERT OR IGNORE INTO MATERIAUX (nom_materiau, categorie, realisme, description)
VALUES ('Écailles de lézard', 'Organique', 'réaliste', 'Écailles de lézard : fragiles mais évolutives, offrant une résistance correcte à haut niveau.');

-- 2) Coût & rareté (valeurs indicatives à adapter)
INSERT OR IGNORE INTO MATERIAUX_COUTS (id_materiau, base_valeur, rarete)
SELECT id_materiau, 90, 4
FROM MATERIAUX
WHERE nom_materiau='Écailles de lézard';

-- 3) Effets par qualité

-- TRANCHANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Écailles de lézard';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -1  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Écailles de lézard';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0,  0  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Écailles de lézard';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1,  3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Écailles de lézard';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2,  6  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Écailles de lézard';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 12  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Écailles de lézard';

-- CONTONDANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -15 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Écailles de lézard';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -10 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Écailles de lézard';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0,  -7 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Écailles de lézard';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1,  -4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Écailles de lézard';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2,  -3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Écailles de lézard';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3,  -2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Écailles de lézard';

-- PERFORANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -9 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Écailles de lézard';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -6 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Écailles de lézard';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, -4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Écailles de lézard';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, -3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Écailles de lézard';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, -2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Écailles de lézard';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, -1 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Écailles de lézard';

-- IGNÉE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -14 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Écailles de lézard';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -9  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Écailles de lézard';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, -6  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Écailles de lézard';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, -4  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Écailles de lézard';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, -3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Écailles de lézard';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, -2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Écailles de lézard';

-- AQUATIQUE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 0 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Écailles de lézard';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 1 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Écailles de lézard';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, 2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Écailles de lézard';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, 3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Écailles de lézard';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 5 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Écailles de lézard';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 7 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Écailles de lézard';

-- TERRESTRE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 1  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Écailles de lézard';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 2  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Écailles de lézard';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, 3  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Écailles de lézard';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, 4  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Écailles de lézard';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 7  FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Écailles de lézard';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 10 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Écailles de lézard';

COMMIT;

-- ÉCAILLES DE CROCODILE/ALLIGATOR

BEGIN TRANSACTION;

-- 1) Matériau
INSERT OR IGNORE INTO MATERIAUX (nom_materiau, categorie, realisme, description)
VALUES ('Écailles de crocodile/alligator', 'Organique', 'réaliste', 'Écailles de crocodile ou alligator : solides, résistantes à l’eau, mais vulnérables au feu.');

-- 2) Coût & rareté (à ajuster si besoin)
INSERT OR IGNORE INTO MATERIAUX_COUTS (id_materiau, base_valeur, rarete)
SELECT id_materiau, 120, 5
FROM MATERIAUX
WHERE nom_materiau='Écailles de crocodile/alligator';

-- 3) Effets par qualité

-- TRANCHANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2,  2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Écailles de crocodile/alligator';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1,  4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Écailles de crocodile/alligator';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0,  6 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Écailles de crocodile/alligator';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1,  8 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Écailles de crocodile/alligator';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 13 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Écailles de crocodile/alligator';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 19 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Écailles de crocodile/alligator';

-- CONTONDANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2,  1 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Écailles de crocodile/alligator';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1,  2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Écailles de crocodile/alligator';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0,  3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Écailles de crocodile/alligator';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1,  5 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Écailles de crocodile/alligator';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2,  7 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Écailles de crocodile/alligator';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 11 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Écailles de crocodile/alligator';

-- PERFORANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2,  1 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Écailles de crocodile/alligator';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1,  2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Écailles de crocodile/alligator';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0,  3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Écailles de crocodile/alligator';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1,  5 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Écailles de crocodile/alligator';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2,  8 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Écailles de crocodile/alligator';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 12 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Écailles de crocodile/alligator';

-- IGNÉE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -16 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Écailles de crocodile/alligator';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -11 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Écailles de crocodile/alligator';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0,  -7 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Écailles de crocodile/alligator';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1,  -5 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Écailles de crocodile/alligator';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2,  -3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Écailles de crocodile/alligator';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3,  -2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Écailles de crocodile/alligator';

-- AQUATIQUE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2,  2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Écailles de crocodile/alligator';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1,  3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Écailles de crocodile/alligator';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0,  5 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Écailles de crocodile/alligator';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1,  8 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Écailles de crocodile/alligator';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 12 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Écailles de crocodile/alligator';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 18 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Écailles de crocodile/alligator';

-- TERRESTRE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 1 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Écailles de crocodile/alligator';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Écailles de crocodile/alligator';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, 3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Écailles de crocodile/alligator';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, 5 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Écailles de crocodile/alligator';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 7 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Écailles de crocodile/alligator';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 11 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Écailles de crocodile/alligator';

COMMIT;

-- ÉCAILLES DE DRAGON DE FEU

BEGIN TRANSACTION;

-- 1) Matériau
INSERT OR IGNORE INTO MATERIAUX (nom_materiau, categorie, realisme, description)
VALUES ('Écailles de dragons de feu', 'Organique', 'fantastique', 'Écailles épaisses et brûlantes des dragons de feu. Résistantes à presque tout, sauf à l’eau.');

-- 2) Coût & rareté (ajustable)
INSERT OR IGNORE INTO MATERIAUX_COUTS (id_materiau, base_valeur, rarete)
SELECT id_materiau, 500, 10
FROM MATERIAUX
WHERE nom_materiau='Écailles de dragons de feu';

-- 3) Effets par qualité

-- TRANCHANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2,  3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Écailles de dragons de feu';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1,  4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Écailles de dragons de feu';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0,  7 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Écailles de dragons de feu';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, 10 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Écailles de dragons de feu';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 15 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Écailles de dragons de feu';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 23 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Écailles de dragons de feu';

-- CONTONDANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2,  3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Écailles de dragons de feu';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1,  4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Écailles de dragons de feu';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0,  6 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Écailles de dragons de feu';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1,  9 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Écailles de dragons de feu';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 13 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Écailles de dragons de feu';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 20 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Écailles de dragons de feu';

-- PERFORANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2,  3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Écailles de dragons de feu';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1,  4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Écailles de dragons de feu';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0,  6 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Écailles de dragons de feu';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, 10 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Écailles de dragons de feu';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 15 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Écailles de dragons de feu';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 22 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Écailles de dragons de feu';

-- IGNÉE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2,  3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Écailles de dragons de feu';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1,  5 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Écailles de dragons de feu';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0,  8 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Écailles de dragons de feu';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, 12 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Écailles de dragons de feu';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 18 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Écailles de dragons de feu';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 27 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Écailles de dragons de feu';

-- AQUATIQUE (faiblesse)
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -10 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Écailles de dragons de feu';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1,  -7 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Écailles de dragons de feu';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0,  -4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Écailles de dragons de feu';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1,  -3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Écailles de dragons de feu';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2,  -2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Écailles de dragons de feu';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3,  -1 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Écailles de dragons de feu';

-- CÉLESTE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2,  2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Écailles de dragons de feu';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1,  4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Écailles de dragons de feu';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0,  6 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Écailles de dragons de feu';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1,  8 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Écailles de dragons de feu';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 13 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Écailles de dragons de feu';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 19 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Écailles de dragons de feu';

-- TERRESTRE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2,  2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Écailles de dragons de feu';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1,  4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Écailles de dragons de feu';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0,  6 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Écailles de dragons de feu';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1,  8 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Écailles de dragons de feu';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 13 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Écailles de dragons de feu';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 19 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Écailles de dragons de feu';

COMMIT;

-- ÉCAILLES DE DRAGONS DE GLACE

BEGIN TRANSACTION;

-- 1) Matériau
INSERT OR IGNORE INTO MATERIAUX (nom_materiau, categorie, realisme, description)
VALUES ('Écailles de dragons de glace', 'Organique', 'fantastique', 'Écailles glacées et cristallines des dragons de glace. Redoutables contre l’eau, vulnérables au feu.');

-- 2) Coût & rareté (ajustable)
INSERT OR IGNORE INTO MATERIAUX_COUTS (id_materiau, base_valeur, rarete)
SELECT id_materiau, 500, 10
FROM MATERIAUX
WHERE nom_materiau='Écailles de dragons de glace';

-- 3) Effets par qualité

-- TRANCHANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2,  3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Écailles de dragons de glace';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1,  4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Écailles de dragons de glace';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0,  7 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Écailles de dragons de glace';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, 10 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Écailles de dragons de glace';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 15 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Écailles de dragons de glace';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 23 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Écailles de dragons de glace';

-- CONTONDANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2,  3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Écailles de dragons de glace';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1,  4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Écailles de dragons de glace';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0,  6 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Écailles de dragons de glace';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1,  9 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Écailles de dragons de glace';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 13 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Écailles de dragons de glace';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 20 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Écailles de dragons de glace';

-- PERFORANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2,  3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Écailles de dragons de glace';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1,  4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Écailles de dragons de glace';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0,  6 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Écailles de dragons de glace';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, 10 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Écailles de dragons de glace';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 15 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Écailles de dragons de glace';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 22 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Écailles de dragons de glace';

-- IGNÉE (faiblesse au feu)
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -13 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Écailles de dragons de glace';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1,  -9 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Écailles de dragons de glace';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0,  -6 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Écailles de dragons de glace';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1,  -4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Écailles de dragons de glace';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2,  -2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Écailles de dragons de glace';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3,  -1 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Écailles de dragons de glace';

-- AQUATIQUE (gros bonus)
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2,  -3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Écailles de dragons de glace';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1,   5 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Écailles de dragons de glace';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0,   8 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Écailles de dragons de glace';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1,  12 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Écailles de dragons de glace';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2,  18 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Écailles de dragons de glace';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3,  27 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Écailles de dragons de glace';

-- CÉLESTE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2,  2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Écailles de dragons de glace';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1,  4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Écailles de dragons de glace';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0,  6 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Écailles de dragons de glace';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1,  8 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Écailles de dragons de glace';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 13 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Écailles de dragons de glace';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 19 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Écailles de dragons de glace';

-- TERRESTRE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2,  2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Écailles de dragons de glace';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1,  4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Écailles de dragons de glace';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0,  6 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Écailles de dragons de glace';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1,  8 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Écailles de dragons de glace';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 13 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Écailles de dragons de glace';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 19 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Écailles de dragons de glace';

COMMIT;

-- ÉCAILLES DE DRAGON AQUATIQUE

BEGIN TRANSACTION;

-- 1) Matériau
INSERT OR IGNORE INTO MATERIAUX (nom_materiau, categorie, realisme, description)
VALUES ('Écailles de dragons aquatiques', 'Organique', 'fantastique', 'Écailles épaisses des dragons aquatiques. Excellente défense contre l’eau, mais sensibles aux attaques célestes.');

-- 2) Coût & rareté (plus rare que glace)
INSERT OR IGNORE INTO MATERIAUX_COUTS (id_materiau, base_valeur, rarete)
SELECT id_materiau, 550, 11
FROM MATERIAUX
WHERE nom_materiau='Écailles de dragons aquatiques';

-- 3) Effets par qualité

-- TRANCHANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2,  3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Écailles de dragons aquatiques';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1,  4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Écailles de dragons aquatiques';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0,  7 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Écailles de dragons aquatiques';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, 10 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Écailles de dragons aquatiques';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 15 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Écailles de dragons aquatiques';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 23 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Écailles de dragons aquatiques';

-- CONTONDANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2,  3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Écailles de dragons aquatiques';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1,  4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Écailles de dragons aquatiques';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0,  6 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Écailles de dragons aquatiques';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1,  9 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Écailles de dragons aquatiques';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 13 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Écailles de dragons aquatiques';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 20 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Écailles de dragons aquatiques';

-- PERFORANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2,  3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Écailles de dragons aquatiques';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1,  4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Écailles de dragons aquatiques';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0,  6 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Écailles de dragons aquatiques';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, 10 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Écailles de dragons aquatiques';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 15 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Écailles de dragons aquatiques';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 22 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Écailles de dragons aquatiques';

-- IGNÉE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2,  3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Écailles de dragons aquatiques';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1,  4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Écailles de dragons aquatiques';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0,  6 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Écailles de dragons aquatiques';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1,  9 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Écailles de dragons aquatiques';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 13 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Écailles de dragons aquatiques';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 20 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Écailles de dragons aquatiques';

-- AQUATIQUE (énorme boost)
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2,  4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Écailles de dragons aquatiques';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1,  5 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Écailles de dragons aquatiques';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0,  8 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Écailles de dragons aquatiques';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, 12 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Écailles de dragons aquatiques';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 19 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Écailles de dragons aquatiques';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 28 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Écailles de dragons aquatiques';

-- CÉLESTE (grosse faiblesse)
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -14 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Écailles de dragons aquatiques';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1,  -9 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Écailles de dragons aquatiques';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0,  -6 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Écailles de dragons aquatiques';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1,  -4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Écailles de dragons aquatiques';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2,  -3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Écailles de dragons aquatiques';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3,  -2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Écailles de dragons aquatiques';

-- TERRESTRE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2,  2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Écailles de dragons aquatiques';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1,  3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Écailles de dragons aquatiques';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0,  5 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Écailles de dragons aquatiques';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1,  7 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Écailles de dragons aquatiques';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 11 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Écailles de dragons aquatiques';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 17 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Écailles de dragons aquatiques';

COMMIT;

-- ÉCAILLES DE DRAGONS CÉLESTES

BEGIN TRANSACTION;

-- 1) Matériau
INSERT OR IGNORE INTO MATERIAUX (nom_materiau, categorie, realisme, description)
VALUES ('Écailles de dragons célestes', 'Organique', 'fantastique', 'Écailles imprégnées de foudre et de vents orageux. Excellente défense contre le céleste, mais faiblesse marquée face au terrestre.');

-- 2) Coût & rareté (très rare)
INSERT OR IGNORE INTO MATERIAUX_COUTS (id_materiau, base_valeur, rarete)
SELECT id_materiau, 600, 12
FROM MATERIAUX
WHERE nom_materiau='Écailles de dragons célestes';

-- 3) Effets par qualité

-- TRANCHANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2,  3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Écailles de dragons célestes';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1,  4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Écailles de dragons célestes';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0,  7 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Écailles de dragons célestes';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, 10 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Écailles de dragons célestes';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 15 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Écailles de dragons célestes';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 23 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Écailles de dragons célestes';

-- CONTONDANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2,  3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Écailles de dragons célestes';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1,  4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Écailles de dragons célestes';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0,  6 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Écailles de dragons célestes';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1,  9 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Écailles de dragons célestes';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 13 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Écailles de dragons célestes';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 20 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Écailles de dragons célestes';

-- PERFORANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2,  3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Écailles de dragons célestes';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1,  4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Écailles de dragons célestes';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0,  6 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Écailles de dragons célestes';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, 10 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Écailles de dragons célestes';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 15 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Écailles de dragons célestes';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 22 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Écailles de dragons célestes';

-- IGNÉE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2,  2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Écailles de dragons célestes';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1,  3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Écailles de dragons célestes';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0,  5 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Écailles de dragons célestes';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1,  7 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Écailles de dragons célestes';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 11 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Écailles de dragons célestes';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 17 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Écailles de dragons célestes';

-- AQUATIQUE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2,  2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Écailles de dragons célestes';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1,  4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Écailles de dragons célestes';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0,  6 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Écailles de dragons célestes';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1,  8 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Écailles de dragons célestes';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 13 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Écailles de dragons célestes';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 19 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Écailles de dragons célestes';

-- CÉLESTE (ultra boost)
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2,   4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Écailles de dragons célestes';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1,   5 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Écailles de dragons célestes';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0,   8 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Écailles de dragons célestes';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1,  12 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Écailles de dragons célestes';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2,  19 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Écailles de dragons célestes';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3,  28 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Écailles de dragons célestes';

-- TERRESTRE (faiblesse marquée)
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -14 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Écailles de dragons célestes';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1,  -9 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Écailles de dragons célestes';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0,  -6 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Écailles de dragons célestes';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1,  -4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Écailles de dragons célestes';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2,  -3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Écailles de dragons célestes';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3,  -2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Écailles de dragons célestes';

COMMIT;

-- ÉCAILLES DE DRAGONS TERRESTRES

BEGIN TRANSACTION;

-- 1) Matériau
INSERT OR IGNORE INTO MATERIAUX (nom_materiau, categorie, realisme, description)
VALUES ('Écailles de dragons terrestres', 'Organique', 'fantastique', 'Écailles massives chargées de l’énergie de la terre. Défense colossale contre le terrestre, mais vulnérables au céleste.');

-- 2) Coût & rareté (très rare)
INSERT OR IGNORE INTO MATERIAUX_COUTS (id_materiau, base_valeur, rarete)
SELECT id_materiau, 600, 12
FROM MATERIAUX
WHERE nom_materiau='Écailles de dragons terrestres';

-- 3) Effets par qualité

-- TRANCHANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2,  3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Écailles de dragons terrestres';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1,  4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Écailles de dragons terrestres';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0,  7 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Écailles de dragons terrestres';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, 10 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Écailles de dragons terrestres';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 15 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Écailles de dragons terrestres';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 23 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Écailles de dragons terrestres';

-- CONTONDANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2,  3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Écailles de dragons terrestres';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1,  4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Écailles de dragons terrestres';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0,  6 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Écailles de dragons terrestres';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1,  9 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Écailles de dragons terrestres';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 13 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Écailles de dragons terrestres';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 20 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Écailles de dragons terrestres';

-- PERFORANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2,  3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Écailles de dragons terrestres';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1,  4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Écailles de dragons terrestres';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0,  6 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Écailles de dragons terrestres';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, 10 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Écailles de dragons terrestres';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 15 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Écailles de dragons terrestres';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 22 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Écailles de dragons terrestres';

-- IGNÉE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2,  2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Écailles de dragons terrestres';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1,  3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Écailles de dragons terrestres';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0,  5 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Écailles de dragons terrestres';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1,  7 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Écailles de dragons terrestres';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 11 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Écailles de dragons terrestres';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 17 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Écailles de dragons terrestres';

-- AQUATIQUE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2,  2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Écailles de dragons terrestres';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1,  4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Écailles de dragons terrestres';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0,  6 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Écailles de dragons terrestres';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1,  8 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Écailles de dragons terrestres';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 13 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Écailles de dragons terrestres';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 19 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Écailles de dragons terrestres';

-- CÉLESTE (faiblesse)
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -14 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Écailles de dragons terrestres';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1,  -9 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Écailles de dragons terrestres';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0,  -6 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Écailles de dragons terrestres';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1,  -4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Écailles de dragons terrestres';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2,  -3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Écailles de dragons terrestres';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3,  -2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Écailles de dragons terrestres';

-- TERRESTRE (ultra boost)
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2,  4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Écailles de dragons terrestres';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1,  5 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Écailles de dragons terrestres';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0,  8 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Écailles de dragons terrestres';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, 12 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Écailles de dragons terrestres';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 19 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Écailles de dragons terrestres';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 28 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Écailles de dragons terrestres';

COMMIT;

-- ÉCAILLES DE SEIGNEUR DRAGON

BEGIN TRANSACTION;

-- 1) Matériau
INSERT OR IGNORE INTO MATERIAUX (nom_materiau, categorie, realisme, description)
VALUES ('Écailles de Seigneurs Dragons', 'Organique', 'fantastique', 'Les écailles ultimes, imprégnées d’une puissance draconique absolue. Elles offrent une protection inégalée contre tous les types de dégâts, sans faiblesse.');

-- 2) Coût & rareté (artefact ultime)
INSERT OR IGNORE INTO MATERIAUX_COUTS (id_materiau, base_valeur, rarete)
SELECT id_materiau, 2000, 20
FROM MATERIAUX
WHERE nom_materiau='Écailles de Seigneurs Dragons';

-- 3) Effets par qualité

-- TRANCHANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2,  4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Écailles de Seigneurs Dragons';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1,  5 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Écailles de Seigneurs Dragons';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0,  8 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Écailles de Seigneurs Dragons';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, 12 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Écailles de Seigneurs Dragons';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 19 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Écailles de Seigneurs Dragons';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 28 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Écailles de Seigneurs Dragons';

-- CONTONDANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2,  4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Écailles de Seigneurs Dragons';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1,  5 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Écailles de Seigneurs Dragons';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0,  8 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Écailles de Seigneurs Dragons';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, 12 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Écailles de Seigneurs Dragons';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 19 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Écailles de Seigneurs Dragons';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 28 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Écailles de Seigneurs Dragons';

-- PERFORANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2,  4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Écailles de Seigneurs Dragons';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1,  5 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Écailles de Seigneurs Dragons';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0,  8 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Écailles de Seigneurs Dragons';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, 12 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Écailles de Seigneurs Dragons';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 19 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Écailles de Seigneurs Dragons';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 28 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Écailles de Seigneurs Dragons';

-- IGNÉE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2,  4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Écailles de Seigneurs Dragons';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1,  5 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Écailles de Seigneurs Dragons';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0,  8 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Écailles de Seigneurs Dragons';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, 12 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Écailles de Seigneurs Dragons';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 19 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Écailles de Seigneurs Dragons';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 28 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Écailles de Seigneurs Dragons';

-- AQUATIQUE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2,  4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Écailles de Seigneurs Dragons';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1,  5 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Écailles de Seigneurs Dragons';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0,  8 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Écailles de Seigneurs Dragons';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, 12 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Écailles de Seigneurs Dragons';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 19 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Écailles de Seigneurs Dragons';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 28 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Écailles de Seigneurs Dragons';

-- CÉLESTE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2,  4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Écailles de Seigneurs Dragons';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1,  5 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Écailles de Seigneurs Dragons';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0,  8 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Écailles de Seigneurs Dragons';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, 12 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Écailles de Seigneurs Dragons';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 19 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Écailles de Seigneurs Dragons';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 28 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Écailles de Seigneurs Dragons';

-- TERRESTRE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2,  4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Écailles de Seigneurs Dragons';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1,  5 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Écailles de Seigneurs Dragons';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0,  8 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Écailles de Seigneurs Dragons';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, 12 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Écailles de Seigneurs Dragons';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 19 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Écailles de Seigneurs Dragons';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 28 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Écailles de Seigneurs Dragons';

COMMIT;

-- COQUILLE D'ESCARGOT D'EAU

BEGIN TRANSACTION;

-- 1) Matériau
INSERT OR IGNORE INTO MATERIAUX (nom_materiau, categorie, realisme, description)
VALUES ('Coquille d’Escargots d’Eau', 'Organique', 'fantastique', 'Une coquille fragile mais chargée d’énergie aquatique. Faible contre les chocs directs, mais excellente pour la résistance magique aquatique.');

-- 2) Coût & rareté
INSERT OR IGNORE INTO MATERIAUX_COUTS (id_materiau, base_valeur, rarete)
SELECT id_materiau, 250, 6
FROM MATERIAUX
WHERE nom_materiau='Coquille d’Escargots d’Eau';

-- 3) Effets par qualité

-- TRANCHANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 1 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Coquille d’Escargots d’Eau';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Coquille d’Escargots d’Eau';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, 3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Coquille d’Escargots d’Eau';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, 5 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Coquille d’Escargots d’Eau';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 8 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Coquille d’Escargots d’Eau';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 12 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Coquille d’Escargots d’Eau';

-- CONTONDANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -16 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Coquille d’Escargots d’Eau';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -11 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Coquille d’Escargots d’Eau';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, -7 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Coquille d’Escargots d’Eau';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, -5 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Coquille d’Escargots d’Eau';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, -3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Coquille d’Escargots d’Eau';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, -2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Coquille d’Escargots d’Eau';

-- PERFORANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 1 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Coquille d’Escargots d’Eau';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Coquille d’Escargots d’Eau';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, 3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Coquille d’Escargots d’Eau';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, 4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Coquille d’Escargots d’Eau';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 7 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Coquille d’Escargots d’Eau';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 10 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Coquille d’Escargots d’Eau';

-- IGNÉE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 0 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Coquille d’Escargots d’Eau';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 1 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Coquille d’Escargots d’Eau';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, 2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Coquille d’Escargots d’Eau';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, 3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Coquille d’Escargots d’Eau';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 5 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Coquille d’Escargots d’Eau';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 8 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Coquille d’Escargots d’Eau';

-- AQUATIQUE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Coquille d’Escargots d’Eau';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Coquille d’Escargots d’Eau';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, 6 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Coquille d’Escargots d’Eau';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, 8 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Coquille d’Escargots d’Eau';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 13 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Coquille d’Escargots d’Eau';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 19 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Coquille d’Escargots d’Eau';

-- CÉLESTE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -12 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Coquille d’Escargots d’Eau';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -8 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Coquille d’Escargots d’Eau';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, -5 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Coquille d’Escargots d’Eau';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, -3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Coquille d’Escargots d’Eau';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, -2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Coquille d’Escargots d’Eau';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, -1 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Coquille d’Escargots d’Eau';

-- TERRESTRE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 0 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Coquille d’Escargots d’Eau';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 1 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Coquille d’Escargots d’Eau';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, 2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Coquille d’Escargots d’Eau';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, 3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Coquille d’Escargots d’Eau';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 5 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Coquille d’Escargots d’Eau';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 7 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Coquille d’Escargots d’Eau';

COMMIT;

-- COQUILLE D'ESCARGOT TERRESTRE

BEGIN TRANSACTION;

-- 1) Matériau
INSERT OR IGNORE INTO MATERIAUX (nom_materiau, categorie, realisme, description)
VALUES ('Coquille d’Escargots Terrestres', 'Organique', 'fantastique', 'Une coquille robuste et lourde adaptée au milieu terrestre. Fragile contre les chocs et la chaleur, mais très résistante en magie terrestre.');

-- 2) Coût & rareté
INSERT OR IGNORE INTO MATERIAUX_COUTS (id_materiau, base_valeur, rarete)
SELECT id_materiau, 250, 6
FROM MATERIAUX
WHERE nom_materiau='Coquille d’Escargots Terrestres';

-- 3) Effets par qualité

-- TRANCHANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 1 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Coquille d’Escargots Terrestres';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Coquille d’Escargots Terrestres';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, 3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Coquille d’Escargots Terrestres';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, 4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Coquille d’Escargots Terrestres';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 7 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Coquille d’Escargots Terrestres';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 10 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Coquille d’Escargots Terrestres';

-- CONTONDANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -18 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Coquille d’Escargots Terrestres';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -12 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Coquille d’Escargots Terrestres';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, -8 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Coquille d’Escargots Terrestres';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, -5 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Coquille d’Escargots Terrestres';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, -3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Coquille d’Escargots Terrestres';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, -2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Coquille d’Escargots Terrestres';

-- PERFORANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 1 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Coquille d’Escargots Terrestres';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Coquille d’Escargots Terrestres';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, 3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Coquille d’Escargots Terrestres';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, 4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Coquille d’Escargots Terrestres';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 7 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Coquille d’Escargots Terrestres';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 10 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Coquille d’Escargots Terrestres';

-- IGNÉE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -23 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Coquille d’Escargots Terrestres';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -15 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Coquille d’Escargots Terrestres';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, -10 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Coquille d’Escargots Terrestres';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, -7 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Coquille d’Escargots Terrestres';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, -4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Coquille d’Escargots Terrestres';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, -3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Coquille d’Escargots Terrestres';

-- AQUATIQUE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Coquille d’Escargots Terrestres';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Coquille d’Escargots Terrestres';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, 6 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Coquille d’Escargots Terrestres';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, 8 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Coquille d’Escargots Terrestres';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 13 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Coquille d’Escargots Terrestres';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 19 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Coquille d’Escargots Terrestres';

-- CÉLESTE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -12 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Coquille d’Escargots Terrestres';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -8 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Coquille d’Escargots Terrestres';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, -5 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Coquille d’Escargots Terrestres';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, -3 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Coquille d’Escargots Terrestres';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, -2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Coquille d’Escargots Terrestres';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, -1 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Coquille d’Escargots Terrestres';

-- TERRESTRE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 2 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Coquille d’Escargots Terrestres';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 4 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Coquille d’Escargots Terrestres';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, 6 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Coquille d’Escargots Terrestres';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, 8 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Coquille d’Escargots Terrestres';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 13 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Coquille d’Escargots Terrestres';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 19 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Coquille d’Escargots Terrestres';

COMMIT;

-- SUBSTANCE GELATINEUSE/ACIDE

BEGIN TRANSACTION;

-- 1) Matériau
INSERT OR IGNORE INTO MATERIAUX (nom_materiau, categorie, realisme, description)
VALUES ('Substance Gélatineuse', 'Organique', 'fantastique', 'Une masse gélatineuse qui amortit tous les coups physiques, mais très vulnérable aux énergies élémentaires.');

-- 2) Coût & rareté
INSERT OR IGNORE INTO MATERIAUX_COUTS (id_materiau, base_valeur, rarete)
SELECT id_materiau, 400, 9
FROM MATERIAUX
WHERE nom_materiau='Substance Gélatineuse';

-- 3) Effets par qualité

-- TRANCHANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 10 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Substance Gélatineuse';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 15 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Substance Gélatineuse';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, 22 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Substance Gélatineuse';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, 33 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Substance Gélatineuse';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 50 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Substance Gélatineuse';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 75 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='tranchant' WHERE m.nom_materiau='Substance Gélatineuse';

-- CONTONDANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 10 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Substance Gélatineuse';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 15 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Substance Gélatineuse';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, 22 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Substance Gélatineuse';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, 33 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Substance Gélatineuse';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 50 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Substance Gélatineuse';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 75 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='contondant' WHERE m.nom_materiau='Substance Gélatineuse';

-- PERFORANT
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, 10 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Substance Gélatineuse';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, 15 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Substance Gélatineuse';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, 22 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Substance Gélatineuse';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, 33 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Substance Gélatineuse';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, 50 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Substance Gélatineuse';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, 75 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='perforant' WHERE m.nom_materiau='Substance Gélatineuse';

-- IGNÉE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -60 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Substance Gélatineuse';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -40 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Substance Gélatineuse';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, -27 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Substance Gélatineuse';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, -18 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Substance Gélatineuse';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, -12 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Substance Gélatineuse';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, -8 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='ignee' WHERE m.nom_materiau='Substance Gélatineuse';

-- AQUATIQUE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -60 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Substance Gélatineuse';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -40 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Substance Gélatineuse';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, -27 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Substance Gélatineuse';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, -18 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Substance Gélatineuse';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, -12 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Substance Gélatineuse';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, -8 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='aquatique' WHERE m.nom_materiau='Substance Gélatineuse';

-- CÉLESTE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -60 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Substance Gélatineuse';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -40 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Substance Gélatineuse';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, -27 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Substance Gélatineuse';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, -18 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Substance Gélatineuse';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, -12 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Substance Gélatineuse';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, -8 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='celeste' WHERE m.nom_materiau='Substance Gélatineuse';

-- TERRESTRE
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -2, -60 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Substance Gélatineuse';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats, -1, -40 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Substance Gélatineuse';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  0, -27 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Substance Gélatineuse';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  1, -18 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Substance Gélatineuse';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  2, -12 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Substance Gélatineuse';
INSERT OR REPLACE INTO MATERIAUX_EFFETS SELECT m.id_materiau, td.id_type_degats,  3, -8 FROM MATERIAUX m JOIN REF_TYPE_DEGATS td ON td.code='terrestre' WHERE m.nom_materiau='Substance Gélatineuse';

COMMIT;
