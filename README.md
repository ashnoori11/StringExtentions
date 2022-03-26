# StringExtentions

##### An open source library for ease of working with strings.
##### This library is written statically and it is recommended to add it to the bottom layer of your program and then use it in other layers.

----------------------

# Install

> [PackageManager Console](https://docs.microsoft.com/en-us/nuget/consume-packages/install-use-packages-powershell)
#### PM> Install-Package StringExtentions_AshkanNoori -Version 1.0.0

> [.Net CLI](https://docs.microsoft.com/en-us/nuget/consume-packages/install-use-packages-dotnet-cli)
#### dotnet add package StringExtentions_AshkanNoori --version 1.0.0


--------------------------------

# How TO Use

> using StringExtentions;


        public IActionResult Index(string param)
        {
            string result = "";

            if (param.HasValue()) result = param;

            // If we want to ignore the WhitSpace in the submitted parameter
            if (param.HasValue(true)) result = param;

            return View(result);
        }
        
------------------------------

# Others

##### string GenerateId(int numOfCharacter) :cowboy_hat_face:

##### string GenerateId()  	:disguised_face:

##### string ToNumeric(this int value) :sunglasses:

##### string ToNumeric(this decimal value) :nerd_face:

##### string ToCurrency(this int value) :monocle_face:

##### string ToCurrency(this decimal value) :hugs:

##### string CleanString(this string str) :yum:

##### string ComparableStrings(this string text) :stuck_out_tongue_winking_eye:

----------------------------------------

### :gift_heart: Dedicated with love to all programmers in the world _ [Ashkan Noori](https://ashkannooridev.com) :gift_heart:
