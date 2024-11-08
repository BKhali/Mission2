-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : ven. 18 oct. 2024 à 08:33
-- Version du serveur : 8.2.0
-- Version de PHP : 8.2.13

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `mlr10`
--

-- --------------------------------------------------------

--
-- Structure de la table `bateau`
--

DROP TABLE IF EXISTS `bateau`;
CREATE TABLE IF NOT EXISTS `bateau` (
  `IDBATE` int NOT NULL,
  `NOM` char(255) DEFAULT NULL,
  `LONGUEUR` int DEFAULT NULL,
  `LARGEUR` int DEFAULT NULL,
  `VITESSE` int DEFAULT NULL,
  PRIMARY KEY (`IDBATE`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `bateau`
--

INSERT INTO `bateau` (`IDBATE`, `NOM`, `LONGUEUR`, `LARGEUR`, `VITESSE`) VALUES
(1, 'Titanic', 269, 28, 21),
(2, 'Queen Mary', 310, 36, 28),
(3, 'Bismarck', 251, 36, 30),
(4, 'USS Arizona', 184, 29, 21),
(5, 'Lusitania', 245, 28, 25);

-- --------------------------------------------------------

--
-- Structure de la table `categorie`
--

DROP TABLE IF EXISTS `categorie`;
CREATE TABLE IF NOT EXISTS `categorie` (
  `IDCAT` int NOT NULL,
  `LIBELLE` char(255) DEFAULT NULL,
  PRIMARY KEY (`IDCAT`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `categorie`
--

INSERT INTO `categorie` (`IDCAT`, `LIBELLE`) VALUES
(1, 'Classe Économique'),
(2, 'Classe Affaires'),
(3, 'Première Classe'),
(4, 'Classe Familiale'),
(5, 'Classe VIP');

-- --------------------------------------------------------

--
-- Structure de la table `client`
--

DROP TABLE IF EXISTS `client`;
CREATE TABLE IF NOT EXISTS `client` (
  `IDCLIENT` int NOT NULL,
  `NOM` char(255) NOT NULL,
  `PRENOM` char(255) DEFAULT NULL,
  PRIMARY KEY (`IDCLIENT`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `client`
--

INSERT INTO `client` (`IDCLIENT`, `NOM`, `PRENOM`) VALUES
(1, 'Dupont', 'Jean'),
(2, 'Martin', 'Claire'),
(3, 'Durand', 'Luc'),
(4, 'Lefevre', 'Marie'),
(5, 'Lemoine', 'Paul');

-- --------------------------------------------------------

--
-- Structure de la table `contenir`
--

DROP TABLE IF EXISTS `contenir`;
CREATE TABLE IF NOT EXISTS `contenir` (
  `IDBATE` int NOT NULL,
  `IDCAT` int NOT NULL,
  `CAPACITEMAX` int DEFAULT NULL,
  PRIMARY KEY (`IDBATE`,`IDCAT`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `contenir`
--

INSERT INTO `contenir` (`IDBATE`, `IDCAT`, `CAPACITEMAX`) VALUES
(1, 1, 200),
(2, 2, 300),
(3, 1, 250),
(4, 3, 150),
(5, 2, 400);

-- --------------------------------------------------------

--
-- Structure de la table `equipement`
--

DROP TABLE IF EXISTS `equipement`;
CREATE TABLE IF NOT EXISTS `equipement` (
  `IDTAR` int NOT NULL,
  `LIBELLE` char(255) DEFAULT NULL,
  PRIMARY KEY (`IDTAR`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `equipement`
--

INSERT INTO `equipement` (`IDTAR`, `LIBELLE`) VALUES
(1, 'Gilet de sauvetage'),
(2, 'Système de navigation'),
(3, 'Extincteur'),
(4, 'Ancre'),
(5, 'Boussole');

-- --------------------------------------------------------

--
-- Structure de la table `liaison`
--

DROP TABLE IF EXISTS `liaison`;
CREATE TABLE IF NOT EXISTS `liaison` (
  `IDLIAIS` int NOT NULL,
  `IDSEC` int NOT NULL,
  `IDPORT_DEPART` int NOT NULL,
  `IDPORT_ARRIVEE` int NOT NULL,
  `DUREE` char(255) DEFAULT NULL,
  PRIMARY KEY (`IDLIAIS`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `liaison`
--

INSERT INTO `liaison` (`IDLIAIS`, `IDSEC`, `IDPORT_DEPART`, `IDPORT_ARRIVEE`, `DUREE`) VALUES
(1, 1, 1, 2, '02:00'),
(2, 1, 2, 3, '04:00'),
(3, 2, 3, 4, '03:30'),
(4, 2, 4, 5, '05:00'),
(5, 3, 1, 3, '01:30');

-- --------------------------------------------------------

--
-- Structure de la table `periode`
--

DROP TABLE IF EXISTS `periode`;
CREATE TABLE IF NOT EXISTS `periode` (
  `IDPER` int NOT NULL,
  `DATEDEBUT` date DEFAULT NULL,
  `DATEFIN` date DEFAULT NULL,
  PRIMARY KEY (`IDPER`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `periode`
--

INSERT INTO `periode` (`IDPER`, `DATEDEBUT`, `DATEFIN`) VALUES
(1, '2024-01-01', '2024-03-31'),
(2, '2024-04-01', '2024-06-30'),
(3, '2024-07-01', '2024-09-30'),
(4, '2024-10-01', '2024-12-31'),
(5, '2025-01-01', '2025-03-31');

-- --------------------------------------------------------

--
-- Structure de la table `port`
--

DROP TABLE IF EXISTS `port`;
CREATE TABLE IF NOT EXISTS `port` (
  `IDPORT` int NOT NULL,
  `IDLIAIS` int NOT NULL,
  `NOM` char(255) DEFAULT NULL,
  PRIMARY KEY (`IDPORT`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `port`
--

INSERT INTO `port` (`IDPORT`, `IDLIAIS`, `NOM`) VALUES
(1, 1, 'Port de Marseille'),
(2, 1, 'Port de Nice'),
(3, 2, 'Port de Rotterdam'),
(4, 2, 'Port d’Amsterdam'),
(5, 3, 'Port de New York');

-- --------------------------------------------------------

--
-- Structure de la table `proposer`
--

DROP TABLE IF EXISTS `proposer`;
CREATE TABLE IF NOT EXISTS `proposer` (
  `IDBATE` int NOT NULL,
  `IDTAR` int NOT NULL,
  PRIMARY KEY (`IDBATE`,`IDTAR`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `proposer`
--

INSERT INTO `proposer` (`IDBATE`, `IDTAR`) VALUES
(1, 1),
(2, 2),
(3, 3),
(4, 4),
(5, 5);

-- --------------------------------------------------------

--
-- Structure de la table `qtreserv`
--

DROP TABLE IF EXISTS `qtreserv`;
CREATE TABLE IF NOT EXISTS `qtreserv` (
  `IDTYPE` int NOT NULL,
  `IDCLIENT` int NOT NULL,
  `QUANTITE` int DEFAULT NULL,
  PRIMARY KEY (`IDTYPE`,`IDCLIENT`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `qtreserv`
--

INSERT INTO `qtreserv` (`IDTYPE`, `IDCLIENT`, `QUANTITE`) VALUES
(1, 1, 2),
(1, 2, 1),
(2, 3, 4),
(3, 4, 3),
(2, 5, 5);

-- --------------------------------------------------------

--
-- Structure de la table `reservation`
--

DROP TABLE IF EXISTS `reservation`;
CREATE TABLE IF NOT EXISTS `reservation` (
  `IDCLIENT` int NOT NULL,
  `IDLIAIS` int NOT NULL,
  `IDTRAV` int NOT NULL,
  `NUMRESERVATION` int DEFAULT NULL,
  PRIMARY KEY (`IDCLIENT`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `reservation`
--

INSERT INTO `reservation` (`IDCLIENT`, `IDLIAIS`, `IDTRAV`, `NUMRESERVATION`) VALUES
(1, 1, 101, 1001),
(2, 1, 102, 1002),
(3, 2, 201, 2001),
(4, 2, 202, 2002),
(5, 3, 301, 3001);

-- --------------------------------------------------------

--
-- Structure de la table `secteur`
--

DROP TABLE IF EXISTS `secteur`;
CREATE TABLE IF NOT EXISTS `secteur` (
  `IDSEC` int NOT NULL,
  `LIBELLE` char(255) DEFAULT NULL,
  PRIMARY KEY (`IDSEC`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `secteur`
--

INSERT INTO `secteur` (`IDSEC`, `LIBELLE`) VALUES
(1, 'Nord'),
(2, 'Sud'),
(3, 'Est'),
(4, 'Ouest'),
(5, 'Centre');

-- --------------------------------------------------------

--
-- Structure de la table `tarif`
--

DROP TABLE IF EXISTS `tarif`;
CREATE TABLE IF NOT EXISTS `tarif` (
  `IDLIAIS` int NOT NULL,
  `IDPER` int NOT NULL,
  `IDTYPE` int NOT NULL,
  `TARIF` int DEFAULT NULL,
  PRIMARY KEY (`IDLIAIS`,`IDPER`,`IDTYPE`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `tarif`
--

INSERT INTO `tarif` (`IDLIAIS`, `IDPER`, `IDTYPE`, `TARIF`) VALUES
(1, 1, 1, 50),
(1, 2, 1, 55),
(2, 1, 2, 60),
(2, 2, 2, 65),
(3, 1, 3, 70);

-- --------------------------------------------------------

--
-- Structure de la table `traverse`
--

DROP TABLE IF EXISTS `traverse`;
CREATE TABLE IF NOT EXISTS `traverse` (
  `IDLIAIS` int NOT NULL,
  `IDTRAV` int NOT NULL,
  `IDBATE` int NOT NULL,
  `DATETRAV` date DEFAULT NULL,
  `HEURE` time DEFAULT NULL,
  PRIMARY KEY (`IDLIAIS`,`IDTRAV`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `traverse`
--

INSERT INTO `traverse` (`IDLIAIS`, `IDTRAV`, `IDBATE`, `DATETRAV`, `HEURE`) VALUES
(1, 101, 1, '2024-10-10', '12:00:00'),
(1, 102, 2, '2024-10-11', '14:00:00'),
(2, 201, 3, '2024-10-12', '16:00:00'),
(2, 202, 4, '2024-10-13', '18:00:00'),
(3, 301, 5, '2024-10-14', '20:00:00');

-- --------------------------------------------------------

--
-- Structure de la table `type`
--

DROP TABLE IF EXISTS `type`;
CREATE TABLE IF NOT EXISTS `type` (
  `IDTYPE` int NOT NULL,
  `IDCAT` int NOT NULL,
  `LIBELLE` char(255) DEFAULT NULL,
  PRIMARY KEY (`IDTYPE`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `type`
--

INSERT INTO `type` (`IDTYPE`, `IDCAT`, `LIBELLE`) VALUES
(1, 1, 'Type A'),
(2, 1, 'Type B'),
(3, 2, 'Type C'),
(4, 2, 'Type D'),
(5, 3, 'Type E');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
