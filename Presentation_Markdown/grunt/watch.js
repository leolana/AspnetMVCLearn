// Watch updates and run predefined tasks
//
// grunt-contrib-watch: <https://github.com/gruntjs/grunt-contrib-watch>

'use strict';

module.exports = {

  // Reload Grunt config
  grunt: {
    files: [
      'Gruntfile.js',
      'grunt/*.js'
    ],
    options: {
      reload: true
    }
  },

  // Inject Bower components
  bower: {
    files: ['bower.json'],
    tasks: ['wiredep']
  },
  template: {
    files: ['<%= path.template %>/template.html'],
    tasks: ['markdown']
  },

  // Compile Markdown
  markdown: {
    files: ['<%= path.markups %>/**/*.md'],
    tasks: ['markdown']
  }

};
