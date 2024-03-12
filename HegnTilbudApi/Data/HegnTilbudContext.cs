using System;
using System.Collections.Generic;
using System.Linq;  
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using HegnTilbudApi.Model;

namespace HegnTilbudApi.Data;

public class HegnTilbudContext : DbContext
{
    public HegnTilbudContext(DbContextOptions<HegnTilbudContext> options) 
    :base(options) 
    { 
    
    }

    public DbSet<RaftHegn> rafHegn { get; set; } = default!;

}


//Scaffold-DbContext "Server=(localdb)\mssqllocaldb;Database=HegnTilbudApi.Data;Trusted_Connection=True;MultipleActiveResultSets=true" Microsoft.EntityFrameWorkCore.SqlServer -outputdir Repository/Models -context HegnTilbudApiDbContext -contextdir Repository -DataAnnotations -Force
