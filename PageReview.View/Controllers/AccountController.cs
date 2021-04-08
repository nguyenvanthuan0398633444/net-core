using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using PageReview.View.Models;
using PageReview.View.Models.Account;
using PageReview.View.Ultilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PageReview.View.Controllers
{
    public class AccountController : Controller
    {
        private readonly IConfiguration configuration;
        private readonly IWebHostEnvironment webHost;

        public AccountController(IConfiguration configuration,
                                    IWebHostEnvironment webHost)
        {
            this.configuration = configuration;
            this.webHost = webHost;
        }
        [Authorize]
        public IActionResult Index()
        {
            var data = ApiHelper<List<ApplicationUser>>.HttpGetAsync($"User/Gets");
            return View(data);
        }
        public IActionResult Gets()
        {
            var data = ApiHelper<List<ApplicationUser>>.HttpGetAsync($"User/Gets");
            return Ok(data);
        }
        public IActionResult GetsAdmin()
        {
            var data = ApiHelper<List<GetUserIdRoleId>>.HttpGetAsync($"User/GetsAdmin");
            return Ok(data);
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Register registerRequest)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var account = new RegisterView()
            {
                Address = registerRequest.Address,
                Company = registerRequest.Company,
                ConfirmPassword = registerRequest.ConfirmPassword,
                DoB = registerRequest.DoB.ToString(),
                Email = registerRequest.Email,
                FullName = registerRequest.FullName,
                Gender = registerRequest.Gender,
                Password = registerRequest.Password,
                PhoneNumber = registerRequest.PhoneNumber,
                UserName = registerRequest.UserName
            };
            string FileImage = null;
            if (registerRequest.ImagePath != null)
            {
                string uploadsFolder = Path.Combine(webHost.WebRootPath, "images/Avatar");
                FileImage = Guid.NewGuid().ToString() + "_" + registerRequest.ImagePath.FileName;
                string filePath = Path.Combine(uploadsFolder, FileImage);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    registerRequest.ImagePath.CopyTo(fileStream);
                }
            }
            account.ImagePath = FileImage;

            var result = ApiHelper<Result>.HttpPostAsync($"User/register","post", account);
            
            ViewBag.Message = result.Message;
            if (result.Message == "Register is successful!")
            {
                ViewBag.Message = result.Message;
                //ModelState.AddModelError("", result.Message);
                return RedirectToAction("Login", "Account");
            }
            return View(registerRequest);
        }

        public async Task<IActionResult> Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginRequest request)
        {
            if (!ModelState.IsValid)
                return View(ModelState);
            var result = ApiHelper<Result>.HttpPostAsync($"User/authenticate", "post", request);
            var userids = ApiHelper<List<GetUserIdRoleId>>.HttpGetAsync($"User/GetsAdmin");
            var user = ApiHelper<ApplicationUser>.HttpGetAsync($"User/GetInfo/{request.UserName}");
            if (user.UserName != null)
            {
                await HttpContext.AuthenticateAsync(CookieAuthenticationDefaults.AuthenticationScheme);

                var claims = new List<Claim>
                    {
                    new Claim(ClaimTypes.Name, request.UserName),
                    };
                foreach (var item in userids)
                {
                    if (item.UserId == user.Id)
                    {
                        claims = new List<Claim>
                    {
                    new Claim(ClaimTypes.Name, request.UserName),
                    new Claim(ClaimTypes.Role, "Admin"),
                    };
                        break;
                    }
                }

                var claimsIdentity = new ClaimsIdentity(
                    claims, CookieAuthenticationDefaults.AuthenticationScheme);

                var authProperties = new AuthenticationProperties
                {
                    //AllowRefresh = <bool>,
                    // Refreshing the authentication session should be allowed.

                    //ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(10),
                    // The time at which the authentication ticket expires. A 
                    // value set here overrides the ExpireTimeSpan option of 
                    // CookieAuthenticationOptions set with AddCookie.

                    //IsPersistent = true,
                    // Whether the authentication session is persisted across 
                    // multiple requests. When used with cookies, controls
                    // whether the cookie's lifetime is absolute (matching the
                    // lifetime of the authentication ticket) or session-based.

                    //IssuedUtc = <DateTimeOffset>,
                    // The time at which the authentication ticket was issued.

                    //RedirectUri = <string>
                    // The full path or absolute URI to be used as an http 
                    // redirect response value.
                };

                await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity),
                    authProperties);

            }
            ViewBag.Message = result.Message;

            if (result.Message == "Login Success")
            {
                HttpContext.Session.SetString("Id", user.Id);
                HttpContext.Session.SetString("UserName", user.UserName);
                HttpContext.Session.SetString("ImagePath", user.ImagePath);
                return RedirectToAction("", "UI");
            }

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> LoginOk(LoginRequest request)
        {
            if (!ModelState.IsValid)
                return View(ModelState);
            var result = ApiHelper<Result>.HttpPostAsync($"User/authenticate", "post", request);
            var userids = ApiHelper<List<GetUserIdRoleId>>.HttpGetAsync($"User/GetsAdmin");
            var user = ApiHelper<ApplicationUser>.HttpGetAsync($"User/GetInfo/{request.UserName}");
            if (user.UserName != null)
            {
                await HttpContext.AuthenticateAsync(CookieAuthenticationDefaults.AuthenticationScheme);

                var claims = new List<Claim>
                    {
                    new Claim(ClaimTypes.Name, request.UserName),
                    };
                foreach (var item in userids)
                {
                    if (item.UserId == user.Id)
                    {
                        claims = new List<Claim>
                    {
                    new Claim(ClaimTypes.Name, request.UserName),
                    new Claim(ClaimTypes.Role, "Admin"),
                    };
                        break;
                    }
                }

                var claimsIdentity = new ClaimsIdentity(
                    claims, CookieAuthenticationDefaults.AuthenticationScheme);

                var authProperties = new AuthenticationProperties
                {
                    //AllowRefresh = <bool>,
                    // Refreshing the authentication session should be allowed.

                    //ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(10),
                    // The time at which the authentication ticket expires. A 
                    // value set here overrides the ExpireTimeSpan option of 
                    // CookieAuthenticationOptions set with AddCookie.

                    //IsPersistent = true,
                    // Whether the authentication session is persisted across 
                    // multiple requests. When used with cookies, controls
                    // whether the cookie's lifetime is absolute (matching the
                    // lifetime of the authentication ticket) or session-based.

                    //IssuedUtc = <DateTimeOffset>,
                    // The time at which the authentication ticket was issued.

                    //RedirectUri = <string>
                    // The full path or absolute URI to be used as an http 
                    // redirect response value.
                };

                await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity),
                    authProperties);

            }

            ViewBag.Message = result.Message;
            if (result.Message == "Login Success")
            {
                ViewBag.Message = result.Message;

                HttpContext.Session.SetString("Id", user.Id);
                HttpContext.Session.SetString("UserName", user.UserName);
                HttpContext.Session.SetString("ImagePath", user.ImagePath);
                return Ok("Login Success");
            }

            return Ok("Username or password is incorrect.");
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("Id");
            HttpContext.Session.Remove("UserName");
            HttpContext.Session.Remove("ImagePath");
            ApiHelper<Result>.HttpPostAsync($"User/Logout", "post", null);
            return RedirectToAction("Login", "Account");
        }
        [Authorize(Roles ="Admin")]
        public IActionResult ChangeStatus(string Id)
        {
            var tam = ApiHelper<Result>.HttpPostAsync($"User/ChangeStatus/{Id}", "post", null);

            return RedirectToAction("", "Account");
        }
        [Authorize(Roles = "Admin")]
        public IActionResult AddRole(string Id)
        {
            
            var tam = ApiHelper<Result>.HttpPostAsync($"User/AddRole/{Id}", "post", null);

            return RedirectToAction("", "Account");
        }
        [Authorize(Roles = "Admin")]
        public IActionResult AddRole1(string Id)
        {
            
            var tam = ApiHelper<Result>.HttpPostAsync($"User/AddRole/{Id}", "post", null);

            return Ok(tam);
        }

        [HttpGet("account/update/{userId}")]
        public IActionResult Update(string userId)
        {
            var game = ApiHelper<RegisterView>.HttpGetAsync($"User/get/{userId}");
            ViewBag.avatar = game.ImagePath;
            var account = new UpdateUser() {
                Address = game.Address,
                Company = game.Company,
                DoB = game.DoB.ToString(),
                Email = game.Email,
                FullName = game.FullName,
                Gender = game.Gender,
                PhoneNumber = game.PhoneNumber,
                UserName = game.UserName
            };
            return View(account);
        }
        [HttpGet("account/Detail/{userId}")]
        public IActionResult Detail(string userId)
        {
            var game = ApiHelper<RegisterView>.HttpGetAsync($"User/get/{userId}");
            ViewBag.avatar = game.ImagePath;
            var account = new UpdateUser() {
                Address = game.Address,
                Company = game.Company,
                DoB = game.DoB.ToString(),
                Email = game.Email,
                FullName = game.FullName,
                Gender = game.Gender,
                PhoneNumber = game.PhoneNumber,
                UserName = game.UserName
            };
            return View(account);
        }
        [HttpGet("account/Details/{userId}")]
        public IActionResult Details(string userId)
        {
            var game = ApiHelper<RegisterView>.HttpGetAsync($"User/get/{userId}");
            ViewBag.avatar = game.ImagePath;
            var account = new UpdateUser() {
                Address = game.Address,
                Company = game.Company,
                DoB = game.DoB.ToString(),
                Email = game.Email,
                FullName = game.FullName,
                Gender = game.Gender,
                UserName = game.UserName
            };
            return View(account);
        }
        [HttpGet("account/changePass/{id}")]
        [Authorize]
        public IActionResult ChangePass(string id)
        {
            var user = ApiHelper<RegisterView>.HttpGetAsync($"User/get/{id}");
            var account = new Password
            {
                username = user.UserName
            };
            return View(account);
        }
        [Authorize]
        [HttpPost]
        public IActionResult ChangePass(Password password)
        {
            var result = ApiHelper<Result>.HttpPostAsync($"User/changepassword", "PUT", password);
            ViewBag.Id = result.Id;
            ViewBag.Message = result.Message;
            return View();
        
        }
        [HttpGet("account/resetPass/{id}")]
        [Authorize(Roles = "Admin")]
        public IActionResult resetPass(string id)
        {
            var account = new Resetpass
            {
                Id = id
            };
            return View(account);
        }
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult resetPass(Resetpass pass)
        {
            var result = ApiHelper<Result>.HttpPostAsync($"User/ResetPass", "POST", pass);
            ViewBag.Id = result.Id;
            ViewBag.Message = result.Message;
            return View();
        }

        [HttpPost]
        [Authorize]
        public IActionResult Update(UpdateUser registerRequest)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var account = new RegisterView()
            {
                Address = registerRequest.Address,
                Company = registerRequest.Company,
                DoB = registerRequest.DoB,
                Email = registerRequest.Email,
                FullName = registerRequest.FullName,
                Gender = registerRequest.Gender,
                PhoneNumber = registerRequest.PhoneNumber,
                UserName = registerRequest.UserName
            };
            string FileImage = null;
            var user = ApiHelper<ApplicationUser>.HttpGetAsync($"User/GetInfo/{account.UserName}");
            if (registerRequest.ImagePath != null)
            {
                string uploadsFolder = Path.Combine(webHost.WebRootPath, "images/Avatar");
                if (global::System.IO.File.Exists(Path.Combine(uploadsFolder, user.ImagePath)))
                {
                    // If file found, delete it    
                    global::System.IO.File.Delete(Path.Combine(uploadsFolder, user.ImagePath));
                }
                FileImage = Guid.NewGuid().ToString() + "_" + registerRequest.ImagePath.FileName;
                string filePath = Path.Combine(uploadsFolder, FileImage);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    registerRequest.ImagePath.CopyTo(fileStream);
                }
            }
            account.ImagePath = FileImage;

            var result = ApiHelper<Result>.HttpPostAsync($"User/update", "post", account);

            ViewBag.avatar = account.ImagePath;
            ViewBag.Message = result.Message;
            if (result.Message == "Update is successful!")
            {
                HttpContext.Session.Remove("ImagePath");
                HttpContext.Session.Remove("UserName");
                HttpContext.Session.SetString("UserName", account.UserName);
                HttpContext.Session.SetString("ImagePath", account.ImagePath);
                ViewBag.Message = result.Message;
                //ModelState.AddModelError("", result.Message);
                return View();
            }
            return View(registerRequest);
        }
        

    }
}
