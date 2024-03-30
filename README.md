This repository contains a custom attribute for ASP.NET Core applications named PermissionAuthorizeAttribute. This attribute extends the AuthorizeAttribute class and provides a way to authorize actions based on permissions and permission modes.

The PermissionAuthorizeAttribute allows specifying the required permissions and the mode of permission verification for authorized actions. It can be applied to controller actions or entire controller classes.

To use this attribute, simply decorate your controller actions or classes with [PermissionAuthorize] and provide the necessary permissions. By default, the attribute accepts an array of permissions and verifies them in "Any" mode.

Example usage:

```csharp
[HttpGet]
[PermissionAuthorize(permissions: [Permissions.Read, Permissions.Write], mode: PermissionMode.All)]
public IActionResult MyAction()
{
    // Action logic here
}
