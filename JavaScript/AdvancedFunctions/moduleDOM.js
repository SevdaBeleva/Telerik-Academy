var moduleDom = (function(){
			function hello(){
				alert('Say hello to my new friend!');
			}
			function getElement(tagName){
					return document.querySelector(tagName);
				}
				
			function createChild(tagName){
					var child = document.createElement(tagName);
					return child;
				}
			function addChildElement(parent, child) {	
				getElement(parent).appendChild(createChild(child));
			}
			
			function removeElement(parent, child){
				getElement(parent).removeChild(getElement(child));
			}
			
			function attachEvent(selector, eventHandler, eventType){
				if (selector.addEventListener){
					selector.addEventListener(eventType, eventHandler, false);
				}else{
				selector.attachEvent('on' + eventType, eventHandler);
				}	
			}
			
			var buffer = {};
			var bufferSize = 100;
			function addElementToBuffer(parent, tag, attribute, innerHtml){
				if (!buffer[parent]) {
					buffer[parent] = document.createDocumentFragment();
			}
				var element = createElement(tagName, attributes, innerHTML);
				buffer[parent].appendChild(element);

				if (buffer[parent].childNodes.length === buferSize) {
					var parent = getElement(parent);
					parent.appendChild(buffer[parent]);
					buffer[parent] = null;
				}
			}
			
			return {
			addChildElement: addChildElement,
			removeElement: removeElement,
			attachEvent: attachEvent,
			addElementToBuffer: addElementToBuffer		
			};
		})();	