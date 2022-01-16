using Abp.Application.Services.Dto;

namespace BoilerPlateMvc.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

