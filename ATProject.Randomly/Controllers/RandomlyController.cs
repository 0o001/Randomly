using Microsoft.AspNetCore.Mvc;

namespace ATProject.Randomly.Controllers
{
    [ApiController]
    [Route("Api/[controller]")]
    public class RandomlyController : ControllerBase
    {
        private Randomizer randomList = new Randomizer(); 

        [HttpGet("Boolean")]
        public bool GetBoolean()
        {
            return randomList.GetBoolean();
        }

        [HttpGet("Integer")]
        public int GetInteger()
        {
            return randomList.GetInteger();
        }

        [HttpGet("Long")]
        public long GetLong()
        {
            return randomList.GetLong();
        }

        [HttpGet("Float")]
        public float GetFloat()
        {
            return randomList.GetFloat();
        }

        [HttpGet("Digit")]
        public float GetDigit()
        {
            return randomList.GetDigit();
        }

        [HttpGet("Char")]
        public char GetChar()
        {
            return randomList.GetChar();
        }

        [HttpGet("String")]
        public string GetString()
        {
            return randomList.GetString();
        }

        [HttpGet("Date")]
        public DateTime GetDate()
        {
            return randomList.GetDate();
        }

        [HttpGet("LanguageShortCode")]
        public string GetLanguageShortCode()
        {
            return randomList.GetLanguageShortCode();
        }

        [HttpGet("Language")]
        public string GetLanguage()
        {
            return randomList.GetLanguage();
        }

        [HttpGet("CurrencySymbol")]
        public string GetCurrencySymbol()
        {
            return randomList.GetCurrencySymbol();
        }

        [HttpGet("GUID")]
        public string GetGUID()
        {
            return randomList.GetGUID();
        }

        [HttpGet("Symbol")]
        public char GetSymbol()
        {
            return randomList.GetSymbol();
        }

        [HttpGet("HEXColor")]
        public string GetHEXColor()
        {
            return randomList.GetHEXColor();
        }
    }
}