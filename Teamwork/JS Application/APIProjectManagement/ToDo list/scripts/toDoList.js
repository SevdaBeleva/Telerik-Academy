function ToDoList(task, list){
	this.task = task;
	this.list = list;
}
ToDoList.prototype = {
	constructor: ToDoList,
	addTask: function(){
		var text = $(this.task).val();
		$(this.list).append('<li> <input type="checkbox" class="checkbox"></input>' + text + '</li>');
		$(this.task).val(' ');
	},
	deleteTask : function(){
		$("input:checked").each(function() {
			$(this).parent().remove();	
		});
	},
	completeTask: function(){
		$("input:checked").each(function() {
			if ($(this).parent().css('textDecoration') === 'line-trough'){//attr, value
				$(this).parent().css('textDecoration','none');	
			} else {
				$(this).parent().css('textDecoration','line-through');
			}
		});		
	},	
	saveLocalStorage: function(button){
		if(typeof(Storage)!=="undefined"){
			 var $savedList = $(this.list);
			//save task. I put this function here, because when it's outside (html) doesn't work
			$(button).click( function(){
				localStorage.setItem('list', $savedList.html());
			});	
			//get tasks when the page loads
			if(localStorage.getItem('list')){
				$savedList.html(localStorage.getItem('list'));
			}
		}
		else{
		  document.write("Sorry!! Your borwser does not support local storage!")
		}		
	}	
}