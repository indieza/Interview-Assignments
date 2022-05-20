// <copyright file="FollowUserAction.cs" company="One To One Relationship With Enumeration">
// Copyright (c) One To One Relationship With Enumeration. All rights reserved.
// </copyright>

namespace OneToOneRelationshipWithEnumeration.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class FollowUserAction : BaseUserAction
    {
        public FollowUserAction()
        {
            this.ActionType = ActionType.Follow;
        }

        [Required]
        [MaxLength(20)]
        public string FollowMessage { get; set; }
    }
}