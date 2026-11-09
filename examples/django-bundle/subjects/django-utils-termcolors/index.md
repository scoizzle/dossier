# django/utils/termcolors

- Subject: django/utils/termcolors (id `71871fc1-8bcd-4e77-bfc6-3a6d218fa67c`)
- Kind: subject
- Budget: 1200 tokens
- Used: 893 tokens
- Facts shown: 17 of 28
- Conflicts: 0
- Gaps: 0

## Facts

- # All remaining instructions are options opts = tuple(s for s in styles if s in opt_dict) if opts: definition["opts"] = opts [d6c7935d]
- # Break the definition into the role, # plus the list of specific instructions. # The role must be in upper case role, instructions = part.split("=") role = role.upper() [ec5ec637]
- # The first instruction can contain a slash # to break apart fg/bg. colors = styles.pop().split("/") colors.reverse() fg = colors.pop() if fg in color_names: definition["fg"] = fg if colors and colors[-1] in color_names: definition["bg"] = colors[-1] [9f88f0be]
- # The nocolor palette has all available roles. # Use that palette as the basis for determining # if the role is valid. if role in PALETTES[NOCOLOR_PALETTE] and definition: palette[role] = definition [047fd91d]
- styles = instructions.split(",") styles.reverse() [8be4a30f]
- "palette;role=fg;role=fg/bg;role=fg,option,option;role=fg/bg,option,option" [215990b0]
- # If there are no colors specified, return the empty palette. if palette == PALETTES[NOCOLOR_PALETTE]: return None return palette [eaff2b1c]
- # Split the color configuration into parts parts = config_string.lower().split(";") palette = PALETTES[NOCOLOR_PALETTE].copy() for part in parts: if part in PALETTES: # A default palette has been specified palette.update(PALETTES[part]) elif "=" in part: # Process a palette defining string definition = {} [97c16cd1]
- Depends on the keyword arguments 'fg' and 'bg', and the contents of the opts tuple/list. [b5641504]
- Example: bold_red = make_style(opts=('bold',), fg='red') print(bold_red('hello')) KEYWORD = make_style(fg='yellow') COMMENT = make_style(fg='blue', opts=('bold',)) """ return lambda text: colorize(text, opts, **kwargs) [f76dfa76]
- Examples: colorize('hello', fg='red', bg='blue', opts=('blink',)) colorize() colorize('goodbye', opts=('underscore',)) print(colorize('first line', fg='red', opts=('noreset',))) print('this should be red too') print(colorize('and so should this')) print('this should not be red') """ code_list = [] if text == "" and len(opts) == 1 and opts[0] == "reset": return "\x1b[%sm" % RESET for k, v in kwargs.items(): if k == "fg": code_list.append(foreground[v]) elif k == "bg": code_list.append(background[v]) for o in opts: if o in opt_dict: code_list.append(opt_dict[o]) if "noreset" not in opts: text = "%s\x1b[%sm" % (text or "", RESET) return "%s%s" % (("\x1b[%sm" % ";".join(code_list)), text or "") [ed327d73]
- Return the RESET code if no parameters are given. [0714ffb9]
- Specifying a named palette is the same as manually specifying the individual definitions for each role. Any individual definitions following the palette definition will augment the base palette definition. [2a87a2b7]
- The general form of a palette definition is: [3123e6d8]
- Valid colors: 'black', 'red', 'green', 'yellow', 'blue', 'magenta', 'cyan', 'white' [e7bf44ea2bdcce69]
- Valid options: 'bold' 'underscore' 'blink' 'reverse' 'conceal' 'noreset' - string will not be auto-terminated with the RESET code [174ce8f1]
- """ termcolors.py """ [b7bff268]

## Beyond the budget

10 more facts did not fit in the budget: [76feda56] [cfc6abb7] [bbb6e5de] [ad77554d] [17342d91] [25cb4559] [2ca1518b] [deb0321d] [0b33cf81] [9a029e01]
