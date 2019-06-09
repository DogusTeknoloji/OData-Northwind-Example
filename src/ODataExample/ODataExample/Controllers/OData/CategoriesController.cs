﻿using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Routing;
using Microsoft.EntityFrameworkCore;
using NorthwindEFCore;
using NorthwindEFCore.Entities;
using System.Linq;

namespace ODataExample.Controllers.OData
{
	[ODataRoutePrefix("Categories")]
	public class CategoriesController : ODataController
	{
		private readonly NorthwindDbContext _db;

		public CategoriesController(NorthwindDbContext db)
		{
			_db = db;
			_db.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
		}

		public IQueryable<Category> Get()
		{
			return _db.Set<Category>();
		}
	}
}