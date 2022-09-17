using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeightGain.DATA;

namespace WeightGain.DAL
{
    public class ExerciseMapping : EntityTypeConfiguration<Exercise>
    {
        public ExerciseMapping()
        {
            this.ToTable("Egzersiz");
            this.HasKey(x=>x.ExerciseID);  
            this.Property(x=>x.ExerciseID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(x=>x.Duration).IsRequired();

        }
    }
}
