
using System.Diagnostics;
using Domain.Entities;
using Domain.Dtos;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services;

public class  TimeTableService
{

   private readonly DataContext _context;

    public  TimeTableService(DataContext context)
    {
        _context = context;
    }
    public  async Task<List<GetTimeTableDto>> Get()
    {
        return await _context.timeTables.Select(x=>new GetTimeTableDto(x.TTId, x.Day,x.Time,x.Subject)).ToListAsync();
    }

 public async Task Add(AddTimeTableDto x)
    {
        try
        {

            var mapped = new TimeTable(x.TTId, x.Day,x.Time,x.Subject);
            await  _context.timeTables.AddAsync(mapped);
            await _context.SaveChangesAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }

public async Task Update(AddTimeTableDto c)
{
    try
    {
        var update = _context.timeTables.Find(c.TTId);
        update.Day=c.Day;
        update.Time=c.Time;
        update.Subject=c.Subject;
        _context.timeTables.Update(update);
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
        var entity=await _context.timeTables.FindAsync(id);
         _context.Remove(entity);
       await  _context.SaveChangesAsync();
        return true;
      
    }


}







