//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.ComponentModel.DataAnnotations;

namespace TextTemplate.Models
{
    public partial class LoginPageModel
    {
        [Required(ErrorMessage = "UserName is required.")]
        public string UserName { get; set; }
        public string Password { get; set; }
        public string IsRememberMe { get; set; }
    }
}
