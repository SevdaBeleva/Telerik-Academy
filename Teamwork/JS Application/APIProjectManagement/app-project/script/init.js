/*==========================================*/
/*       BIND UI CONTROLES to VIEW LAYER
/*==========================================*/

// bind user interface with view element 
var view =  new View({
    
    //    Credentials Controles
    userLogin           : document.getElementById("user_login"),
    userRegistration    : document.getElementById("user_registration"),
    
    // get data from the server
    getProjects         : document.getElementById("get_projects"),
    getUsers            : document.getElementById("get_users"),
    
    // set new project UI
    setProject          : document.getElementById("new_project"),
    projectSet          : $("#placeholder"),
    trackSet            : document.getElementById("new_track"),
    showItems           : $("#track-placeholder"),
    addItem             : document.getElementById("new_item")
});

/*==========================================*/
/*              DATA LAYER
/*==========================================*/

var data = new DataRequest();


/*==========================================*/
/*              CONTROLLER LAYER
/*==========================================*/

var controller = new Controller(data, view);

// setup Project environment
setupEnvironment();

