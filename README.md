Developers love to fucking swear. Now you can write shitty code just by swearing your ass off.

Yeah, it's a Brainfuck clone that originated from [a discussion on Reddit](https://www.reddit.com/r/ProgrammerHumor/comments/6vav3t/what_is_the_most_used_language/dlz9lgm/) and me being bored.

License is WTFPL because what other license would be appropriate?

## Syntax and shit

Valid identifiers contain only ASCII letters. Any other character is used as an identifier seperator. If a word isn't recognized, it's ignored. Case insensitive but completely ignores any characters that aren't ASCII letters.

| **swear** | **brainfuck** | **what the fuck does it do?**                                                          |
|-----------|---------------|----------------------------------------------------------------------------------------|
| `ass`     | `>`           | increment the data pointer                                                             |
| `bitch`   | `<`           | decrement the data pointer. if you try to go beyond the beginning it just does nothing |
| `cunt`    | `+`           | increment the value at the data pointer                                                |
| `damn`    | `-`           | decrement the value at the data pointer                                                |
| `dick`    | `.`           | write the value at the data pointer to stdout                                          |
| `fuck`    | `,`           | read a character from stdin and store it in the data pointer                           |
| `shit`    | `[`           | begin loop                                                                             |
| `twat`    | `]`           | end loop                                                                               |

## Hello World

Shamelssly copied from the Wikipedias

    cunt cunt cunt cunt cunt cunt cunt cunt shit ass cunt cunt cunt cunt shit
    ass cunt cunt ass cunt cunt cunt ass cunt cunt cunt ass cunt bitch bitch
    bitch bitch damn twat ass cunt ass cunt ass damn ass ass cunt shit bitch
    twat bitch damn twat ass ass dick ass damn damn damn dick cunt cunt cunt
    cunt cunt cunt cunt dick dick cunt cunt cunt dick ass ass dick bitch
    damn dick bitch dick cunt cunt cunt dick damn damn damn damn damn damn
    dick damn damn damn damn damn damn damn damn dick ass ass cunt dick ass
    cunt cunt dick 

## Building and testing

![Works on my machine](https://i.imgur.com/LdH0ycy.png)

## Future Plans

Fuck I dunno. More commands? A type system based on racist slurs?

Nah I'm probably done with this. (Famous last words.)

