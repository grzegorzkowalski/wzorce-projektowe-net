using PartyAdapter;

var nightClub = new NightClub();
var adult = new Adult("Jan", 33);
var fakeAdult = new FakeAdult("Michał", 15);

nightClub.letsParty(adult);
nightClub.letsParty(fakeAdult);