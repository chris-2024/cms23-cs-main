using _01_Enums.Services;

var weekdayService = new WeekdayService();
weekdayService.Run();

var urlCheckerService = new UrlCheckerService();
await urlCheckerService.Run("https://hamsterpaj.net");