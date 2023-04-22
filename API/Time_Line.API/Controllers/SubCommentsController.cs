namespace Time_Line.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubCommentsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public SubCommentsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost("[action]")]
        public async Task<ActionResult<SubCommentCreateCommandResponse>> CreateSubComment([FromBody] SubCommentCreateCommand request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpDelete("[action]/{id}")]
        public async Task<ActionResult<SubCommentDeleteCommandResponse>> DeleteSubComment(string id)
        {
            var request = new SubCommentDeleteCommand(id);
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("[action]/{id}")]
        public async Task<ActionResult<GetSubCommentDetailQueryResponse>> GetSubCommentDetail(string id)
        {
            var request = new GetSubCommentDetailQuery(id);
            var response = await _mediator.Send(request);
            return Ok(response);
        }


        [HttpPut("[action]")]
        public async Task<ActionResult<SubCommentUpdateCommandResponse>> UpdatePost([FromBody] SubCommentUpdateCommand request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
