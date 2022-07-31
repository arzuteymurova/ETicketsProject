using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

var movieManager = new MovieManager(new EfMovieDal());

var data = movieManager.GetAll();
foreach (var item in data.Data)
{
    Console.WriteLine(item.Name);
}

