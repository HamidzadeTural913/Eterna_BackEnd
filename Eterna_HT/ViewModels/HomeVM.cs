using Eterna_HT.Models;
using System.Collections.Generic;

namespace Eterna_HT.ViewModels
{
    public class HomeVM
    {
        public List<Box> Boxs { get; set; }
        public Skill Skills { get; set; }
        public List<Progress> Progresses { get; set; }
        public List<SocialContact> SocialContacts { get; set; }
    }
}