# Fact 87d6b446

Store id: d4c6b297-2ef5-45af-be6f-8e64e0cfc916

## Text

```text
def check(self, model, connection)
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
- posted_at: `2026-11-09T23:44:54.6711930+00:00`

## Data

```json
{
  "end_line": 175,
  "entity_kind": "method",
  "parent": "Index",
  "start_line": 86,
  "symbol": "Index.check"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/indexes.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":86,"selector":"L86-L175","symbol":"Index.check"}`

## Items

```json
[
  {
    "text": "Check fields, names, and conditions of indexes.",
    "locator": {
      "line": 87
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/indexes::Index.check](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 175,
    "entity_kind": "method",
    "parent": "Index",
    "start_line": 86,
    "symbol": "Index.check"
  },
  "id": "d4c6b297-2ef5-45af-be6f-8e64e0cfc916",
  "items": [
    {
      "locator": {
        "line": 87
      },
      "text": "Check fields, names, and conditions of indexes."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.6711930+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 86,
        "selector": "L86-L175",
        "symbol": "Index.check"
      },
      "rel": "derived_from",
      "target": "django/db/models/indexes.py"
    }
  ],
  "status": "live",
  "subject_id": "6d34550a-a615-438c-b134-c4de1e2fe547",
  "subject_name": "django/db/models/indexes::Index.check",
  "tags": [
    "entity:method"
  ],
  "text": "def check(self, model, connection)"
}
```
