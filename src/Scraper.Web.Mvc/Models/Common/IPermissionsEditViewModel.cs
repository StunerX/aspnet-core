using System.Collections.Generic;
using Scraper.Roles.Dto;

namespace Scraper.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}