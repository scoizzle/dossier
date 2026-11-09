# django/utils/translation/template

- Subject: django/utils/translation/template (id `9847e929-b471-4656-8cb7-f1513a4ea42e`)
- Kind: subject
- Budget: 1200 tokens
- Used: 877 tokens
- Facts shown: 9 of 11
- Conflicts: 0
- Gaps: 0

## Facts

- if t.token_type == TokenType.BLOCK: imatch = inline_re.match(t.contents) bmatch = block_re.match(t.contents) cmatches = constant_re.findall(t.contents) if imatch: g = imatch[1] if g[0] == '"': g = g.strip('"') elif g[0] == "'": g = g.strip("'") g = g.replace("%", "%%") if imatch[2]: # A context is provided context_match = context_re.match(imatch[2]) message_context = context_match[1] if message_context[0] == '"': message_context = message_context.strip('"') elif message_context[0] == "'": message_context = message_context.strip("'") out.write( " pgettext({p}{!r}, {p}{!r}) ".format( message_context, g, p=raw_prefix ) ) message_context = None else: out.write(" gettext({p}{!r}) ".format(g, p=raw_prefix)) elif bmatch: for fmatch in constant_re.findall(t.contents): out.write(" _(%s) " % fmatch) if bmatch[1]: # A context is provided context_match = context_re.match(bmatch[1]) message_context = context_match[1] if message_context[0] == '"': message_context = message_context.strip('"') elif message_context[0] == "'": message_context = message_context.strip("'") intrans = True inplural = False trimmed = "trimmed" in t.split_contents() singular = [] plural = [] elif cmatches: for cmatch in cmatches: out.write(" _(%s) " % cmatch) elif t.contents == "comment": incomment = True else: out.write(blankout(t.contents, "B")) elif t.token_type == TokenType.VAR: parts = t.contents.split("|") cmatch = constant_re.match(parts[0]) if cmatch: out.write(" _(%s) " % cmatch[1]) for p in parts[1:]: if p.find(":_(") >= 0: out.write(" %s " % p.split(":", 1)[1]) else: out.write(blankout(p, "F")) elif t.token_type == TokenType.COMMENT: if t.contents.lstrip().startswith(TRANSLATOR_COMMENT_MARK): lineno_comment_map.setdefault(t.lineno, []).append(t.contents) comment_lineno_cache = t.lineno else: out.write(blankout(t.contents, "X")) return out.getvalue() [beb1316a]
- def join_tokens(tokens, trim=False): message = "".join(tokens) if trim: message = trim_whitespace(message) return message [066cf181]
- TRANSLATOR_COMMENT_MARK = "Translators" [cf7e65bd]
- context_re = _lazy_re_compile(r"""^\s+.*context\s+((?:"[^"]*?")|(?:'[^']*?'))\s*""") inline_re = _lazy_re_compile( # Match the trans/translate 'some text' part. r"""^\s*trans(?:late)?\s+((?:"[^"]*?")|(?:'[^']*?'))""" # Match and ignore optional filters r"""(?:\s*\|\s*[^\s:]+(?::(?:[^\s'":]+|(?:"[^"]*?")|(?:'[^']*?')))?)*""" # Match the optional context part r"""(\s+.*context\s+((?:"[^"]*?")|(?:'[^']*?')))?\s*""" ) block_re = _lazy_re_compile( r"""^\s*blocktrans(?:late)?(\s+.*context\s+((?:"[^"]*?")|(?:'[^']*?')))?(?:\s+|$)""" ) endblock_re = _lazy_re_compile(r"""^\s*endblocktrans(?:late)?$""") plural_re = _lazy_re_compile(r"""^\s*plural$""") constant_re = _lazy_re_compile(r"""_\(((?:".*?")|(?:'.*?'))\)""") [b9f72cde]
- def blankout(src, char): """ Change every non-whitespace character to the given char. Used in the templatize function. """ return dot_re.sub(char, src) [a379a5bf]
- dot_re = _lazy_re_compile(r"\S") [128f169c]
- from . import TranslatorCommentWarning, trim_whitespace [66927f66]
- from django.template.base import Lexer, TokenType from django.utils.regex_helper import _lazy_re_compile [98ed2a95]
- import warnings from io import StringIO [6e695d99]

## Beyond the budget

2 more facts did not fit in the budget: [4db3d7e7] [46eabf41]
