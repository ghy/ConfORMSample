﻿using System;
using System.Collections.Generic;
using ConfORMSample.Persistence.Entities.Contract;
using Iesi.Collections.Generic;

namespace ConfORMSample.Persistence.Entities
{
    public class User : EntityBase<Guid>, IUser
    {
        public virtual string UserName { get; set; }

        public virtual string Password { get; set; }

        public virtual Address Address { get; set; }

        public virtual ICollection<IPoll> Polls { get; set; }

        public User()
            : this(new HashedSet<IPoll>())
        {
        }

        public User(ICollection<IPoll> polls)
        {
            Polls = polls;
        }

        public virtual void AssignPoll(IPoll poll)
        {
            Polls.Add(poll);
        }
    }
}