# Fact d1ce73f2

Store id: 21dd9faf-57a8-4deb-afd2-6d405fedd321

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
- posted_at: `2026-11-09T23:31:55.1285340+00:00`

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
  "id": "21dd9faf-57a8-4deb-afd2-6d405fedd321",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.1285340+00:00"
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
      "target": "005f9048-056e-4164-9d30-ad2bd8ee3506"
    }
  ],
  "status": "live",
  "subject_id": "c6ec8df1-dcd1-4e95-abda-df3f68ba6875",
  "subject_name": "django/db/models/deletion",
  "tags": [
    "entity:function"
  ],
  "text": "contains function get_candidate_relations_to_delete"
}
```
