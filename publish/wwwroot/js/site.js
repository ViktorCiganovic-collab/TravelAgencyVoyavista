


document.addEventListener('DOMContentLoaded', () => {
    const menuItems = document.querySelectorAll('.nav-item a'); // Get all the links
    const currentPath = window.location.pathname; // Get the current page's path

    // Loop through each menu item
    menuItems.forEach(item => {
        // Check if the link's href matches the current URL
        if (item.getAttribute('href') === currentPath) {
            // Add 'active' class to the matching menu item
            item.classList.add('active');
        } else {
            // Optionally, remove the 'active' class from all other items
            item.classList.remove('active');
        }
    });
});

const observerOptions = {
    threshold: 1.0 // Start triggering when 50% of the element is visible
};

const observer = new IntersectionObserver(onIntersection, observerOptions);

function onIntersection(entries, observer) {
    entries.forEach(entry => {
        if (entry.isIntersecting) {
            console.log("Element is in view: ", entry.target);

            // Trigger animation only for the `.heading` within the target container
            if (entry.target.classList.contains('heading')) {
                entry.target.classList.add('visible'); // Add visible class to trigger animation
            }

            observer.unobserve(entry.target); // Stop observing after animation is triggered
        }
    });
}

// Now, make sure to observe all `.hero-container` elements
document.querySelectorAll('.hero-container').forEach(container => {
    const heading = container.querySelector('.heading'); // Select the `.heading` inside each hero-container
    if (heading) {
        observer.observe(heading); // Observe each heading individually
    }
});


function toggleMode(button) {
    var content = button.nextElementSibling;
    var icon = button.querySelector('i');

    // Use ternary operator to toggle max-height
    content.style.maxHeight = (content.style.maxHeight === '0px' || content.style.maxHeight === '')
        ? content.scrollHeight + 'px'  // Expand to scrollHeight if maxHeight is not set
        : '0px';  // Collapse the content if already set

    // Toggle the rotation of the icon
    icon.classList.toggle("bi-caret-up");
    icon.classList.toggle("bi-caret-down");
}
