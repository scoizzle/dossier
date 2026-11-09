# docs/howto/custom-management-commands

- Subject: docs/howto/custom-management-commands (id `120ec6e2-f816-4e91-8cef-e33820db6080`)
- Kind: subject
- Budget: 1200 tokens
- Used: 900 tokens
- Facts shown: 20 of 116
- Conflicts: 0
- Gaps: 0

## Facts

- poll.opened = False poll.save() [6b53af87]
- self.stdout.write( self.style.SUCCESS('Successfully closed poll "%s"' % poll_id) ) [7c9b74e9]
- # Named (optional) arguments parser.add_argument( "--delete", action="store_true", help="Delete poll instead of closing it", ) [becac750]
- @no_translations def handle(self, *args, **options): ... [83d25ace]
- class Command(BaseCommand): def __init__(self, *args, **kwargs): super().__init__(*args, **kwargs) # ... [82571e8b]
- def add_arguments(self, parser): parser.add_argument("poll_ids", nargs="+", type=int) [fc4f0ff2]
- def get_check_kwargs(self, options): kwargs = super().get_check_kwargs(options) return {**kwargs, "databases": [options["database"]]} [2bb79989]
- def handle(self, *args, **options): # ... if options["delete"]: poll.delete() # ... [aff76b56]
- def handle(self, *args, **options): for poll_id in options["poll_ids"]: try: poll = Poll.objects.get(pk=poll_id) except Poll.DoesNotExist: raise CommandError('Poll "%s" does not exist' % poll_id) [eae65617]
- self.stdout.write("Unterminated line", ending="") [df35da22]
- self.stdout.write(self.style.SUCCESS("...")) [5d132a60]
- A boolean indicating whether the command outputs SQL statements; if ``True``, the output will automatically be wrapped with ``BEGIN;`` and ``COMMIT;``. Default value is ``False``. [7d448dd2]
- A boolean; if ``True``, the command prints a warning if the set of migrations on disk don't match the migrations in the database. A warning doesn't prevent the command from executing. Default value is ``False``. [a8ab9a90]
- A list or tuple of tags, e.g. ``[Tags.staticfiles, Tags.models]``. System checks :ref:`registered in the chosen tags <registering-labeling-checks>` will be checked for errors prior to executing the command. The value ``'__all__'`` can be used to specify that all system checks should be performed. Default value is ``'__all__'``. [f63028ab]
- A short description of the command, which will be printed in the help message when the user runs the command ``python manage.py help <command>``. [94327226]
- A string describing the arbitrary arguments passed to the command. The string is used in the usage text and error messages of the command. Defaults to ``'label'``. [56ba0ae7]
- An instance attribute that helps create colored output when writing to ``stdout`` or ``stderr``. For example:: [9e404a8f]
- Custom management commands are especially useful for running standalone scripts or for scripts that are periodically executed from the UNIX crontab or from Windows scheduled tasks control panel. [6edbecd2]
- Entry point to add parser arguments to handle command line arguments passed to the command. Custom commands should override this method to add both positional and optional arguments accepted by the command. Calling ``super()`` is not needed when directly subclassing ``BaseCommand``. [d69f16a6]
- If you implement ``__init__`` in your subclass of :class:`BaseCommand`, you must call :class:`BaseCommand`’s ``__init__``:: [eb91add2]

## Beyond the budget

95 more facts did not fit in the budget: [28b7dc93] [917dd412] [1ba0160b] [d881abde] [b242fa17] [091d6e3d] [424738ec] [fcb7b0ab] [b1988be3] [f57155b4] [a60da509] [7531d187] [ac21212e] [4f61d193] [2f8a15d6] [8a5f987e] [5d7e19b4] [e6891a34] [a13b5c66] [580840f3] [faea555b] [599cae7d] [7c8e02be] [d9db3ca3] [f970fedb] [903b71f2] [a519a974] [d1c1a176] [3799d7cc] [d644051d] [e5afc565] [a4123769] [75efcc67] [f7cc0c26] [6fb1b697] [69c3afb7] [912df12d] [9662a1d6] [82a17df8] [fdd558af] [5063901b] [aaf0eea7] [4e230af1] [3a9340cd0d877339-2] [ae8f5ba9] [5256352b] [c7fa06f2] [6fcdba99] [f0879eb8] [e9aa7758] [c53ea39c] [0f67f80d] [4358bbd4] [51cd3658] [dda9c8be] [55a36081] [7cfa64ae] [dcd2168f] [14c9e3d0] [9d273a80] [43c71c60] [4a661b75] [6a6afc26] [bb91fb20711fda29] [1eb3105e] [59a3c035] [572a9146] [a0033136] [9cde4913] [f16def0d] [4e0e04c9] [9c9d49e0] [91bbea73] [9ea00dc5] [6d8e9208] [d1bd9d0b] [52de68c2] [d5882157dc780592] [3c80bde9] [26948de8] [7112719f] [77b9525b] [81bec9f6] [2a042191630e69fa] [071de544] [bd908a20] [96461863] [bb459a53] [d403b3ab] [b4ab9c90] [79922f8a] [2687a5da] [70c1e577] [248c277e] [72cc687f]
