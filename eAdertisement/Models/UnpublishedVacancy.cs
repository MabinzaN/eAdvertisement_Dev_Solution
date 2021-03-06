namespace eAdertisement.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UnpublishedVacancy")]
    public partial class UnpublishedVacancy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UnpublishedVacancy()
        {
            Vacancies = new HashSet<Vacancy>();
        }

        public int UnpublishedVacancyId { get; set; }

        public int? VacancyId { get; set; }

        [StringLength(200)]
        public string Post { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vacancy> Vacancies { get; set; }
    }
}
