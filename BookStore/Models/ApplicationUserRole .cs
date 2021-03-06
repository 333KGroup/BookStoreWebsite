﻿using Microsoft.AspNet.Identity.EntityFramework;

namespace BookStore.Models {
    public class ApplicationUserRole : IdentityUserRole {
        public ApplicationUserRole()
            : base() { }

        public ApplicationRole Role { get; set; }
    }
}