# docs/internals/contributing/writing-code/javascript

- Subject: docs/internals/contributing/writing-code/javascript (id `93189fd1-fa1a-4f70-acaf-7a993157c5dd`)
- Kind: subject
- Budget: 1200 tokens
- Used: 892 tokens
- Facts shown: 24 of 36
- Conflicts: 0
- Gaps: 0

## Facts

- $ npm install [550501b8]
- $ npm test [bf2e2853]
- QUnit.module('magicTricks', { beforeEach: function() { const $ = django.jQuery; $('#qunit-fixture').append('<button class="button"></button>'); } }); [46cc828d]
- QUnit.test('copyOnClick adds button on click', function(assert) { const $ = django.jQuery; copyOnClick('.button'); assert.equal($('.button').length, 1); $('.button').click(); assert.equal($('.button').length, 2); }); [0fe8a278]
- QUnit.test('removeOnClick removes button on click', function(assert) { const $ = django.jQuery; removeOnClick('.button'); assert.equal($('.button').length, 1); $('.button').click(); assert.equal($('.button').length, 0); }); [05e5d930]
- * Execute ``python -m http.server`` from the root directory (not from inside ``js_tests``). * Open http://localhost:8000/js_tests/tests.html in your web browser. [b9aae1fd]
- * Please conform to the indentation style dictated in the ``.editorconfig`` file. We recommend using a text editor with `EditorConfig`_ support to avoid indentation and whitespace issues. Most of the JavaScript files use 4 spaces for indentation, but there are some exceptions. [d07fe1aa]
- * Use the `Biome`_ code linter to check your code for bugs and style errors. Biome will be run by the pre-commit hooks. We also recommended installing a Biome plugin in your text editor. [b86fd885]
- * When naming variables, use ``camelCase`` instead of ``underscore_case``. Different JavaScript files sometimes use a different code style. Please try to conform to the code style of each file. [586a9728]
- * Where possible, write code that will work even if the page structure is later changed with JavaScript. For instance, when binding a click handler, use ``$('body').on('click', selector, func)`` instead of ``$(selector).click(func)``. This makes it easier for projects to extend Django's default behavior with JavaScript. [2f0c90bf]
- .. _Biome: https://biomejs.dev/ .. _EditorConfig: https://editorconfig.org/ .. _Java: https://www.java.com .. _node.js: https://nodejs.org/ .. _qunit: https://qunitjs.com/ [c13b3b0f]
- .. _javascript-patches: [a7b755f2]
- .. _javascript-tests: [33597321]
- .. code-block:: javascript [3f90e06ebee94674-4]
- .. console:: [7714e199aac2701e-17]
- .. console:: [7714e199aac2701e-18]
- =============== JavaScript code =============== [dac439f4]
- After installing ``Node.js``, install the JavaScript test dependencies by running the following from the root of your Django checkout: [da07592e]
- Code style ========== [ff2e06a2]
- Django's JavaScript tests can be run in a browser or from the command line. The tests are located in a top level :source:`js_tests` directory. [9a568c99]
- Django's JavaScript tests use `QUnit`_. Here is an example test module: [56a11c19]
- JavaScript patches ================== [cd4a0816]
- JavaScript tests ================ [4217f621]
- Running tests ------------- [0e1dadb93d50ca4b]

## Beyond the budget

12 more facts did not fit in the budget: [f6d20bfb] [3991ee29] [6222061e] [cb2069d6] [56ac0378] [cb076667] [d06caf47] [c227b434] [0173b61d] [b3bf0de4] [87b5b548] [a60d61ac]
