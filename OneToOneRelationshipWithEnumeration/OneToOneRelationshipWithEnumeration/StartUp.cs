// <copyright file="StartUp.cs" company="One To One Relationship With Enumeration">
// Copyright (c) One To One Relationship With Enumeration. All rights reserved.
// </copyright>

namespace OneToOneRelationshipWithEnumeration
{
    using Microsoft.EntityFrameworkCore;

    using OneToOneRelationshipWithEnumeration.Data;
    using OneToOneRelationshipWithEnumeration.Models;

    public class StartUp
    {
        private static void Main()
        {
            var db = new MyDbContext();

            var actionId = Guid.NewGuid().ToString();
            var baseActionId = Guid.NewGuid().ToString();

            db.UserActions.Add(new UserAction
            {
                Id = actionId,
                BaseUserActionId = baseActionId,
                BaseUserAction = new FollowUserAction
                {
                    UserActionId = actionId,
                    Comment = "ASDF",
                    FollowMessage = "Follow ASDF",
                },
                Description = "FDSA",
            });

            db.SaveChanges();

            var item = db.UserActions
                .Include(x => x.BaseUserAction)
                .AsSingleQuery()
                .Where(x => x.BaseUserAction.ActionType == ActionType.Follow)
                .ToList();
            Console.WriteLine(string.Join(", ", item.Select(x => x.Id).ToList()));
        }
    }
}