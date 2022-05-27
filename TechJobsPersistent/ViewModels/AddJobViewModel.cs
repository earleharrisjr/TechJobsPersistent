using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddJobViewModel
    {
        [Required(ErrorMessage ="Job Name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Skill is required")]
        public string[] selectedSkills { get; set; }
        public List<Skill> Skills { get; set; }
        public int JobId { get; set; }
        public int EmployerId { get; set; }
        public List<SelectListItem> Employers { get; set; }


        public AddJobViewModel(List<Employer> newEmployers, List<Skill> newSkill)
        {
            Employers = new List<SelectListItem>();
            Skills = newSkill;


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

