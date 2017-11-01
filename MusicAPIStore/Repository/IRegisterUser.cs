using MusicAPIStore.Models;
using System;

namespace MusicAPIStore.Repository
{
    public interface IRegisterUser : IBaseRepository<RegisterUser>
    {
        bool ValidateUsername(RegisterUser registeruser);
        int GetLoggedUserID(RegisterUser registeruser);
    }
}
