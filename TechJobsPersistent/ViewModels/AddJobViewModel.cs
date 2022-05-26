﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddJobViewModel
    {
        [Required(ErrorMessage ="Job Name is required")]
        public string Name { get; set; }
        public int JobId { get; set; }
        public int EmployerId { get; set; }
        public List<SelectListItem> Employers { get; set; }


        public AddJobViewModel(List<Employer> newEmployers)
        {
            Employers = new List<SelectListItem>();
            

            foreach (var employer in newEmployers)
            {
                Employers.Add(new SelectListItem
                {
                    Value = employer.Id.ToString(),
                    Text = employer.Name
                });
            }
        }
        public AddJobViewModel() { }
    }
}

