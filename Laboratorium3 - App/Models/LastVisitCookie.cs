namespace Laboratorium3___App.Models
{
    public class LastVisitCookie
    {

        public static string CookieName = "visit";
        private readonly RequestDelegate _next;

        public LastVisitCookie(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {

            string? cookie = context.Request.Cookies[CookieName];
            if (cookie is null)
            {//piewrsza wizyta
                context.Items.Add(CookieName, "FirstVisit");
            }
            else
            {
                //kolejna wizyta, odzczytujemy z ciastka date kolejnej wizyty
                if (DateTime.TryParse(cookie, out var date))
                {
                    context.Items.Add(CookieName, date);



                }

                else
                {
                    context.Items.Add(CookieName, "Cant read date from coookie!");

                }

            }
            CookieOptions options = new CookieOptions { MaxAge =new  TimeSpan(400, 0,0,0)};
            context.Response.Cookies.Append(CookieName, DateTime.Now.ToString(), options);
            await _next(context);

        }
        
    }
}
