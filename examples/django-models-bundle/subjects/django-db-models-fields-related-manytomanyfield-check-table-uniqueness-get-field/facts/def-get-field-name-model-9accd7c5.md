# Fact 9accd7c5

Store id: 351135af-095f-4034-b961-28afe81584de

## Text

```text
def _get_field_name(model)
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
- posted_at: `2026-11-09T23:44:51.6417690+00:00`

## Data

```json
{
  "end_line": 1878,
  "entity_kind": "function",
  "parent": "ManyToManyField._check_table_uniqueness",
  "start_line": 1875,
  "symbol": "ManyToManyField._check_table_uniqueness._get_field_name"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1875,"selector":"L1875-L1878","symbol":"ManyToManyField._check_table_uniqueness._get_field_name"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ManyToManyField._check_table_uniqueness._get_field_name](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1878,
    "entity_kind": "function",
    "parent": "ManyToManyField._check_table_uniqueness",
    "start_line": 1875,
    "symbol": "ManyToManyField._check_table_uniqueness._get_field_name"
  },
  "id": "351135af-095f-4034-b961-28afe81584de",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.6417690+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1875,
        "selector": "L1875-L1878",
        "symbol": "ManyToManyField._check_table_uniqueness._get_field_name"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "eca92524-6d01-4bd9-8e42-f4f077915b23",
  "subject_name": "django/db/models/fields/related::ManyToManyField._check_table_uniqueness._get_field_name",
  "tags": [
    "entity:function"
  ],
  "text": "def _get_field_name(model)"
}
```
