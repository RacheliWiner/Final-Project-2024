﻿using BL.DTO;
using BL.Implementation;
using BL;
using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ServerSide.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DrivesController : ControllerBase
    {
        DriveService driveService;
        public DrivesController(BLManeger blManeger)
        {
            this.driveService = blManeger.drive;
        }
        [HttpGet]
        public List<Drive> GetAllDrives()
        {
            return driveService.GetAllDrives();

        }
       
        [HttpPut("{email}")]
        public Drive UpdateDrive(int id, Drive drive)
        {
            return driveService.UpdateDrive(id, drive);
        }
        [HttpPost]
        public Drive AddDrive(Drive drive)
        {
            return driveService.AddDrive(drive) ;
        }
        [HttpDelete("{email}")]
        public bool DeleteDrive(int id)
        {
            return driveService.DeleteDrive(id);
        }
    }
}
