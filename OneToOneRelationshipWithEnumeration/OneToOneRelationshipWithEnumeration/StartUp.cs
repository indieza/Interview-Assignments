// <copyright file="StartUp.cs" company="One To One Relationship With Enumeration">
// Copyright (c) One To One Relationship With Enumeration. All rights reserved.
// </copyright>

namespace OneToOneRelationshipWithEnumeration
{
    using OneToOneRelationshipWithEnumeration.Data;
    using OneToOneRelationshipWithEnumeration.Models;

    public class StartUp
    {
        private static void Main()
        {
            var db = new MyDbContext();
            var userAction = new UserAction();

            db.UserActions.Add(new UserAction
            {
                Id = "812a5d77-f622-453a-9f7f-2be4b897a00e",
                BaseUserActionId = "406a325d-fcc9-4e42-9aa2-92f376aef80a",
                BaseUserAction = new FollowUserAction
                {
                    Id = "406a325d-fcc9-4e42-9aa2-92f376aef80a",
                    UserActionId = "812a5d77-f622-453a-9f7f-2be4b897a00e",
                    Comment = "ASDF",
                    FollowMessage = "Follow ASDF",
                },
                Description = "FDSA"
            });

            db.SaveChanges();
        }
    }
}