
using System.Diagnostics;
using Domain.Entities;
using Domain.Dtos;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services;

public class IssuesService
{

   private readonly DataContext _context;

    public IssuesService(DataContext context)
    {
        _context = context;
    }
    public  async Task<List<GetIssuesDto>> Get()
    {
        return await _context.issues.Select(x=>new GetIssuesDto(x.IssueId, x.Type,x.Details,x.IsResolved,x.StudentId)).ToListAsync();
    }

 public async Task Add(AddIssuesDto x)
    {
        try
        {
            var mapped = new Issues(x.IssueId, x.Type,x.Details,x.IsResolved,x.StudentId);
            await  _context.issues.AddAsync(mapped);
            await _context.SaveChangesAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
       
    }

public async Task Update(AddIssuesDto c)
{

    try
    {
        var update = _context.issues.Find(c.IssueId);

        update.Type=c.Type;
        update.Details=c.Details;
        update.IsResolved=c.IsResolved;
        update.StudentId=c.StudentId;
        _context.issues.Update(update);
        await _context.SaveChangesAsync();
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
        throw;
    }
  
}


 public async Task<bool>  Delete(int id)
    {
        var entity=await _context.issues.FindAsync(id);
         _context.Remove(entity);
       await  _context.SaveChangesAsync();
        return true;
      
    }


}
















