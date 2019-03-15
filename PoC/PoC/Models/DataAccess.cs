using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoC.Models
{
	public class DataAccess : DbContext
	{
		public DataAccess(DbContextOptions<DataAccess> data) : base(data) { }

		public DbSet<Meter> Meter { get; set; }
	}
}
