/**
 * ===========================================================
 * 
 * 
 * ===========================================================
 */

/** ProjectObject is the main Entity in the Project system it contains 
 * several smaler objects in it like
 *  -- Tracks project boards
 *  -- Users project contributors
 * @param {string} projectName
 * @param {string} projectDescription
 * @returns {ProjectObject}
 */
function ProjectObject(projectName, projectDescription){
    
    this.projectName   = projectName;
    this.projectDescription = projectDescription;
    this.projectUsers  = [];
    this.projectTracks = [];
    
    this.projectPlaceholder = document.getElementById("placeholder");
}

/**
 * Return General Project data needed to undarstand this project 
 * TODO set optional description for the project item
 *
 * @returns {JSON object} 
 */
ProjectObject.prototype.getProjectData = function(){
    
    var data = {};
    data["project_name"]        = this.projectName;
    data["project_description"] = this.projectDescription;
    data["user_id"]             = sessionObject.userId();
    
    return JSON.stringify(data);
};

/**
 * 
 * @returns {undefined}
 */
ProjectObject.prototype.setProjectUsers = function(userObject){
    this.projectUsers.push(userObject);
};

/**
 * 
 * @returns {undefined}
 */
ProjectObject.prototype.getProjectUsers = function(){
    return this.projectUsers;
};

/**
 * 
 * @returns {undefined}
 */
ProjectObject.prototype.setProjectTracks = function(trackObject){
    this.projectTracks.push(trackObject);
};

/**
 * 
 * @returns {undefined}
 */
ProjectObject.prototype.getProjectTracks = function(){
    return this.projectTracks;
};

/**
 * 
 * @returns {undefined}
 */
ProjectObject.prototype.renderTracks = function(){
    
    for(var i = 0; i< this.projectTracks.length; i++){

        this.projectPlaceholder.appendChild(this.projectTracks[i].renderTrack());
    }
};

/**
 * 
 * @returns {undefined}
 */
ProjectObject.prototype.renderProjects = function(projectData){
    
    
    if(projectData.length === 0){
    
        this.projectPlaceholder.innerHTML += "<h2 class='track-label'>No Projects in Current Palet</h2>";
    
    }else{
        
        this.projectPlaceholder.innerHTML = "";
        
        for(var i=0; i<projectData.length; i++){
           this.projectPlaceholder.innerHTML +=("<h2 data-id='" + projectData[i]["project_id"] + "' class='project'>" + projectData[i]["project_name"] + "</h2>");
        }    
    }
    
    
};