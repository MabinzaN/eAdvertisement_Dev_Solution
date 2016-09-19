namespace eAdertisement.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Vacancy")]
    public partial class Vacancy
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int VacancyId { get; set; }

        public int? ExpiredVacancyId { get; set; }

        public int? DepartmentId { get; set; }

        public int? PendingVacancyId { get; set; }

        public int? PublishedVacancyId { get; set; }

        public int? UnpublishedVacancyId { get; set; }

        public string Post { get; set; }

        public string Attention { get; set; }

        public DateTime? ClosingDate { get; set; }

        public int? Telephone { get; set; }

        public string Salary { get; set; }

        public string Centre { get; set; }


        public string Application { get; set; }

        public string Requirements { get; set; }


        public string Note { get; set; }

        public string Duties { get; set; }


        public string ReferenceNo { get; set; }

        public int? Level { get; set; }

        public virtual Department Department { get; set; }

        public virtual ExpiredVacancy ExpiredVacancy { get; set; }

        public virtual PendingVacancy PendingVacancy { get; set; }

        public virtual PublishedVacancy PublishedVacancy { get; set; }

        public virtual UnpublishedVacancy UnpublishedVacancy { get; set; }
    }
}
