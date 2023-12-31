﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShopApi.DtoLayer.DTOs;
using TeaShopApi.EntityLayer.Concrete;

namespace TeaShopApi.BusinessLayer.Mapping.AutoMapper
{
    public class TeaShopMapping:Profile
    {
        public TeaShopMapping()
        {
            CreateMap<CreateDrinkDto,Drink>().ReverseMap();
            CreateMap<UpdateDrinkDto,Drink>().ReverseMap();
            CreateMap<CreateQuestionDto,Question>().ReverseMap();
            CreateMap<UpdateQuestionDto,Question>().ReverseMap();
            CreateMap<CreateAboutDto,About>().ReverseMap();
            CreateMap<UpdateAboutDto,About>().ReverseMap();
            CreateMap<CreateMessageDto,Message>().ReverseMap();
            CreateMap<UpdateMessageDto,Message>().ReverseMap();
            CreateMap<CreatePricingDto,Pricing>().ReverseMap();
            CreateMap<UpdatePricingDto,Pricing>().ReverseMap();
            CreateMap<CreateTestimonialDto,Testimonial>().ReverseMap();
            CreateMap<UpdateTestimonialDto,Testimonial>().ReverseMap();
        }
    }
}
