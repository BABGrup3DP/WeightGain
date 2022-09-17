using System.Data.Entity.ModelConfiguration;
using WeightGain.DATA;

namespace WeightGain.DAL
{
    public class UserMapping : EntityTypeConfiguration<User>
    {
        public UserMapping()
        {
            this.ToTable("Kullanici");
        }
    }
}
