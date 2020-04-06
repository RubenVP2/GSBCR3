//------------------------------------------------------------------------------
// <auto-generated>
//    Ce code a été généré à partir d'un modèle.
//
//    Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//    Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GSBCR.modele
{
    using System;
    using System.Collections.Generic;
    
    public partial class PRATICIEN
    {
        public PRATICIEN()
        {
            this.POSSEDERs = new HashSet<POSSEDER>();
            this.LesRapports = new HashSet<RAPPORT_VISITE>();
        }
    
        public short PRA_NUM { get; set; }
        public string PRA_NOM { get; set; }
        public string PRA_PRENOM { get; set; }

        public string PRA_FULLNAME => $"{PRA_NOM} {PRA_PRENOM}";
        public string PRA_ADRESSE { get; set; }
        public string PRA_CP { get; set; }
        public string PRA_VILLE { get; set; }
        public Nullable<float> PRA_COEFNOTORIETE { get; set; }
        public string TYP_CODE { get; set; }
    
        public virtual ICollection<POSSEDER> POSSEDERs { get; set; }
        public virtual TYPE_PRATICIEN LeType { get; set; }
        public virtual ICollection<RAPPORT_VISITE> LesRapports { get; set; }
    }
}
