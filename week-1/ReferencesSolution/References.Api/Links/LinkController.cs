using System.Diagnostics.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace References.Api.Links;
public class LinkController : ControllerBase
{
    //some code here that will get called when a get /links is sent to the server

    [HttpGet("/links")]
    public async Task<ActionResult> GetAllLinksAsync(CancellationToken token) {
        return Ok();
    }

}
