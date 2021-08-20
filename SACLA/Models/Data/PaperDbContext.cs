using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SACLA.Models.Data
{
	public class PaperDbContext:DbContext
	{
		public DbSet<Paper> Paper { get; set; }

	}
}