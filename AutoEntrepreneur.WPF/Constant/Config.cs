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

        #region SqlCommand
        public const string CREATE_DATABASE = "CREATE DATABASE IF NOT EXISTS `auto_entrepreneur`;";
        #endregion
    }
}
