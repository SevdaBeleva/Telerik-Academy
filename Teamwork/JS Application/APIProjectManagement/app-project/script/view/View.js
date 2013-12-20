/**
 * ===========================================================
 * 
 * 
 * ===========================================================
 */

/**
 * 
 * @param {type} element
 * @returns {View}
 */
function View(element) {
    
    this.element    = element;
    this.viewEvent  = [];
    
    // automatically attach events 
    this.attachEventObject(element);

    /*
     * SET CURRENT SCOPE VARIABLE
     -------------------------------------------*/
    var _this = this;
    
    
    /*
     * BIND UI CONTROLS WITH EVENT LISTENERS
     -------------------------------------------*/
    
    /**
     * 
     */
    if(this.element.userLogin !== null) {
        this.element.userLogin.addEventListener('submit', function(e){
        
            var dataObject = {  
                username : _this.element.userLogin["username"].value,
                userpass : _this.element.userLogin["userpass"].value
            };

            _this.viewEvent["userLogin"].notify(dataObject);

            e.preventDefault();
        });
    }
    
    
    /**
     * 
     */
    if(this.element.userRegistration !== null) {
        this.element.userRegistration.addEventListener('submit', function(e){

            var dataObject = {  
                username : _this.element.userRegistration["username"].value,
                userpass : _this.element.userRegistration["userpass"].value
            };

            _this.viewEvent["userRegistration"].notify(dataObject);

            e.preventDefault();
        });    
    }
    
    /**
     * 
     */
    if(this.element.getProjects !== null) {
        this.element.getProjects.addEventListener('click', function(){
            _this.viewEvent["getProjects"].notify({
                user_id : sessionObject.userId()
            });
        });
    }
    
    /**
     * 
     */
    if(this.element.getUsers !== null) {
        this.element.getUsers.addEventListener('click', function(){
            _this.viewEvent["getUsers"].notify();
        });
    }
    
    /**
     * 
     */
    if(this.element.setProject !== null) {
        this.element.setProject.addEventListener('submit', function(e){
            
            _this.viewEvent["setProject"].notify({
                projectname : _this.element.setProject["projectname"].value,
                projectdesc : _this.element.setProject["projectdesc"].value
            });
            $("#myModal").css("display", "none");
            
           e.preventDefault();
        });
    }
    
    /*
     * 
     * @param {type} eventName
     * @returns {undefined}
     */
        if(this.element.projectSet !== null) {
        this.element.projectSet.on('click', function(e){
             
//             _this.element.projectSet.css('display', 'none');
             
            _this.viewEvent["projectSet"].notify({
                projectid : e.target.getAttribute('data-id')
            });

           e.preventDefault();
           e.stopPropagation();
        });
    }
    
    /**
     * 
     */
    if(this.element.trackSet !== null){
        this.element.trackSet.addEventListener('submit', function(e){
           
           _this.viewEvent["trackSet"].notify({
                trackname : _this.element.trackSet["trackname"].value
                
            });
            
            $("#myModalTrack").css("display", "none");
            
           e.preventDefault();
            
        });
    }
    
    
        /*
     * 
     * @param {type} eventName
     * @returns {undefined}
     */
      if(this.element.showItems !== null) {
        this.element.showItems.on('click', function(e){
            
             _this.element.showItems.css('display', 'none');
            
            _this.viewEvent["showItems"].notify({
                trackid : e.target.getAttribute('data-id')
            });

                e.preventDefault();
                e.stopPropagation();
        });
    }
  
      /**
     * 
     */
    if(this.element.addItem !== null){
        this.element.addItem.addEventListener('submit', function(e){
           
            
           _this.viewEvent["addItem"].notify({
                itemname : _this.element.addItem["itemcontent"].value
            });
            
           $("#myModalItem").css("display", "none");

           e.preventDefault();
        });
    }
  
}

/*==========================================*/
/*         VIEW ELEMENTS METHODS            */
/*==========================================*/

/**
 * Bind UI controll to Event object, the newly binded eement
 * is placed in spacial aray that can be executed by Controller obhect
 * 
 * @param {string} eventName
 */
View.prototype.setEvent = function(eventName){
    this.viewEvent[eventName] = new Event(this);
};

/**
 * Automaticly attach newly binded UI controll with Event Object,
 * this method is involked at the constructro class.
 * 
 * @param {object} elementObject
 */
View.prototype.attachEventObject = function(elementObject){
    for(var eventObject in elementObject){
        this.setEvent(eventObject);
    }
};


