float distance = 30000;
int firstFriendS = 20;
int secondFriendS = 10;
int dogS = 30;
int friend = 2;
int count = 0;
float time = 1;
while (distance > 10)
{
    if (friend == 1)
    {
        time = distance/(firstFriendS + dogS );
        friend = 2;
    }
    else
    {
        time = distance/(secondFriendS + dogS );
        friend = 1;
    }
    distance = distance - (firstFriendS + secondFriendS)*time;
    count++;
}

Console.Write("count = ");
Console.WriteLine(count);
