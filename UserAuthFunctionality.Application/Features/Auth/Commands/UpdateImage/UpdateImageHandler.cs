﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserAuthFunctionality.Application.Interfaces;
using UserAuthFunctionality.Core.Entities.Common;

namespace UserAuthFunctionality.Application.Features.Auth.Commands.UpdateImage
{
    public class UpdateImageHandler : IRequestHandler<UpdateImageCommand, Result<string>>
    {
        private readonly IAuthService _authService;

        public UpdateImageHandler(IAuthService authService)
        {
            _authService = authService;
        }
        public async Task<Result<string>> Handle(UpdateImageCommand request, CancellationToken cancellationToken)
        {
            return await _authService.UpdateImage(request.UserUpdateImageDto);
        }
    }
}