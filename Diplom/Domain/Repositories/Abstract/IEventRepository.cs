﻿using Diplom.Domain.Entities;

namespace Diplom.Domain.Repositories.Abstract
{
	public interface IEventRepository //интерфейс сущности новости БД
	{
		IQueryable<Event> GetEvents();
		Event GetEventById(int id);
		Event GetEventByName(string name);
		void SaveEvent(Event entity);
		void DeleteEvent(int id);

	}
}
