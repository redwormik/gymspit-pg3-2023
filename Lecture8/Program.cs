static bool AddValue(string value, string[] data, int count)
{
	if (count >= data.Length) {
		Console.WriteLine("I'm afraid I can't do that.");
		return false;
	}

	data[count] = value;
	return true;
}

static bool RemoveValue(string[] data, int index, int count)
{
	if (index < 0 || index >= count){
		Console.WriteLine("I'm afraid I can't do that.");
		return false;
	}

	for (int i = index; i < count - 1; i += 1) {
		data[i] = data[i + 1];
	}
	data[count - 1] = "";
	return true;
}


static void AddUser(string username, string[] users, ref int userCount)
{
	int index = Array.IndexOf(users, username);
	if (index >= 0) {
		Console.WriteLine("User already exists.");
		return;
	}

	if (AddValue(username, users, userCount)) {
		userCount += 1;
	}
}

static void RemoveUser(string username, string[] users, ref int userCount)
{
	int index = Array.IndexOf(users, username);
	if (index < 0) {
		Console.WriteLine("User does not exist.");
		return;
	}

	if (index >= 0 && RemoveValue(users, index, userCount)) {
		userCount -= 1;
	}
}


static void AddPost(string post, string author, string[] posts, string[] postAuthors, ref int postCount)
{
	// TODO
}

static string[] GetUserPosts(string user, string[] posts, string[] postAuthors, int postCount)
{
	// TODO
	return new string[] { };
}


static void AddFollow(string follower, string followee, string[] followers, string[] followees, ref int followCount)
{
	// TODO
}

static void RemoveFollow(string follower, string followee, string[] followers, string[] followees, ref int followCount)
{
	// TODO
}

static string[] GetUserFollows(string user, string[] followers, string[] followees, int followCount)
{
	// TODO
	return new string[] { };
}

static string[] GetUserFollowers(string user, string[] followers, string[] followees, int followCount)
{
	// TODO
	return new string[] { };
}


// Bonus
static string[] GetUserTimeline(string user, string[] posts, string[] postAuthors, int postCount, string[] followers, string[] followees, int followCount)
{
	// TODO
	return new string[] { };
}


int MAX_USERS = 100;
int MAX_POSTS = MAX_USERS * 100;
int MAX_FOLLOWS = MAX_USERS * (MAX_USERS + 1) / 2;

string[] users = new string[MAX_USERS];
int userCount = 0;

string[] posts = new string[MAX_POSTS];
string[] postAuthors = new string[MAX_POSTS];
int postCount = 0;

string[] followers = new string[MAX_FOLLOWS];
string[] followees = new string[MAX_FOLLOWS];
int followCount = 0;

AddUser("wormik", users, ref userCount);