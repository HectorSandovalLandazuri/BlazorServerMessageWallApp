using System.ComponentModel.DataAnnotations;

namespace BlazorServerMessageWall.Models;

public class NameModel
{
	[Required]
	[StringLength(maximumLength: 100, MinimumLength = 1)]
	public string FirstName { get; set; }

	[Required]
	[StringLength(maximumLength: 100, MinimumLength = 1)]
	public string LastName { get; set; }


}
