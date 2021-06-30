﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FilmsMVC.Models
{
	public class MovieGenreViewModel
	{
		public List<Movie> Movies { get; set; }
		public SelectList Genres { get; set; }
		public string MovieGenre { get; set; }
		public string SearchingString { get; set; }
	}
}
