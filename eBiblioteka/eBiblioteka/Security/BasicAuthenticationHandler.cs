using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text.Encodings.Web;
using System.Text;
using System.Threading.Tasks;
using eBiblioteka.Services;

namespace eBiblioteka.Security
{
    public class BasicAuthenticationHandler : AuthenticationHandler<AuthenticationSchemeOptions>
    {
        private readonly IZaposlenikService _zaposlenikService;
        private readonly IClanService _clanService;
        public BasicAuthenticationHandler(IOptionsMonitor<AuthenticationSchemeOptions> options, ILoggerFactory logger, UrlEncoder encoder, ISystemClock clock, IZaposlenikService zaposlenikService, IClanService clanService) : base(options, logger, encoder, clock)
        {
            _zaposlenikService = zaposlenikService;
            _clanService = clanService;
        }

        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            if (!Request.Headers.ContainsKey("Authorization"))
            {
                return AuthenticateResult.Fail("Missing authorization header");
            }

            Model.Zaposlenik zaposlenik = null;
            Model.Clan clan = null;

            try
            {
                var authHeader = AuthenticationHeaderValue.Parse(Request.Headers["Authorization"]);
                var credentialBytes = Convert.FromBase64String(authHeader.Parameter);
                var credentials = Encoding.UTF8.GetString(credentialBytes).Split(':');
                var username = credentials[0];
                var password = credentials[1];

                try
                {
                    zaposlenik = await _zaposlenikService.Login(username, password);
                }
                catch (Exception)
                {
                    clan = await _clanService.Login(username, password);
                }
            }
            catch (Exception ex)
            {
                return AuthenticateResult.Fail("Incorrect username or password");
            }

            if (zaposlenik is null && clan is null)
                return AuthenticateResult.Fail("Invalid username or password");

            string korisnickoIme, ime, uloga;
            if (zaposlenik != null)
            {
                _zaposlenikService.SetLogiraniKorisnik(zaposlenik);
                korisnickoIme = zaposlenik.KorisnickoIme;
                ime = zaposlenik.Ime;
                uloga = zaposlenik.Uloga.Naziv;
            }
            else
            {
                _clanService.SetLogiraniKorisnik(clan);
                korisnickoIme = clan.KorisnickoIme;
                ime = clan.Ime;
                uloga = "Član";
            }

            var claims = new List<Claim> {
                new Claim(ClaimTypes.NameIdentifier, korisnickoIme),
                new Claim(ClaimTypes.Name, ime),
            };


            claims.Add(new Claim(ClaimTypes.Role, uloga));


            var identity = new ClaimsIdentity(claims, Scheme.Name);
            var principal = new ClaimsPrincipal(identity);
            var ticket = new AuthenticationTicket(principal, Scheme.Name);

            return AuthenticateResult.Success(ticket);
        }


    }
}
