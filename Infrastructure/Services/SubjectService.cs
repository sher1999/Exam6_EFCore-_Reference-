
using System.Diagnostics;
using Domain.Entities;
using Domain.Dtos;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services;

public class SubjectService
{

   private readonly DataContext _context;

    public SubjectService(DataContext context)
    {
        _context = context;
    }
    public  async Task<List<GetSubjectDto>> Get()
    {
        return await _context.subjects.Select(x=>new GetSubjectDto(x.SubjectId, x.Name,x.Grade,x.Description)).ToListAsync();
    }

 public async Task Add(AddSubjectDto x)
    {
        try
        {
            var mapped = new Subject(x.SubjectId, x.Name,x.Grade,x.Description);
            await  _context.subjects.AddAsync(mapped);
            await _context.SaveChangesAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
       
    }

public async Task Update(AddSubjectDto c)
{
    try
    {
        var update = _context.subjects.Find(c.SubjectId);
        update.Name=c.Name;
        update.Grade=c.Grade;
        update.Description = c.Description;
        _context.subjects.Update(update);
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
        var entity=await _context.subjects.FindAsync(id);
         _context.Remove(entity);
       await  _context.SaveChangesAsync();
        return true;
      
    }


}


