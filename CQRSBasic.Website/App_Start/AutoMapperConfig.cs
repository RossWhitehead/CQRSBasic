using AutoMapper;
using CQRS.QueryStack;
using CQRSBasic.CommandStack;

namespace CQRSBasic.Website
{
    public class AutoMapperConfig
    {
        public static void Initialize()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile<WebsiteMappingProfile>();
                cfg.AddProfile<CommandStackMappingProfile>();
                cfg.AddProfile<QueryStackMappingProfile>();
            });
        }
    }
}


