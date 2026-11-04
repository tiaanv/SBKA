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
  <a href="https://github.com/AJCrowley/SBKA-Plus">
    <img src="./SBKA/Resources/soundbar_line_w.png" alt="Logo" width="200" height="200">
  </a>  
  <h3 align="center">SBKA</h3>

  <p align="center">
   A simple utility to keep your soundbar awake forked from <a href="https://github.com/tiaanv/SBKA/blob/master/SBKA">SBKA</a> by <a href="https://github.com/tiaanv/">tiaanv</a>.
    <br />
    <a href="https://github.com/tiaanv/SBKA/issues">Report Bug</a>
    ·
    <a href="https://github.com/tiaanv/SBKA/issues">Request Feature</a>
  </p>
</div>


<a href="https://github.com/tiaanv/SBKA/blob/master/SBKA">
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

I recently got a new sound bar. It sounds great, there's just one issue. It has an *obnoxiously aggressive* power saving firmware that offers me no control over it. What this means for me in practical terms:

- If no sound comes from the TV for 15 minutes, the sound bar will go into standby, cycling my TV screen with it through the HDMI CEC connection, leaving me with a black screen for several seconds
- It has precisely zero qualms about aggressively cycling my TV screen when I'm playing Helldivers with my friends and wearing headphones. Think it'll just hit you once when it goes into standby? Guess again!
- I have tried every single *sound bar keepy uppy* program there is, and none of them worked
- Another delightful side effect of this manic power saving is that because my computer is outputting Dolby audio, the sound bar won't keep a stream open, so whatever I play, I have to wait about 5 seconds for the audio to kick in
- The sound bar sounds really great, and I'm not going back to the one that just worked and didn't give me a hard time

I had three options:
- Deal with the incessant annoyance of a soundbar that randomly turns my TV screen off while I'm doing things
- Use a TOSLink cable or disable HDMI CEC on my TV, and have more remotes to deal with
- Take the best of the dozen or more *please don't let my sound bar sleep*, learn C# in an evening, and spend said evening making the adjustments that I desired

I had a sense that the issue was either that the tones played by all of the apps were either too quiet, or too short, and it wasn't enough to keep my sound bar awake.

<a href="https://github.com/tiaanv/SBKA/blob/master/SBKA">SBKA</a> was the best of these applications, because it didn't just fart out a noise on a timer, it actually monitored when Windows last made a sound, and only sends a keep alive signal if necessary. This set it apart from the competition. I needed to add features to play with to figure out a way to keep my narcoleptic sound bar going, so I added:

- Choose between 44.1 and 48KHz, because why not?
- Give you control of the general frequency range of the tone generated. You can have a little rumble, or a big beep
- Choose the duration of the sound generated so that slow to pick up sound bars have time to realise that somebody is trying to put audio through them
- A delightful selection of icons to choose from, all based on the original by <a href="https://github.com/tiaanv/">tiaanv</a>
- Now you can click the systray icon with the left or the right mouse button to open the menu
- A nice little check box that you can compulisvely check and uncheck to get the program to start with windows, or not

It is my hope that this program will now serve to handle even the most stubborn of sound bars. I hope that somebody finds it useful. Please use and enjoy it, be nice and support me and <a href="https://github.com/tiaanv/">tiaanv</a>, have fun!

Is sound bar one or two words? I can't tell. I can't even be consistent in my own documentation. I yield the floor to the author of the original software:

---

I recently started using an old soundbar as my speakers for my PC.  Only to realise it has an "auto sleep" function that I cannot adjust or disable.  The workaround for this would be to simply make sure that audio is sent to the sound output before it goes to sleep.
I did find one alternative app searching the web, but I did not want to download and install it, since both Chrome and Windows identified it as having a Trojan.  Might be a false alarm, but I'd rather not take the chance. 

I figured, I might as well just create my own, and make some improvements to the existing app (as described).

This little app does the following:
* Monitors audio levels on the default output device, and if no output is detected in a 10-minute period, it will play a sound.
* The Sound is not an embedded wave file, but the waveform is generated in code.  Saves some size, and makes it more flexible
* The sound is a 10Hz sine wave, imperceptible to human hearing (for most).
* To sound volume is ramped up, and then down, to make sure there are no START/STOP "pops". Some digital devices will manifest this.
* The app has a Tray Icon and a Settings window. See Getting Started below for details


<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- GETTING STARTED -->
## Getting Started

Download the Zip File containing the latest [Release](https://github.com/tiaanv/SBKA/releases), or get the source, and build it yourself.
Run the app.  You may also add a shortcut to your Windows startup folder.

When you run the app, it will immediately start working. An icon will appear in the Tray Icons list.  Right-clicking on the Tray Icon presents a menu. from here you can:
* Exit -> Close the application
* Settings -> Presents the Settings window:
  * Shows the last time sound was detected, and the last time sound was played
  * Shows a small VU meter to show detected output. Good for identifying the correct device.
  * You can Test the Sound output (this is at 100Hz, so you can hear it).
  * You can change the Output device to a specific (not Default) device. This is handy if you have the soundbar connected to an output, but sometimes plug headphones in. This way you can ensure the sound is played through the soundbar.
  * You can select to bypass the sound detection detection, and just play the sound irrespectively at the set interval
  * You can choose to disable sound if your monitors are off (sleep)
  * You can choose to disable sound if your computer/station is locked
  * You can set output volume boost from 1 to 4.  This is experimental, to assist some speakers not responding.
  * You can set the interval (in seconds) at which sound is played.*   

### Installation


1. This is a Portable App, so no installation is required.
2. Simply copy all the files into a folder on your computer and run it from there.
<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- ROADMAP -->
## Roadmap

- [x] Generate Waveform and Play
- [x] Detect Sound
- [x] Add Settings
- [ ] Create Installer - CANCELLED (App is now single portable EXE)

See the [open issues](https:///github.com/tiaanv/SBKA/issues) for a full list of proposed features (and known issues).

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- CONTRIBUTING -->
## Contributing

Contributions are what makes the open-source community such an amazing place to learn, inspire, and create. Any contributions you make are **greatly appreciated**.

If you have a suggestion that would make this better, please fork the repo and create a pull request. You can also simply open an issue with the tag "enhancement".
Don't forget to give the project a star! Thanks again!

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

<p align="right">(<a href="#readme-top">back to top</a>)</p>



## Support

Enjoying the project? [Buy me a beer 🍺](https://ko-fi.com/tiaanvee).
Always appreciated, never expected.

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

