grammar AWSIMScriptGrammar;

scenario
    : (statement)+ EOF;

statement
    : (assignmentStm | functionExp) ';' ;

assignmentStm
    : variableExp '=' expression;

expression
    : stringExp
    | positionExp
    | routeExp
    | arrayExp
    | variableExp
    | spawnDelayOptionExp
    | functionExp;

functionExp
    : idExp '(' argumentList? ')' ;

argumentList
    : expression ( ',' expression )*
    ;

arrayExp
    : '[' argumentList? ']';

// to specify a (2D) position
// e.g., "TrafficLane.239" at 3.5 expresses the position on lane 239, 3.5m from the starting point of the lane.
positionExp
    : lanePositionExp;
lanePositionExp
    : stringExp ('at' numberExp)?;

routeExp
    : stringExp ('with-speed-limit' numberExp)?;

// variable name, e.g., npc1
variableExp: idExp;

spawnDelayOptionExp
    : 'delay-spawn' '(' numberExp ')'
    | 'delay-move' '(' numberExp ')'
    | 'delay-spawn-until-ego-move' '(' numberExp ')'
    | 'delay-move-until-ego-move' '(' numberExp ')'
    | 'delay-spawn-until-ego-engaged' '(' numberExp ')'
    | 'delay-move-until-ego-engaged' '(' numberExp ')';

stringExp
    : STRING;
numberExp
    : NUMBER;
idExp
    : ID;

// number and string data types
STRING : '"' .*? '"';
SIGN
    : ('+' | '-');
NUMBER
    : SIGN? ( [0-9]* '.' )? [0-9]+;

ID  : [a-zA-Z_] [a-zA-Z0-9_]*;

// ignore space(s)
WS  : (' '|'\t'|'\r'|'\n')+ -> skip;

LINE_COMMENT
    : '//' ~[\r\n]* -> skip;


// non-moving NPC
// spawn an NPC with 5 seconds delay (i.e., spawn at time 5)
// spawn an NPC and delay its movement by 5 seconds
// spawn an NPC and make it move at 1 second after the Ego moves
// spawn an NPC, delay its movement, and make it move when the Ego engage
