// JavaScript Exercise 14
const events = [
  { name: "Tech Innovators Meetup", category: "Technology", seats: 12, date: "2026-07-10" },
  { name: "Music Night", category: "Music", seats: 0, date: "2026-06-01" },
  { name: "Health Camp", category: "Health", seats: 20, date: "2026-08-05" }
];

function render(list = events) {
  const cards = list
    .map(
      (event) =>
        `<article class="event"><h3>${event.name}</h3><p>${event.category} - Seats: ${event.seats}</p></article>`
    )
    .join("");
  $("#output").html(cards);
}

function filterEventsByCategory(category) {
  render(events.filter((event) => event.category === category));
}

$(function () {
  render();

  $("#filter").on("change", function () {
    filterEventsByCategory(this.value);
  });

  $("#search").on("keydown", function (event) {
    if (event.key === "Enter") {
      const term = this.value.toLowerCase();
      render(events.filter((item) => item.name.toLowerCase().includes(term)));
    }
  });

  $("#registerForm").on("submit", async function (event) {
    event.preventDefault();
    const email = $(this).find('[name="email"]').val();
    if (!String(email).includes("@")) {
      $("#message").text("Enter a valid email.");
      return;
    }

    $("#message").text("Submitting...");
    await new Promise((resolve) => setTimeout(resolve, 400));
    const fullName = $(this).find('[name="fullName"]').val();
    const eventName = $(this).find('[name="eventName"]').val();
    $("#message").text(`Registered ${fullName} for ${eventName}`);
  });

  $("#load").on("click", async function () {
    const response = await fetch("data/events.json");
    const data = await response.json();
    $("#output").html(data.map((item) => `<p>${item.name} in ${item.city}</p>`).join(""));
  });
});
