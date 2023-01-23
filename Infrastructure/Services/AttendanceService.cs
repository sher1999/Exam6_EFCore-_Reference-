using System.Diagnostics;
using Domain.Entities;
using Domain.Dtos;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services;

public class AttendanceService
{

   private readonly DataContext _context;

    public AttendanceService(DataContext context)
    {
        _context = context;
    }
    public  async Task<List<GetAttendanceDto>> Get()
    {
        return await  _context.AttendanceStudents.Select(x=>new GetAttendanceDto(x.AttendanceStudentId,x.Status,x.StudentId)).ToListAsync();
    }

 public async Task Add(AddAttendanceDto c)
    {
        try
        {
            var mapped = new AttendanceStudent(c.AttendanceStudentId, c.Status,c.StudentId);
            await  _context.AttendanceStudents.AddAsync(mapped);
            await _context.SaveChangesAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
        
    }

public async Task Update(AddAttendanceDto c)
{

    try
    {
        var update = _context.AttendanceStudents.Find(c.AttendanceStudentId);
        update.Status=c.Status;
        update.StudentId=c.StudentId;

        _context.AttendanceStudents.Update(update);
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
        var entity=await _context.AttendanceStudents.FindAsync(id);
         _context.Remove(entity);
       await  _context.SaveChangesAsync();
        return true;
      
    }


}

