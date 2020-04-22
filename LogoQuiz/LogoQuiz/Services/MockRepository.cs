//using LogoQuiz.Models;
//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Threading.Tasks;

//namespace LogoQuiz.Services
//{
//    public class MockRepository : IRepository<Logo>
//    {
//        readonly List<Logo> logos;

//        public MockRepository()
//        {
//            logos = new List<Logo>()
//            {
//                new Logo { Name = "Bmw", Hint = "*m*", ImageUrl = "BMW.jpg" }
//            };
//        }

//        public Task<IEnumerable<Logo>> GetLogosAsync(bool forceRefresh = false)
//        {
//            var allLogos = await Logos.ToListAsync();
//            return allLogos;
//        }
//    }
//}
