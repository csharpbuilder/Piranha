﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

using Piranha.Models;

namespace Piranha.Web
{
	/// <summary>
	/// HtmlHelper extensions for the Piranha application.
	/// </summary>
	public static class PiranhaHelper
	{
		/// <summary>
		/// Url helper for generating the url for the given permalink.
		/// </summary>
		/// <param name="helper">The url helper</param>
		/// <param name="permalink">The permalink</param>
		/// <returns>An action url</returns>
		public static string GetPermalink(this UrlHelper helper, string permalink) {
			return helper.Content("~/hem/" + permalink.ToLower()) ;
		}

		/// <summary>
		/// Url helper for generating the preview url for the given page id.
		/// </summary>
		/// <param name="helper">The url helper</param>
		/// <param name="id">The page id</param>
		/// <returns></returns>
		public static string GetPreviewlink(this UrlHelper helper, Guid id) {
			return helper.Content("~/preview/" + id.ToString()) ;
		}
	}
}
