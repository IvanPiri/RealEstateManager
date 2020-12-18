﻿using RealEstateManager.Models.Data;
using RealEstateManager.Models.Estate;
using RealEstateManager.Repository;
using System;
using System.Linq;

namespace RealEstateManager.Utils
{
    public static class EstateAgentHelper
    {
        public static bool IsAgentAuthorized(CurrentIdentity currentIdentity, EstateGetModel estate)
        {
            return currentIdentity != null && estate.EstateAgents != null &&
                estate.EstateAgents.Any(x => x.EstateId == estate.Id && x.UserId == currentIdentity.Id);
        }

        public static bool isAdminAuthorized(CurrentIdentity currentIdentity)
        {
            return currentIdentity != null &&
                (currentIdentity.Type == UserType.Admin);
        }
    }
}