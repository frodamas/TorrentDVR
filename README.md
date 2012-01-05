#Overview
TorrentDVR in its simplest form copies TV shows and movie files from a remote server to a local storage location where the video file can be played back. However, it is more than a simple file sync. Instead, it recognizes the standard naming convention for TV show files to intellegently track TV show names, seasons, and episodes. This allows for a more intellegent tracking and syncing of your files.

Some of the features include the automatic creation of folder structures for each TV show, prevention of downloading duplicate episodes, and one-time download of episodes, even if it is later removed locally, but still exists on the remote server.

##TV SHOWS
TV shows are identified by the file name having one of the following season/episode naming patterns:

* S??E??
* s??e??
* S?? E??
* .?X??.
* .?x??.
* .??X??.
* .??x??.

*Note the '?' is a single character wildcard. In this case, it must be a numeric value from 0 to 9.*

Additionally, the file name must end in one of the predefined, but modifiable, file extensions. The default list is:
> mkv, avi, mp4, mpeg, or wmv