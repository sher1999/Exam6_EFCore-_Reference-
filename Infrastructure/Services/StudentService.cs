
using System.Diagnostics;
using Domain.Entities;
using Domain.Dtos;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services;

public class StudentService
{

   private readonly DataContext _context;

    public StudentService(DataContext context)
    {
        _context = context;
    }
    public  async Task<List<GetStudentDto>> Get()
    {
        return await _context.students.Select(x=>new GetStudentDto(x.StudentId, x.Email,x.Password,x.Name,x.Sex,x.Address,x.Phone,x.DateOfJoin,x.ParentName)).ToListAsync();
    }

 public async Task Add(AddStudentDto x)
    {
        try
        {
            var mapped = new Student(x.StudentId, x.Email,x.Password,x.Name,x.Sex,x.Address,x.Phone,x.DateOfJoin,x.ParentName);
            await  _context.students.AddAsync(mapped);
            await _context.SaveChangesAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
      
    }

public async Task Update(AddStudentDto c)
{
    try
    {
        var update = _context.students.Find(c.StudentId);
        update.Email=c.Email;
        update.Password=c.Password;
        update.Name=c.Name;
        update.Sex=c.Sex;
        update.Address=c.Address;
        update.Phone=c.Phone;
        update.DateOfJoin=c.DateOfJoin;
        update.ParentName=c.ParentName;
        _context.students.Update(update);
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








