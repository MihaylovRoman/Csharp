//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PR4
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            this.Products = new HashSet<Product>();
        }
    
        public int id { get; set; }
        public Nullable<System.DateTime> orderDate { get; set; }
        public Nullable<int> id_client { get; set; }
        public Nullable<int> id_product { get; set; }
        public Nullable<int> countProduct { get; set; }
        public Nullable<double> sumOrder { get; set; }
        public Nullable<double> sumDiscount { get; set; }
        public Nullable<int> id_pickUpPoint { get; set; }
        public Nullable<int> receiptCode { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual PickUpPoint PickUpPoint { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; }
    }
}
