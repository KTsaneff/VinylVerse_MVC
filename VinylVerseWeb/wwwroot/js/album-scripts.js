var trackTitles = [];

document.getElementById('addTrackButton').addEventListener('click', function () {
    showModal();
});

document.addEventListener('DOMContentLoaded', function () {
    trackModalInstance = new bootstrap.Modal(document.getElementById('trackModal'), {
        keyboard: true,
        focus: true
    });
});

document.getElementById('newTrackTitle').addEventListener('keypress', function (event) {
    if (event.key === 'Enter') {
        addTrack();
    }
});

function addTrack() {
    var trackTitle = document.getElementById('newTrackTitle').value.trim();
    if (trackTitle) {
        addTrackToTable(trackTitle);
        trackTitles.push(trackTitle);
        document.getElementById('newTrackTitle').value = '';

        if (document.querySelector('.modal-backdrop')) {
            // Don't hide the modal yet
        }
    } else {
        alert('Please enter a track title.');
    }
}

function addTrackToTable(title) {
    const tableBody = document.getElementById('trackList').getElementsByTagName('tbody')[0];
    const newRow = tableBody.insertRow();
    const cell1 = newRow.insertCell(0);
    const cell2 = newRow.insertCell(1);

    cell1.innerHTML = `<input type="text" name="Tracks" value="${title}" class="form-control" />`;
    cell2.innerHTML = '<button onclick="removeTrack(this)" class="btn btn-danger">Delete</button>';
}

function removeTrack(btn) {
    const row = btn.parentNode.parentNode;
    const trackTitle = row.cells[0].getElementsByTagName('input')[0].value;
    const index = trackTitles.indexOf(trackTitle);
    if (index !== -1) {
        trackTitles.splice(index, 1);
    }
    row.remove();
}

function populateTracksInput() {
    const tracksInput = document.getElementById('tracksInput');
    tracksInput.value = JSON.stringify(trackTitles);
}

function removeBackdrop() {
    const backdrops = document.querySelectorAll('.modal-backdrop');
    backdrops.forEach(backdrop => backdrop.remove());
    document.body.classList.remove('modal-open');
    document.body.style.paddingRight = '0';
}
