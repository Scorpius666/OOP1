using Newtonsoft.Json;
using SquirrelFramework.Domain.Model;
using SquirrelFramework.Repository;
using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Human zhansan = new Human();
            //zhansan.Age = 18;
            //Human lisi = new Human();
            //lisi.Age = 19;
            //Human wangwu = new Human();
            //Human zhaoliu = new Human();
            Human zhansan = new Human();
            zhansan.Age = 19;
            HumanCurdRepository database = new HumanCurdRepository();
            database.Add(zhansan);
            Console.WriteLine(JsonConvert.SerializeObject(database.GetAll()));
        }
      
     }


}

class HumanCurdRepository : RepositoryBase<Human> { }
class Human : DomainModel
{
    public void Eat(int foodsize)
    {
        HungerIndex = HungerIndex + foodsize / 4;
    }//成员方法 行为
    public Human()
    {

    }
    private int hungerIndex;
   //唯一标识符
    public string Name;
    public bool Gender;
    public int Age;
    public DateTime Birthday;
    public string Professional;

    public int HungerIndex { get => hungerIndex; set => hungerIndex = value; }
    //成员变量 属性
}