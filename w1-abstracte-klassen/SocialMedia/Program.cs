using SocialMedia;
using System;
using System.Collections.Generic;


//Post p = new Post(); // mag niet, want abstracte klasse
MessagePost m = new MessagePost("MarkRutte", "nieuwe maatregelen");
PhotoPost p9 = new("hieke", "code.cs"); // mag in C# 9
//PhotoPost p = new Post(); // mag niet, want post is abstract, en een post heeft niet de functies van Photopost
Post p = new PhotoPost("Amalia", "me.png");

p.Like();
p.Display();
//p.ApplyFilter(); // mag niet, want p is van het type Post

p = m; // voordeel van declaratie als Post, ik kan een ander type in de variabele stoppen

//PhotoPost p2 = (PhotoPost)p; //casting, in veel gevallen liever niet want dit gaat nu mis op runtime!!

List<MessagePost> mPosts = new(); // niet zo flexibel

List<Post> posts = new(); // hier mag ik elk type post aan toevoegen
posts.Add(new MessagePost("MarkRutte", "nieuwe maatregelen"));
posts.Add(new PhotoPost("Amalia", "me.png"));

foreach (var post in posts)
{
    post.Display(); // elke post heeft een implementatie van display
}
