using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Nuxiba.Services.Business;
using Nuxiba.Services.Entity;
using Nuxiba.Services.Entity.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NuxServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NuxibaController : Controller
    {
        private IConfiguration _configuration;
        private string _urlService;

        public NuxibaController(IConfiguration iconfig)
        {
            _configuration = iconfig;
            _urlService = _configuration.GetValue<string>("NuxibaServices:serviceUrl");
        }

        [HttpGet]
        [Route("GetUsers")]
        public IActionResult GetUsers()
        {
            try
            {
                return Ok(JsonConvert.SerializeObject(ProcessUser.ProcessGetUser(_urlService)));
            }
            catch (Exception ex)
            {
                ProcessLog.LogError(new LogError(ex), LogType.LogError, _urlService).GetAwaiter().GetResult();
                return StatusCode(500, JsonConvert.SerializeObject(ex.Message));
            }
        }

        [HttpGet]
        [Route("GetUserPost")]
        public IActionResult GetUserPost(string idUser)
        {
            try
            {
                return Ok(JsonConvert.SerializeObject(ProcessUser.ProcessGetUserPost(_urlService, idUser)));
            }
            catch (Exception ex)
            {
                ProcessLog.LogError(new LogError(ex), LogType.LogError, _urlService).GetAwaiter().GetResult();
                return StatusCode(500, JsonConvert.SerializeObject(ex.Message));
            }
        }
        [HttpGet]
        [Route("GetUserTasks")]
        public IActionResult GetUserTasks(string idUser)
        {
            try
            {
                return Ok(JsonConvert.SerializeObject(ProcessUser.ProcessGetUserTasks(_urlService, idUser)));
            }
            catch (Exception ex)
            {
                ProcessLog.LogError(new LogError(ex), LogType.LogError, _urlService).GetAwaiter().GetResult();
                return StatusCode(500, JsonConvert.SerializeObject(ex.Message));
            }
        }
        [HttpPost]
        [Route("SaveData")]
        public IActionResult SaveData(Nuxiba.Services.Entity.Task data)
        {
            try
            {
                return Ok(JsonConvert.SerializeObject(ProcessUser.ProcessSaveData(_urlService, data)));
            }
            catch (Exception ex)
            {
                ProcessLog.LogError(new LogError(ex), LogType.LogError, _urlService).GetAwaiter().GetResult();
                return StatusCode(500, JsonConvert.SerializeObject(ex.Message));
            }
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
