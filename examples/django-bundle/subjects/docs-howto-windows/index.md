# docs/howto/windows

- Subject: docs/howto/windows (id `c43d2f68-4514-4e40-833f-21060477ad15`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 1859 tokens
- Facts shown: 47 of 47
- Conflicts: 0
- Gaps: 0

## Highlights

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

## All facts

- [3e92fc47] About ``pip`` =============
- [720177ba] After installation, open the command prompt and check that the Python version matches the version you installed by executing:
- [0f8d7efb] After the installation has completed, you can verify your Django installation by executing ``django-admin --version`` in the command prompt.
- [bdfdbb95] Colored terminal output =======================
- [a0cf6273] Common pitfalls ===============
- [8df366e4] Django can be installed easily using ``pip`` within your virtual environment.
- [6ffbde30] Django is a Python web framework, thus requiring Python to be installed on your machine. At the time of writing, Python 3.15 is the latest version.
- [a926a9fe] In the command prompt, ensure your virtual environment is active, and execute the following command:
- [353315ce348b58ea] Install Django ==============
- [4426f6e8c58b3926] Install Python ==============
- [a967515c] It is best practice to provide a dedicated environment for each Django project you create. There are many options to manage environments and packages within the Python ecosystem, some of which are recommended in the `Python documentation <https://packaging.python.org/guides/tool-recommendations/>`_. Python itself comes with :doc:`venv <python:tutorial/venv>` for managing environments which we will use for this guide.
- [d301115c] On older Windows versions, or legacy terminals, :pypi:`colorama` 0.4.6+ must be installed to enable syntax coloring:
- [85977fdf] See :ref:`database-installation` for information on database installation with Django.
- [5893f074] See :ref:`syntax-coloring` for more information on color settings.
- [31133dd9] Setting up a virtual environment ================================
- [c39f597b] The steps in this guide have been tested with Windows 10. In other versions, the steps would be similar. You will need to be familiar with using the Windows command prompt.
- [32e0d629] The virtual environment will be activated and you'll see "(project-name)" next to the command prompt to designate that. Each time you start a new command prompt, you'll need to activate the environment again.
- [d55d14c1] This document will guide you through installing Python 3.15 and Django on Windows. It also provides instructions for setting up a virtual environment, which makes it easier to work on Python projects. This is meant as a beginner's guide for users working on Django projects and does not reflect how Django should be installed when developing changes for Django itself.
- [a1917200] This will create a folder called 'project-name' if it does not already exist and set up the virtual environment. To activate the environment, run:
- [dbb46eaa] This will download and install the latest Django release.
- [cca6d521] To create a virtual environment for your project, open a new command prompt, navigate to the folder where you want to create your project and then enter the following:
- [3d632d7a] To install Python on your machine go to https://www.python.org/downloads/. The website should offer you a download button for the latest Python version. Download the executable installer and run it. Check the boxes next to "Install launcher for all users (recommended)" then click "Install Now".
