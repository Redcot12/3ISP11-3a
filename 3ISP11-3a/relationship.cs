//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _3ISP11_3a
{
    using System;
    using System.Collections.Generic;
    
    public partial class relationship
    {
        public int idRelationship { get; set; }
        public int idUser1 { get; set; }
        public int idUser2 { get; set; }
        public int idStatusRelationship { get; set; }
    
        public virtual statusRelationship statusRelationship { get; set; }
        public virtual user user { get; set; }
        public virtual user user1 { get; set; }
    }
}
