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
		public IActionResult getMatchByteams(string homeTeam, string awayTeam)
		{


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
		[HttpGet("ByDate")]
		public IActionResult getMatchesByDate(string date)
		{
			var result = _db.results
				.Where(d => d.date == date)
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

		[HttpGet("ByCompetition")]
		public IActionResult getMatchesByCompetition(string competition, string? homeTeam, string? awayTeam)
		{
			var result = _db.results
				.Where(c => c.tournament == competition && c.home_team == homeTeam && c.away_team == awayTeam)
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

		[HttpGet("ByCityCountry")]
		public IActionResult getMatchesByCityCountry(string city, string country)
		{
			var result = _db.results
				.Where(c => c.city == city && c.country == country)
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

		[HttpGet("ByCityCountryCompedition")]
		public IActionResult getMatchesByCityCountryCompedition(string city, string country, string compedition)
		{
			var result = _db.results
				.Where(c => c.city == city
				&& c.country == country
				&& c.tournament == compedition)
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
