(function () {
	const alertElement = document.getElementById("success-alert");
	const formElement = document.getElementById("company-form");
	const inputName = formElement.querySelector('input[name="Name"]');
	const inputDescription = formElement.querySelector('textarea[name="Description"]');
	const inputIsVisible = formElement.querySelector('input[name="IsVisible"]');

	const addNewItem = async () => {
		// 1. read data from the form​// const requestData = ...​
		const endpointUrl = 'api/company';
		const requestData = {
			Name: inputName.value,
			Description: inputDescription.value,
			isVisible: inputIsVisible.checked
		};

		const config = {
			method: 'POST',
			body: JSON.stringify(requestData),
			headers: {
				'Content-Type': 'application/json',
			}
		};

		// 2. call the application server using fetch method​// 
		const response = await fetch(endpointUrl, config);
		const responseJson = await response.json();

		if (response.status === 200 && responseJson) {
			// 3. un-hide the alertElement when the request has been successful
			// alertElement.style...
			alertElement.style.display = 'block';
		}
	};
	window.addEventListener("load", () => {
		formElement.addEventListener("submit", event => {
			event.preventDefault();
			addNewItem().then(() => console.log("added successfully"));
		});
	});
})();