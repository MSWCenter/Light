﻿using System.Linq.Expressions;

namespace Light.Identity.EntityFrameworkCore.Extensions;

public static class DataMapper
{
    public static IQueryable<UserDto> MapToDto(this IQueryable<User> query)
    {
        Expression<Func<User, UserDto>> selectExp = s => new UserDto
        {
            Id = s.Id,
            UserName = s.UserName,
            FirstName = s.FirstName,
            LastName = s.LastName,
            Email = s.Email,
            PhoneNumber = s.PhoneNumber,
            UseDomainPassword = s.UseDomainPassword,
            Status = s.Status.Value,
            IsDeleted = s.IsDeleted,
        };

        return query.Select(selectExp);
    }

    public static UserDto MapToDto(this User user)
    {
        var dto = new UserDto
        {
            Id = user.Id,
            UserName = user.UserName,
            FirstName = user.FirstName,
            LastName = user.LastName,
            Email = user.Email,
            PhoneNumber = user.PhoneNumber,
            UseDomainPassword = user.UseDomainPassword,
            Status = user.Status.Value,
            IsDeleted = user.IsDeleted,
        };

        return dto;
    }

    public static IQueryable<RoleDto> MapToDto(this IQueryable<Role> query)
    {
        Expression<Func<Role, RoleDto>> selectExp = s => new RoleDto
        {
            Id = s.Id,
            Name = s.Name,
            Description = s.Description,
        };

        return query.Select(selectExp);
    }

    public static RoleDto MapToDto(this Role role)
    {
        var dto = new RoleDto
        {
            Id = role.Id,
            Name = role.Name,
            Description = role.Description,
        };

        return dto;
    }
}
