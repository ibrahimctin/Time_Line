namespace Time_Line.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PostsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost("[action]")]
        public async Task<ActionResult<PostCreateCommandResponse>> CreatePost([FromBody] PostCreateCommand request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpDelete("[action]/{id}")]
        public async Task<ActionResult<PostDeleteCommandResponse>> DeletePost(string id)
        {
            var request = new PostDeleteCommand(id);
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("[action]/{id}")]
        public async Task<ActionResult<GetPostDetailQueryResponse>> GetPostDetail(string id)
        {
            var request = new GetPostDetailQuery(id);
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("[action]/{id}")]
        public async Task<ActionResult<GetPostCommnetsListQueryResponse>> GetPostComments(string commentId)
        {
            var request = new GetPostCommnetsListQuery(commentId);
            var response = await _mediator.Send(request);
            return Ok(response);
        }


        [HttpPut("[action]")]
        public async Task<ActionResult<PostUpdateCommand>> UpdatePost([FromBody] PostUpdateCommand request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
