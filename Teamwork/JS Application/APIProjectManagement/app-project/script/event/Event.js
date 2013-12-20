/**
 * ===========================================================
 * 
 * 
 * ===========================================================
 */

/**
 * 
 * @param {type} sender
 * @returns {Event}
 */
function Event(sender){
    this.sender = sender;
    this.listeners = [];
};

/**
 * 
 * @param {type} listener
 * @returns {undefined}
 */
Event.prototype.attach = function(listener){
    this.listeners.push(listener);
};

/**
 * 
 * @returns {undefined}
 */
Event.prototype.notify = function(arguments){
    for(var i=0;i<this.listeners.length;i++){
        this.listeners[i](this.sender,arguments);
    }
};
