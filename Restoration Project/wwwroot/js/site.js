// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function selectAns(result)
    {
    var buttons = document.getElementsByClassName("incorrect");
    for (i in buttons) {
        buttons[i].disabled = true;
    }
    if (result == "correct")
    {
        document.getElementById("resultTxt").innerHTML = "Good Job! You got it correct!";
    }
    else
    {
        document.getElementById("resultTxt").innerHTML = "Sorry, you got this question wrong..";
    }
    document.getElementById("moveOn").hidden = false;
}

function changeViewed()
{

    document.getElementById(id).value = true;
}

function resetViewed(questions)
{
    for (i in questions)
    {
        questions[i].Viewed = false;
    }
}