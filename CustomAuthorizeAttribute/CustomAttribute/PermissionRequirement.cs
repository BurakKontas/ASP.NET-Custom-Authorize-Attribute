﻿using Microsoft.AspNetCore.Authorization;

namespace CustomAuthorizeAttribute.CustomAttribute;

public class PermissionRequirement(Permissions[] permission, PermissionMode mode) : IAuthorizationRequirement
{
    public PermissionMode Mode { get; } = mode;
    public Permissions[] Permissions { get; } = permission;
}