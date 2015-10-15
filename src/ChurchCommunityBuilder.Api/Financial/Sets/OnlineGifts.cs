﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChurchCommunityBuilder.Api.Financial.Entity;
using ChurchCommunityBuilder.Api.Entity;

namespace ChurchCommunityBuilder.Api.Financial.Sets {
    public class OnlineGifts : BaseApiSet<OnlineGift> {
        public OnlineGifts(string baseUrl, string username, string password) : base(baseUrl, username, password) { }

        public bool Create(OnlineGift entity) {
            var result = this.Execute<Response>("online_giving_insert_gift", entity.GetFormDictionary());
            return result.Errors.Count == 0;
        }
    }
}
