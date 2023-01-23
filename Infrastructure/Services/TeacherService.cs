
using System.Diagnostics;
using Domain.Entities;
using Domain.Dtos;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services;

public class TeacherService
{

   private readonly DataContext _context;

    public TeacherService(DataContext context)
    {
        _context = context;
    }
    public  async Task<List<GetTeacherDto>> Get()
    {
        return await _context.teachers.Select(x=>new GetTeacherDto(x.TeacherId, x.Email,x.Password,x.Name,x.Sex,x.Address,x.Phone,x.DateOfJoin)).ToListAsync();
    }

 public async Task Add(AddTeacherDto x)
    {
        try
        {
            var mapped = new Teacher(x.TeacherId, x.Email,x.Password,x.Name,x.Sex,x.Address,x.Phone,x.DateOfJoin);
            await  _context.teachers.AddAsync(mapped);
            await _context.SaveChangesAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
        
    }

public async Task Update(AddTeacherDto c)
{
    try
    {
        var update = _context.teachers.Find(c.TeacherId);
        update.Email=c.Email;
        update.Password=c.Password;
        update.Name=c.Name;
        update.Sex=c.Sex;
        update.Address=c.Address;
        update.Phone=c.Phone;
        update.DateOfJoin=c.DateOfJoin;
 
        _context.teachers.Update(update);
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
        var entity=await _context.teachers.FindAsync(id);
         _context.Remove(entity);
       await  _context.SaveChangesAsync();
        return true;
      
    }


}


