import { ASPNETBOILERPLATETemplatePage } from './app.po';

describe('ASPNETBOILERPLATE App', function() {
  let page: ASPNETBOILERPLATETemplatePage;

  beforeEach(() => {
    page = new ASPNETBOILERPLATETemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
