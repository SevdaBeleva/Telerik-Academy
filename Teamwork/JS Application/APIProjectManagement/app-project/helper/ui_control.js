// change navbar login -registration button
var getButton         = $("#user-button");
var loginForm         = $("#user_login"); 
var registrationForm  = $("#user_registration"); 
var projectHolder     = $("#placeholder");
var trackHolder       = $("#track-placeholder");
var itemHolder        = $("#item-placeholder");
var buttonSet         = $("#buttonSet");


function SessionForm(){
    buttonSet.html('<button class="btn btn-primary" id="user-button">Login</button>');
    
    var get_button = buttonSet.children("#user-button");
    
    get_button.on('click', function(){
       
       if($(this).text() == "Login"){
           $(this).text("Registration");
           loginForm.removeClass("visible");
           registrationForm.addClass("visible");
       }else{
           $(this).text("Login");
           loginForm.addClass("visible");
           registrationForm.removeClass("visible");
       }
    });
}

function ProjectForm(){
     if(sessionObject.isLogin()){
        buttonSet.html(' <a id="controllButton" href="#myModal" role="button" class="btn" data-toggle="modal">New Project</a>');
    }
}

function showForm() {
    
    if(sessionObject.isProject()){
            buttonSet.html(' <a id="controllButton" href="#myModalTrack" role="button" class="btn" data-toggle="modal">New Track</a>');
    }
}

function setupEnvironment(){
    
    if(sessionObject.isTrack()){
        loginForm.removeClass("visible");
        registrationForm.removeClass("visible");
        trackHolder.css("display", "none");
        controller.showItems();
    }
    
    if(sessionObject.isProject()){
        showForm();
        loginForm.removeClass("visible");
        registrationForm.removeClass("visible");
        projectHolder.css("display", "none");
        controller.showTracks();
        
        
        
    }
    if(sessionObject.isLogin()){
        ProjectForm();
        loginForm.removeClass("visible");
        registrationForm.removeClass("visible");
        controller.onLoadShow();
    }else{
        SessionForm();
    }   
}

