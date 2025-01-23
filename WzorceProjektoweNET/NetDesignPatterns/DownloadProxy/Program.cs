using DownloadProxy;
var downloadService = new DownloadService();
downloadService.DownloadFilm("Pocahontas", "Test1234");
downloadService.DownloadFilm("Avatar 2", "TestTest");

var downloadServiceProxy = new DownloadServiceProxy();
downloadServiceProxy.DownloadFilm("Pocahontas", "Test1234");
downloadServiceProxy.DownloadFilm("Avatar 2", "TestTest");