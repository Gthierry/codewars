# The solution is a novice solution but without using any AI
# I just want to do thing from scratch without using text.endswith(ending)
def solution(text, ending):
    # declaration booleen à à false
    result = False
    # Si text plus petit que ending, d'office return false
    if len(text) < len(ending):
        return result
    # s'ils contiennent des caractères
    if len(text) > 0 and len(ending) > 0:
        # decla d'un int à 0 pour la boucle
        i = 0
        # decla d'un index negatif démarrant à -1
        negative_index = -1
        # boucle sur le ending en utilisant l'index negatif
        for i in range(len(ending)):
            # Verification caractère par caractère, si egal result est vrai
            if text[negative_index] == ending[negative_index]:
                print(text[negative_index] + " == " + ending[negative_index])
                result = True
                negative_index -= 1
            # s'il y a un faux alors result faux
            else:
                result = False

        return result


solution("samourai", "ai")
