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
    
    public partial class timePlayed
    {
        public int idTimePlayed { get; set; }
        public int idUserGame { get; set; }
        public System.DateTime timeStart { get; set; }
        public System.DateTime timeEnd { get; set; }
    
        public virtual userGame userGame { get; set; }
    }
}