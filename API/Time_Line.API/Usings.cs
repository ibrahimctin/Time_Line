﻿global using QualificationExam.Identity.Configurators;
global using QualificationExam.Infrastructure.Identity.Configurators;
global using Time_Line.Infrastructure;
global using Microsoft.AspNetCore.Identity;
global using Time_Line.Domain.Application.Constants;
global using Time_Line.Domain.Entities.DbModels.Identity;
global using Time_Line.API;
global using System.Text.Json;
global using Time_Line.Domain.Entities.ExceptionModels.Models;
global using Time_Line.API.Middleware;
global using Time_Line.Domain.Application.Configurators;
global using MediatR;
global using Microsoft.AspNetCore.Authorization;
global using Microsoft.AspNetCore.Mvc;
global using Time_Line.Domain.Application.Features.Identity.Commands.Accounts.ChangeEmail;
global using Time_Line.Domain.Application.Features.Identity.Commands.Accounts.ChangePassword;
global using Time_Line.Domain.Application.Features.Identity.Commands.Accounts.ChangeUsername;
global using Time_Line.Domain.Application.Features.Identity.Commands.Accounts.Login;
global using Time_Line.Domain.Application.Features.Identity.Commands.Accounts.Register;
global using Time_Line.Domain.Application.Features.Identity.Commands.AppUsers.DeleteUser;
global using Time_Line.Domain.Entities.DTOs.Identity.RequestDtos;
global using Time_Line.Domain.Entities.DTOs.Identity.ResponseDtos;
global using Time_Line.Domain.Application.Abstraction.Identity;
global using Time_Line.Domain.Application.Features.Posts.Commands.CreatePost;
global using Time_Line.Domain.Application.Features.Posts.Commands.DeletePost;
global using Time_Line.Domain.Application.Features.Posts.Commands.UpdatePost;
global using Time_Line.Persistence;
global using Time_Line.Domain.Application.Features.Posts.Queries.GetPostDetail;
global using Time_Line.Domain.Application.Features.Comments.Commands.CreateComment;
global using Time_Line.Domain.Application.Features.Comments.Commands.DeleteComment;
global using Time_Line.Domain.Application.Features.Comments.Commands.UpdateComment;
global using Time_Line.Domain.Application.Features.Comments.Queries.GetCommentDetail;
global using Time_Line.Domain.Application.Features.Posts.Queries.GetPostCommentsList;
global using Time_Line.Domain.Application.Features.SubComments.Commands.CreateSubComment;
global using Time_Line.Domain.Application.Features.SubComments.Commands.DeleteSubComment;
global using Time_Line.Domain.Application.Features.SubComments.Commands.UpdateSubComment;
global using Time_Line.Domain.Application.Features.SubComments.Queries.GetSubCommentDetail;

