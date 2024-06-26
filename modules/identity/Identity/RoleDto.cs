﻿namespace Light.Identity;

public class RoleDto
{
    public string Id { get; set; } = null!;

    public string? Name { get; set; }

    public string? Description { get; set; }

    public IEnumerable<ClaimDto> Claims { get; set; } = new List<ClaimDto>();
}
