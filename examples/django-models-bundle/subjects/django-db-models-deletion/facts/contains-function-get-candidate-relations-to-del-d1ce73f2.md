# Fact d1ce73f2

Store id: 3f3ef99f-5cb4-4d4a-9858-e13538302625

## Text

```text
contains function get_candidate_relations_to_delete
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:function`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:41.0946700+00:00`

## Refs

- rel: contains
  - kind: subject
  - target: [django/db/models/deletion::get_candidate_relations_to_delete](../../django-db-models-deletion-get-candidate-relations-to-delete/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":106,"symbol":"get_candidate_relations_to_delete"}`

## Referenced by

None.

## Subject

[django/db/models/deletion](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "3f3ef99f-5cb4-4d4a-9858-e13538302625",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.0946700+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "subject",
      "locator": {
        "line": 106,
        "symbol": "get_candidate_relations_to_delete"
      },
      "rel": "contains",
      "target": "e016def7-b47a-4a12-b4c7-65d4a737e282"
    }
  ],
  "status": "live",
  "subject_id": "9dd01ff9-dc4a-434f-bc10-89b57d3d6bb3",
  "subject_name": "django/db/models/deletion",
  "tags": [
    "entity:function"
  ],
  "text": "contains function get_candidate_relations_to_delete"
}
```
