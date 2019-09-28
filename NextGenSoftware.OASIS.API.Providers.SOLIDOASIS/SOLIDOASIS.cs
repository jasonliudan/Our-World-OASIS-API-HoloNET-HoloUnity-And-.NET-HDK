﻿using Microsoft.AspNetCore.Mvc.RazorPages;
using NextGenSoftware.OASIS.API.Core;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NextGenSoftware.OASIS.API.Providers.SOLIDOASIS
{
    public class SOLIDOASIS : OASISProvider, IOASISStorage, IOASISNET
    {
        public event ProfileManager.StorageProviderError OnStorageProviderError;

        public SOLIDOASIS()
        {
            this.Name = "SOLIDOASIS";
            this.Description = "SOLID Provider";
            this.Type = ProviderType.SOLIDOASIS;
        }

        public Task<bool> AddKarmaToProfileAsync(IProfile profile, int karma)
        {
            throw new NotImplementedException();
        }

        public List<IHolon> GetHolonsNearMe(HolonType Type)
        {
            throw new NotImplementedException();
        }

        public List<IPlayer> GetPlayersNearMe()
        {
            throw new NotImplementedException();
        }

        public Task<IProfile> LoadProfileAsync(string providerKey)
        {
            //TODO: Call into JS SOLID Code here.
            //Page.ClientScript.RegisterStartupScript(this.GetType(), "CallMyFunction", "MyFunction()", true);

            return null;
        }

        public Task<IProfile> LoadProfileAsync(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<IProfile> LoadProfileAsync(string username, string password)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveKarmaFromProfileAsync(IProfile profile, int karma)
        {
            throw new NotImplementedException();
        }

        public Task<IProfile> SaveProfileAsync(IProfile profile)
        {
            throw new NotImplementedException();
        }

        public async override void ActivateProvider()
        {
            //TODO: Login/Connect to SOLID POD here.
            base.ActivateProvider();
        }

        public async override void DeActivateProvider()
        {
            //TODO: Logout of SOLID POD here.
            base.DeActivateProvider();
        }
    }
}
