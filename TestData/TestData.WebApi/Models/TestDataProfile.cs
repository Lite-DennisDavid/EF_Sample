using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestData.Entities;

namespace TestData.WebApi.Models
{
    public class TestDataProfile : Profile
    {
        public TestDataProfile()
        {
            CreateMap<TestDataL1, TestDataL1Model>();
        }
    }
}
