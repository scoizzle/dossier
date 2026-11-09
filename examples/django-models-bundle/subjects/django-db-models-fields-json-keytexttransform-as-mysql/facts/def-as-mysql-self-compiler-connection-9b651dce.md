# Fact 9b651dce

Store id: 62c96508-187c-4a70-9588-f8ee03a17573

## Text

```text
def as_mysql(self, compiler, connection)
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
- posted_at: `2026-11-09T23:44:51.0297140+00:00`

## Data

```json
{
  "end_line": 557,
  "entity_kind": "method",
  "parent": "KeyTextTransform",
  "start_line": 545,
  "symbol": "KeyTextTransform.as_mysql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":545,"selector":"L545-L557","symbol":"KeyTextTransform.as_mysql"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::KeyTextTransform.as_mysql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 557,
    "entity_kind": "method",
    "parent": "KeyTextTransform",
    "start_line": 545,
    "symbol": "KeyTextTransform.as_mysql"
  },
  "id": "62c96508-187c-4a70-9588-f8ee03a17573",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.0297140+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 545,
        "selector": "L545-L557",
        "symbol": "KeyTextTransform.as_mysql"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "c6d515db-7c9e-4363-af3c-ccd7b25d09b7",
  "subject_name": "django/db/models/fields/json::KeyTextTransform.as_mysql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_mysql(self, compiler, connection)"
}
```
