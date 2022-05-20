// <copyright file="BaseUserAction.cs" company="One To One Relationship With Enumeration">
// Copyright (c) One To One Relationship With Enumeration. All rights reserved.
// </copyright>

namespace OneToOneRelationshipWithEnumeration.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class BaseUserAction
    {
        public BaseUserAction()
        {
        }

        [Key]
        [Required]
        public string Id { get; set; }

        public ActionType ActionType { get; set; }

        [Required]
        [ForeignKey(nameof(UserAction))]
        public string UserActionId { get; set; }

        public UserAction UserAction { get; set; }

        public string Comment { get; set; }
    }
}