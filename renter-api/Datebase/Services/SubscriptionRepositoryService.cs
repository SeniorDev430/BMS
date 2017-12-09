﻿using Database.Interfaces;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Database.Services
{
	public class SubscriptionRepositoryService : RepositoryService<Subscription>, ISubscriptionRepositoryService
	{
		public SubscriptionRepositoryService(DbContext dbContext) : base(dbContext)
		{
		}
	}
}
