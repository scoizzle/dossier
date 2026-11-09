# Fact e2ff16ca

Store id: 1d6edad0-9184-48f1-bd64-074a24a958b5

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
- posted_at: `2026-11-09T23:44:50.4864380+00:00`

## Data

```json
{
  "end_line": 98,
  "entity_kind": "method",
  "parent": "CompositePrimaryKey",
  "start_line": 97,
  "symbol": "CompositePrimaryKey.get_attname_column"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/composite.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":97,"selector":"L97-L98","symbol":"CompositePrimaryKey.get_attname_column"}`

## Referenced by

None.

## Subject

[django/db/models/fields/composite::CompositePrimaryKey.get_attname_column](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 98,
    "entity_kind": "method",
    "parent": "CompositePrimaryKey",
    "start_line": 97,
    "symbol": "CompositePrimaryKey.get_attname_column"
  },
  "id": "1d6edad0-9184-48f1-bd64-074a24a958b5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.4864380+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 97,
        "selector": "L97-L98",
        "symbol": "CompositePrimaryKey.get_attname_column"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/composite.py"
    }
  ],
  "status": "live",
  "subject_id": "471783ed-0108-431b-82f9-fe530b36a410",
  "subject_name": "django/db/models/fields/composite::CompositePrimaryKey.get_attname_column",
  "tags": [
    "entity:method"
  ],
  "text": "def get_attname_column(self)"
}
```
