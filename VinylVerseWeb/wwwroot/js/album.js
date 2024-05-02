document.addEventListener('DOMContentLoaded', function () {
    const addTrackButton = document.getElementById('addTrackButton');
    const trackModal = document.getElementById('trackModal');
    const closeModalButton = document.getElementById('closeModalButton');
    const addTrackButtonModal = document.getElementById('addTrackButtonModal');
    const newTrackTitleInput = document.getElementById('newTrackTitle');
    const trackListContainer = document.getElementById('trackList').getElementsByTagName('tbody')[0];

    addTrackButton.addEventListener('click', function () {
        trackModal.style.display = 'block';
    });

    closeModalButton.addEventListener('click', function () {
        trackModal.style.display = 'none';
    });

    window.addEventListener('click', function (event) {
        if (event.target === trackModal) {
            trackModal.style.display = 'none';
        }
    });

    addTrackButtonModal.addEventListener('click', function () {
        addTrack();
    });

    // Function to add a track
    function addTrack() {
        const trackTitle = newTrackTitleInput.value.trim();
        if (trackTitle !== '') {
            // Check if a row is being edited
            const editedRow = trackListContainer.querySelector('.editing');
            if (editedRow) {
                // Update the title of the edited track
                editedRow.querySelector('.track-title').textContent = trackTitle.toUpperCase();
                editedRow.classList.remove('editing'); // Remove editing class
            } else {
                // Create a new row for the track
                const newRow = document.createElement('tr');

                // Create track title cell
                const titleCell = document.createElement('td');
                titleCell.textContent = trackTitle.toUpperCase(); // Convert track title to uppercase
                titleCell.classList.add('track-title'); // Add a class to identify the title cell
                titleCell.style.fontStyle = 'italic'; // Apply italic style
                newRow.appendChild(titleCell);

                // Create actions cell
                const actionsCell = document.createElement('td');

                // Create edit button
                const editButton = document.createElement('button');
                editButton.textContent = 'Edit';
                editButton.classList.add('btn', 'btn-outline-primary', 'btn-sm', 'me-2'); // Add Bootstrap button classes
                editButton.addEventListener('click', function () {
                    // Populate the modal input field with the current track title
                    newTrackTitleInput.value = titleCell.textContent.toLowerCase(); // Convert track title to lowercase
                    trackModal.style.display = 'block';
                    newRow.classList.add('editing'); // Add editing class to identify the row being edited
                });
                actionsCell.appendChild(editButton);

                // Create remove button
                const removeButton = document.createElement('button');
                removeButton.textContent = 'Remove';
                removeButton.classList.add('btn', 'btn-outline-danger', 'btn-sm'); // Add Bootstrap button classes
                removeButton.addEventListener('click', function () {
                    // Remove the track row when remove button is clicked
                    trackListContainer.removeChild(newRow);
                });
                actionsCell.appendChild(removeButton);

                newRow.appendChild(actionsCell);

                // Append the new row to the track list container
                trackListContainer.appendChild(newRow);
            }

            // Clear the input field
            newTrackTitleInput.value = '';

            // Close the modal
            trackModal.style.display = 'none';
        }
    }

    // Add track when Enter key is pressed within the modal's input field
    newTrackTitleInput.addEventListener('keypress', function (event) {
        if (event.key === 'Enter') {
            event.preventDefault(); // Prevent the default action (submitting the form)
            addTrack();
        }
    });

    // Function to populate tracks input based on the Tracks property of AlbumCreateDto
function populateTracksInput() {
    // Get the input element for tracks
    const tracksInput = document.getElementById('tracksInput');

    // Get the AlbumCreateDto object from the form
    const albumDto = document.getElementById('albumForm').dataset.albumDto;

    // Parse the JSON string to get the object
    const album = JSON.parse(albumDto);

    // Set the value of the input element to the tracks array joined with a comma
    tracksInput.value = album.Tracks.join(',');
}
});