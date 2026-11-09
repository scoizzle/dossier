# Fact d1ce73f2

Store id: 6a87169c-d522-41cc-9626-d2a1523bdd3c

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
- posted_at: `2026-11-09T23:44:48.9179750+00:00`

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
  "id": "6a87169c-d522-41cc-9626-d2a1523bdd3c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.9179750+00:00"
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
      "target": "7f8a2d4c-190d-450c-8994-cad55519d55c"
    }
  ],
  "status": "live",
  "subject_id": "64ffe9c5-9ade-4b8f-a82d-b80d0ea921ae",
  "subject_name": "django/db/models/deletion",
  "tags": [
    "entity:function"
  ],
  "text": "contains function get_candidate_relations_to_delete"
}
```
