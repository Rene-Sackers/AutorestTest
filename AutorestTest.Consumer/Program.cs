using System.Diagnostics;
using AutorestTest.Client;

var client = new AutorestTestApiClient(new ("https://localhost:7164"), new());
// or just `AddResponseData result = ...`
Result<AddResponseData> result = await client.AddAsync(new AddRequestData()
{
	Value1 = 1,
	Value2 = 2
});
Debug.Assert(result.Value.Sum == 3);