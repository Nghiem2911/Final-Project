namespace Mall.model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    namespace Mall.model.EF
    {
        [Table("News")]
        public class News
        {
            public int ID { get; set; }

            [Column(TypeName = "ntext")]
            public string Content { get; set; }

            public bool? Status { get; set; }
        }
    }
}