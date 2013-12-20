/**
 * ===========================================================
 * Proxy Object for comunicating with Model data and involking 
 * currently definde functionality
 * ===========================================================
 */

/**
 * 
 * @returns {undefined}
 */
function DataRequest(){ 
    var _this = this;
}

///**
// * 
// * @returns {undefined}
// */
DataRequest.prototype.userLogin = function(username, userpass){
    
    var user = new UserObject(username, userpass);
    user.getUserData();
    
    // database Object 
    $.post("http://www.updata.cloudvps.bg/cellar/loginUser",  user.getUserData() ,function(data) {
        Modula.subscribe("LOGIN_STATUS", data);
    },'json');
};

///**
// * 
// * @returns {undefined}
// */
DataRequest.prototype.userRegistration = function(username, userpass){
    
    var user = new UserObject(username, userpass);
    user.getUserData();
    
    // database Object 
    $.post("http://www.updata.cloudvps.bg/cellar/registerUser",  user.getUserData() ,function(data) {
        console.log(data);
        Modula.subscribe("REGISTER_STATUS", data);
    },'json');
    
};

///**
// * 
// * @returns {undefined}
// */
DataRequest.prototype.getAllProjects = function(id){
    console.log(id);
    
    var project = new ProjectObject();
    
    $.getJSON("http://www.updata.cloudvps.bg/cellar/getAllProjects/" + id, function(data){
          project.renderProjects(data);
    });
};

///**
// * 
// * @returns {undefined}
// */
DataRequest.prototype.getAllUsers = function(){
    
    $.getJSON("http://www.updata.cloudvps.bg/cellar/getAllUsers", function(data){
    });
};

///**
// * 
// * @returns {undefined}
// */
DataRequest.prototype.addNewProject = function(projectName, projectDescription){
    
    
    var projectObject = new ProjectObject(projectName, projectDescription);
    
    $.post("http://www.updata.cloudvps.bg/cellar/addNewProject", projectObject.getProjectData() ,function(data) {
        projectObject.renderProjects();
    },'json');
    
};

///**
// * 
// * @returns {undefined}
// */
DataRequest.prototype.addNewTrack = function(projectId, trackName){
    
    // TODO Add rack Object
    
    $.ajax({
        type: 'PUT',
        contentType: 'application/json',
        url: "http://www.updata.cloudvps.bg/cellar/addNewTrack/" + projectId,
        dataType: "json",
        data: JSON.stringify({ project_id : projectId,track_name : trackName}),
        success: function(data) {
            console.log("Data Loaded: " + data);
        }
    });   
    
};

///**
// * 
// * @returns {undefined}
// */
DataRequest.prototype.addNewItem = function(trackId,itemName){
    
    $.ajax({
        type: 'PUT',
        contentType: 'application/json',
        url: "http://www.updata.cloudvps.bg/cellar/addNewItem/" + trackId,
        dataType: "json",
        data: JSON.stringify({ item_content : itemName}),
        success: function(data) {
        }
    });    
};


DataRequest.prototype.getProjectTracks = function(id){
    
        $.getJSON("http://www.updata.cloudvps.bg/cellar/getAllTraks/" + id, function(data){
        Modula.subscribe("getAllTracks", data);
    });
    
};


DataRequest.prototype.getTrackItems = function(id){
        
        $.getJSON("http://www.updata.cloudvps.bg/cellar/getAllTrakItems/" + id, function(data){
            Modula.subscribe("getAllItems", data);
    });
};