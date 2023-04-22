
namespace Time_Line.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CommentsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost("[action]")]
        public async Task<ActionResult<CommentCreateCommandResponse>> CreateComment([FromBody] CommentCreateCommand request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpDelete("[action]/{id}")]
        public async Task<ActionResult<CommentDeleteCommandResponse>> DeleteComment(string id)
        {
            var request = new CommentDeleteCommand(id);
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("[action]/{id}")]
        public async Task<ActionResult<GetCommentDetailQueryResponse>> GetCommentDetail(string id)
        {
            var request = new GetCommentDetailQuery(id);
            var response = await _mediator.Send(request);
            return Ok(response);
        }


        [HttpPut("[action]")]
        public async Task<ActionResult<CommentUpdateCommandResponse>> UpdatePost([FromBody] CommentUpdateCommand request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("[action]")]
        public async Task<ActionResult<GetCommentSubCommetsListQueryResponse>> GetCommentSubCommnents(string commentId)
        {
            var request = new GetCommentSubCommetsListQuery(commentId);
            var response = await _mediator.Send(request);
            return Ok(response);
        }

    }
}
