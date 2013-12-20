/**
 * ===========================================================
 * 
 * 
 * ===========================================================
 */

/**
 * 
 * @param {type} task
 * @param {type} list
 * @returns {ToDoList}
 */
function TrackObject(trackName) {
    this.trackName = trackName;
    this.task = [];
}

/**
 * 
 * @returns {undefined}
 */
TrackObject.prototype.addTask = function(task) {
    this.task.push(task);
};

/**
 * 
 * @returns {undefined}
 */
TrackObject.prototype.deleteTask = function(){
    $("input:checked").each(function() {
        $(this).parent().remove();
    });
};

/**
 * 
 * @returns {undefined}
 */
TrackObject.prototype.completeTask = function(){
 $("input:checked").each(function() {
        if ($(this).parent().css('textDecoration') === 'line-trough') {
            $(this).parent().css('textDecoration', 'none');
        } else {
            $(this).parent().css('textDecoration', 'line-through');
        }
    });
};

/**
 * 
 * @param {type} button
 * @returns {undefined} 
 */
TrackObject.prototype.saveLocalStorage = function(button){
    if (typeof(Storage) !== "undefined") {
         var $savedList = $(this.list);

         $(button).click(function() {
             localStorage.setItem('list', $savedList.html());
         });

         if (localStorage.getItem('list')) {
             $savedList.html(localStorage.getItem('list'));
         }
     }
};

/**
 * 
 * @returns {undefined}
 */
TrackObject.prototype.renderTrack = function(){
    var element = document.createElement("div");
    element.innerHTML = "<h2>" + this.trackName + "</h2>";
    
    return element;
};


/**
 * 
 * @returns {undefined}
 */
TrackObject.prototype.renderEntries = function(){
    
};