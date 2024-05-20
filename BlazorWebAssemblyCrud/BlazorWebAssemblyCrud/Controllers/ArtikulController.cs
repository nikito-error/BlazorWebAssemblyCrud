using BlazorWebAssemblyCrud.Data;
using BlazorWebAssemblyCrud.Shared.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorWebAssemblyCrud.Controllers
{
	[Route("api/artikuls")]
	[ApiController]
	public class ArtikulController : ControllerBase
	{
		private readonly DataContext _context;

		public ArtikulController(DataContext context)
		{
			_context = context;
		}

		[HttpGet]
		public async Task<ActionResult<List<Artikul>>> GetAllArtikulsAsync()
		{
			return await _context.artikuls.ToListAsync();
		}

		[HttpGet("{id}")]
		public async Task<ActionResult<Artikul>> GetArtikulByIdAsync(int id)
		{
			var result =  await _context.artikuls.FindAsync(id);
			if(result  == null)
			{
				return NotFound("Artikul Not Found");
			}

			return Ok(result);
		}
		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteArtikulAsync(int id)
		{
			var result = await _context.artikuls.FindAsync(id);
			if (result == null)
			{
				return NotFound("Artikul Not Found");
			}

			_context.Remove(result);
			await _context.SaveChangesAsync();

			return Ok();
		}

		[HttpPut("{id}")]
		public async Task<ActionResult<Artikul>> UpdateArtikulAsync(int id, Artikul updatedArtikul)
		{
			var dbArtikul = await _context.artikuls.FindAsync(id);
			if (dbArtikul == null)
			{
				return NotFound("Artikul Not Found");
			}

			dbArtikul.ArtikulID = updatedArtikul.ArtikulID;
			dbArtikul.ArtikulName = updatedArtikul.ArtikulName;
			dbArtikul.ArtikulPrice = updatedArtikul.ArtikulPrice;
			dbArtikul.ArtikulDate = updatedArtikul.ArtikulDate;

			await _context.SaveChangesAsync();

			return Ok(dbArtikul);
		}

		[HttpPost]
		public async Task<ActionResult<Artikul>> AddArtikulAsync(Artikul newArtikul)
		{

			_context.Add(newArtikul);

			await _context.SaveChangesAsync();

			return Ok(newArtikul);
		}

	}
}
