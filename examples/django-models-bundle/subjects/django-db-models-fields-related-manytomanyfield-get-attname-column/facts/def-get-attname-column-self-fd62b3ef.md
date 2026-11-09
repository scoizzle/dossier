# Fact fd62b3ef

Store id: 9d213063-4240-4886-b07d-debac3bf3d9f

## Text

```text
def get_attname_column(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:51.6471490+00:00`

## Data

```json
{
  "end_line": 1993,
  "entity_kind": "method",
  "parent": "ManyToManyField",
  "start_line": 1991,
  "symbol": "ManyToManyField.get_attname_column"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1991,"selector":"L1991-L1993","symbol":"ManyToManyField.get_attname_column"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ManyToManyField.get_attname_column](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1993,
    "entity_kind": "method",
    "parent": "ManyToManyField",
    "start_line": 1991,
    "symbol": "ManyToManyField.get_attname_column"
  },
  "id": "9d213063-4240-4886-b07d-debac3bf3d9f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.6471490+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1991,
        "selector": "L1991-L1993",
        "symbol": "ManyToManyField.get_attname_column"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "4f2dca21-2088-430a-a0bc-0d71b426cb98",
  "subject_name": "django/db/models/fields/related::ManyToManyField.get_attname_column",
  "tags": [
    "entity:method"
  ],
  "text": "def get_attname_column(self)"
}
```
