
: 
             modelBuilder.Entity<Document>()
            .OwnsOne(e => e.DocumentPropeties)
            .Property(p => p.Languages)
            .HasConversion(
                v => string.Join(",", v),
                v => v.Split(',', StringSplitOptions.RemoveEmptyEntries).ToList());
