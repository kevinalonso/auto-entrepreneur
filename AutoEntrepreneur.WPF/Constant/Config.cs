using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoEntrepreneur.WPF.Constant
{
    public static class Config
    {
        #region MenuItem
        public const string HEADER_FICHIER = "Fichier";
        public const string HEADER_CLIENT = "Clients";
        public const string HEADER_PRODUIT = "Produits/Services";
        public const string HEADER_FACTURATION = "Facturation";
        public const string HEADER_FACTURE = "Factures";
        public const string HEADER_DEVIS = "Devis";
        public const string HEADER_CA = "CA";
        public const string HEADER_MOI = "Mon entreprise";


        public const string HEADER_A_PROPOS = "?";
        public const string HEADER_SAUVEGARDER = "Sauvegarder";
        public const string HEADER_QUITTER = "Quitter";
        #endregion

        #region Factory View
        public const string LABEL_LASTNAME = "Nom :";
        public const string LABEL_FIRSTNAME = "Prénom :";
        public const string LABEL_FACTORY_NAME= "Nom de l'entreprise :";
        public const string LABEL_ADRESSE = "Adresse :";
        public const string LABEL_VILLE = "Ville :";
        public const string LABEL_TEL = "Téléphone :";
        public const string LABEL_SIRET = "N° Siret :";
        #endregion

        #region SqlCommand
        public const string CREATE_DATABASE = "CREATE DATABASE IF NOT EXISTS `auto_entrepreneur`;";
        public const string CREATE_TABLE_PERSON = "CREATE TABLE Person("
                + "id INT NOT NULL auto_increment,"
                + "lastname VARCHAR(45) NULL,"
                + "firstname VARCHAR(45) NULL,"
                + "address VARCHAR(100) NULL,"
                + "tel VARCHAR(20) NULL,"
                + "siret INT NULL,"
                + "PRIMARY KEY (id))";
        public const string CREATE_TABLE_TYPE_MONEY = "CREATE TABLE type_money("
               + "id INT NOT NULL auto_increment,"
               + "libelle VARCHAR(45) NULL,"
               + "PRIMARY KEY (id))";
        public const string CREATE_TABLE_TYPE_CUSTOMER = "CREATE TABLE type_customer("
               + "id INT NOT NULL auto_increment,"
               + "libelle VARCHAR(45) NULL,"
               + "PRIMARY KEY (id))";
        public const string CREATE_TABLE_CUSTOMER = "CREATE TABLE customer("
                + "id INT NOT NULL auto_increment,"
                + "lastname VARCHAR(45) NULL,"
                + "firstname VARCHAR(45) NULL,"
                + "address VARCHAR(100) NULL,"
                + "cp VARCHAR(100) NULL,"
                + "city VARCHAR(100) NULL,"
                + "tel VARCHAR(20) NULL,"
                + "mobile VARCHAR(20) NULL,"
                + "email VARCHAR(20) NULL,"
                + "comment VARCHAR(255) NULL,"
                + "PRIMARY KEY (id))";
        public const string CREATE_TABLE_ARTICLE = "CREATE TABLE article("
                + "id INT NOT NULL auto_increment,"
                + "libelle VARCHAR(200) NULL,"
                + "ref VARCHAR(45) NULL,"
                + "cost_duty_free VARCHAR(100) NULL,"
                + "PRIMARY KEY (id))";
        #endregion
    }
}
