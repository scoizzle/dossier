# Fact d1b6878d

Store id: 329a0b04-3d3d-4009-81f0-85783de561d9

## Text

```text
def reverse_path_infos(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:cached_property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:44.3568420+00:00`

## Data

```json
{
  "end_line": 929,
  "entity_kind": "method",
  "parent": "ForeignObject",
  "start_line": 927,
  "symbol": "ForeignObject.reverse_path_infos"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":927,"selector":"L927-L929","symbol":"ForeignObject.reverse_path_infos"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ForeignObject.reverse_path_infos](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 929,
    "entity_kind": "method",
    "parent": "ForeignObject",
    "start_line": 927,
    "symbol": "ForeignObject.reverse_path_infos"
  },
  "id": "329a0b04-3d3d-4009-81f0-85783de561d9",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.3568420+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 927,
        "selector": "L927-L929",
        "symbol": "ForeignObject.reverse_path_infos"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "5cfea9b4-01bc-4536-9be7-1ef41d4af499",
  "subject_name": "django/db/models/fields/related::ForeignObject.reverse_path_infos",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def reverse_path_infos(self)"
}
```
