﻿using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Entities;

public class UserEntity : IdentityUser
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string? ProfileImage { get; set; } = "avatar.svg";
    public string? ProfileBio {  get; set; }

    public int? AddressId { get; set; }
    public AddressEntity? Address { get; set; }
}

