using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWebAssemblyCrud.Shared.Entities
{
	public class Artikul
	{
		public int ArtikulID {  get; set; }
		public string? ArtikulName { get; set; }
		public Double ArtikulPrice { get; set; }
		public DateTime ArtikulDate { get; set; }

	}
}
