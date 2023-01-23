using System.Diagnostics;
using Domain.Entities;
using Domain.Dtos;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services;

public class ClassroomService
{

   private readonly DataContext _context;

    public ClassroomService(DataContext context)
    {
        _context = context;
    }
    public  async Task<List<GetClassroomDto>> Get()
    {
        return await _context.classrooms.Select(x=>new GetClassroomDto(x.ClassroomId,x.Section,x.Grade,x.TeacherId)).ToListAsync();
    }

 public async Task Add(AddClassroomDto x)
    {
        try
        {
            var mapped = new Classroom(x.ClassroomID,x.Section,x.Grade,x.TeacherId);
            await  _context.classrooms.AddAsync(mapped);
            await _context.SaveChangesAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
      
    }

public async Task Update(AddClassroomDto c)
{

    try
    {
        var update = _context.classrooms.Find(c.ClassroomID);
        update.Section=c.Section;
        update.Grade=c.Grade;
        update.TeacherId=c.TeacherId;
        _context.classrooms.Update(update);
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
        var entity=await _context.classrooms.FindAsync(id);
         _context.Remove(entity);
       await  _context.SaveChangesAsync();
        return true;
      
    }


}

