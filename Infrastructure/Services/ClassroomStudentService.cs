using System.Diagnostics;
using Domain.Entities;
using Domain.Dtos;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services;

public class ClassroomStudentService
{

   private readonly DataContext _context;

    public ClassroomStudentService(DataContext context)
    {
        _context = context;
    }
    public  async Task<List<GetClassroomStudentDto>> Get()
    {
        return await _context.ClassromStudents.Select(x=>new GetClassroomStudentDto(x.StudentId, x.ClassroomId)).ToListAsync();
    }

 public async Task Add(AddClassroomStudentDto x)
 
    {
        try
        {
            var mapped = new ClassromStudent(x.StudentId,x.ClassroomId);
            await  _context.ClassromStudents.AddAsync(mapped);
            await _context.SaveChangesAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
        
    }

public async Task Update(AddClassroomStudentDto c)
{
    try
    {
        var update = _context.ClassromStudents.Find(c.StudentId);
 
        update.ClassroomId=c.ClassroomId;

        _context.ClassromStudents.Update(update);
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
        var entity=await _context.ClassromStudents.FindAsync(id);
         _context.Remove(entity);
       await  _context.SaveChangesAsync();
        return true;
      
    }


}

