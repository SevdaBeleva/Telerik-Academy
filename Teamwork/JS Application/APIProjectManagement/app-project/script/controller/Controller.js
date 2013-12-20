/**
 * ===========================================================
 * 
 * 
 * ===========================================================
 */

/**
 * 
 * @param {type} dataRequest
 * @param {type} viewObject
 * @returns {Controller}
 */
function Controller(dataRequest, viewObject){
    
    this.dataRequest = dataRequest;
    this.viewObject  = viewObject;
    
    /*
     * SET CURRENT SCOPE VARIABLE
     -------------------------------------------*/    
    var _this = this;
    
    
    /*
     * INVOLKE MODEL DATA WHEN UI EVENT OCCURED
     -------------------------------------------*/
    /**
     *  User Login 
     */
    this.viewObject.viewEvent["userLogin"].attach(function(sender, controlData){
        _this.dataRequest.userLogin(controlData.username, controlData.userpass);
        
        Modula.publish("LOGIN_STATUS", function(ajax, status){
            var getJSONData = JSON.parse(status);

            if(getJSONData["statusCode"] == "ERROR_USER_NOT_EXISTS"){
                console.log("Probblem");
            }else if(getJSONData["statusCode"] == "SUCCESSFUL_LOGIN"){
                sessionObject.login(getJSONData["user_id"]);
                setupEnvironment();
            }
        });
    });
    
    /**
     *  User Registration
     */
    this.viewObject.viewEvent["userRegistration"].attach(function(sender, data){
        _this.dataRequest.userRegistration(data.username, data.userpass);
        
            Modula.publish("REGISTER_STATUS", function(ajax, status){
            var getJSONData = JSON.parse(status);

            if(getJSONData["statusCode"] == "GENERAL_ERROR"){
                console.log("Probblem");
            }else if(getJSONData["statusCode"] == "SUCCESFUL_REGISTRATION"){
                sessionObject.login(getJSONData["user_id"]);
                setupEnvironment();
            }
        });
    });
    
    
    /**
     *  Get All Project of Current User
     */
    this.viewObject.viewEvent["getProjects"].attach(function(sender, data){
        _this.dataRequest.getAllProjects(data.user_id);
    });
    
    /**
     *  Get All Users
     */
    this.viewObject.viewEvent["getUsers"].attach(function(){
        _this.dataRequest.getAllUsers();
    });
    
    /**
     *  Set new Project
     */
    this.viewObject.viewEvent["setProject"].attach(function(sender, data){
        
        _this.dataRequest.addNewProject(data.projectname, data.projectdesc);
         //window.location.reload(true);
        
    });
    
    /**
     *  Couse Project from the Set of Projects
     */
    this.viewObject.viewEvent["projectSet"].attach(function(sender, data){
        
        localStorage.setItem("projecId", data.projectid);
        sessionObject.setProject(data.projectid);
        
        _this.dataRequest.getProjectTracks(data.projectid);
        

        // collect Items data
        Modula.publish("getAllTracks", function(){
                
            var data = [];
            
            for (var i = 1; i < arguments.length; i++) {
                data.push(arguments[i]);
            }
           
            if(data.length === 0 ){
                
               $("#track-placeholder").append("<h2 class='track-label'>No Tracks in Current Project</h2>");
                
            }else{
                
                for(var i=0; i<data.length;i++) {
                    $("#track-placeholder").append("<h2 class='tracks' data-id='"+data[i]["track_id"]+"'>" + data[i]["track_name"] + "</h2>");
                }    
            }
        });
        
            // Change Nav Bar button 
            var button = $("#controllButton");
            button.attr("href", "#myModalTrack");
            button.text("Add new Track");
            
            window.location.reload(true);
    });
    
    /**
     *  Set new Track
     */
    this.viewObject.viewEvent["trackSet"].attach(function(sender, data){
        _this.dataRequest.addNewTrack(localStorage.getItem("projecId"), data.trackname);
        //window.location.reload(true);
    });   
    
    
   /**
     *  Set new Item
     */
    this.viewObject.viewEvent["addItem"].attach(function(sender, data){
        
        console.log(data);
        console.log(sessionObject.trackId());
        _this.dataRequest.addNewItem(sessionObject.trackId(), data.itemname);

    });   
    
    
    
    /**
     *  Show Track Items
     */
    this.viewObject.viewEvent["showItems"].attach(function(sender, data){
        
        _this.dataRequest.getTrackItems(data.trackid);
        
        sessionObject.setTrack(data.trackid);
        
        Modula.publish("getAllItems", function(){
                            
            var data = [];

            for (var i = 1; i < arguments.length; i++) {
                data.push(arguments[i]);
            } 
        
            if(data.length === 0 ){
               $("#item-placeholder").append("<h2 class='track-label'>No Items in Current Track</h2>");
                
            }else{
                for (var i = 0; i < data.length; i++) {
                    $("#item-placeholder").append("<div class='well'>" + data[i]["item_content"] + "</div>");
                }
            }
        });
        // setup Project environment
                // Change Nav Bar button 
            var button = $("#controllButton");
            button.attr("href", "#myModalItem");
            button.text("Add new Item");
            window.location.reload(true);
    });
}

/**
 * 
 * @returns {undefined}
 */
Controller.prototype.onLoadShow = function(){
    this.dataRequest.getAllProjects(sessionObject.userId());
};

Controller.prototype.showTracks = function(){
    
    var _this = this;
    
    this.dataRequest.getProjectTracks(sessionObject.projectId());
    
    // collect Items data
        Modula.publish("getAllTracks", function(){
                
            var data = [];
            for (var i = 1; i < arguments.length; i++) {
                data.push(arguments[i]);
            }
           
            if(data.length === 0 ){
               $("#track-placeholder").append("<h2 class='track-label'>No Tracks in Current Project</h2>");
                
            }else{
                for(var i=0; i<data.length;i++) {
                    $("#track-placeholder").append("<h2 class='tracks' data_id='"+ data[i]["track_id"] +"'>" + data[i]["track_name"] + "</h2></div>");
                }    
            }
            
            // Change Nav Bar button 
            var button = $("#controllButton");
            button.attr("href", "#myModalTrack");
            button.text("Add new Track");
             
        });
        
        
};


Controller.prototype.showItems = function(){
    /**
     *  Show Track Items
     */
        var _this = this;
        _this.dataRequest.getTrackItems(sessionObject.trackId());
        
        Modula.publish("getAllItems", function(){
                            
            var data = [];

            for (var i = 1; i < arguments.length; i++) {
                data.push(arguments[i]);
            } 
            
            if(data.length === 0 ){
               $("#item-placeholder").append("<h2 class='track-label'>No Items in Current Track</h2>");
                
            }else{
                for (var i = 0; i < data.length; i++) {
                    $("#item-placeholder").append("<div class='well'>" + data[i]["item_content"] + "</div>");
                }
            }
            
            // Change Nav Bar button 
            var button = $("#controllButton");
            button.attr("href", "#myModalItem");
            button.text("Add new Item");
        });
};
