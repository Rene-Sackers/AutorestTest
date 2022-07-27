using System.Net;
using AutorestTest.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace AutorestTest.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class CalculateController : ControllerBase
{
	[HttpPost(Name = "Add")]
	[ProducesResponseType(typeof(AddResponseData), (int)HttpStatusCode.OK)]
	public AddResponseData Add([FromBody] AddRequestData data)
	{
		return new()
		{
			Sum = data.Value1 + data.Value2
		};
	}
}
