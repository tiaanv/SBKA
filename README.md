<!-- Improved compatibility of back to top link: See: https://github.com/othneildrew/Best-README-Template/pull/73 -->
<a name="readme-top"></a>
<!--
*** Thanks for checking out the Best-README-Template. If you have a suggestion
*** that would make this better, please fork the repo and create a pull request
*** or simply open an issue with the tag "enhancement".
*** Don't forget to give the project a star!
*** Thanks again! Now go create something AMAZING! :D
-->

<!-- PROJECT LOGO -->
<br />
<div align="center">
  <a href="https://github.com/tiaanv/SBKA/blob/master/SBKA">
    <img src="/SBKA/soundbar.png" alt="Logo" width="80" height="80">
  </a>  
  <h3 align="center">SBKA</h3>

  <p align="center">
   A simple utility to keep your soundbar awake
    <br />
    <a href="https://github.com/tiaanv/SBKA/issues">Report Bug</a>
    ·
    <a href="https://github.com/tiaanv/SBKA/issues">Request Feature</a>
  </p>
</div>



<!-- TABLE OF CONTENTS -->
<details>
  <summary>Table of Contents</summary>
  <ol>
    <li>
      <a href="#about-the-project">About The Project</a>
      <ul>
        <li><a href="#built-with">Built With</a></li>
      </ul>
    </li>
    <li>
      <a href="#getting-started">Getting Started</a>
      <ul>
        <li><a href="#prerequisites">Prerequisites</a></li>
        <li><a href="#installation">Installation</a></li>
      </ul>
    </li>
    <li><a href="#usage">Usage</a></li>
    <li><a href="#roadmap">Roadmap</a></li>
    <li><a href="#contributing">Contributing</a></li>
    <li><a href="#license">License</a></li>
    <li><a href="#acknowledgments">Acknowledgments</a></li>
  </ol>
</details>



<!-- ABOUT THE PROJECT -->
## About The Project

I recently started using an old soundbar as my speakers for my PC.  Only to realise it has an "auto sleep" function that I cannot adjust or disable.  The workaround for this would be to simply make sure that audio is sent to the sound output before it goes to sleep.
I did find one alternative app searching the web, but I did not want to download and install it, since both Chrome and Windows identified it as having a Trojan.  Might be a false alarm, but I'd rather not take the chance. 

I figured, I might as well just create my own, and make some improvements to the existing app (as described).

This little app does the following:
* Monitors audio levels on the default output device, and if no output is detected in a 10-minute period, it will play a sound.
* The Sound is not an embedded wave file, but the waveform is generated in code.  Saves some size, and makes it more flexible
* The sound is a 10Hz sine wave, imperceptible to human hearing (for most).
* To sound volume is ramped up, and then down, to make sure there are no START/STOP "pops". Some digital devices will manifest this.
* The app has a Tray Icon, and a Settings window (nothing in there yet)

<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- GETTING STARTED -->
## Getting Started

Download the Zip File containing the latest [Release](https://github.com/tiaanv/SBKA/releases), or get the source, and build it yourself.
Run the app.  You may also add a shortcut to your windows startup folder..

When you run the app, it will immediately start working. a Icon will appear in Tray Icons list.  Right Clicking on the Tray Icon presents a menu. from here you can:
* Exit -> Close the application
* Settings -> Presents the Settings window. This only shows the last time sound was detected, and the last time sound was played (for now).  Will add settings if it gets requested by users.

### Installation


1. This is a Portable App, so no installation is required.
2. Simply copy all the files into a folder on your computer an run it from there.
<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- ROADMAP -->
## Roadmap

- [x] Generate Waveform and Play
- [x] Detect Sound
- [ ] Add Settings
- [ ] Create Installer

See the [open issues](https:///github.com/tiaanv/SBKA/issues) for a full list of proposed features (and known issues).

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- CONTRIBUTING -->
## Contributing

Contributions are what makes the open source community such an amazing place to learn, inspire, and create. Any contributions you make are **greatly appreciated**.

If you have a suggestion that would make this better, please fork the repo and create a pull request. You can also simply open an issue with the tag "enhancement".
Don't forget to give the project a star! Thanks again!

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- LICENSE -->
## License

Distributed under the MIT License. See `LICENSE.txt` for more information.

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- ACKNOWLEDGMENTS -->
## Acknowledgments

Code from the following Github project was used in this project

* [Generate Sine Waveform](https://stackoverflow.com/questions/203890/creating-sine-or-square-wave-in-c-sharp)
* [Sound Detection](https://github.com/RudiHansen/TestSoundDetection)
* [Inspiration (Rejzor)](https://rejzor.wordpress.com/soundbar-standby-blocker).

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[contributors-shield]: https://img.shields.io/github/contributors/othneildrew/Best-README-Template.svg?style=for-the-badge
[contributors-url]: [https://github.com/othneildrew/Best-README-Template](https:///github.com/tiaanv/SBKA)/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/othneildrew/Best-README-Template.svg?style=for-the-badge
[forks-url]: https://github.com/othneildrew/Best-README-Template/network/members
[stars-shield]: https://img.shields.io/github/stars/othneildrew/Best-README-Template.svg?style=for-the-badge
[stars-url]: https://github.com/othneildrew/Best-README-Template/stargazers
[issues-shield]: https://img.shields.io/github/issues/othneildrew/Best-README-Template.svg?style=for-the-badge
[issues-url]: https://github.com/othneildrew/Best-README-Template/issues
[license-shield]: https://img.shields.io/github/license/othneildrew/Best-README-Template.svg?style=for-the-badge
[license-url]: https://github.com/othneildrew/Best-README-Template/blob/master/LICENSE.txt
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://linkedin.com/in/othneildrew
[product-screenshot]: images/screenshot.png

