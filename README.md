### **Game Design Document**

##
**&quot;Will of Steel&quot;**

Game Title: **Will of Steel**

Design By: **Fine Motion Studio**

Ferdinand Wijaya S (18/425308/TK/47003)

Kori Pepadhang (18/425312/TK/47007)

Ignatius Aurora A S (18/429069/TK/47571)

Genre: **Strategy, Tower Defense**

Platform: **Desktop**

Target Age: **15-21**

Rating: **E10**

#
### **Story and Gameplay**

Prodi TE, TI, dan TB saling berkolaborasi mengembangkan robot untuk menunjang perawatan medis di seluruh dunia. Tanpa sepengetahuan tim pengembang, robot medis telah diretas oleh kelompok teroris berideologi radikal. Kini robot tersebut justru ingin memusnahkan umat manusia. Tim pengembang pun tidak mau tinggal diam dan melihat dunia dihancurkan oleh ciptaannya, maka mereka membangun _tower_ untuk melawan para robot.

Pemain membuat sebuah sistem pertahanan yang terdiri dari gabungan _tower_ TE, TI, dan TB. Setiap gelombang memiliki set musuh tersendiri. Untuk mengalahkan musuh-musuh, pemain dapat meningkatkan _tower_ sesuai dengan kemauannya. Setiap kali musuh dikalahkan, musuh akan menjatuhkan material untuk meningkatkan _tower_ tersebut. Semakin tinggi _level_ gelombang, semakin bervariasi tipe musuh dan semakin rumit. Setelah 25 _level_, pemain akan melawan _boss_ musuh untuk dapat melanjutkan kegelombang selanjutnya dengan _level_ 75 sebagai _level_ maksimum.

#
### **Game Flow**

Saat pertama kali bermain Will of Steel, terdapat tutorial yang mengenalkan pemain dengan lingkungan dalam permainan, seperti medan area permainan, objektif permainan, dan _head-up display_ (HUD) permainan. Pemain diberikan sedikit arahan strategi yang efektif pada peta yang dimainkan di awal. Perkenalan terhadap jenis-jenis _tower_ juga diberikan di awal sehingga pemain dapat mencoba-coba kombinasi _tower_ yang beragam.

Jenis-jenis musuh dikenalkan pada pertengahan permainan. Setelah beberapa level, suatu jenis musuh baru dikenalkan dan diberikan juga strategi yang dapat digunakan untuk mengalahkan musuh tersebut. Pemain dapat meningkatkan kapabilitas markas utama dan _tower_ dengan cara membeli _upgrade_ permanen menggunakan kepingan logam. Kepingan logam didapatkan setiap kali pemain menyelesaikan 5 _level_ pada _endless mode_. _Upgrade_ permanen yang ditawarkan dapat berupa _health point_ markas utama, kemampuan serangan semua _tower_, atau melemahkan musuh di awal _level_.

Ketika permainan selesai, pemain akan diberikan skor total yang didapatkan selama permainan berlangsung. Skor yang tinggi dapat dibuat menjadi patokan baru sebagai skor yang dapat dikalahkan sebagai _personal achievement_. Skor juga bisa dijadikan sebagai metode untuk menganalisis strategi yang digunakan untuk mengalahkan permainan sebelumnya dan mencoba mengembangkan strategi tersebut untuk menjadi lebih efektif.

#
### **Character and Controllers**

**Character:**

Pemain dapat mengendalikan pengelolaan _tower_ yang dibangun oleh tim pengembang dari prodi TE, TI, dan TB. Pemain memilih lokasi pembangunan dan aspek yang ingin ditingkatkan (_upgrade_) terlebih dahulu pada _tower_, seperti frekuensi, durasi, dan jangkauan serangan, untuk dapat mengalahkan gelombang musuh. _Tower_ juga memiliki serangan khusus (_special attack_) dengan kekuatan dan jangkauan yang lebih besar dari serangan biasa, tetapi memakan waktu jeda (_cooldown time_) untuk dapat digunakan. Waktu jeda ini dapat berkurang seiring peningkatan kemampuan _tower_ yang dipilih pemain. _Tower_ terbagi menjadi tiga jenis, yaitu _tower_ TI, _tower_ TE, dan _tower_ TB, yang selalu ada di setiap _level_ permainan. Setiap _tower_ memiliki kemampuan spesialnya masing-masing:

- _Tower_ TE memiliki fungsi utama melakukan penyerangan kepada musuh (_attack_).
- _Tower_ TI memiliki fokus utama menguatkan serangan dan pertahanan pemain (_buff_).
- _Tower_ TB memiliki fokus utama melemahkan serangan dan pertahanan musuh (_debuff_).

**Controller:**

Pengaturan _tower_ dapat dilakukan dengan klik tetikus (_mouse click_). Pemetaan fungsi tombol pada _mouse_ diilustrasikan pada gambar di bawah ini.

![](https://github.com/ignatiusaas/will-of-steel/blob/ae2b513c1a846b23e73c602a8797ef9ffb82c3f7/README%20imgs/1.png)

#
### **Main Game Play**

Permainan Will of Steel berfokus pada strategi dan _tower defense_ di mana pemain ditantang untuk menentukan lokasi pembangunan _tower_ yang strategis dan melakukan manajemen sumber daya (_electric point_) untuk melakukan peningkatan pada _tower_ agar dapat mengalahkan gelombang musuh yang menyerangnya secara bertahap pada setiap _level_. Pemain disediakan berbagai pilihan peningkatan (_upgrade path_) _tower_ sehingga banyak solusi yang dapat diberikan untuk menyelesaikan satu _level_. Mekanisme permainan cukup sederhana karena pemain hanya perlu memilih peningkatan _tower_ yang diinginkan sehingga mudah untuk dipelajari oleh pemain baru, akan tetapi mekanisme ini membutuhkan penguasaan yang baik agar dapat menyusun strategi yang optimal untuk mengalahkan gelombang-gelombang musuh. Keunikan lain dari permainan Will of Steeladalah dapat dimainkan secara luring (_offline_) sehingga tidak memakan kuota internet dan membebani jaringan. Permainan juga menyediakan mode tanpa akhir (_endless mode_) yang memberikan tantangan tersendiri bagi pemain.

![](https://github.com/ignatiusaas/will-of-steel/blob/ae2b513c1a846b23e73c602a8797ef9ffb82c3f7/README%20imgs/2.png)

**(Ilustrasi di atas tidak menggambarkan produk akhir)**

Ilustrasi di atas menggambarkan konsep desain visual saat pemain memainkan suatu _level_. Pada permainan, _tower_ dapat diletakkan pada bagian lingkaran abu-abu dengan garis putus-putus. Terdapat tiga jenis _tower_ yang dapat diletakkan pada bagian tersebut. _Tower_ TB ditandakan dengan lingkaran berwarna ungu. _Tower_ TE ditandakan dengan lingkaran berwarna biru. _Tower_ TI ditandakan dengan lingkaran berwarna oranye. Ketiga _tower_ dapat diletakkan dengan menggunakan 25 poin energi. Poin energi ditandakan dengan lambang petir berwarna kuning pada pojok kiri atas.

_Tower_-_tower_ yang telah diletakkan kemudian akan menyerang musuh yang datang untuk menghancurkan markas. Musuh ditandakan dengan lingkaran berwarna abu-abu. Musuh mengikuti jalur khusus yang ditandakan dengan garis merah yang memiliki panah untuk menunjukkan arah jalur tersebut. Apabila musuh mencapai markas, maka _health point_ markas akan berkurang. _Health point_ markas ditandakan dengan lambang hati berwarna merah.

Dalam permainan terdapat tombol untuk menghentikan permainan sementara (_pause_) yang ditandakan dengan lingkaran berisi dua garis sejajar. Pemain dapat keluar dari permainan yang berlangsung pada menu &quot;Pause&quot;. Pemain juga dapat mempercepat permainan dengan menggunakan tombol &quot;Fast Forward&quot; yang ditandakan dengan lingkaran berisi dua panah sejajar yang mengarah ke kanan. Pada bagian tengah atas terdapat indikasi level pada permainan yang berlangsung.

![](https://github.com/ignatiusaas/will-of-steel/blob/ae2b513c1a846b23e73c602a8797ef9ffb82c3f7/README%20imgs/3.png)

Diagram alur di atas memetakan aktivitas-aktivitas yang mungkin dialami pemain saat memainkan satu _level_ Will of Steel. Setelah memilih memulai _level_ permainan, pemain akan ditampilkan jalur musuh. Pemain kemudian memilih jenis _tower_ yang akan dibangun pada lokasi yang telah disediakan berdasarkan poin energi yang diberikan di awal. Setelah pemain membangun beberapa _tower_, musuh akan mulai memasuki area permainan sesuai jalur yang telah ditentukan. _Tower_ akan mendeteksi musuh dan mulai meluncurkan serangan. Seiring dikalahkannya musuh, pemain akan mengumpulkan poin energi yang dapat digunakan untuk membangun _tower_ baru atau meningkatkan kemampuan _tower_ yang sudah ada. Semakin tinggi kemampuan _tower_, semakin mudah pula musuh dikalahkan. Jika kemampuan _tower_ yang ada tidak berhasil mengalahkan musuh, musuh akan menembus garis pertahanan dan memberikan serangan yang mengurangi _health point_ (HP)markas utama. Jika HP markas utama jatuh hingga nol, pemain akan kalah dan _level_ akan berakhir dengan menampilkan skor yang didapat. Jika HP markas utama masih belum mencapai nol, permainan akan terus berlanjut dengan siklus _tower_ menyerang musuh dan pemain meningkatkan kemampuan _tower_. Jika _tower_ berhasil mengalahkan semua musuh, pemain akan menang dan _level_ juga akan berakhir dengan menampilkan skor yang didapat.

#
### **Game World**

Dalam cerita latar kejadian permainan, robot dibangun oleh tim pengembang dari Departemen Teknik Elektro dan Teknologi Informasi serta Teknik Biomedis (DTETITB) yang juga merancang pembangunan _tower_ untuk mengalahkan robot yang sudah diretas oleh teroris. Mengetahui hal tersebut, teroris memutuskan untuk menyerang langsung ke sumber utama ancaman rencana mereka untuk menguasai dunia. Jadi, kejadian dalam permainan akan berlokasi di lingkungan Fakultas Teknik Universitas Gadjah Mada. Pemain dapat memilih lokasi bagian Fakultas Teknik di mana pertahanan akan dibangun (_hub-style navigation_). Situasi pertarungan antara _tower_ dengan serangan robot berlangsung dengan genting, mencekam, dan intens.

![](https://github.com/ignatiusaas/will-of-steel/blob/ae2b513c1a846b23e73c602a8797ef9ffb82c3f7/README%20imgs/4.png)

Diagram alur di atas mengilustrasikan urutan pemilihan peta dan proses permainan. Saat memulai permainan baru, akan muncul halaman daftar peta yang berisi _level_ permainan. Pemain diharuskan memilih peta yang ingin dimainkan yang akan memunculkan detail peta dan konfirmasi apakah pemain ingin langsung memulai permainan. Jika tidak, pemain akan dibawa kembali ke halaman daftar peta. Jika pemain setuju, pemain akan dibawa ke halaman permainan dan dapat mulai bermain. Setelah permainan pada peta tersebut selesai, maka akan muncul tampilan mengenai skor yang didapat selama permainan berlangsung, jika menang, peta baru akan terbuka dan pemain dibawa kembali ke halaman daftar peta, akan tetapi pemain harus mengulang peta yang dimainkan apabila pemain kalah pada saat bermain pada peta tersebut. Jika pemain tidak ingin mengulang, maka pemain akan dibawa kembali ke halaman daftar peta. Selain itu, pemain juga dapat mengulang peta yang pernah dimainkan, hanya saja saat pemain menang pada peta tersebut, peta baru tidak akan terbuka.

#
### **Interface**

**Navigate** :

Pemain dapat mengakses antarmuka permainan mengklik tetikus (_mouse click_) pada area yang diinginkan. Pemain juga dapat menggunakan metode _drag-and-drop_ untuk memasang _tower_ pada lokasi yang disediakan.

**Mood:**

Will of Steel berceritakan tentang pertarungan sengit antara pihak teroris dan tim pengembang. Oleh karena itu, nuansa antarmuka permainan akan bertemakan teknologi, futuristik, _metal_, _mecha_, elektronik, kelistrikan, dan sirkuit. Nuansa antarmuka juga akan disesuaikan dengan target usia pemain dan _rating_ permainan, sehingga cenderung mengadopsi gaya desain kartun agar suasana permainan terkesan ringan dan menyenangkan.

**Music:**

Musik latar permainan juga menyesuaikan tema dan latar cerita sehingga menggunakan musik-musik bernuansa tekno dan elektronik dengan nada _upbeat_ yang membangkitkan suasana permainan dan memompa adrenalin agar meningkatkan motivasi pemain.

**Flow diagram:**

![](https://github.com/ignatiusaas/will-of-steel/blob/ae2b513c1a846b23e73c602a8797ef9ffb82c3f7/README%20imgs/5.png)

Diagram alur di atas memetakan pilihan-pilihan yang dapat diambil oleh pemain dalam aplikasi permainan. Saat pertama kali pemain menjalankan permainan, akan muncul _title screen_ yang diikuti dengan menu utama. Pada menu utama terdapat tiga opsi, yaitu &quot;Play&quot;, &quot;Settings&quot;, &quot;Store&quot;, dan &quot;Exit&quot;. Opsi &quot;Play&quot; akan mengarahkan pemain ke tampilan pemilihan permainan. Opsi &quot;Settings&quot; akan mengarahkan pemain ke menu konfigurasi di mana pemain dapat mengkonfigurasi grafik, suara, dan konfigurasi permainan lainnya. Opsi &quot;Store&quot; akan mengarahkan pemain kepada tempat di mana pemain dapat membeli _upgrade_ permanen dengan menggunakan kepingan logam yang didapatkan dari _endless mode_. Opsi &quot;Exit&quot; akan mengarahkan pemain keluar dari permainan.

Pada tampilan pemilihan permainan awal terdapat dua opsi, yaitu &quot;Load Game&quot; dan &quot;New Game&quot;. Apabila pemain memilih &quot;New Game&quot;, pemain akan diarahkan ke seleksi peta yang akan digunakan. Apabila pemain memilih &quot;Load Game&quot;, pemain akan diarahkan ke seleksi sesi permainan yang sebelumnya sudah pernah disimpan namun belum selesai. Setelah memilih peta atau sesi permainan yang disimpan, pemain akan diarahkan ke permainan utama. Ketika permainan selesai, permainan akan menampilkan hasil skor yang didapatkan pemain dan kembali ke seleksi peta.

#
### **Game Mechanic**

Permainan Will of Steel adalah permainan yang memiliki sudut pandang model _top-view_ 2D. Aspek 2D terdapat pada seluruh elemen dalam permainan hingga medan atau peta yang dimainkan. Permainan ini dimainkan secara _real time_, sehingga diperlukan _pre-planning_ sebelum musuh datang. Karena jalur dapat terlihat secara utuh pada layar, antarmuka tidak memerlukan peta kecil (_minimap_) untuk membantu navigasi.

Pemain disediakan berbagai pilihan peningkatan (_upgrade path_) _tower_ sehingga banyak solusi yang dapat diberikan untuk menyelesaikan satu level. Mekanisme permainan cukup sederhana karena pemain hanya perlu memilih peningkatan _tower_ yang diinginkan sehingga mudah untuk dipelajari oleh pemain baru, akan tetapi mekanisme ini membutuhkan penguasaan yang baik agar dapat menyusun strategi yang optimal untuk mengalahkan gelombang-gelombang musuh yang beragam.

Pada permainan, terdapat tiga jenis _tower_ yang dapat diletakkan pada bagian yang sudah ditentukan sebelumnya. _Tower_ tersebut adalah TB, TE, TI. Masing-masing _tower_ dapat diletakkan dengan menggunakan 25 poin energi. _Tower-tower_ yang telah diletakkan akan digunakan untuk menyerang musuh yang datang untuk menghancurkan markas pada jalur yang sudah ditentukan. Apabila musuh mencapai markas, maka _health point_ markas akan berkurang. Ada berbagai jenis musuh dan _boss_ yang terdapat pada permainan.

Ketika pemain telah mencapai level 75, pemain dapat terus melanjutkan permainannya pada _endless mode_. Setiap kali pemain menyelesaikan 5 level pada _endless mode_, pemain akan mendapatkan kepingan logam untuk membuka kemampuan baru secara terpisah, seperti menambah _health point_ markas utama, kemampuan serangan semua _tower_, dan melemahkan musuh di awal _level_.

#
### **Enemies and Bosses**

Musuh utama dalam permainan ini adalah robot hasil retasan kelompok teroris, di mana telah dimodifikasi sehingga memiliki fungsi dan kemampuan yang berbeda dari tujuan awal tim pengembang. Terdapat empat jenis robot penyerang ganas dalam permainan:

- _ **Regular** _ **:** Robot dengan _health point_ sebanyak 5 HP dan serangan setinggi 2 poin. Apabila dikalahkan, robot akan menjatuhkan 5 poin energi.
- _ **Fast** _ **:** Robot dengan _health point_ sebanyak 4 HP dan serangan setinggi 2 poin. Robot ini memiliki kecepatan 175% dari kecepatan robot regular. Apabila dikalahkan, robot akan menjatuhkan 7 poin energi.
- _ **Tank:** _ Robot dengan _health point_ sebanyak 10 HP dan serangan setinggi 3 poin. Robot ini memiliki kecepatan 50% dari kecepatan robot regular. Apabila dikalahkan, robot akan menjatuhkan 7 poin energi.
- _ **Camouflage** _ **:** Robot dengan _health point_ sebanyak 5 HP dan serangan setinggi 3 poin. Robot ini hanya dapat ditarget oleh _tower_ yang memiliki deteksi _camo_. Apabila dikalahkan, robot akan menjatuhkan 7 poin energi.

_Health point,_ serangan, dan energi yang dijatuhkan oleh robot akan meningkat sebesar 5% setiap ronde yang berlangsung (5% pada ronde kedua, 10% pada ronde ketiga, 15% pada ronde keempat, dan seterusnya).

Pemain akan berhadapan dengan bos, yakni robot berkekuatan tinggi dengan kemampuan khusus, ketika mencapai level 25, 50, dan 75. Spesifikasi setiap bos adalah berikut.

**Lower Boss** :

- Dihadapi pada saat pemain mencapai _level_ 25.
- Memiliki _health point_ sebanyak 100 HP, kekuatan serangan 60 poin, dan kecepatan 50% dari robot _regular_.
- Saat dikalahkan, _lower boss_ akan terpecah menjadi 2 robot dirinya yang berukuran setengah kali semula dengan _health point_ sebanyak 50 HP, serangan 30 poin, dan kecepatan 75% dari robot regular.
- Apabila kedua robot telah dikalahkan, robot akan terbagi lagi menjadi 2 robot dirinya yang berukuran setengah kali sebelumnya (seperempat kali semula) dengan _health point_ sebanyak 25 HP, serangan 15 poin, dan memiliki kecepatan yang sama dengan robot regular.
- Setiap kali dikalahkan, robot _lower boss_ akan menjatuhkan 15 poin energi.

**Middle Boss** :

- Dihadapi pada saat pemain mencapai _level_ 50.
- Memiliki _health point_ sebanyak 200 HP, kekuatan serangan 250 poin, dan kecepatan 50% dari robot _regular_.
- Ketika diserang, _middle boss_ dapat memanggil robot-robot _regular_ untuk membantunya menyerang pertahanan _tower_ pemain.
- Apabila dikalahkan, robot _middle boss_ akan menjatuhkan 80 poin energi.

**Final Boss** :

- Dihadapi pada saat pemain mencapai _level_ final, yakni _level_ 75.
- Merupakan robot raksasa yang dikendarai oleh si teroris.
- Memiliki _health point_ sebanyak 1100 HP, kekuatan serangan 500 poin, dan kecepatan 40% dari robot regular.
- Serangan _Final Boss_ terdiri dari dua fase:
  - Fase 1: Bos memanggil robot-robot secara acak dan meningkatkan serangan serta pertahanannya (_buffing_).
  - Fase 2: Ketika _health point_ sudah mencapai 25% semula, bos akan melakukan serangan EMP setiap 10 detik yang akan melumpuhkan _tower_ di jangkauan terdekatselama 3 detik.
- Apabila dikalahkan, _final boss_ akan menjatuhkan 300 poin energi dan medali penamatan permainan.

**How to Win -** Menangkan semua 75 _level_ tanpa _health point_ markas utama mencapai nol. Ketika pemain berhasil menamatkan permainan, ia akan dihadiahi medali dan melihat _cutscene_ akhir cerita.

**How to Lose -** Robot menembus garis pertahanan _tower_ dan menjatuhkan _health point_ markas utama menjadi nol. Jika pemain kalah, akan muncul _game over screen_ dan tawaran untuk mengulang _level_ atau memilih _level_ lain.

#
### **Cutscene and Bonus Materials**

**Cutscene:**

_Cutscene_ adalah narasi cerita pada bagian awal dan akhir permainan yang menunjukkan latar cerita dan kesimpulan permainan (menang/kalah). Narasi diberikan dalam gaya komik (_panel comic_) dengan memberikan perhatian dan efek khusus pada karakter dan kejadian tertentu.

**Bonus Material:**

Setiap kali menyelesaikan 5 level pada _endless mode_, pemain akan mendapatkan sebuah kepingan logam untuk membuka kemampuan baru secara terpisah, seperti menambah _health point_ markas utama, kemampuan serangan semua _tower_, dan melemahkan musuh di awal _level_.

### **Incentive** :

- _Score_: Pemain akan mendapatkan skor setiap mengalahkan musuh.
- _Medal_: Pemain akan mendapatkan trofi setiap menyelesaikan suatu gol.
- _Achievement_: Pemain akan mendapatkan medali saat menamatkan permainan.
- _Endless mode_: Pemain dapat bermain dalam _endless mode_ di mana permainan berjalan dengan kemampuan dan kecepatan musuh yang meningkat terus-menerus hingga pemain kalah. Mode ini memberikan kepingan logam untuk membuka kemampuan baru secara terpisah.

### Competitor:

Arknights, Bloons TD 6, Elements TD 2.
