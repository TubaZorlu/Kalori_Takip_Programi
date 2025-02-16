﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mapping
{
    public class MakroBesinRaporuMapping : EntityTypeConfiguration<MakroBesinRaporu>
    {
        public MakroBesinRaporuMapping()
        {
            this.HasKey(x => x.ID);
            this.Property(x => x.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).IsRequired();



            this.Property(x => x.CreatedBy).HasMaxLength(50);
            this.Property(x => x.ModifiedBy).HasMaxLength(50);
            this.Property(x => x.DeletedBy).HasMaxLength(50);

            this.Property(x => x.CreatedDate).IsRequired();
            this.Property(x => x.DeletedDate).IsOptional();
            this.Property(x => x.ModifiedDate).IsOptional();

            this.Property(x => x.Status).HasColumnName("Statu");

            this.HasMany(mr => mr.Kullanicilar)
                .WithOptional(k => k.MakroBesinRaporu)
                .HasForeignKey(k => k.MakroBesinRaporuID);

   


        }
    }
}
