

using Microsoft.EntityFrameworkCore;
using national_football_matchesAPI.Models;

namespace national_football_matchesAPI.Data
{
	public class APIContext : DbContext
	{
		public APIContext(DbContextOptions<APIContext> options) : base(options)
		{

		}

		public DbSet<Match> matches { get; set; }
	}
}
