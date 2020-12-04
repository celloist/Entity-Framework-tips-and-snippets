# Entity-Framework-tips-and-snippets
Small report to keep snippets of enitity framework code 


 Entity framework with a Nested list string: 
             modelBuilder.Entity<Document>()
            .OwnsOne(e => e.DocumentPropeties)
            .Property(p => p.Languages)
            .HasConversion(
                v => string.Join(",", v),
                v => v.Split(',', StringSplitOptions.RemoveEmptyEntries).ToList());
