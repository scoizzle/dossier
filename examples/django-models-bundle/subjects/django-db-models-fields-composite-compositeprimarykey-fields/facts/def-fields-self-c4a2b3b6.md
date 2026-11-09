# Fact c4a2b3b6

Store id: a42f75cd-c7ea-4036-b1ca-05f014cb764f

## Text

```text
def fields(self)
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
- posted_at: `2026-11-09T23:31:57.1238720+00:00`

## Data

```json
{
  "end_line": 86,
  "entity_kind": "method",
  "parent": "CompositePrimaryKey",
  "start_line": 83,
  "symbol": "CompositePrimaryKey.fields"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/composite.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":83,"selector":"L83-L86","symbol":"CompositePrimaryKey.fields"}`

## Referenced by

None.

## Subject

[django/db/models/fields/composite::CompositePrimaryKey.fields](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 86,
    "entity_kind": "method",
    "parent": "CompositePrimaryKey",
    "start_line": 83,
    "symbol": "CompositePrimaryKey.fields"
  },
  "id": "a42f75cd-c7ea-4036-b1ca-05f014cb764f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.1238720+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 83,
        "selector": "L83-L86",
        "symbol": "CompositePrimaryKey.fields"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/composite.py"
    }
  ],
  "status": "live",
  "subject_id": "0f0e7128-1623-469a-9930-b33dd854ca89",
  "subject_name": "django/db/models/fields/composite::CompositePrimaryKey.fields",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def fields(self)"
}
```
