using Microsoft.AspNetCore.Mvc;
using national_football_matchesAPI.Data;

namespace national_football_matchesAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class MatchController : ControllerBase
	{
		private readonly APIContext _db;
		public MatchController(APIContext db)
		{
			_db = db;
		}

		[HttpGet]
		public IActionResult getMatch(string homeTeam, string awayTeam)
		{
			var database = _db.Database.CanConnect();

			var result = _db.results
				.Where(n => n.home_team == homeTeam && n.away_team == awayTeam)
				.ToList();

			if (result.Count() == 0)
			{
				return StatusCode(404, "No matches found");

			}
			else
			{
				return Ok(result);
			}








		}
	}
}
