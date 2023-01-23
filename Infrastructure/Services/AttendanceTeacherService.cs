using System.Diagnostics;
using Domain.Entities;
using Domain.Dtos;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services;

public class AttendanceTeacherService
{

   private readonly DataContext _context;

    public AttendanceTeacherService(DataContext context)
    {
        _context = context;
    }
    public  async Task<List<GetAttendanceTeacherDto>> Get()
    {
        return await _context.AttendanceTeachers.Select(x=>new GetAttendanceTeacherDto(x.AttendanceTeacherId,x.Status,x.TeacherId)).ToListAsync();
    }

 public async Task Add(AddAttendanceTeacherDto c)
    {
        try
        {
            var mapped = new AttendanceTeacher(c.AttendanceTeacherId, c.Status,c.TeacherId);
            await  _context.AttendanceTeachers.AddAsync(mapped);
            await _context.SaveChangesAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
       
    }

public async Task Update(AddAttendanceTeacherDto c)
{
    try
    {
        var update = _context.AttendanceTeachers.Find(c.AttendanceTeacherId);
        update.Status=c.Status;
        update.TeacherId=c.TeacherId;

        _context.AttendanceTeachers.Update(update);
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
        var entity=await _context.AttendanceTeachers.FindAsync(id);
         _context.Remove(entity);
       await  _context.SaveChangesAsync();
        return true;
      
    }


}



