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
    
    public partial class categoryGame
    {
        public int idCategoryGame { get; set; }
        public int idGame { get; set; }
        public int idCategory { get; set; }
    
        public virtual category category { get; set; }
        public virtual game game { get; set; }
    }
}
