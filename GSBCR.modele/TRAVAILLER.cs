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
    
    public partial class TRAVAILLER
    {
        public string VIS_MATRICULE { get; set; }
        public System.DateTime JJMMAA { get; set; }
        public string REG_CODE { get; set; }
        public string TRA_ROLE { get; set; }
    
        public virtual REGION LaRegion { get; set; }
        public virtual VISITEUR LeVisiteur { get; set; }
    }
}
