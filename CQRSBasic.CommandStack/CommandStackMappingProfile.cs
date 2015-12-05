using AutoMapper;
using CQRSBasic.CommandStack.Commands;
using CQRSBasic.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSBasic.CommandStack
{
    public class CommandStackMappingProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<AddOrEditProductCategoryCommand, ProductCategory>();
            base.Configure();
        }
    }
}
