money = 0
playerX = 800
playerY = 360
fTimer = 0
nextFight = 0
enemyHp = 100
totEnemyHp = enemyHp

playerHp = 100
totPlayerHp = playerHp

playerLvl = 1


class bootScene extends Phaser.Scene
{
    preload()
    {
        this.load.image('player', 'assets/hev.png', { frameWidth: 32, frameHeight: 64 });
        this.load.spritesheet('firegoblin', 'assets/firegoblin.png', { frameWidth: 32, frameHeight: 32 });
        this.load.tilemapTiledJSON('tilemap', 'assets/cityTest.json')
        this.load.image('tile', 'assets/city.png')
        this.load.image('mmapBord', 'assets/miniMapBorder.png')
        this.load.image('forestBg', 'assets/forest.png')
        this.load.image('playButton', 'assets/playButton.png')
        this.load.image('menuButton', 'assets/menuButton.png')
        this.load.image('menuBg', 'assets/menuBg.png')
        this.load.image('resumeButton', 'assets/resumeButton.png')
        this.load.image('spawnButton', 'assets/spawnButton.png')
        this.load.image('fightBg', 'assets/fightBgPix.png')
        this.load.image('healthBg', 'assets/hpBox.png')
        this.load.image('playerHpBg', 'assets/playerBox.png')
        this.load.image('fightBut', 'assets/fightButton.png')
        this.load.image('fireball', 'assets/fireball.png')
        this.load.spritesheet('playerBack', 'assets/playerBack.png', { frameWidth: 32, frameHeight: 64 })

    }

    create()
    {
        this.moneyStr = localStorage.getItem('cash');
        this.xStr = localStorage.getItem('x');
        this.yStr = localStorage.getItem('y');
        playerX = Number(this.xStr)
        playerY = Number(this.yStr)
        
    }

    update () 
    {
        this.scene.launch('mainMenu').stop();
    }
}


class mainMenuScene extends Phaser.Scene
{

    constructor ()
    {
        super('mainMenu');
    }


    create()
    {
        this.add.image(800,450, 'forestBg')
        this.playButton = this.add.image(800,450, 'playButton')

        this.playButton.setInteractive()

        this.playButton.setScale(0.75)

        this.playButton.on('pointerover', ()=> {money = money + 10, this.playButton.setTint(0x51e883)})
        this.playButton.on('pointerout', ()=> {console.log(money),this.playButton.setTint(0xffffff)})
        this.playButton.on('pointerdown', ()=> {this.scene.start('game').launch('hud')})


    }
}

class menuScene extends Phaser.Scene
{

    constructor ()
    {
        super('menu');
    }


    create()
    {
        this.add.image(800,450, 'menuBg')
        this.resumeButton = this.add.image(800,450, 'resumeButton')

        this.resumeButton.setInteractive()

        this.resumeButton.setScale(0.75)

        this.resumeButton.on('pointerover', ()=> {money = money + 10, this.resumeButton.setTint(0x51e883)})
        this.resumeButton.on('pointerout', ()=> {console.log(money),this.resumeButton.setTint(0xffffff)})
        this.resumeButton.on('pointerdown', ()=> {this.scene.start('game').launch('hud')})
    

    }
}

class battleUi extends Phaser.Scene {
    constructor() {
        super('battleUi');
    }
    preload() {}
    create() {

        
        this.good = 0x28de52
        this.med = 0xe1ad01
        this.bad = 0xe60e23

        // this.barHp =
        
        //make 3 bars
        this.enhealthBar = this.makeBar(250,60,this.good,enemyHp,totEnemyHp);
        // this.setValue(this.enhealthBar,enemyHpP);

        this.plyhealthBar=this.makeBar(1045,525,this.good,playerHp,totPlayerHp);
        // this.setValue(this.plyhealthBar,playerHpP);
        this.fireball = this.add.image(410,510,'fireball')
        this.fireball.setScale(1.5)

        this.fbgroup = this.add.group()

        this.fireBallAttack = this.tweens.add({
            targets: this.fireball,
            paused: true,
            x:1100,
            y:100,
            ease: 'Power0',
            duration: 300,
            yoyo: false,
            repeat: 0,
    })

        this.topLeftB = this.add.image(1110,640,'fightBut')
        this.topLeftB.setInteractive()
        

        this.topLeftB.on('pointerover', ()=> {this.topLeftB.setTint(0x51e883)})
        this.topLeftB.on('pointerout', ()=> {this.topLeftB.setTint(0xffffff)})
        this.topLeftB.on('pointerdown', ()=> {this.fireBallAttack.play()})


    }
    makeBar(x, y,color,eneHp,totalHp) {
        //draw the bar
        let bar = this.add.graphics();


        this.perc = (eneHp/totalHp)*100

        //color the bar
        bar.fillStyle(color, 1);

        //fill the bar with a rectangle
        bar.fillRect(0, 0, this.perc*3, 50);
        
        //position the bar
        bar.x = x;
        bar.y = y;

        //return the bar
        return bar;
    }
    setValue(bar,hp,totHp) {
        //scale the bar


        
        this.per = (hp/totHp)*100
        console.log(this.per)

        if(this.per > 1)
        {
            bar.scaleX = this.per/100;
        }

        // if(hp > 1)
        // {

        //     if(name == 'enemy')
        //     {

        //         if(this.per < 50)
        //         {
        //             this.enhealthBar.clear()
        //             this.enhealthBar = this.makeBar(250,60,this.med,hp,totHp)
        //         }

        //         if(this.per < 25)
        //         {
        //             this.enhealthBar.clear()
        //             this.enhealthBar = this.makeBar(250,60,this.bad,hp,totHp)
        //         }
        //     }

        //     if(name = 'player')
        //     {

        //         if(this.per < 50)
        //         {
        //             this.plyhealthBar.clear()
        //             this.plyhealthBar = this.makeBar(250,60,this.med,hp,totHp)
        //         }

        //         if(this.per < 25)
        //         {
        //             this.plyhealthBar.clear()
        //             this.plyhealthBar = this.makeBar(250,60,this.bad,hp,totHp)
        //         }
        //     }
        // }



    }
    update() {
        this.setValue(this.enhealthBar,enemyHp,totEnemyHp,'enemy')

        this.setValue(this.plyhealthBar,playerHp,totPlayerHp,'player')

    }
}



class fightScene extends Phaser.Scene
{

    constructor ()
    {
        super('fight');
    }

    


    create()
    {
        this.enemyLvl = Math.floor((Math.random() * 6) + 5);
        this.playerHealth = 50
        enemyHp = this.enemyLvl*10
        totEnemyHp = enemyHp
        this.goblinHealth = enemyHp
        this.enemy = 'Fire Goblin'

        playerHp = 100


        this.add.image(800,450, 'fightBg')
        this.resumeButton = this.add.image(125,370, 'resumeButton')

        this.resumeButton.setInteractive()

        this.resumeButton.setScale(0.5)

        this.resumeButton.on('pointerover', ()=> {money = money + 10, this.resumeButton.setTint(0x51e883)})
        this.resumeButton.on('pointerout', ()=> {console.log(money),this.resumeButton.setTint(0xffffff)})
        this.resumeButton.on('pointerdown', ()=> {this.scene.start('game').stop('battleUi').launch('hud')})

        this.enemyHealthBg = this.add.image(330,130, 'healthBg')
        this.enemyHealthBg.setDepth(10)
        this.enemyHealthText = this.add.text(115, 155, this.enemy);
        this.enemyHealthText.setTint('#0fffffff')
        this.enemyHealthText.setScale(2)
        this.enemyHealthText.setResolution(3)
        this.enemyHealthText.setDepth(15)

        this.playerHealthBg = this.add.image(800,410, 'playerHpBg')
        this.playerHealthBg.setDepth(10)

        this.playerLvlText = this.add.text(1410,540, playerLvl);
        this.playerLvlText.setTint('#0fffffff')
        this.playerLvlText.setScale(2)
        this.playerLvlText.setResolution(3)
        this.playerLvlText.setDepth(15)

        this.enemyLvlText = this.add.text(420, 155, this.enemyLvl);
        this.enemyLvlText.setTint('#0fffffff')
        this.enemyLvlText.setScale(2)
        this.enemyLvlText.setResolution(3)
        this.enemyLvlText.setDepth(15)
        

        var goblinIdle = 
        {
            key: 'goblinidle',
            frames: this.anims.generateFrameNumbers('firegoblin', { start: 0, end: 13, first: 0 }),
            frameRate: 8,
            repeat: -1
        }

        var playerBack = 
        {
            key: 'playerBackIdle',
            frames: this.anims.generateFrameNumbers('playerBack', { start: 0, end: 3, first: 0 }),
            frameRate: 4,
            repeat: -1
        }

        this.anims.create(goblinIdle);
        this.anims.create(playerBack);
    
        this.gob = this.physics.add.sprite(0, 120, 'firegoblin').play('goblinidle');
        this.gob.setScale(6)
        this.gob.setFlipX(true)

        this.player = this.physics.add.sprite(1600, 600, 'playerBack').play('playerBackIdle')
        this.player.setScale(7)

        this.playerSlide = this.tweens.add({
                targets: this.player,
                x:350,
                ease: 'Power0',
                duration: 1000,
                yoyo: false,
                repeat: 0,
        })

        this.enemySlide = this.tweens.add({
            targets: this.gob,
            x:1100,
            ease: 'Power0',
            duration: 1000,
            yoyo: false,
            repeat: 0,
         })

        this.label = this.add.text(0, 0, '(x, y)', { fontFamily: '"Monospace"'});
        this.pointer = this.input.activePointer;

    }

    update()
    {
        this.label.setText('(' + this.pointer.x + ', ' + this.pointer.y + ')');
        // enemyHp = this.goblinHealth 
        // if(enemyHp > 1)
        // {
        //     enemyHp -= 2
        // }

        // if(playerHp > 1)
        // {
        //     playerHp -= 2
        // }
    }
}



class playScene extends Phaser.Scene
{

    constructor ()
    {
        super('game');
    }


    // called once after the preload ends
    create() 
    {
        this.walkingSpeed = 90
        this.isWalking = false
        this.fightTimer = 0
        this.randomVar = 200

        this.keys = this.input.keyboard.addKeys({
            a:  Phaser.Input.Keyboard.KeyCodes.A,
            s:  Phaser.Input.Keyboard.KeyCodes.S,
            d:  Phaser.Input.Keyboard.KeyCodes.D,
            w:  Phaser.Input.Keyboard.KeyCodes.W
        });

        this.num1 = 220
        this.num2 = 130
        this.num3 = 90


        this.cursors = this.input.keyboard.createCursorKeys();
        this.cameras.main.zoom = 3;
        this.cameras.main.backgroundColor.setTo(this.num1, this.num2, this.num3);


        // forestAmbience = this.sound.add("forestAmb", { loop: true });


        this.mapTest = this.make.tilemap({key: 'tilemap'})
        this.tilesetTest = this.mapTest.addTilesetImage('city','tile', 32, 32)

        this.mapTest.createLayer('walk', this.tilesetTest)
        this.mapTest.createLayer('walkOver', this.tilesetTest)
        this.mapTest.createLayer('walkOver2', this.tilesetTest)
        this.collide = this.mapTest.createLayer('collide', this.tilesetTest)



        this.collide.setCollisionBetween(4,12);


        var playerIdle = {
        key: 'playerIdle',
        frames: this.anims.generateFrameNumbers('player', { start: 0, end: 10, first: 0 }),
        frameRate: 3,
        repeat: -1
        }

        // var playerWalking = {
        //     key: 'playerWalking',
        //     frames: this.anims.generateFrameNumbers('player', { start: 4, end: 10, first: 4 }),
        //     frameRate: 16,
        //     repeat: -1
        // }

        // var goblinIdle = {
        //     key: 'goblinIdle',
        //     frames: this.anims.generateFrameNumbers('fireGoblin', { start: 0, end: 14, first: 0 }),
        //     frameRate: 4,
        //     repeat: -1
        // }
        // this.anims.create(goblinIdle);

        this.anims.create(playerIdle);
        // this.anims.create(playerWalking);


        this.player = this.physics.add.sprite(playerX, playerY, 'player')//.play('playerIdle');

        this.player.setScale(0.75)
        this.player.setSize(24,24,0)
        this.player.setOffset(4,40)

        this.physics.add.collider(this.player, this.collide);

        // this.add.image('mmapBord',600, 0)

        this.minimap =this.cameras.add(1250, 30, 300, 300).setZoom(0.4).setName('mini');

        this.minimap.backgroundColor.setTo(37, 105, 28);

    


            
    };

    // this is called up to 60 times per second
    update()
    {
        this.cameras.main.centerOn(this.player.x, this.player.y);
        this.minimap.centerOn(this.player.x,this.player.y)
        playerX = this.player.x
        playerY = this.player.y

        localStorage.setItem('x', playerX)
        localStorage.setItem('y', playerY)

        console.log(this.isWalking,this.fightTimer,this.randomVar )

        // this.num1+= 50
        // this.num2+= 50
        // this.num3+= 50

        this.cameras.main.backgroundColor.setTo(this.num1, this.num2, this.num3);


                    
        if (this.keys.a.isDown)
        {
            this.player.setVelocityX(-this.walkingSpeed);
            this.player.setVelocityY(0);
            this.player.setFlipX(true);
            // this.player.anims.play('playerWalking', true)
            this.isWalking = true
        }
        else if (this.keys.d.isDown)
        {
            this.player.setVelocityX(this.walkingSpeed);
            this.player.setVelocityY(0);
            this.player.setFlipX(false);
            // this.player.anims.play('playerWalking', true)
            this.isWalking = true

        }
        else if (this.keys.s.isDown)
        {
            this.player.setVelocityY(this.walkingSpeed);
            this.player.setVelocityX(0);
            // this.player.anims.play('playerWalking', true)
            this.isWalking = true

        }
        else if (this.keys.w.isDown)
        {
            this.player.setVelocityY(-this.walkingSpeed);
            this.player.setVelocityX(0);
            // this.player.anims.play('playerWalking', true)
            this.isWalking = true
        }
        else
        {
            this.player.setVelocityX(0);
            this.player.setVelocityY(0);
            // this.player.anims.play('playerIdle', true)
            this.isWalking = false
            this.randomVar = Math.floor((Math.random() * 100) + 300);
        }

        if(this.isWalking == true)
        {
            this.fightTimer = this.fightTimer + 1
        }

        if(this.fightTimer == this.randomVar,this.fightTimer > this.randomVar)
        {
            this.walkingSpeed = 0
            this.fightTimer = 0
            fTimer = 0
            this.cameras.main.fadeOut(400, 0, 0, 0)

            this.cameras.main.once(Phaser.Cameras.Scene2D.Events.FADE_OUT_COMPLETE, (cam, effect) => {
                this.scene.start('fight').launch('battleUi'),this.scene.stop('hud')
            })
            // this.scene.start('fight'),this.scene.stop('hud')
        }


    };

}

class uiScene extends Phaser.Scene
{

    constructor ()
    {
        super('hud');
    }

    // preload()
    // {
    //     this.load.image('mmapBord', 'assets/miniMapBorder.png')
    // }

    create()
    {
        this.scene.bringToTop();
        this.goblins = this.physics.add.group()
        this.add.image(1400, 180,'mmapBord')

        this.menuButton = this.add.image(150,40, 'menuButton')
        this.menuButton.setInteractive()
        this.menuButton.setScale(0.5)

    

        this.menuButton.on('pointerover', ()=> {this.menuButton.setTint(0x51e883)})
        this.menuButton.on('pointerout', ()=> {this.menuButton.setTint(0xffffff)})
        this.menuButton.on('pointerdown', ()=> {this.scene.start('fight').launch('battleUi'),this.scene.stop('game')})

    }
}




// set the configuration of the game
let config = {
  type: Phaser.WEBGL, // Phaser will use WebGL if available, if not it will use Canvas
  width: 1600,
  height: 900,
  pixelArt: true,
  transparent: true,
  physics: {
    default: 'arcade',
    arcade: {
      gravity: { y: 0 },
      debug: false
    }
  },
  scene:  [ bootScene, mainMenuScene, menuScene, fightScene, uiScene, playScene, battleUi ]

};

// create a new game, pass the configuration
let game = new Phaser.Game(config);
