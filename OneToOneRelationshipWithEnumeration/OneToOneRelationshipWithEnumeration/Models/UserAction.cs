// <copyright file="UserAction.cs" company="One To One Relationship With Enumeration">
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

    public class UserAction
    {
        public UserAction()
        {
        }

        [Key]
        [Required]
        public string Id { get; set; }

        [Required]
        [ForeignKey(nameof(BaseUserAction))]
        public string BaseUserActionId { get; set; }

        public BaseUserAction BaseUserAction { get; set; }

        [MaxLength(150)]
        public string Description { get; set; }
    }
}