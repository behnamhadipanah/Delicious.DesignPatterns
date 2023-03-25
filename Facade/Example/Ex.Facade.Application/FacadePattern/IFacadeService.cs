﻿using Ex.Facade.Application.Services.LoginUser;
using Ex.Facade.Application.Services.RegisterUser;

namespace Ex.Facade.Application.FacadePattern;

public interface IFacadeService
{
    public ILoginUserService LoginUserService { get; }
    public IRegisterUserService RegisterUserService { get; }
}

public class FacadeService : IFacadeService
{
    private ILoginUserService _loginUserService;
    private IRegisterUserService _registerUserService;
    public ILoginUserService LoginUserService
    {
        get { return _loginUserService = _loginUserService ?? new LoginUserService(); }
    }
    public IRegisterUserService RegisterUserService
    {
        get { return _registerUserService = _registerUserService ?? new RegisterUserService(); }
    }
}
