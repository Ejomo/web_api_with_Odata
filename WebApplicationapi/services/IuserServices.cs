﻿using WebApplicationapi.modesl;

namespace WebApplicationapi.services
{
    public interface IuserServices
    {
        IQueryable<user> RetrieveAllUser();

        public List<user> GetDatabyid(int id);
    }
}
