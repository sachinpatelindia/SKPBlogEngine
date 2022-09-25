using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using SKPBlogEngine.Base.Domain.Members;
using SKPBlogEngine.Web.Controllers;
using SKPBlogEngine.Web.System;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SKPBlogEngine.Web.API
{
    [Route("api/[controller]")]
    [EnableCors("corsapp")]
    [ApiController]
    public class MembersController : ControllerBase
    {
        private readonly IRepository<Member> _memberRepository;
        public MembersController(IRepository<Member> memberRepository)
        {
            _memberRepository = memberRepository;
        }
        // GET: api/<MembersController>
        [HttpGet]
        [Authorize]
        public IEnumerable<Member> Get()
        {
            return GetMembers();
        }

        // GET api/<MembersController>/5
        [HttpGet("{id}")]
        public Member Get(int? id)
        {
            var member = GetMembers()?.FirstOrDefault<Member>(m => m?.Id == id);
            return member;
        }

        // POST api/<MembersController>
        [HttpPost]
        public void Post([FromBody] Member member)
        {
            if(member != null)
            {
                _memberRepository.Insert(member);
            }
              
        }

        // PUT api/<MembersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MembersController>/5
        [HttpDelete("{id}")]
        public void Delete(int? id)
        {
            if(id != null)
            {
                var member = _memberRepository.GetById(id);
                if (member != null)
                    _memberRepository.Delete(member);
            }
        }

        private ICollection<Member> GetMembers()
        {
            var members = _memberRepository.Table.ToList();
            return members;
        }
    }
}
