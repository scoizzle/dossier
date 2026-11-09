# django/utils/termcolors

- Subject: django/utils/termcolors (id `9e3c4618-8799-416b-9322-9ab62696948f`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 1773 tokens
- Facts shown: 27 of 28
- Conflicts: 0
- Gaps: 0

## Highlights

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

## All facts

- [76feda56] Valid options: 'bold', 'underscore', 'blink', 'reverse', 'conceal', 'noreset' """ if not config_string: return PALETTES[DEFAULT_PALETTE]
- [cfc6abb7] Valid roles: 'error', 'success', 'warning', 'notice', 'sql_field', 'sql_coltype', 'sql_keyword', 'sql_table', 'http_info', 'http_success', 'http_redirect', 'http_not_modified', 'http_bad_request', 'http_not_found', 'http_server_error', 'migrate_heading', 'migrate_label'
- [bbb6e5de] where: palette is a named palette; one of 'light', 'dark', or 'nocolor'. role is a named style used by Django fg is a foreground color. bg is a background color. option is a display options.
- [ad77554d] NOCOLOR_PALETTE = "nocolor" DARK_PALETTE = "dark" LIGHT_PALETTE = "light"
- [17342d91] PALETTES = { NOCOLOR_PALETTE: { "ERROR": {}, "SUCCESS": {}, "WARNING": {}, "NOTICE": {}, "SQL_FIELD": {}, "SQL_COLTYPE": {}, "SQL_KEYWORD": {}, "SQL_TABLE": {}, "HTTP_INFO": {}, "HTTP_SUCCESS": {}, "HTTP_REDIRECT": {}, "HTTP_NOT_MODIFIED": {}, "HTTP_BAD_REQUEST": {}, "HTTP_NOT_FOUND": {}, "HTTP_SERVER_ERROR": {}, "MIGRATE_HEADING": {}, "MIGRATE_LABEL": {}, }, DARK_PALETTE: { "ERROR": {"fg": "red", "opts": ("bold",)}, "SUCCESS": {"fg": "green", "opts": ("bold",)}, "WARNING": {"fg": "yellow", "opts": ("bold",)}, "NOTICE": {"fg": "red"}, "SQL_FIELD": {"fg": "green", "opts": ("bold",)}, "SQL_COLTYPE": {"fg": "green"}, "SQL_KEYWORD": {"fg": "yellow"}, "SQL_TABLE": {"opts": ("bold",)}, "HTTP_INFO": {"opts": ("bold",)}, "HTTP_SUCCESS": {}, "HTTP_REDIRECT": {"fg": "green"}, "HTTP_NOT_MODIFIED": {"fg": "cyan"}, "HTTP_BAD_REQUEST": {"fg": "red", "opts": ("bold",)}, "HTTP_NOT_FOUND": {"fg": "yellow"}, "HTTP_SERVER_ERROR": {"fg": "magenta", "opts": ("bold",)}, "MIGRATE_HEADING": {"fg": "cyan", "opts": ("bold",)}, "MIGRATE_LABEL": {"opts": ("bold",)}, }, LIGHT_PALETTE: { "ERROR": {"fg": "red", "opts": ("bold",)}, "SUCCESS": {"fg": "green", "opts": ("bold",)}, "WARNING": {"fg": "yellow", "opts": ("bold",)}, "NOTICE": {"fg": "red"}, "SQL_FIELD": {"fg": "green", "opts": ("bold",)}, "SQL_COLTYPE": {"fg": "green"}, "SQL_KEYWORD": {"fg": "blue"}, "SQL_TABLE": {"opts": ("bold",)}, "HTTP_INFO": {"opts": ("bold",)}, "HTTP_SUCCESS": {}, "HTTP_REDIRECT": {"fg": "green", "opts": ("bold",)}, "HTTP_NOT_MODIFIED": {"fg": "green"}, "HTTP_BAD_REQUEST": {"fg": "red", "opts": ("bold",)}, "HTTP_NOT_FOUND": {"fg": "red"}, "HTTP_SERVER_ERROR": {"fg": "magenta", "opts": ("bold",)}, "MIGRATE_HEADING": {"fg": "cyan", "opts": ("bold",)}, "MIGRATE_LABEL": {"opts": ("bold",)}, }, } DEFAULT_PALETTE = DARK_PALETTE
- [25cb4559] RESET = "0" opt_dict = { "bold": "1", "underscore": "4", "blink": "5", "reverse": "7", "conceal": "8", }
- [2ca1518b] color_names = ("black", "red", "green", "yellow", "blue", "magenta", "cyan", "white") foreground = {color_names[x]: "3%s" % x for x in range(8)} background = {color_names[x]: "4%s" % x for x in range(8)}
- [deb0321d] def colorize(text="", opts=(), **kwargs): """ Return your text, enclosed in ANSI graphics codes.
- [0b33cf81] def make_style(opts=(), **kwargs): """ Return a function with default parameters for colorize()
- [9a029e01] def parse_color_setting(config_string): """Parse a DJANGO_COLORS environment variable to produce the system palette
