using System.Diagnostics;
using Domain.Entities;
using Domain.Dtos;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services;

public class ExamService
{

   private readonly DataContext _context;

    public ExamService(DataContext context)
    {
        _context = context;
    }
    public  async Task<List<GetExamDto>> Get()
    {
        return await _context.exams.Select(x=>new GetExamDto(x.ExamId, x.Name,x.Type)).ToListAsync();
    }

 public async Task Add(AddExamDto x)
    {
        try
        {
            var mapped = new Exam(x.ExamId,x.Name,x.Type);
            await  _context.exams.AddAsync(mapped);
            await _context.SaveChangesAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
        
    }

public async Task Update(AddExamDto c)
{
    try
    {
        var update = _context.exams.Find(c.ExamId);
 
        update.Name=c.Name;
        update.Type=c.Type;
        _context.exams.Update(update);
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
        var entity=await _context.exams.FindAsync(id);
         _context.Remove(entity);
       await  _context.SaveChangesAsync();
        return true;
      
    }


}

