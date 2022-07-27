using System.Diagnostics;
using AutorestTest.Client;

var client = new AutorestTestApiClient(new (""), new());
Result<AddResponseData> result = await client.AddAsync(new AddRequestData()
{
	Value1 = 1,
	Value2 = 2
});
Debug.Assert(result.Value == 3);