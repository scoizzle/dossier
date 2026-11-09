# docs/faq/troubleshooting

- Subject: docs/faq/troubleshooting (id `a14dde7a-2f8c-4798-9cae-f21bde012124`)
- Kind: subject
- Budget: 1200 tokens
- Used: 681 tokens
- Facts shown: 17 of 17
- Conflicts: 0
- Gaps: 0

## Facts

- UnicodeDecodeError: 'ascii' codec can't decode byte 0x?? in position ?: ordinal not in range(128) [e5190441]
- * :doc:`Unicode in Django </ref/unicode>` * https://wiki.python.org/moin/UnicodeDecodeError [bd6f47f9]
- * Your system locale may be a default ASCII locale, like the "C" locale on UNIX-like systems (can be checked by the ``locale`` command). If it's the case, please refer to your system documentation to learn how you can change this to a UTF-8 locale. [8ddb9d29]
- .. _troubleshooting-django-admin: [750aa572]
- .. code-block:: pytb [fccd37de02dbdecc]
- :doc:`django-admin </ref/django-admin>` should be on your system path if you installed Django via ``pip``. If it's not in your path, ensure you have your virtual environment activated and you can try running the equivalent command ``python -m django``. [ac75a3d2]
- =============== Troubleshooting =============== [cc1fafd2]
- I'm getting a ``UnicodeDecodeError``. What am I doing wrong? ------------------------------------------------------------ [03157ca1]
- If you're using macOS, you may see the message "permission denied" when you try to run ``django-admin``. This is because, on Unix-based systems like macOS, a file must be marked as "executable" before it can be run as a program. To do this, open Terminal.app and navigate (using the ``cd`` command) to the directory where :doc:`django-admin </ref/django-admin>` is installed, then run the command ``sudo chmod +x django-admin``. [78eb7b38]
- Miscellaneous ============= [860302bc192c8ae4]
- Problems running ``django-admin`` ================================= [d740f623]
- Related resources: [1fee3272]
- The resolution mostly depends on the context, however here are two common pitfalls producing this error: [87fb870f]
- This class of errors happen when a bytestring containing non-ASCII sequences is transformed into a Unicode string and the specified encoding is incorrect. The output generally looks like this: [6f0cee0d]
- This page contains some advice about errors and problems commonly encountered during the development of Django applications. [d5b71284]
- ``command not found: django-admin`` ----------------------------------- [de68c715]
- macOS permissions ----------------- [664a7e4f]
