# docs/howto/windows

- Subject: docs/howto/windows (id `202d148b-f420-4f01-a090-9d9682e2d46b`)
- Kind: subject
- Budget: 1200 tokens
- Used: 889 tokens
- Facts shown: 25 of 47
- Conflicts: 0
- Gaps: 0

## Facts

- ...\> project-name\Scripts\activate.bat [990a3795]
- ...\> py --version [43239ff5]
- ...\> py -m pip install "colorama >= 0.4.6" [b3f064cc05979b4b]
- ...\> py -m pip install Django [142ff5ff]
- ...\> py -m venv project-name [35c74fc5]
- ...\> set http_proxy=http://username:password@proxyserver:proxyport ...\> set https_proxy=https://username:password@proxyserver:proxyport [ec46a5ab]
- Depending on how you've installed Python (such as via the Microsoft Store), ``py`` may not be available in the command prompt. [e88238b6]
- For more details, see :doc:`python:using/windows` documentation. [85b0a78f]
- You will then need to use ``python`` instead of ``py`` when entering commands. [5301c10e]
- .. code-block:: doscon [423631a5927aaff7]
- * If ``django-admin`` only displays the help text no matter what arguments it is given, there is probably a problem with the file association in Windows. Check if there is more than one environment variable set for running Python scripts in ``PATH``. This usually occurs when there is more than one Python version installed. [70e244ec]
- * If you are connecting to the internet behind a proxy, there might be problems in running the command ``py -m pip install Django``. Set the environment variables for proxy configuration in the command prompt as follows: [5b0dd79f]
- * In general, Django assumes that ``UTF-8`` encoding is used for I/O. This may cause problems if your system is set to use a different encoding. Recent versions of Python allow setting the :envvar:`PYTHONUTF8` environment variable in order to force a ``UTF-8`` encoding. Windows 10 also provides a system-wide setting by checking ``Use Unicode UTF-8 for worldwide language support`` in :menuselection:`Language --> Administrative Language Settings --> Change system locale` in system settings. [9f1f8ce1]
- .. _install_python_windows: [7e6145a9]
- .. _virtualenvironment: [c2825365]
- .. admonition:: ``py`` is not recognized or found [68ce0b38]
- .. code-block:: doscon [423631a5927aaff7-2]
- .. code-block:: doscon [423631a5927aaff7-3]
- .. code-block:: doscon [423631a5927aaff7-4]
- .. code-block:: doscon [423631a5927aaff7-5]
- .. code-block:: doscon [423631a5927aaff7-6]
- .. seealso:: [6b4a5e54e001d097-11]
- :pypi:`pip` is a package manager for Python and is included by default with the Python installer. It helps to install and uninstall Python packages (such as Django!). For the rest of the installation, we'll use ``pip`` to install Python packages from the command line. [6cb39581]
- ================================ How to install Django on Windows ================================ [1809ba92]
- A quality-of-life feature adds colored (rather than monochrome) output to the terminal. In modern terminals this should work for both CMD and PowerShell. If for some reason this needs to be disabled, set the environmental variable :envvar:`DJANGO_COLORS` to ``nocolor``. [599c74e2]

## Beyond the budget

22 more facts did not fit in the budget: [3e92fc47] [720177ba] [0f8d7efb] [bdfdbb95] [a0cf6273] [8df366e4] [6ffbde30] [a926a9fe] [353315ce348b58ea] [4426f6e8c58b3926] [a967515c] [d301115c] [85977fdf] [5893f074] [31133dd9] [c39f597b] [32e0d629] [d55d14c1] [a1917200] [dbb46eaa] [cca6d521] [3d632d7a]
