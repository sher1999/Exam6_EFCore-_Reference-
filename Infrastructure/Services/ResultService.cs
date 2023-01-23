
using System.Diagnostics;
using Domain.Entities;
using Domain.Dtos;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services;

public class ResultService
{

   private readonly DataContext _context;

    public ResultService(DataContext context)
    {
        _context = context;
    }
    public  async Task<List<GetResultDto>> Get()
    {
        return await _context.results.Select(x=>new GetResultDto(x.ExamId, x.StudentId,x.SubjectId,x.Marks)).ToListAsync();
    }

 public async Task Add(AddResultDto x)
    {
        try
        {
            var mapped = new Result(x.ExamId, x.StudentId,x.SubjectId,x.Marks);
            await  _context.results.AddAsync(mapped);
            await _context.SaveChangesAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
       
    }

public async Task Update(AddResultDto c)
{
    try
    {
        var update = _context.results.Find(c.ExamId);
  
        update.StudentId=c.StudentId;
        update.SubjectId=c.SubjectId;
        update.Marks=c.Marks;
        _context.results.Update(update);
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
        var entity=await _context.results.FindAsync(id);
         _context.Remove(entity);
       await  _context.SaveChangesAsync();
        return true;
      
    }


}




