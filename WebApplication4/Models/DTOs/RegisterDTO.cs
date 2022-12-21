using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebApplication4.Models.EFModels;

namespace WebApplication4.Models.DTOs
{
    public class RegisterDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }

       
        public string Email { get; set; }

        public DateTime CreateTime { get; set; }
    }
    public static class RegistersExtensions {
        public static RegisterDTO EntityToDTO(this Register source) {
            return new RegisterDTO
            {
                Id = source.id,
                Name = source.Name,
                Email = source.Email,
                CreateTime = (DateTime)source.CreateTime

            };




        }
    }


}