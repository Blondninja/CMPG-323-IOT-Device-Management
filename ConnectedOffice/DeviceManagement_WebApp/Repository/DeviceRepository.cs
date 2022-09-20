using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeviceManagement_WebApp.Repository
{
    public class DeviceRepository
    {
        private readonly ConnectedOfficeContext _context;

        // GET: Categories
        public List<Device> GetAll()
        {
            return _context.Device.ToList();
        }

        // GET: Categories/Details/5
        public async Task<Device> GetById(Guid? id)
        {


            var device = await _context.Device
                .FirstOrDefaultAsync(m => m.DeviceId == id);


            return (device);
        }
    }
}
