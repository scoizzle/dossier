# django/utils/lorem_ipsum

- Subject: django/utils/lorem_ipsum (id `c6826f98-c019-4ac2-88df-fe50ae262e96`)
- Kind: subject
- Budget: 1200 tokens
- Used: 741 tokens
- Facts shown: 12 of 13
- Conflicts: 0
- Gaps: 0

## Facts

- If `common` is True, then the first 19 words will be the standard 'lorem ipsum' words. Otherwise, all words will be selected randomly. """ word_list = list(COMMON_WORDS) if common else [] c = len(word_list) if count > c: count -= c while count > 0: c = min(count, len(WORDS)) count -= c word_list += random.sample(WORDS, c) else: word_list = word_list[:count] return " ".join(word_list) [6d91332b]
- If `common` is True, then the first paragraph will be the standard 'lorem ipsum' paragraph. Otherwise, the first paragraph will be random Latin text. Either way, subsequent paragraphs will be random Latin text. """ paras = [] for i in range(count): if common and i == 0: paras.append(COMMON_P) else: paras.append(paragraph()) return paras [7f6a16d2]
- The first word is capitalized, and the sentence ends in either a period or question mark. Commas are added at random. """ # Determine the number of comma-separated sections and number of words in # each section for this sentence. sections = [ " ".join(random.sample(WORDS, random.randint(3, 12))) for i in range(random.randint(1, 5)) ] s = ", ".join(sections) # Convert to sentence case and add end punctuation. return "%s%s%s" % (s[0].upper(), s[1:], random.choice("?.")) [7049c25f]
- The paragraph consists of between 1 and 4 sentences, inclusive. """ return " ".join(sentence() for i in range(random.randint(1, 4))) [3b45af92]
- """ Utility functions for generating "lorem ipsum" Latin text. """ [15eda9ea]
- COMMON_P = ( "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod " "tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim " "veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea " "commodo consequat. Duis aute irure dolor in reprehenderit in voluptate " "velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint " "occaecat cupidatat non proident, sunt in culpa qui officia deserunt " "mollit anim id est laborum." ) [998eb44f]
- COMMON_WORDS = ( "lorem", "ipsum", "dolor", "sit", "amet", "consectetur", "adipisicing", "elit", "sed", "do", "eiusmod", "tempor", "incididunt", "ut", "labore", "et", "dolore", "magna", "aliqua", ) [ea4688e6]
- def paragraph(): """ Return a randomly generated paragraph of lorem ipsum text. [ad57943a]
- def paragraphs(count, common=True): """ Return a list of paragraphs as returned by paragraph(). [9019528c]
- def sentence(): """ Return a randomly generated sentence of lorem ipsum text. [74a7ee21]
- def words(count, common=True): """ Return a string of `count` lorem ipsum words separated by a single space. [65cb0d3a]
- import random [1a6568a9]

## Beyond the budget

1 more facts did not fit in the budget: [0ef57924]
