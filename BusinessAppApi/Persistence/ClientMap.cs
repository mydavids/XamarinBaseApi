﻿using BusinessApp.Models;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BusinessAppApi.Persistence
{
    public class ClientMap : ClassMap<Client>
    {
        public ClientMap()
        {
            Table("[Client]");
            Id(x => x.Id).GeneratedBy.Guid().Column("Id");
            Map(x => x.Email).Column("Email");
            Map(x => x.Password).Column("Password");
            Map(x => x.PhoneNumber).Column("PhoneNumber");
            Map(x => x.Name).Column("Name");
            Map(x => x.Surname).Column("Surname");
            Map(x => x.ClientAddressId).Column("ClientAddressId");
            Map(x => x.CreatedAt).Column("created_at");
            Map(x => x.ModifiedAt).Column("modified_at");

    }
    }
}