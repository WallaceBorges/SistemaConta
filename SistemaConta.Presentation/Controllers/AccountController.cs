using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SistemaConta.Data.Entities;
using SistemaConta.Data.Helpers;
using SistemaConta.Data.Repositories;
using SistemaConta.Presentation.Models.Account;

namespace SistemaConta.Presentation.Controllers
{
    public class AccountController : Controller
    {       private readonly IMapper? _mapper;

        public AccountController(IMapper? mapper)
        {
            _mapper = mapper;
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var usuarioRepository = new UsuarioRepository();
                    var usuario=usuarioRepository.Obter(u=>u.Email.Equals(model.Email)&&u.Senha.Equals(MD5Cryptography.Hash(model.Senha))); 
                    if(usuario != null)
                    {
                        if (usuario.Ativo == 1)
                        {

                        }
                        else
                        {
                            TempData["MensagemErro"] = "Conta desativada";
                        }

                    }
                    else
                    {
                        TempData["MensagemErro"] = "Acesso negado.";
                    }
                }
                catch (Exception e)
                {
                    TempData["MensagemErro"] = $"ModelState não é valida {e.Message}";
                    throw;
                }
            }

            return View();
         }


        //metodo get que retorna para o navegador a pagina
        public IActionResult Register()
        {
            return View();
        }

        //Metodo post para receber o form da pagina
        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var usuarioRepository = new UsuarioRepository();

                    if(usuarioRepository.Obter(u=>u.Email.Equals(model.Email))!=null)
                    {
                        ModelState.AddModelError("Email", "Email já cadastrado.");
                    }
                    else
                    {
                        var usuario = _mapper.Map<Usuario>(model);


                        usuarioRepository.Adicionar(usuario);
                        ModelState.Clear();

                        TempData["MensagemSucesso"] = $"Parabens {usuario.Nome}, conta criada.";

                    }
                }
                catch (Exception e)
                {

                    TempData["MensagemErro"] = $"Falha ao criar cadastro.{e.Message}";
                }

            }
            return View();
        }



        public IActionResult PasswordRecover()
        {
            return View();
        }
        [HttpPost]
        public IActionResult PasswordRecover(LoginViewModel model)
        {
            return View();
        }
    }
}
