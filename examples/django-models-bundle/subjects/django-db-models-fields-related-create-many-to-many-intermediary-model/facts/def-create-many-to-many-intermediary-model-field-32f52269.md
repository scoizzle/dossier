# Fact 32f52269

Store id: 53bbd1a7-6a5d-41b4-9177-ab3625cac5e0

## Text

```text
def create_many_to_many_intermediary_model(field, klass)
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
- posted_at: `2026-11-09T23:44:51.6248160+00:00`

## Data

```json
{
  "end_line": 1455,
  "entity_kind": "function",
  "parent": "related",
  "start_line": 1401,
  "symbol": "create_many_to_many_intermediary_model"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1401,"selector":"L1401-L1455","symbol":"create_many_to_many_intermediary_model"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::create_many_to_many_intermediary_model](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1455,
    "entity_kind": "function",
    "parent": "related",
    "start_line": 1401,
    "symbol": "create_many_to_many_intermediary_model"
  },
  "id": "53bbd1a7-6a5d-41b4-9177-ab3625cac5e0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.6248160+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1401,
        "selector": "L1401-L1455",
        "symbol": "create_many_to_many_intermediary_model"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "3b62f803-a406-452d-8fcf-f873639b65b2",
  "subject_name": "django/db/models/fields/related::create_many_to_many_intermediary_model",
  "tags": [
    "entity:function"
  ],
  "text": "def create_many_to_many_intermediary_model(field, klass)"
}
```
