var JOURNAL = [];

function addEntry(events, didTurnIntoASquirrel) {
    JOURNAL.push({
        events: events,
        squirrel: didTurnIntoASquirrel
    });
};

addEntry(["work", "touched tree", "pizza", "running",
    "television"], false);

addEntry(["work", "ice cream", "cauliflower", "lasagna",
    "touched tree", "bryshed teeth"], false);

addEntry(["weekend", "cycling", "break", "peanuts",
    "beer"], true);


function phi(table) {
    return (table[3] * table[0] - table[2] * table[1]) /
        Math.sqrt(
            (table[2] + table[3]) *
            (table[0] + table[1]) *
            (table[1] + table[3]) *
            (table[0] + table[2])
        );
};

function hasEvent(event, entry) {
    return entry.events.indexOf(event) != -1;
};

function tableFor(event, journal) {
    var table = [0, 0, 0, 0];

    for (var i = 0; i < journal.length; i += 1) {

        var entry = journal[i]
        var index = 0;

        if (hasEvent(event, entry)) {
            index += 1;
        };

        if (entry.squirrel) {
            index += 2;
        };

        table[index] += 1;
    };
    return table;
}

function gatherCorrelattions(journal) {
    var phis = {};

    for (var entry = 0; entry < journal.length; entry += 1) {

        var events = journal[entry].events;

        for (var i = 0; i < events.length; i += 1) {
            var event = events[i];

            if (!(event in phis)) {
                phis[event] = phi(tableFor(event, journal));
            };

        };
    };

    return phis;
};



function getAllCorellations(JOURNAL) {
    var correlation = gatherCorrelattions(JOURNAL);
    for (const event in correlation) {
        var correlationEvent = correlation[event];
        if (correlationEvent > 0.1 ) {
            console.log(event + ": " + correlationEvent);
        }
       
    };
};

getAllCorellations(JOURNAL);