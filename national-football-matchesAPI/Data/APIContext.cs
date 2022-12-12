

using Microsoft.EntityFrameworkCore;

namespace national_football_matchesAPI.Data
{
	public class APIContext : DbContext
	{
		public APIContext(DbContextOptions<APIContext> options) : base(options)
		{

		}

	}
}
