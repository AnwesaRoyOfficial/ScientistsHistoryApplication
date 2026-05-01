using API.Data;
using API.Entities;
<<<<<<< HEAD
using API.Interfaces;
=======
>>>>>>> fb7632f2213c77f519721db927098cea7144822b
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
<<<<<<< HEAD
    [Authorize]
    public class MembersController(IMemberRepository memberRepository) : BaseApiController{
        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<Member>>> GetMembers()
        {
            return Ok(await memberRepository.GetMemberAsync());
=======
    
    public class MembersController(AppDbContext context) : BaseApiController{
        [HttpGet]
        public async Task<IReadOnlyList<AppUser>> GetMembers()
        {
            var members = await context.Users.ToListAsync();

            return members;
>>>>>>> fb7632f2213c77f519721db927098cea7144822b
        }

        [Authorize]
        [HttpGet("{id}")] // localhost:5001/api/members/bob-id

<<<<<<< HEAD
        public async Task<ActionResult<Member>> GetMember(String id)
        {
            var member = await memberRepository.GetMemberByIdAsync(id);
=======
        public async Task<ActionResult<AppUser>> GetMember(String id)
        {
            var member = await context.Users.FindAsync(id);
>>>>>>> fb7632f2213c77f519721db927098cea7144822b

            if(member == null) return NotFound();

            return member;
        }
<<<<<<< HEAD

        [HttpGet("{id}/photos")]
        public async Task<ActionResult<IReadOnlyList<Photo>>> GetMemberPhotos(string id)
        {
            return Ok(await memberRepository.GetPhotosForMemberAsync(id));
        }

=======
>>>>>>> fb7632f2213c77f519721db927098cea7144822b
    }
}
