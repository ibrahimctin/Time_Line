global using Time_Line.Domain.Entities.DbModels.Identity;
global using Time_Line.Domain.Entities.DTOs.Identity.ResponseDtos;
global using Microsoft.AspNetCore.Identity;
global using Time_Line.Domain.Entities.DTOs.Identity.RequestDtos;
global using MediatR;
global using FluentValidation;
global using Time_Line.Domain.Application.Abstraction.Messaging;
global using ValidationException = Time_Line.Domain.Entities.ExceptionModels.Models.ValidationException;
global using Microsoft.Extensions.DependencyInjection;
global using System.Reflection;
global using Time_Line.Domain.Application.Behaviors;
global using Time_Line.Domain.Application.Abstraction.Identity;
global using Time_Line.Domain.Application.Features.Identity.Commands.Accounts.ChangeUsername; 
global using Microsoft.EntityFrameworkCore;
global using Time_Line.Domain.Entities.DbModels;
global using System.Linq.Expressions;
global using Time_Line.Domain.Entities.DTOs.Posts.RequestDtos;
global using AutoMapper;
global using Time_Line.Domain.Entities.DTOs.Posts.ResponseDtos;
global using Time_Line.Domain.Application.Features.Posts.Commands.CreatePost;
global using Time_Line.Domain.Application.Features.Posts.Queries.GetPostDetail;
global using Time_Line.Domain.Application.Features.Posts.Commands.UpdatePost;
global using Time_Line.Domain.Application.Features.Posts.Commands.DeletePost;
global using Time_Line.Domain.Application.Abstraction.Persistence.Services;


