// See https://aka.ms/new-console-template for more information
using SOLID.DIP;
using SOLID.LSP;
using SOLID.OCR;
using static SOLID.LSP.Post;


#region OCP
//Manager manager = new Manager();
////manager.Name = "Ahmed Yousef";
////manager.Id = "123";
//manager.BasicSalary = 900;
//Console.WriteLine(manager.ToString() 
//    + Environment.NewLine+
//    "Bounce :" + manager.CalacSalary(5).ToString());

//Console.WriteLine("...................");

//RegualerEmp regualerEmp = new RegualerEmp();
////regualerEmp.Name = "Omer Yousef";
////regualerEmp.Id = "1234";
//regualerEmp.BasicSalary = 900;
//Console.WriteLine(regualerEmp.ToString()
//    + Environment.NewLine +
//    "Bounce :" + regualerEmp.CalacSalary(5).ToString());
#endregion


#region LSP

//PostDatabase db = new();

//List<string> newPost = new();
//newPost.Add("Original Post");
//newPost.Add("#Tag Post");
//newPost.Add("@Mention Post");
//newPost.Add("http Post");

//Post postObj;

//foreach (var post in newPost)
//{
//    if (post.StartsWith("#"))
//    {
//        postObj = new TagPost();
//    }
//    else if (post.StartsWith("@"))
//    {
//        postObj = new MentionPost();
//    }
//    else if (post.StartsWith("http"))
//    {
//        postObj = new LinkPost();
//    }
//    else
//    {
//        postObj = new Post();
//    }

//    var result = postObj.CreatePost(db, post);

//    Console.WriteLine(result);
//}


#endregion


#region ISP

#region Dependency Injection Using Constructor
//Notification notification = new(new Gmail());
//notification.SendMail();
#endregion

#region Dependency Injection Using Method
//Notification notification = new();
//notification.SendMail(new Hotmail());

#endregion


#region Dependency Injection Using Property
//Notification notification = new();
//notification.mailServiceType = new WebMail();
//notification.SendMail();
#endregion

#endregion
