//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Evaluation
{
    using System;
    using System.Collections.Generic;
    
    public partial class CommandDetails
    {
        public Nullable<int> CommandID { get; set; }
        public Nullable<int> ProductID { get; set; }
        public int Quantity { get; set; }
    
        public virtual Command Command { get; set; }
        public virtual Product Product { get; set; }
    }
}